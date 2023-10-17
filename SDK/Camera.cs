using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using ThermoEngine;

namespace ThermoCamSDK
{
    public partial class MainForm
    {
        ThermoEngine.Camera mCamera = default;
        private Thread captureThread = null;
        private Stopwatch stopwatch = new Stopwatch();
        private BackgroundWorker firmwareWorker;
        private double minVal, avgVal, maxVal;
        private System.Drawing.Point minLoc, maxLoc;

        #region Camera Preview
        private void frameCaptureThread()
        {
            try
            {
                this.stopwatch.Start();

                while (mCamera != null && mCamera.IsOpen == true)
                {
                    var frame = mCamera.QueryFrame(pictureBox_Preview.Width, pictureBox_Preview.Height);
                    if (frame != null)
                    {
                        // Update values
                        Invoke(new Action(() =>
                        {
                            if (mCamera != null && mCamera.IsOpen == true)
                            {
                                // measure roi items
                                frame.DoMeasure(ref roiManager.Items);

                                // get minimum and maximum values and locations
                                frame.MinMaxLoc(out minVal, out avgVal, out maxVal, out minLoc, out maxLoc);

                                var bmp = frame.ToBitmap();
                                if (bmp != null)
                                {
                                    DrawShapeObjects(bmp);
                                    if (pictureBox_Preview.Image != null) pictureBox_Preview.Image.Dispose();
                                    pictureBox_Preview.Image = bmp;
                                }

                                label_MinimumTemperature.Text = string.Format("{0:0.00} {1}", mCamera.GetTemperature(minVal), mCamera.TempUnitSymbol);
                                label_AverageTemperature.Text = string.Format("{0:0.00} {1}", mCamera.GetTemperature(avgVal), mCamera.TempUnitSymbol);
                                label_MaximumTemperature.Text = string.Format("{0:0.00} {1}", mCamera.GetTemperature(maxVal), mCamera.TempUnitSymbol);
                            }
                        }));

                        if (stopwatch.ElapsedMilliseconds != 0)
                        {
                            //StatusLabel_fps.Text = $"{1000 / stopwatch.ElapsedMilliseconds}Hz";
                        }
                        stopwatch.Restart();
                    }
                    //Thread.Sleep(1);
                }

                pictureBox_Preview.Image = null;
            }
            catch { }
        }

        private void comboBox_ColorMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mCamera != null)
            {
                mCamera.ColorMap = comboBox_ColorMap.SelectedIndex;
            }
        }

        private void comboBox_TemperatureUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mCamera != null)
            {
                mCamera.TempUnit = (TempUnit)comboBox_TemperatureUnit.SelectedIndex;
            }
        }
        #endregion

        #region Local Camera
        private void ScanLocalCameraList()
        {
            listBox_LocalCameraScanList.Tag = LocalCamera.GetCameraList();

            listBox_LocalCameraScanList.Items.Clear();
            foreach (var item in listBox_LocalCameraScanList.Tag as LocalCamInfo[])
            {
                listBox_LocalCameraScanList.Items.Add($"{item.Name}-{item.ComPort}");
            }

            if (listBox_LocalCameraScanList.Items.Count > 0)
            {
                listBox_LocalCameraScanList.SelectedIndex = 0;

                LocalCamInfo[] items = listBox_LocalCameraScanList.Tag as LocalCamInfo[];

                textBox_LocalCameraName.Text = items[listBox_LocalCameraScanList.SelectedIndex].Name;
                textBox_LocalCameraComPort.Text = items[listBox_LocalCameraScanList.SelectedIndex].ComPort;
            }
        }

        private void button_ScanLocalCamera_Click(object sender, EventArgs e)
        {
            this.ScanLocalCameraList();
        }

        private void listBox_LocalCameraList_Click(object sender, EventArgs e)
        {
            if (sender is ListBox listbox && listbox.SelectedIndex >= 0)
            {
                var items = listbox.Tag as LocalCamInfo[];
                if(items != null)
                {
                    textBox_LocalCameraName.Text = items[listbox.SelectedIndex].Name;
                    textBox_LocalCameraComPort.Text = items[listbox.SelectedIndex].ComPort;
                }
            }
        }

        private void button_ConnectLocalCamera_Click(object sender, EventArgs e)
        {
            if(sender is Button btn)
            {
                if(btn.Text == "Connect")
                {
                    if (listBox_LocalCameraScanList.SelectedIndex < 0)
                    {
                        MessageBox.Show("Invalid Camera Index.", "Connect", MessageBoxButtons.OK);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(textBox_LocalCameraName.Text))
                    {
                        MessageBox.Show("Invalid Camera Name.", "Connect", MessageBoxButtons.OK);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(textBox_LocalCameraComPort.Text))
                    {
                        MessageBox.Show("Invalid COM Port.", "Connect", MessageBoxButtons.OK);
                        return;
                    }

                    if(listBox_LocalCameraScanList.Tag == null)
                    {
                        MessageBox.Show("Invalid Camera List.", "Connect", MessageBoxButtons.OK);
                        return;
                    }

                    if (mCamera == null)
                    {
                        mCamera = new ThermoEngine.LocalCamera();
                        if (mCamera.Open((listBox_LocalCameraScanList.Tag as LocalCamInfo[])[listBox_LocalCameraScanList.SelectedIndex]))
                        {
                            this.captureThread = new Thread(new ThreadStart(frameCaptureThread));
                            this.captureThread.Start();

                            btn.Text = "Disconnect";

                            button_ScanLocalCamera.Enabled = false;
                            button_ConnectRemoteCamera.Enabled = false;
                            button_ScanRemoteCamera.Enabled = false;
                            tabControl2.Enabled = true;
                            tabControl3.Enabled = true;
                            comboBox_ColorMap.Enabled = true;
                            comboBox_TemperatureUnit.Enabled = true;

                            switch(mCamera.Name)
                            {
                                case "ThermoCam160E":
                                    groupBox_FluxParameters_160E.Visible = true;
                                    groupBox_FluxParameters_256E.Visible = false;
                                    break;

                                case "ThermoCam256E":
                                    groupBox_FluxParameters_160E.Visible = false;
                                    groupBox_FluxParameters_256E.Visible = true;
                                    break;
                            }

                            StatusLabel_Name.Text = mCamera.Name;
                            StatusLabel_CamInfo.Text = $"{mCamera.Width}x{mCamera.Height}@{mCamera.FPS}Hz";
                        }
                        else
                        {
                            MessageBox.Show("Fail to connect Local Camera.", "Connect", MessageBoxButtons.OK);
                            
                            btn.Text = "Connect";

                            button_ScanLocalCamera.Enabled = true;
                            button_ConnectRemoteCamera.Enabled = true;
                            button_ScanRemoteCamera.Enabled = true;
                            tabControl2.Enabled = false;
                            tabControl3.Enabled = false;
                            comboBox_ColorMap.Enabled = false;
                            comboBox_TemperatureUnit.Enabled = false;

                            groupBox_FluxParameters_160E.Visible = false;
                            groupBox_FluxParameters_256E.Visible = false;

                            StatusLabel_Name.Text = "";
                            StatusLabel_CamInfo.Text = "";
                            StatusLabel_fps.Text = "";
                            return;
                        }
                    }
                }
                else
                {
                    if(mCamera != null) 
                    {
                        mCamera.Close();
                        mCamera = null;

                        btn.Text = "Connect";

                        button_ScanLocalCamera.Enabled = true;
                        button_ConnectRemoteCamera.Enabled = true;
                        button_ScanRemoteCamera.Enabled = true;
                        tabControl2.Enabled = false;
                        tabControl3.Enabled = false;
                        comboBox_ColorMap.Enabled = false;
                        comboBox_TemperatureUnit.Enabled = false;

                        groupBox_FluxParameters_160E.Visible = false;
                        groupBox_FluxParameters_256E.Visible = false;

                        StatusLabel_Name.Text = "";
                        StatusLabel_CamInfo.Text = "";
                        StatusLabel_fps.Text = "";
                    }
                }
            }
        }
        #endregion

        #region RemoteCamera
        private void ScanRemoteCameraList()
        {
            listBox_RemoteCameraScanList.Tag = RemoteCamera.GetCameraList();

            listBox_RemoteCameraScanList.Items.Clear();
            foreach (var item in listBox_RemoteCameraScanList.Tag as RemoteCamInfo[] )
            {
                listBox_RemoteCameraScanList.Items.Add($"{item.Name}-{item.AddrIP}");
            }

            if (listBox_RemoteCameraScanList.Items.Count > 0)
            {
                listBox_RemoteCameraScanList.SelectedIndex = 0;

                RemoteCamInfo[] items = listBox_RemoteCameraScanList.Tag as RemoteCamInfo[];
                textBox_RemoteCameraIPAddress.Text = items[listBox_RemoteCameraScanList.SelectedIndex].AddrIP;
                textBox_RemoteCameraMACAddress.Text = items[listBox_RemoteCameraScanList.SelectedIndex].AddrMAC;
                textBox_RemoteCameraSerialNumber.Text = items[listBox_RemoteCameraScanList.SelectedIndex].SerialNumber;
                textBox_RemoteCameraName.Text = items[listBox_RemoteCameraScanList.SelectedIndex].Name;
            }
        }

        private void button_ScanRemoteCamera_Click(object sender, EventArgs e)
        {
            this.ScanRemoteCameraList();
        }

        private void listBox_RemoteCameraList_Click(object sender, EventArgs e)
        {
            if(sender is ListBox listbox && listbox.SelectedIndex >= 0)
            {
                var items = listbox.Tag as RemoteCamInfo[];
                if(items != null)
                {
                    textBox_RemoteCameraName.Text = items[listbox.SelectedIndex].Name;
                    textBox_RemoteCameraIPAddress.Text = items[listbox.SelectedIndex].AddrIP;
                    textBox_RemoteCameraMACAddress.Text = items[listbox.SelectedIndex].AddrMAC;
                    textBox_RemoteCameraSerialNumber.Text = items[listbox.SelectedIndex].SerialNumber;
                }
            }
        }

        private void button_ConnectRemoteCamera_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Text == "Connect")
                {
                    if (string.IsNullOrEmpty(textBox_RemoteCameraIPAddress.Text))
                    {
                        MessageBox.Show("Invalid AddrIP Address.", "Connect", MessageBoxButtons.OK);
                        return;
                    }

                    if (mCamera == null)
                    {
                        mCamera = new ThermoEngine.RemoteCamera();
                        if (mCamera.Open((listBox_RemoteCameraScanList.Tag as RemoteCamInfo[])[listBox_RemoteCameraScanList.SelectedIndex]))
                        {
                            this.captureThread = new Thread(new ThreadStart(frameCaptureThread));
                            this.captureThread.Start();

                            btn.Text = "Disconnect";

                            button_ScanLocalCamera.Enabled = false;
                            button_ConnectLocalCamera.Enabled = false;
                            button_ScanRemoteCamera.Enabled = false;
                            tabControl2.Enabled = true;
                            tabControl3.Enabled = true;
                            comboBox_ColorMap.Enabled = true;
                            comboBox_TemperatureUnit.Enabled = true;

                            switch(mCamera.Name)
                            {
                                case "ThermoCam160E":
                                    groupBox_FluxParameters_160E.Visible = true;
                                    groupBox_FluxParameters_256E.Visible = false;
                                    break;

                                case "ThermoCam256E":
                                    groupBox_FluxParameters_160E.Visible = false;
                                    groupBox_FluxParameters_256E.Visible = true;
                                    break;
                            }

                            StatusLabel_Name.Text = mCamera.Name;
                            StatusLabel_CamInfo.Text = $"{mCamera.Width}x{mCamera.Height}@{mCamera.FPS}Hz";
                            //StatusLabel_fps.Text = $"@{mCamera.FPS}Hz";
                        }
                        else
                        {
                            MessageBox.Show("Fail to connect Remote Camera.", "Connect", MessageBoxButtons.OK);

                            mCamera.Close();
                            mCamera = null;

                            button_ScanLocalCamera.Enabled = true;
                            button_ConnectLocalCamera.Enabled = true;
                            button_ScanRemoteCamera.Enabled = true;
                            tabControl2.Enabled = false;
                            tabControl3.Enabled = false;
                            comboBox_ColorMap.Enabled = false;
                            comboBox_TemperatureUnit.Enabled = false;

                            groupBox_FluxParameters_160E.Visible = false;
                            groupBox_FluxParameters_256E.Visible = false;

                            StatusLabel_Name.Text = "";
                            StatusLabel_CamInfo.Text = "";
                            StatusLabel_fps.Text = "";
                            return;
                        }
                    }
                }
                else
                {
                    if (mCamera != null)
                    {
                        mCamera.Close();
                        mCamera = null;

                        btn.Text = "Connect";

                        button_ScanLocalCamera.Enabled = true;
                        button_ConnectLocalCamera.Enabled = true;
                        button_ScanRemoteCamera.Enabled = true;
                        tabControl2.Enabled = false;
                        tabControl3.Enabled = false;
                        comboBox_ColorMap.Enabled = false;
                        comboBox_TemperatureUnit.Enabled = false;

                        groupBox_FluxParameters_160E.Visible = false;
                        groupBox_FluxParameters_256E.Visible = false;

                        StatusLabel_Name.Text = "";
                        StatusLabel_CamInfo.Text = "";
                        StatusLabel_fps.Text = "";
                    }

                }
            }
        }
        #endregion
    }
}
