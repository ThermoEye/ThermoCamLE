using System;
using System.Drawing;
using System.Windows.Forms;
using ThermoEngine;

namespace ThermoCamSDK
{
    public partial class MainForm
    {
        RoiManager roiManager = new RoiManager();

        private void button_RemoveAllRoi_Click(object sender, EventArgs e)
        {
            roiManager?.Items.Clear();
        }

        private string GetTempStringUnit(double raw)
        {
            string strTemp = string.Empty;
            if(mCamera != null && mCamera.IsOpen)
            {
                switch(mCamera.TempUnit)
                {
                    case TempUnit.Raw:
                        strTemp = string.Format("{0:0} {1}", raw, mCamera.TempUnitSymbol);
                        break;
                    case TempUnit.Celsius:
                        strTemp = string.Format("{0:0.00} {1}", mCamera.GetTemperature(raw), mCamera.TempUnitSymbol);
                        break;
                    case TempUnit.Fahrenheit:
                        strTemp = string.Format("{0:0.00} {1}", mCamera.GetTemperature(raw), mCamera.TempUnitSymbol);
                        break;
                    case TempUnit.Kelvin:
                        strTemp = string.Format("{0:0.00} {1}", mCamera.GetTemperature(raw), mCamera.TempUnitSymbol);
                        break;
                }
            }
            return strTemp;
        }

        private void DrawShapeObjects(Bitmap bitmap)
        {
            if (bitmap == null) return;

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                if (g == null) return;
                // Draw Roi items
                using (Font font = new Font("Verdana", 7))
                {
                    string strDraw;
                    SizeF sizeDraw;

                    foreach (var item in roiManager.Items)
                    {
                        switch (item.RoiType)
                        {
                            case RoiType.Spot:
                                {
                                    var shape = (RoiSpot)item;
                                    // draw shape
                                    g.DrawEllipse(new Pen(Color.Cyan, 1), shape.Spot.X - 1, shape.Spot.Y - 1, 2, 2);
                                    // draw object id
                                    strDraw = $"ROI{shape.Index}";
                                    sizeDraw = g.MeasureString(strDraw, font);
                                    g.DrawString(strDraw, font, Brushes.Cyan, shape.Spot.X - sizeDraw.Width/2, shape.Spot.Y - 14);
                                    // draw temp
                                    strDraw = GetTempStringUnit(shape.MaxLoc.Value);
                                    sizeDraw = g.MeasureString(strDraw, font);
                                    g.DrawString(strDraw, font, Brushes.Green, shape.Spot.X - sizeDraw.Width/2, shape.Spot.Y + 6);
                                }
                                break;
                            case RoiType.Line:
                                {
                                    var shape = (RoiLine)item;
                                    // draw shape
                                    g.DrawLine(new Pen(Color.GreenYellow, 1), shape.Start.X, shape.Start.Y, shape.End.X, shape.End.Y);
                                    // draw object id
                                    strDraw = $"ROI{shape.Index}";
                                    g.DrawString(strDraw, font, Brushes.Cyan, shape.Start.X, shape.Start.Y - 14);
                                    // draw max temp
                                    g.FillPolygon(Brushes.OrangeRed, new Point[] { new Point(shape.MaxLoc.Location.X, shape.MaxLoc.Location.Y), new Point(shape.MaxLoc.Location.X - 4, shape.MaxLoc.Location.Y - 4), new Point(shape.MaxLoc.Location.X + 4, shape.MaxLoc.Location.Y - 4) });
                                    strDraw = GetTempStringUnit(shape.MaxLoc.Value);
                                    sizeDraw = g.MeasureString(strDraw, font);
                                    g.DrawString(strDraw, font, Brushes.OrangeRed, shape.MaxLoc.Location.X - sizeDraw.Width/2, shape.MaxLoc.Location.Y - 16);
                                    // draw min temp
                                    g.FillPolygon(Brushes.DodgerBlue, new Point[] { new Point(shape.MinLoc.Location.X, shape.MinLoc.Location.Y), new Point(shape.MinLoc.Location.X - 4, shape.MinLoc.Location.Y + 4), new Point(shape.MinLoc.Location.X + 4, shape.MinLoc.Location.Y + 4) });
                                    strDraw = GetTempStringUnit(shape.MinLoc.Value);
                                    sizeDraw = g.MeasureString(strDraw, font);
                                    g.DrawString(strDraw, font, Brushes.DodgerBlue, shape.MinLoc.Location.X - sizeDraw.Width/2, shape.MinLoc.Location.Y + 4);
                                }
                                break;
                            case RoiType.Rect:
                                {
                                    var shape = (RoiRect)item;
                                    // draw shape
                                    g.DrawRectangle(new Pen(Color.Red, 1), shape.Rect);
                                    // draw object id
                                    strDraw = $"ROI{shape.Index}";
                                    g.DrawString(strDraw, font, Brushes.Cyan, shape.Rect.X, shape.Rect.Y - 14);
                                    // draw max temp
                                    g.FillPolygon(Brushes.OrangeRed, new Point[] { new Point(shape.MaxLoc.Location.X, shape.MaxLoc.Location.Y), new Point(shape.MaxLoc.Location.X - 4, shape.MaxLoc.Location.Y - 4), new Point(shape.MaxLoc.Location.X + 4, shape.MaxLoc.Location.Y - 4) });
                                    strDraw = GetTempStringUnit(shape.MaxLoc.Value);
                                    sizeDraw = g.MeasureString(strDraw, font);
                                    g.DrawString(strDraw, font, Brushes.OrangeRed, shape.MaxLoc.Location.X - sizeDraw.Width/2, shape.MaxLoc.Location.Y - 16);
                                    // draw min temp
                                    g.FillPolygon(Brushes.DodgerBlue, new Point[] { new Point(shape.MinLoc.Location.X, shape.MinLoc.Location.Y), new Point(shape.MinLoc.Location.X - 4, shape.MinLoc.Location.Y + 4), new Point(shape.MinLoc.Location.X + 4, shape.MinLoc.Location.Y + 4) });
                                    strDraw = GetTempStringUnit(shape.MinLoc.Value);
                                    sizeDraw = g.MeasureString(strDraw, font);
                                    g.DrawString(strDraw, font, Brushes.DodgerBlue, shape.MinLoc.Location.X - sizeDraw.Width / 2, shape.MinLoc.Location.Y + 4);
                                }
                                break;
                            case RoiType.Ellipse:
                                {
                                    var shape = (RoiEllipse)item;
                                    // draw shape
                                    g.DrawEllipse(new Pen(Color.DarkOrange, 1), (item as RoiEllipse).Ellipse);
                                    // draw object id
                                    strDraw = $"ROI{shape.Index}";
                                    sizeDraw = g.MeasureString(strDraw, font);
                                    g.DrawString(strDraw, font, Brushes.Cyan, shape.Ellipse.X + shape.Ellipse.Width/2 - sizeDraw.Width/2, shape.Ellipse.Y - 14);
                                    // draw max temp
                                    g.FillPolygon(Brushes.OrangeRed, new Point[] { new Point(shape.MaxLoc.Location.X, shape.MaxLoc.Location.Y), new Point(shape.MaxLoc.Location.X - 4, shape.MaxLoc.Location.Y - 4), new Point(shape.MaxLoc.Location.X + 4, shape.MaxLoc.Location.Y - 4) });
                                    strDraw = GetTempStringUnit(shape.MaxLoc.Value);
                                    sizeDraw = g.MeasureString(strDraw, font);
                                    g.DrawString(strDraw, font, Brushes.OrangeRed, shape.MaxLoc.Location.X - sizeDraw.Width/2, shape.MaxLoc.Location.Y - 16);
                                    // draw min temp
                                    g.FillPolygon(Brushes.DodgerBlue, new Point[] { new Point(shape.MinLoc.Location.X, shape.MinLoc.Location.Y), new Point(shape.MinLoc.Location.X - 4, shape.MinLoc.Location.Y + 4), new Point(shape.MinLoc.Location.X + 4, shape.MinLoc.Location.Y + 4) });
                                    strDraw = GetTempStringUnit(shape.MinLoc.Value);
                                    sizeDraw = g.MeasureString(strDraw, font);
                                    g.DrawString(strDraw, font, Brushes.DodgerBlue, shape.MinLoc.Location.X - sizeDraw.Width/2, shape.MinLoc.Location.Y + 4);
                                }
                                break;
                            case RoiType.Polygon:
                                break;
                        }

                    }

                }
            }
        }

        private void radioButton_Shape_Selected(object sender, EventArgs e)
        {
            if (sender is RadioButton btn && btn.Checked == true)
            {
                switch(btn.Name)
                {
                    case "radioButton_ShapeCursor":
                        roiManager.SelectedType = RoiType.Hand;
                        break;
                    case "radioButton_ShapeSpot":
                        roiManager.SelectedType = RoiType.Spot;
                        break;
                    case "radioButton_ShapeLine":
                        roiManager.SelectedType = RoiType.Line;
                        break;
                    case "radioButton_ShapeRectangle":
                        roiManager.SelectedType = RoiType.Rect;
                        break;
                    case "radioButton_ShapeEllipse":
                        roiManager.SelectedType = RoiType.Ellipse;
                        break;
                    case "radioButton_ShapePolygon":
                        roiManager.SelectedType = RoiType.Polygon;
                        break;
                }
            }
        }

        private void pictureBox_Preview_MouseDown(object sender, MouseEventArgs e)
        {
            if(sender is PictureBox box)
            {
                if(e.Button == MouseButtons.Left)
                {
                    roiManager.MouseDown(sender, e.Location);
                }
            }
        }

        private void pictureBox_Preview_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox box)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (roiManager.MouseMove(sender, e.Location)) box.Refresh();
                }
            }
        }

        private void pictureBox_Preview_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox box)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (roiManager.MouseUp(sender, e.Location)) radioButton_ShapeCursor.Checked = true;
                }
            }
        }

        private void pictureBox_Preview_Paint(object sender, PaintEventArgs e)
        {
            if (e != null && roiManager.SelectedItem != null)
            {
                // mouse drawing...
                if (roiManager.SelectedItem != null)
                {
                    using (Pen pen = new Pen(Color.Yellow, 1))
                    {
                        switch (roiManager.SelectedType)
                        {
                            case RoiType.Hand:
                                break;
                            case RoiType.Spot:
                                {
                                    var shape = (RoiSpot)roiManager.SelectedItem;
                                    e.Graphics.DrawEllipse(pen, shape.Spot.X - 1, shape.Spot.Y - 1, 2, 2);
                                }
                                break;
                            case RoiType.Line:
                                {
                                    var shape = (RoiLine)roiManager.SelectedItem;
                                    e.Graphics.DrawLine(pen, shape.Start.X, shape.Start.Y, shape.End.X, shape.End.Y);
                                }
                                break;
                            case RoiType.Rect:
                                {
                                    var shape = (RoiRect)roiManager.SelectedItem;
                                    e.Graphics.DrawRectangle(pen, shape.Rect);
                                }
                                break;
                            case RoiType.Ellipse:
                                {
                                    var shape = (RoiEllipse)roiManager.SelectedItem;
                                    e.Graphics.DrawEllipse(pen, shape.Ellipse);
                                }
                                break;
                        }
                    }
                }
            }
        }
    }
}