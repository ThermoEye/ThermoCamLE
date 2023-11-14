using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ThermoCamSDK
{
    public partial class MainForm
    {
        private BackgroundWorker firmwareWorker;

        #region Product
        private void button_ProductControl_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && mCamera != null && mCamera.IsOpen)
            {
                switch (btn.Name)
                {
                    case "button_GetProductInformation":
                        string productModelName = mCamera.Control.GetProductModelName();
                        if (productModelName != null)
                        {
                            label_ProductModelName.Text = productModelName;
                        }
                        else
                        {
                            MessageBox.Show("Fail to get Product Model Name.", "Camera Information", MessageBoxButtons.OK);
                        }

                        string productSerialNumber = mCamera.Control.GetProductSerialNumber();
                        if (productSerialNumber != null)
                        {
                            label_ProductSerialNumber.Text = productSerialNumber;
                        }
                        else
                        {
                            MessageBox.Show("Fail to get Product Serial Number.", "Camera Information", MessageBoxButtons.OK);
                        }

                        string hardwareVersion = mCamera.Control.GetHardwareVersion();
                        if (hardwareVersion != null)
                        {
                            label_HardwareVersion.Text = hardwareVersion;
                        }
                        else
                        {
                            MessageBox.Show("Fail to get Hardware Version.", "Camera Information", MessageBoxButtons.OK);
                        }

                        string bootloaderVersion = mCamera.Control.GetBootloaderVersion();
                        if (bootloaderVersion != null)
                        {
                            label_BootloaderVersion.Text = bootloaderVersion;
                        }
                        else
                        {
                            MessageBox.Show("Fail to get Bootloader Version.", "Camera Information", MessageBoxButtons.OK);
                        }

                        string firmwareVersion = mCamera.Control.GetFirmwareVersion();
                        if (firmwareVersion != null)
                        {
                            label_FirmwareVersion.Text = firmwareVersion;
                        }
                        else
                        {
                            MessageBox.Show("Fail to get Firmware Version.", "Camera Information", MessageBoxButtons.OK);
                        }

                        break;

                    case "button_GetSensorInformation":
                        string sensorModelName = mCamera.Control.GetSensorModelName();
                        if (sensorModelName != null)
                        {
                            label_SensorModelName.Text = sensorModelName;
                        }
                        else
                        {
                            MessageBox.Show("Fail to get Sensor Model Name.", "Camera Information", MessageBoxButtons.OK);
                        }

                        string sensorSerialNumber = mCamera.Control.GetSensorSerialNumber();
                        if (sensorSerialNumber != null)
                        {
                            label_SensorSerialNumber.Text = sensorSerialNumber;
                        }
                        else
                        {
                            MessageBox.Show("Fail to get Sensor Serial Number.", "Camera Information", MessageBoxButtons.OK);
                        }

                        string sensorUptime = mCamera.Control.GetSensorUptime();
                        if (sensorUptime != null)
                        {
                            label_SensorUptime.Text = sensorUptime + " ms";
                        }
                        else
                        {
                            MessageBox.Show("Fail to get Sensor Uptime.", "Camera Information", MessageBoxButtons.OK);
                        }

                        break;

                    case "button_SoftwareUpdateFileBrowse":
                        OpenFileDialog openFileDialog = new OpenFileDialog
                        {
                            InitialDirectory = @"C:\",
                            Title = "Browse Firmware Binary Files",

                            CheckFileExists = true,
                            CheckPathExists = true,

                            DefaultExt = "bin",
                            Filter = "binary file (*.bin)|*.bin",
                            FilterIndex = 2,
                            RestoreDirectory = true,

                            ReadOnlyChecked = true,
                            ShowReadOnly = true
                        };

                        DialogResult result = openFileDialog.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            textBox_SoftwareUpdateFilePath.Text = openFileDialog.FileName;
                            button_StartSoftwareUpdate.Text = "Start";
                            button_StartSoftwareUpdate.Enabled = true;
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            textBox_SoftwareUpdateFilePath.Text = "";
                            button_StartSoftwareUpdate.Text = "Browse and Select binary file";
                            button_StartSoftwareUpdate.Enabled = false;
                        }

                        break;

                    case "button_StartSoftwareUpdate":
                        if (btn.Text == "Start")
                        {
                            if (this.captureThread != null && this.captureThread.IsAlive)
                            {
                                // force to terminate frameThread
                                this.captureThread.Interrupt();
                                // Wait for frameThread to end.
                                this.captureThread.Join();

                                System.Threading.Thread.Sleep(1000);
                            }

                            mCamera.Stop();
                            mCamera.Dispose();

                            btn.Text = "Wait...";
                            btn.Enabled = false;
                            button_SoftwareUpdateFileBrowse.Enabled = false;

                            if (mCamera.Control.OpenFirmware(textBox_SoftwareUpdateFilePath.Text) > 0)
                            {
                                label_SoftwareUpdateStatus.Text = "Start firmware update.";

                                firmwareWorker = new BackgroundWorker();
                                firmwareWorker.WorkerReportsProgress = true;
                                firmwareWorker.WorkerSupportsCancellation = true;
                                firmwareWorker.DoWork += new DoWorkEventHandler(update_DoWork);
                                firmwareWorker.ProgressChanged += new ProgressChangedEventHandler(update_ProgressChanged);
                                firmwareWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(update_RunWorkerCompleted);
                                firmwareWorker.RunWorkerAsync();
                            }
                            else
                            {
                                label_SoftwareUpdateStatus.Text = "File open fail.";
                            }
                        }

                        break;
                }
            }
        }

        void update_DoWork(object sender, DoWorkEventArgs e)
        {
            int percent = 0;

            if (mCamera != null && mCamera.IsOpen) return;

            while (percent < 100)
            {
                percent = mCamera.Control.UpdateFirmware();
                if (percent >= 0)
                {
                    firmwareWorker.ReportProgress(percent);
                }
                else
                {
                    Console.WriteLine("Error during download firmware.");
                    e.Cancel = true;
                    return;
                }
            }
        }

        void update_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label_SoftwareUpdateStatus.Text = string.Format("Downloading... {0}%", e.ProgressPercentage);
            progressBar_SoftwareUpdate.Value = e.ProgressPercentage;
        }

        void update_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult dr;

            if (mCamera != null && mCamera.IsOpen) return;

            bool result = mCamera.Control.CloseFirmware();

            if ((e.Cancelled) || (e.Error != null) || (result == false))
            {
                label_SoftwareUpdateStatus.Text = "Update failed.";
            }
            else
            {
                label_SoftwareUpdateStatus.Text = "Download complete. Reboot...";
            }

            System.Threading.Thread.Sleep(1000);

            mCamera.Close();
            mCamera = null;

            System.Threading.Thread.Sleep(1000);

            Application.EnableVisualStyles();
            if (result == true)
            {
                dr = MessageBox.Show("Reconnect camera device.", "Software Update", MessageBoxButtons.OK);
            }
            else
            {
                dr = MessageBox.Show("Please check firmware binary file.", "Software Update", MessageBoxButtons.OK);
            }
            switch (dr)
            {
                case DialogResult.OK:
                    label_SoftwareUpdateStatus.Text = string.Empty;
                    progressBar_SoftwareUpdate.Value = 0;
                    textBox_SoftwareUpdateFilePath.Text = string.Empty;
                    button_StartSoftwareUpdate.Text = "Browse and Select Binary File";
                    button_SoftwareUpdateFileBrowse.Enabled = true;
                    tabControl2.Enabled = false;
                    tabControl3.Enabled = false;
                    comboBox_ColorMap.Enabled = false;
                    comboBox_TemperatureUnit.Enabled = false;
                    button_ConnectLocalCamera.Enabled = false;
                    button_ScanLocalCamera.Enabled = false;
                    button_ConnectRemoteCamera.Enabled = false;
                    button_ScanRemoteCamera.Enabled = false;
                    System.Threading.Thread.Sleep(2000);
                    button_ConnectLocalCamera.Text = "Connect";
                    button_ConnectLocalCamera.Enabled = true;
                    button_ScanLocalCamera.Enabled = true;
                    button_ConnectRemoteCamera.Text = "Connect";
                    button_ConnectRemoteCamera.Enabled = true;
                    button_ScanRemoteCamera.Enabled = true;
                    break;
            }
        }
        #endregion

        #region Network
        private void button_NetworkControl_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && mCamera != null && mCamera.IsOpen)
            {
                switch (btn.Name)
                {
                    case "button_GetNetworkConfiguration":
                        if (mCamera.Control.GetNetworkConfiguration(out string mac, out string ipAssign, out string ip, out string netmask,
                                                                    out string gateway, out string dns, out string dns2))
                        {
                            textBox_MACAddress.Text = mac;
                            comboBox_IPAssignment.Text = ipAssign;
                            textBox_IPAddress.Text = ip;
                            textBox_Netmask.Text = netmask;
                            textBox_Gateway.Text = gateway;
                            textBox_MainDNSServer.Text = dns;
                            textBox_SubDNSServer.Text = dns2;

                            comboBox_IPAssignment.Enabled = true;
                            if (comboBox_IPAssignment.Text == "Static")
                            {
                                textBox_IPAddress.ReadOnly = false;
                                textBox_Netmask.ReadOnly = false;
                                textBox_Gateway.ReadOnly = false;
                            }
                            else
                            {
                                textBox_IPAddress.ReadOnly = true;
                                textBox_Netmask.ReadOnly = true;
                                textBox_Gateway.ReadOnly = true;
                            }
                            textBox_MainDNSServer.ReadOnly = true;
                            textBox_SubDNSServer.ReadOnly = true;
                            button_SetNetworkConfiguration.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Fail to get Network Configuration.", "Network", MessageBoxButtons.OK);
                        }

                        break;

                    case "button_SetNetworkConfiguration":
                        if (comboBox_IPAssignment.Text == "Static")
                        {
                            if (string.IsNullOrEmpty(textBox_IPAddress.Text) || string.IsNullOrEmpty(textBox_Netmask.Text) || string.IsNullOrEmpty(textBox_Gateway.Text))
                                return;
                        }

                        if (mCamera.Control.SetNetworkConfiguration(comboBox_IPAssignment.Text, textBox_IPAddress.Text, textBox_Netmask.Text, textBox_Gateway.Text, textBox_MainDNSServer.Text, textBox_SubDNSServer.Text))
                        {
                            MessageBox.Show("Succes to set Network Configuration.", "Network", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Fail to set Network Configuration.", "Network", MessageBoxButtons.OK);
                        }

                        break;

                    case "button_SetDefaultNetworkConfiguration":
                        if (mCamera.Control.SetDefaultNetworkConfiguration(out string ipAssignDef, out string ipDef, out string netmaskDef,
                                                                            out string gatewayDef, out string dnsDef, out string dns2Def))
                        {
                            comboBox_IPAssignment.Text = ipAssignDef;
                            textBox_IPAddress.Text = ipDef;
                            textBox_Netmask.Text = netmaskDef;
                            textBox_Gateway.Text = gatewayDef;
                            textBox_MainDNSServer.Text = dnsDef;
                            textBox_SubDNSServer.Text = dns2Def;
                        }
                        else
                        {
                            MessageBox.Show("Fail to get Factory Default", "Network", MessageBoxButtons.OK);
                        }

                        break;

                    case "button_SystemReboot":
                        if (this.captureThread != null && this.captureThread.IsAlive)
                        {
                            // force to terminate frameThread
                            this.captureThread.Interrupt();
                            // Wait for frameThread to end.
                            this.captureThread.Join();

                            System.Threading.Thread.Sleep(1000);
                        }

                        mCamera.Control.RebootDevice();

                        System.Threading.Thread.Sleep(1000);

                        mCamera.Close();
                        mCamera = null;

                        System.Threading.Thread.Sleep(1000);

                        Application.EnableVisualStyles();
                        DialogResult dr = MessageBox.Show("Reboot... Reconnect camera device.", "ThermoCamApp", MessageBoxButtons.OK);
                        switch (dr)
                        {
                            case DialogResult.OK:
                                tabControl2.Enabled = false;
                                tabControl3.Enabled = false;
                                comboBox_ColorMap.Enabled = false;
                                comboBox_TemperatureUnit.Enabled = false;
                                button_ConnectLocalCamera.Enabled = false;
                                button_ScanLocalCamera.Enabled = false;
                                button_ConnectRemoteCamera.Enabled = false;
                                button_ScanRemoteCamera.Enabled = false;
                                System.Threading.Thread.Sleep(2000);
                                button_ConnectLocalCamera.Text = "Connect";
                                button_ConnectLocalCamera.Enabled = true;
                                button_ScanLocalCamera.Enabled = true;
                                button_ConnectRemoteCamera.Text = "Connect";
                                button_ConnectRemoteCamera.Enabled = true;
                                button_ScanRemoteCamera.Enabled = true;
                                break;
                        }

                        break;
                }
            }
        }

        private void comboBox_IPAssignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_IPAssignment.SelectedIndex >= 0)
            {
                if ("Static" == comboBox_IPAssignment.SelectedItem as string)
                {
                    textBox_IPAddress.ReadOnly = false;
                    textBox_Netmask.ReadOnly = false;
                    textBox_Gateway.ReadOnly = false;
                }
                else
                {
                    textBox_IPAddress.ReadOnly = true;
                    textBox_Netmask.ReadOnly = true;
                    textBox_Gateway.ReadOnly = true;
                }
                textBox_MainDNSServer.ReadOnly = true;
                textBox_SubDNSServer.ReadOnly = true;
            }
        }
        #endregion
    }
}
