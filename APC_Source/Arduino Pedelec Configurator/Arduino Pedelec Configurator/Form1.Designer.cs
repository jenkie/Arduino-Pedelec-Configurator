namespace Arduino_Pedelec_Configurator
{
    partial class Form_menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_menu));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cb_bottombracket = new System.Windows.Forms.ComboBox();
            this.nud_circumference = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_magnets = new System.Windows.Forms.NumericUpDown();
            this.lbl_magnets = new System.Windows.Forms.Label();
            this.nud_pasfactor_min = new System.Windows.Forms.NumericUpDown();
            this.nud_pasfactor_max = new System.Windows.Forms.NumericUpDown();
            this.lbl_pf = new System.Windows.Forms.Label();
            this.lbl_pfmin = new System.Windows.Forms.Label();
            this.lbl_pfmax = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chb_brake = new System.Windows.Forms.CheckBox();
            this.chb_brakeinverted = new System.Windows.Forms.CheckBox();
            this.nud_pas_tolerance = new System.Windows.Forms.NumericUpDown();
            this.nud_motor_max = new System.Windows.Forms.NumericUpDown();
            this.nud_motor_min = new System.Windows.Forms.NumericUpDown();
            this.nud_poti_max = new System.Windows.Forms.NumericUpDown();
            this.nud_poti_min = new System.Windows.Forms.NumericUpDown();
            this.cb_controls = new System.Windows.Forms.ComboBox();
            this.nud_throttle_max = new System.Windows.Forms.NumericUpDown();
            this.nud_throttle_min = new System.Windows.Forms.NumericUpDown();
            this.nud_power_max = new System.Windows.Forms.NumericUpDown();
            this.nud_power_thermal = new System.Windows.Forms.NumericUpDown();
            this.nud_thermalsafespeed = new System.Windows.Forms.NumericUpDown();
            this.nud_startingaid = new System.Windows.Forms.NumericUpDown();
            this.cb_controlmode = new System.Windows.Forms.ComboBox();
            this.cb_serialmode = new System.Windows.Forms.ComboBox();
            this.nud_controlmode = new System.Windows.Forms.NumericUpDown();
            this.nud_vemergency = new System.Windows.Forms.NumericUpDown();
            this.nud_vcutoff = new System.Windows.Forms.NumericUpDown();
            this.lblVoltageRaw = new System.Windows.Forms.Label();
            this.lblCurrentRaw = new System.Windows.Forms.Label();
            this.lblVoltageCalc = new System.Windows.Forms.Label();
            this.lblCurrentCalc = new System.Windows.Forms.Label();
            this.cb_display = new System.Windows.Forms.ComboBox();
            this.chb_backlight = new System.Windows.Forms.CheckBox();
            this.nud_display_contrast = new System.Windows.Forms.NumericUpDown();
            this.nud_speedcutoff_stop = new System.Windows.Forms.NumericUpDown();
            this.nud_speedcutoff_start = new System.Windows.Forms.NumericUpDown();
            this.nud_menuidle = new System.Windows.Forms.NumericUpDown();
            this.txb_goodbye = new System.Windows.Forms.TextBox();
            this.txb_welcometext = new System.Windows.Forms.TextBox();
            this.nud_idle_shutdown = new System.Windows.Forms.NumericUpDown();
            this.nud_pidi_throttle = new System.Windows.Forms.NumericUpDown();
            this.nud_pidp_throttle = new System.Windows.Forms.NumericUpDown();
            this.nud_pidi = new System.Windows.Forms.NumericUpDown();
            this.nud_pidp = new System.Windows.Forms.NumericUpDown();
            this.nud_vmax = new System.Windows.Forms.NumericUpDown();
            this.nud_idlespeed = new System.Windows.Forms.NumericUpDown();
            this.chb_preguess = new System.Windows.Forms.CheckBox();
            this.nud_power_max_2 = new System.Windows.Forms.NumericUpDown();
            this.nud_speedcutoff_start_2 = new System.Windows.Forms.NumericUpDown();
            this.nud_speedcutoff_stop_2 = new System.Windows.Forms.NumericUpDown();
            this.nud_startingaid_2 = new System.Windows.Forms.NumericUpDown();
            this.nud_controlmode_2 = new System.Windows.Forms.NumericUpDown();
            this.chb_firstaid = new System.Windows.Forms.CheckBox();
            this.chb_chargedetection = new System.Windows.Forms.CheckBox();
            this.chb_profilemenu = new System.Windows.Forms.CheckBox();
            this.nud_stepsize = new System.Windows.Forms.NumericUpDown();
            this.chb_lightswitch = new System.Windows.Forms.CheckBox();
            this.chb_lightswitch_startup = new System.Windows.Forms.CheckBox();
            this.chb_lightswitch_menu = new System.Windows.Forms.CheckBox();
            this.chb_dspc01 = new System.Windows.Forms.CheckBox();
            this.chb_bmp085 = new System.Windows.Forms.CheckBox();
            this.chb_HRMI = new System.Windows.Forms.CheckBox();
            this.chb_rtc = new System.Windows.Forms.CheckBox();
            this.chb_bluetoothstartup = new System.Windows.Forms.CheckBox();
            this.nud_voltage_offset = new System.Windows.Forms.NumericUpDown();
            this.nud_voltage_amplitude = new System.Windows.Forms.NumericUpDown();
            this.nud_current_amplitude = new System.Windows.Forms.NumericUpDown();
            this.nud_current_offset = new System.Windows.Forms.NumericUpDown();
            this.nud_poti_startup = new System.Windows.Forms.NumericUpDown();
            this.nud_fixed_throttle = new System.Windows.Forms.NumericUpDown();
            this.nud_chargedetect_min = new System.Windows.Forms.NumericUpDown();
            this.chb_gearshift = new System.Windows.Forms.CheckBox();
            this.txb_lowgear = new System.Windows.Forms.TextBox();
            this.txb_highgear = new System.Windows.Forms.TextBox();
            this.cb_bluetoothmode = new System.Windows.Forms.ComboBox();
            this.chb_chargecounter = new System.Windows.Forms.CheckBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.contextmenu_display = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tssm = new System.Windows.Forms.ToolStripMenuItem();
            this.cbts_menuup = new System.Windows.Forms.ToolStripComboBox();
            this.menuButtonDOWNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbts_menudown = new System.Windows.Forms.ToolStripComboBox();
            this.toolstripdisp1short = new System.Windows.Forms.ToolStripMenuItem();
            this.cbts_disp1short = new System.Windows.Forms.ToolStripComboBox();
            this.toolstripdisp1long = new System.Windows.Forms.ToolStripMenuItem();
            this.cbts_disp1long = new System.Windows.Forms.ToolStripComboBox();
            this.toolstripdisp2short = new System.Windows.Forms.ToolStripMenuItem();
            this.cbts_disp2short = new System.Windows.Forms.ToolStripComboBox();
            this.displaySwitch2LongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbts_disp2long = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_GRAPHIC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_HUMAN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ENVIRONMENT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_TIME = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_BATTERY = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ODO = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contextmenu_poti = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbts_potishort = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbts_potilong = new System.Windows.Forms.ToolStripComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.contextmenu_throttle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbts_throttleshort = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.cbts_throttlelong = new System.Windows.Forms.ToolStripComboBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.chb_motorservo = new System.Windows.Forms.CheckBox();
            this.chb_switchonpoti = new System.Windows.Forms.CheckBox();
            this.chb_autocruise = new System.Windows.Forms.CheckBox();
            this.nud_magnetcount = new System.Windows.Forms.NumericUpDown();
            this.chb_brokensensor = new System.Windows.Forms.CheckBox();
            this.nud_pastimeout = new System.Windows.Forms.NumericUpDown();
            this.chb_DS1820 = new System.Windows.Forms.CheckBox();
            this.txb_tempsensepin = new System.Windows.Forms.TextBox();
            this.chb_external_voltage = new System.Windows.Forms.CheckBox();
            this.txb_external_voltage = new System.Windows.Forms.TextBox();
            this.txb_external_current = new System.Windows.Forms.TextBox();
            this.chb_external_current = new System.Windows.Forms.CheckBox();
            this.nud_external_voltage_amplitude = new System.Windows.Forms.NumericUpDown();
            this.nud_external_voltage_offset = new System.Windows.Forms.NumericUpDown();
            this.nud_external_current_amplitude = new System.Windows.Forms.NumericUpDown();
            this.nud_external_current_offset = new System.Windows.Forms.NumericUpDown();
            this.chb_resetintegral = new System.Windows.Forms.CheckBox();
            this.nud_fixedsoftpoti = new System.Windows.Forms.NumericUpDown();
            this.nud_gearchangepause = new System.Windows.Forms.NumericUpDown();
            this.chb_torque_throttle = new System.Windows.Forms.CheckBox();
            this.nud_torquethrottle_min = new System.Windows.Forms.NumericUpDown();
            this.nud_torquethrottle_full = new System.Windows.Forms.NumericUpDown();
            this.txb_thermistorpin = new System.Windows.Forms.TextBox();
            this.chb_thermistor = new System.Windows.Forms.CheckBox();
            this.nud_therm_t0 = new System.Windows.Forms.NumericUpDown();
            this.nud_therm_beta = new System.Windows.Forms.NumericUpDown();
            this.nud_therm_r = new System.Windows.Forms.NumericUpDown();
            this.nud_torque_zero = new System.Windows.Forms.NumericUpDown();
            this.chb_torquezero_auto = new System.Windows.Forms.CheckBox();
            this.chb_thermistor_cutoff = new System.Windows.Forms.CheckBox();
            this.nud_temperature_cutoff_stop = new System.Windows.Forms.NumericUpDown();
            this.nud_temperature_cutoff_start = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_brake = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_display = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panel_controls = new System.Windows.Forms.Panel();
            this.lbl_startup_unit = new System.Windows.Forms.Label();
            this.lbl_poti_startup = new System.Windows.Forms.Label();
            this.lbl_stepsize_unit = new System.Windows.Forms.Label();
            this.lbl_stepsize = new System.Windows.Forms.Label();
            this.lbl_poti_max = new System.Windows.Forms.Label();
            this.lbl_poti_min = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_throttle = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_fixed_throttle_unit = new System.Windows.Forms.Label();
            this.lbl_thr_max = new System.Windows.Forms.Label();
            this.chb_throttle = new System.Windows.Forms.CheckBox();
            this.lbl_thr_min = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.powergraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel_bottombracket = new System.Windows.Forms.Panel();
            this.lbl_torque_zero = new System.Windows.Forms.Label();
            this.lbl_torquethrottlemax = new System.Windows.Forms.Label();
            this.lbl_torquethrottlemin = new System.Windows.Forms.Label();
            this.lbl_gearchange = new System.Windows.Forms.Label();
            this.lbl_pastimeoutms = new System.Windows.Forms.Label();
            this.lbl_pastimeout = new System.Windows.Forms.Label();
            this.lbl_pastol = new System.Windows.Forms.Label();
            this.panel_power = new System.Windows.Forms.Panel();
            this.chb_startingaid = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel_speedsensor = new System.Windows.Forms.Panel();
            this.label47 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_profile = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.bt_load = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel_motor = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.panel_controlmode = new System.Windows.Forms.Panel();
            this.lbl_controlmode = new System.Windows.Forms.Label();
            this.panel_battery = new System.Windows.Forms.Panel();
            this.lbl_chargedetect_min = new System.Windows.Forms.Label();
            this.nud_capacity_2 = new System.Windows.Forms.NumericUpDown();
            this.label42 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.nud_capacity = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.bwSerial = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbVoltage = new System.Windows.Forms.TrackBar();
            this.desc_voltage = new System.Windows.Forms.Label();
            this.desc_current = new System.Windows.Forms.Label();
            this.tbCurrent = new System.Windows.Forms.TrackBar();
            this.label37 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.chart_pas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.desc_pas = new System.Windows.Forms.Label();
            this.lbl_pas_factor = new System.Windows.Forms.Label();
            this.lblPotiMin = new System.Windows.Forms.Label();
            this.lblPotiMax = new System.Windows.Forms.Label();
            this.lblPotiRaw = new System.Windows.Forms.Label();
            this.desc_poti = new System.Windows.Forms.Label();
            this.tbPoti = new System.Windows.Forms.TrackBar();
            this.lblThrottleMin = new System.Windows.Forms.Label();
            this.lblThrottleMax = new System.Windows.Forms.Label();
            this.lblThrottleRaw = new System.Windows.Forms.Label();
            this.desc_throttle = new System.Windows.Forms.Label();
            this.tbThrottle = new System.Windows.Forms.TrackBar();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.rbBrake = new System.Windows.Forms.RadioButton();
            this.nud_version = new System.Windows.Forms.NumericUpDown();
            this.label50 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_bpm_max = new System.Windows.Forms.NumericUpDown();
            this.nud_bpm_min = new System.Windows.Forms.NumericUpDown();
            this.label51 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_localpath = new System.Windows.Forms.ToolStripStatusLabel();
            this.bt_compile = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.tb_console = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_switch_profile = new System.Windows.Forms.Button();
            this.chb_online = new System.Windows.Forms.CheckBox();
            this.chb_local = new System.Windows.Forms.CheckBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.bt_source_local = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_setkilometers_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_settime_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_setcounter_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_serial_menu = new System.Windows.Forms.ToolStripComboBox();
            this.bt_connect_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_disconnect_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_refresh_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_bluetoothmode = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nud_circumference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_magnets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pasfactor_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pasfactor_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pas_tolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_motor_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_motor_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_poti_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_poti_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_throttle_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_throttle_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_power_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_power_thermal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_thermalsafespeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_startingaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_controlmode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vemergency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vcutoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_display_contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_speedcutoff_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_speedcutoff_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_menuidle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_idle_shutdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pidi_throttle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pidp_throttle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pidi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pidp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_idlespeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_power_max_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_speedcutoff_start_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_speedcutoff_stop_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_startingaid_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_controlmode_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stepsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_voltage_offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_voltage_amplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_current_amplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_current_offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_poti_startup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fixed_throttle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_chargedetect_min)).BeginInit();
            this.panel13.SuspendLayout();
            this.contextmenu_display.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextmenu_poti.SuspendLayout();
            this.panel14.SuspendLayout();
            this.contextmenu_throttle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_magnetcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pastimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_external_voltage_amplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_external_voltage_offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_external_current_amplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_external_current_offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fixedsoftpoti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gearchangepause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_torquethrottle_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_torquethrottle_full)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_therm_t0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_therm_beta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_therm_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_torque_zero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_temperature_cutoff_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_temperature_cutoff_start)).BeginInit();
            this.panel_brake.SuspendLayout();
            this.panel_display.SuspendLayout();
            this.panel_controls.SuspendLayout();
            this.panel_throttle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powergraph)).BeginInit();
            this.panel_bottombracket.SuspendLayout();
            this.panel_power.SuspendLayout();
            this.panel_speedsensor.SuspendLayout();
            this.panel_motor.SuspendLayout();
            this.panel_controlmode.SuspendLayout();
            this.panel_battery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_capacity_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPoti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThrottle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_version)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bpm_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bpm_min)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_bottombracket
            // 
            this.cb_bottombracket.FormattingEnabled = true;
            this.cb_bottombracket.Items.AddRange(new object[] {
            "none",
            "Standard PAS",
            "Thun X-Cell RT",
            "BBS01/02",
            "Sempu V1",
            "Sempu new",
            "Erider T9 4pin"});
            this.cb_bottombracket.Location = new System.Drawing.Point(26, 16);
            this.cb_bottombracket.Name = "cb_bottombracket";
            this.cb_bottombracket.Size = new System.Drawing.Size(121, 21);
            this.cb_bottombracket.TabIndex = 0;
            this.cb_bottombracket.Text = "none";
            this.cb_bottombracket.SelectedIndexChanged += new System.EventHandler(this.cb_bottombracket_SelectedIndexChanged);
            // 
            // nud_circumference
            // 
            this.nud_circumference.Location = new System.Drawing.Point(6, 33);
            this.nud_circumference.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nud_circumference.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_circumference.Name = "nud_circumference";
            this.nud_circumference.Size = new System.Drawing.Size(51, 20);
            this.nud_circumference.TabIndex = 1;
            this.toolTip1.SetToolTip(this.nud_circumference, "Type in the wheel circumference here. Measure it while sitting on the bike to get" +
        " best accurracy.");
            this.nud_circumference.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "mm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "speed sensor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "bottom bracket / PAS sensor";
            // 
            // nud_magnets
            // 
            this.nud_magnets.Location = new System.Drawing.Point(86, 38);
            this.nud_magnets.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nud_magnets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_magnets.Name = "nud_magnets";
            this.nud_magnets.Size = new System.Drawing.Size(61, 20);
            this.nud_magnets.TabIndex = 5;
            this.toolTip1.SetToolTip(this.nud_magnets, "Number of magnets/pulses of your PAS sensor. Usually 5, Thun X-Cell RT gives 8 pu" +
        "lses.");
            this.nud_magnets.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_magnets.Visible = false;
            // 
            // lbl_magnets
            // 
            this.lbl_magnets.AutoSize = true;
            this.lbl_magnets.Location = new System.Drawing.Point(23, 40);
            this.lbl_magnets.Name = "lbl_magnets";
            this.lbl_magnets.Size = new System.Drawing.Size(57, 13);
            this.lbl_magnets.TabIndex = 6;
            this.lbl_magnets.Text = "# magnets";
            this.lbl_magnets.Visible = false;
            // 
            // nud_pasfactor_min
            // 
            this.nud_pasfactor_min.DecimalPlaces = 2;
            this.nud_pasfactor_min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_pasfactor_min.Location = new System.Drawing.Point(26, 76);
            this.nud_pasfactor_min.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_pasfactor_min.Name = "nud_pasfactor_min";
            this.nud_pasfactor_min.Size = new System.Drawing.Size(45, 20);
            this.nud_pasfactor_min.TabIndex = 7;
            this.toolTip1.SetToolTip(this.nud_pasfactor_min, "minimum value for the PAS factor (PAS signal high time/PAS signal low time) to be" +
        " detect as proper pedaling. Should be a bit lower than the average value of the " +
        "PAS factor when you are pedaling");
            this.nud_pasfactor_min.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            this.nud_pasfactor_min.Visible = false;
            // 
            // nud_pasfactor_max
            // 
            this.nud_pasfactor_max.DecimalPlaces = 2;
            this.nud_pasfactor_max.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_pasfactor_max.Location = new System.Drawing.Point(98, 76);
            this.nud_pasfactor_max.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_pasfactor_max.Name = "nud_pasfactor_max";
            this.nud_pasfactor_max.Size = new System.Drawing.Size(49, 20);
            this.nud_pasfactor_max.TabIndex = 8;
            this.toolTip1.SetToolTip(this.nud_pasfactor_max, "maximum value for the PAS factor (PAS signal high time/PAS signal low time) to be" +
        " detect as proper pedaling. Should be a bit higher than the average PAS factor w" +
        "hen you are pedaling.");
            this.nud_pasfactor_max.Value = new decimal(new int[] {
            30,
            0,
            0,
            65536});
            this.nud_pasfactor_max.Visible = false;
            // 
            // lbl_pf
            // 
            this.lbl_pf.AutoSize = true;
            this.lbl_pf.Location = new System.Drawing.Point(55, 60);
            this.lbl_pf.Name = "lbl_pf";
            this.lbl_pf.Size = new System.Drawing.Size(58, 13);
            this.lbl_pf.TabIndex = 9;
            this.lbl_pf.Text = "PAS factor";
            this.lbl_pf.Visible = false;
            // 
            // lbl_pfmin
            // 
            this.lbl_pfmin.AutoSize = true;
            this.lbl_pfmin.Location = new System.Drawing.Point(20, 60);
            this.lbl_pfmin.Name = "lbl_pfmin";
            this.lbl_pfmin.Size = new System.Drawing.Size(23, 13);
            this.lbl_pfmin.TabIndex = 10;
            this.lbl_pfmin.Text = "min";
            this.lbl_pfmin.Visible = false;
            // 
            // lbl_pfmax
            // 
            this.lbl_pfmax.AutoSize = true;
            this.lbl_pfmax.Location = new System.Drawing.Point(125, 60);
            this.lbl_pfmax.Name = "lbl_pfmax";
            this.lbl_pfmax.Size = new System.Drawing.Size(26, 13);
            this.lbl_pfmax.TabIndex = 11;
            this.lbl_pfmax.Text = "max";
            this.lbl_pfmax.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.AutoPopDelay = 60000;
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.Color.Red;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.UseAnimation = false;
            this.toolTip1.UseFading = false;
            // 
            // chb_brake
            // 
            this.chb_brake.AutoSize = true;
            this.chb_brake.Location = new System.Drawing.Point(3, 21);
            this.chb_brake.Name = "chb_brake";
            this.chb_brake.Size = new System.Drawing.Size(73, 17);
            this.chb_brake.TabIndex = 12;
            this.chb_brake.Text = "use brake";
            this.toolTip1.SetToolTip(this.chb_brake, "Check this  if brake switch connected");
            this.chb_brake.UseVisualStyleBackColor = true;
            this.chb_brake.CheckedChanged += new System.EventHandler(this.cb_brake_CheckedChanged);
            // 
            // chb_brakeinverted
            // 
            this.chb_brakeinverted.AutoSize = true;
            this.chb_brakeinverted.Enabled = false;
            this.chb_brakeinverted.Location = new System.Drawing.Point(3, 44);
            this.chb_brakeinverted.Name = "chb_brakeinverted";
            this.chb_brakeinverted.Size = new System.Drawing.Size(82, 17);
            this.chb_brakeinverted.TabIndex = 13;
            this.chb_brakeinverted.Text = "invert brake";
            this.toolTip1.SetToolTip(this.chb_brakeinverted, "Check if brake switch is OPEN when BRAKING");
            this.chb_brakeinverted.UseVisualStyleBackColor = true;
            // 
            // nud_pas_tolerance
            // 
            this.nud_pas_tolerance.Location = new System.Drawing.Point(98, 98);
            this.nud_pas_tolerance.Name = "nud_pas_tolerance";
            this.nud_pas_tolerance.Size = new System.Drawing.Size(49, 20);
            this.nud_pas_tolerance.TabIndex = 12;
            this.toolTip1.SetToolTip(this.nud_pas_tolerance, "Sets number of consecutive tolerated pulses with pas_factor not in above range");
            this.nud_pas_tolerance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_pas_tolerance.Visible = false;
            // 
            // nud_motor_max
            // 
            this.nud_motor_max.Location = new System.Drawing.Point(3, 38);
            this.nud_motor_max.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nud_motor_max.Name = "nud_motor_max";
            this.nud_motor_max.Size = new System.Drawing.Size(46, 20);
            this.nud_motor_max.TabIndex = 49;
            this.toolTip1.SetToolTip(this.nud_motor_max, "0..255 means 0..5V at the signal output to the motor controller\r\nPlug in the valu" +
        "e above which the motor is not becoming faster any more.");
            this.nud_motor_max.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_motor_max.ValueChanged += new System.EventHandler(this.nud_motor_max_ValueChanged);
            // 
            // nud_motor_min
            // 
            this.nud_motor_min.Location = new System.Drawing.Point(3, 16);
            this.nud_motor_min.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nud_motor_min.Name = "nud_motor_min";
            this.nud_motor_min.Size = new System.Drawing.Size(46, 20);
            this.nud_motor_min.TabIndex = 48;
            this.toolTip1.SetToolTip(this.nud_motor_min, "0..255 means 0..5V at the signal output to the motor controller\r\nPlug in the lowe" +
        "st value for which the motor does just not start to spin.");
            this.nud_motor_min.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_motor_min.ValueChanged += new System.EventHandler(this.nud_motor_min_ValueChanged);
            // 
            // nud_poti_max
            // 
            this.nud_poti_max.Location = new System.Drawing.Point(5, 59);
            this.nud_poti_max.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.nud_poti_max.Name = "nud_poti_max";
            this.nud_poti_max.Size = new System.Drawing.Size(46, 20);
            this.nud_poti_max.TabIndex = 20;
            this.toolTip1.SetToolTip(this.nud_poti_max, "0..1023 means 0-5V signal from the poti signal.\r\nPlug in the measured value when " +
        "poti is in highest position. Can be determined from the live data view on the ri" +
        "ght.\r\n");
            this.nud_poti_max.Value = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.nud_poti_max.Visible = false;
            // 
            // nud_poti_min
            // 
            this.nud_poti_min.Location = new System.Drawing.Point(5, 38);
            this.nud_poti_min.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.nud_poti_min.Name = "nud_poti_min";
            this.nud_poti_min.Size = new System.Drawing.Size(46, 20);
            this.nud_poti_min.TabIndex = 19;
            this.toolTip1.SetToolTip(this.nud_poti_min, "0..1023 means 0-5V signal from the poti signal.\r\nPlug in the measured value when " +
        "poti is in lowest position. Can be determined from the live data view on the rig" +
        "ht.");
            this.nud_poti_min.Visible = false;
            // 
            // cb_controls
            // 
            this.cb_controls.DropDownWidth = 100;
            this.cb_controls.FormattingEnabled = true;
            this.cb_controls.Items.AddRange(new object[] {
            "none",
            "poti",
            "soft-poti",
            "up-down-switches"});
            this.cb_controls.Location = new System.Drawing.Point(5, 16);
            this.cb_controls.Name = "cb_controls";
            this.cb_controls.Size = new System.Drawing.Size(69, 21);
            this.cb_controls.TabIndex = 18;
            this.cb_controls.Text = "none";
            this.toolTip1.SetToolTip(this.cb_controls, resources.GetString("cb_controls.ToolTip"));
            this.cb_controls.SelectedIndexChanged += new System.EventHandler(this.cb_controls_SelectedIndexChanged);
            // 
            // nud_throttle_max
            // 
            this.nud_throttle_max.Location = new System.Drawing.Point(52, 28);
            this.nud_throttle_max.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.nud_throttle_max.Name = "nud_throttle_max";
            this.nud_throttle_max.Size = new System.Drawing.Size(46, 20);
            this.nud_throttle_max.TabIndex = 24;
            this.toolTip1.SetToolTip(this.nud_throttle_max, "0..1023 means 0-5V signal from the throttle.\r\nPlug in the measured value when thr" +
        "ottle is fully pressed. Can be determined from the live data view on the right.");
            this.nud_throttle_max.Value = new decimal(new int[] {
            870,
            0,
            0,
            0});
            this.nud_throttle_max.Visible = false;
            // 
            // nud_throttle_min
            // 
            this.nud_throttle_min.Location = new System.Drawing.Point(1, 28);
            this.nud_throttle_min.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.nud_throttle_min.Name = "nud_throttle_min";
            this.nud_throttle_min.Size = new System.Drawing.Size(46, 20);
            this.nud_throttle_min.TabIndex = 23;
            this.toolTip1.SetToolTip(this.nud_throttle_min, "0..1023 means 0-5V signal from the throttle.\r\nPlug in the measured value when thr" +
        "ottle is not touched. Can be determined from the live data view on the right.");
            this.nud_throttle_min.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nud_throttle_min.Visible = false;
            // 
            // nud_power_max
            // 
            this.nud_power_max.ForeColor = System.Drawing.Color.Blue;
            this.nud_power_max.Location = new System.Drawing.Point(129, 14);
            this.nud_power_max.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nud_power_max.Name = "nud_power_max";
            this.nud_power_max.Size = new System.Drawing.Size(46, 20);
            this.nud_power_max.TabIndex = 22;
            this.toolTip1.SetToolTip(this.nud_power_max, "Maximum power drawn by motor. For a street legal 250 W system this should be arou" +
        "nd 500 W.");
            this.nud_power_max.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nud_power_max.ValueChanged += new System.EventHandler(this.nud_power_max_ValueChanged);
            // 
            // nud_power_thermal
            // 
            this.nud_power_thermal.Location = new System.Drawing.Point(129, 40);
            this.nud_power_thermal.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nud_power_thermal.Name = "nud_power_thermal";
            this.nud_power_thermal.Size = new System.Drawing.Size(46, 20);
            this.nud_power_thermal.TabIndex = 27;
            this.toolTip1.SetToolTip(this.nud_power_thermal, "Thermal power that motor can withstand");
            this.nud_power_thermal.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nud_power_thermal.ValueChanged += new System.EventHandler(this.nud_power_max_ValueChanged);
            // 
            // nud_thermalsafespeed
            // 
            this.nud_thermalsafespeed.Location = new System.Drawing.Point(129, 66);
            this.nud_thermalsafespeed.Name = "nud_thermalsafespeed";
            this.nud_thermalsafespeed.Size = new System.Drawing.Size(46, 20);
            this.nud_thermalsafespeed.TabIndex = 29;
            this.toolTip1.SetToolTip(this.nud_thermalsafespeed, "Speed above which the efficiency of the motor is such that the thermal limit defi" +
        "ned above will never be  exceeded.");
            this.nud_thermalsafespeed.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nud_thermalsafespeed.ValueChanged += new System.EventHandler(this.nud_power_max_ValueChanged);
            // 
            // nud_startingaid
            // 
            this.nud_startingaid.ForeColor = System.Drawing.Color.Blue;
            this.nud_startingaid.Location = new System.Drawing.Point(288, 65);
            this.nud_startingaid.Name = "nud_startingaid";
            this.nud_startingaid.Size = new System.Drawing.Size(54, 20);
            this.nud_startingaid.TabIndex = 35;
            this.toolTip1.SetToolTip(this.nud_startingaid, "Starting aid with thumb throttle works up to this speed.");
            this.nud_startingaid.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nud_startingaid.ValueChanged += new System.EventHandler(this.nud_power_max_ValueChanged);
            // 
            // cb_controlmode
            // 
            this.cb_controlmode.FormattingEnabled = true;
            this.cb_controlmode.Items.AddRange(new object[] {
            "power",
            "wh/km",
            "torque"});
            this.cb_controlmode.Location = new System.Drawing.Point(8, 19);
            this.cb_controlmode.Name = "cb_controlmode";
            this.cb_controlmode.Size = new System.Drawing.Size(88, 21);
            this.cb_controlmode.TabIndex = 44;
            this.cb_controlmode.Text = "power";
            this.toolTip1.SetToolTip(this.cb_controlmode, resources.GetString("cb_controlmode.ToolTip"));
            this.cb_controlmode.SelectedIndexChanged += new System.EventHandler(this.cb_controlmode_SelectedIndexChanged);
            // 
            // cb_serialmode
            // 
            this.cb_serialmode.FormattingEnabled = true;
            this.cb_serialmode.Items.AddRange(new object[] {
            "debug",
            "none",
            "android",
            "mmc",
            "logview",
            "IOS",
            "dispay-debug"});
            this.cb_serialmode.Location = new System.Drawing.Point(5, 19);
            this.cb_serialmode.Name = "cb_serialmode";
            this.cb_serialmode.Size = new System.Drawing.Size(80, 21);
            this.cb_serialmode.TabIndex = 46;
            this.cb_serialmode.Text = "debug";
            this.toolTip1.SetToolTip(this.cb_serialmode, resources.GetString("cb_serialmode.ToolTip"));
            // 
            // nud_controlmode
            // 
            this.nud_controlmode.ForeColor = System.Drawing.Color.Blue;
            this.nud_controlmode.Location = new System.Drawing.Point(103, 19);
            this.nud_controlmode.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nud_controlmode.Name = "nud_controlmode";
            this.nud_controlmode.Size = new System.Drawing.Size(73, 20);
            this.nud_controlmode.TabIndex = 48;
            this.toolTip1.SetToolTip(this.nud_controlmode, resources.GetString("nud_controlmode.ToolTip"));
            this.nud_controlmode.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // nud_vemergency
            // 
            this.nud_vemergency.DecimalPlaces = 1;
            this.nud_vemergency.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_vemergency.Location = new System.Drawing.Point(122, 71);
            this.nud_vemergency.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_vemergency.Name = "nud_vemergency";
            this.nud_vemergency.Size = new System.Drawing.Size(46, 20);
            this.nud_vemergency.TabIndex = 59;
            this.toolTip1.SetToolTip(this.nud_vemergency, "For voltages below this value the system will immediately shut down.");
            this.nud_vemergency.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.nud_vemergency.ValueChanged += new System.EventHandler(this.nud_vemergency_ValueChanged);
            // 
            // nud_vcutoff
            // 
            this.nud_vcutoff.DecimalPlaces = 1;
            this.nud_vcutoff.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_vcutoff.Location = new System.Drawing.Point(122, 50);
            this.nud_vcutoff.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_vcutoff.Name = "nud_vcutoff";
            this.nud_vcutoff.Size = new System.Drawing.Size(46, 20);
            this.nud_vcutoff.TabIndex = 57;
            this.toolTip1.SetToolTip(this.nud_vcutoff, "Below this battery voltage the power limit will be 0 to protect the battery. This" +
        " is the lower limit of the voltage bar in the battery meter (Nokia display)");
            this.nud_vcutoff.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            this.nud_vcutoff.ValueChanged += new System.EventHandler(this.nud_vcutoff_ValueChanged);
            // 
            // lblVoltageRaw
            // 
            this.lblVoltageRaw.AutoSize = true;
            this.lblVoltageRaw.Location = new System.Drawing.Point(1033, 73);
            this.lblVoltageRaw.Name = "lblVoltageRaw";
            this.lblVoltageRaw.Size = new System.Drawing.Size(13, 13);
            this.lblVoltageRaw.TabIndex = 61;
            this.lblVoltageRaw.Text = "0";
            this.toolTip1.SetToolTip(this.lblVoltageRaw, "This is the raw value of the voltage measurement\r\n0-1023=0-5V at the Arduino pin");
            // 
            // lblCurrentRaw
            // 
            this.lblCurrentRaw.AutoSize = true;
            this.lblCurrentRaw.Location = new System.Drawing.Point(1033, 162);
            this.lblCurrentRaw.Name = "lblCurrentRaw";
            this.lblCurrentRaw.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentRaw.TabIndex = 64;
            this.lblCurrentRaw.Text = "0";
            this.toolTip1.SetToolTip(this.lblCurrentRaw, "This is the raw value of the current measurement\r\n0-1023=0-5V at the Arduino pin");
            // 
            // lblVoltageCalc
            // 
            this.lblVoltageCalc.AutoSize = true;
            this.lblVoltageCalc.Location = new System.Drawing.Point(1033, 94);
            this.lblVoltageCalc.Name = "lblVoltageCalc";
            this.lblVoltageCalc.Size = new System.Drawing.Size(13, 13);
            this.lblVoltageCalc.TabIndex = 65;
            this.lblVoltageCalc.Text = "0";
            this.toolTip1.SetToolTip(this.lblVoltageCalc, "This is the actual voltage calculated from the raw measurement using the paramete" +
        "rs on the right.");
            // 
            // lblCurrentCalc
            // 
            this.lblCurrentCalc.AutoSize = true;
            this.lblCurrentCalc.Location = new System.Drawing.Point(1033, 183);
            this.lblCurrentCalc.Name = "lblCurrentCalc";
            this.lblCurrentCalc.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentCalc.TabIndex = 66;
            this.lblCurrentCalc.Text = "0";
            this.toolTip1.SetToolTip(this.lblCurrentCalc, "This is the actual current calculated from the raw measurement using the paramete" +
        "rs on the right.");
            // 
            // cb_display
            // 
            this.cb_display.DropDownWidth = 300;
            this.cb_display.FormattingEnabled = true;
            this.cb_display.Items.AddRange(new object[] {
            "none",
            "Nokia 4 Pin (standard)",
            "Nokia 5 Pin",
            "16X2 LCD 4-bit Mode",
            "16X2 LCD Serial Mode",
            "BMS Battery S-LCD",
            "BMS Battery S-LCD3",
            "Kingmeter 618U (KM5s, EBS-LCD2, J-LCD, WS-LCD)",
            "Kingmeter 901U (KM5s)",
            "Bafang C961",
            "Bafang C965",
            "Bafang SW102"});
            this.cb_display.Location = new System.Drawing.Point(3, 16);
            this.cb_display.Name = "cb_display";
            this.cb_display.Size = new System.Drawing.Size(105, 21);
            this.cb_display.TabIndex = 14;
            this.cb_display.Text = "none";
            this.toolTip1.SetToolTip(this.cb_display, "select your display type");
            this.cb_display.SelectedIndexChanged += new System.EventHandler(this.cb_display_SelectedIndexChanged);
            // 
            // chb_backlight
            // 
            this.chb_backlight.AutoSize = true;
            this.chb_backlight.Enabled = false;
            this.chb_backlight.Location = new System.Drawing.Point(3, 43);
            this.chb_backlight.Name = "chb_backlight";
            this.chb_backlight.Size = new System.Drawing.Size(111, 17);
            this.chb_backlight.TabIndex = 16;
            this.chb_backlight.Text = "dynamic backlight";
            this.toolTip1.SetToolTip(this.chb_backlight, "Check if you have connected the Display backlight on Arduino Pin D12");
            this.chb_backlight.UseVisualStyleBackColor = true;
            // 
            // nud_display_contrast
            // 
            this.nud_display_contrast.Enabled = false;
            this.nud_display_contrast.Location = new System.Drawing.Point(3, 60);
            this.nud_display_contrast.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_display_contrast.Name = "nud_display_contrast";
            this.nud_display_contrast.Size = new System.Drawing.Size(44, 20);
            this.nud_display_contrast.TabIndex = 17;
            this.toolTip1.SetToolTip(this.nud_display_contrast, "LCD contrast for nokia displays.");
            this.nud_display_contrast.Value = new decimal(new int[] {
            190,
            0,
            0,
            0});
            // 
            // nud_speedcutoff_stop
            // 
            this.nud_speedcutoff_stop.ForeColor = System.Drawing.Color.Blue;
            this.nud_speedcutoff_stop.Location = new System.Drawing.Point(288, 35);
            this.nud_speedcutoff_stop.Name = "nud_speedcutoff_stop";
            this.nud_speedcutoff_stop.Size = new System.Drawing.Size(54, 20);
            this.nud_speedcutoff_stop.TabIndex = 31;
            this.toolTip1.SetToolTip(this.nud_speedcutoff_stop, "This is the speed at which the motor power will be 0. Make range larger to have a" +
        " smoother speed cutoff.");
            this.nud_speedcutoff_stop.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_speedcutoff_stop.ValueChanged += new System.EventHandler(this.nud_speedcutoff_stop_ValueChanged);
            // 
            // nud_speedcutoff_start
            // 
            this.nud_speedcutoff_start.ForeColor = System.Drawing.Color.Blue;
            this.nud_speedcutoff_start.Location = new System.Drawing.Point(288, 14);
            this.nud_speedcutoff_start.Name = "nud_speedcutoff_start";
            this.nud_speedcutoff_start.Size = new System.Drawing.Size(54, 20);
            this.nud_speedcutoff_start.TabIndex = 33;
            this.toolTip1.SetToolTip(this.nud_speedcutoff_start, "This is the speed above which the power is slowly decreased towards 0. Make range" +
        " larger to have a smoother speed cutoff.");
            this.nud_speedcutoff_start.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_speedcutoff_start.ValueChanged += new System.EventHandler(this.nud_speedcutoff_start_ValueChanged);
            // 
            // nud_menuidle
            // 
            this.nud_menuidle.Location = new System.Drawing.Point(93, 35);
            this.nud_menuidle.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nud_menuidle.Name = "nud_menuidle";
            this.nud_menuidle.Size = new System.Drawing.Size(59, 20);
            this.nud_menuidle.TabIndex = 111;
            this.toolTip1.SetToolTip(this.nud_menuidle, "Time in seconds until menu is closed when no key is pressed");
            this.nud_menuidle.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // txb_goodbye
            // 
            this.txb_goodbye.Location = new System.Drawing.Point(92, 77);
            this.txb_goodbye.Name = "txb_goodbye";
            this.txb_goodbye.Size = new System.Drawing.Size(60, 20);
            this.txb_goodbye.TabIndex = 107;
            this.txb_goodbye.Text = "Live long and prosper!";
            this.toolTip1.SetToolTip(this.txb_goodbye, "Message shown when shutting down");
            // 
            // txb_welcometext
            // 
            this.txb_welcometext.Location = new System.Drawing.Point(92, 56);
            this.txb_welcometext.Name = "txb_welcometext";
            this.txb_welcometext.Size = new System.Drawing.Size(60, 20);
            this.txb_welcometext.TabIndex = 105;
            this.txb_welcometext.Text = "Welcome!";
            this.toolTip1.SetToolTip(this.txb_welcometext, "Message shown at startup");
            // 
            // nud_idle_shutdown
            // 
            this.nud_idle_shutdown.Location = new System.Drawing.Point(93, 14);
            this.nud_idle_shutdown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nud_idle_shutdown.Name = "nud_idle_shutdown";
            this.nud_idle_shutdown.Size = new System.Drawing.Size(59, 20);
            this.nud_idle_shutdown.TabIndex = 9;
            this.toolTip1.SetToolTip(this.nud_idle_shutdown, "Time in seconds after which system shuts down when no wheel turn is detected");
            this.nud_idle_shutdown.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // nud_pidi_throttle
            // 
            this.nud_pidi_throttle.DecimalPlaces = 2;
            this.nud_pidi_throttle.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_pidi_throttle.Location = new System.Drawing.Point(4, 165);
            this.nud_pidi_throttle.Name = "nud_pidi_throttle";
            this.nud_pidi_throttle.Size = new System.Drawing.Size(46, 20);
            this.nud_pidi_throttle.TabIndex = 8;
            this.toolTip1.SetToolTip(this.nud_pidi_throttle, "i-parameter of PID power control when throttle overrides poti power");
            this.nud_pidi_throttle.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // nud_pidp_throttle
            // 
            this.nud_pidp_throttle.DecimalPlaces = 2;
            this.nud_pidp_throttle.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_pidp_throttle.Location = new System.Drawing.Point(4, 144);
            this.nud_pidp_throttle.Name = "nud_pidp_throttle";
            this.nud_pidp_throttle.Size = new System.Drawing.Size(46, 20);
            this.nud_pidp_throttle.TabIndex = 7;
            this.toolTip1.SetToolTip(this.nud_pidp_throttle, "p-parameter of PID power control when throttle overrides poti power");
            this.nud_pidp_throttle.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // nud_pidi
            // 
            this.nud_pidi.DecimalPlaces = 2;
            this.nud_pidi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_pidi.Location = new System.Drawing.Point(4, 123);
            this.nud_pidi.Name = "nud_pidi";
            this.nud_pidi.Size = new System.Drawing.Size(46, 20);
            this.nud_pidi.TabIndex = 6;
            this.toolTip1.SetToolTip(this.nud_pidi, "i-parameter of PID power control");
            this.nud_pidi.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nud_pidp
            // 
            this.nud_pidp.DecimalPlaces = 2;
            this.nud_pidp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_pidp.Location = new System.Drawing.Point(4, 102);
            this.nud_pidp.Name = "nud_pidp";
            this.nud_pidp.Size = new System.Drawing.Size(46, 20);
            this.nud_pidp.TabIndex = 5;
            this.toolTip1.SetToolTip(this.nud_pidp, "p-parameter of PID power control");
            // 
            // nud_vmax
            // 
            this.nud_vmax.DecimalPlaces = 1;
            this.nud_vmax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_vmax.Location = new System.Drawing.Point(122, 29);
            this.nud_vmax.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_vmax.Name = "nud_vmax";
            this.nud_vmax.Size = new System.Drawing.Size(46, 20);
            this.nud_vmax.TabIndex = 61;
            this.toolTip1.SetToolTip(this.nud_vmax, "Battery voltage when fully charged. This is the upper limit of the voltage bar in" +
        " the battery meter (for Nokia displays)");
            this.nud_vmax.Value = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.nud_vmax.ValueChanged += new System.EventHandler(this.nud_vmax_ValueChanged);
            // 
            // nud_idlespeed
            // 
            this.nud_idlespeed.Enabled = false;
            this.nud_idlespeed.Location = new System.Drawing.Point(3, 60);
            this.nud_idlespeed.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nud_idlespeed.Name = "nud_idlespeed";
            this.nud_idlespeed.Size = new System.Drawing.Size(46, 20);
            this.nud_idlespeed.TabIndex = 53;
            this.toolTip1.SetToolTip(this.nud_idlespeed, "Virtual idle speed of motor when at full throttle without any load (0W power!). U" +
        "sed for pre-guess of motor output to optimize response behaviour. Is approx. fac" +
        "tor 2 above real idle speed.");
            this.nud_idlespeed.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // chb_preguess
            // 
            this.chb_preguess.AutoSize = true;
            this.chb_preguess.Location = new System.Drawing.Point(4, 82);
            this.chb_preguess.Name = "chb_preguess";
            this.chb_preguess.Size = new System.Drawing.Size(92, 17);
            this.chb_preguess.TabIndex = 55;
            this.chb_preguess.Text = "use pre-guess";
            this.toolTip1.SetToolTip(this.chb_preguess, "Check if you want to use pre-guessing of throttle signal to motor. Usefull for mo" +
        "tor controllers with speed throttle to have a more direct response behaviour.");
            this.chb_preguess.UseVisualStyleBackColor = true;
            this.chb_preguess.CheckedChanged += new System.EventHandler(this.chb_preguess_CheckedChanged);
            // 
            // nud_power_max_2
            // 
            this.nud_power_max_2.BackColor = System.Drawing.Color.White;
            this.nud_power_max_2.ForeColor = System.Drawing.Color.Red;
            this.nud_power_max_2.Location = new System.Drawing.Point(129, 14);
            this.nud_power_max_2.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nud_power_max_2.Name = "nud_power_max_2";
            this.nud_power_max_2.Size = new System.Drawing.Size(46, 20);
            this.nud_power_max_2.TabIndex = 113;
            this.toolTip1.SetToolTip(this.nud_power_max_2, "Maximum power drawn by motor. For a street legal 250 W system this should be arou" +
        "nd 500 W.");
            this.nud_power_max_2.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_power_max_2.Visible = false;
            this.nud_power_max_2.ValueChanged += new System.EventHandler(this.nud_power_max_2_ValueChanged);
            // 
            // nud_speedcutoff_start_2
            // 
            this.nud_speedcutoff_start_2.ForeColor = System.Drawing.Color.Red;
            this.nud_speedcutoff_start_2.Location = new System.Drawing.Point(288, 14);
            this.nud_speedcutoff_start_2.Name = "nud_speedcutoff_start_2";
            this.nud_speedcutoff_start_2.Size = new System.Drawing.Size(54, 20);
            this.nud_speedcutoff_start_2.TabIndex = 113;
            this.toolTip1.SetToolTip(this.nud_speedcutoff_start_2, "This is the speed above which the power is slowly decreased towards 0. Make range" +
        " larger to have a smoother speed cutoff.");
            this.nud_speedcutoff_start_2.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_speedcutoff_start_2.Visible = false;
            this.nud_speedcutoff_start_2.ValueChanged += new System.EventHandler(this.nud_speedcutoff_start_2_ValueChanged);
            // 
            // nud_speedcutoff_stop_2
            // 
            this.nud_speedcutoff_stop_2.ForeColor = System.Drawing.Color.Red;
            this.nud_speedcutoff_stop_2.Location = new System.Drawing.Point(288, 35);
            this.nud_speedcutoff_stop_2.Name = "nud_speedcutoff_stop_2";
            this.nud_speedcutoff_stop_2.Size = new System.Drawing.Size(54, 20);
            this.nud_speedcutoff_stop_2.TabIndex = 113;
            this.toolTip1.SetToolTip(this.nud_speedcutoff_stop_2, "This is the speed at which the motor power will be 0. Make range larger to have a" +
        " smoother speed cutoff.");
            this.nud_speedcutoff_stop_2.Value = new decimal(new int[] {
            27,
            0,
            0,
            0});
            this.nud_speedcutoff_stop_2.Visible = false;
            this.nud_speedcutoff_stop_2.ValueChanged += new System.EventHandler(this.nud_speedcutoff_stop_2_ValueChanged);
            // 
            // nud_startingaid_2
            // 
            this.nud_startingaid_2.ForeColor = System.Drawing.Color.Red;
            this.nud_startingaid_2.Location = new System.Drawing.Point(288, 65);
            this.nud_startingaid_2.Name = "nud_startingaid_2";
            this.nud_startingaid_2.Size = new System.Drawing.Size(54, 20);
            this.nud_startingaid_2.TabIndex = 113;
            this.toolTip1.SetToolTip(this.nud_startingaid_2, "Starting aid with thumb throttle works up to this speed.");
            this.nud_startingaid_2.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nud_startingaid_2.Visible = false;
            this.nud_startingaid_2.ValueChanged += new System.EventHandler(this.nud_power_max_ValueChanged);
            // 
            // nud_controlmode_2
            // 
            this.nud_controlmode_2.ForeColor = System.Drawing.Color.Red;
            this.nud_controlmode_2.Location = new System.Drawing.Point(103, 19);
            this.nud_controlmode_2.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nud_controlmode_2.Name = "nud_controlmode_2";
            this.nud_controlmode_2.Size = new System.Drawing.Size(73, 20);
            this.nud_controlmode_2.TabIndex = 113;
            this.toolTip1.SetToolTip(this.nud_controlmode_2, resources.GetString("nud_controlmode_2.ToolTip"));
            this.nud_controlmode_2.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_controlmode_2.Visible = false;
            // 
            // chb_firstaid
            // 
            this.chb_firstaid.AutoSize = true;
            this.chb_firstaid.Location = new System.Drawing.Point(3, 96);
            this.chb_firstaid.Name = "chb_firstaid";
            this.chb_firstaid.Size = new System.Drawing.Size(88, 17);
            this.chb_firstaid.TabIndex = 112;
            this.chb_firstaid.Text = "first aid menu";
            this.toolTip1.SetToolTip(this.chb_firstaid, "Enables appearance of first aid menu in nokia display");
            this.chb_firstaid.UseVisualStyleBackColor = true;
            // 
            // chb_chargedetection
            // 
            this.chb_chargedetection.AutoSize = true;
            this.chb_chargedetection.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_chargedetection.Checked = true;
            this.chb_chargedetection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_chargedetection.Location = new System.Drawing.Point(0, 91);
            this.chb_chargedetection.Name = "chb_chargedetection";
            this.chb_chargedetection.Size = new System.Drawing.Size(155, 17);
            this.chb_chargedetection.TabIndex = 18;
            this.chb_chargedetection.Text = "automatic charge detection";
            this.toolTip1.SetToolTip(this.chb_chargedetection, "Check if you want recharges to be automatically detected");
            this.chb_chargedetection.UseVisualStyleBackColor = true;
            this.chb_chargedetection.CheckedChanged += new System.EventHandler(this.chb_chargedetection_CheckedChanged);
            // 
            // chb_profilemenu
            // 
            this.chb_profilemenu.AutoSize = true;
            this.chb_profilemenu.Location = new System.Drawing.Point(3, 110);
            this.chb_profilemenu.Name = "chb_profilemenu";
            this.chb_profilemenu.Size = new System.Drawing.Size(130, 17);
            this.chb_profilemenu.TabIndex = 117;
            this.chb_profilemenu.Text = "profile switching menu";
            this.toolTip1.SetToolTip(this.chb_profilemenu, "Check if you want to see profile switching options in the display menu");
            this.chb_profilemenu.UseVisualStyleBackColor = true;
            // 
            // nud_stepsize
            // 
            this.nud_stepsize.Location = new System.Drawing.Point(39, 66);
            this.nud_stepsize.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.nud_stepsize.Name = "nud_stepsize";
            this.nud_stepsize.Size = new System.Drawing.Size(38, 20);
            this.nud_stepsize.TabIndex = 23;
            this.toolTip1.SetToolTip(this.nud_stepsize, "Stepsize for up-down switches");
            this.nud_stepsize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_stepsize.Visible = false;
            // 
            // chb_lightswitch
            // 
            this.chb_lightswitch.AutoSize = true;
            this.chb_lightswitch.Location = new System.Drawing.Point(3, 124);
            this.chb_lightswitch.Name = "chb_lightswitch";
            this.chb_lightswitch.Size = new System.Drawing.Size(121, 17);
            this.chb_lightswitch.TabIndex = 118;
            this.chb_lightswitch.Text = "support lights switch";
            this.toolTip1.SetToolTip(this.chb_lightswitch, "Check if you have SJ1 in the position to switch the headlight on and off by softw" +
        "are");
            this.chb_lightswitch.UseVisualStyleBackColor = true;
            this.chb_lightswitch.CheckedChanged += new System.EventHandler(this.chb_lightswitch_CheckedChanged);
            // 
            // chb_lightswitch_startup
            // 
            this.chb_lightswitch_startup.AutoSize = true;
            this.chb_lightswitch_startup.Enabled = false;
            this.chb_lightswitch_startup.Location = new System.Drawing.Point(23, 138);
            this.chb_lightswitch_startup.Name = "chb_lightswitch_startup";
            this.chb_lightswitch_startup.Size = new System.Drawing.Size(85, 17);
            this.chb_lightswitch_startup.TabIndex = 119;
            this.chb_lightswitch_startup.Text = "on at startup";
            this.toolTip1.SetToolTip(this.chb_lightswitch_startup, "Check if lights should be on at startup");
            this.chb_lightswitch_startup.UseVisualStyleBackColor = true;
            // 
            // chb_lightswitch_menu
            // 
            this.chb_lightswitch_menu.AutoSize = true;
            this.chb_lightswitch_menu.Enabled = false;
            this.chb_lightswitch_menu.Location = new System.Drawing.Point(23, 152);
            this.chb_lightswitch_menu.Name = "chb_lightswitch_menu";
            this.chb_lightswitch_menu.Size = new System.Drawing.Size(91, 17);
            this.chb_lightswitch_menu.TabIndex = 120;
            this.chb_lightswitch_menu.Text = "show in menu";
            this.toolTip1.SetToolTip(this.chb_lightswitch_menu, "Check if you want to have light switch options in the menu");
            this.chb_lightswitch_menu.UseVisualStyleBackColor = true;
            // 
            // chb_dspc01
            // 
            this.chb_dspc01.AutoSize = true;
            this.chb_dspc01.Location = new System.Drawing.Point(6, 61);
            this.chb_dspc01.Name = "chb_dspc01";
            this.chb_dspc01.Size = new System.Drawing.Size(172, 17);
            this.chb_dspc01.TabIndex = 24;
            this.chb_dspc01.Text = "DSPC01 temp/pressure sensor";
            this.toolTip1.SetToolTip(this.chb_dspc01, "Check if you have a DSPC01 temp/pressure sensor connected");
            this.chb_dspc01.UseVisualStyleBackColor = true;
            // 
            // chb_bmp085
            // 
            this.chb_bmp085.AutoSize = true;
            this.chb_bmp085.Location = new System.Drawing.Point(6, 47);
            this.chb_bmp085.Name = "chb_bmp085";
            this.chb_bmp085.Size = new System.Drawing.Size(144, 17);
            this.chb_bmp085.TabIndex = 18;
            this.chb_bmp085.Text = "BMP085 pressure sensor";
            this.toolTip1.SetToolTip(this.chb_bmp085, "Check if you have a BMP085 pressure sensor connected");
            this.chb_bmp085.UseVisualStyleBackColor = true;
            // 
            // chb_HRMI
            // 
            this.chb_HRMI.AutoSize = true;
            this.chb_HRMI.Location = new System.Drawing.Point(6, 13);
            this.chb_HRMI.Name = "chb_HRMI";
            this.chb_HRMI.Size = new System.Drawing.Size(136, 17);
            this.chb_HRMI.TabIndex = 17;
            this.chb_HRMI.Text = "HRMI heart rate sensor";
            this.toolTip1.SetToolTip(this.chb_HRMI, "Check if you have a HRMI heart rate sensor connected");
            this.chb_HRMI.UseVisualStyleBackColor = true;
            // 
            // chb_rtc
            // 
            this.chb_rtc.AutoSize = true;
            this.chb_rtc.Location = new System.Drawing.Point(6, 75);
            this.chb_rtc.Name = "chb_rtc";
            this.chb_rtc.Size = new System.Drawing.Size(90, 17);
            this.chb_rtc.TabIndex = 25;
            this.chb_rtc.Text = "DS1307 RTC";
            this.toolTip1.SetToolTip(this.chb_rtc, "Check if you have a DS1307 RTC connected");
            this.chb_rtc.UseVisualStyleBackColor = true;
            this.chb_rtc.CheckedChanged += new System.EventHandler(this.chb_rtc_CheckedChanged);
            // 
            // chb_bluetoothstartup
            // 
            this.chb_bluetoothstartup.AutoSize = true;
            this.chb_bluetoothstartup.Location = new System.Drawing.Point(3, 170);
            this.chb_bluetoothstartup.Name = "chb_bluetoothstartup";
            this.chb_bluetoothstartup.Size = new System.Drawing.Size(153, 17);
            this.chb_bluetoothstartup.TabIndex = 114;
            this.chb_bluetoothstartup.Text = "enable Bluetooth at startup";
            this.toolTip1.SetToolTip(this.chb_bluetoothstartup, "Blootooth will be enabled at startup if checked");
            this.chb_bluetoothstartup.UseVisualStyleBackColor = true;
            // 
            // nud_voltage_offset
            // 
            this.nud_voltage_offset.DecimalPlaces = 2;
            this.nud_voltage_offset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_voltage_offset.Location = new System.Drawing.Point(1139, 71);
            this.nud_voltage_offset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nud_voltage_offset.Name = "nud_voltage_offset";
            this.nud_voltage_offset.Size = new System.Drawing.Size(57, 20);
            this.nud_voltage_offset.TabIndex = 67;
            this.toolTip1.SetToolTip(this.nud_voltage_offset, "Offset for voltage sensor.");
            // 
            // nud_voltage_amplitude
            // 
            this.nud_voltage_amplitude.DecimalPlaces = 4;
            this.nud_voltage_amplitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nud_voltage_amplitude.Location = new System.Drawing.Point(1139, 93);
            this.nud_voltage_amplitude.Name = "nud_voltage_amplitude";
            this.nud_voltage_amplitude.Size = new System.Drawing.Size(57, 20);
            this.nud_voltage_amplitude.TabIndex = 68;
            this.toolTip1.SetToolTip(this.nud_voltage_amplitude, "Conversion factor for voltage sensor. Usually not changed.");
            this.nud_voltage_amplitude.Value = new decimal(new int[] {
            587,
            0,
            0,
            262144});
            // 
            // nud_current_amplitude
            // 
            this.nud_current_amplitude.DecimalPlaces = 4;
            this.nud_current_amplitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nud_current_amplitude.Location = new System.Drawing.Point(1139, 182);
            this.nud_current_amplitude.Name = "nud_current_amplitude";
            this.nud_current_amplitude.Size = new System.Drawing.Size(57, 20);
            this.nud_current_amplitude.TabIndex = 72;
            this.toolTip1.SetToolTip(this.nud_current_amplitude, "Conversion factor for current sensor. Usually not changed.");
            this.nud_current_amplitude.Value = new decimal(new int[] {
            741,
            0,
            0,
            262144});
            // 
            // nud_current_offset
            // 
            this.nud_current_offset.DecimalPlaces = 2;
            this.nud_current_offset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_current_offset.Location = new System.Drawing.Point(1139, 160);
            this.nud_current_offset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nud_current_offset.Name = "nud_current_offset";
            this.nud_current_offset.Size = new System.Drawing.Size(57, 20);
            this.nud_current_offset.TabIndex = 71;
            this.toolTip1.SetToolTip(this.nud_current_offset, "Offset for current sensor");
            // 
            // nud_poti_startup
            // 
            this.nud_poti_startup.Location = new System.Drawing.Point(38, 44);
            this.nud_poti_startup.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.nud_poti_startup.Name = "nud_poti_startup";
            this.nud_poti_startup.Size = new System.Drawing.Size(38, 20);
            this.nud_poti_startup.TabIndex = 26;
            this.toolTip1.SetToolTip(this.nud_poti_startup, "Startup Value for Poti");
            this.nud_poti_startup.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nud_poti_startup.Visible = false;
            // 
            // nud_fixed_throttle
            // 
            this.nud_fixed_throttle.Location = new System.Drawing.Point(40, 79);
            this.nud_fixed_throttle.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.nud_fixed_throttle.Name = "nud_fixed_throttle";
            this.nud_fixed_throttle.Size = new System.Drawing.Size(48, 20);
            this.nud_fixed_throttle.TabIndex = 27;
            this.toolTip1.SetToolTip(this.nud_fixed_throttle, "Set power for ACTION_FIXED_THROTTLE_VALUE here");
            // 
            // nud_chargedetect_min
            // 
            this.nud_chargedetect_min.DecimalPlaces = 1;
            this.nud_chargedetect_min.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_chargedetect_min.Location = new System.Drawing.Point(122, 107);
            this.nud_chargedetect_min.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_chargedetect_min.Name = "nud_chargedetect_min";
            this.nud_chargedetect_min.Size = new System.Drawing.Size(46, 20);
            this.nud_chargedetect_min.TabIndex = 114;
            this.toolTip1.SetToolTip(this.nud_chargedetect_min, "Minimum voltage for which a regarge is detected. Set this a bit below your fully " +
        "charged voltage.");
            this.nud_chargedetect_min.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // chb_gearshift
            // 
            this.chb_gearshift.AutoSize = true;
            this.chb_gearshift.Location = new System.Drawing.Point(3, 217);
            this.chb_gearshift.Name = "chb_gearshift";
            this.chb_gearshift.Size = new System.Drawing.Size(146, 17);
            this.chb_gearshift.TabIndex = 56;
            this.chb_gearshift.Text = "have double speed motor";
            this.toolTip1.SetToolTip(this.chb_gearshift, "Check this if you have a double speed motor and want to use automatic gear shifti" +
        "ng.");
            this.chb_gearshift.UseVisualStyleBackColor = true;
            this.chb_gearshift.CheckedChanged += new System.EventHandler(this.chb_gearshift_CheckedChanged);
            // 
            // txb_lowgear
            // 
            this.txb_lowgear.Enabled = false;
            this.txb_lowgear.Location = new System.Drawing.Point(43, 234);
            this.txb_lowgear.Name = "txb_lowgear";
            this.txb_lowgear.Size = new System.Drawing.Size(25, 20);
            this.txb_lowgear.TabIndex = 121;
            this.txb_lowgear.Text = "5";
            this.toolTip1.SetToolTip(this.txb_lowgear, "Pin connected to low gear signal (red cable)");
            // 
            // txb_highgear
            // 
            this.txb_highgear.Enabled = false;
            this.txb_highgear.Location = new System.Drawing.Point(121, 233);
            this.txb_highgear.MaxLength = 3;
            this.txb_highgear.Name = "txb_highgear";
            this.txb_highgear.Size = new System.Drawing.Size(25, 20);
            this.txb_highgear.TabIndex = 122;
            this.txb_highgear.Text = "7";
            this.toolTip1.SetToolTip(this.txb_highgear, "Pin connected to high gear signal (green cable)");
            // 
            // cb_bluetoothmode
            // 
            this.cb_bluetoothmode.FormattingEnabled = true;
            this.cb_bluetoothmode.Items.AddRange(new object[] {
            "debug",
            "none",
            "android",
            "mmc",
            "logview",
            "IOS",
            "display-debug"});
            this.cb_bluetoothmode.Location = new System.Drawing.Point(104, 19);
            this.cb_bluetoothmode.Name = "cb_bluetoothmode";
            this.cb_bluetoothmode.Size = new System.Drawing.Size(80, 21);
            this.cb_bluetoothmode.TabIndex = 49;
            this.cb_bluetoothmode.Text = "debug";
            this.toolTip1.SetToolTip(this.cb_bluetoothmode, resources.GetString("cb_bluetoothmode.ToolTip"));
            // 
            // chb_chargecounter
            // 
            this.chb_chargecounter.AutoSize = true;
            this.chb_chargecounter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_chargecounter.Location = new System.Drawing.Point(0, 129);
            this.chb_chargecounter.Name = "chb_chargecounter";
            this.chb_chargecounter.Size = new System.Drawing.Size(126, 17);
            this.chb_chargecounter.TabIndex = 116;
            this.chb_chargecounter.Text = "charge cycle counter";
            this.toolTip1.SetToolTip(this.chb_chargecounter, "Check this if you want to count charge cycles ");
            this.chb_chargecounter.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel13.ContextMenuStrip = this.contextmenu_display;
            this.panel13.Controls.Add(this.panel2);
            this.panel13.Location = new System.Drawing.Point(693, 198);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(91, 68);
            this.panel13.TabIndex = 104;
            this.toolTip1.SetToolTip(this.panel13, "RIGHT CLICK HERE!");
            this.panel13.MouseEnter += new System.EventHandler(this.panel13_MouseEnter);
            this.panel13.MouseLeave += new System.EventHandler(this.panel13_MouseLeave);
            // 
            // contextmenu_display
            // 
            this.contextmenu_display.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssm,
            this.menuButtonDOWNToolStripMenuItem,
            this.toolstripdisp1short,
            this.toolstripdisp1long,
            this.toolstripdisp2short,
            this.displaySwitch2LongToolStripMenuItem,
            this.toolStripMenuItem5});
            this.contextmenu_display.Name = "cm_display";
            this.contextmenu_display.Size = new System.Drawing.Size(215, 158);
            this.contextmenu_display.Opening += new System.ComponentModel.CancelEventHandler(this.contextmenu_display_Opening);
            // 
            // tssm
            // 
            this.tssm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbts_menuup});
            this.tssm.Name = "tssm";
            this.tssm.Size = new System.Drawing.Size(214, 22);
            this.tssm.Text = "Menu button UP";
            // 
            // cbts_menuup
            // 
            this.cbts_menuup.Items.AddRange(new object[] {
            "SWITCH_THROTTLE",
            "SWITCH_DISPLAY1",
            "SWITCH_DISPLAY2"});
            this.cbts_menuup.Name = "cbts_menuup";
            this.cbts_menuup.Size = new System.Drawing.Size(200, 23);
            // 
            // menuButtonDOWNToolStripMenuItem
            // 
            this.menuButtonDOWNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbts_menudown});
            this.menuButtonDOWNToolStripMenuItem.Name = "menuButtonDOWNToolStripMenuItem";
            this.menuButtonDOWNToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.menuButtonDOWNToolStripMenuItem.Text = "Menu button DOWN";
            // 
            // cbts_menudown
            // 
            this.cbts_menudown.Items.AddRange(new object[] {
            "SWITCH_THROTTLE",
            "SWITCH_DISPLAY1",
            "SWITCH_DISPLAY2"});
            this.cbts_menudown.Name = "cbts_menudown";
            this.cbts_menudown.Size = new System.Drawing.Size(200, 23);
            // 
            // toolstripdisp1short
            // 
            this.toolstripdisp1short.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbts_disp1short});
            this.toolstripdisp1short.Name = "toolstripdisp1short";
            this.toolstripdisp1short.Size = new System.Drawing.Size(214, 22);
            this.toolstripdisp1short.Text = "Display switch 1 short";
            // 
            // cbts_disp1short
            // 
            this.cbts_disp1short.Items.AddRange(new object[] {
            "ACTION_NONE",
            "ACTION_SET_SOFT_POTI",
            "ACTION_SHUTDOWN_SYSTEM",
            "ACTION_ENABLE_BACKLIGHT_LONG",
            "ACTION_TOGGLE_BLUETOOTH",
            "ACTION_ENTER_MENU",
            "ACTION_PROFILE_1",
            "ACTION_PROFILE_2",
            "ACTION_PROFILE",
            "ACTION_TOGGLE_LIGHTS",
            "ACTION_INCREASE_POTI",
            "ACTION_DECREASE_POTI",
            "ACTION_FIXED_THROTTLE_VALUE",
            "ACTION_DISPLAY_PREV_VIEW",
            "ACTION_DISPLAY_NEXT_VIEW"});
            this.cbts_disp1short.Name = "cbts_disp1short";
            this.cbts_disp1short.Size = new System.Drawing.Size(200, 23);
            // 
            // toolstripdisp1long
            // 
            this.toolstripdisp1long.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbts_disp1long});
            this.toolstripdisp1long.Name = "toolstripdisp1long";
            this.toolstripdisp1long.Size = new System.Drawing.Size(214, 22);
            this.toolstripdisp1long.Text = "Display switch 1 long";
            // 
            // cbts_disp1long
            // 
            this.cbts_disp1long.Name = "cbts_disp1long";
            this.cbts_disp1long.Size = new System.Drawing.Size(200, 23);
            // 
            // toolstripdisp2short
            // 
            this.toolstripdisp2short.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbts_disp2short});
            this.toolstripdisp2short.Name = "toolstripdisp2short";
            this.toolstripdisp2short.Size = new System.Drawing.Size(214, 22);
            this.toolstripdisp2short.Text = "Display switch 2 short";
            // 
            // cbts_disp2short
            // 
            this.cbts_disp2short.Items.AddRange(new object[] {
            "ACTION_NONE",
            "ACTION_SET_SOFT_POTI",
            "ACTION_SHUTDOWN_SYSTEM",
            "ACTION_ENABLE_BACKLIGHT_LONG",
            "ACTION_TOGGLE_BLUETOOTH",
            "ACTION_ENTER_MENU",
            "ACTION_PROFILE_1",
            "ACTION_PROFILE_2",
            "ACTION_PROFILE",
            "ACTION_TOGGLE_LIGHTS",
            "ACTION_INCREASE_POTI",
            "ACTION_DECREASE_POTI"});
            this.cbts_disp2short.Name = "cbts_disp2short";
            this.cbts_disp2short.Size = new System.Drawing.Size(200, 23);
            // 
            // displaySwitch2LongToolStripMenuItem
            // 
            this.displaySwitch2LongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbts_disp2long});
            this.displaySwitch2LongToolStripMenuItem.Name = "displaySwitch2LongToolStripMenuItem";
            this.displaySwitch2LongToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.displaySwitch2LongToolStripMenuItem.Text = "Display switch 2 long";
            // 
            // cbts_disp2long
            // 
            this.cbts_disp2long.Items.AddRange(new object[] {
            "ACTION_NONE",
            "ACTION_SET_SOFT_POTI",
            "ACTION_SHUTDOWN_SYSTEM",
            "ACTION_ENABLE_BACKLIGHT_LONG",
            "ACTION_TOGGLE_BLUETOOTH",
            "ACTION_ENTER_MENU",
            "ACTION_PROFILE_1",
            "ACTION_PROFILE_2",
            "ACTION_PROFILE",
            "ACTION_TOGGLE_LIGHTS",
            "ACTION_INCREASE_POTI",
            "ACTION_DECREASE_POTI"});
            this.cbts_disp2long.Name = "cbts_disp2long";
            this.cbts_disp2long.Size = new System.Drawing.Size(200, 23);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_GRAPHIC,
            this.tsmi_HUMAN,
            this.tsmi_ENVIRONMENT,
            this.tsmi_TIME,
            this.tsmi_BATTERY,
            this.tsmi_ODO});
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem5.Text = "Views (check to activate)";
            // 
            // tsmi_GRAPHIC
            // 
            this.tsmi_GRAPHIC.Checked = true;
            this.tsmi_GRAPHIC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_GRAPHIC.Name = "tsmi_GRAPHIC";
            this.tsmi_GRAPHIC.Size = new System.Drawing.Size(160, 22);
            this.tsmi_GRAPHIC.Text = "GRAPHIC";
            this.tsmi_GRAPHIC.Click += new System.EventHandler(this.tsmi_displayview_click);
            // 
            // tsmi_HUMAN
            // 
            this.tsmi_HUMAN.Checked = true;
            this.tsmi_HUMAN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_HUMAN.Name = "tsmi_HUMAN";
            this.tsmi_HUMAN.Size = new System.Drawing.Size(160, 22);
            this.tsmi_HUMAN.Text = "HUMAN";
            this.tsmi_HUMAN.Click += new System.EventHandler(this.tsmi_displayview_click);
            // 
            // tsmi_ENVIRONMENT
            // 
            this.tsmi_ENVIRONMENT.Checked = true;
            this.tsmi_ENVIRONMENT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_ENVIRONMENT.Name = "tsmi_ENVIRONMENT";
            this.tsmi_ENVIRONMENT.Size = new System.Drawing.Size(160, 22);
            this.tsmi_ENVIRONMENT.Text = "ENVIRONMENT";
            this.tsmi_ENVIRONMENT.Click += new System.EventHandler(this.tsmi_displayview_click);
            // 
            // tsmi_TIME
            // 
            this.tsmi_TIME.Checked = true;
            this.tsmi_TIME.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_TIME.Name = "tsmi_TIME";
            this.tsmi_TIME.Size = new System.Drawing.Size(160, 22);
            this.tsmi_TIME.Text = "TIME";
            this.tsmi_TIME.Click += new System.EventHandler(this.tsmi_displayview_click);
            // 
            // tsmi_BATTERY
            // 
            this.tsmi_BATTERY.Checked = true;
            this.tsmi_BATTERY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_BATTERY.Name = "tsmi_BATTERY";
            this.tsmi_BATTERY.Size = new System.Drawing.Size(160, 22);
            this.tsmi_BATTERY.Text = "BATTERY";
            this.tsmi_BATTERY.Click += new System.EventHandler(this.tsmi_displayview_click);
            // 
            // tsmi_ODO
            // 
            this.tsmi_ODO.Checked = true;
            this.tsmi_ODO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_ODO.Name = "tsmi_ODO";
            this.tsmi_ODO.Size = new System.Drawing.Size(160, 22);
            this.tsmi_ODO.Text = "ODOMETER";
            this.tsmi_ODO.Click += new System.EventHandler(this.tsmi_displayview_click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(94, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 54);
            this.panel2.TabIndex = 105;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.ContextMenuStrip = this.contextmenu_poti;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Location = new System.Drawing.Point(796, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 56);
            this.panel3.TabIndex = 106;
            this.toolTip1.SetToolTip(this.panel3, "RIGHT CLICK HERE!");
            this.panel3.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            // 
            // contextmenu_poti
            // 
            this.contextmenu_poti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextmenu_poti.Name = "cm_display";
            this.contextmenu_poti.Size = new System.Drawing.Size(163, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbts_potishort});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItem1.Text = "Poti switch short";
            // 
            // cbts_potishort
            // 
            this.cbts_potishort.Items.AddRange(new object[] {
            "ACTION_NONE",
            "ACTION_SET_SOFT_POTI",
            "ACTION_SHUTDOWN_SYSTEM",
            "ACTION_ENABLE_BACKLIGHT_LONG",
            "ACTION_TOGGLE_BLUETOOTH",
            "ACTION_ENTER_MENU",
            "ACTION_PROFILE_1",
            "ACTION_PROFILE_2",
            "ACTION_PROFILE",
            "ACTION_TOGGLE_LIGHTS",
            "ACTION_INCREASE_POTI",
            "ACTION_DECREASE_POTI"});
            this.cbts_potishort.Name = "cbts_potishort";
            this.cbts_potishort.Size = new System.Drawing.Size(150, 23);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbts_potilong});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItem2.Text = "Poti switch long";
            // 
            // cbts_potilong
            // 
            this.cbts_potilong.Items.AddRange(new object[] {
            "ACTION_NONE",
            "ACTION_SET_SOFT_POTI",
            "ACTION_SHUTDOWN_SYSTEM",
            "ACTION_ENABLE_BACKLIGHT_LONG",
            "ACTION_TOGGLE_BLUETOOTH",
            "ACTION_ENTER_MENU",
            "ACTION_PROFILE_1",
            "ACTION_PROFILE_2",
            "ACTION_PROFILE",
            "ACTION_TOGGLE_LIGHTS",
            "ACTION_INCREASE_POTI",
            "ACTION_DECREASE_POTI"});
            this.cbts_potilong.Name = "cbts_potilong";
            this.cbts_potilong.Size = new System.Drawing.Size(150, 23);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel9.Location = new System.Drawing.Point(94, 8);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(80, 54);
            this.panel9.TabIndex = 105;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel14.ContextMenuStrip = this.contextmenu_throttle;
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Location = new System.Drawing.Point(873, 199);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(63, 71);
            this.panel14.TabIndex = 107;
            this.toolTip1.SetToolTip(this.panel14, "RIGHT CLICK HERE!");
            this.panel14.MouseEnter += new System.EventHandler(this.panel14_MouseEnter);
            this.panel14.MouseLeave += new System.EventHandler(this.panel14_MouseLeave);
            // 
            // contextmenu_throttle
            // 
            this.contextmenu_throttle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.contextmenu_throttle.Name = "cm_display";
            this.contextmenu_throttle.Size = new System.Drawing.Size(183, 48);
            this.contextmenu_throttle.Opening += new System.ComponentModel.CancelEventHandler(this.contextmenu_throttle_Opening);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbts_throttleshort});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem3.Text = "Throttle switch short";
            // 
            // cbts_throttleshort
            // 
            this.cbts_throttleshort.Items.AddRange(new object[] {
            "ACTION_NONE",
            "ACTION_SET_SOFT_POTI",
            "ACTION_SHUTDOWN_SYSTEM",
            "ACTION_ENABLE_BACKLIGHT_LONG",
            "ACTION_TOGGLE_BLUETOOTH",
            "ACTION_ENTER_MENU",
            "ACTION_PROFILE_1",
            "ACTION_PROFILE_2",
            "ACTION_PROFILE",
            "ACTION_TOGGLE_LIGHTS",
            "ACTION_INCREASE_POTI",
            "ACTION_DECREASE_POTI"});
            this.cbts_throttleshort.Name = "cbts_throttleshort";
            this.cbts_throttleshort.Size = new System.Drawing.Size(150, 23);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbts_throttlelong});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItem4.Text = "Throttle switch long";
            // 
            // cbts_throttlelong
            // 
            this.cbts_throttlelong.Items.AddRange(new object[] {
            "ACTION_NONE",
            "ACTION_SET_SOFT_POTI",
            "ACTION_SHUTDOWN_SYSTEM",
            "ACTION_ENABLE_BACKLIGHT_LONG",
            "ACTION_TOGGLE_BLUETOOTH",
            "ACTION_ENTER_MENU",
            "ACTION_PROFILE_1",
            "ACTION_PROFILE_2",
            "ACTION_PROFILE",
            "ACTION_TOGGLE_LIGHTS",
            "ACTION_INCREASE_POTI",
            "ACTION_DECREASE_POTI"});
            this.cbts_throttlelong.Name = "cbts_throttlelong";
            this.cbts_throttlelong.Size = new System.Drawing.Size(150, 23);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel15.Location = new System.Drawing.Point(94, 8);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(80, 54);
            this.panel15.TabIndex = 105;
            // 
            // chb_motorservo
            // 
            this.chb_motorservo.AutoSize = true;
            this.chb_motorservo.Location = new System.Drawing.Point(82, 19);
            this.chb_motorservo.Name = "chb_motorservo";
            this.chb_motorservo.Size = new System.Drawing.Size(70, 17);
            this.chb_motorservo.TabIndex = 124;
            this.chb_motorservo.Text = "RC servo";
            this.toolTip1.SetToolTip(this.chb_motorservo, "Check this if you have an RC motor controller connected to the motor output and n" +
        "eed a  PWM signal at the output");
            this.chb_motorservo.UseVisualStyleBackColor = true;
            this.chb_motorservo.CheckedChanged += new System.EventHandler(this.chb_motorservo_CheckedChanged);
            // 
            // chb_switchonpoti
            // 
            this.chb_switchonpoti.AutoSize = true;
            this.chb_switchonpoti.Location = new System.Drawing.Point(7, 84);
            this.chb_switchonpoti.Name = "chb_switchonpoti";
            this.chb_switchonpoti.Size = new System.Drawing.Size(101, 17);
            this.chb_switchonpoti.TabIndex = 119;
            this.chb_switchonpoti.Text = "switch@poti-pin";
            this.toolTip1.SetToolTip(this.chb_switchonpoti, "Check if you have connected a switch to the poti pin. Remember to install a pullu" +
        "p resistor for hardware revisions lower than 2.0");
            this.chb_switchonpoti.UseVisualStyleBackColor = true;
            this.chb_switchonpoti.Visible = false;
            // 
            // chb_autocruise
            // 
            this.chb_autocruise.AutoSize = true;
            this.chb_autocruise.Location = new System.Drawing.Point(12, 61);
            this.chb_autocruise.Name = "chb_autocruise";
            this.chb_autocruise.Size = new System.Drawing.Size(78, 17);
            this.chb_autocruise.TabIndex = 119;
            this.chb_autocruise.Text = "auto cruise";
            this.toolTip1.SetToolTip(this.chb_autocruise, "Check if you want to automatically set poti value by holding the thumb throttle i" +
        "n a fixed position for a while");
            this.chb_autocruise.UseVisualStyleBackColor = true;
            this.chb_autocruise.Visible = false;
            // 
            // nud_magnetcount
            // 
            this.nud_magnetcount.Location = new System.Drawing.Point(6, 60);
            this.nud_magnetcount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_magnetcount.Name = "nud_magnetcount";
            this.nud_magnetcount.Size = new System.Drawing.Size(39, 20);
            this.nud_magnetcount.TabIndex = 4;
            this.toolTip1.SetToolTip(this.nud_magnetcount, "type in your magnet count here");
            this.nud_magnetcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chb_brokensensor
            // 
            this.chb_brokensensor.AutoSize = true;
            this.chb_brokensensor.Location = new System.Drawing.Point(6, 86);
            this.chb_brokensensor.Name = "chb_brokensensor";
            this.chb_brokensensor.Size = new System.Drawing.Size(126, 17);
            this.chb_brokensensor.TabIndex = 115;
            this.chb_brokensensor.Text = "detect broken sensor";
            this.toolTip1.SetToolTip(this.chb_brokensensor, "Check if you want to automatically detect speed sensor malfunction and disable th" +
        "e motor");
            this.chb_brokensensor.UseVisualStyleBackColor = true;
            // 
            // nud_pastimeout
            // 
            this.nud_pastimeout.Location = new System.Drawing.Point(98, 122);
            this.nud_pastimeout.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_pastimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_pastimeout.Name = "nud_pastimeout";
            this.nud_pastimeout.Size = new System.Drawing.Size(49, 20);
            this.nud_pastimeout.TabIndex = 14;
            this.toolTip1.SetToolTip(this.nud_pastimeout, "Time in ms after which pedaling is set to false, if no valid PAS pulses are detec" +
        "ted. Smaller values make PAS more responsive but less error tolerant.");
            this.nud_pastimeout.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_pastimeout.Visible = false;
            // 
            // chb_DS1820
            // 
            this.chb_DS1820.AutoSize = true;
            this.chb_DS1820.Location = new System.Drawing.Point(6, 90);
            this.chb_DS1820.Name = "chb_DS1820";
            this.chb_DS1820.Size = new System.Drawing.Size(156, 17);
            this.chb_DS1820.TabIndex = 26;
            this.chb_DS1820.Text = "DS1820 temperature on pin";
            this.toolTip1.SetToolTip(this.chb_DS1820, "Check if you have DS1820 temperature sensors connected");
            this.chb_DS1820.UseVisualStyleBackColor = true;
            // 
            // txb_tempsensepin
            // 
            this.txb_tempsensepin.Location = new System.Drawing.Point(160, 88);
            this.txb_tempsensepin.Name = "txb_tempsensepin";
            this.txb_tempsensepin.Size = new System.Drawing.Size(24, 20);
            this.txb_tempsensepin.TabIndex = 106;
            this.txb_tempsensepin.Text = "A2";
            this.toolTip1.SetToolTip(this.txb_tempsensepin, "Enter Pin number where DS1820 sensors are connected");
            // 
            // chb_external_voltage
            // 
            this.chb_external_voltage.AutoSize = true;
            this.chb_external_voltage.Location = new System.Drawing.Point(1079, 50);
            this.chb_external_voltage.Name = "chb_external_voltage";
            this.chb_external_voltage.Size = new System.Drawing.Size(95, 17);
            this.chb_external_voltage.TabIndex = 120;
            this.chb_external_voltage.Text = "external @ Pin";
            this.toolTip1.SetToolTip(this.chb_external_voltage, "Check if you have an external voltage sensor");
            this.chb_external_voltage.UseVisualStyleBackColor = true;
            this.chb_external_voltage.CheckedChanged += new System.EventHandler(this.chb_external_voltage_CheckedChanged);
            // 
            // txb_external_voltage
            // 
            this.txb_external_voltage.Enabled = false;
            this.txb_external_voltage.Location = new System.Drawing.Point(1172, 48);
            this.txb_external_voltage.Name = "txb_external_voltage";
            this.txb_external_voltage.Size = new System.Drawing.Size(24, 20);
            this.txb_external_voltage.TabIndex = 121;
            this.txb_external_voltage.Text = "A7";
            this.toolTip1.SetToolTip(this.txb_external_voltage, "Enter pin number where external voltage sensor is connected");
            // 
            // txb_external_current
            // 
            this.txb_external_current.Enabled = false;
            this.txb_external_current.Location = new System.Drawing.Point(1172, 131);
            this.txb_external_current.Name = "txb_external_current";
            this.txb_external_current.Size = new System.Drawing.Size(24, 20);
            this.txb_external_current.TabIndex = 123;
            this.txb_external_current.Text = "A6";
            this.toolTip1.SetToolTip(this.txb_external_current, "Enter pin number where external current sensor is connected");
            // 
            // chb_external_current
            // 
            this.chb_external_current.AutoSize = true;
            this.chb_external_current.Location = new System.Drawing.Point(1079, 133);
            this.chb_external_current.Name = "chb_external_current";
            this.chb_external_current.Size = new System.Drawing.Size(95, 17);
            this.chb_external_current.TabIndex = 122;
            this.chb_external_current.Text = "external @ Pin";
            this.toolTip1.SetToolTip(this.chb_external_current, "Check if you have an external current sensor");
            this.chb_external_current.UseVisualStyleBackColor = true;
            this.chb_external_current.CheckedChanged += new System.EventHandler(this.chb_external_current_CheckedChanged);
            // 
            // nud_external_voltage_amplitude
            // 
            this.nud_external_voltage_amplitude.DecimalPlaces = 4;
            this.nud_external_voltage_amplitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nud_external_voltage_amplitude.Location = new System.Drawing.Point(1139, 93);
            this.nud_external_voltage_amplitude.Name = "nud_external_voltage_amplitude";
            this.nud_external_voltage_amplitude.Size = new System.Drawing.Size(57, 20);
            this.nud_external_voltage_amplitude.TabIndex = 125;
            this.toolTip1.SetToolTip(this.nud_external_voltage_amplitude, "Conversion factor for voltage sensor. Usually not changed.");
            this.nud_external_voltage_amplitude.Value = new decimal(new int[] {
            587,
            0,
            0,
            262144});
            this.nud_external_voltage_amplitude.Visible = false;
            // 
            // nud_external_voltage_offset
            // 
            this.nud_external_voltage_offset.DecimalPlaces = 2;
            this.nud_external_voltage_offset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_external_voltage_offset.Location = new System.Drawing.Point(1139, 71);
            this.nud_external_voltage_offset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nud_external_voltage_offset.Name = "nud_external_voltage_offset";
            this.nud_external_voltage_offset.Size = new System.Drawing.Size(57, 20);
            this.nud_external_voltage_offset.TabIndex = 124;
            this.toolTip1.SetToolTip(this.nud_external_voltage_offset, "Offset for voltage sensor.");
            this.nud_external_voltage_offset.Visible = false;
            // 
            // nud_external_current_amplitude
            // 
            this.nud_external_current_amplitude.DecimalPlaces = 4;
            this.nud_external_current_amplitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nud_external_current_amplitude.Location = new System.Drawing.Point(1139, 182);
            this.nud_external_current_amplitude.Name = "nud_external_current_amplitude";
            this.nud_external_current_amplitude.Size = new System.Drawing.Size(57, 20);
            this.nud_external_current_amplitude.TabIndex = 127;
            this.toolTip1.SetToolTip(this.nud_external_current_amplitude, "Conversion factor for current sensor. Usually not changed.");
            this.nud_external_current_amplitude.Value = new decimal(new int[] {
            489,
            0,
            0,
            262144});
            this.nud_external_current_amplitude.Visible = false;
            // 
            // nud_external_current_offset
            // 
            this.nud_external_current_offset.DecimalPlaces = 2;
            this.nud_external_current_offset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_external_current_offset.Location = new System.Drawing.Point(1139, 160);
            this.nud_external_current_offset.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nud_external_current_offset.Name = "nud_external_current_offset";
            this.nud_external_current_offset.Size = new System.Drawing.Size(57, 20);
            this.nud_external_current_offset.TabIndex = 126;
            this.toolTip1.SetToolTip(this.nud_external_current_offset, "Offset for current sensor");
            this.nud_external_current_offset.Visible = false;
            // 
            // chb_resetintegral
            // 
            this.chb_resetintegral.AutoSize = true;
            this.chb_resetintegral.Location = new System.Drawing.Point(3, 191);
            this.chb_resetintegral.Name = "chb_resetintegral";
            this.chb_resetintegral.Size = new System.Drawing.Size(141, 17);
            this.chb_resetintegral.TabIndex = 125;
            this.chb_resetintegral.Text = "reset PID on brake/PAS";
            this.toolTip1.SetToolTip(this.chb_resetintegral, resources.GetString("chb_resetintegral.ToolTip"));
            this.chb_resetintegral.UseVisualStyleBackColor = true;
            // 
            // nud_fixedsoftpoti
            // 
            this.nud_fixedsoftpoti.Location = new System.Drawing.Point(75, 193);
            this.nud_fixedsoftpoti.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_fixedsoftpoti.Name = "nud_fixedsoftpoti";
            this.nud_fixedsoftpoti.Size = new System.Drawing.Size(63, 20);
            this.nud_fixedsoftpoti.TabIndex = 121;
            this.toolTip1.SetToolTip(this.nud_fixedsoftpoti, "Fixed number of watts for the soft poti when ACTION_SET_FIXED_POTI_VALUE is trigg" +
        "ered");
            this.nud_fixedsoftpoti.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // nud_gearchangepause
            // 
            this.nud_gearchangepause.Location = new System.Drawing.Point(117, 38);
            this.nud_gearchangepause.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_gearchangepause.Name = "nud_gearchangepause";
            this.nud_gearchangepause.Size = new System.Drawing.Size(47, 20);
            this.nud_gearchangepause.TabIndex = 17;
            this.toolTip1.SetToolTip(this.nud_gearchangepause, "Time that the motor is kept powerless after pedaling backwards to allow for gear " +
        "changes");
            this.nud_gearchangepause.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_gearchangepause.Visible = false;
            // 
            // chb_torque_throttle
            // 
            this.chb_torque_throttle.AutoSize = true;
            this.chb_torque_throttle.Location = new System.Drawing.Point(26, 38);
            this.chb_torque_throttle.Name = "chb_torque_throttle";
            this.chb_torque_throttle.Size = new System.Drawing.Size(126, 17);
            this.chb_torque_throttle.TabIndex = 19;
            this.chb_torque_throttle.Text = "enable torque throttle";
            this.toolTip1.SetToolTip(this.chb_torque_throttle, "enable this to make pedal force act like thumb throttle");
            this.chb_torque_throttle.UseVisualStyleBackColor = true;
            this.chb_torque_throttle.Visible = false;
            // 
            // nud_torquethrottle_min
            // 
            this.nud_torquethrottle_min.Location = new System.Drawing.Point(11, 56);
            this.nud_torquethrottle_min.Name = "nud_torquethrottle_min";
            this.nud_torquethrottle_min.Size = new System.Drawing.Size(42, 20);
            this.nud_torquethrottle_min.TabIndex = 20;
            this.toolTip1.SetToolTip(this.nud_torquethrottle_min, "this is the threshold torque before pedal force triggers motor");
            this.nud_torquethrottle_min.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_torquethrottle_min.Visible = false;
            // 
            // nud_torquethrottle_full
            // 
            this.nud_torquethrottle_full.Location = new System.Drawing.Point(11, 78);
            this.nud_torquethrottle_full.Name = "nud_torquethrottle_full";
            this.nud_torquethrottle_full.Size = new System.Drawing.Size(42, 20);
            this.nud_torquethrottle_full.TabIndex = 128;
            this.toolTip1.SetToolTip(this.nud_torquethrottle_full, "this is the torque giving you full power at the motor");
            this.nud_torquethrottle_full.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_torquethrottle_full.Visible = false;
            // 
            // txb_thermistorpin
            // 
            this.txb_thermistorpin.Location = new System.Drawing.Point(112, 114);
            this.txb_thermistorpin.Name = "txb_thermistorpin";
            this.txb_thermistorpin.Size = new System.Drawing.Size(24, 20);
            this.txb_thermistorpin.TabIndex = 107;
            this.txb_thermistorpin.Text = "A2";
            this.toolTip1.SetToolTip(this.txb_thermistorpin, "Enter pin number where thermistor is connected to");
            // 
            // chb_thermistor
            // 
            this.chb_thermistor.AutoSize = true;
            this.chb_thermistor.Location = new System.Drawing.Point(6, 116);
            this.chb_thermistor.Name = "chb_thermistor";
            this.chb_thermistor.Size = new System.Drawing.Size(107, 17);
            this.chb_thermistor.TabIndex = 108;
            this.chb_thermistor.Text = "Thermistor on pin";
            this.toolTip1.SetToolTip(this.chb_thermistor, "Check if you have a thermistor connected");
            this.chb_thermistor.UseVisualStyleBackColor = true;
            // 
            // nud_therm_t0
            // 
            this.nud_therm_t0.DecimalPlaces = 2;
            this.nud_therm_t0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_therm_t0.Location = new System.Drawing.Point(112, 135);
            this.nud_therm_t0.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_therm_t0.Name = "nud_therm_t0";
            this.nud_therm_t0.Size = new System.Drawing.Size(58, 20);
            this.nud_therm_t0.TabIndex = 109;
            this.toolTip1.SetToolTip(this.nud_therm_t0, "Thermistor reference temperature in K");
            this.nud_therm_t0.Value = new decimal(new int[] {
            29815,
            0,
            0,
            131072});
            // 
            // nud_therm_beta
            // 
            this.nud_therm_beta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_therm_beta.Location = new System.Drawing.Point(112, 157);
            this.nud_therm_beta.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_therm_beta.Name = "nud_therm_beta";
            this.nud_therm_beta.Size = new System.Drawing.Size(58, 20);
            this.nud_therm_beta.TabIndex = 111;
            this.toolTip1.SetToolTip(this.nud_therm_beta, "Thermistor beta in K");
            this.nud_therm_beta.Value = new decimal(new int[] {
            3950,
            0,
            0,
            0});
            // 
            // nud_therm_r
            // 
            this.nud_therm_r.DecimalPlaces = 2;
            this.nud_therm_r.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_therm_r.Location = new System.Drawing.Point(112, 179);
            this.nud_therm_r.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_therm_r.Name = "nud_therm_r";
            this.nud_therm_r.Size = new System.Drawing.Size(58, 20);
            this.nud_therm_r.TabIndex = 113;
            this.toolTip1.SetToolTip(this.nud_therm_r, "Thermistor resistance in kOhm");
            this.nud_therm_r.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nud_torque_zero
            // 
            this.nud_torque_zero.Location = new System.Drawing.Point(11, 99);
            this.nud_torque_zero.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
            this.nud_torque_zero.Name = "nud_torque_zero";
            this.nud_torque_zero.Size = new System.Drawing.Size(42, 20);
            this.nud_torque_zero.TabIndex = 131;
            this.toolTip1.SetToolTip(this.nud_torque_zero, "Zero torque value. Is theoretically 512. If Auto is checked, this value will be d" +
        "etermined at startup.");
            this.nud_torque_zero.Value = new decimal(new int[] {
            533,
            0,
            0,
            0});
            this.nud_torque_zero.Visible = false;
            this.nud_torque_zero.ValueChanged += new System.EventHandler(this.nud_torque_zero_ValueChanged);
            // 
            // chb_torquezero_auto
            // 
            this.chb_torquezero_auto.AutoSize = true;
            this.chb_torquezero_auto.Checked = true;
            this.chb_torquezero_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_torquezero_auto.Location = new System.Drawing.Point(129, 100);
            this.chb_torquezero_auto.Name = "chb_torquezero_auto";
            this.chb_torquezero_auto.Size = new System.Drawing.Size(48, 17);
            this.chb_torquezero_auto.TabIndex = 133;
            this.chb_torquezero_auto.Text = "Auto";
            this.toolTip1.SetToolTip(this.chb_torquezero_auto, "Check to automatically determine offset at startup. Do not put load on pedal when" +
        " switching on.");
            this.chb_torquezero_auto.UseVisualStyleBackColor = true;
            this.chb_torquezero_auto.Visible = false;
            this.chb_torquezero_auto.CheckedChanged += new System.EventHandler(this.chb_torquezero_auto_CheckedChanged);
            // 
            // chb_thermistor_cutoff
            // 
            this.chb_thermistor_cutoff.AutoSize = true;
            this.chb_thermistor_cutoff.Location = new System.Drawing.Point(6, 202);
            this.chb_thermistor_cutoff.Name = "chb_thermistor_cutoff";
            this.chb_thermistor_cutoff.Size = new System.Drawing.Size(162, 17);
            this.chb_thermistor_cutoff.TabIndex = 115;
            this.chb_thermistor_cutoff.Text = "Motor temperature protection";
            this.toolTip1.SetToolTip(this.chb_thermistor_cutoff, "Check if you want to temperature-protect the motor using a temperature power-cuto" +
        "ff");
            this.chb_thermistor_cutoff.UseVisualStyleBackColor = true;
            this.chb_thermistor_cutoff.CheckedChanged += new System.EventHandler(this.chb_thermistor_cutoff_CheckedChanged);
            // 
            // nud_temperature_cutoff_stop
            // 
            this.nud_temperature_cutoff_stop.Location = new System.Drawing.Point(99, 220);
            this.nud_temperature_cutoff_stop.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nud_temperature_cutoff_stop.Name = "nud_temperature_cutoff_stop";
            this.nud_temperature_cutoff_stop.Size = new System.Drawing.Size(46, 20);
            this.nud_temperature_cutoff_stop.TabIndex = 117;
            this.toolTip1.SetToolTip(this.nud_temperature_cutoff_stop, "Temperature cutoff stop in °C. Above this temperature no power is available");
            this.nud_temperature_cutoff_stop.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // nud_temperature_cutoff_start
            // 
            this.nud_temperature_cutoff_start.Location = new System.Drawing.Point(35, 220);
            this.nud_temperature_cutoff_start.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nud_temperature_cutoff_start.Name = "nud_temperature_cutoff_start";
            this.nud_temperature_cutoff_start.Size = new System.Drawing.Size(46, 20);
            this.nud_temperature_cutoff_start.TabIndex = 116;
            this.toolTip1.SetToolTip(this.nud_temperature_cutoff_start, "Temperature cutoff start in °C. Up to this temperature the full power is availabl" +
        "e");
            this.nud_temperature_cutoff_start.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "display";
            // 
            // panel_brake
            // 
            this.panel_brake.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_brake.Controls.Add(this.label9);
            this.panel_brake.Controls.Add(this.chb_brakeinverted);
            this.panel_brake.Controls.Add(this.chb_brake);
            this.panel_brake.Location = new System.Drawing.Point(562, 90);
            this.panel_brake.Name = "panel_brake";
            this.panel_brake.Size = new System.Drawing.Size(92, 103);
            this.panel_brake.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "brake";
            // 
            // panel_display
            // 
            this.panel_display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_display.ContextMenuStrip = this.contextmenu_display;
            this.panel_display.Controls.Add(this.label23);
            this.panel_display.Controls.Add(this.nud_display_contrast);
            this.panel_display.Controls.Add(this.chb_backlight);
            this.panel_display.Controls.Add(this.label8);
            this.panel_display.Controls.Add(this.cb_display);
            this.panel_display.Location = new System.Drawing.Point(655, 90);
            this.panel_display.Name = "panel_display";
            this.panel_display.Size = new System.Drawing.Size(117, 103);
            this.panel_display.TabIndex = 18;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(53, 63);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 13);
            this.label23.TabIndex = 23;
            this.label23.Text = "contrast";
            // 
            // panel_controls
            // 
            this.panel_controls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_controls.ContextMenuStrip = this.contextmenu_poti;
            this.panel_controls.Controls.Add(this.chb_switchonpoti);
            this.panel_controls.Controls.Add(this.lbl_startup_unit);
            this.panel_controls.Controls.Add(this.lbl_poti_startup);
            this.panel_controls.Controls.Add(this.nud_poti_startup);
            this.panel_controls.Controls.Add(this.lbl_stepsize_unit);
            this.panel_controls.Controls.Add(this.lbl_stepsize);
            this.panel_controls.Controls.Add(this.nud_stepsize);
            this.panel_controls.Controls.Add(this.lbl_poti_max);
            this.panel_controls.Controls.Add(this.lbl_poti_min);
            this.panel_controls.Controls.Add(this.nud_poti_max);
            this.panel_controls.Controls.Add(this.nud_poti_min);
            this.panel_controls.Controls.Add(this.cb_controls);
            this.panel_controls.Controls.Add(this.label10);
            this.panel_controls.Location = new System.Drawing.Point(774, 90);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.Size = new System.Drawing.Size(106, 103);
            this.panel_controls.TabIndex = 19;
            // 
            // lbl_startup_unit
            // 
            this.lbl_startup_unit.AutoSize = true;
            this.lbl_startup_unit.Location = new System.Drawing.Point(77, 48);
            this.lbl_startup_unit.Name = "lbl_startup_unit";
            this.lbl_startup_unit.Size = new System.Drawing.Size(18, 13);
            this.lbl_startup_unit.TabIndex = 28;
            this.lbl_startup_unit.Text = "W";
            this.lbl_startup_unit.Visible = false;
            // 
            // lbl_poti_startup
            // 
            this.lbl_poti_startup.AutoSize = true;
            this.lbl_poti_startup.Location = new System.Drawing.Point(-1, 48);
            this.lbl_poti_startup.Name = "lbl_poti_startup";
            this.lbl_poti_startup.Size = new System.Drawing.Size(39, 13);
            this.lbl_poti_startup.TabIndex = 27;
            this.lbl_poti_startup.Text = "startup";
            this.lbl_poti_startup.Visible = false;
            // 
            // lbl_stepsize_unit
            // 
            this.lbl_stepsize_unit.AutoSize = true;
            this.lbl_stepsize_unit.Location = new System.Drawing.Point(78, 71);
            this.lbl_stepsize_unit.Name = "lbl_stepsize_unit";
            this.lbl_stepsize_unit.Size = new System.Drawing.Size(18, 13);
            this.lbl_stepsize_unit.TabIndex = 25;
            this.lbl_stepsize_unit.Text = "W";
            this.lbl_stepsize_unit.Visible = false;
            // 
            // lbl_stepsize
            // 
            this.lbl_stepsize.AutoSize = true;
            this.lbl_stepsize.Location = new System.Drawing.Point(0, 68);
            this.lbl_stepsize.Name = "lbl_stepsize";
            this.lbl_stepsize.Size = new System.Drawing.Size(27, 13);
            this.lbl_stepsize.TabIndex = 24;
            this.lbl_stepsize.Text = "step";
            this.lbl_stepsize.Visible = false;
            // 
            // lbl_poti_max
            // 
            this.lbl_poti_max.AutoSize = true;
            this.lbl_poti_max.Location = new System.Drawing.Point(57, 62);
            this.lbl_poti_max.Name = "lbl_poti_max";
            this.lbl_poti_max.Size = new System.Drawing.Size(26, 13);
            this.lbl_poti_max.TabIndex = 22;
            this.lbl_poti_max.Text = "max";
            this.lbl_poti_max.Visible = false;
            // 
            // lbl_poti_min
            // 
            this.lbl_poti_min.AutoSize = true;
            this.lbl_poti_min.Location = new System.Drawing.Point(57, 42);
            this.lbl_poti_min.Name = "lbl_poti_min";
            this.lbl_poti_min.Size = new System.Drawing.Size(23, 13);
            this.lbl_poti_min.TabIndex = 21;
            this.lbl_poti_min.Text = "min";
            this.lbl_poti_min.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "controls";
            // 
            // panel_throttle
            // 
            this.panel_throttle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_throttle.ContextMenuStrip = this.contextmenu_throttle;
            this.panel_throttle.Controls.Add(this.nud_fixed_throttle);
            this.panel_throttle.Controls.Add(this.chb_autocruise);
            this.panel_throttle.Controls.Add(this.label11);
            this.panel_throttle.Controls.Add(this.lbl_fixed_throttle_unit);
            this.panel_throttle.Controls.Add(this.lbl_thr_max);
            this.panel_throttle.Controls.Add(this.chb_throttle);
            this.panel_throttle.Controls.Add(this.lbl_thr_min);
            this.panel_throttle.Controls.Add(this.label12);
            this.panel_throttle.Controls.Add(this.nud_throttle_max);
            this.panel_throttle.Controls.Add(this.nud_throttle_min);
            this.panel_throttle.Location = new System.Drawing.Point(881, 90);
            this.panel_throttle.Name = "panel_throttle";
            this.panel_throttle.Size = new System.Drawing.Size(105, 103);
            this.panel_throttle.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-2, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "button";
            // 
            // lbl_fixed_throttle_unit
            // 
            this.lbl_fixed_throttle_unit.AutoSize = true;
            this.lbl_fixed_throttle_unit.Location = new System.Drawing.Point(87, 82);
            this.lbl_fixed_throttle_unit.Name = "lbl_fixed_throttle_unit";
            this.lbl_fixed_throttle_unit.Size = new System.Drawing.Size(18, 13);
            this.lbl_fixed_throttle_unit.TabIndex = 28;
            this.lbl_fixed_throttle_unit.Text = "W";
            // 
            // lbl_thr_max
            // 
            this.lbl_thr_max.AutoSize = true;
            this.lbl_thr_max.Location = new System.Drawing.Point(59, 48);
            this.lbl_thr_max.Name = "lbl_thr_max";
            this.lbl_thr_max.Size = new System.Drawing.Size(26, 13);
            this.lbl_thr_max.TabIndex = 26;
            this.lbl_thr_max.Text = "max";
            this.lbl_thr_max.Visible = false;
            // 
            // chb_throttle
            // 
            this.chb_throttle.AutoSize = true;
            this.chb_throttle.Location = new System.Drawing.Point(12, 11);
            this.chb_throttle.Name = "chb_throttle";
            this.chb_throttle.Size = new System.Drawing.Size(71, 17);
            this.chb_throttle.TabIndex = 20;
            this.chb_throttle.Text = "have one";
            this.chb_throttle.UseVisualStyleBackColor = true;
            this.chb_throttle.CheckedChanged += new System.EventHandler(this.chb_throttle_CheckedChanged);
            // 
            // lbl_thr_min
            // 
            this.lbl_thr_min.AutoSize = true;
            this.lbl_thr_min.Location = new System.Drawing.Point(6, 48);
            this.lbl_thr_min.Name = "lbl_thr_min";
            this.lbl_thr_min.Size = new System.Drawing.Size(23, 13);
            this.lbl_thr_min.TabIndex = 25;
            this.lbl_thr_min.Text = "min";
            this.lbl_thr_min.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "thumb throttle";
            // 
            // powergraph
            // 
            this.powergraph.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.Title = "speed / km/h";
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.Title = "power / W";
            chartArea1.Name = "ChartArea1";
            this.powergraph.ChartAreas.Add(chartArea1);
            this.powergraph.Location = new System.Drawing.Point(-1, 190);
            this.powergraph.Name = "powergraph";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Name = "Series2";
            this.powergraph.Series.Add(series1);
            this.powergraph.Series.Add(series2);
            this.powergraph.Size = new System.Drawing.Size(336, 184);
            this.powergraph.TabIndex = 21;
            this.powergraph.Text = "chart1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "maximum power W";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "thermal limit W";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "thermal safe speed km/h";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(203, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "starting aid km/h";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(188, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "speed cutoff km/h";
            // 
            // panel_bottombracket
            // 
            this.panel_bottombracket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_bottombracket.Controls.Add(this.chb_torquezero_auto);
            this.panel_bottombracket.Controls.Add(this.lbl_torque_zero);
            this.panel_bottombracket.Controls.Add(this.nud_torque_zero);
            this.panel_bottombracket.Controls.Add(this.lbl_torquethrottlemax);
            this.panel_bottombracket.Controls.Add(this.lbl_torquethrottlemin);
            this.panel_bottombracket.Controls.Add(this.nud_torquethrottle_full);
            this.panel_bottombracket.Controls.Add(this.nud_torquethrottle_min);
            this.panel_bottombracket.Controls.Add(this.chb_torque_throttle);
            this.panel_bottombracket.Controls.Add(this.lbl_gearchange);
            this.panel_bottombracket.Controls.Add(this.nud_gearchangepause);
            this.panel_bottombracket.Controls.Add(this.lbl_pastimeoutms);
            this.panel_bottombracket.Controls.Add(this.lbl_pastimeout);
            this.panel_bottombracket.Controls.Add(this.nud_pastimeout);
            this.panel_bottombracket.Controls.Add(this.lbl_pastol);
            this.panel_bottombracket.Controls.Add(this.nud_pas_tolerance);
            this.panel_bottombracket.Controls.Add(this.lbl_pfmax);
            this.panel_bottombracket.Controls.Add(this.lbl_pfmin);
            this.panel_bottombracket.Controls.Add(this.lbl_pf);
            this.panel_bottombracket.Controls.Add(this.nud_pasfactor_max);
            this.panel_bottombracket.Controls.Add(this.nud_pasfactor_min);
            this.panel_bottombracket.Controls.Add(this.lbl_magnets);
            this.panel_bottombracket.Controls.Add(this.nud_magnets);
            this.panel_bottombracket.Controls.Add(this.label3);
            this.panel_bottombracket.Controls.Add(this.cb_bottombracket);
            this.panel_bottombracket.Location = new System.Drawing.Point(412, 603);
            this.panel_bottombracket.Name = "panel_bottombracket";
            this.panel_bottombracket.Size = new System.Drawing.Size(181, 145);
            this.panel_bottombracket.TabIndex = 36;
            // 
            // lbl_torque_zero
            // 
            this.lbl_torque_zero.AutoSize = true;
            this.lbl_torque_zero.Location = new System.Drawing.Point(59, 101);
            this.lbl_torque_zero.Name = "lbl_torque_zero";
            this.lbl_torque_zero.Size = new System.Drawing.Size(60, 13);
            this.lbl_torque_zero.TabIndex = 132;
            this.lbl_torque_zero.Text = "torque zero";
            this.lbl_torque_zero.Visible = false;
            this.lbl_torque_zero.Click += new System.EventHandler(this.lbl_torque_zero_Click);
            // 
            // lbl_torquethrottlemax
            // 
            this.lbl_torquethrottlemax.AutoSize = true;
            this.lbl_torquethrottlemax.Location = new System.Drawing.Point(59, 80);
            this.lbl_torquethrottlemax.Name = "lbl_torquethrottlemax";
            this.lbl_torquethrottlemax.Size = new System.Drawing.Size(80, 13);
            this.lbl_torquethrottlemax.TabIndex = 130;
            this.lbl_torquethrottlemax.Text = "full torque / Nm";
            this.lbl_torquethrottlemax.Visible = false;
            // 
            // lbl_torquethrottlemin
            // 
            this.lbl_torquethrottlemin.AutoSize = true;
            this.lbl_torquethrottlemin.Location = new System.Drawing.Point(60, 58);
            this.lbl_torquethrottlemin.Name = "lbl_torquethrottlemin";
            this.lbl_torquethrottlemin.Size = new System.Drawing.Size(107, 13);
            this.lbl_torquethrottlemin.TabIndex = 129;
            this.lbl_torquethrottlemin.Text = "minimum torque / Nm";
            this.lbl_torquethrottlemin.Visible = false;
            // 
            // lbl_gearchange
            // 
            this.lbl_gearchange.AutoSize = true;
            this.lbl_gearchange.Location = new System.Drawing.Point(12, 41);
            this.lbl_gearchange.Name = "lbl_gearchange";
            this.lbl_gearchange.Size = new System.Drawing.Size(101, 13);
            this.lbl_gearchange.TabIndex = 18;
            this.lbl_gearchange.Text = "Gear change pause";
            this.lbl_gearchange.Visible = false;
            // 
            // lbl_pastimeoutms
            // 
            this.lbl_pastimeoutms.AutoSize = true;
            this.lbl_pastimeoutms.Location = new System.Drawing.Point(150, 124);
            this.lbl_pastimeoutms.Name = "lbl_pastimeoutms";
            this.lbl_pastimeoutms.Size = new System.Drawing.Size(20, 13);
            this.lbl_pastimeoutms.TabIndex = 16;
            this.lbl_pastimeoutms.Text = "ms";
            this.lbl_pastimeoutms.Visible = false;
            // 
            // lbl_pastimeout
            // 
            this.lbl_pastimeout.AutoSize = true;
            this.lbl_pastimeout.Location = new System.Drawing.Point(21, 124);
            this.lbl_pastimeout.Name = "lbl_pastimeout";
            this.lbl_pastimeout.Size = new System.Drawing.Size(65, 13);
            this.lbl_pastimeout.TabIndex = 15;
            this.lbl_pastimeout.Text = "PAS timeout";
            this.lbl_pastimeout.Visible = false;
            // 
            // lbl_pastol
            // 
            this.lbl_pastol.AutoSize = true;
            this.lbl_pastol.Location = new System.Drawing.Point(21, 100);
            this.lbl_pastol.Name = "lbl_pastol";
            this.lbl_pastol.Size = new System.Drawing.Size(75, 13);
            this.lbl_pastol.TabIndex = 13;
            this.lbl_pastol.Text = "PAS tolerance";
            this.lbl_pastol.Visible = false;
            // 
            // panel_power
            // 
            this.panel_power.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_power.Controls.Add(this.nud_startingaid_2);
            this.panel_power.Controls.Add(this.nud_speedcutoff_stop_2);
            this.panel_power.Controls.Add(this.nud_speedcutoff_start_2);
            this.panel_power.Controls.Add(this.nud_power_max_2);
            this.panel_power.Controls.Add(this.chb_startingaid);
            this.panel_power.Controls.Add(this.label21);
            this.panel_power.Controls.Add(this.nud_startingaid);
            this.panel_power.Controls.Add(this.label20);
            this.panel_power.Controls.Add(this.nud_speedcutoff_start);
            this.panel_power.Controls.Add(this.label19);
            this.panel_power.Controls.Add(this.nud_speedcutoff_stop);
            this.panel_power.Controls.Add(this.label18);
            this.panel_power.Controls.Add(this.nud_thermalsafespeed);
            this.panel_power.Controls.Add(this.label17);
            this.panel_power.Controls.Add(this.nud_power_thermal);
            this.panel_power.Controls.Add(this.label16);
            this.panel_power.Controls.Add(this.nud_power_max);
            this.panel_power.Location = new System.Drawing.Point(12, 90);
            this.panel_power.Name = "panel_power";
            this.panel_power.Size = new System.Drawing.Size(354, 103);
            this.panel_power.TabIndex = 37;
            // 
            // chb_startingaid
            // 
            this.chb_startingaid.AutoSize = true;
            this.chb_startingaid.Checked = true;
            this.chb_startingaid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_startingaid.Location = new System.Drawing.Point(189, 67);
            this.chb_startingaid.Name = "chb_startingaid";
            this.chb_startingaid.Size = new System.Drawing.Size(15, 14);
            this.chb_startingaid.TabIndex = 53;
            this.chb_startingaid.UseVisualStyleBackColor = true;
            this.chb_startingaid.CheckedChanged += new System.EventHandler(this.cb_startingaid_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "power and speed";
            // 
            // panel_speedsensor
            // 
            this.panel_speedsensor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_speedsensor.Controls.Add(this.chb_brokensensor);
            this.panel_speedsensor.Controls.Add(this.label47);
            this.panel_speedsensor.Controls.Add(this.label15);
            this.panel_speedsensor.Controls.Add(this.nud_magnetcount);
            this.panel_speedsensor.Controls.Add(this.label2);
            this.panel_speedsensor.Controls.Add(this.label1);
            this.panel_speedsensor.Controls.Add(this.nud_circumference);
            this.panel_speedsensor.Location = new System.Drawing.Point(20, 476);
            this.panel_speedsensor.Name = "panel_speedsensor";
            this.panel_speedsensor.Size = new System.Drawing.Size(139, 109);
            this.panel_speedsensor.TabIndex = 38;
            this.panel_speedsensor.MouseEnter += new System.EventHandler(this.panel_speedsensor_MouseEnter);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(3, 17);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(105, 13);
            this.label47.TabIndex = 114;
            this.label47.Text = "wheel circumference";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(49, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "magnet count";
            // 
            // cb_profile
            // 
            this.cb_profile.FormattingEnabled = true;
            this.cb_profile.Location = new System.Drawing.Point(57, 30);
            this.cb_profile.Name = "cb_profile";
            this.cb_profile.Size = new System.Drawing.Size(140, 21);
            this.cb_profile.TabIndex = 39;
            this.cb_profile.Text = "new profile";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(9, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 13);
            this.label22.TabIndex = 40;
            this.label22.Text = "profile";
            // 
            // bt_load
            // 
            this.bt_load.Location = new System.Drawing.Point(203, 28);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(36, 23);
            this.bt_load.TabIndex = 41;
            this.bt_load.Text = "load";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.bt_load_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(245, 28);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(43, 23);
            this.bt_save.TabIndex = 42;
            this.bt_save.Text = "save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(294, 28);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(29, 23);
            this.bt_delete.TabIndex = 43;
            this.bt_delete.Text = "x";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(5, 2);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "control mode";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(2, 5);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 13);
            this.label25.TabIndex = 47;
            this.label25.Text = "serial mode";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(55, 41);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(26, 13);
            this.label27.TabIndex = 51;
            this.label27.Text = "max";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(55, 20);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(23, 13);
            this.label28.TabIndex = 50;
            this.label28.Text = "min";
            // 
            // panel_motor
            // 
            this.panel_motor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_motor.Controls.Add(this.chb_resetintegral);
            this.panel_motor.Controls.Add(this.chb_motorservo);
            this.panel_motor.Controls.Add(this.label14);
            this.panel_motor.Controls.Add(this.label13);
            this.panel_motor.Controls.Add(this.txb_highgear);
            this.panel_motor.Controls.Add(this.txb_lowgear);
            this.panel_motor.Controls.Add(this.chb_gearshift);
            this.panel_motor.Controls.Add(this.chb_preguess);
            this.panel_motor.Controls.Add(this.label46);
            this.panel_motor.Controls.Add(this.nud_idlespeed);
            this.panel_motor.Controls.Add(this.label29);
            this.panel_motor.Controls.Add(this.label27);
            this.panel_motor.Controls.Add(this.label28);
            this.panel_motor.Controls.Add(this.nud_motor_max);
            this.panel_motor.Controls.Add(this.nud_motor_min);
            this.panel_motor.Controls.Add(this.nud_pidi_throttle);
            this.panel_motor.Controls.Add(this.label52);
            this.panel_motor.Controls.Add(this.nud_pidp_throttle);
            this.panel_motor.Controls.Add(this.label53);
            this.panel_motor.Controls.Add(this.nud_pidi);
            this.panel_motor.Controls.Add(this.label54);
            this.panel_motor.Controls.Add(this.nud_pidp);
            this.panel_motor.Controls.Add(this.label55);
            this.panel_motor.Location = new System.Drawing.Point(816, 476);
            this.panel_motor.Name = "panel_motor";
            this.panel_motor.Size = new System.Drawing.Size(154, 260);
            this.panel_motor.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(75, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 123;
            this.label14.Text = "high pin";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "low pin";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(54, 62);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(83, 13);
            this.label46.TabIndex = 54;
            this.label46.Text = "idle speed km/h";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(0, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(150, 13);
            this.label29.TabIndex = 52;
            this.label29.Text = "output to motor controller";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(56, 104);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(30, 13);
            this.label52.TabIndex = 0;
            this.label52.Text = "pid p";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(56, 125);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(26, 13);
            this.label53.TabIndex = 1;
            this.label53.Text = "pid i";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(56, 146);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(65, 13);
            this.label54.TabIndex = 2;
            this.label54.Text = "pid p throttle";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(56, 167);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(61, 13);
            this.label55.TabIndex = 3;
            this.label55.Text = "pid i throttle";
            // 
            // panel_controlmode
            // 
            this.panel_controlmode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_controlmode.Controls.Add(this.nud_controlmode_2);
            this.panel_controlmode.Controls.Add(this.lbl_controlmode);
            this.panel_controlmode.Controls.Add(this.nud_controlmode);
            this.panel_controlmode.Controls.Add(this.label24);
            this.panel_controlmode.Controls.Add(this.cb_controlmode);
            this.panel_controlmode.Location = new System.Drawing.Point(368, 90);
            this.panel_controlmode.Name = "panel_controlmode";
            this.panel_controlmode.Size = new System.Drawing.Size(193, 54);
            this.panel_controlmode.TabIndex = 53;
            // 
            // lbl_controlmode
            // 
            this.lbl_controlmode.AutoSize = true;
            this.lbl_controlmode.Location = new System.Drawing.Point(101, 3);
            this.lbl_controlmode.Name = "lbl_controlmode";
            this.lbl_controlmode.Size = new System.Drawing.Size(81, 13);
            this.lbl_controlmode.TabIndex = 49;
            this.lbl_controlmode.Text = "poti: max power";
            this.lbl_controlmode.Click += new System.EventHandler(this.label52_Click);
            // 
            // panel_battery
            // 
            this.panel_battery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_battery.Controls.Add(this.chb_chargecounter);
            this.panel_battery.Controls.Add(this.lbl_chargedetect_min);
            this.panel_battery.Controls.Add(this.nud_chargedetect_min);
            this.panel_battery.Controls.Add(this.chb_chargedetection);
            this.panel_battery.Controls.Add(this.nud_capacity_2);
            this.panel_battery.Controls.Add(this.label42);
            this.panel_battery.Controls.Add(this.nud_vmax);
            this.panel_battery.Controls.Add(this.label33);
            this.panel_battery.Controls.Add(this.nud_vemergency);
            this.panel_battery.Controls.Add(this.label32);
            this.panel_battery.Controls.Add(this.nud_vcutoff);
            this.panel_battery.Controls.Add(this.label31);
            this.panel_battery.Controls.Add(this.nud_capacity);
            this.panel_battery.Controls.Add(this.label30);
            this.panel_battery.Location = new System.Drawing.Point(450, 327);
            this.panel_battery.Name = "panel_battery";
            this.panel_battery.Size = new System.Drawing.Size(173, 151);
            this.panel_battery.TabIndex = 54;
            // 
            // lbl_chargedetect_min
            // 
            this.lbl_chargedetect_min.AutoSize = true;
            this.lbl_chargedetect_min.Location = new System.Drawing.Point(0, 111);
            this.lbl_chargedetect_min.Name = "lbl_chargedetect_min";
            this.lbl_chargedetect_min.Size = new System.Drawing.Size(104, 13);
            this.lbl_chargedetect_min.TabIndex = 115;
            this.lbl_chargedetect_min.Text = "minimum detection V";
            // 
            // nud_capacity_2
            // 
            this.nud_capacity_2.ForeColor = System.Drawing.Color.Red;
            this.nud_capacity_2.Location = new System.Drawing.Point(122, 8);
            this.nud_capacity_2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_capacity_2.Name = "nud_capacity_2";
            this.nud_capacity_2.Size = new System.Drawing.Size(46, 20);
            this.nud_capacity_2.TabIndex = 113;
            this.nud_capacity_2.Value = new decimal(new int[] {
            166,
            0,
            0,
            0});
            this.nud_capacity_2.Visible = false;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(0, 32);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(105, 13);
            this.label42.TabIndex = 62;
            this.label42.Text = "fully charged voltage";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(0, 73);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(118, 13);
            this.label33.TabIndex = 60;
            this.label33.Text = "emergency shutdown V";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(0, 52);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(82, 13);
            this.label32.TabIndex = 58;
            this.label32.Text = "voltage cutoff V";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(0, 12);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 13);
            this.label31.TabIndex = 56;
            this.label31.Text = "capacity wh";
            // 
            // nud_capacity
            // 
            this.nud_capacity.ForeColor = System.Drawing.Color.Blue;
            this.nud_capacity.Location = new System.Drawing.Point(122, 8);
            this.nud_capacity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_capacity.Name = "nud_capacity";
            this.nud_capacity.Size = new System.Drawing.Size(46, 20);
            this.nud_capacity.TabIndex = 55;
            this.nud_capacity.Value = new decimal(new int[] {
            166,
            0,
            0,
            0});
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(60, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(46, 13);
            this.label30.TabIndex = 54;
            this.label30.Text = "battery";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(1060, 30);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(86, 13);
            this.label34.TabIndex = 56;
            this.label34.Text = "live data view";
            // 
            // bwSerial
            // 
            this.bwSerial.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSerial_DoWork);
            this.bwSerial.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSerial_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbVoltage
            // 
            this.tbVoltage.Enabled = false;
            this.tbVoltage.Location = new System.Drawing.Point(1004, 63);
            this.tbVoltage.Maximum = 1023;
            this.tbVoltage.Name = "tbVoltage";
            this.tbVoltage.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVoltage.Size = new System.Drawing.Size(45, 66);
            this.tbVoltage.TabIndex = 59;
            this.tbVoltage.TickFrequency = 100;
            this.tbVoltage.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // desc_voltage
            // 
            this.desc_voltage.AutoSize = true;
            this.desc_voltage.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.desc_voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_voltage.Location = new System.Drawing.Point(1015, 51);
            this.desc_voltage.Name = "desc_voltage";
            this.desc_voltage.Size = new System.Drawing.Size(50, 13);
            this.desc_voltage.TabIndex = 60;
            this.desc_voltage.Text = "Voltage";
            // 
            // desc_current
            // 
            this.desc_current.AutoSize = true;
            this.desc_current.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.desc_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_current.Location = new System.Drawing.Point(1016, 134);
            this.desc_current.Name = "desc_current";
            this.desc_current.Size = new System.Drawing.Size(48, 13);
            this.desc_current.TabIndex = 63;
            this.desc_current.Text = "Current";
            // 
            // tbCurrent
            // 
            this.tbCurrent.Enabled = false;
            this.tbCurrent.Location = new System.Drawing.Point(1004, 150);
            this.tbCurrent.Maximum = 1023;
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbCurrent.Size = new System.Drawing.Size(45, 66);
            this.tbCurrent.TabIndex = 62;
            this.tbCurrent.TickFrequency = 100;
            this.tbCurrent.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(1080, 94);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(52, 13);
            this.label37.TabIndex = 70;
            this.label37.Text = "amplitude";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(1098, 73);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(33, 13);
            this.label39.TabIndex = 69;
            this.label39.Text = "offset";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(1080, 183);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(52, 13);
            this.label40.TabIndex = 74;
            this.label40.Text = "amplitude";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(1098, 162);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(33, 13);
            this.label41.TabIndex = 73;
            this.label41.Text = "offset";
            // 
            // chart_pas
            // 
            this.chart_pas.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.Name = "ChartArea1";
            this.chart_pas.ChartAreas.Add(chartArea2);
            this.chart_pas.Location = new System.Drawing.Point(1004, 230);
            this.chart_pas.Name = "chart_pas";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsVisibleInLegend = false;
            series3.Name = "Series1";
            this.chart_pas.Series.Add(series3);
            this.chart_pas.Size = new System.Drawing.Size(190, 98);
            this.chart_pas.TabIndex = 75;
            this.chart_pas.Text = "chart1";
            this.chart_pas.Click += new System.EventHandler(this.chart_pas_Click);
            // 
            // desc_pas
            // 
            this.desc_pas.AutoSize = true;
            this.desc_pas.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.desc_pas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_pas.Location = new System.Drawing.Point(1015, 217);
            this.desc_pas.Name = "desc_pas";
            this.desc_pas.Size = new System.Drawing.Size(68, 13);
            this.desc_pas.TabIndex = 76;
            this.desc_pas.Text = "PAS factor";
            // 
            // lbl_pas_factor
            // 
            this.lbl_pas_factor.AutoSize = true;
            this.lbl_pas_factor.Location = new System.Drawing.Point(1118, 217);
            this.lbl_pas_factor.Name = "lbl_pas_factor";
            this.lbl_pas_factor.Size = new System.Drawing.Size(13, 13);
            this.lbl_pas_factor.TabIndex = 77;
            this.lbl_pas_factor.Text = "0";
            // 
            // lblPotiMin
            // 
            this.lblPotiMin.AutoSize = true;
            this.lblPotiMin.Location = new System.Drawing.Point(1033, 383);
            this.lblPotiMin.Name = "lblPotiMin";
            this.lblPotiMin.Size = new System.Drawing.Size(31, 13);
            this.lblPotiMin.TabIndex = 85;
            this.lblPotiMin.Text = "1023";
            // 
            // lblPotiMax
            // 
            this.lblPotiMax.AutoSize = true;
            this.lblPotiMax.Location = new System.Drawing.Point(1033, 357);
            this.lblPotiMax.Name = "lblPotiMax";
            this.lblPotiMax.Size = new System.Drawing.Size(13, 13);
            this.lblPotiMax.TabIndex = 84;
            this.lblPotiMax.Text = "0";
            // 
            // lblPotiRaw
            // 
            this.lblPotiRaw.AutoSize = true;
            this.lblPotiRaw.Location = new System.Drawing.Point(1033, 370);
            this.lblPotiRaw.Name = "lblPotiRaw";
            this.lblPotiRaw.Size = new System.Drawing.Size(13, 13);
            this.lblPotiRaw.TabIndex = 80;
            this.lblPotiRaw.Text = "0";
            // 
            // desc_poti
            // 
            this.desc_poti.AutoSize = true;
            this.desc_poti.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.desc_poti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_poti.Location = new System.Drawing.Point(1015, 335);
            this.desc_poti.Name = "desc_poti";
            this.desc_poti.Size = new System.Drawing.Size(29, 13);
            this.desc_poti.TabIndex = 79;
            this.desc_poti.Text = "Poti";
            // 
            // tbPoti
            // 
            this.tbPoti.Enabled = false;
            this.tbPoti.Location = new System.Drawing.Point(1004, 347);
            this.tbPoti.Maximum = 1023;
            this.tbPoti.Name = "tbPoti";
            this.tbPoti.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbPoti.Size = new System.Drawing.Size(45, 66);
            this.tbPoti.TabIndex = 78;
            this.tbPoti.TickFrequency = 100;
            this.tbPoti.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblThrottleMin
            // 
            this.lblThrottleMin.AutoSize = true;
            this.lblThrottleMin.Location = new System.Drawing.Point(1141, 383);
            this.lblThrottleMin.Name = "lblThrottleMin";
            this.lblThrottleMin.Size = new System.Drawing.Size(31, 13);
            this.lblThrottleMin.TabIndex = 90;
            this.lblThrottleMin.Text = "1023";
            // 
            // lblThrottleMax
            // 
            this.lblThrottleMax.AutoSize = true;
            this.lblThrottleMax.Location = new System.Drawing.Point(1141, 357);
            this.lblThrottleMax.Name = "lblThrottleMax";
            this.lblThrottleMax.Size = new System.Drawing.Size(13, 13);
            this.lblThrottleMax.TabIndex = 89;
            this.lblThrottleMax.Text = "0";
            // 
            // lblThrottleRaw
            // 
            this.lblThrottleRaw.AutoSize = true;
            this.lblThrottleRaw.Location = new System.Drawing.Point(1141, 370);
            this.lblThrottleRaw.Name = "lblThrottleRaw";
            this.lblThrottleRaw.Size = new System.Drawing.Size(13, 13);
            this.lblThrottleRaw.TabIndex = 88;
            this.lblThrottleRaw.Text = "0";
            // 
            // desc_throttle
            // 
            this.desc_throttle.AutoSize = true;
            this.desc_throttle.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.desc_throttle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_throttle.Location = new System.Drawing.Point(1123, 335);
            this.desc_throttle.Name = "desc_throttle";
            this.desc_throttle.Size = new System.Drawing.Size(51, 13);
            this.desc_throttle.TabIndex = 87;
            this.desc_throttle.Text = "Throttle";
            // 
            // tbThrottle
            // 
            this.tbThrottle.Enabled = false;
            this.tbThrottle.Location = new System.Drawing.Point(1112, 347);
            this.tbThrottle.Maximum = 1023;
            this.tbThrottle.Name = "tbThrottle";
            this.tbThrottle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbThrottle.Size = new System.Drawing.Size(45, 66);
            this.tbThrottle.TabIndex = 86;
            this.tbThrottle.TickFrequency = 100;
            this.tbThrottle.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(1070, 357);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(26, 13);
            this.label43.TabIndex = 91;
            this.label43.Text = "max";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(1070, 383);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(23, 13);
            this.label44.TabIndex = 92;
            this.label44.Text = "min";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(1173, 383);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(23, 13);
            this.label45.TabIndex = 94;
            this.label45.Text = "min";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(1173, 357);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(26, 13);
            this.label48.TabIndex = 93;
            this.label48.Text = "max";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(1015, 427);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(40, 13);
            this.label49.TabIndex = 95;
            this.label49.Text = "Brake";
            // 
            // rbBrake
            // 
            this.rbBrake.AutoSize = true;
            this.rbBrake.Location = new System.Drawing.Point(1019, 445);
            this.rbBrake.Name = "rbBrake";
            this.rbBrake.Size = new System.Drawing.Size(78, 17);
            this.rbBrake.TabIndex = 96;
            this.rbBrake.Text = "not braking";
            this.rbBrake.UseVisualStyleBackColor = true;
            // 
            // nud_version
            // 
            this.nud_version.BackColor = System.Drawing.SystemColors.Window;
            this.nud_version.Location = new System.Drawing.Point(97, 55);
            this.nud_version.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_version.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_version.Name = "nud_version";
            this.nud_version.ReadOnly = true;
            this.nud_version.Size = new System.Drawing.Size(46, 20);
            this.nud_version.TabIndex = 97;
            this.nud_version.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.nud_version.ValueChanged += new System.EventHandler(this.nud_version_ValueChanged);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(9, 58);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(81, 13);
            this.label50.TabIndex = 98;
            this.label50.Text = "HW Revision";
            // 
            // panel11
            // 
            this.panel11.AutoScroll = true;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.label26);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.nud_temperature_cutoff_stop);
            this.panel11.Controls.Add(this.chb_thermistor_cutoff);
            this.panel11.Controls.Add(this.nud_temperature_cutoff_start);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.nud_therm_r);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.nud_therm_beta);
            this.panel11.Controls.Add(this.nud_therm_t0);
            this.panel11.Controls.Add(this.chb_thermistor);
            this.panel11.Controls.Add(this.txb_thermistorpin);
            this.panel11.Controls.Add(this.txb_tempsensepin);
            this.panel11.Controls.Add(this.chb_DS1820);
            this.panel11.Controls.Add(this.chb_rtc);
            this.panel11.Controls.Add(this.chb_dspc01);
            this.panel11.Controls.Add(this.nud_bpm_max);
            this.panel11.Controls.Add(this.nud_bpm_min);
            this.panel11.Controls.Add(this.chb_bmp085);
            this.panel11.Controls.Add(this.chb_HRMI);
            this.panel11.Controls.Add(this.label51);
            this.panel11.Location = new System.Drawing.Point(352, 198);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(223, 96);
            this.panel11.TabIndex = 99;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(85, 222);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(10, 13);
            this.label26.TabIndex = 119;
            this.label26.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "°C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 114;
            this.label6.Text = "Thermistor R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "Thermistor beta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 110;
            this.label4.Text = "Thermistor T0";
            // 
            // nud_bpm_max
            // 
            this.nud_bpm_max.Location = new System.Drawing.Point(129, 27);
            this.nud_bpm_max.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nud_bpm_max.Name = "nud_bpm_max";
            this.nud_bpm_max.Size = new System.Drawing.Size(46, 20);
            this.nud_bpm_max.TabIndex = 23;
            this.nud_bpm_max.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            this.nud_bpm_max.ValueChanged += new System.EventHandler(this.nud_bpm_max_ValueChanged);
            // 
            // nud_bpm_min
            // 
            this.nud_bpm_min.Location = new System.Drawing.Point(53, 27);
            this.nud_bpm_min.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nud_bpm_min.Name = "nud_bpm_min";
            this.nud_bpm_min.Size = new System.Drawing.Size(46, 20);
            this.nud_bpm_min.TabIndex = 20;
            this.nud_bpm_min.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nud_bpm_min.ValueChanged += new System.EventHandler(this.nud_bpm_min_ValueChanged);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(3, 1);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(110, 13);
            this.label51.TabIndex = 16;
            this.label51.Text = "I2C, other sensors";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_localpath});
            this.statusStrip1.Location = new System.Drawing.Point(0, 759);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1214, 22);
            this.statusStrip1.TabIndex = 101;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_localpath
            // 
            this.tssl_localpath.Name = "tssl_localpath";
            this.tssl_localpath.Size = new System.Drawing.Size(0, 17);
            // 
            // bt_compile
            // 
            this.bt_compile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_compile.Location = new System.Drawing.Point(858, 27);
            this.bt_compile.Name = "bt_compile";
            this.bt_compile.Size = new System.Drawing.Size(128, 60);
            this.bt_compile.TabIndex = 102;
            this.bt_compile.Text = "GO!";
            this.bt_compile.UseVisualStyleBackColor = true;
            this.bt_compile.Click += new System.EventHandler(this.bt_compile_Click);
            // 
            // panel12
            // 
            this.panel12.AutoScroll = true;
            this.panel12.BackColor = System.Drawing.SystemColors.Control;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.label61);
            this.panel12.Controls.Add(this.label60);
            this.panel12.Controls.Add(this.nud_fixedsoftpoti);
            this.panel12.Controls.Add(this.chb_bluetoothstartup);
            this.panel12.Controls.Add(this.chb_lightswitch_menu);
            this.panel12.Controls.Add(this.chb_lightswitch_startup);
            this.panel12.Controls.Add(this.chb_lightswitch);
            this.panel12.Controls.Add(this.chb_profilemenu);
            this.panel12.Controls.Add(this.chb_firstaid);
            this.panel12.Controls.Add(this.nud_menuidle);
            this.panel12.Controls.Add(this.label38);
            this.panel12.Controls.Add(this.label36);
            this.panel12.Controls.Add(this.txb_goodbye);
            this.panel12.Controls.Add(this.label35);
            this.panel12.Controls.Add(this.txb_welcometext);
            this.panel12.Controls.Add(this.label57);
            this.panel12.Controls.Add(this.nud_idle_shutdown);
            this.panel12.Controls.Add(this.label56);
            this.panel12.Location = new System.Drawing.Point(787, 276);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(179, 159);
            this.panel12.TabIndex = 103;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(140, 195);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(18, 13);
            this.label61.TabIndex = 123;
            this.label61.Text = "W";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(0, 195);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(72, 13);
            this.label60.TabIndex = 122;
            this.label60.Text = "Fixed SoftPoti";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(3, 37);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(60, 13);
            this.label38.TabIndex = 110;
            this.label38.Text = "menu idle s";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(3, 80);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(69, 13);
            this.label36.TabIndex = 108;
            this.label36.Text = "bye message";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 59);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(72, 13);
            this.label35.TabIndex = 106;
            this.label35.Text = "start message";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(3, 3);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(91, 13);
            this.label57.TabIndex = 104;
            this.label57.Text = "misc and menu";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(3, 21);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(80, 13);
            this.label56.TabIndex = 4;
            this.label56.Text = "idle shutdown s";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(586, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(101, 49);
            this.panel4.TabIndex = 106;
            this.panel4.MouseEnter += new System.EventHandler(this.panel4_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(472, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 120);
            this.panel1.TabIndex = 106;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Location = new System.Drawing.Point(8, 124);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(47, 41);
            this.panel5.TabIndex = 107;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel10.Location = new System.Drawing.Point(94, 8);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(80, 54);
            this.panel10.TabIndex = 105;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Controls.Add(this.panel21);
            this.panel18.Location = new System.Drawing.Point(480, 571);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(47, 41);
            this.panel18.TabIndex = 108;
            this.panel18.MouseEnter += new System.EventHandler(this.panel18_MouseEnter);
            this.panel18.MouseLeave += new System.EventHandler(this.panel18_MouseLeave);
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel19.Controls.Add(this.panel20);
            this.panel19.Location = new System.Drawing.Point(8, 124);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(47, 41);
            this.panel19.TabIndex = 107;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel20.Location = new System.Drawing.Point(94, 8);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(80, 54);
            this.panel20.TabIndex = 105;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel21.Location = new System.Drawing.Point(94, 8);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(80, 54);
            this.panel21.TabIndex = 105;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel16.Controls.Add(this.panel17);
            this.panel16.Controls.Add(this.panel23);
            this.panel16.Location = new System.Drawing.Point(744, 557);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(67, 71);
            this.panel16.TabIndex = 109;
            this.panel16.MouseEnter += new System.EventHandler(this.panel16_MouseEnter);
            this.panel16.MouseLeave += new System.EventHandler(this.panel16_MouseLeave);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel17.Controls.Add(this.panel22);
            this.panel17.Location = new System.Drawing.Point(8, 124);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(47, 41);
            this.panel17.TabIndex = 107;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel22.Location = new System.Drawing.Point(94, 8);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(80, 54);
            this.panel22.TabIndex = 105;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel23.Location = new System.Drawing.Point(94, 8);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(80, 54);
            this.panel23.TabIndex = 105;
            // 
            // tb_console
            // 
            this.tb_console.Location = new System.Drawing.Point(1004, 532);
            this.tb_console.Multiline = true;
            this.tb_console.Name = "tb_console";
            this.tb_console.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_console.Size = new System.Drawing.Size(190, 215);
            this.tb_console.TabIndex = 110;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Arduino_Pedelec_Configurator.Properties.Resources.background2;
            this.pictureBox1.Image = global::Arduino_Pedelec_Configurator.Properties.Resources.background2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 750);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // bt_switch_profile
            // 
            this.bt_switch_profile.BackColor = System.Drawing.Color.Blue;
            this.bt_switch_profile.ForeColor = System.Drawing.Color.Red;
            this.bt_switch_profile.Location = new System.Drawing.Point(205, 54);
            this.bt_switch_profile.Name = "bt_switch_profile";
            this.bt_switch_profile.Size = new System.Drawing.Size(118, 23);
            this.bt_switch_profile.TabIndex = 113;
            this.bt_switch_profile.Text = "Show RED setup";
            this.bt_switch_profile.UseVisualStyleBackColor = false;
            this.bt_switch_profile.Click += new System.EventHandler(this.bt_switch_profile_Click);
            // 
            // chb_online
            // 
            this.chb_online.AutoSize = true;
            this.chb_online.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_online.Checked = true;
            this.chb_online.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_online.Location = new System.Drawing.Point(758, 30);
            this.chb_online.Name = "chb_online";
            this.chb_online.Size = new System.Drawing.Size(94, 17);
            this.chb_online.TabIndex = 114;
            this.chb_online.Text = "online sources";
            this.chb_online.UseVisualStyleBackColor = true;
            this.chb_online.CheckedChanged += new System.EventHandler(this.chb_online_CheckedChanged);
            // 
            // chb_local
            // 
            this.chb_local.AutoSize = true;
            this.chb_local.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_local.Location = new System.Drawing.Point(764, 46);
            this.chb_local.Name = "chb_local";
            this.chb_local.Size = new System.Drawing.Size(88, 17);
            this.chb_local.TabIndex = 115;
            this.chb_local.Text = "local sources";
            this.chb_local.UseVisualStyleBackColor = true;
            this.chb_local.CheckedChanged += new System.EventHandler(this.chb_local_CheckedChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // bt_source_local
            // 
            this.bt_source_local.Enabled = false;
            this.bt_source_local.Location = new System.Drawing.Point(764, 64);
            this.bt_source_local.Name = "bt_source_local";
            this.bt_source_local.Size = new System.Drawing.Size(88, 23);
            this.bt_source_local.TabIndex = 116;
            this.bt_source_local.Text = "browse";
            this.bt_source_local.UseVisualStyleBackColor = true;
            this.bt_source_local.Click += new System.EventHandler(this.bt_source_local_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Arduino files|*.ino|All files (*.*)|*.*";
            this.openFileDialog.Title = "Point to .ino of your custom Code";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.serialPortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1214, 24);
            this.menuStrip1.TabIndex = 117;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_setkilometers_menu,
            this.bt_settime_menu,
            this.bt_setcounter_menu});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // bt_setkilometers_menu
            // 
            this.bt_setkilometers_menu.Name = "bt_setkilometers_menu";
            this.bt_setkilometers_menu.Size = new System.Drawing.Size(175, 22);
            this.bt_setkilometers_menu.Text = "Set total kilometers";
            this.bt_setkilometers_menu.ToolTipText = "Select and connect serial port first!";
            this.bt_setkilometers_menu.Click += new System.EventHandler(this.setTotalKilometersToolStripMenuItem_Click);
            // 
            // bt_settime_menu
            // 
            this.bt_settime_menu.Enabled = false;
            this.bt_settime_menu.Name = "bt_settime_menu";
            this.bt_settime_menu.Size = new System.Drawing.Size(175, 22);
            this.bt_settime_menu.Text = "Set time";
            this.bt_settime_menu.Click += new System.EventHandler(this.bt_settime_menu_Click);
            // 
            // bt_setcounter_menu
            // 
            this.bt_setcounter_menu.Name = "bt_setcounter_menu";
            this.bt_setcounter_menu.Size = new System.Drawing.Size(175, 22);
            this.bt_setcounter_menu.Text = "Set charge counter";
            this.bt_setcounter_menu.Click += new System.EventHandler(this.bt_setcounter_menu_Click);
            // 
            // serialPortToolStripMenuItem
            // 
            this.serialPortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cb_serial_menu,
            this.bt_connect_menu,
            this.bt_disconnect_menu,
            this.bt_refresh_menu});
            this.serialPortToolStripMenuItem.Name = "serialPortToolStripMenuItem";
            this.serialPortToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.serialPortToolStripMenuItem.Text = "Serial Port";
            // 
            // cb_serial_menu
            // 
            this.cb_serial_menu.Name = "cb_serial_menu";
            this.cb_serial_menu.Size = new System.Drawing.Size(121, 23);
            this.cb_serial_menu.Text = "Select Serial Port";
            // 
            // bt_connect_menu
            // 
            this.bt_connect_menu.Name = "bt_connect_menu";
            this.bt_connect_menu.Size = new System.Drawing.Size(181, 22);
            this.bt_connect_menu.Text = "Connect";
            this.bt_connect_menu.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // bt_disconnect_menu
            // 
            this.bt_disconnect_menu.Name = "bt_disconnect_menu";
            this.bt_disconnect_menu.Size = new System.Drawing.Size(181, 22);
            this.bt_disconnect_menu.Text = "Disconnect";
            this.bt_disconnect_menu.Click += new System.EventHandler(this.bt_disconnect_menu_Click);
            // 
            // bt_refresh_menu
            // 
            this.bt_refresh_menu.Name = "bt_refresh_menu";
            this.bt_refresh_menu.Size = new System.Drawing.Size(181, 22);
            this.bt_refresh_menu.Text = "Refresh";
            this.bt_refresh_menu.Click += new System.EventHandler(this.bt_refresh_menu_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.cb_bluetoothmode);
            this.panel6.Controls.Add(this.lbl_bluetoothmode);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Controls.Add(this.cb_serialmode);
            this.panel6.Location = new System.Drawing.Point(368, 146);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(193, 47);
            this.panel6.TabIndex = 118;
            // 
            // lbl_bluetoothmode
            // 
            this.lbl_bluetoothmode.AutoSize = true;
            this.lbl_bluetoothmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bluetoothmode.Location = new System.Drawing.Point(96, 5);
            this.lbl_bluetoothmode.Name = "lbl_bluetoothmode";
            this.lbl_bluetoothmode.Size = new System.Drawing.Size(95, 13);
            this.lbl_bluetoothmode.TabIndex = 48;
            this.lbl_bluetoothmode.Text = "Bluetooth mode";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel25);
            this.panel7.Location = new System.Drawing.Point(165, 495);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(47, 41);
            this.panel7.TabIndex = 119;
            this.panel7.MouseEnter += new System.EventHandler(this.panel7_MouseEnter);
            this.panel7.MouseLeave += new System.EventHandler(this.panel7_MouseLeave);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel8.Controls.Add(this.panel24);
            this.panel8.Location = new System.Drawing.Point(8, 124);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(47, 41);
            this.panel8.TabIndex = 107;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel24.Location = new System.Drawing.Point(94, 8);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(80, 54);
            this.panel24.TabIndex = 105;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel25.Location = new System.Drawing.Point(94, 8);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(80, 54);
            this.panel25.TabIndex = 105;
            // 
            // Form_menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1214, 781);
            this.Controls.Add(this.nud_external_current_amplitude);
            this.Controls.Add(this.nud_external_current_offset);
            this.Controls.Add(this.nud_external_voltage_amplitude);
            this.Controls.Add(this.nud_external_voltage_offset);
            this.Controls.Add(this.txb_external_current);
            this.Controls.Add(this.chb_external_current);
            this.Controls.Add(this.txb_external_voltage);
            this.Controls.Add(this.chb_external_voltage);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.bt_source_local);
            this.Controls.Add(this.chb_local);
            this.Controls.Add(this.chb_online);
            this.Controls.Add(this.bt_switch_profile);
            this.Controls.Add(this.tb_console);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.bt_compile);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.nud_version);
            this.Controls.Add(this.rbBrake);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.lblThrottleMin);
            this.Controls.Add(this.lblThrottleMax);
            this.Controls.Add(this.lblThrottleRaw);
            this.Controls.Add(this.desc_throttle);
            this.Controls.Add(this.tbThrottle);
            this.Controls.Add(this.lblPotiMin);
            this.Controls.Add(this.lblPotiMax);
            this.Controls.Add(this.lblPotiRaw);
            this.Controls.Add(this.desc_poti);
            this.Controls.Add(this.tbPoti);
            this.Controls.Add(this.lbl_pas_factor);
            this.Controls.Add(this.desc_pas);
            this.Controls.Add(this.chart_pas);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.nud_current_amplitude);
            this.Controls.Add(this.nud_current_offset);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.nud_voltage_amplitude);
            this.Controls.Add(this.nud_voltage_offset);
            this.Controls.Add(this.lblCurrentCalc);
            this.Controls.Add(this.lblVoltageCalc);
            this.Controls.Add(this.lblCurrentRaw);
            this.Controls.Add(this.desc_current);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.lblVoltageRaw);
            this.Controls.Add(this.desc_voltage);
            this.Controls.Add(this.tbVoltage);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.panel_battery);
            this.Controls.Add(this.panel_controlmode);
            this.Controls.Add(this.panel_motor);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_load);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cb_profile);
            this.Controls.Add(this.panel_speedsensor);
            this.Controls.Add(this.panel_power);
            this.Controls.Add(this.panel_bottombracket);
            this.Controls.Add(this.powergraph);
            this.Controls.Add(this.panel_throttle);
            this.Controls.Add(this.panel_controls);
            this.Controls.Add(this.panel_display);
            this.Controls.Add(this.panel_brake);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1230, 820);
            this.Name = "Form_menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Arduino Pedelec Configurator 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_circumference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_magnets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pasfactor_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pasfactor_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pas_tolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_motor_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_motor_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_poti_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_poti_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_throttle_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_throttle_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_power_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_power_thermal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_thermalsafespeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_startingaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_controlmode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vemergency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vcutoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_display_contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_speedcutoff_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_speedcutoff_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_menuidle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_idle_shutdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pidi_throttle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pidp_throttle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pidi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pidp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_idlespeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_power_max_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_speedcutoff_start_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_speedcutoff_stop_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_startingaid_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_controlmode_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stepsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_voltage_offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_voltage_amplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_current_amplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_current_offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_poti_startup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fixed_throttle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_chargedetect_min)).EndInit();
            this.panel13.ResumeLayout(false);
            this.contextmenu_display.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.contextmenu_poti.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.contextmenu_throttle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_magnetcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pastimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_external_voltage_amplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_external_voltage_offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_external_current_amplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_external_current_offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fixedsoftpoti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gearchangepause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_torquethrottle_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_torquethrottle_full)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_therm_t0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_therm_beta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_therm_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_torque_zero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_temperature_cutoff_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_temperature_cutoff_start)).EndInit();
            this.panel_brake.ResumeLayout(false);
            this.panel_brake.PerformLayout();
            this.panel_display.ResumeLayout(false);
            this.panel_display.PerformLayout();
            this.panel_controls.ResumeLayout(false);
            this.panel_controls.PerformLayout();
            this.panel_throttle.ResumeLayout(false);
            this.panel_throttle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powergraph)).EndInit();
            this.panel_bottombracket.ResumeLayout(false);
            this.panel_bottombracket.PerformLayout();
            this.panel_power.ResumeLayout(false);
            this.panel_power.PerformLayout();
            this.panel_speedsensor.ResumeLayout(false);
            this.panel_speedsensor.PerformLayout();
            this.panel_motor.ResumeLayout(false);
            this.panel_motor.PerformLayout();
            this.panel_controlmode.ResumeLayout(false);
            this.panel_controlmode.PerformLayout();
            this.panel_battery.ResumeLayout(false);
            this.panel_battery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_capacity_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPoti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThrottle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_version)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bpm_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bpm_min)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_bottombracket;
        private System.Windows.Forms.NumericUpDown nud_circumference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_magnets;
        private System.Windows.Forms.Label lbl_magnets;
        private System.Windows.Forms.NumericUpDown nud_pasfactor_min;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown nud_pasfactor_max;
        private System.Windows.Forms.Label lbl_pf;
        private System.Windows.Forms.Label lbl_pfmin;
        private System.Windows.Forms.Label lbl_pfmax;
        private System.Windows.Forms.CheckBox chb_brake;
        private System.Windows.Forms.CheckBox chb_brakeinverted;
        private System.Windows.Forms.ComboBox cb_display;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chb_backlight;
        private System.Windows.Forms.Panel panel_brake;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel_display;
        private System.Windows.Forms.Panel panel_controls;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel_throttle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_poti_max;
        private System.Windows.Forms.Label lbl_poti_min;
        private System.Windows.Forms.NumericUpDown nud_poti_max;
        private System.Windows.Forms.NumericUpDown nud_poti_min;
        private System.Windows.Forms.ComboBox cb_controls;
        private System.Windows.Forms.Label lbl_thr_max;
        private System.Windows.Forms.CheckBox chb_throttle;
        private System.Windows.Forms.Label lbl_thr_min;
        private System.Windows.Forms.NumericUpDown nud_throttle_max;
        private System.Windows.Forms.NumericUpDown nud_throttle_min;
        private System.Windows.Forms.DataVisualization.Charting.Chart powergraph;
        private System.Windows.Forms.NumericUpDown nud_power_max;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nud_power_thermal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nud_thermalsafespeed;
        private System.Windows.Forms.NumericUpDown nud_speedcutoff_stop;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nud_speedcutoff_start;
        private System.Windows.Forms.NumericUpDown nud_startingaid;
        private System.Windows.Forms.Panel panel_bottombracket;
        private System.Windows.Forms.Panel panel_power;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel_speedsensor;
        private System.Windows.Forms.ComboBox cb_profile;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.NumericUpDown nud_display_contrast;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cb_controlmode;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cb_serialmode;
        private System.Windows.Forms.Label lbl_pastol;
        private System.Windows.Forms.NumericUpDown nud_pas_tolerance;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown nud_motor_max;
        private System.Windows.Forms.NumericUpDown nud_motor_min;
        private System.Windows.Forms.Panel panel_motor;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox chb_startingaid;
        private System.Windows.Forms.Panel panel_controlmode;
        private System.Windows.Forms.Panel panel_battery;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown nud_vemergency;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown nud_vcutoff;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.NumericUpDown nud_capacity;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label34;
        private System.ComponentModel.BackgroundWorker bwSerial;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbVoltage;
        private System.Windows.Forms.Label desc_voltage;
        private System.Windows.Forms.Label lblVoltageRaw;
        private System.Windows.Forms.Label lblCurrentRaw;
        private System.Windows.Forms.Label desc_current;
        private System.Windows.Forms.TrackBar tbCurrent;
        private System.Windows.Forms.Label lblVoltageCalc;
        private System.Windows.Forms.Label lblCurrentCalc;
        private System.Windows.Forms.NumericUpDown nud_voltage_offset;
        private System.Windows.Forms.NumericUpDown nud_voltage_amplitude;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown nud_current_amplitude;
        private System.Windows.Forms.NumericUpDown nud_current_offset;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_pas;
        private System.Windows.Forms.Label desc_pas;
        private System.Windows.Forms.Label lbl_pas_factor;
        private System.Windows.Forms.Label lblPotiMin;
        private System.Windows.Forms.Label lblPotiMax;
        private System.Windows.Forms.Label lblPotiRaw;
        private System.Windows.Forms.Label desc_poti;
        private System.Windows.Forms.TrackBar tbPoti;
        private System.Windows.Forms.Label lblThrottleMin;
        private System.Windows.Forms.Label lblThrottleMax;
        private System.Windows.Forms.Label lblThrottleRaw;
        private System.Windows.Forms.Label desc_throttle;
        private System.Windows.Forms.TrackBar tbThrottle;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.RadioButton rbBrake;
        private System.Windows.Forms.NumericUpDown nud_version;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.CheckBox chb_bmp085;
        private System.Windows.Forms.CheckBox chb_HRMI;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button bt_compile;
        private System.Windows.Forms.NumericUpDown nud_bpm_max;
        private System.Windows.Forms.NumericUpDown nud_bpm_min;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lbl_controlmode;
        private System.Windows.Forms.NumericUpDown nud_controlmode;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.NumericUpDown nud_pidp;
        private System.Windows.Forms.NumericUpDown nud_idle_shutdown;
        private System.Windows.Forms.NumericUpDown nud_pidi_throttle;
        private System.Windows.Forms.NumericUpDown nud_pidp_throttle;
        private System.Windows.Forms.NumericUpDown nud_pidi;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox tb_console;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txb_goodbye;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txb_welcometext;
        private System.Windows.Forms.ContextMenuStrip contextmenu_display;
        private System.Windows.Forms.ToolStripMenuItem tssm;
        private System.Windows.Forms.ToolStripComboBox cbts_menuup;
        private System.Windows.Forms.ToolStripMenuItem menuButtonDOWNToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbts_menudown;
        private System.Windows.Forms.ToolStripMenuItem toolstripdisp1short;
        private System.Windows.Forms.ToolStripComboBox cbts_disp1short;
        private System.Windows.Forms.ToolStripMenuItem toolstripdisp1long;
        private System.Windows.Forms.ToolStripComboBox cbts_disp1long;
        private System.Windows.Forms.ToolStripMenuItem toolstripdisp2short;
        private System.Windows.Forms.ToolStripComboBox cbts_disp2short;
        private System.Windows.Forms.ToolStripMenuItem displaySwitch2LongToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbts_disp2long;
        private System.Windows.Forms.ContextMenuStrip contextmenu_throttle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripComboBox cbts_throttleshort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripComboBox cbts_throttlelong;
        private System.Windows.Forms.NumericUpDown nud_menuidle;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.NumericUpDown nud_vmax;
        private System.Windows.Forms.CheckBox chb_preguess;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.NumericUpDown nud_idlespeed;
        private System.Windows.Forms.NumericUpDown nud_startingaid_2;
        private System.Windows.Forms.NumericUpDown nud_speedcutoff_stop_2;
        private System.Windows.Forms.NumericUpDown nud_speedcutoff_start_2;
        private System.Windows.Forms.NumericUpDown nud_power_max_2;
        private System.Windows.Forms.NumericUpDown nud_controlmode_2;
        private System.Windows.Forms.NumericUpDown nud_capacity_2;
        private System.Windows.Forms.Button bt_switch_profile;
        private System.Windows.Forms.CheckBox chb_dspc01;
        private System.Windows.Forms.CheckBox chb_firstaid;
        private System.Windows.Forms.CheckBox chb_online;
        private System.Windows.Forms.CheckBox chb_local;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button bt_source_local;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel tssl_localpath;
        private System.Windows.Forms.CheckBox chb_chargedetection;
        private System.Windows.Forms.CheckBox chb_profilemenu;
        private System.Windows.Forms.Label lbl_stepsize;
        private System.Windows.Forms.NumericUpDown nud_stepsize;
        private System.Windows.Forms.Label lbl_stepsize_unit;
        private System.Windows.Forms.ContextMenuStrip contextmenu_poti;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox cbts_potishort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox cbts_potilong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bt_setkilometers_menu;
        private System.Windows.Forms.ToolStripMenuItem serialPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cb_serial_menu;
        private System.Windows.Forms.ToolStripMenuItem bt_connect_menu;
        private System.Windows.Forms.ToolStripMenuItem bt_refresh_menu;
        private System.Windows.Forms.ToolStripMenuItem bt_disconnect_menu;
        private System.Windows.Forms.CheckBox chb_lightswitch;
        private System.Windows.Forms.CheckBox chb_lightswitch_menu;
        private System.Windows.Forms.CheckBox chb_lightswitch_startup;
        private System.Windows.Forms.CheckBox chb_rtc;
        private System.Windows.Forms.ToolStripMenuItem bt_settime_menu;
        private System.Windows.Forms.CheckBox chb_bluetoothstartup;
        private System.Windows.Forms.Label lbl_poti_startup;
        private System.Windows.Forms.NumericUpDown nud_poti_startup;
        private System.Windows.Forms.Label lbl_startup_unit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_fixed_throttle_unit;
        private System.Windows.Forms.NumericUpDown nud_fixed_throttle;
        private System.Windows.Forms.Label lbl_chargedetect_min;
        private System.Windows.Forms.NumericUpDown nud_chargedetect_min;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_highgear;
        private System.Windows.Forms.TextBox txb_lowgear;
        private System.Windows.Forms.CheckBox chb_gearshift;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cb_bluetoothmode;
        private System.Windows.Forms.Label lbl_bluetoothmode;
        private System.Windows.Forms.CheckBox chb_chargecounter;
        private System.Windows.Forms.ToolStripMenuItem bt_setcounter_menu;
        private System.Windows.Forms.CheckBox chb_motorservo;
        private System.Windows.Forms.CheckBox chb_switchonpoti;
        private System.Windows.Forms.CheckBox chb_autocruise;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nud_magnetcount;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.CheckBox chb_brokensensor;
        private System.Windows.Forms.Label lbl_pastimeoutms;
        private System.Windows.Forms.Label lbl_pastimeout;
        private System.Windows.Forms.NumericUpDown nud_pastimeout;
        private System.Windows.Forms.TextBox txb_tempsensepin;
        private System.Windows.Forms.CheckBox chb_DS1820;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TextBox txb_external_current;
        private System.Windows.Forms.CheckBox chb_external_current;
        private System.Windows.Forms.TextBox txb_external_voltage;
        private System.Windows.Forms.CheckBox chb_external_voltage;
        private System.Windows.Forms.NumericUpDown nud_external_current_amplitude;
        private System.Windows.Forms.NumericUpDown nud_external_current_offset;
        private System.Windows.Forms.NumericUpDown nud_external_voltage_amplitude;
        private System.Windows.Forms.NumericUpDown nud_external_voltage_offset;
        private System.Windows.Forms.CheckBox chb_resetintegral;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmi_GRAPHIC;
        private System.Windows.Forms.ToolStripMenuItem tsmi_HUMAN;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ENVIRONMENT;
        private System.Windows.Forms.ToolStripMenuItem tsmi_TIME;
        private System.Windows.Forms.ToolStripMenuItem tsmi_BATTERY;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.NumericUpDown nud_fixedsoftpoti;
        private System.Windows.Forms.Label lbl_gearchange;
        private System.Windows.Forms.NumericUpDown nud_gearchangepause;
        private System.Windows.Forms.Label lbl_torquethrottlemax;
        private System.Windows.Forms.Label lbl_torquethrottlemin;
        private System.Windows.Forms.NumericUpDown nud_torquethrottle_full;
        private System.Windows.Forms.NumericUpDown nud_torquethrottle_min;
        private System.Windows.Forms.CheckBox chb_torque_throttle;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ODO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_therm_r;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_therm_beta;
        private System.Windows.Forms.NumericUpDown nud_therm_t0;
        private System.Windows.Forms.CheckBox chb_thermistor;
        private System.Windows.Forms.TextBox txb_thermistorpin;
        private System.Windows.Forms.CheckBox chb_torquezero_auto;
        private System.Windows.Forms.Label lbl_torque_zero;
        private System.Windows.Forms.NumericUpDown nud_torque_zero;
        private System.Windows.Forms.NumericUpDown nud_temperature_cutoff_stop;
        private System.Windows.Forms.CheckBox chb_thermistor_cutoff;
        private System.Windows.Forms.NumericUpDown nud_temperature_cutoff_start;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label7;
    }
}

