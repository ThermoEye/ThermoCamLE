namespace ThermoCamSDK
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabel_Name = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel_CamInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel_fps = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel_PreviewSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_RemoteCamera = new System.Windows.Forms.TabPage();
            this.textBox_RemoteCameraMACAddress = new System.Windows.Forms.TextBox();
            this.label_RemoteCameraMACAddressTitle = new System.Windows.Forms.Label();
            this.textBox_RemoteCameraSerialNumber = new System.Windows.Forms.TextBox();
            this.label_RemoteCameraSerialNumberTitle = new System.Windows.Forms.Label();
            this.textBox_RemoteCameraName = new System.Windows.Forms.TextBox();
            this.label_RemoteCameraNameTitle = new System.Windows.Forms.Label();
            this.label_RemoteCameraIPAddressTitle = new System.Windows.Forms.Label();
            this.textBox_RemoteCameraIPAddress = new System.Windows.Forms.TextBox();
            this.button_ConnectRemoteCamera = new System.Windows.Forms.Button();
            this.listBox_RemoteCameraScanList = new System.Windows.Forms.ListBox();
            this.button_ScanRemoteCamera = new System.Windows.Forms.Button();
            this.tabPage_LocalCamera = new System.Windows.Forms.TabPage();
            this.textBox_LocalCameraComPort = new System.Windows.Forms.TextBox();
            this.textBox_LocalCameraName = new System.Windows.Forms.TextBox();
            this.listBox_LocalCameraScanList = new System.Windows.Forms.ListBox();
            this.button_ScanLocalCamera = new System.Windows.Forms.Button();
            this.label_LocalCameraComPort = new System.Windows.Forms.Label();
            this.label_LocalCameraNameTitle = new System.Windows.Forms.Label();
            this.button_ConnectLocalCamera = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage_Product = new System.Windows.Forms.TabPage();
            this.groupBox_ProductInformation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_HardwareVersion = new System.Windows.Forms.Label();
            this.label_ProductSerialNumber = new System.Windows.Forms.Label();
            this.label_ProductModelName = new System.Windows.Forms.Label();
            this.label_ProductSerialNumberTitle = new System.Windows.Forms.Label();
            this.label_ProductModelNameTitle = new System.Windows.Forms.Label();
            this.label_FirmwareVersionTitle = new System.Windows.Forms.Label();
            this.label_BootloaderVersionTitle = new System.Windows.Forms.Label();
            this.label_FirmwareVersion = new System.Windows.Forms.Label();
            this.label_BootloaderVersion = new System.Windows.Forms.Label();
            this.label_HardwareVersionTitle = new System.Windows.Forms.Label();
            this.button_GetProductInformation = new System.Windows.Forms.Button();
            this.groupBox_SensorInformation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label_SensorUptime = new System.Windows.Forms.Label();
            this.label_SensorUptimeTitle = new System.Windows.Forms.Label();
            this.label_SensorModelNameTitle = new System.Windows.Forms.Label();
            this.label_SensorSerialNumberTitle = new System.Windows.Forms.Label();
            this.label_SensorSerialNumber = new System.Windows.Forms.Label();
            this.label_SensorModelName = new System.Windows.Forms.Label();
            this.button_GetSensorInformation = new System.Windows.Forms.Button();
            this.groupBox_SoftwareUpdate = new System.Windows.Forms.GroupBox();
            this.button_SoftwareUpdateFileBrowse = new System.Windows.Forms.Button();
            this.textBox_SoftwareUpdateFilePath = new System.Windows.Forms.TextBox();
            this.button_StartSoftwareUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label_SoftwareUpdateStatus = new System.Windows.Forms.Label();
            this.progressBar_SoftwareUpdate = new System.Windows.Forms.ProgressBar();
            this.tabPage_Network = new System.Windows.Forms.TabPage();
            this.groupBox_NetworkConfiguration = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_SubDNSServer = new System.Windows.Forms.TextBox();
            this.label_SubDNSServerTitle = new System.Windows.Forms.Label();
            this.label_MACAddressTitle = new System.Windows.Forms.Label();
            this.textBox_MACAddress = new System.Windows.Forms.TextBox();
            this.button_GetNetworkConfiguration = new System.Windows.Forms.Button();
            this.label_IPAssignmentTitle = new System.Windows.Forms.Label();
            this.label_IPAddressTitle = new System.Windows.Forms.Label();
            this.label_NetmaskTitle = new System.Windows.Forms.Label();
            this.label_GatewayNameTitle = new System.Windows.Forms.Label();
            this.textBox_IPAddress = new System.Windows.Forms.TextBox();
            this.textBox_Netmask = new System.Windows.Forms.TextBox();
            this.textBox_Gateway = new System.Windows.Forms.TextBox();
            this.textBox_MainDNSServer = new System.Windows.Forms.TextBox();
            this.button_SetNetworkConfiguration = new System.Windows.Forms.Button();
            this.comboBox_IPAssignment = new System.Windows.Forms.ComboBox();
            this.label_MainDNSServerTitle = new System.Windows.Forms.Label();
            this.button_SystemReboot = new System.Windows.Forms.Button();
            this.button_SetDefaultNetworkConfiguration = new System.Windows.Forms.Button();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage_SensorControl = new System.Windows.Forms.TabPage();
            this.panel_SensorControl_256E = new System.Windows.Forms.Panel();
            this.groupBox_FFCParameters_256E = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label_FFCParam256E_MaxIntervalTitle = new System.Windows.Forms.Label();
            this.textBox_FFCParam256E_MaxIntervalRange = new System.Windows.Forms.TextBox();
            this.button_GetFFCParameters_256E = new System.Windows.Forms.Button();
            this.button_SetFFCParameters_256E = new System.Windows.Forms.Button();
            this.numericUpDown_FFCParam256E_MaxInterval = new System.Windows.Forms.NumericUpDown();
            this.label_FFCParam256E_AutoTriggerThresholdTitle = new System.Windows.Forms.Label();
            this.numericUpDown_FFCParam256E_AutoTriggerThreshold = new System.Windows.Forms.NumericUpDown();
            this.textBox_FFCParam256E_AutoTriggerThresholdRange = new System.Windows.Forms.TextBox();
            this.label_FFCParam256E_MaxIntervalUnit = new System.Windows.Forms.Label();
            this.button_StoreUserSensorConfig_256E = new System.Windows.Forms.Button();
            this.button_RestoreDefaultSensorConfig_256E = new System.Windows.Forms.Button();
            this.groupBox_FluxParameters_256E = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_FluxParam256E_DistanceTitle = new System.Windows.Forms.Label();
            this.label_FluxParam256E_EmissivityTitle = new System.Windows.Forms.Label();
            this.textBox_FluxParam256E_EmissivityRange = new System.Windows.Forms.TextBox();
            this.button_GetFluxParameters_256E = new System.Windows.Forms.Button();
            this.button_SetFluxParameters_256E = new System.Windows.Forms.Button();
            this.numericUpDown_FluxParam256E_Emissivity = new System.Windows.Forms.NumericUpDown();
            this.label_FluxParam256E_AtmosphericTransmittanceTitle = new System.Windows.Forms.Label();
            this.numericUpDown_FluxParam256E_AtmosphericTransmittance = new System.Windows.Forms.NumericUpDown();
            this.textBox_FluxParam256E_AtmosphericTransmittanceRange = new System.Windows.Forms.TextBox();
            this.label_FluxParam256E_AtmosphericTemperatureTitle = new System.Windows.Forms.Label();
            this.numericUpDown_FluxParam256E_AtmosphericTemperature = new System.Windows.Forms.NumericUpDown();
            this.textBox_FluxParam256E_AtmosphericTemperatureRange = new System.Windows.Forms.TextBox();
            this.label_FluxParam256E_AtmosphericTemperatureUnit = new System.Windows.Forms.Label();
            this.label_FluxParam256E_AmbientReflectionTemperatureTitle = new System.Windows.Forms.Label();
            this.numericUpDown_FluxParam256E_AmbientReflectionTemperature = new System.Windows.Forms.NumericUpDown();
            this.label_FluxParam256E_AmbientReflectionTemperatureUnit = new System.Windows.Forms.Label();
            this.textBox_FluxParam256E_AmbientReflectionTemperatureRange = new System.Windows.Forms.TextBox();
            this.numericUpDown_FluxParam256E_Distance = new System.Windows.Forms.NumericUpDown();
            this.label_FluxParam256E_DistanceUnit = new System.Windows.Forms.Label();
            this.textBox_FluxParam256E_DistanceRange = new System.Windows.Forms.TextBox();
            this.groupBox_GainModeState_256E = new System.Windows.Forms.GroupBox();
            this.button_SetGainModeState_256E = new System.Windows.Forms.Button();
            this.button_GetGainModeState_256E = new System.Windows.Forms.Button();
            this.radioButton_GainModeStateLow_256E = new System.Windows.Forms.RadioButton();
            this.radioButton_GainModeStateHigh_256E = new System.Windows.Forms.RadioButton();
            this.groupBox_FlatFieldCorrection_256E = new System.Windows.Forms.GroupBox();
            this.button_SetFlatFieldCorrectionMode_256E = new System.Windows.Forms.Button();
            this.button_GetFlatFieldCorrectionMode_256E = new System.Windows.Forms.Button();
            this.radioButton_FlatFieldCorrectionManual_256E = new System.Windows.Forms.RadioButton();
            this.button_RunFlatFieldCorrection_256E = new System.Windows.Forms.Button();
            this.radioButton_FlatFieldCorrectionAutomatic_256E = new System.Windows.Forms.RadioButton();
            this.panel_SensorControl_160E = new System.Windows.Forms.Panel();
            this.groupBox_FluxParameters_160E = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label_FluxParam160E_WindowReflectedTemperatureUnit = new System.Windows.Forms.Label();
            this.label_FluxParam160E_AtmosphericTemperatureUnit = new System.Windows.Forms.Label();
            this.label_FluxParam160E_WindowTemperatureUnit = new System.Windows.Forms.Label();
            this.label_FluxParam160E_BackgroundTemperatureUnit = new System.Windows.Forms.Label();
            this.numericUpDown_FluxParam160E_WindowReflectedTemperature = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_FluxParam160E_WindowReflection = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_FluxParam160E_AtmosphericTemperature = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_FluxParam160E_AtmosphericTransmission = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_FluxParam160E_WindowTemperature = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_FluxParam160E_WindowTransmission = new System.Windows.Forms.NumericUpDown();
            this.label_FluxParam160E_SceneEmissivityTitle = new System.Windows.Forms.Label();
            this.textBox_FluxParam160E_SceneEmissivityRange = new System.Windows.Forms.TextBox();
            this.button_GetFluxParameters_160E = new System.Windows.Forms.Button();
            this.button_SetFluxParameters_160E = new System.Windows.Forms.Button();
            this.label_FluxParam160E_WindowTransmissionTitle = new System.Windows.Forms.Label();
            this.label_FluxParam160E_WindowTemperatureTitle = new System.Windows.Forms.Label();
            this.label_FluxParam160E_AtmosphericTransmissionTitle = new System.Windows.Forms.Label();
            this.label_FluxParam160E_AtmosphericTemperatureTitle = new System.Windows.Forms.Label();
            this.textBox_FluxParam160E_BackgroundTemperatureRange = new System.Windows.Forms.TextBox();
            this.textBox_FluxParam160E_WindowTransmissionRange = new System.Windows.Forms.TextBox();
            this.textBox_FluxParam160E_WindowTemperatureRange = new System.Windows.Forms.TextBox();
            this.textBox_FluxParam160E_AtmosphericTransmissionRange = new System.Windows.Forms.TextBox();
            this.textBox_FluxParam160E_AtmosphericTemperatureRange = new System.Windows.Forms.TextBox();
            this.label_FluxParam160E_WindowReflectionTitle = new System.Windows.Forms.Label();
            this.label_FluxParam160E_WindowReflectedTemperatureTitle = new System.Windows.Forms.Label();
            this.textBox_FluxParam160E_WindowReflectionRange = new System.Windows.Forms.TextBox();
            this.textBox_FluxParam160E_WindowReflectedTemperatureRange = new System.Windows.Forms.TextBox();
            this.numericUpDown_FluxParam160E_SceneEmissivity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_FluxParam160E_BackgroundTemperature = new System.Windows.Forms.NumericUpDown();
            this.label_FluxParam160E_BackgroundTemperatureTitle = new System.Windows.Forms.Label();
            this.groupBox_GainModeState_160E = new System.Windows.Forms.GroupBox();
            this.button_SetGainModeState_160E = new System.Windows.Forms.Button();
            this.button_GetGainModeState_160E = new System.Windows.Forms.Button();
            this.radioButton_GainModeStateAuto_160E = new System.Windows.Forms.RadioButton();
            this.radioButton_GainModeStateLow_160E = new System.Windows.Forms.RadioButton();
            this.radioButton_GainModeStateHigh_160E = new System.Windows.Forms.RadioButton();
            this.groupBox_FlatFieldCorrection_160E = new System.Windows.Forms.GroupBox();
            this.button_SetFlatFieldCorrectionMode_160E = new System.Windows.Forms.Button();
            this.button_GetFlatFieldCorrectionMode_160E = new System.Windows.Forms.Button();
            this.radioButton_FlatFieldCorrectionManual_160E = new System.Windows.Forms.RadioButton();
            this.button_RunFlatFieldCorrection_160E = new System.Windows.Forms.Button();
            this.radioButton_FlatFieldCorrectionAutomatic_160E = new System.Windows.Forms.RadioButton();
            this.button_RestoreDefaultFluxParameters_160E = new System.Windows.Forms.Button();
            this.tabPage_RoiManager = new System.Windows.Forms.TabPage();
            this.button_RemoveRoiItem = new System.Windows.Forms.Button();
            this.button_AddRoiItem = new System.Windows.Forms.Button();
            this.rbtn_RoiEllipse = new System.Windows.Forms.RadioButton();
            this.rbtn_RoiRect = new System.Windows.Forms.RadioButton();
            this.rbtn_RoiLine = new System.Windows.Forms.RadioButton();
            this.rbtn_RoiSpot = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_ellipseX = new System.Windows.Forms.TextBox();
            this.textBox_ellipseW = new System.Windows.Forms.TextBox();
            this.textBox_ellipseY = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_ellipseH = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_rectX = new System.Windows.Forms.TextBox();
            this.textBox_rectW = new System.Windows.Forms.TextBox();
            this.textBox_rectY = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_rectH = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_lineX1 = new System.Windows.Forms.TextBox();
            this.textBox_lineX2 = new System.Windows.Forms.TextBox();
            this.textBox_lineY1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_lineY2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_spotX = new System.Windows.Forms.TextBox();
            this.textBox_spotY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ListROI = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_Preview = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_MinimumTemperature = new System.Windows.Forms.Label();
            this.label_AverageTemperature = new System.Windows.Forms.Label();
            this.label_MaximumTemperature = new System.Windows.Forms.Label();
            this.panel_Preview = new System.Windows.Forms.Panel();
            this.checkBox_NoiseFiltering = new System.Windows.Forms.CheckBox();
            this.label_ColorMap = new System.Windows.Forms.Label();
            this.comboBox_ColorMap = new System.Windows.Forms.ComboBox();
            this.label_TemperatureUnit = new System.Windows.Forms.Label();
            this.comboBox_TemperatureUnit = new System.Windows.Forms.ComboBox();
            this.panel_VideoPreview = new System.Windows.Forms.Panel();
            this.pictureBox_Preview = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton_ShapeEllipse = new System.Windows.Forms.RadioButton();
            this.radioButton_ShapeRectangle = new System.Windows.Forms.RadioButton();
            this.radioButton_ShapeLine = new System.Windows.Forms.RadioButton();
            this.radioButton_ShapeSpot = new System.Windows.Forms.RadioButton();
            this.radioButton_ShapeCursor = new System.Windows.Forms.RadioButton();
            this.button_RemoveAllRoi = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_RemoteCamera.SuspendLayout();
            this.tabPage_LocalCamera.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage_Product.SuspendLayout();
            this.groupBox_ProductInformation.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox_SensorInformation.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox_SoftwareUpdate.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPage_Network.SuspendLayout();
            this.groupBox_NetworkConfiguration.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage_SensorControl.SuspendLayout();
            this.panel_SensorControl_256E.SuspendLayout();
            this.groupBox_FFCParameters_256E.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FFCParam256E_MaxInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FFCParam256E_AutoTriggerThreshold)).BeginInit();
            this.groupBox_FluxParameters_256E.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam256E_Emissivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam256E_AtmosphericTransmittance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam256E_AtmosphericTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam256E_AmbientReflectionTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam256E_Distance)).BeginInit();
            this.groupBox_GainModeState_256E.SuspendLayout();
            this.groupBox_FlatFieldCorrection_256E.SuspendLayout();
            this.panel_SensorControl_160E.SuspendLayout();
            this.groupBox_FluxParameters_160E.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_WindowReflectedTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_WindowReflection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_AtmosphericTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_AtmosphericTransmission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_WindowTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_WindowTransmission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_SceneEmissivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_BackgroundTemperature)).BeginInit();
            this.groupBox_GainModeState_160E.SuspendLayout();
            this.groupBox_FlatFieldCorrection_160E.SuspendLayout();
            this.tabPage_RoiManager.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel_Preview.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_Preview.SuspendLayout();
            this.panel_VideoPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Preview)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 370F));
            this.tableLayoutPanelMain.Controls.Add(this.statusBar, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tabControl2, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tabControl3, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 274F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1103, 769);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // statusBar
            // 
            this.statusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.SetColumnSpan(this.statusBar, 3);
            this.statusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel_Name,
            this.StatusLabel_CamInfo,
            this.StatusLabel_fps,
            this.StatusLabel_PreviewSize});
            this.statusBar.Location = new System.Drawing.Point(0, 747);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1103, 22);
            this.statusBar.TabIndex = 14;
            this.statusBar.Text = "statusStrip";
            // 
            // StatusLabel_Name
            // 
            this.StatusLabel_Name.Name = "StatusLabel_Name";
            this.StatusLabel_Name.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusLabel_CamInfo
            // 
            this.StatusLabel_CamInfo.Name = "StatusLabel_CamInfo";
            this.StatusLabel_CamInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusLabel_fps
            // 
            this.StatusLabel_fps.Name = "StatusLabel_fps";
            this.StatusLabel_fps.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusLabel_PreviewSize
            // 
            this.StatusLabel_PreviewSize.Name = "StatusLabel_PreviewSize";
            this.StatusLabel_PreviewSize.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 463);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_RemoteCamera);
            this.tabControl1.Controls.Add(this.tabPage_LocalCamera);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(234, 463);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_RemoteCamera
            // 
            this.tabPage_RemoteCamera.Controls.Add(this.textBox_RemoteCameraMACAddress);
            this.tabPage_RemoteCamera.Controls.Add(this.label_RemoteCameraMACAddressTitle);
            this.tabPage_RemoteCamera.Controls.Add(this.textBox_RemoteCameraSerialNumber);
            this.tabPage_RemoteCamera.Controls.Add(this.label_RemoteCameraSerialNumberTitle);
            this.tabPage_RemoteCamera.Controls.Add(this.textBox_RemoteCameraName);
            this.tabPage_RemoteCamera.Controls.Add(this.label_RemoteCameraNameTitle);
            this.tabPage_RemoteCamera.Controls.Add(this.label_RemoteCameraIPAddressTitle);
            this.tabPage_RemoteCamera.Controls.Add(this.textBox_RemoteCameraIPAddress);
            this.tabPage_RemoteCamera.Controls.Add(this.button_ConnectRemoteCamera);
            this.tabPage_RemoteCamera.Controls.Add(this.listBox_RemoteCameraScanList);
            this.tabPage_RemoteCamera.Controls.Add(this.button_ScanRemoteCamera);
            this.tabPage_RemoteCamera.Location = new System.Drawing.Point(4, 24);
            this.tabPage_RemoteCamera.Name = "tabPage_RemoteCamera";
            this.tabPage_RemoteCamera.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RemoteCamera.Size = new System.Drawing.Size(226, 435);
            this.tabPage_RemoteCamera.TabIndex = 1;
            this.tabPage_RemoteCamera.Text = "Remote Camera";
            this.tabPage_RemoteCamera.UseVisualStyleBackColor = true;
            // 
            // textBox_RemoteCameraMACAddress
            // 
            this.textBox_RemoteCameraMACAddress.Location = new System.Drawing.Point(95, 86);
            this.textBox_RemoteCameraMACAddress.Name = "textBox_RemoteCameraMACAddress";
            this.textBox_RemoteCameraMACAddress.ReadOnly = true;
            this.textBox_RemoteCameraMACAddress.Size = new System.Drawing.Size(120, 23);
            this.textBox_RemoteCameraMACAddress.TabIndex = 9;
            // 
            // label_RemoteCameraMACAddressTitle
            // 
            this.label_RemoteCameraMACAddressTitle.AutoSize = true;
            this.label_RemoteCameraMACAddressTitle.Location = new System.Drawing.Point(51, 90);
            this.label_RemoteCameraMACAddressTitle.Name = "label_RemoteCameraMACAddressTitle";
            this.label_RemoteCameraMACAddressTitle.Size = new System.Drawing.Size(40, 15);
            this.label_RemoteCameraMACAddressTitle.TabIndex = 8;
            this.label_RemoteCameraMACAddressTitle.Text = "MAC :";
            // 
            // textBox_RemoteCameraSerialNumber
            // 
            this.textBox_RemoteCameraSerialNumber.Location = new System.Drawing.Point(95, 53);
            this.textBox_RemoteCameraSerialNumber.Name = "textBox_RemoteCameraSerialNumber";
            this.textBox_RemoteCameraSerialNumber.ReadOnly = true;
            this.textBox_RemoteCameraSerialNumber.Size = new System.Drawing.Size(120, 23);
            this.textBox_RemoteCameraSerialNumber.TabIndex = 7;
            // 
            // label_RemoteCameraSerialNumberTitle
            // 
            this.label_RemoteCameraSerialNumberTitle.AutoSize = true;
            this.label_RemoteCameraSerialNumberTitle.Location = new System.Drawing.Point(40, 57);
            this.label_RemoteCameraSerialNumberTitle.Name = "label_RemoteCameraSerialNumberTitle";
            this.label_RemoteCameraSerialNumberTitle.Size = new System.Drawing.Size(51, 15);
            this.label_RemoteCameraSerialNumberTitle.TabIndex = 6;
            this.label_RemoteCameraSerialNumberTitle.Text = "Serial # :";
            // 
            // textBox_RemoteCameraName
            // 
            this.textBox_RemoteCameraName.Location = new System.Drawing.Point(95, 21);
            this.textBox_RemoteCameraName.Name = "textBox_RemoteCameraName";
            this.textBox_RemoteCameraName.ReadOnly = true;
            this.textBox_RemoteCameraName.Size = new System.Drawing.Size(120, 23);
            this.textBox_RemoteCameraName.TabIndex = 5;
            // 
            // label_RemoteCameraNameTitle
            // 
            this.label_RemoteCameraNameTitle.AutoSize = true;
            this.label_RemoteCameraNameTitle.Location = new System.Drawing.Point(46, 24);
            this.label_RemoteCameraNameTitle.Name = "label_RemoteCameraNameTitle";
            this.label_RemoteCameraNameTitle.Size = new System.Drawing.Size(45, 15);
            this.label_RemoteCameraNameTitle.TabIndex = 4;
            this.label_RemoteCameraNameTitle.Text = "Name :";
            // 
            // label_RemoteCameraIPAddressTitle
            // 
            this.label_RemoteCameraIPAddressTitle.AutoSize = true;
            this.label_RemoteCameraIPAddressTitle.Location = new System.Drawing.Point(23, 123);
            this.label_RemoteCameraIPAddressTitle.Name = "label_RemoteCameraIPAddressTitle";
            this.label_RemoteCameraIPAddressTitle.Size = new System.Drawing.Size(68, 15);
            this.label_RemoteCameraIPAddressTitle.TabIndex = 3;
            this.label_RemoteCameraIPAddressTitle.Text = "IP Address :";
            // 
            // textBox_RemoteCameraIPAddress
            // 
            this.textBox_RemoteCameraIPAddress.Location = new System.Drawing.Point(95, 119);
            this.textBox_RemoteCameraIPAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_RemoteCameraIPAddress.Name = "textBox_RemoteCameraIPAddress";
            this.textBox_RemoteCameraIPAddress.Size = new System.Drawing.Size(120, 23);
            this.textBox_RemoteCameraIPAddress.TabIndex = 2;
            // 
            // button_ConnectRemoteCamera
            // 
            this.button_ConnectRemoteCamera.Location = new System.Drawing.Point(12, 153);
            this.button_ConnectRemoteCamera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ConnectRemoteCamera.Name = "button_ConnectRemoteCamera";
            this.button_ConnectRemoteCamera.Size = new System.Drawing.Size(203, 27);
            this.button_ConnectRemoteCamera.TabIndex = 1;
            this.button_ConnectRemoteCamera.Text = "Connect";
            this.button_ConnectRemoteCamera.UseVisualStyleBackColor = true;
            this.button_ConnectRemoteCamera.Click += new System.EventHandler(this.button_ConnectRemoteCamera_Click);
            // 
            // listBox_RemoteCameraScanList
            // 
            this.listBox_RemoteCameraScanList.FormattingEnabled = true;
            this.listBox_RemoteCameraScanList.HorizontalScrollbar = true;
            this.listBox_RemoteCameraScanList.ItemHeight = 15;
            this.listBox_RemoteCameraScanList.Location = new System.Drawing.Point(12, 240);
            this.listBox_RemoteCameraScanList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_RemoteCameraScanList.Name = "listBox_RemoteCameraScanList";
            this.listBox_RemoteCameraScanList.Size = new System.Drawing.Size(203, 184);
            this.listBox_RemoteCameraScanList.TabIndex = 1;
            this.listBox_RemoteCameraScanList.Click += new System.EventHandler(this.listBox_RemoteCameraList_Click);
            // 
            // button_ScanRemoteCamera
            // 
            this.button_ScanRemoteCamera.Location = new System.Drawing.Point(12, 208);
            this.button_ScanRemoteCamera.Name = "button_ScanRemoteCamera";
            this.button_ScanRemoteCamera.Size = new System.Drawing.Size(204, 26);
            this.button_ScanRemoteCamera.TabIndex = 0;
            this.button_ScanRemoteCamera.Text = "Scan Camera";
            this.button_ScanRemoteCamera.UseVisualStyleBackColor = true;
            this.button_ScanRemoteCamera.Click += new System.EventHandler(this.button_ScanRemoteCamera_Click);
            // 
            // tabPage_LocalCamera
            // 
            this.tabPage_LocalCamera.Controls.Add(this.textBox_LocalCameraComPort);
            this.tabPage_LocalCamera.Controls.Add(this.textBox_LocalCameraName);
            this.tabPage_LocalCamera.Controls.Add(this.listBox_LocalCameraScanList);
            this.tabPage_LocalCamera.Controls.Add(this.button_ScanLocalCamera);
            this.tabPage_LocalCamera.Controls.Add(this.label_LocalCameraComPort);
            this.tabPage_LocalCamera.Controls.Add(this.label_LocalCameraNameTitle);
            this.tabPage_LocalCamera.Controls.Add(this.button_ConnectLocalCamera);
            this.tabPage_LocalCamera.Location = new System.Drawing.Point(4, 24);
            this.tabPage_LocalCamera.Name = "tabPage_LocalCamera";
            this.tabPage_LocalCamera.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_LocalCamera.Size = new System.Drawing.Size(226, 435);
            this.tabPage_LocalCamera.TabIndex = 0;
            this.tabPage_LocalCamera.Text = "Local Camera";
            this.tabPage_LocalCamera.UseVisualStyleBackColor = true;
            // 
            // textBox_LocalCameraComPort
            // 
            this.textBox_LocalCameraComPort.Location = new System.Drawing.Point(94, 54);
            this.textBox_LocalCameraComPort.Name = "textBox_LocalCameraComPort";
            this.textBox_LocalCameraComPort.ReadOnly = true;
            this.textBox_LocalCameraComPort.Size = new System.Drawing.Size(121, 23);
            this.textBox_LocalCameraComPort.TabIndex = 12;
            // 
            // textBox_LocalCameraName
            // 
            this.textBox_LocalCameraName.Location = new System.Drawing.Point(94, 21);
            this.textBox_LocalCameraName.Name = "textBox_LocalCameraName";
            this.textBox_LocalCameraName.ReadOnly = true;
            this.textBox_LocalCameraName.Size = new System.Drawing.Size(121, 23);
            this.textBox_LocalCameraName.TabIndex = 11;
            // 
            // listBox_LocalCameraScanList
            // 
            this.listBox_LocalCameraScanList.FormattingEnabled = true;
            this.listBox_LocalCameraScanList.HorizontalScrollbar = true;
            this.listBox_LocalCameraScanList.ItemHeight = 15;
            this.listBox_LocalCameraScanList.Location = new System.Drawing.Point(12, 240);
            this.listBox_LocalCameraScanList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_LocalCameraScanList.Name = "listBox_LocalCameraScanList";
            this.listBox_LocalCameraScanList.Size = new System.Drawing.Size(203, 184);
            this.listBox_LocalCameraScanList.TabIndex = 11;
            this.listBox_LocalCameraScanList.Click += new System.EventHandler(this.listBox_LocalCameraList_Click);
            // 
            // button_ScanLocalCamera
            // 
            this.button_ScanLocalCamera.Location = new System.Drawing.Point(12, 208);
            this.button_ScanLocalCamera.Name = "button_ScanLocalCamera";
            this.button_ScanLocalCamera.Size = new System.Drawing.Size(204, 26);
            this.button_ScanLocalCamera.TabIndex = 5;
            this.button_ScanLocalCamera.Text = "Scan Camera";
            this.button_ScanLocalCamera.UseVisualStyleBackColor = true;
            this.button_ScanLocalCamera.Click += new System.EventHandler(this.button_ScanLocalCamera_Click);
            // 
            // label_LocalCameraComPort
            // 
            this.label_LocalCameraComPort.AutoSize = true;
            this.label_LocalCameraComPort.Location = new System.Drawing.Point(25, 57);
            this.label_LocalCameraComPort.Name = "label_LocalCameraComPort";
            this.label_LocalCameraComPort.Size = new System.Drawing.Size(66, 15);
            this.label_LocalCameraComPort.TabIndex = 4;
            this.label_LocalCameraComPort.Text = "COM Port :";
            // 
            // label_LocalCameraNameTitle
            // 
            this.label_LocalCameraNameTitle.AutoSize = true;
            this.label_LocalCameraNameTitle.Location = new System.Drawing.Point(46, 24);
            this.label_LocalCameraNameTitle.Name = "label_LocalCameraNameTitle";
            this.label_LocalCameraNameTitle.Size = new System.Drawing.Size(45, 15);
            this.label_LocalCameraNameTitle.TabIndex = 2;
            this.label_LocalCameraNameTitle.Text = "Name :";
            // 
            // button_ConnectLocalCamera
            // 
            this.button_ConnectLocalCamera.Location = new System.Drawing.Point(12, 96);
            this.button_ConnectLocalCamera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_ConnectLocalCamera.Name = "button_ConnectLocalCamera";
            this.button_ConnectLocalCamera.Size = new System.Drawing.Size(203, 27);
            this.button_ConnectLocalCamera.TabIndex = 1;
            this.button_ConnectLocalCamera.Text = "Connect";
            this.button_ConnectLocalCamera.UseVisualStyleBackColor = true;
            this.button_ConnectLocalCamera.Click += new System.EventHandler(this.button_ConnectLocalCamera_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage_Product);
            this.tabControl2.Controls.Add(this.tabPage_Network);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Enabled = false;
            this.tabControl2.Location = new System.Drawing.Point(736, 3);
            this.tabControl2.Name = "tabControl2";
            this.tableLayoutPanelMain.SetRowSpan(this.tabControl2, 2);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(364, 739);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage_Product
            // 
            this.tabPage_Product.Controls.Add(this.groupBox_ProductInformation);
            this.tabPage_Product.Controls.Add(this.groupBox_SensorInformation);
            this.tabPage_Product.Controls.Add(this.groupBox_SoftwareUpdate);
            this.tabPage_Product.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Product.Name = "tabPage_Product";
            this.tabPage_Product.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Product.Size = new System.Drawing.Size(356, 711);
            this.tabPage_Product.TabIndex = 0;
            this.tabPage_Product.Text = "Product";
            this.tabPage_Product.UseVisualStyleBackColor = true;
            // 
            // groupBox_ProductInformation
            // 
            this.groupBox_ProductInformation.Controls.Add(this.tableLayoutPanel2);
            this.groupBox_ProductInformation.Controls.Add(this.button_GetProductInformation);
            this.groupBox_ProductInformation.Location = new System.Drawing.Point(4, 11);
            this.groupBox_ProductInformation.Name = "groupBox_ProductInformation";
            this.groupBox_ProductInformation.Size = new System.Drawing.Size(345, 153);
            this.groupBox_ProductInformation.TabIndex = 10;
            this.groupBox_ProductInformation.TabStop = false;
            this.groupBox_ProductInformation.Text = "Product Information";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.Controls.Add(this.label_HardwareVersion, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label_ProductSerialNumber, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_ProductModelName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_ProductSerialNumberTitle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_ProductModelNameTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_FirmwareVersionTitle, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label_BootloaderVersionTitle, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_FirmwareVersion, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label_BootloaderVersion, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_HardwareVersionTitle, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(261, 120);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label_HardwareVersion
            // 
            this.label_HardwareVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_HardwareVersion.AutoSize = true;
            this.label_HardwareVersion.Location = new System.Drawing.Point(143, 52);
            this.label_HardwareVersion.Name = "label_HardwareVersion";
            this.label_HardwareVersion.Size = new System.Drawing.Size(0, 15);
            this.label_HardwareVersion.TabIndex = 14;
            // 
            // label_ProductSerialNumber
            // 
            this.label_ProductSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_ProductSerialNumber.AutoSize = true;
            this.label_ProductSerialNumber.Location = new System.Drawing.Point(143, 28);
            this.label_ProductSerialNumber.Name = "label_ProductSerialNumber";
            this.label_ProductSerialNumber.Size = new System.Drawing.Size(0, 15);
            this.label_ProductSerialNumber.TabIndex = 13;
            // 
            // label_ProductModelName
            // 
            this.label_ProductModelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_ProductModelName.AutoSize = true;
            this.label_ProductModelName.Location = new System.Drawing.Point(143, 4);
            this.label_ProductModelName.Name = "label_ProductModelName";
            this.label_ProductModelName.Size = new System.Drawing.Size(0, 15);
            this.label_ProductModelName.TabIndex = 12;
            // 
            // label_ProductSerialNumberTitle
            // 
            this.label_ProductSerialNumberTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_ProductSerialNumberTitle.AutoSize = true;
            this.label_ProductSerialNumberTitle.Location = new System.Drawing.Point(4, 28);
            this.label_ProductSerialNumberTitle.Name = "label_ProductSerialNumberTitle";
            this.label_ProductSerialNumberTitle.Size = new System.Drawing.Size(133, 15);
            this.label_ProductSerialNumberTitle.TabIndex = 11;
            this.label_ProductSerialNumberTitle.Text = "Product Serial Number :";
            // 
            // label_ProductModelNameTitle
            // 
            this.label_ProductModelNameTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_ProductModelNameTitle.AutoSize = true;
            this.label_ProductModelNameTitle.Location = new System.Drawing.Point(10, 4);
            this.label_ProductModelNameTitle.Name = "label_ProductModelNameTitle";
            this.label_ProductModelNameTitle.Size = new System.Drawing.Size(127, 15);
            this.label_ProductModelNameTitle.TabIndex = 9;
            this.label_ProductModelNameTitle.Text = "Product Model Name :";
            // 
            // label_FirmwareVersionTitle
            // 
            this.label_FirmwareVersionTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_FirmwareVersionTitle.AutoSize = true;
            this.label_FirmwareVersionTitle.Location = new System.Drawing.Point(34, 100);
            this.label_FirmwareVersionTitle.Name = "label_FirmwareVersionTitle";
            this.label_FirmwareVersionTitle.Size = new System.Drawing.Size(103, 15);
            this.label_FirmwareVersionTitle.TabIndex = 3;
            this.label_FirmwareVersionTitle.Text = "Firmware Version :";
            // 
            // label_BootloaderVersionTitle
            // 
            this.label_BootloaderVersionTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_BootloaderVersionTitle.AutoSize = true;
            this.label_BootloaderVersionTitle.Location = new System.Drawing.Point(25, 76);
            this.label_BootloaderVersionTitle.Name = "label_BootloaderVersionTitle";
            this.label_BootloaderVersionTitle.Size = new System.Drawing.Size(112, 15);
            this.label_BootloaderVersionTitle.TabIndex = 2;
            this.label_BootloaderVersionTitle.Text = "Bootloader Version :";
            // 
            // label_FirmwareVersion
            // 
            this.label_FirmwareVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_FirmwareVersion.AutoSize = true;
            this.label_FirmwareVersion.Location = new System.Drawing.Point(143, 100);
            this.label_FirmwareVersion.Name = "label_FirmwareVersion";
            this.label_FirmwareVersion.Size = new System.Drawing.Size(0, 15);
            this.label_FirmwareVersion.TabIndex = 6;
            // 
            // label_BootloaderVersion
            // 
            this.label_BootloaderVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_BootloaderVersion.AutoSize = true;
            this.label_BootloaderVersion.Location = new System.Drawing.Point(143, 76);
            this.label_BootloaderVersion.Name = "label_BootloaderVersion";
            this.label_BootloaderVersion.Size = new System.Drawing.Size(0, 15);
            this.label_BootloaderVersion.TabIndex = 5;
            // 
            // label_HardwareVersionTitle
            // 
            this.label_HardwareVersionTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_HardwareVersionTitle.AutoSize = true;
            this.label_HardwareVersionTitle.Location = new System.Drawing.Point(32, 52);
            this.label_HardwareVersionTitle.Name = "label_HardwareVersionTitle";
            this.label_HardwareVersionTitle.Size = new System.Drawing.Size(105, 15);
            this.label_HardwareVersionTitle.TabIndex = 10;
            this.label_HardwareVersionTitle.Text = "Hardware Version :";
            // 
            // button_GetProductInformation
            // 
            this.button_GetProductInformation.Location = new System.Drawing.Point(280, 22);
            this.button_GetProductInformation.Name = "button_GetProductInformation";
            this.button_GetProductInformation.Size = new System.Drawing.Size(56, 120);
            this.button_GetProductInformation.TabIndex = 0;
            this.button_GetProductInformation.Text = "Get";
            this.button_GetProductInformation.UseVisualStyleBackColor = true;
            this.button_GetProductInformation.Click += new System.EventHandler(this.button_ProductControl_Click);
            // 
            // groupBox_SensorInformation
            // 
            this.groupBox_SensorInformation.Controls.Add(this.tableLayoutPanel8);
            this.groupBox_SensorInformation.Controls.Add(this.button_GetSensorInformation);
            this.groupBox_SensorInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SensorInformation.Location = new System.Drawing.Point(4, 180);
            this.groupBox_SensorInformation.Name = "groupBox_SensorInformation";
            this.groupBox_SensorInformation.Size = new System.Drawing.Size(345, 103);
            this.groupBox_SensorInformation.TabIndex = 9;
            this.groupBox_SensorInformation.TabStop = false;
            this.groupBox_SensorInformation.Text = "Sensor Information";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel8.Controls.Add(this.label_SensorUptime, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.label_SensorUptimeTitle, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.label_SensorModelNameTitle, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label_SensorSerialNumberTitle, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label_SensorSerialNumber, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.label_SensorModelName, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(13, 22);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(261, 72);
            this.tableLayoutPanel8.TabIndex = 6;
            // 
            // label_SensorUptime
            // 
            this.label_SensorUptime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_SensorUptime.AutoSize = true;
            this.label_SensorUptime.Location = new System.Drawing.Point(143, 52);
            this.label_SensorUptime.Name = "label_SensorUptime";
            this.label_SensorUptime.Size = new System.Drawing.Size(0, 15);
            this.label_SensorUptime.TabIndex = 1;
            // 
            // label_SensorUptimeTitle
            // 
            this.label_SensorUptimeTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_SensorUptimeTitle.AutoSize = true;
            this.label_SensorUptimeTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SensorUptimeTitle.Location = new System.Drawing.Point(47, 52);
            this.label_SensorUptimeTitle.Name = "label_SensorUptimeTitle";
            this.label_SensorUptimeTitle.Size = new System.Drawing.Size(90, 15);
            this.label_SensorUptimeTitle.TabIndex = 0;
            this.label_SensorUptimeTitle.Text = "Sensor Uptime :";
            // 
            // label_SensorModelNameTitle
            // 
            this.label_SensorModelNameTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_SensorModelNameTitle.AutoSize = true;
            this.label_SensorModelNameTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SensorModelNameTitle.Location = new System.Drawing.Point(17, 4);
            this.label_SensorModelNameTitle.Name = "label_SensorModelNameTitle";
            this.label_SensorModelNameTitle.Size = new System.Drawing.Size(120, 15);
            this.label_SensorModelNameTitle.TabIndex = 5;
            this.label_SensorModelNameTitle.Text = "Sensor Model Name :";
            // 
            // label_SensorSerialNumberTitle
            // 
            this.label_SensorSerialNumberTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_SensorSerialNumberTitle.AutoSize = true;
            this.label_SensorSerialNumberTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SensorSerialNumberTitle.Location = new System.Drawing.Point(11, 28);
            this.label_SensorSerialNumberTitle.Name = "label_SensorSerialNumberTitle";
            this.label_SensorSerialNumberTitle.Size = new System.Drawing.Size(126, 15);
            this.label_SensorSerialNumberTitle.TabIndex = 0;
            this.label_SensorSerialNumberTitle.Text = "Sensor Serial Number :";
            // 
            // label_SensorSerialNumber
            // 
            this.label_SensorSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_SensorSerialNumber.AutoSize = true;
            this.label_SensorSerialNumber.Location = new System.Drawing.Point(143, 28);
            this.label_SensorSerialNumber.Name = "label_SensorSerialNumber";
            this.label_SensorSerialNumber.Size = new System.Drawing.Size(0, 15);
            this.label_SensorSerialNumber.TabIndex = 1;
            // 
            // label_SensorModelName
            // 
            this.label_SensorModelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_SensorModelName.AutoSize = true;
            this.label_SensorModelName.Location = new System.Drawing.Point(143, 4);
            this.label_SensorModelName.Name = "label_SensorModelName";
            this.label_SensorModelName.Size = new System.Drawing.Size(0, 15);
            this.label_SensorModelName.TabIndex = 5;
            // 
            // button_GetSensorInformation
            // 
            this.button_GetSensorInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GetSensorInformation.Location = new System.Drawing.Point(280, 22);
            this.button_GetSensorInformation.Name = "button_GetSensorInformation";
            this.button_GetSensorInformation.Size = new System.Drawing.Size(56, 72);
            this.button_GetSensorInformation.TabIndex = 7;
            this.button_GetSensorInformation.Text = "Get";
            this.button_GetSensorInformation.UseVisualStyleBackColor = true;
            this.button_GetSensorInformation.Click += new System.EventHandler(this.button_ProductControl_Click);
            // 
            // groupBox_SoftwareUpdate
            // 
            this.groupBox_SoftwareUpdate.Controls.Add(this.button_SoftwareUpdateFileBrowse);
            this.groupBox_SoftwareUpdate.Controls.Add(this.textBox_SoftwareUpdateFilePath);
            this.groupBox_SoftwareUpdate.Controls.Add(this.button_StartSoftwareUpdate);
            this.groupBox_SoftwareUpdate.Controls.Add(this.tableLayoutPanel5);
            this.groupBox_SoftwareUpdate.Controls.Add(this.progressBar_SoftwareUpdate);
            this.groupBox_SoftwareUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_SoftwareUpdate.Location = new System.Drawing.Point(4, 301);
            this.groupBox_SoftwareUpdate.Name = "groupBox_SoftwareUpdate";
            this.groupBox_SoftwareUpdate.Size = new System.Drawing.Size(345, 138);
            this.groupBox_SoftwareUpdate.TabIndex = 3;
            this.groupBox_SoftwareUpdate.TabStop = false;
            this.groupBox_SoftwareUpdate.Text = "Software Update";
            // 
            // button_SoftwareUpdateFileBrowse
            // 
            this.button_SoftwareUpdateFileBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SoftwareUpdateFileBrowse.Location = new System.Drawing.Point(10, 74);
            this.button_SoftwareUpdateFileBrowse.Name = "button_SoftwareUpdateFileBrowse";
            this.button_SoftwareUpdateFileBrowse.Size = new System.Drawing.Size(63, 23);
            this.button_SoftwareUpdateFileBrowse.TabIndex = 8;
            this.button_SoftwareUpdateFileBrowse.Text = "Browse";
            this.button_SoftwareUpdateFileBrowse.UseVisualStyleBackColor = true;
            this.button_SoftwareUpdateFileBrowse.Click += new System.EventHandler(this.button_ProductControl_Click);
            // 
            // textBox_SoftwareUpdateFilePath
            // 
            this.textBox_SoftwareUpdateFilePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoftwareUpdateFilePath.Location = new System.Drawing.Point(79, 74);
            this.textBox_SoftwareUpdateFilePath.Name = "textBox_SoftwareUpdateFilePath";
            this.textBox_SoftwareUpdateFilePath.ReadOnly = true;
            this.textBox_SoftwareUpdateFilePath.Size = new System.Drawing.Size(257, 23);
            this.textBox_SoftwareUpdateFilePath.TabIndex = 7;
            // 
            // button_StartSoftwareUpdate
            // 
            this.button_StartSoftwareUpdate.Enabled = false;
            this.button_StartSoftwareUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_StartSoftwareUpdate.Location = new System.Drawing.Point(10, 104);
            this.button_StartSoftwareUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_StartSoftwareUpdate.Name = "button_StartSoftwareUpdate";
            this.button_StartSoftwareUpdate.Size = new System.Drawing.Size(326, 23);
            this.button_StartSoftwareUpdate.TabIndex = 6;
            this.button_StartSoftwareUpdate.Text = "Browse and Select Binary File";
            this.button_StartSoftwareUpdate.UseVisualStyleBackColor = true;
            this.button_StartSoftwareUpdate.Click += new System.EventHandler(this.button_ProductControl_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.12613F));
            this.tableLayoutPanel5.Controls.Add(this.label_SoftwareUpdateStatus, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(10, 22);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(326, 17);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // label_SoftwareUpdateStatus
            // 
            this.label_SoftwareUpdateStatus.AutoSize = true;
            this.label_SoftwareUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SoftwareUpdateStatus.Location = new System.Drawing.Point(3, 0);
            this.label_SoftwareUpdateStatus.Name = "label_SoftwareUpdateStatus";
            this.label_SoftwareUpdateStatus.Size = new System.Drawing.Size(0, 15);
            this.label_SoftwareUpdateStatus.TabIndex = 0;
            // 
            // progressBar_SoftwareUpdate
            // 
            this.progressBar_SoftwareUpdate.Location = new System.Drawing.Point(10, 45);
            this.progressBar_SoftwareUpdate.Name = "progressBar_SoftwareUpdate";
            this.progressBar_SoftwareUpdate.Size = new System.Drawing.Size(326, 23);
            this.progressBar_SoftwareUpdate.TabIndex = 0;
            // 
            // tabPage_Network
            // 
            this.tabPage_Network.Controls.Add(this.groupBox_NetworkConfiguration);
            this.tabPage_Network.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Network.Name = "tabPage_Network";
            this.tabPage_Network.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Network.Size = new System.Drawing.Size(356, 711);
            this.tabPage_Network.TabIndex = 2;
            this.tabPage_Network.Text = "Network";
            this.tabPage_Network.UseVisualStyleBackColor = true;
            // 
            // groupBox_NetworkConfiguration
            // 
            this.groupBox_NetworkConfiguration.Controls.Add(this.tableLayoutPanel4);
            this.groupBox_NetworkConfiguration.Controls.Add(this.button_SystemReboot);
            this.groupBox_NetworkConfiguration.Controls.Add(this.button_SetDefaultNetworkConfiguration);
            this.groupBox_NetworkConfiguration.Location = new System.Drawing.Point(3, 11);
            this.groupBox_NetworkConfiguration.Name = "groupBox_NetworkConfiguration";
            this.groupBox_NetworkConfiguration.Size = new System.Drawing.Size(348, 268);
            this.groupBox_NetworkConfiguration.TabIndex = 16;
            this.groupBox_NetworkConfiguration.TabStop = false;
            this.groupBox_NetworkConfiguration.Text = "Network Configuration";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel4.Controls.Add(this.textBox_SubDNSServer, 2, 6);
            this.tableLayoutPanel4.Controls.Add(this.label_SubDNSServerTitle, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.label_MACAddressTitle, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox_MACAddress, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_GetNetworkConfiguration, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_IPAssignmentTitle, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label_IPAddressTitle, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label_NetmaskTitle, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label_GatewayNameTitle, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.textBox_IPAddress, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBox_Netmask, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.textBox_Gateway, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.textBox_MainDNSServer, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.button_SetNetworkConfiguration, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.comboBox_IPAssignment, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label_MainDNSServerTitle, 0, 5);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(5, 22);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 7;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(337, 176);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // textBox_SubDNSServer
            // 
            this.textBox_SubDNSServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_SubDNSServer.Location = new System.Drawing.Point(157, 153);
            this.textBox_SubDNSServer.Name = "textBox_SubDNSServer";
            this.textBox_SubDNSServer.ReadOnly = true;
            this.textBox_SubDNSServer.Size = new System.Drawing.Size(138, 23);
            this.textBox_SubDNSServer.TabIndex = 16;
            // 
            // label_SubDNSServerTitle
            // 
            this.label_SubDNSServerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SubDNSServerTitle.AutoSize = true;
            this.label_SubDNSServerTitle.Location = new System.Drawing.Point(18, 150);
            this.label_SubDNSServerTitle.Name = "label_SubDNSServerTitle";
            this.label_SubDNSServerTitle.Size = new System.Drawing.Size(94, 26);
            this.label_SubDNSServerTitle.TabIndex = 15;
            this.label_SubDNSServerTitle.Text = "Sub DNS Server :";
            this.label_SubDNSServerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_MACAddressTitle
            // 
            this.label_MACAddressTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_MACAddressTitle.AutoSize = true;
            this.label_MACAddressTitle.Location = new System.Drawing.Point(27, 0);
            this.label_MACAddressTitle.Name = "label_MACAddressTitle";
            this.label_MACAddressTitle.Size = new System.Drawing.Size(85, 25);
            this.label_MACAddressTitle.TabIndex = 1;
            this.label_MACAddressTitle.Text = "MAC Address :";
            this.label_MACAddressTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_MACAddress
            // 
            this.textBox_MACAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_MACAddress.Location = new System.Drawing.Point(157, 3);
            this.textBox_MACAddress.Name = "textBox_MACAddress";
            this.textBox_MACAddress.ReadOnly = true;
            this.textBox_MACAddress.Size = new System.Drawing.Size(138, 23);
            this.textBox_MACAddress.TabIndex = 9;
            // 
            // button_GetNetworkConfiguration
            // 
            this.button_GetNetworkConfiguration.Location = new System.Drawing.Point(118, 3);
            this.button_GetNetworkConfiguration.Name = "button_GetNetworkConfiguration";
            this.tableLayoutPanel4.SetRowSpan(this.button_GetNetworkConfiguration, 7);
            this.button_GetNetworkConfiguration.Size = new System.Drawing.Size(33, 170);
            this.button_GetNetworkConfiguration.TabIndex = 6;
            this.button_GetNetworkConfiguration.Text = "Get";
            this.button_GetNetworkConfiguration.UseVisualStyleBackColor = true;
            this.button_GetNetworkConfiguration.Click += new System.EventHandler(this.button_NetworkControl_Click);
            // 
            // label_IPAssignmentTitle
            // 
            this.label_IPAssignmentTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_IPAssignmentTitle.AutoSize = true;
            this.label_IPAssignmentTitle.Location = new System.Drawing.Point(23, 25);
            this.label_IPAssignmentTitle.Name = "label_IPAssignmentTitle";
            this.label_IPAssignmentTitle.Size = new System.Drawing.Size(89, 25);
            this.label_IPAssignmentTitle.TabIndex = 7;
            this.label_IPAssignmentTitle.Text = "IP Assignment :";
            this.label_IPAssignmentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_IPAddressTitle
            // 
            this.label_IPAddressTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_IPAddressTitle.AutoSize = true;
            this.label_IPAddressTitle.Location = new System.Drawing.Point(44, 50);
            this.label_IPAddressTitle.Name = "label_IPAddressTitle";
            this.label_IPAddressTitle.Size = new System.Drawing.Size(68, 25);
            this.label_IPAddressTitle.TabIndex = 8;
            this.label_IPAddressTitle.Text = "IP Address :";
            this.label_IPAddressTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_NetmaskTitle
            // 
            this.label_NetmaskTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_NetmaskTitle.AutoSize = true;
            this.label_NetmaskTitle.Location = new System.Drawing.Point(52, 75);
            this.label_NetmaskTitle.Name = "label_NetmaskTitle";
            this.label_NetmaskTitle.Size = new System.Drawing.Size(60, 25);
            this.label_NetmaskTitle.TabIndex = 9;
            this.label_NetmaskTitle.Text = "Netmask :";
            this.label_NetmaskTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_GatewayNameTitle
            // 
            this.label_GatewayNameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_GatewayNameTitle.AutoSize = true;
            this.label_GatewayNameTitle.Location = new System.Drawing.Point(54, 100);
            this.label_GatewayNameTitle.Name = "label_GatewayNameTitle";
            this.label_GatewayNameTitle.Size = new System.Drawing.Size(58, 25);
            this.label_GatewayNameTitle.TabIndex = 10;
            this.label_GatewayNameTitle.Text = "Gateway :";
            this.label_GatewayNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_IPAddress
            // 
            this.textBox_IPAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_IPAddress.Location = new System.Drawing.Point(157, 53);
            this.textBox_IPAddress.Name = "textBox_IPAddress";
            this.textBox_IPAddress.ReadOnly = true;
            this.textBox_IPAddress.Size = new System.Drawing.Size(138, 23);
            this.textBox_IPAddress.TabIndex = 9;
            // 
            // textBox_Netmask
            // 
            this.textBox_Netmask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Netmask.Location = new System.Drawing.Point(157, 78);
            this.textBox_Netmask.Name = "textBox_Netmask";
            this.textBox_Netmask.ReadOnly = true;
            this.textBox_Netmask.Size = new System.Drawing.Size(138, 23);
            this.textBox_Netmask.TabIndex = 9;
            // 
            // textBox_Gateway
            // 
            this.textBox_Gateway.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Gateway.Location = new System.Drawing.Point(157, 103);
            this.textBox_Gateway.Name = "textBox_Gateway";
            this.textBox_Gateway.ReadOnly = true;
            this.textBox_Gateway.Size = new System.Drawing.Size(138, 23);
            this.textBox_Gateway.TabIndex = 9;
            // 
            // textBox_MainDNSServer
            // 
            this.textBox_MainDNSServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_MainDNSServer.Location = new System.Drawing.Point(157, 128);
            this.textBox_MainDNSServer.Name = "textBox_MainDNSServer";
            this.textBox_MainDNSServer.ReadOnly = true;
            this.textBox_MainDNSServer.Size = new System.Drawing.Size(138, 23);
            this.textBox_MainDNSServer.TabIndex = 9;
            // 
            // button_SetNetworkConfiguration
            // 
            this.button_SetNetworkConfiguration.Enabled = false;
            this.button_SetNetworkConfiguration.Location = new System.Drawing.Point(301, 28);
            this.button_SetNetworkConfiguration.Name = "button_SetNetworkConfiguration";
            this.tableLayoutPanel4.SetRowSpan(this.button_SetNetworkConfiguration, 5);
            this.button_SetNetworkConfiguration.Size = new System.Drawing.Size(33, 97);
            this.button_SetNetworkConfiguration.TabIndex = 6;
            this.button_SetNetworkConfiguration.Text = "Set";
            this.button_SetNetworkConfiguration.UseVisualStyleBackColor = true;
            this.button_SetNetworkConfiguration.Click += new System.EventHandler(this.button_NetworkControl_Click);
            // 
            // comboBox_IPAssignment
            // 
            this.comboBox_IPAssignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_IPAssignment.Enabled = false;
            this.comboBox_IPAssignment.FormattingEnabled = true;
            this.comboBox_IPAssignment.Items.AddRange(new object[] {
            "Static",
            "DHCP"});
            this.comboBox_IPAssignment.Location = new System.Drawing.Point(157, 28);
            this.comboBox_IPAssignment.Name = "comboBox_IPAssignment";
            this.comboBox_IPAssignment.Size = new System.Drawing.Size(138, 23);
            this.comboBox_IPAssignment.TabIndex = 12;
            this.comboBox_IPAssignment.SelectedIndexChanged += new System.EventHandler(this.comboBox_IPAssignment_SelectedIndexChanged);
            // 
            // label_MainDNSServerTitle
            // 
            this.label_MainDNSServerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_MainDNSServerTitle.AutoSize = true;
            this.label_MainDNSServerTitle.Location = new System.Drawing.Point(11, 125);
            this.label_MainDNSServerTitle.Name = "label_MainDNSServerTitle";
            this.label_MainDNSServerTitle.Size = new System.Drawing.Size(101, 25);
            this.label_MainDNSServerTitle.TabIndex = 11;
            this.label_MainDNSServerTitle.Text = "Main DNS Server :";
            this.label_MainDNSServerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_SystemReboot
            // 
            this.button_SystemReboot.Location = new System.Drawing.Point(123, 234);
            this.button_SystemReboot.Name = "button_SystemReboot";
            this.button_SystemReboot.Size = new System.Drawing.Size(216, 27);
            this.button_SystemReboot.TabIndex = 15;
            this.button_SystemReboot.Text = "Reboot to Apply Changes";
            this.button_SystemReboot.UseVisualStyleBackColor = true;
            this.button_SystemReboot.Click += new System.EventHandler(this.button_NetworkControl_Click);
            // 
            // button_SetDefaultNetworkConfiguration
            // 
            this.button_SetDefaultNetworkConfiguration.Location = new System.Drawing.Point(123, 204);
            this.button_SetDefaultNetworkConfiguration.Name = "button_SetDefaultNetworkConfiguration";
            this.button_SetDefaultNetworkConfiguration.Size = new System.Drawing.Size(216, 27);
            this.button_SetDefaultNetworkConfiguration.TabIndex = 13;
            this.button_SetDefaultNetworkConfiguration.Text = "Set to Factory Default";
            this.button_SetDefaultNetworkConfiguration.UseVisualStyleBackColor = true;
            this.button_SetDefaultNetworkConfiguration.Click += new System.EventHandler(this.button_NetworkControl_Click);
            // 
            // tabControl3
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.tabControl3, 2);
            this.tabControl3.Controls.Add(this.tabPage_SensorControl);
            this.tabControl3.Controls.Add(this.tabPage_RoiManager);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Enabled = false;
            this.tabControl3.Location = new System.Drawing.Point(3, 474);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(727, 268);
            this.tabControl3.TabIndex = 5;
            // 
            // tabPage_SensorControl
            // 
            this.tabPage_SensorControl.Controls.Add(this.panel_SensorControl_256E);
            this.tabPage_SensorControl.Controls.Add(this.panel_SensorControl_160E);
            this.tabPage_SensorControl.Location = new System.Drawing.Point(4, 24);
            this.tabPage_SensorControl.Name = "tabPage_SensorControl";
            this.tabPage_SensorControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SensorControl.Size = new System.Drawing.Size(719, 240);
            this.tabPage_SensorControl.TabIndex = 0;
            this.tabPage_SensorControl.Text = "Sensor Control";
            this.tabPage_SensorControl.UseVisualStyleBackColor = true;
            // 
            // panel_SensorControl_256E
            // 
            this.panel_SensorControl_256E.Controls.Add(this.groupBox_FFCParameters_256E);
            this.panel_SensorControl_256E.Controls.Add(this.button_StoreUserSensorConfig_256E);
            this.panel_SensorControl_256E.Controls.Add(this.button_RestoreDefaultSensorConfig_256E);
            this.panel_SensorControl_256E.Controls.Add(this.groupBox_FluxParameters_256E);
            this.panel_SensorControl_256E.Controls.Add(this.groupBox_GainModeState_256E);
            this.panel_SensorControl_256E.Controls.Add(this.groupBox_FlatFieldCorrection_256E);
            this.panel_SensorControl_256E.Location = new System.Drawing.Point(0, 0);
            this.panel_SensorControl_256E.Name = "panel_SensorControl_256E";
            this.panel_SensorControl_256E.Size = new System.Drawing.Size(719, 240);
            this.panel_SensorControl_256E.TabIndex = 14;
            this.panel_SensorControl_256E.Visible = false;
            // 
            // groupBox_FFCParameters_256E
            // 
            this.groupBox_FFCParameters_256E.Controls.Add(this.tableLayoutPanel10);
            this.groupBox_FFCParameters_256E.Location = new System.Drawing.Point(6, 160);
            this.groupBox_FFCParameters_256E.Name = "groupBox_FFCParameters_256E";
            this.groupBox_FFCParameters_256E.Size = new System.Drawing.Size(467, 77);
            this.groupBox_FFCParameters_256E.TabIndex = 17;
            this.groupBox_FFCParameters_256E.TabStop = false;
            this.groupBox_FFCParameters_256E.Text = "FFC Parameters";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 6;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.label_FFCParam256E_MaxIntervalTitle, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.textBox_FFCParam256E_MaxIntervalRange, 4, 0);
            this.tableLayoutPanel10.Controls.Add(this.button_GetFFCParameters_256E, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.button_SetFFCParameters_256E, 5, 0);
            this.tableLayoutPanel10.Controls.Add(this.numericUpDown_FFCParam256E_MaxInterval, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.label_FFCParam256E_AutoTriggerThresholdTitle, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.numericUpDown_FFCParam256E_AutoTriggerThreshold, 2, 1);
            this.tableLayoutPanel10.Controls.Add(this.textBox_FFCParam256E_AutoTriggerThresholdRange, 4, 1);
            this.tableLayoutPanel10.Controls.Add(this.label_FFCParam256E_MaxIntervalUnit, 3, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(455, 52);
            this.tableLayoutPanel10.TabIndex = 10;
            // 
            // label_FFCParam256E_MaxIntervalTitle
            // 
            this.label_FFCParam256E_MaxIntervalTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FFCParam256E_MaxIntervalTitle.AutoSize = true;
            this.label_FFCParam256E_MaxIntervalTitle.Location = new System.Drawing.Point(78, 0);
            this.label_FFCParam256E_MaxIntervalTitle.Name = "label_FFCParam256E_MaxIntervalTitle";
            this.label_FFCParam256E_MaxIntervalTitle.Size = new System.Drawing.Size(110, 26);
            this.label_FFCParam256E_MaxIntervalTitle.TabIndex = 1;
            this.label_FFCParam256E_MaxIntervalTitle.Text = "Maximum Interval :";
            this.label_FFCParam256E_MaxIntervalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_FFCParam256E_MaxIntervalRange
            // 
            this.textBox_FFCParam256E_MaxIntervalRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_FFCParam256E_MaxIntervalRange.Enabled = false;
            this.textBox_FFCParam256E_MaxIntervalRange.Location = new System.Drawing.Point(319, 3);
            this.textBox_FFCParam256E_MaxIntervalRange.Name = "textBox_FFCParam256E_MaxIntervalRange";
            this.textBox_FFCParam256E_MaxIntervalRange.ReadOnly = true;
            this.textBox_FFCParam256E_MaxIntervalRange.Size = new System.Drawing.Size(94, 23);
            this.textBox_FFCParam256E_MaxIntervalRange.TabIndex = 9;
            this.textBox_FFCParam256E_MaxIntervalRange.Text = "5 ~ 655";
            this.textBox_FFCParam256E_MaxIntervalRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_GetFFCParameters_256E
            // 
            this.button_GetFFCParameters_256E.Location = new System.Drawing.Point(194, 3);
            this.button_GetFFCParameters_256E.Name = "button_GetFFCParameters_256E";
            this.tableLayoutPanel10.SetRowSpan(this.button_GetFFCParameters_256E, 2);
            this.button_GetFFCParameters_256E.Size = new System.Drawing.Size(33, 46);
            this.button_GetFFCParameters_256E.TabIndex = 6;
            this.button_GetFFCParameters_256E.Text = "Get";
            this.button_GetFFCParameters_256E.UseVisualStyleBackColor = true;
            this.button_GetFFCParameters_256E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // button_SetFFCParameters_256E
            // 
            this.button_SetFFCParameters_256E.Enabled = false;
            this.button_SetFFCParameters_256E.Location = new System.Drawing.Point(419, 3);
            this.button_SetFFCParameters_256E.Name = "button_SetFFCParameters_256E";
            this.tableLayoutPanel10.SetRowSpan(this.button_SetFFCParameters_256E, 2);
            this.button_SetFFCParameters_256E.Size = new System.Drawing.Size(34, 46);
            this.button_SetFFCParameters_256E.TabIndex = 6;
            this.button_SetFFCParameters_256E.Text = "Set";
            this.button_SetFFCParameters_256E.UseVisualStyleBackColor = true;
            this.button_SetFFCParameters_256E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // numericUpDown_FFCParam256E_MaxInterval
            // 
            this.numericUpDown_FFCParam256E_MaxInterval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_FFCParam256E_MaxInterval.Enabled = false;
            this.numericUpDown_FFCParam256E_MaxInterval.Location = new System.Drawing.Point(233, 3);
            this.numericUpDown_FFCParam256E_MaxInterval.Maximum = new decimal(new int[] {
            655,
            0,
            0,
            0});
            this.numericUpDown_FFCParam256E_MaxInterval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_FFCParam256E_MaxInterval.Name = "numericUpDown_FFCParam256E_MaxInterval";
            this.numericUpDown_FFCParam256E_MaxInterval.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_FFCParam256E_MaxInterval.TabIndex = 12;
            this.numericUpDown_FFCParam256E_MaxInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FFCParam256E_MaxInterval.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_FFCParam256E_MaxInterval.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDown_FFCParam256E_MaxInterval.ValueChanged += new System.EventHandler(this.numericUpDown_FFCParam256E_MaxInterval_ValueChanged);
            // 
            // label_FFCParam256E_AutoTriggerThresholdTitle
            // 
            this.label_FFCParam256E_AutoTriggerThresholdTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FFCParam256E_AutoTriggerThresholdTitle.AutoSize = true;
            this.label_FFCParam256E_AutoTriggerThresholdTitle.Location = new System.Drawing.Point(25, 26);
            this.label_FFCParam256E_AutoTriggerThresholdTitle.Name = "label_FFCParam256E_AutoTriggerThresholdTitle";
            this.label_FFCParam256E_AutoTriggerThresholdTitle.Size = new System.Drawing.Size(163, 26);
            this.label_FFCParam256E_AutoTriggerThresholdTitle.TabIndex = 10;
            this.label_FFCParam256E_AutoTriggerThresholdTitle.Text = "Automatic Trigger Threshold :";
            this.label_FFCParam256E_AutoTriggerThresholdTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_FFCParam256E_AutoTriggerThreshold
            // 
            this.numericUpDown_FFCParam256E_AutoTriggerThreshold.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_FFCParam256E_AutoTriggerThreshold.Enabled = false;
            this.numericUpDown_FFCParam256E_AutoTriggerThreshold.Location = new System.Drawing.Point(233, 29);
            this.numericUpDown_FFCParam256E_AutoTriggerThreshold.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown_FFCParam256E_AutoTriggerThreshold.Name = "numericUpDown_FFCParam256E_AutoTriggerThreshold";
            this.numericUpDown_FFCParam256E_AutoTriggerThreshold.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_FFCParam256E_AutoTriggerThreshold.TabIndex = 14;
            this.numericUpDown_FFCParam256E_AutoTriggerThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FFCParam256E_AutoTriggerThreshold.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_FFCParam256E_AutoTriggerThreshold.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_FFCParam256E_AutoTriggerThreshold.ValueChanged += new System.EventHandler(this.numericUpDown_FFCParam256E_AutoTriggerThreshold_ValueChanged);
            // 
            // textBox_FFCParam256E_AutoTriggerThresholdRange
            // 
            this.textBox_FFCParam256E_AutoTriggerThresholdRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_FFCParam256E_AutoTriggerThresholdRange.Enabled = false;
            this.textBox_FFCParam256E_AutoTriggerThresholdRange.Location = new System.Drawing.Point(319, 29);
            this.textBox_FFCParam256E_AutoTriggerThresholdRange.Name = "textBox_FFCParam256E_AutoTriggerThresholdRange";
            this.textBox_FFCParam256E_AutoTriggerThresholdRange.ReadOnly = true;
            this.textBox_FFCParam256E_AutoTriggerThresholdRange.Size = new System.Drawing.Size(94, 23);
            this.textBox_FFCParam256E_AutoTriggerThresholdRange.TabIndex = 9;
            this.textBox_FFCParam256E_AutoTriggerThresholdRange.Text = "0 ~ 65535";
            this.textBox_FFCParam256E_AutoTriggerThresholdRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_FFCParam256E_MaxIntervalUnit
            // 
            this.label_FFCParam256E_MaxIntervalUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_FFCParam256E_MaxIntervalUnit.AutoSize = true;
            this.label_FFCParam256E_MaxIntervalUnit.Location = new System.Drawing.Point(300, 5);
            this.label_FFCParam256E_MaxIntervalUnit.Margin = new System.Windows.Forms.Padding(0);
            this.label_FFCParam256E_MaxIntervalUnit.Name = "label_FFCParam256E_MaxIntervalUnit";
            this.label_FFCParam256E_MaxIntervalUnit.Size = new System.Drawing.Size(12, 15);
            this.label_FFCParam256E_MaxIntervalUnit.TabIndex = 28;
            this.label_FFCParam256E_MaxIntervalUnit.Text = "s";
            // 
            // button_StoreUserSensorConfig_256E
            // 
            this.button_StoreUserSensorConfig_256E.Location = new System.Drawing.Point(489, 189);
            this.button_StoreUserSensorConfig_256E.Name = "button_StoreUserSensorConfig_256E";
            this.button_StoreUserSensorConfig_256E.Size = new System.Drawing.Size(104, 45);
            this.button_StoreUserSensorConfig_256E.TabIndex = 16;
            this.button_StoreUserSensorConfig_256E.Text = "Store Config Permanently";
            this.button_StoreUserSensorConfig_256E.UseVisualStyleBackColor = true;
            this.button_StoreUserSensorConfig_256E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // button_RestoreDefaultSensorConfig_256E
            // 
            this.button_RestoreDefaultSensorConfig_256E.Location = new System.Drawing.Point(599, 189);
            this.button_RestoreDefaultSensorConfig_256E.Name = "button_RestoreDefaultSensorConfig_256E";
            this.button_RestoreDefaultSensorConfig_256E.Size = new System.Drawing.Size(114, 45);
            this.button_RestoreDefaultSensorConfig_256E.TabIndex = 12;
            this.button_RestoreDefaultSensorConfig_256E.Text = "Restore to Factory Default";
            this.button_RestoreDefaultSensorConfig_256E.UseVisualStyleBackColor = true;
            this.button_RestoreDefaultSensorConfig_256E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // groupBox_FluxParameters_256E
            // 
            this.groupBox_FluxParameters_256E.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_FluxParameters_256E.Location = new System.Drawing.Point(6, 3);
            this.groupBox_FluxParameters_256E.Name = "groupBox_FluxParameters_256E";
            this.groupBox_FluxParameters_256E.Size = new System.Drawing.Size(467, 155);
            this.groupBox_FluxParameters_256E.TabIndex = 13;
            this.groupBox_FluxParameters_256E.TabStop = false;
            this.groupBox_FluxParameters_256E.Text = "Flux Parameters";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label_FluxParam256E_DistanceTitle, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_FluxParam256E_EmissivityTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_FluxParam256E_EmissivityRange, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_GetFluxParameters_256E, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_SetFluxParameters_256E, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_FluxParam256E_Emissivity, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_FluxParam256E_AtmosphericTransmittanceTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_FluxParam256E_AtmosphericTransmittance, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_FluxParam256E_AtmosphericTransmittanceRange, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_FluxParam256E_AtmosphericTemperatureTitle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_FluxParam256E_AtmosphericTemperature, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_FluxParam256E_AtmosphericTemperatureRange, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_FluxParam256E_AtmosphericTemperatureUnit, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_FluxParam256E_AmbientReflectionTemperatureTitle, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_FluxParam256E_AmbientReflectionTemperature, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_FluxParam256E_AmbientReflectionTemperatureUnit, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_FluxParam256E_AmbientReflectionTemperatureRange, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_FluxParam256E_Distance, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_FluxParam256E_DistanceUnit, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_FluxParam256E_DistanceRange, 4, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 130);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label_FluxParam256E_DistanceTitle
            // 
            this.label_FluxParam256E_DistanceTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FluxParam256E_DistanceTitle.AutoSize = true;
            this.label_FluxParam256E_DistanceTitle.Location = new System.Drawing.Point(55, 104);
            this.label_FluxParam256E_DistanceTitle.Name = "label_FluxParam256E_DistanceTitle";
            this.label_FluxParam256E_DistanceTitle.Size = new System.Drawing.Size(133, 26);
            this.label_FluxParam256E_DistanceTitle.TabIndex = 25;
            this.label_FluxParam256E_DistanceTitle.Text = "Distance (Not support) :";
            this.label_FluxParam256E_DistanceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_FluxParam256E_EmissivityTitle
            // 
            this.label_FluxParam256E_EmissivityTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FluxParam256E_EmissivityTitle.AutoSize = true;
            this.label_FluxParam256E_EmissivityTitle.Location = new System.Drawing.Point(123, 0);
            this.label_FluxParam256E_EmissivityTitle.Name = "label_FluxParam256E_EmissivityTitle";
            this.label_FluxParam256E_EmissivityTitle.Size = new System.Drawing.Size(65, 26);
            this.label_FluxParam256E_EmissivityTitle.TabIndex = 1;
            this.label_FluxParam256E_EmissivityTitle.Text = "Emissivity :";
            this.label_FluxParam256E_EmissivityTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_FluxParam256E_EmissivityRange
            // 
            this.textBox_FluxParam256E_EmissivityRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_FluxParam256E_EmissivityRange.Enabled = false;
            this.textBox_FluxParam256E_EmissivityRange.Location = new System.Drawing.Point(319, 3);
            this.textBox_FluxParam256E_EmissivityRange.Name = "textBox_FluxParam256E_EmissivityRange";
            this.textBox_FluxParam256E_EmissivityRange.ReadOnly = true;
            this.textBox_FluxParam256E_EmissivityRange.Size = new System.Drawing.Size(94, 23);
            this.textBox_FluxParam256E_EmissivityRange.TabIndex = 9;
            this.textBox_FluxParam256E_EmissivityRange.Text = "0.01 ~ 1.00";
            this.textBox_FluxParam256E_EmissivityRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_GetFluxParameters_256E
            // 
            this.button_GetFluxParameters_256E.Location = new System.Drawing.Point(194, 3);
            this.button_GetFluxParameters_256E.Name = "button_GetFluxParameters_256E";
            this.tableLayoutPanel1.SetRowSpan(this.button_GetFluxParameters_256E, 5);
            this.button_GetFluxParameters_256E.Size = new System.Drawing.Size(33, 124);
            this.button_GetFluxParameters_256E.TabIndex = 6;
            this.button_GetFluxParameters_256E.Text = "Get";
            this.button_GetFluxParameters_256E.UseVisualStyleBackColor = true;
            this.button_GetFluxParameters_256E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // button_SetFluxParameters_256E
            // 
            this.button_SetFluxParameters_256E.Enabled = false;
            this.button_SetFluxParameters_256E.Location = new System.Drawing.Point(419, 3);
            this.button_SetFluxParameters_256E.Name = "button_SetFluxParameters_256E";
            this.tableLayoutPanel1.SetRowSpan(this.button_SetFluxParameters_256E, 5);
            this.button_SetFluxParameters_256E.Size = new System.Drawing.Size(34, 124);
            this.button_SetFluxParameters_256E.TabIndex = 6;
            this.button_SetFluxParameters_256E.Text = "Set";
            this.button_SetFluxParameters_256E.UseVisualStyleBackColor = true;
            this.button_SetFluxParameters_256E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // numericUpDown_FluxParam256E_Emissivity
            // 
            this.numericUpDown_FluxParam256E_Emissivity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_FluxParam256E_Emissivity.DecimalPlaces = 2;
            this.numericUpDown_FluxParam256E_Emissivity.Enabled = false;
            this.numericUpDown_FluxParam256E_Emissivity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam256E_Emissivity.Location = new System.Drawing.Point(233, 3);
            this.numericUpDown_FluxParam256E_Emissivity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_FluxParam256E_Emissivity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam256E_Emissivity.Name = "numericUpDown_FluxParam256E_Emissivity";
            this.numericUpDown_FluxParam256E_Emissivity.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_FluxParam256E_Emissivity.TabIndex = 12;
            this.numericUpDown_FluxParam256E_Emissivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FluxParam256E_Emissivity.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_FluxParam256E_Emissivity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_FluxParam256E_Emissivity.ValueChanged += new System.EventHandler(this.numericUpDown_FluxParam256E_Emissivity_ValueChanged);
            // 
            // label_FluxParam256E_AtmosphericTransmittanceTitle
            // 
            this.label_FluxParam256E_AtmosphericTransmittanceTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FluxParam256E_AtmosphericTransmittanceTitle.AutoSize = true;
            this.label_FluxParam256E_AtmosphericTransmittanceTitle.Location = new System.Drawing.Point(30, 26);
            this.label_FluxParam256E_AtmosphericTransmittanceTitle.Name = "label_FluxParam256E_AtmosphericTransmittanceTitle";
            this.label_FluxParam256E_AtmosphericTransmittanceTitle.Size = new System.Drawing.Size(158, 26);
            this.label_FluxParam256E_AtmosphericTransmittanceTitle.TabIndex = 10;
            this.label_FluxParam256E_AtmosphericTransmittanceTitle.Text = "Atmospheric Transmittance :";
            this.label_FluxParam256E_AtmosphericTransmittanceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_FluxParam256E_AtmosphericTransmittance
            // 
            this.numericUpDown_FluxParam256E_AtmosphericTransmittance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_FluxParam256E_AtmosphericTransmittance.DecimalPlaces = 2;
            this.numericUpDown_FluxParam256E_AtmosphericTransmittance.Enabled = false;
            this.numericUpDown_FluxParam256E_AtmosphericTransmittance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam256E_AtmosphericTransmittance.Location = new System.Drawing.Point(233, 29);
            this.numericUpDown_FluxParam256E_AtmosphericTransmittance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_FluxParam256E_AtmosphericTransmittance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam256E_AtmosphericTransmittance.Name = "numericUpDown_FluxParam256E_AtmosphericTransmittance";
            this.numericUpDown_FluxParam256E_AtmosphericTransmittance.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_FluxParam256E_AtmosphericTransmittance.TabIndex = 14;
            this.numericUpDown_FluxParam256E_AtmosphericTransmittance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FluxParam256E_AtmosphericTransmittance.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_FluxParam256E_AtmosphericTransmittance.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam256E_AtmosphericTransmittance.ValueChanged += new System.EventHandler(this.numericUpDown_FluxParam256E_AtmosphericTransmittance_ValueChanged);
            // 
            // textBox_FluxParam256E_AtmosphericTransmittanceRange
            // 
            this.textBox_FluxParam256E_AtmosphericTransmittanceRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_FluxParam256E_AtmosphericTransmittanceRange.Enabled = false;
            this.textBox_FluxParam256E_AtmosphericTransmittanceRange.Location = new System.Drawing.Point(319, 29);
            this.textBox_FluxParam256E_AtmosphericTransmittanceRange.Name = "textBox_FluxParam256E_AtmosphericTransmittanceRange";
            this.textBox_FluxParam256E_AtmosphericTransmittanceRange.ReadOnly = true;
            this.textBox_FluxParam256E_AtmosphericTransmittanceRange.Size = new System.Drawing.Size(94, 23);
            this.textBox_FluxParam256E_AtmosphericTransmittanceRange.TabIndex = 9;
            this.textBox_FluxParam256E_AtmosphericTransmittanceRange.Text = "0.01 ~ 1.00";
            this.textBox_FluxParam256E_AtmosphericTransmittanceRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_FluxParam256E_AtmosphericTemperatureTitle
            // 
            this.label_FluxParam256E_AtmosphericTemperatureTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FluxParam256E_AtmosphericTemperatureTitle.AutoSize = true;
            this.label_FluxParam256E_AtmosphericTemperatureTitle.Location = new System.Drawing.Point(38, 52);
            this.label_FluxParam256E_AtmosphericTemperatureTitle.Name = "label_FluxParam256E_AtmosphericTemperatureTitle";
            this.label_FluxParam256E_AtmosphericTemperatureTitle.Size = new System.Drawing.Size(150, 26);
            this.label_FluxParam256E_AtmosphericTemperatureTitle.TabIndex = 11;
            this.label_FluxParam256E_AtmosphericTemperatureTitle.Text = "Atmospheric Temperature :";
            this.label_FluxParam256E_AtmosphericTemperatureTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_FluxParam256E_AtmosphericTemperature
            // 
            this.numericUpDown_FluxParam256E_AtmosphericTemperature.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_FluxParam256E_AtmosphericTemperature.DecimalPlaces = 2;
            this.numericUpDown_FluxParam256E_AtmosphericTemperature.Enabled = false;
            this.numericUpDown_FluxParam256E_AtmosphericTemperature.Location = new System.Drawing.Point(233, 55);
            this.numericUpDown_FluxParam256E_AtmosphericTemperature.Maximum = new decimal(new int[] {
            62685,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam256E_AtmosphericTemperature.Minimum = new decimal(new int[] {
            4315,
            0,
            0,
            -2147352576});
            this.numericUpDown_FluxParam256E_AtmosphericTemperature.Name = "numericUpDown_FluxParam256E_AtmosphericTemperature";
            this.numericUpDown_FluxParam256E_AtmosphericTemperature.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_FluxParam256E_AtmosphericTemperature.TabIndex = 15;
            this.numericUpDown_FluxParam256E_AtmosphericTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FluxParam256E_AtmosphericTemperature.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_FluxParam256E_AtmosphericTemperature.Value = new decimal(new int[] {
            2685,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam256E_AtmosphericTemperature.ValueChanged += new System.EventHandler(this.numericUpDown_FluxParam256E_AtmosphericTemperature_ValueChanged);
            // 
            // textBox_FluxParam256E_AtmosphericTemperatureRange
            // 
            this.textBox_FluxParam256E_AtmosphericTemperatureRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_FluxParam256E_AtmosphericTemperatureRange.Enabled = false;
            this.textBox_FluxParam256E_AtmosphericTemperatureRange.Location = new System.Drawing.Point(319, 55);
            this.textBox_FluxParam256E_AtmosphericTemperatureRange.Name = "textBox_FluxParam256E_AtmosphericTemperatureRange";
            this.textBox_FluxParam256E_AtmosphericTemperatureRange.ReadOnly = true;
            this.textBox_FluxParam256E_AtmosphericTemperatureRange.Size = new System.Drawing.Size(94, 23);
            this.textBox_FluxParam256E_AtmosphericTemperatureRange.TabIndex = 9;
            this.textBox_FluxParam256E_AtmosphericTemperatureRange.Text = "-43.15 ~ 626.85";
            this.textBox_FluxParam256E_AtmosphericTemperatureRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_FluxParam256E_AtmosphericTemperatureUnit
            // 
            this.label_FluxParam256E_AtmosphericTemperatureUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_FluxParam256E_AtmosphericTemperatureUnit.AutoSize = true;
            this.label_FluxParam256E_AtmosphericTemperatureUnit.Location = new System.Drawing.Point(296, 57);
            this.label_FluxParam256E_AtmosphericTemperatureUnit.Margin = new System.Windows.Forms.Padding(0);
            this.label_FluxParam256E_AtmosphericTemperatureUnit.Name = "label_FluxParam256E_AtmosphericTemperatureUnit";
            this.label_FluxParam256E_AtmosphericTemperatureUnit.Size = new System.Drawing.Size(19, 15);
            this.label_FluxParam256E_AtmosphericTemperatureUnit.TabIndex = 22;
            this.label_FluxParam256E_AtmosphericTemperatureUnit.Text = "℃";
            // 
            // label_FluxParam256E_AmbientReflectionTemperatureTitle
            // 
            this.label_FluxParam256E_AmbientReflectionTemperatureTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FluxParam256E_AmbientReflectionTemperatureTitle.AutoSize = true;
            this.label_FluxParam256E_AmbientReflectionTemperatureTitle.Location = new System.Drawing.Point(4, 78);
            this.label_FluxParam256E_AmbientReflectionTemperatureTitle.Name = "label_FluxParam256E_AmbientReflectionTemperatureTitle";
            this.label_FluxParam256E_AmbientReflectionTemperatureTitle.Size = new System.Drawing.Size(184, 26);
            this.label_FluxParam256E_AmbientReflectionTemperatureTitle.TabIndex = 11;
            this.label_FluxParam256E_AmbientReflectionTemperatureTitle.Text = "Ambient Reflection Temperature :";
            this.label_FluxParam256E_AmbientReflectionTemperatureTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_FluxParam256E_AmbientReflectionTemperature
            // 
            this.numericUpDown_FluxParam256E_AmbientReflectionTemperature.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_FluxParam256E_AmbientReflectionTemperature.DecimalPlaces = 2;
            this.numericUpDown_FluxParam256E_AmbientReflectionTemperature.Enabled = false;
            this.numericUpDown_FluxParam256E_AmbientReflectionTemperature.Location = new System.Drawing.Point(233, 81);
            this.numericUpDown_FluxParam256E_AmbientReflectionTemperature.Maximum = new decimal(new int[] {
            62685,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam256E_AmbientReflectionTemperature.Minimum = new decimal(new int[] {
            4315,
            0,
            0,
            -2147352576});
            this.numericUpDown_FluxParam256E_AmbientReflectionTemperature.Name = "numericUpDown_FluxParam256E_AmbientReflectionTemperature";
            this.numericUpDown_FluxParam256E_AmbientReflectionTemperature.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_FluxParam256E_AmbientReflectionTemperature.TabIndex = 16;
            this.numericUpDown_FluxParam256E_AmbientReflectionTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FluxParam256E_AmbientReflectionTemperature.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_FluxParam256E_AmbientReflectionTemperature.Value = new decimal(new int[] {
            2685,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam256E_AmbientReflectionTemperature.ValueChanged += new System.EventHandler(this.numericUpDown_FluxParam256E_ReflectionTemperature_ValueChanged);
            // 
            // label_FluxParam256E_AmbientReflectionTemperatureUnit
            // 
            this.label_FluxParam256E_AmbientReflectionTemperatureUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_FluxParam256E_AmbientReflectionTemperatureUnit.AutoSize = true;
            this.label_FluxParam256E_AmbientReflectionTemperatureUnit.Location = new System.Drawing.Point(296, 83);
            this.label_FluxParam256E_AmbientReflectionTemperatureUnit.Margin = new System.Windows.Forms.Padding(0);
            this.label_FluxParam256E_AmbientReflectionTemperatureUnit.Name = "label_FluxParam256E_AmbientReflectionTemperatureUnit";
            this.label_FluxParam256E_AmbientReflectionTemperatureUnit.Size = new System.Drawing.Size(19, 15);
            this.label_FluxParam256E_AmbientReflectionTemperatureUnit.TabIndex = 24;
            this.label_FluxParam256E_AmbientReflectionTemperatureUnit.Text = "℃";
            // 
            // textBox_FluxParam256E_AmbientReflectionTemperatureRange
            // 
            this.textBox_FluxParam256E_AmbientReflectionTemperatureRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_FluxParam256E_AmbientReflectionTemperatureRange.Enabled = false;
            this.textBox_FluxParam256E_AmbientReflectionTemperatureRange.Location = new System.Drawing.Point(319, 81);
            this.textBox_FluxParam256E_AmbientReflectionTemperatureRange.Name = "textBox_FluxParam256E_AmbientReflectionTemperatureRange";
            this.textBox_FluxParam256E_AmbientReflectionTemperatureRange.ReadOnly = true;
            this.textBox_FluxParam256E_AmbientReflectionTemperatureRange.Size = new System.Drawing.Size(94, 23);
            this.textBox_FluxParam256E_AmbientReflectionTemperatureRange.TabIndex = 9;
            this.textBox_FluxParam256E_AmbientReflectionTemperatureRange.Text = "-43.15 ~ 626.85";
            this.textBox_FluxParam256E_AmbientReflectionTemperatureRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_FluxParam256E_Distance
            // 
            this.numericUpDown_FluxParam256E_Distance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_FluxParam256E_Distance.DecimalPlaces = 2;
            this.numericUpDown_FluxParam256E_Distance.Enabled = false;
            this.numericUpDown_FluxParam256E_Distance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam256E_Distance.Location = new System.Drawing.Point(233, 107);
            this.numericUpDown_FluxParam256E_Distance.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_FluxParam256E_Distance.Name = "numericUpDown_FluxParam256E_Distance";
            this.numericUpDown_FluxParam256E_Distance.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_FluxParam256E_Distance.TabIndex = 26;
            this.numericUpDown_FluxParam256E_Distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FluxParam256E_Distance.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_FluxParam256E_Distance.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam256E_Distance.ValueChanged += new System.EventHandler(this.numericUpDown_FluxParam256E_Distance_ValueChanged);
            // 
            // label_FluxParam256E_DistanceUnit
            // 
            this.label_FluxParam256E_DistanceUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_FluxParam256E_DistanceUnit.AutoSize = true;
            this.label_FluxParam256E_DistanceUnit.Location = new System.Drawing.Point(297, 109);
            this.label_FluxParam256E_DistanceUnit.Margin = new System.Windows.Forms.Padding(0);
            this.label_FluxParam256E_DistanceUnit.Name = "label_FluxParam256E_DistanceUnit";
            this.label_FluxParam256E_DistanceUnit.Size = new System.Drawing.Size(18, 15);
            this.label_FluxParam256E_DistanceUnit.TabIndex = 27;
            this.label_FluxParam256E_DistanceUnit.Text = "m";
            // 
            // textBox_FluxParam256E_DistanceRange
            // 
            this.textBox_FluxParam256E_DistanceRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_FluxParam256E_DistanceRange.Enabled = false;
            this.textBox_FluxParam256E_DistanceRange.Location = new System.Drawing.Point(319, 107);
            this.textBox_FluxParam256E_DistanceRange.Name = "textBox_FluxParam256E_DistanceRange";
            this.textBox_FluxParam256E_DistanceRange.ReadOnly = true;
            this.textBox_FluxParam256E_DistanceRange.Size = new System.Drawing.Size(94, 23);
            this.textBox_FluxParam256E_DistanceRange.TabIndex = 28;
            this.textBox_FluxParam256E_DistanceRange.Text = "0.00 ~ 200.00";
            this.textBox_FluxParam256E_DistanceRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox_GainModeState_256E
            // 
            this.groupBox_GainModeState_256E.Controls.Add(this.button_SetGainModeState_256E);
            this.groupBox_GainModeState_256E.Controls.Add(this.button_GetGainModeState_256E);
            this.groupBox_GainModeState_256E.Controls.Add(this.radioButton_GainModeStateLow_256E);
            this.groupBox_GainModeState_256E.Controls.Add(this.radioButton_GainModeStateHigh_256E);
            this.groupBox_GainModeState_256E.Location = new System.Drawing.Point(489, 3);
            this.groupBox_GainModeState_256E.Name = "groupBox_GainModeState_256E";
            this.groupBox_GainModeState_256E.Size = new System.Drawing.Size(224, 74);
            this.groupBox_GainModeState_256E.TabIndex = 15;
            this.groupBox_GainModeState_256E.TabStop = false;
            this.groupBox_GainModeState_256E.Text = "Gain Mode State";
            // 
            // button_SetGainModeState_256E
            // 
            this.button_SetGainModeState_256E.Location = new System.Drawing.Point(162, 24);
            this.button_SetGainModeState_256E.Name = "button_SetGainModeState_256E";
            this.button_SetGainModeState_256E.Size = new System.Drawing.Size(49, 42);
            this.button_SetGainModeState_256E.TabIndex = 19;
            this.button_SetGainModeState_256E.Text = "Set";
            this.button_SetGainModeState_256E.UseVisualStyleBackColor = true;
            this.button_SetGainModeState_256E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // button_GetGainModeState_256E
            // 
            this.button_GetGainModeState_256E.Location = new System.Drawing.Point(110, 24);
            this.button_GetGainModeState_256E.Name = "button_GetGainModeState_256E";
            this.button_GetGainModeState_256E.Size = new System.Drawing.Size(49, 42);
            this.button_GetGainModeState_256E.TabIndex = 18;
            this.button_GetGainModeState_256E.Text = "Get";
            this.button_GetGainModeState_256E.UseVisualStyleBackColor = true;
            this.button_GetGainModeState_256E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // radioButton_GainModeStateLow_256E
            // 
            this.radioButton_GainModeStateLow_256E.AutoSize = true;
            this.radioButton_GainModeStateLow_256E.Location = new System.Drawing.Point(9, 47);
            this.radioButton_GainModeStateLow_256E.Name = "radioButton_GainModeStateLow_256E";
            this.radioButton_GainModeStateLow_256E.Size = new System.Drawing.Size(47, 19);
            this.radioButton_GainModeStateLow_256E.TabIndex = 1;
            this.radioButton_GainModeStateLow_256E.TabStop = true;
            this.radioButton_GainModeStateLow_256E.Text = "Low";
            this.radioButton_GainModeStateLow_256E.UseVisualStyleBackColor = true;
            // 
            // radioButton_GainModeStateHigh_256E
            // 
            this.radioButton_GainModeStateHigh_256E.AutoSize = true;
            this.radioButton_GainModeStateHigh_256E.Location = new System.Drawing.Point(9, 22);
            this.radioButton_GainModeStateHigh_256E.Name = "radioButton_GainModeStateHigh_256E";
            this.radioButton_GainModeStateHigh_256E.Size = new System.Drawing.Size(51, 19);
            this.radioButton_GainModeStateHigh_256E.TabIndex = 0;
            this.radioButton_GainModeStateHigh_256E.TabStop = true;
            this.radioButton_GainModeStateHigh_256E.Text = "High";
            this.radioButton_GainModeStateHigh_256E.UseVisualStyleBackColor = true;
            // 
            // groupBox_FlatFieldCorrection_256E
            // 
            this.groupBox_FlatFieldCorrection_256E.Controls.Add(this.button_SetFlatFieldCorrectionMode_256E);
            this.groupBox_FlatFieldCorrection_256E.Controls.Add(this.button_GetFlatFieldCorrectionMode_256E);
            this.groupBox_FlatFieldCorrection_256E.Controls.Add(this.radioButton_FlatFieldCorrectionManual_256E);
            this.groupBox_FlatFieldCorrection_256E.Controls.Add(this.button_RunFlatFieldCorrection_256E);
            this.groupBox_FlatFieldCorrection_256E.Controls.Add(this.radioButton_FlatFieldCorrectionAutomatic_256E);
            this.groupBox_FlatFieldCorrection_256E.Location = new System.Drawing.Point(489, 83);
            this.groupBox_FlatFieldCorrection_256E.Name = "groupBox_FlatFieldCorrection_256E";
            this.groupBox_FlatFieldCorrection_256E.Size = new System.Drawing.Size(224, 74);
            this.groupBox_FlatFieldCorrection_256E.TabIndex = 14;
            this.groupBox_FlatFieldCorrection_256E.TabStop = false;
            this.groupBox_FlatFieldCorrection_256E.Text = "Flat Field Correction";
            // 
            // button_SetFlatFieldCorrectionMode_256E
            // 
            this.button_SetFlatFieldCorrectionMode_256E.Location = new System.Drawing.Point(162, 19);
            this.button_SetFlatFieldCorrectionMode_256E.Name = "button_SetFlatFieldCorrectionMode_256E";
            this.button_SetFlatFieldCorrectionMode_256E.Size = new System.Drawing.Size(49, 23);
            this.button_SetFlatFieldCorrectionMode_256E.TabIndex = 18;
            this.button_SetFlatFieldCorrectionMode_256E.Text = "Set";
            this.button_SetFlatFieldCorrectionMode_256E.UseVisualStyleBackColor = true;
            this.button_SetFlatFieldCorrectionMode_256E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // button_GetFlatFieldCorrectionMode_256E
            // 
            this.button_GetFlatFieldCorrectionMode_256E.Location = new System.Drawing.Point(110, 19);
            this.button_GetFlatFieldCorrectionMode_256E.Name = "button_GetFlatFieldCorrectionMode_256E";
            this.button_GetFlatFieldCorrectionMode_256E.Size = new System.Drawing.Size(50, 23);
            this.button_GetFlatFieldCorrectionMode_256E.TabIndex = 17;
            this.button_GetFlatFieldCorrectionMode_256E.Text = "Get";
            this.button_GetFlatFieldCorrectionMode_256E.UseVisualStyleBackColor = true;
            this.button_GetFlatFieldCorrectionMode_256E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // radioButton_FlatFieldCorrectionManual_256E
            // 
            this.radioButton_FlatFieldCorrectionManual_256E.AutoSize = true;
            this.radioButton_FlatFieldCorrectionManual_256E.Location = new System.Drawing.Point(8, 45);
            this.radioButton_FlatFieldCorrectionManual_256E.Name = "radioButton_FlatFieldCorrectionManual_256E";
            this.radioButton_FlatFieldCorrectionManual_256E.Size = new System.Drawing.Size(65, 19);
            this.radioButton_FlatFieldCorrectionManual_256E.TabIndex = 16;
            this.radioButton_FlatFieldCorrectionManual_256E.TabStop = true;
            this.radioButton_FlatFieldCorrectionManual_256E.Text = "Manual";
            this.radioButton_FlatFieldCorrectionManual_256E.UseVisualStyleBackColor = true;
            // 
            // button_RunFlatFieldCorrection_256E
            // 
            this.button_RunFlatFieldCorrection_256E.Location = new System.Drawing.Point(110, 44);
            this.button_RunFlatFieldCorrection_256E.Name = "button_RunFlatFieldCorrection_256E";
            this.button_RunFlatFieldCorrection_256E.Size = new System.Drawing.Size(101, 23);
            this.button_RunFlatFieldCorrection_256E.TabIndex = 14;
            this.button_RunFlatFieldCorrection_256E.Text = "Run";
            this.button_RunFlatFieldCorrection_256E.UseVisualStyleBackColor = true;
            this.button_RunFlatFieldCorrection_256E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // radioButton_FlatFieldCorrectionAutomatic_256E
            // 
            this.radioButton_FlatFieldCorrectionAutomatic_256E.AutoSize = true;
            this.radioButton_FlatFieldCorrectionAutomatic_256E.Location = new System.Drawing.Point(8, 22);
            this.radioButton_FlatFieldCorrectionAutomatic_256E.Name = "radioButton_FlatFieldCorrectionAutomatic_256E";
            this.radioButton_FlatFieldCorrectionAutomatic_256E.Size = new System.Drawing.Size(81, 19);
            this.radioButton_FlatFieldCorrectionAutomatic_256E.TabIndex = 15;
            this.radioButton_FlatFieldCorrectionAutomatic_256E.TabStop = true;
            this.radioButton_FlatFieldCorrectionAutomatic_256E.Text = "Automatic";
            this.radioButton_FlatFieldCorrectionAutomatic_256E.UseVisualStyleBackColor = true;
            // 
            // panel_SensorControl_160E
            // 
            this.panel_SensorControl_160E.Controls.Add(this.groupBox_FluxParameters_160E);
            this.panel_SensorControl_160E.Controls.Add(this.groupBox_GainModeState_160E);
            this.panel_SensorControl_160E.Controls.Add(this.groupBox_FlatFieldCorrection_160E);
            this.panel_SensorControl_160E.Controls.Add(this.button_RestoreDefaultFluxParameters_160E);
            this.panel_SensorControl_160E.Location = new System.Drawing.Point(0, 0);
            this.panel_SensorControl_160E.Name = "panel_SensorControl_160E";
            this.panel_SensorControl_160E.Size = new System.Drawing.Size(719, 244);
            this.panel_SensorControl_160E.TabIndex = 15;
            this.panel_SensorControl_160E.Visible = false;
            // 
            // groupBox_FluxParameters_160E
            // 
            this.groupBox_FluxParameters_160E.Controls.Add(this.tableLayoutPanel6);
            this.groupBox_FluxParameters_160E.Location = new System.Drawing.Point(6, 3);
            this.groupBox_FluxParameters_160E.Name = "groupBox_FluxParameters_160E";
            this.groupBox_FluxParameters_160E.Size = new System.Drawing.Size(467, 233);
            this.groupBox_FluxParameters_160E.TabIndex = 12;
            this.groupBox_FluxParameters_160E.TabStop = false;
            this.groupBox_FluxParameters_160E.Text = "Flux Parameters";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 6;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.label_FluxParam160E_WindowReflectedTemperatureUnit, 3, 7);
            this.tableLayoutPanel6.Controls.Add(this.label_FluxParam160E_AtmosphericTemperatureUnit, 3, 5);
            this.tableLayoutPanel6.Controls.Add(this.label_FluxParam160E_WindowTemperatureUnit, 3, 3);
            this.tableLayoutPanel6.Controls.Add(this.label_FluxParam160E_BackgroundTemperatureUnit, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDown_FluxParam160E_WindowReflectedTemperature, 2, 7);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDown_FluxParam160E_WindowReflection, 2, 6);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDown_FluxParam160E_AtmosphericTemperature, 2, 5);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDown_FluxParam160E_AtmosphericTransmission, 2, 4);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDown_FluxParam160E_WindowTemperature, 2, 3);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDown_FluxParam160E_WindowTransmission, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.label_FluxParam160E_SceneEmissivityTitle, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBox_FluxParam160E_SceneEmissivityRange, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.button_GetFluxParameters_160E, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.button_SetFluxParameters_160E, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.label_FluxParam160E_WindowTransmissionTitle, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label_FluxParam160E_WindowTemperatureTitle, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label_FluxParam160E_AtmosphericTransmissionTitle, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.label_FluxParam160E_AtmosphericTemperatureTitle, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.textBox_FluxParam160E_BackgroundTemperatureRange, 4, 1);
            this.tableLayoutPanel6.Controls.Add(this.textBox_FluxParam160E_WindowTransmissionRange, 4, 2);
            this.tableLayoutPanel6.Controls.Add(this.textBox_FluxParam160E_WindowTemperatureRange, 4, 3);
            this.tableLayoutPanel6.Controls.Add(this.textBox_FluxParam160E_AtmosphericTransmissionRange, 4, 4);
            this.tableLayoutPanel6.Controls.Add(this.textBox_FluxParam160E_AtmosphericTemperatureRange, 4, 5);
            this.tableLayoutPanel6.Controls.Add(this.label_FluxParam160E_WindowReflectionTitle, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.label_FluxParam160E_WindowReflectedTemperatureTitle, 0, 7);
            this.tableLayoutPanel6.Controls.Add(this.textBox_FluxParam160E_WindowReflectionRange, 4, 6);
            this.tableLayoutPanel6.Controls.Add(this.textBox_FluxParam160E_WindowReflectedTemperatureRange, 4, 7);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDown_FluxParam160E_SceneEmissivity, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDown_FluxParam160E_BackgroundTemperature, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.label_FluxParam160E_BackgroundTemperatureTitle, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 8;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(455, 208);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // label_FluxParam160E_WindowReflectedTemperatureUnit
            // 
            this.label_FluxParam160E_WindowReflectedTemperatureUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_FluxParam160E_WindowReflectedTemperatureUnit.AutoSize = true;
            this.label_FluxParam160E_WindowReflectedTemperatureUnit.Location = new System.Drawing.Point(296, 187);
            this.label_FluxParam160E_WindowReflectedTemperatureUnit.Margin = new System.Windows.Forms.Padding(0);
            this.label_FluxParam160E_WindowReflectedTemperatureUnit.Name = "label_FluxParam160E_WindowReflectedTemperatureUnit";
            this.label_FluxParam160E_WindowReflectedTemperatureUnit.Size = new System.Drawing.Size(19, 15);
            this.label_FluxParam160E_WindowReflectedTemperatureUnit.TabIndex = 24;
            this.label_FluxParam160E_WindowReflectedTemperatureUnit.Text = "℃";
            // 
            // label_FluxParam160E_AtmosphericTemperatureUnit
            // 
            this.label_FluxParam160E_AtmosphericTemperatureUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_FluxParam160E_AtmosphericTemperatureUnit.AutoSize = true;
            this.label_FluxParam160E_AtmosphericTemperatureUnit.Location = new System.Drawing.Point(296, 135);
            this.label_FluxParam160E_AtmosphericTemperatureUnit.Margin = new System.Windows.Forms.Padding(0);
            this.label_FluxParam160E_AtmosphericTemperatureUnit.Name = "label_FluxParam160E_AtmosphericTemperatureUnit";
            this.label_FluxParam160E_AtmosphericTemperatureUnit.Size = new System.Drawing.Size(19, 15);
            this.label_FluxParam160E_AtmosphericTemperatureUnit.TabIndex = 22;
            this.label_FluxParam160E_AtmosphericTemperatureUnit.Text = "℃";
            // 
            // label_FluxParam160E_WindowTemperatureUnit
            // 
            this.label_FluxParam160E_WindowTemperatureUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_FluxParam160E_WindowTemperatureUnit.AutoSize = true;
            this.label_FluxParam160E_WindowTemperatureUnit.Location = new System.Drawing.Point(296, 83);
            this.label_FluxParam160E_WindowTemperatureUnit.Margin = new System.Windows.Forms.Padding(0);
            this.label_FluxParam160E_WindowTemperatureUnit.Name = "label_FluxParam160E_WindowTemperatureUnit";
            this.label_FluxParam160E_WindowTemperatureUnit.Size = new System.Drawing.Size(19, 15);
            this.label_FluxParam160E_WindowTemperatureUnit.TabIndex = 20;
            this.label_FluxParam160E_WindowTemperatureUnit.Text = "℃";
            // 
            // label_FluxParam160E_BackgroundTemperatureUnit
            // 
            this.label_FluxParam160E_BackgroundTemperatureUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_FluxParam160E_BackgroundTemperatureUnit.AutoSize = true;
            this.label_FluxParam160E_BackgroundTemperatureUnit.Location = new System.Drawing.Point(296, 31);
            this.label_FluxParam160E_BackgroundTemperatureUnit.Margin = new System.Windows.Forms.Padding(0);
            this.label_FluxParam160E_BackgroundTemperatureUnit.Name = "label_FluxParam160E_BackgroundTemperatureUnit";
            this.label_FluxParam160E_BackgroundTemperatureUnit.Size = new System.Drawing.Size(19, 15);
            this.label_FluxParam160E_BackgroundTemperatureUnit.TabIndex = 18;
            this.label_FluxParam160E_BackgroundTemperatureUnit.Text = "℃";
            // 
            // numericUpDown_FluxParam160E_WindowReflectedTemperature
            // 
            this.numericUpDown_FluxParam160E_WindowReflectedTemperature.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_FluxParam160E_WindowReflectedTemperature.DecimalPlaces = 2;
            this.numericUpDown_FluxParam160E_WindowReflectedTemperature.Enabled = false;
            this.numericUpDown_FluxParam160E_WindowReflectedTemperature.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam160E_WindowReflectedTemperature.Location = new System.Drawing.Point(233, 185);
            this.numericUpDown_FluxParam160E_WindowReflectedTemperature.Maximum = new decimal(new int[] {
            3822,
            0,
            0,
            65536});
            this.numericUpDown_FluxParam160E_WindowReflectedTemperature.Minimum = new decimal(new int[] {
            27315,
            0,
            0,
            -2147352576});
            this.numericUpDown_FluxParam160E_WindowReflectedTemperature.Name = "numericUpDown_FluxParam160E_WindowReflectedTemperature";
            this.numericUpDown_FluxParam160E_WindowReflectedTemperature.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_FluxParam160E_WindowReflectedTemperature.TabIndex = 16;
            this.numericUpDown_FluxParam160E_WindowReflectedTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FluxParam160E_WindowReflectedTemperature.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_FluxParam160E_WindowReflectedTemperature.Value = new decimal(new int[] {
            220,
            0,
            0,
            65536});
            this.numericUpDown_FluxParam160E_WindowReflectedTemperature.ValueChanged += new System.EventHandler(this.numericUpDown_FluxParam160E_WindowReflectedTemperature_ValueChanged);
            // 
            // numericUpDown_FluxParam160E_WindowReflection
            // 
            this.numericUpDown_FluxParam160E_WindowReflection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_FluxParam160E_WindowReflection.DecimalPlaces = 2;
            this.numericUpDown_FluxParam160E_WindowReflection.Enabled = false;
            this.numericUpDown_FluxParam160E_WindowReflection.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam160E_WindowReflection.Location = new System.Drawing.Point(233, 159);
            this.numericUpDown_FluxParam160E_WindowReflection.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam160E_WindowReflection.Name = "numericUpDown_FluxParam160E_WindowReflection";
            this.numericUpDown_FluxParam160E_WindowReflection.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_FluxParam160E_WindowReflection.TabIndex = 15;
            this.numericUpDown_FluxParam160E_WindowReflection.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FluxParam160E_WindowReflection.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_FluxParam160E_WindowReflection.ValueChanged += new System.EventHandler(this.numericUpDown_FluxParam160E_WindowReflection_ValueChanged);
            // 
            // numericUpDown_FluxParam160E_AtmosphericTemperature
            // 
            this.numericUpDown_FluxParam160E_AtmosphericTemperature.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_FluxParam160E_AtmosphericTemperature.DecimalPlaces = 2;
            this.numericUpDown_FluxParam160E_AtmosphericTemperature.Enabled = false;
            this.numericUpDown_FluxParam160E_AtmosphericTemperature.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam160E_AtmosphericTemperature.Location = new System.Drawing.Point(233, 133);
            this.numericUpDown_FluxParam160E_AtmosphericTemperature.Maximum = new decimal(new int[] {
            3822,
            0,
            0,
            65536});
            this.numericUpDown_FluxParam160E_AtmosphericTemperature.Minimum = new decimal(new int[] {
            27315,
            0,
            0,
            -2147352576});
            this.numericUpDown_FluxParam160E_AtmosphericTemperature.Name = "numericUpDown_FluxParam160E_AtmosphericTemperature";
            this.numericUpDown_FluxParam160E_AtmosphericTemperature.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_FluxParam160E_AtmosphericTemperature.TabIndex = 15;
            this.numericUpDown_FluxParam160E_AtmosphericTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FluxParam160E_AtmosphericTemperature.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_FluxParam160E_AtmosphericTemperature.Value = new decimal(new int[] {
            220,
            0,
            0,
            65536});
            this.numericUpDown_FluxParam160E_AtmosphericTemperature.ValueChanged += new System.EventHandler(this.numericUpDown_FluxParam160E_AtmosphericTemperature_ValueChanged);
            // 
            // numericUpDown_FluxParam160E_AtmosphericTransmission
            // 
            this.numericUpDown_FluxParam160E_AtmosphericTransmission.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_FluxParam160E_AtmosphericTransmission.DecimalPlaces = 2;
            this.numericUpDown_FluxParam160E_AtmosphericTransmission.Enabled = false;
            this.numericUpDown_FluxParam160E_AtmosphericTransmission.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam160E_AtmosphericTransmission.Location = new System.Drawing.Point(233, 107);
            this.numericUpDown_FluxParam160E_AtmosphericTransmission.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_FluxParam160E_AtmosphericTransmission.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam160E_AtmosphericTransmission.Name = "numericUpDown_FluxParam160E_AtmosphericTransmission";
            this.numericUpDown_FluxParam160E_AtmosphericTransmission.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_FluxParam160E_AtmosphericTransmission.TabIndex = 14;
            this.numericUpDown_FluxParam160E_AtmosphericTransmission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FluxParam160E_AtmosphericTransmission.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_FluxParam160E_AtmosphericTransmission.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam160E_AtmosphericTransmission.ValueChanged += new System.EventHandler(this.numericUpDown_FluxParam160E_AtmosphericTransmission_ValueChanged);
            // 
            // numericUpDown_FluxParam160E_WindowTemperature
            // 
            this.numericUpDown_FluxParam160E_WindowTemperature.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_FluxParam160E_WindowTemperature.DecimalPlaces = 2;
            this.numericUpDown_FluxParam160E_WindowTemperature.Enabled = false;
            this.numericUpDown_FluxParam160E_WindowTemperature.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam160E_WindowTemperature.Location = new System.Drawing.Point(233, 81);
            this.numericUpDown_FluxParam160E_WindowTemperature.Maximum = new decimal(new int[] {
            3822,
            0,
            0,
            65536});
            this.numericUpDown_FluxParam160E_WindowTemperature.Minimum = new decimal(new int[] {
            27315,
            0,
            0,
            -2147352576});
            this.numericUpDown_FluxParam160E_WindowTemperature.Name = "numericUpDown_FluxParam160E_WindowTemperature";
            this.numericUpDown_FluxParam160E_WindowTemperature.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_FluxParam160E_WindowTemperature.TabIndex = 14;
            this.numericUpDown_FluxParam160E_WindowTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FluxParam160E_WindowTemperature.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_FluxParam160E_WindowTemperature.Value = new decimal(new int[] {
            220,
            0,
            0,
            65536});
            this.numericUpDown_FluxParam160E_WindowTemperature.ValueChanged += new System.EventHandler(this.numericUpDown_FluxParam160E_WindowTemperature_ValueChanged);
            // 
            // numericUpDown_FluxParam160E_WindowTransmission
            // 
            this.numericUpDown_FluxParam160E_WindowTransmission.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_FluxParam160E_WindowTransmission.DecimalPlaces = 2;
            this.numericUpDown_FluxParam160E_WindowTransmission.Enabled = false;
            this.numericUpDown_FluxParam160E_WindowTransmission.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam160E_WindowTransmission.Location = new System.Drawing.Point(233, 55);
            this.numericUpDown_FluxParam160E_WindowTransmission.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_FluxParam160E_WindowTransmission.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam160E_WindowTransmission.Name = "numericUpDown_FluxParam160E_WindowTransmission";
            this.numericUpDown_FluxParam160E_WindowTransmission.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_FluxParam160E_WindowTransmission.TabIndex = 13;
            this.numericUpDown_FluxParam160E_WindowTransmission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FluxParam160E_WindowTransmission.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_FluxParam160E_WindowTransmission.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_FluxParam160E_WindowTransmission.ValueChanged += new System.EventHandler(this.numericUpDown_FluxParam160E_WindowTransmission_ValueChanged);
            // 
            // label_FluxParam160E_SceneEmissivityTitle
            // 
            this.label_FluxParam160E_SceneEmissivityTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FluxParam160E_SceneEmissivityTitle.AutoSize = true;
            this.label_FluxParam160E_SceneEmissivityTitle.Location = new System.Drawing.Point(89, 0);
            this.label_FluxParam160E_SceneEmissivityTitle.Name = "label_FluxParam160E_SceneEmissivityTitle";
            this.label_FluxParam160E_SceneEmissivityTitle.Size = new System.Drawing.Size(99, 26);
            this.label_FluxParam160E_SceneEmissivityTitle.TabIndex = 1;
            this.label_FluxParam160E_SceneEmissivityTitle.Text = "Scene Emissivity :";
            this.label_FluxParam160E_SceneEmissivityTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_FluxParam160E_SceneEmissivityRange
            // 
            this.textBox_FluxParam160E_SceneEmissivityRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_FluxParam160E_SceneEmissivityRange.Enabled = false;
            this.textBox_FluxParam160E_SceneEmissivityRange.Location = new System.Drawing.Point(319, 3);
            this.textBox_FluxParam160E_SceneEmissivityRange.Name = "textBox_FluxParam160E_SceneEmissivityRange";
            this.textBox_FluxParam160E_SceneEmissivityRange.ReadOnly = true;
            this.textBox_FluxParam160E_SceneEmissivityRange.Size = new System.Drawing.Size(94, 23);
            this.textBox_FluxParam160E_SceneEmissivityRange.TabIndex = 9;
            this.textBox_FluxParam160E_SceneEmissivityRange.Text = "0.01 ~ 1.00";
            this.textBox_FluxParam160E_SceneEmissivityRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_GetFluxParameters_160E
            // 
            this.button_GetFluxParameters_160E.Location = new System.Drawing.Point(194, 3);
            this.button_GetFluxParameters_160E.Name = "button_GetFluxParameters_160E";
            this.tableLayoutPanel6.SetRowSpan(this.button_GetFluxParameters_160E, 8);
            this.button_GetFluxParameters_160E.Size = new System.Drawing.Size(33, 202);
            this.button_GetFluxParameters_160E.TabIndex = 6;
            this.button_GetFluxParameters_160E.Text = "Get";
            this.button_GetFluxParameters_160E.UseVisualStyleBackColor = true;
            this.button_GetFluxParameters_160E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // button_SetFluxParameters_160E
            // 
            this.button_SetFluxParameters_160E.Enabled = false;
            this.button_SetFluxParameters_160E.Location = new System.Drawing.Point(419, 3);
            this.button_SetFluxParameters_160E.Name = "button_SetFluxParameters_160E";
            this.tableLayoutPanel6.SetRowSpan(this.button_SetFluxParameters_160E, 8);
            this.button_SetFluxParameters_160E.Size = new System.Drawing.Size(34, 202);
            this.button_SetFluxParameters_160E.TabIndex = 6;
            this.button_SetFluxParameters_160E.Text = "Set";
            this.button_SetFluxParameters_160E.UseVisualStyleBackColor = true;
            this.button_SetFluxParameters_160E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // label_FluxParam160E_WindowTransmissionTitle
            // 
            this.label_FluxParam160E_WindowTransmissionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FluxParam160E_WindowTransmissionTitle.AutoSize = true;
            this.label_FluxParam160E_WindowTransmissionTitle.Location = new System.Drawing.Point(60, 52);
            this.label_FluxParam160E_WindowTransmissionTitle.Name = "label_FluxParam160E_WindowTransmissionTitle";
            this.label_FluxParam160E_WindowTransmissionTitle.Size = new System.Drawing.Size(128, 26);
            this.label_FluxParam160E_WindowTransmissionTitle.TabIndex = 8;
            this.label_FluxParam160E_WindowTransmissionTitle.Text = "Window Transmission :";
            this.label_FluxParam160E_WindowTransmissionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_FluxParam160E_WindowTemperatureTitle
            // 
            this.label_FluxParam160E_WindowTemperatureTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FluxParam160E_WindowTemperatureTitle.AutoSize = true;
            this.label_FluxParam160E_WindowTemperatureTitle.Location = new System.Drawing.Point(62, 78);
            this.label_FluxParam160E_WindowTemperatureTitle.Name = "label_FluxParam160E_WindowTemperatureTitle";
            this.label_FluxParam160E_WindowTemperatureTitle.Size = new System.Drawing.Size(126, 26);
            this.label_FluxParam160E_WindowTemperatureTitle.TabIndex = 9;
            this.label_FluxParam160E_WindowTemperatureTitle.Text = "Window Temperature :";
            this.label_FluxParam160E_WindowTemperatureTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_FluxParam160E_AtmosphericTransmissionTitle
            // 
            this.label_FluxParam160E_AtmosphericTransmissionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FluxParam160E_AtmosphericTransmissionTitle.AutoSize = true;
            this.label_FluxParam160E_AtmosphericTransmissionTitle.Location = new System.Drawing.Point(36, 104);
            this.label_FluxParam160E_AtmosphericTransmissionTitle.Name = "label_FluxParam160E_AtmosphericTransmissionTitle";
            this.label_FluxParam160E_AtmosphericTransmissionTitle.Size = new System.Drawing.Size(152, 26);
            this.label_FluxParam160E_AtmosphericTransmissionTitle.TabIndex = 10;
            this.label_FluxParam160E_AtmosphericTransmissionTitle.Text = "Atmospheric Transmission :";
            this.label_FluxParam160E_AtmosphericTransmissionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_FluxParam160E_AtmosphericTemperatureTitle
            // 
            this.label_FluxParam160E_AtmosphericTemperatureTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FluxParam160E_AtmosphericTemperatureTitle.AutoSize = true;
            this.label_FluxParam160E_AtmosphericTemperatureTitle.Location = new System.Drawing.Point(38, 130);
            this.label_FluxParam160E_AtmosphericTemperatureTitle.Name = "label_FluxParam160E_AtmosphericTemperatureTitle";
            this.label_FluxParam160E_AtmosphericTemperatureTitle.Size = new System.Drawing.Size(150, 26);
            this.label_FluxParam160E_AtmosphericTemperatureTitle.TabIndex = 11;
            this.label_FluxParam160E_AtmosphericTemperatureTitle.Text = "Atmospheric Temperature :";
            this.label_FluxParam160E_AtmosphericTemperatureTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_FluxParam160E_BackgroundTemperatureRange
            // 
            this.textBox_FluxParam160E_BackgroundTemperatureRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_FluxParam160E_BackgroundTemperatureRange.Enabled = false;
            this.textBox_FluxParam160E_BackgroundTemperatureRange.Location = new System.Drawing.Point(319, 29);
            this.textBox_FluxParam160E_BackgroundTemperatureRange.Name = "textBox_FluxParam160E_BackgroundTemperatureRange";
            this.textBox_FluxParam160E_BackgroundTemperatureRange.ReadOnly = true;
            this.textBox_FluxParam160E_BackgroundTemperatureRange.Size = new System.Drawing.Size(94, 23);
            this.textBox_FluxParam160E_BackgroundTemperatureRange.TabIndex = 9;
            this.textBox_FluxParam160E_BackgroundTemperatureRange.Text = "-273.15 ~ 382.2";
            this.textBox_FluxParam160E_BackgroundTemperatureRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_FluxParam160E_WindowTransmissionRange
            // 
            this.textBox_FluxParam160E_WindowTransmissionRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_FluxParam160E_WindowTransmissionRange.Enabled = false;
            this.textBox_FluxParam160E_WindowTransmissionRange.Location = new System.Drawing.Point(319, 55);
            this.textBox_FluxParam160E_WindowTransmissionRange.Name = "textBox_FluxParam160E_WindowTransmissionRange";
            this.textBox_FluxParam160E_WindowTransmissionRange.ReadOnly = true;
            this.textBox_FluxParam160E_WindowTransmissionRange.Size = new System.Drawing.Size(94, 23);
            this.textBox_FluxParam160E_WindowTransmissionRange.TabIndex = 9;
            this.textBox_FluxParam160E_WindowTransmissionRange.Text = "0.01 ~ 1.00";
            this.textBox_FluxParam160E_WindowTransmissionRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_FluxParam160E_WindowTemperatureRange
            // 
            this.textBox_FluxParam160E_WindowTemperatureRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_FluxParam160E_WindowTemperatureRange.Enabled = false;
            this.textBox_FluxParam160E_WindowTemperatureRange.Location = new System.Drawing.Point(319, 81);
            this.textBox_FluxParam160E_WindowTemperatureRange.Name = "textBox_FluxParam160E_WindowTemperatureRange";
            this.textBox_FluxParam160E_WindowTemperatureRange.ReadOnly = true;
            this.textBox_FluxParam160E_WindowTemperatureRange.Size = new System.Drawing.Size(94, 23);
            this.textBox_FluxParam160E_WindowTemperatureRange.TabIndex = 9;
            this.textBox_FluxParam160E_WindowTemperatureRange.Text = "-273.15 ~ 382.2";
            this.textBox_FluxParam160E_WindowTemperatureRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_FluxParam160E_AtmosphericTransmissionRange
            // 
            this.textBox_FluxParam160E_AtmosphericTransmissionRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_FluxParam160E_AtmosphericTransmissionRange.Enabled = false;
            this.textBox_FluxParam160E_AtmosphericTransmissionRange.Location = new System.Drawing.Point(319, 107);
            this.textBox_FluxParam160E_AtmosphericTransmissionRange.Name = "textBox_FluxParam160E_AtmosphericTransmissionRange";
            this.textBox_FluxParam160E_AtmosphericTransmissionRange.ReadOnly = true;
            this.textBox_FluxParam160E_AtmosphericTransmissionRange.Size = new System.Drawing.Size(94, 23);
            this.textBox_FluxParam160E_AtmosphericTransmissionRange.TabIndex = 9;
            this.textBox_FluxParam160E_AtmosphericTransmissionRange.Text = "0.01 ~ 1.00";
            this.textBox_FluxParam160E_AtmosphericTransmissionRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_FluxParam160E_AtmosphericTemperatureRange
            // 
            this.textBox_FluxParam160E_AtmosphericTemperatureRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_FluxParam160E_AtmosphericTemperatureRange.Enabled = false;
            this.textBox_FluxParam160E_AtmosphericTemperatureRange.Location = new System.Drawing.Point(319, 133);
            this.textBox_FluxParam160E_AtmosphericTemperatureRange.Name = "textBox_FluxParam160E_AtmosphericTemperatureRange";
            this.textBox_FluxParam160E_AtmosphericTemperatureRange.ReadOnly = true;
            this.textBox_FluxParam160E_AtmosphericTemperatureRange.Size = new System.Drawing.Size(94, 23);
            this.textBox_FluxParam160E_AtmosphericTemperatureRange.TabIndex = 9;
            this.textBox_FluxParam160E_AtmosphericTemperatureRange.Text = "-273.15 ~ 382.2";
            this.textBox_FluxParam160E_AtmosphericTemperatureRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_FluxParam160E_WindowReflectionTitle
            // 
            this.label_FluxParam160E_WindowReflectionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FluxParam160E_WindowReflectionTitle.AutoSize = true;
            this.label_FluxParam160E_WindowReflectionTitle.Location = new System.Drawing.Point(75, 156);
            this.label_FluxParam160E_WindowReflectionTitle.Name = "label_FluxParam160E_WindowReflectionTitle";
            this.label_FluxParam160E_WindowReflectionTitle.Size = new System.Drawing.Size(113, 26);
            this.label_FluxParam160E_WindowReflectionTitle.TabIndex = 11;
            this.label_FluxParam160E_WindowReflectionTitle.Text = "Window Reflection :";
            this.label_FluxParam160E_WindowReflectionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_FluxParam160E_WindowReflectedTemperatureTitle
            // 
            this.label_FluxParam160E_WindowReflectedTemperatureTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FluxParam160E_WindowReflectedTemperatureTitle.AutoSize = true;
            this.label_FluxParam160E_WindowReflectedTemperatureTitle.Location = new System.Drawing.Point(10, 182);
            this.label_FluxParam160E_WindowReflectedTemperatureTitle.Name = "label_FluxParam160E_WindowReflectedTemperatureTitle";
            this.label_FluxParam160E_WindowReflectedTemperatureTitle.Size = new System.Drawing.Size(178, 26);
            this.label_FluxParam160E_WindowReflectedTemperatureTitle.TabIndex = 11;
            this.label_FluxParam160E_WindowReflectedTemperatureTitle.Text = "Window Reflected Temperature :";
            this.label_FluxParam160E_WindowReflectedTemperatureTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_FluxParam160E_WindowReflectionRange
            // 
            this.textBox_FluxParam160E_WindowReflectionRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_FluxParam160E_WindowReflectionRange.Enabled = false;
            this.textBox_FluxParam160E_WindowReflectionRange.Location = new System.Drawing.Point(319, 159);
            this.textBox_FluxParam160E_WindowReflectionRange.Name = "textBox_FluxParam160E_WindowReflectionRange";
            this.textBox_FluxParam160E_WindowReflectionRange.ReadOnly = true;
            this.textBox_FluxParam160E_WindowReflectionRange.Size = new System.Drawing.Size(94, 23);
            this.textBox_FluxParam160E_WindowReflectionRange.TabIndex = 9;
            this.textBox_FluxParam160E_WindowReflectionRange.Text = "0.00 ~ 0.00";
            this.textBox_FluxParam160E_WindowReflectionRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_FluxParam160E_WindowReflectedTemperatureRange
            // 
            this.textBox_FluxParam160E_WindowReflectedTemperatureRange.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_FluxParam160E_WindowReflectedTemperatureRange.Enabled = false;
            this.textBox_FluxParam160E_WindowReflectedTemperatureRange.Location = new System.Drawing.Point(319, 185);
            this.textBox_FluxParam160E_WindowReflectedTemperatureRange.Name = "textBox_FluxParam160E_WindowReflectedTemperatureRange";
            this.textBox_FluxParam160E_WindowReflectedTemperatureRange.ReadOnly = true;
            this.textBox_FluxParam160E_WindowReflectedTemperatureRange.Size = new System.Drawing.Size(94, 23);
            this.textBox_FluxParam160E_WindowReflectedTemperatureRange.TabIndex = 9;
            this.textBox_FluxParam160E_WindowReflectedTemperatureRange.Text = "-273.15 ~ 382.2";
            this.textBox_FluxParam160E_WindowReflectedTemperatureRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_FluxParam160E_SceneEmissivity
            // 
            this.numericUpDown_FluxParam160E_SceneEmissivity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_FluxParam160E_SceneEmissivity.DecimalPlaces = 2;
            this.numericUpDown_FluxParam160E_SceneEmissivity.Enabled = false;
            this.numericUpDown_FluxParam160E_SceneEmissivity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam160E_SceneEmissivity.Location = new System.Drawing.Point(233, 3);
            this.numericUpDown_FluxParam160E_SceneEmissivity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_FluxParam160E_SceneEmissivity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam160E_SceneEmissivity.Name = "numericUpDown_FluxParam160E_SceneEmissivity";
            this.numericUpDown_FluxParam160E_SceneEmissivity.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_FluxParam160E_SceneEmissivity.TabIndex = 12;
            this.numericUpDown_FluxParam160E_SceneEmissivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FluxParam160E_SceneEmissivity.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_FluxParam160E_SceneEmissivity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_FluxParam160E_SceneEmissivity.ValueChanged += new System.EventHandler(this.numericUpDown_FluxParam160E_SceneEmissivity_ValueChanged);
            // 
            // numericUpDown_FluxParam160E_BackgroundTemperature
            // 
            this.numericUpDown_FluxParam160E_BackgroundTemperature.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDown_FluxParam160E_BackgroundTemperature.DecimalPlaces = 2;
            this.numericUpDown_FluxParam160E_BackgroundTemperature.Enabled = false;
            this.numericUpDown_FluxParam160E_BackgroundTemperature.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_FluxParam160E_BackgroundTemperature.Location = new System.Drawing.Point(233, 29);
            this.numericUpDown_FluxParam160E_BackgroundTemperature.Maximum = new decimal(new int[] {
            3822,
            0,
            0,
            65536});
            this.numericUpDown_FluxParam160E_BackgroundTemperature.Minimum = new decimal(new int[] {
            27315,
            0,
            0,
            -2147352576});
            this.numericUpDown_FluxParam160E_BackgroundTemperature.Name = "numericUpDown_FluxParam160E_BackgroundTemperature";
            this.numericUpDown_FluxParam160E_BackgroundTemperature.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown_FluxParam160E_BackgroundTemperature.TabIndex = 13;
            this.numericUpDown_FluxParam160E_BackgroundTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_FluxParam160E_BackgroundTemperature.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_FluxParam160E_BackgroundTemperature.Value = new decimal(new int[] {
            220,
            0,
            0,
            65536});
            this.numericUpDown_FluxParam160E_BackgroundTemperature.ValueChanged += new System.EventHandler(this.numericUpDown_FluxParam160E_BackgroundTemperature_ValueChanged);
            // 
            // label_FluxParam160E_BackgroundTemperatureTitle
            // 
            this.label_FluxParam160E_BackgroundTemperatureTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FluxParam160E_BackgroundTemperatureTitle.AutoSize = true;
            this.label_FluxParam160E_BackgroundTemperatureTitle.Location = new System.Drawing.Point(42, 26);
            this.label_FluxParam160E_BackgroundTemperatureTitle.Name = "label_FluxParam160E_BackgroundTemperatureTitle";
            this.label_FluxParam160E_BackgroundTemperatureTitle.Size = new System.Drawing.Size(146, 26);
            this.label_FluxParam160E_BackgroundTemperatureTitle.TabIndex = 7;
            this.label_FluxParam160E_BackgroundTemperatureTitle.Text = "Background Temperature :";
            this.label_FluxParam160E_BackgroundTemperatureTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox_GainModeState_160E
            // 
            this.groupBox_GainModeState_160E.Controls.Add(this.button_SetGainModeState_160E);
            this.groupBox_GainModeState_160E.Controls.Add(this.button_GetGainModeState_160E);
            this.groupBox_GainModeState_160E.Controls.Add(this.radioButton_GainModeStateAuto_160E);
            this.groupBox_GainModeState_160E.Controls.Add(this.radioButton_GainModeStateLow_160E);
            this.groupBox_GainModeState_160E.Controls.Add(this.radioButton_GainModeStateHigh_160E);
            this.groupBox_GainModeState_160E.Location = new System.Drawing.Point(489, 3);
            this.groupBox_GainModeState_160E.Name = "groupBox_GainModeState_160E";
            this.groupBox_GainModeState_160E.Size = new System.Drawing.Size(224, 100);
            this.groupBox_GainModeState_160E.TabIndex = 18;
            this.groupBox_GainModeState_160E.TabStop = false;
            this.groupBox_GainModeState_160E.Text = "Gain Mode State";
            // 
            // button_SetGainModeState_160E
            // 
            this.button_SetGainModeState_160E.Location = new System.Drawing.Point(162, 24);
            this.button_SetGainModeState_160E.Name = "button_SetGainModeState_160E";
            this.button_SetGainModeState_160E.Size = new System.Drawing.Size(49, 67);
            this.button_SetGainModeState_160E.TabIndex = 19;
            this.button_SetGainModeState_160E.Text = "Set";
            this.button_SetGainModeState_160E.UseVisualStyleBackColor = true;
            this.button_SetGainModeState_160E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // button_GetGainModeState_160E
            // 
            this.button_GetGainModeState_160E.Location = new System.Drawing.Point(110, 24);
            this.button_GetGainModeState_160E.Name = "button_GetGainModeState_160E";
            this.button_GetGainModeState_160E.Size = new System.Drawing.Size(49, 67);
            this.button_GetGainModeState_160E.TabIndex = 18;
            this.button_GetGainModeState_160E.Text = "Get";
            this.button_GetGainModeState_160E.UseVisualStyleBackColor = true;
            this.button_GetGainModeState_160E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // radioButton_GainModeStateAuto_160E
            // 
            this.radioButton_GainModeStateAuto_160E.AutoSize = true;
            this.radioButton_GainModeStateAuto_160E.Location = new System.Drawing.Point(9, 72);
            this.radioButton_GainModeStateAuto_160E.Name = "radioButton_GainModeStateAuto_160E";
            this.radioButton_GainModeStateAuto_160E.Size = new System.Drawing.Size(81, 19);
            this.radioButton_GainModeStateAuto_160E.TabIndex = 2;
            this.radioButton_GainModeStateAuto_160E.TabStop = true;
            this.radioButton_GainModeStateAuto_160E.Text = "Automatic";
            this.radioButton_GainModeStateAuto_160E.UseVisualStyleBackColor = true;
            // 
            // radioButton_GainModeStateLow_160E
            // 
            this.radioButton_GainModeStateLow_160E.AutoSize = true;
            this.radioButton_GainModeStateLow_160E.Location = new System.Drawing.Point(9, 47);
            this.radioButton_GainModeStateLow_160E.Name = "radioButton_GainModeStateLow_160E";
            this.radioButton_GainModeStateLow_160E.Size = new System.Drawing.Size(47, 19);
            this.radioButton_GainModeStateLow_160E.TabIndex = 1;
            this.radioButton_GainModeStateLow_160E.TabStop = true;
            this.radioButton_GainModeStateLow_160E.Text = "Low";
            this.radioButton_GainModeStateLow_160E.UseVisualStyleBackColor = true;
            // 
            // radioButton_GainModeStateHigh_160E
            // 
            this.radioButton_GainModeStateHigh_160E.AutoSize = true;
            this.radioButton_GainModeStateHigh_160E.Location = new System.Drawing.Point(9, 22);
            this.radioButton_GainModeStateHigh_160E.Name = "radioButton_GainModeStateHigh_160E";
            this.radioButton_GainModeStateHigh_160E.Size = new System.Drawing.Size(51, 19);
            this.radioButton_GainModeStateHigh_160E.TabIndex = 0;
            this.radioButton_GainModeStateHigh_160E.TabStop = true;
            this.radioButton_GainModeStateHigh_160E.Text = "High";
            this.radioButton_GainModeStateHigh_160E.UseVisualStyleBackColor = true;
            // 
            // groupBox_FlatFieldCorrection_160E
            // 
            this.groupBox_FlatFieldCorrection_160E.Controls.Add(this.button_SetFlatFieldCorrectionMode_160E);
            this.groupBox_FlatFieldCorrection_160E.Controls.Add(this.button_GetFlatFieldCorrectionMode_160E);
            this.groupBox_FlatFieldCorrection_160E.Controls.Add(this.radioButton_FlatFieldCorrectionManual_160E);
            this.groupBox_FlatFieldCorrection_160E.Controls.Add(this.button_RunFlatFieldCorrection_160E);
            this.groupBox_FlatFieldCorrection_160E.Controls.Add(this.radioButton_FlatFieldCorrectionAutomatic_160E);
            this.groupBox_FlatFieldCorrection_160E.Location = new System.Drawing.Point(489, 109);
            this.groupBox_FlatFieldCorrection_160E.Name = "groupBox_FlatFieldCorrection_160E";
            this.groupBox_FlatFieldCorrection_160E.Size = new System.Drawing.Size(224, 74);
            this.groupBox_FlatFieldCorrection_160E.TabIndex = 17;
            this.groupBox_FlatFieldCorrection_160E.TabStop = false;
            this.groupBox_FlatFieldCorrection_160E.Text = "Flat Field Correction";
            // 
            // button_SetFlatFieldCorrectionMode_160E
            // 
            this.button_SetFlatFieldCorrectionMode_160E.Location = new System.Drawing.Point(162, 19);
            this.button_SetFlatFieldCorrectionMode_160E.Name = "button_SetFlatFieldCorrectionMode_160E";
            this.button_SetFlatFieldCorrectionMode_160E.Size = new System.Drawing.Size(49, 23);
            this.button_SetFlatFieldCorrectionMode_160E.TabIndex = 18;
            this.button_SetFlatFieldCorrectionMode_160E.Text = "Set";
            this.button_SetFlatFieldCorrectionMode_160E.UseVisualStyleBackColor = true;
            this.button_SetFlatFieldCorrectionMode_160E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // button_GetFlatFieldCorrectionMode_160E
            // 
            this.button_GetFlatFieldCorrectionMode_160E.Location = new System.Drawing.Point(110, 19);
            this.button_GetFlatFieldCorrectionMode_160E.Name = "button_GetFlatFieldCorrectionMode_160E";
            this.button_GetFlatFieldCorrectionMode_160E.Size = new System.Drawing.Size(50, 23);
            this.button_GetFlatFieldCorrectionMode_160E.TabIndex = 17;
            this.button_GetFlatFieldCorrectionMode_160E.Text = "Get";
            this.button_GetFlatFieldCorrectionMode_160E.UseVisualStyleBackColor = true;
            this.button_GetFlatFieldCorrectionMode_160E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // radioButton_FlatFieldCorrectionManual_160E
            // 
            this.radioButton_FlatFieldCorrectionManual_160E.AutoSize = true;
            this.radioButton_FlatFieldCorrectionManual_160E.Location = new System.Drawing.Point(8, 45);
            this.radioButton_FlatFieldCorrectionManual_160E.Name = "radioButton_FlatFieldCorrectionManual_160E";
            this.radioButton_FlatFieldCorrectionManual_160E.Size = new System.Drawing.Size(65, 19);
            this.radioButton_FlatFieldCorrectionManual_160E.TabIndex = 16;
            this.radioButton_FlatFieldCorrectionManual_160E.TabStop = true;
            this.radioButton_FlatFieldCorrectionManual_160E.Text = "Manual";
            this.radioButton_FlatFieldCorrectionManual_160E.UseVisualStyleBackColor = true;
            // 
            // button_RunFlatFieldCorrection_160E
            // 
            this.button_RunFlatFieldCorrection_160E.Location = new System.Drawing.Point(110, 44);
            this.button_RunFlatFieldCorrection_160E.Name = "button_RunFlatFieldCorrection_160E";
            this.button_RunFlatFieldCorrection_160E.Size = new System.Drawing.Size(101, 23);
            this.button_RunFlatFieldCorrection_160E.TabIndex = 14;
            this.button_RunFlatFieldCorrection_160E.Text = "Run";
            this.button_RunFlatFieldCorrection_160E.UseVisualStyleBackColor = true;
            this.button_RunFlatFieldCorrection_160E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // radioButton_FlatFieldCorrectionAutomatic_160E
            // 
            this.radioButton_FlatFieldCorrectionAutomatic_160E.AutoSize = true;
            this.radioButton_FlatFieldCorrectionAutomatic_160E.Location = new System.Drawing.Point(8, 22);
            this.radioButton_FlatFieldCorrectionAutomatic_160E.Name = "radioButton_FlatFieldCorrectionAutomatic_160E";
            this.radioButton_FlatFieldCorrectionAutomatic_160E.Size = new System.Drawing.Size(81, 19);
            this.radioButton_FlatFieldCorrectionAutomatic_160E.TabIndex = 15;
            this.radioButton_FlatFieldCorrectionAutomatic_160E.TabStop = true;
            this.radioButton_FlatFieldCorrectionAutomatic_160E.Text = "Automatic";
            this.radioButton_FlatFieldCorrectionAutomatic_160E.UseVisualStyleBackColor = true;
            // 
            // button_RestoreDefaultFluxParameters_160E
            // 
            this.button_RestoreDefaultFluxParameters_160E.Location = new System.Drawing.Point(489, 197);
            this.button_RestoreDefaultFluxParameters_160E.Name = "button_RestoreDefaultFluxParameters_160E";
            this.button_RestoreDefaultFluxParameters_160E.Size = new System.Drawing.Size(224, 30);
            this.button_RestoreDefaultFluxParameters_160E.TabIndex = 12;
            this.button_RestoreDefaultFluxParameters_160E.Text = "Restore Flux Parameters to Default";
            this.button_RestoreDefaultFluxParameters_160E.UseVisualStyleBackColor = true;
            this.button_RestoreDefaultFluxParameters_160E.Click += new System.EventHandler(this.button_SensorControl_Click);
            // 
            // tabPage_RoiManager
            // 
            this.tabPage_RoiManager.Controls.Add(this.button_RemoveRoiItem);
            this.tabPage_RoiManager.Controls.Add(this.button_AddRoiItem);
            this.tabPage_RoiManager.Controls.Add(this.rbtn_RoiEllipse);
            this.tabPage_RoiManager.Controls.Add(this.rbtn_RoiRect);
            this.tabPage_RoiManager.Controls.Add(this.rbtn_RoiLine);
            this.tabPage_RoiManager.Controls.Add(this.rbtn_RoiSpot);
            this.tabPage_RoiManager.Controls.Add(this.tableLayoutPanel14);
            this.tabPage_RoiManager.Controls.Add(this.tableLayoutPanel13);
            this.tabPage_RoiManager.Controls.Add(this.tableLayoutPanel12);
            this.tabPage_RoiManager.Controls.Add(this.tableLayoutPanel11);
            this.tabPage_RoiManager.Controls.Add(this.label1);
            this.tabPage_RoiManager.Controls.Add(this.comboBox_ListROI);
            this.tabPage_RoiManager.Location = new System.Drawing.Point(4, 24);
            this.tabPage_RoiManager.Name = "tabPage_RoiManager";
            this.tabPage_RoiManager.Size = new System.Drawing.Size(719, 240);
            this.tabPage_RoiManager.TabIndex = 2;
            this.tabPage_RoiManager.Text = "Region of Interests";
            this.tabPage_RoiManager.UseVisualStyleBackColor = true;
            // 
            // button_RemoveRoiItem
            // 
            this.button_RemoveRoiItem.Location = new System.Drawing.Point(129, 32);
            this.button_RemoveRoiItem.Name = "button_RemoveRoiItem";
            this.button_RemoveRoiItem.Size = new System.Drawing.Size(60, 23);
            this.button_RemoveRoiItem.TabIndex = 4;
            this.button_RemoveRoiItem.Text = "Remove";
            this.button_RemoveRoiItem.UseVisualStyleBackColor = true;
            this.button_RemoveRoiItem.Click += new System.EventHandler(this.button_RemoveRoiItem_Click);
            // 
            // button_AddRoiItem
            // 
            this.button_AddRoiItem.Location = new System.Drawing.Point(392, 79);
            this.button_AddRoiItem.Name = "button_AddRoiItem";
            this.button_AddRoiItem.Size = new System.Drawing.Size(60, 98);
            this.button_AddRoiItem.TabIndex = 4;
            this.button_AddRoiItem.Text = "Add";
            this.button_AddRoiItem.UseVisualStyleBackColor = true;
            this.button_AddRoiItem.Click += new System.EventHandler(this.button_AddRoiItem_Click);
            // 
            // rbtn_RoiEllipse
            // 
            this.rbtn_RoiEllipse.AutoSize = true;
            this.rbtn_RoiEllipse.Location = new System.Drawing.Point(24, 156);
            this.rbtn_RoiEllipse.Name = "rbtn_RoiEllipse";
            this.rbtn_RoiEllipse.Size = new System.Drawing.Size(58, 19);
            this.rbtn_RoiEllipse.TabIndex = 3;
            this.rbtn_RoiEllipse.TabStop = true;
            this.rbtn_RoiEllipse.Text = "Ellipse";
            this.rbtn_RoiEllipse.UseVisualStyleBackColor = true;
            // 
            // rbtn_RoiRect
            // 
            this.rbtn_RoiRect.AutoSize = true;
            this.rbtn_RoiRect.Location = new System.Drawing.Point(24, 131);
            this.rbtn_RoiRect.Name = "rbtn_RoiRect";
            this.rbtn_RoiRect.Size = new System.Drawing.Size(77, 19);
            this.rbtn_RoiRect.TabIndex = 3;
            this.rbtn_RoiRect.TabStop = true;
            this.rbtn_RoiRect.Text = "Rectangle";
            this.rbtn_RoiRect.UseVisualStyleBackColor = true;
            // 
            // rbtn_RoiLine
            // 
            this.rbtn_RoiLine.AutoSize = true;
            this.rbtn_RoiLine.Location = new System.Drawing.Point(24, 106);
            this.rbtn_RoiLine.Name = "rbtn_RoiLine";
            this.rbtn_RoiLine.Size = new System.Drawing.Size(47, 19);
            this.rbtn_RoiLine.TabIndex = 3;
            this.rbtn_RoiLine.TabStop = true;
            this.rbtn_RoiLine.Text = "Line";
            this.rbtn_RoiLine.UseVisualStyleBackColor = true;
            // 
            // rbtn_RoiSpot
            // 
            this.rbtn_RoiSpot.AutoSize = true;
            this.rbtn_RoiSpot.Location = new System.Drawing.Point(24, 81);
            this.rbtn_RoiSpot.Name = "rbtn_RoiSpot";
            this.rbtn_RoiSpot.Size = new System.Drawing.Size(49, 19);
            this.rbtn_RoiSpot.TabIndex = 3;
            this.rbtn_RoiSpot.TabStop = true;
            this.rbtn_RoiSpot.Text = "Spot";
            this.rbtn_RoiSpot.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 8;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel14.Controls.Add(this.label13, 4, 0);
            this.tableLayoutPanel14.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.label15, 2, 0);
            this.tableLayoutPanel14.Controls.Add(this.textBox_ellipseX, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.textBox_ellipseW, 5, 0);
            this.tableLayoutPanel14.Controls.Add(this.textBox_ellipseY, 3, 0);
            this.tableLayoutPanel14.Controls.Add(this.label16, 6, 0);
            this.tableLayoutPanel14.Controls.Add(this.textBox_ellipseH, 7, 0);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(129, 154);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(256, 23);
            this.tableLayoutPanel14.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 3);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "W :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 3);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "X :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(67, 3);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Y :";
            // 
            // textBox_ellipseX
            // 
            this.textBox_ellipseX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ellipseX.Location = new System.Drawing.Point(32, 0);
            this.textBox_ellipseX.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_ellipseX.Name = "textBox_ellipseX";
            this.textBox_ellipseX.Size = new System.Drawing.Size(32, 23);
            this.textBox_ellipseX.TabIndex = 1;
            // 
            // textBox_ellipseW
            // 
            this.textBox_ellipseW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ellipseW.Location = new System.Drawing.Point(160, 0);
            this.textBox_ellipseW.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_ellipseW.Name = "textBox_ellipseW";
            this.textBox_ellipseW.Size = new System.Drawing.Size(32, 23);
            this.textBox_ellipseW.TabIndex = 1;
            // 
            // textBox_ellipseY
            // 
            this.textBox_ellipseY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ellipseY.Location = new System.Drawing.Point(96, 0);
            this.textBox_ellipseY.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_ellipseY.Name = "textBox_ellipseY";
            this.textBox_ellipseY.Size = new System.Drawing.Size(32, 23);
            this.textBox_ellipseY.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(195, 3);
            this.label16.Margin = new System.Windows.Forms.Padding(3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "H :";
            // 
            // textBox_ellipseH
            // 
            this.textBox_ellipseH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ellipseH.Location = new System.Drawing.Point(224, 0);
            this.textBox_ellipseH.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_ellipseH.Name = "textBox_ellipseH";
            this.textBox_ellipseH.Size = new System.Drawing.Size(32, 23);
            this.textBox_ellipseH.TabIndex = 1;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 8;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel13.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel13.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel13.Controls.Add(this.textBox_rectX, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.textBox_rectW, 5, 0);
            this.tableLayoutPanel13.Controls.Add(this.textBox_rectY, 3, 0);
            this.tableLayoutPanel13.Controls.Add(this.label10, 6, 0);
            this.tableLayoutPanel13.Controls.Add(this.textBox_rectH, 7, 0);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(129, 129);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(256, 23);
            this.tableLayoutPanel13.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "W :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "X :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Y :";
            // 
            // textBox_rectX
            // 
            this.textBox_rectX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_rectX.Location = new System.Drawing.Point(32, 0);
            this.textBox_rectX.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_rectX.Name = "textBox_rectX";
            this.textBox_rectX.Size = new System.Drawing.Size(32, 23);
            this.textBox_rectX.TabIndex = 1;
            // 
            // textBox_rectW
            // 
            this.textBox_rectW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_rectW.Location = new System.Drawing.Point(160, 0);
            this.textBox_rectW.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_rectW.Name = "textBox_rectW";
            this.textBox_rectW.Size = new System.Drawing.Size(32, 23);
            this.textBox_rectW.TabIndex = 1;
            // 
            // textBox_rectY
            // 
            this.textBox_rectY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_rectY.Location = new System.Drawing.Point(96, 0);
            this.textBox_rectY.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_rectY.Name = "textBox_rectY";
            this.textBox_rectY.Size = new System.Drawing.Size(32, 23);
            this.textBox_rectY.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "H :";
            // 
            // textBox_rectH
            // 
            this.textBox_rectH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_rectH.Location = new System.Drawing.Point(224, 0);
            this.textBox_rectH.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_rectH.Name = "textBox_rectH";
            this.textBox_rectH.Size = new System.Drawing.Size(32, 23);
            this.textBox_rectH.TabIndex = 1;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 8;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel12.Controls.Add(this.label11, 4, 0);
            this.tableLayoutPanel12.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel12.Controls.Add(this.textBox_lineX1, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.textBox_lineX2, 5, 0);
            this.tableLayoutPanel12.Controls.Add(this.textBox_lineY1, 3, 0);
            this.tableLayoutPanel12.Controls.Add(this.label12, 6, 0);
            this.tableLayoutPanel12.Controls.Add(this.textBox_lineY2, 7, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(129, 104);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(256, 23);
            this.tableLayoutPanel12.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "X2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "X1 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Y1 :";
            // 
            // textBox_lineX1
            // 
            this.textBox_lineX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_lineX1.Location = new System.Drawing.Point(32, 0);
            this.textBox_lineX1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_lineX1.Name = "textBox_lineX1";
            this.textBox_lineX1.Size = new System.Drawing.Size(32, 23);
            this.textBox_lineX1.TabIndex = 1;
            // 
            // textBox_lineX2
            // 
            this.textBox_lineX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_lineX2.Location = new System.Drawing.Point(160, 0);
            this.textBox_lineX2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_lineX2.Name = "textBox_lineX2";
            this.textBox_lineX2.Size = new System.Drawing.Size(32, 23);
            this.textBox_lineX2.TabIndex = 1;
            // 
            // textBox_lineY1
            // 
            this.textBox_lineY1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_lineY1.Location = new System.Drawing.Point(96, 0);
            this.textBox_lineY1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_lineY1.Name = "textBox_lineY1";
            this.textBox_lineY1.Size = new System.Drawing.Size(32, 23);
            this.textBox_lineY1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(195, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Y2 :";
            // 
            // textBox_lineY2
            // 
            this.textBox_lineY2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_lineY2.Location = new System.Drawing.Point(224, 0);
            this.textBox_lineY2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_lineY2.Name = "textBox_lineY2";
            this.textBox_lineY2.Size = new System.Drawing.Size(32, 23);
            this.textBox_lineY2.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 4;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel11.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.textBox_spotX, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.textBox_spotY, 3, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(129, 79);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(128, 23);
            this.tableLayoutPanel11.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "X :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Y :";
            // 
            // textBox_spotX
            // 
            this.textBox_spotX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_spotX.Location = new System.Drawing.Point(32, 0);
            this.textBox_spotX.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_spotX.Name = "textBox_spotX";
            this.textBox_spotX.Size = new System.Drawing.Size(32, 23);
            this.textBox_spotX.TabIndex = 1;
            // 
            // textBox_spotY
            // 
            this.textBox_spotY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_spotY.Location = new System.Drawing.Point(96, 0);
            this.textBox_spotY.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_spotY.Name = "textBox_spotY";
            this.textBox_spotY.Size = new System.Drawing.Size(32, 23);
            this.textBox_spotY.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ROI List";
            // 
            // comboBox_ListROI
            // 
            this.comboBox_ListROI.FormattingEnabled = true;
            this.comboBox_ListROI.Location = new System.Drawing.Point(24, 32);
            this.comboBox_ListROI.Name = "comboBox_ListROI";
            this.comboBox_ListROI.Size = new System.Drawing.Size(99, 23);
            this.comboBox_ListROI.TabIndex = 0;
            this.comboBox_ListROI.SelectedIndexChanged += new System.EventHandler(this.comboBox_ListROI_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel_Preview);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(240, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 471);
            this.panel2.TabIndex = 6;
            // 
            // tableLayoutPanel_Preview
            // 
            this.tableLayoutPanel_Preview.ColumnCount = 1;
            this.tableLayoutPanel_Preview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Preview.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel_Preview.Controls.Add(this.panel_Preview, 0, 3);
            this.tableLayoutPanel_Preview.Controls.Add(this.panel_VideoPreview, 0, 0);
            this.tableLayoutPanel_Preview.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Preview.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Preview.Name = "tableLayoutPanel_Preview";
            this.tableLayoutPanel_Preview.RowCount = 4;
            this.tableLayoutPanel_Preview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Preview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel_Preview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel_Preview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Preview.Size = new System.Drawing.Size(493, 471);
            this.tableLayoutPanel_Preview.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label_MinimumTemperature);
            this.panel5.Controls.Add(this.label_AverageTemperature);
            this.panel5.Controls.Add(this.label_MaximumTemperature);
            this.panel5.Location = new System.Drawing.Point(1, 373);
            this.panel5.Margin = new System.Windows.Forms.Padding(1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(491, 20);
            this.panel5.TabIndex = 3;
            // 
            // label_MinimumTemperature
            // 
            this.label_MinimumTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_MinimumTemperature.AutoSize = true;
            this.label_MinimumTemperature.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_MinimumTemperature.Location = new System.Drawing.Point(3, 2);
            this.label_MinimumTemperature.Name = "label_MinimumTemperature";
            this.label_MinimumTemperature.Size = new System.Drawing.Size(57, 15);
            this.label_MinimumTemperature.TabIndex = 1;
            this.label_MinimumTemperature.Text = "MinTemp";
            this.label_MinimumTemperature.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label_AverageTemperature
            // 
            this.label_AverageTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_AverageTemperature.AutoSize = true;
            this.label_AverageTemperature.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_AverageTemperature.Location = new System.Drawing.Point(212, 2);
            this.label_AverageTemperature.Name = "label_AverageTemperature";
            this.label_AverageTemperature.Size = new System.Drawing.Size(57, 15);
            this.label_AverageTemperature.TabIndex = 1;
            this.label_AverageTemperature.Text = "AvgTemp";
            this.label_AverageTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_MaximumTemperature
            // 
            this.label_MaximumTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_MaximumTemperature.AutoSize = true;
            this.label_MaximumTemperature.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_MaximumTemperature.Location = new System.Drawing.Point(422, 2);
            this.label_MaximumTemperature.Name = "label_MaximumTemperature";
            this.label_MaximumTemperature.Size = new System.Drawing.Size(59, 15);
            this.label_MaximumTemperature.TabIndex = 1;
            this.label_MaximumTemperature.Text = "MaxTemp";
            this.label_MaximumTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Preview
            // 
            this.panel_Preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Preview.BackColor = System.Drawing.Color.White;
            this.panel_Preview.Controls.Add(this.checkBox_NoiseFiltering);
            this.panel_Preview.Controls.Add(this.label_ColorMap);
            this.panel_Preview.Controls.Add(this.comboBox_ColorMap);
            this.panel_Preview.Controls.Add(this.label_TemperatureUnit);
            this.panel_Preview.Controls.Add(this.comboBox_TemperatureUnit);
            this.panel_Preview.Location = new System.Drawing.Point(1, 434);
            this.panel_Preview.Margin = new System.Windows.Forms.Padding(1);
            this.panel_Preview.Name = "panel_Preview";
            this.panel_Preview.Size = new System.Drawing.Size(491, 34);
            this.panel_Preview.TabIndex = 2;
            // 
            // checkBox_NoiseFiltering
            // 
            this.checkBox_NoiseFiltering.AutoSize = true;
            this.checkBox_NoiseFiltering.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_NoiseFiltering.Location = new System.Drawing.Point(190, 9);
            this.checkBox_NoiseFiltering.Name = "checkBox_NoiseFiltering";
            this.checkBox_NoiseFiltering.Size = new System.Drawing.Size(102, 19);
            this.checkBox_NoiseFiltering.TabIndex = 5;
            this.checkBox_NoiseFiltering.Text = "Noise Filtering";
            this.checkBox_NoiseFiltering.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_NoiseFiltering.UseVisualStyleBackColor = true;
            this.checkBox_NoiseFiltering.CheckedChanged += new System.EventHandler(this.checkBox_NoiseFiltering_CheckedChanged);
            // 
            // label_ColorMap
            // 
            this.label_ColorMap.AutoSize = true;
            this.label_ColorMap.Location = new System.Drawing.Point(3, 10);
            this.label_ColorMap.Name = "label_ColorMap";
            this.label_ColorMap.Size = new System.Drawing.Size(63, 15);
            this.label_ColorMap.TabIndex = 3;
            this.label_ColorMap.Text = "Color Map";
            // 
            // comboBox_ColorMap
            // 
            this.comboBox_ColorMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ColorMap.Enabled = false;
            this.comboBox_ColorMap.FormattingEnabled = true;
            this.comboBox_ColorMap.Items.AddRange(new object[] {
            "Grayscale",
            "Autumn",
            "Bone",
            "Jet",
            "Winter",
            "Rainbow",
            "Ocean",
            "Summer",
            "Spring",
            "Cool",
            "Hsv",
            "Pink",
            "Hot",
            "Parula",
            "Magma",
            "Inferno",
            "Plasma",
            "Viridis",
            "Cividis",
            "Twilight",
            "TwilightShifted"});
            this.comboBox_ColorMap.Location = new System.Drawing.Point(72, 6);
            this.comboBox_ColorMap.Name = "comboBox_ColorMap";
            this.comboBox_ColorMap.Size = new System.Drawing.Size(97, 23);
            this.comboBox_ColorMap.TabIndex = 2;
            this.comboBox_ColorMap.SelectedIndexChanged += new System.EventHandler(this.comboBox_ColorMap_SelectedIndexChanged);
            // 
            // label_TemperatureUnit
            // 
            this.label_TemperatureUnit.AutoSize = true;
            this.label_TemperatureUnit.Location = new System.Drawing.Point(309, 10);
            this.label_TemperatureUnit.Name = "label_TemperatureUnit";
            this.label_TemperatureUnit.Size = new System.Drawing.Size(73, 15);
            this.label_TemperatureUnit.TabIndex = 1;
            this.label_TemperatureUnit.Text = "Temperature";
            // 
            // comboBox_TemperatureUnit
            // 
            this.comboBox_TemperatureUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TemperatureUnit.Enabled = false;
            this.comboBox_TemperatureUnit.FormattingEnabled = true;
            this.comboBox_TemperatureUnit.Items.AddRange(new object[] {
            "Raw",
            "Celsius(℃)",
            "Fahrenheit(℉)",
            "Kelvin(Κ)"});
            this.comboBox_TemperatureUnit.Location = new System.Drawing.Point(388, 6);
            this.comboBox_TemperatureUnit.Name = "comboBox_TemperatureUnit";
            this.comboBox_TemperatureUnit.Size = new System.Drawing.Size(97, 23);
            this.comboBox_TemperatureUnit.TabIndex = 0;
            this.comboBox_TemperatureUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox_TemperatureUnit_SelectedIndexChanged);
            // 
            // panel_VideoPreview
            // 
            this.panel_VideoPreview.Controls.Add(this.pictureBox_Preview);
            this.panel_VideoPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_VideoPreview.Location = new System.Drawing.Point(0, 0);
            this.panel_VideoPreview.Margin = new System.Windows.Forms.Padding(0);
            this.panel_VideoPreview.Name = "panel_VideoPreview";
            this.panel_VideoPreview.Size = new System.Drawing.Size(493, 371);
            this.panel_VideoPreview.TabIndex = 4;
            this.panel_VideoPreview.SizeChanged += new System.EventHandler(this.panel_VideoPreview_SizeChanged);
            // 
            // pictureBox_Preview
            // 
            this.pictureBox_Preview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox_Preview.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_Preview.Location = new System.Drawing.Point(7, 5);
            this.pictureBox_Preview.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox_Preview.Name = "pictureBox_Preview";
            this.pictureBox_Preview.Size = new System.Drawing.Size(480, 360);
            this.pictureBox_Preview.TabIndex = 0;
            this.pictureBox_Preview.TabStop = false;
            this.pictureBox_Preview.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Preview_Paint);
            this.pictureBox_Preview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Preview_MouseDown);
            this.pictureBox_Preview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Preview_MouseMove);
            this.pictureBox_Preview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Preview_MouseUp);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel7.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.button_RemoveAllRoi, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(1, 396);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(491, 34);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.radioButton_ShapeEllipse);
            this.panel3.Controls.Add(this.radioButton_ShapeRectangle);
            this.panel3.Controls.Add(this.radioButton_ShapeLine);
            this.panel3.Controls.Add(this.radioButton_ShapeSpot);
            this.panel3.Controls.Add(this.radioButton_ShapeCursor);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(409, 32);
            this.panel3.TabIndex = 1;
            // 
            // radioButton_ShapeEllipse
            // 
            this.radioButton_ShapeEllipse.Location = new System.Drawing.Point(311, 6);
            this.radioButton_ShapeEllipse.Name = "radioButton_ShapeEllipse";
            this.radioButton_ShapeEllipse.Size = new System.Drawing.Size(73, 19);
            this.radioButton_ShapeEllipse.TabIndex = 0;
            this.radioButton_ShapeEllipse.Text = "Ellipse";
            this.radioButton_ShapeEllipse.UseVisualStyleBackColor = true;
            this.radioButton_ShapeEllipse.Click += new System.EventHandler(this.radioButton_Shape_Selected);
            // 
            // radioButton_ShapeRectangle
            // 
            this.radioButton_ShapeRectangle.Location = new System.Drawing.Point(223, 6);
            this.radioButton_ShapeRectangle.Name = "radioButton_ShapeRectangle";
            this.radioButton_ShapeRectangle.Size = new System.Drawing.Size(82, 19);
            this.radioButton_ShapeRectangle.TabIndex = 0;
            this.radioButton_ShapeRectangle.Text = "Rectangle";
            this.radioButton_ShapeRectangle.UseVisualStyleBackColor = true;
            this.radioButton_ShapeRectangle.Click += new System.EventHandler(this.radioButton_Shape_Selected);
            // 
            // radioButton_ShapeLine
            // 
            this.radioButton_ShapeLine.Location = new System.Drawing.Point(157, 6);
            this.radioButton_ShapeLine.Name = "radioButton_ShapeLine";
            this.radioButton_ShapeLine.Size = new System.Drawing.Size(60, 19);
            this.radioButton_ShapeLine.TabIndex = 0;
            this.radioButton_ShapeLine.Text = "Line";
            this.radioButton_ShapeLine.UseVisualStyleBackColor = true;
            this.radioButton_ShapeLine.Click += new System.EventHandler(this.radioButton_Shape_Selected);
            // 
            // radioButton_ShapeSpot
            // 
            this.radioButton_ShapeSpot.Location = new System.Drawing.Point(91, 6);
            this.radioButton_ShapeSpot.Name = "radioButton_ShapeSpot";
            this.radioButton_ShapeSpot.Size = new System.Drawing.Size(60, 19);
            this.radioButton_ShapeSpot.TabIndex = 0;
            this.radioButton_ShapeSpot.Text = "Spot";
            this.radioButton_ShapeSpot.UseVisualStyleBackColor = true;
            this.radioButton_ShapeSpot.Click += new System.EventHandler(this.radioButton_Shape_Selected);
            // 
            // radioButton_ShapeCursor
            // 
            this.radioButton_ShapeCursor.AutoSize = true;
            this.radioButton_ShapeCursor.Checked = true;
            this.radioButton_ShapeCursor.Location = new System.Drawing.Point(8, 6);
            this.radioButton_ShapeCursor.Name = "radioButton_ShapeCursor";
            this.radioButton_ShapeCursor.Size = new System.Drawing.Size(60, 19);
            this.radioButton_ShapeCursor.TabIndex = 0;
            this.radioButton_ShapeCursor.TabStop = true;
            this.radioButton_ShapeCursor.Text = "Cursor";
            this.radioButton_ShapeCursor.UseVisualStyleBackColor = true;
            this.radioButton_ShapeCursor.Click += new System.EventHandler(this.radioButton_Shape_Selected);
            // 
            // button_RemoveAllRoi
            // 
            this.button_RemoveAllRoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_RemoveAllRoi.Location = new System.Drawing.Point(412, 1);
            this.button_RemoveAllRoi.Margin = new System.Windows.Forms.Padding(1);
            this.button_RemoveAllRoi.Name = "button_RemoveAllRoi";
            this.button_RemoveAllRoi.Size = new System.Drawing.Size(78, 32);
            this.button_RemoveAllRoi.TabIndex = 2;
            this.button_RemoveAllRoi.Text = "Remove All";
            this.button_RemoveAllRoi.UseVisualStyleBackColor = true;
            this.button_RemoveAllRoi.Click += new System.EventHandler(this.button_RemoveAllRoi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 769);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThermoCamSDK";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_RemoteCamera.ResumeLayout(false);
            this.tabPage_RemoteCamera.PerformLayout();
            this.tabPage_LocalCamera.ResumeLayout(false);
            this.tabPage_LocalCamera.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage_Product.ResumeLayout(false);
            this.groupBox_ProductInformation.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox_SensorInformation.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.groupBox_SoftwareUpdate.ResumeLayout(false);
            this.groupBox_SoftwareUpdate.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPage_Network.ResumeLayout(false);
            this.groupBox_NetworkConfiguration.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage_SensorControl.ResumeLayout(false);
            this.panel_SensorControl_256E.ResumeLayout(false);
            this.groupBox_FFCParameters_256E.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FFCParam256E_MaxInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FFCParam256E_AutoTriggerThreshold)).EndInit();
            this.groupBox_FluxParameters_256E.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam256E_Emissivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam256E_AtmosphericTransmittance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam256E_AtmosphericTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam256E_AmbientReflectionTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam256E_Distance)).EndInit();
            this.groupBox_GainModeState_256E.ResumeLayout(false);
            this.groupBox_GainModeState_256E.PerformLayout();
            this.groupBox_FlatFieldCorrection_256E.ResumeLayout(false);
            this.groupBox_FlatFieldCorrection_256E.PerformLayout();
            this.panel_SensorControl_160E.ResumeLayout(false);
            this.groupBox_FluxParameters_160E.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_WindowReflectedTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_WindowReflection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_AtmosphericTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_AtmosphericTransmission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_WindowTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_WindowTransmission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_SceneEmissivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FluxParam160E_BackgroundTemperature)).EndInit();
            this.groupBox_GainModeState_160E.ResumeLayout(false);
            this.groupBox_GainModeState_160E.PerformLayout();
            this.groupBox_FlatFieldCorrection_160E.ResumeLayout(false);
            this.groupBox_FlatFieldCorrection_160E.PerformLayout();
            this.tabPage_RoiManager.ResumeLayout(false);
            this.tabPage_RoiManager.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel_Preview.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel_Preview.ResumeLayout(false);
            this.panel_Preview.PerformLayout();
            this.panel_VideoPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Preview)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.PictureBox pictureBox_Preview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_ConnectLocalCamera;
        private System.Windows.Forms.TextBox textBox_RemoteCameraIPAddress;
        private System.Windows.Forms.Button button_ConnectRemoteCamera;
        private System.Windows.Forms.ListBox listBox_RemoteCameraScanList;
        private System.Windows.Forms.Button button_ScanRemoteCamera;
        private System.Windows.Forms.Label label_RemoteCameraIPAddressTitle;
        private System.Windows.Forms.Button button_GetProductInformation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_SensorSerialNumberTitle;
        private System.Windows.Forms.Label label_SensorSerialNumber;
        private System.Windows.Forms.Label label_SensorUptimeTitle;
        private System.Windows.Forms.Label label_SensorUptime;
        private System.Windows.Forms.GroupBox groupBox_SoftwareUpdate;
        private System.Windows.Forms.ProgressBar progressBar_SoftwareUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label_SoftwareUpdateStatus;
        private System.Windows.Forms.Button button_StartSoftwareUpdate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_LocalCamera;
        private System.Windows.Forms.TabPage tabPage_RemoteCamera;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage_Product;
        private System.Windows.Forms.TabPage tabPage_Network;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage_SensorControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_MinimumTemperature;
        private System.Windows.Forms.Label label_AverageTemperature;
        private System.Windows.Forms.Label label_MaximumTemperature;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox textBox_FluxParam160E_SceneEmissivityRange;
        private System.Windows.Forms.TextBox textBox_FluxParam160E_BackgroundTemperatureRange;
        private System.Windows.Forms.TextBox textBox_FluxParam160E_WindowTransmissionRange;
        private System.Windows.Forms.TextBox textBox_FluxParam160E_WindowTemperatureRange;
        private System.Windows.Forms.TextBox textBox_FluxParam160E_AtmosphericTransmissionRange;
        private System.Windows.Forms.TextBox textBox_FluxParam160E_AtmosphericTemperatureRange;
        private System.Windows.Forms.Label label_FluxParam160E_WindowReflectionTitle;
        private System.Windows.Forms.Label label_FluxParam160E_WindowReflectedTemperatureTitle;
        private System.Windows.Forms.TextBox textBox_FluxParam160E_WindowReflectionRange;
        private System.Windows.Forms.TextBox textBox_FluxParam160E_WindowReflectedTemperatureRange;
        private System.Windows.Forms.Label label_LocalCameraComPort;
        private System.Windows.Forms.Label label_LocalCameraNameTitle;
        private System.Windows.Forms.Label label_BootloaderVersionTitle;
        private System.Windows.Forms.Label label_FirmwareVersionTitle;
        private System.Windows.Forms.Label label_FirmwareVersion;
        private System.Windows.Forms.Label label_BootloaderVersion;
        private System.Windows.Forms.Label label_SensorModelName;
        private System.Windows.Forms.Label label_SensorModelNameTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label_MACAddressTitle;
        private System.Windows.Forms.TextBox textBox_MACAddress;
        private System.Windows.Forms.Button button_GetNetworkConfiguration;
        private System.Windows.Forms.Label label_IPAssignmentTitle;
        private System.Windows.Forms.Button button_SetNetworkConfiguration;
        private System.Windows.Forms.Label label_IPAddressTitle;
        private System.Windows.Forms.Label label_NetmaskTitle;
        private System.Windows.Forms.Label label_GatewayNameTitle;
        private System.Windows.Forms.Label label_MainDNSServerTitle;
        private System.Windows.Forms.TextBox textBox_IPAddress;
        private System.Windows.Forms.TextBox textBox_Netmask;
        private System.Windows.Forms.TextBox textBox_Gateway;
        private System.Windows.Forms.TextBox textBox_MainDNSServer;
        private System.Windows.Forms.ComboBox comboBox_IPAssignment;
        private System.Windows.Forms.Button button_SetDefaultNetworkConfiguration;
        private System.Windows.Forms.Label label_SubDNSServerTitle;
        private System.Windows.Forms.TextBox textBox_SubDNSServer;
        private System.Windows.Forms.TextBox textBox_SoftwareUpdateFilePath;
        private System.Windows.Forms.Button button_SoftwareUpdateFileBrowse;
        private System.Windows.Forms.Button button_SystemReboot;
        private System.Windows.Forms.NumericUpDown numericUpDown_FluxParam160E_SceneEmissivity;
        private System.Windows.Forms.NumericUpDown numericUpDown_FluxParam160E_BackgroundTemperature;
        private System.Windows.Forms.NumericUpDown numericUpDown_FluxParam160E_WindowTransmission;
        private System.Windows.Forms.NumericUpDown numericUpDown_FluxParam160E_WindowReflection;
        private System.Windows.Forms.NumericUpDown numericUpDown_FluxParam160E_AtmosphericTemperature;
        private System.Windows.Forms.NumericUpDown numericUpDown_FluxParam160E_AtmosphericTransmission;
        private System.Windows.Forms.NumericUpDown numericUpDown_FluxParam160E_WindowTemperature;
        private System.Windows.Forms.NumericUpDown numericUpDown_FluxParam160E_WindowReflectedTemperature;
        private System.Windows.Forms.Button button_RestoreDefaultFluxParameters_160E;
        private System.Windows.Forms.Button button_GetSensorInformation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label_ProductModelNameTitle;
        private System.Windows.Forms.Label label_HardwareVersionTitle;
        private System.Windows.Forms.Label label_ProductSerialNumberTitle;
        private System.Windows.Forms.Label label_HardwareVersion;
        private System.Windows.Forms.Label label_ProductSerialNumber;
        private System.Windows.Forms.Label label_ProductModelName;
        private System.Windows.Forms.GroupBox groupBox_SensorInformation;
        private System.Windows.Forms.GroupBox groupBox_ProductInformation;
        private System.Windows.Forms.GroupBox groupBox_FluxParameters_160E;
        private System.Windows.Forms.GroupBox groupBox_NetworkConfiguration;
        private System.Windows.Forms.Button button_ScanLocalCamera;
        private System.Windows.Forms.TextBox textBox_RemoteCameraName;
        private System.Windows.Forms.Label label_RemoteCameraNameTitle;
        private System.Windows.Forms.TextBox textBox_RemoteCameraSerialNumber;
        private System.Windows.Forms.Label label_RemoteCameraSerialNumberTitle;
        private System.Windows.Forms.Label label_RemoteCameraMACAddressTitle;
        private System.Windows.Forms.TextBox textBox_RemoteCameraMACAddress;
        private System.Windows.Forms.ListBox listBox_LocalCameraScanList;
        private System.Windows.Forms.TextBox textBox_LocalCameraComPort;
        private System.Windows.Forms.TextBox textBox_LocalCameraName;
        private System.Windows.Forms.Label label_FluxParam160E_BackgroundTemperatureUnit;
        private System.Windows.Forms.Label label_FluxParam160E_WindowReflectedTemperatureUnit;
        private System.Windows.Forms.Label label_FluxParam160E_AtmosphericTemperatureUnit;
        private System.Windows.Forms.Label label_FluxParam160E_WindowTemperatureUnit;
        private System.Windows.Forms.Panel panel_Preview;
        private System.Windows.Forms.ComboBox comboBox_TemperatureUnit;
        private System.Windows.Forms.Label label_TemperatureUnit;
        private System.Windows.Forms.Label label_ColorMap;
        private System.Windows.Forms.ComboBox comboBox_ColorMap;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_Name;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_CamInfo;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_fps;
        private System.Windows.Forms.TabPage tabPage_RoiManager;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButton_ShapeEllipse;
        private System.Windows.Forms.RadioButton radioButton_ShapeRectangle;
        private System.Windows.Forms.RadioButton radioButton_ShapeLine;
        private System.Windows.Forms.RadioButton radioButton_ShapeSpot;
        private System.Windows.Forms.RadioButton radioButton_ShapeCursor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Preview;
        private System.Windows.Forms.Panel panel_VideoPreview;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_PreviewSize;
        private System.Windows.Forms.GroupBox groupBox_FluxParameters_256E;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_RestoreDefaultSensorConfig_256E;
        private System.Windows.Forms.Label label_FluxParam256E_EmissivityTitle;
        private System.Windows.Forms.TextBox textBox_FluxParam256E_EmissivityRange;
        private System.Windows.Forms.Button button_GetFluxParameters_256E;
        private System.Windows.Forms.Button button_SetFluxParameters_256E;
        private System.Windows.Forms.NumericUpDown numericUpDown_FluxParam256E_Emissivity;
        private System.Windows.Forms.Label label_FluxParam256E_AtmosphericTransmittanceTitle;
        private System.Windows.Forms.NumericUpDown numericUpDown_FluxParam256E_AtmosphericTransmittance;
        private System.Windows.Forms.TextBox textBox_FluxParam256E_AtmosphericTransmittanceRange;
        private System.Windows.Forms.Label label_FluxParam256E_AtmosphericTemperatureTitle;
        private System.Windows.Forms.NumericUpDown numericUpDown_FluxParam256E_AtmosphericTemperature;
        private System.Windows.Forms.TextBox textBox_FluxParam256E_AtmosphericTemperatureRange;
        private System.Windows.Forms.Label label_FluxParam256E_AtmosphericTemperatureUnit;
        private System.Windows.Forms.Label label_FluxParam256E_AmbientReflectionTemperatureTitle;
        private System.Windows.Forms.NumericUpDown numericUpDown_FluxParam256E_AmbientReflectionTemperature;
        private System.Windows.Forms.Label label_FluxParam256E_AmbientReflectionTemperatureUnit;
        private System.Windows.Forms.TextBox textBox_FluxParam256E_AmbientReflectionTemperatureRange;
        private System.Windows.Forms.Label label_FluxParam160E_SceneEmissivityTitle;
        private System.Windows.Forms.Button button_GetFluxParameters_160E;
        private System.Windows.Forms.Button button_SetFluxParameters_160E;
        private System.Windows.Forms.Label label_FluxParam160E_WindowTransmissionTitle;
        private System.Windows.Forms.Label label_FluxParam160E_WindowTemperatureTitle;
        private System.Windows.Forms.Label label_FluxParam160E_AtmosphericTransmissionTitle;
        private System.Windows.Forms.Label label_FluxParam160E_AtmosphericTemperatureTitle;
        private System.Windows.Forms.Label label_FluxParam160E_BackgroundTemperatureTitle;
        private System.Windows.Forms.GroupBox groupBox_GainModeState_256E;
        private System.Windows.Forms.Button button_SetGainModeState_256E;
        private System.Windows.Forms.Button button_GetGainModeState_256E;
        private System.Windows.Forms.RadioButton radioButton_GainModeStateLow_256E;
        private System.Windows.Forms.RadioButton radioButton_GainModeStateHigh_256E;
        private System.Windows.Forms.GroupBox groupBox_FlatFieldCorrection_256E;
        private System.Windows.Forms.Button button_SetFlatFieldCorrectionMode_256E;
        private System.Windows.Forms.Button button_GetFlatFieldCorrectionMode_256E;
        private System.Windows.Forms.RadioButton radioButton_FlatFieldCorrectionManual_256E;
        private System.Windows.Forms.Button button_RunFlatFieldCorrection_256E;
        private System.Windows.Forms.RadioButton radioButton_FlatFieldCorrectionAutomatic_256E;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ListROI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button button_RemoveAllRoi;
        private System.Windows.Forms.Button button_RemoveRoiItem;
        private System.Windows.Forms.Button button_AddRoiItem;
        private System.Windows.Forms.RadioButton rbtn_RoiEllipse;
        private System.Windows.Forms.RadioButton rbtn_RoiRect;
        private System.Windows.Forms.RadioButton rbtn_RoiLine;
        private System.Windows.Forms.RadioButton rbtn_RoiSpot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_ellipseX;
        private System.Windows.Forms.TextBox textBox_ellipseW;
        private System.Windows.Forms.TextBox textBox_ellipseY;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_ellipseH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_rectX;
        private System.Windows.Forms.TextBox textBox_rectW;
        private System.Windows.Forms.TextBox textBox_rectY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_rectH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_lineX1;
        private System.Windows.Forms.TextBox textBox_lineX2;
        private System.Windows.Forms.TextBox textBox_lineY1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_lineY2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_spotX;
        private System.Windows.Forms.TextBox textBox_spotY;
        private System.Windows.Forms.Panel panel_SensorControl_256E;
        private System.Windows.Forms.GroupBox groupBox_GainModeState_160E;
        private System.Windows.Forms.Button button_SetGainModeState_160E;
        private System.Windows.Forms.Button button_GetGainModeState_160E;
        private System.Windows.Forms.RadioButton radioButton_GainModeStateAuto_160E;
        private System.Windows.Forms.RadioButton radioButton_GainModeStateLow_160E;
        private System.Windows.Forms.RadioButton radioButton_GainModeStateHigh_160E;
        private System.Windows.Forms.GroupBox groupBox_FlatFieldCorrection_160E;
        private System.Windows.Forms.Button button_SetFlatFieldCorrectionMode_160E;
        private System.Windows.Forms.Button button_GetFlatFieldCorrectionMode_160E;
        private System.Windows.Forms.RadioButton radioButton_FlatFieldCorrectionManual_160E;
        private System.Windows.Forms.Button button_RunFlatFieldCorrection_160E;
        private System.Windows.Forms.RadioButton radioButton_FlatFieldCorrectionAutomatic_160E;
        private System.Windows.Forms.Panel panel_SensorControl_160E;
        private System.Windows.Forms.Button button_StoreUserSensorConfig_256E;
        private System.Windows.Forms.Label label_FluxParam256E_DistanceTitle;
        private System.Windows.Forms.NumericUpDown numericUpDown_FluxParam256E_Distance;
        private System.Windows.Forms.Label label_FluxParam256E_DistanceUnit;
        private System.Windows.Forms.TextBox textBox_FluxParam256E_DistanceRange;
        private System.Windows.Forms.GroupBox groupBox_FFCParameters_256E;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label_FFCParam256E_MaxIntervalTitle;
        private System.Windows.Forms.TextBox textBox_FFCParam256E_MaxIntervalRange;
        private System.Windows.Forms.Button button_GetFFCParameters_256E;
        private System.Windows.Forms.Button button_SetFFCParameters_256E;
        private System.Windows.Forms.NumericUpDown numericUpDown_FFCParam256E_MaxInterval;
        private System.Windows.Forms.Label label_FFCParam256E_AutoTriggerThresholdTitle;
        private System.Windows.Forms.NumericUpDown numericUpDown_FFCParam256E_AutoTriggerThreshold;
        private System.Windows.Forms.TextBox textBox_FFCParam256E_AutoTriggerThresholdRange;
        private System.Windows.Forms.Label label_FFCParam256E_MaxIntervalUnit;
        private System.Windows.Forms.CheckBox checkBox_NoiseFiltering;
    }
}

