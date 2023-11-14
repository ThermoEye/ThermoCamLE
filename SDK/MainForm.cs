using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThermoCamSDK
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ScanRemoteCameraList();
            this.ScanLocalCameraList();
            comboBox_ColorMap.SelectedIndex = 15;       // Inferno
            comboBox_TemperatureUnit.SelectedIndex = 1; // Celsius
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisconnectCamera();
        }

        private void panel_VideoPreview_SizeChanged(object sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                pictureBox_Preview.Width = pictureBox_Preview.Height * 4 / 3;
                pictureBox_Preview.Location = new Point(panel.Width / 2 - pictureBox_Preview.Width / 2, pictureBox_Preview.Location.Y);

                StatusLabel_PreviewSize.Text = $"{pictureBox_Preview.Width}x{pictureBox_Preview.Height}";
                //Console.WriteLine($"Panel {panel.Width} x {panel.Height}");
            }
        }
    }
}
