using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Net;
using Ionic.Zip;

namespace Arduino_Pedelec_Configurator


{
    public partial class Form_menu : Form
    {
        SerialPort spArduino;
        string serialString;
        string appPath;
        string configPath,sourcePath_local,sourcePath_online;
        string appVersion = "1.42";
        string updatetext = "";
        Rectangle rect_motor;

        List<string> ACTIONS = new List<string> {
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
            "ACTION_DISPLAY_NEXT_VIEW",
            "ACTION_GEAR_SHIFT_LOW",
            "ACTION_GEAR_SHIFT_HIGH",
            "ACTION_GEAR_SHIFT_AUTO",
            "ACTION_TORQUE_ZERO"};

        public Form_menu()
        {
            InitializeComponent();
        }


        private void cb_bottombracket_SelectedIndexChanged(object sender, EventArgs e)
        {
            nud_magnets.Visible =
            lbl_magnets.Visible = 

            nud_pasfactor_min.Visible =
            nud_pasfactor_max.Visible =
            lbl_pf.Visible =
            lbl_pfmax.Visible =
            lbl_pfmin.Visible =

            nud_pas_tolerance.Visible =
            lbl_pastol.Visible =

            nud_gearchangepause.Visible = 
            lbl_gearchange.Visible =

            nud_pastimeout.Visible =
            lbl_pastimeout.Visible =
            lbl_pastimeoutms.Visible =

            chb_torque_throttle.Visible =
            nud_torquethrottle_full.Visible =
            nud_torquethrottle_min.Visible =
            lbl_torquethrottlemin.Visible =
            lbl_torquethrottlemax.Visible =
            lbl_torque_zero.Visible=
            nud_torque_zero.Visible=
            chb_torquezero_auto.Visible=
            false;
            switch (cb_bottombracket.SelectedIndex)
            {
                case 0: //no PAS sensor
                    nud_magnets.Value = 5;
                    break;
                case 1: //standard PAS sensor
                    nud_magnets.Value = 5;
                    nud_magnets.Visible =
                    lbl_magnets.Visible = 
                    nud_pasfactor_min.Visible =
                    nud_pasfactor_max.Visible =
                    lbl_pf.Visible =
                    lbl_pfmax.Visible =
                    lbl_pfmin.Visible =
                    nud_pas_tolerance.Visible =
                    lbl_pastol.Visible = 
                    nud_pastimeout.Visible =
                    lbl_pastimeout.Visible =
                    lbl_pastimeoutms.Visible =true;
                    break;
                case 2: //Thun X-Cell RT
                    if (nud_version.Value<=5)
                        chb_lightswitch.Checked = false;
                    nud_magnets.Value = 8;
                    if (nud_version.Value < 5)
                    {
                        nud_pasfactor_min.Value = 0.2M;
                        nud_pasfactor_max.Value = 0.5M;
                    }
                    else 
                    {
                        nud_pasfactor_min.Value = 0.5M;
                        nud_pasfactor_max.Value = 1.5M;
                    }
                    nud_pastimeout.Visible =
                    lbl_pastimeout.Visible =
                    lbl_pastimeoutms.Visible =
                    chb_torque_throttle.Visible =
                    nud_torquethrottle_full.Visible =
                    nud_torquethrottle_min.Visible =
                    lbl_torquethrottlemin.Visible =
                    lbl_torquethrottlemax.Visible =
                    lbl_torque_zero.Visible =
                    nud_torque_zero.Visible =
                    chb_torquezero_auto.Visible = true;
                    break;
                case 3: //BBS bottom bracket
                    lbl_gearchange.Visible = 
                    nud_gearchangepause.Visible = true;
                    if (nud_version.Value <= 5)
                        chb_lightswitch.Checked = false;
                    nud_magnets.Value = 24;
                    if (nud_version.Value < 5)
                    {
                        nud_pasfactor_min.Value = 0.2M;
                        nud_pasfactor_max.Value = 0.5M;
                    }
                    else
                    {
                        nud_pasfactor_min.Value = 0.5M;
                        nud_pasfactor_max.Value = 1.5M;
                    }
                    break;
                case 4: //Sempu V1
                case 5: //Sempu new
                    if (nud_version.Value <= 5)
                        chb_lightswitch.Checked = false;
                    nud_pastimeout.Visible =
                    lbl_pastimeout.Visible =
                    lbl_pastimeoutms.Visible =
                    chb_torque_throttle.Visible =
                    nud_torquethrottle_full.Visible =
                    nud_torquethrottle_min.Visible =
                    lbl_torquethrottlemin.Visible =
                    lbl_torquethrottlemax.Visible =
                    lbl_torque_zero.Visible =
                    nud_torque_zero.Visible =
                    chb_torquezero_auto.Visible = true;
                    nud_torque_zero.Value = 307;
                    break;
            }
        }

        private void cb_brake_CheckedChanged(object sender, EventArgs e)
        {
            rbBrake.Enabled = chb_brake.Enabled;
            chb_brakeinverted.Enabled = chb_brake.Checked;
            if (chb_brake.Checked==false)
                chb_brakeinverted.Checked=false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbts_disp1short.ComboBox.BindingContext = this.BindingContext;
            cbts_disp1short.ComboBox.DataSource = new BindingSource(ACTIONS, null);
            cbts_disp1long.ComboBox.BindingContext = this.BindingContext;
            cbts_disp1long.ComboBox.DataSource = new BindingSource(ACTIONS, null);
            cbts_disp2short.ComboBox.BindingContext = this.BindingContext;
            cbts_disp2short.ComboBox.DataSource = new BindingSource(ACTIONS, null);
            cbts_disp2long.ComboBox.BindingContext = this.BindingContext;
            cbts_disp2long.ComboBox.DataSource = new BindingSource(ACTIONS, null);
            cbts_throttleshort.ComboBox.BindingContext = this.BindingContext;
            cbts_throttleshort.ComboBox.DataSource = new BindingSource(ACTIONS, null);
            cbts_throttlelong.ComboBox.BindingContext = this.BindingContext;
            cbts_throttlelong.ComboBox.DataSource = new BindingSource(ACTIONS, null);
            cbts_potishort.ComboBox.BindingContext = this.BindingContext;
            cbts_potishort.ComboBox.DataSource = new BindingSource(ACTIONS, null);
            cbts_potilong.ComboBox.BindingContext = this.BindingContext;
            cbts_potilong.ComboBox.DataSource = new BindingSource(ACTIONS, null);




            panel14.Parent=panel13.Parent=panel4.Parent=panel3.Parent =panel1.Parent=panel16.Parent=panel18.Parent=panel7.Parent=pictureBox1;
            panel14.BackColor = panel13.BackColor = panel4.BackColor = panel3.BackColor = panel1.BackColor = panel16.BackColor = panel18.BackColor =panel7.BackColor= Color.Transparent;
            this.Text = "Arduino Pedelec Configurator " + appVersion;
            drawpowergraph();

            listserialports();

            appPath = Path.GetDirectoryName(Application.ExecutablePath);
            configPath = appPath+@"\config";
            sourcePath_online = appPath + @"\source";
            if (!System.IO.Directory.Exists(configPath))
                System.IO.Directory.CreateDirectory(configPath);
            if (!System.IO.Directory.Exists(sourcePath_online))
                System.IO.Directory.CreateDirectory(sourcePath_online);
            listconfigprofiles();

            cbts_throttleshort.SelectedIndex = 1;
            cbts_throttlelong.SelectedIndex = 0;
            cbts_disp1short.SelectedIndex = 3;
            cbts_disp1long.SelectedIndex = 2;
            cbts_disp2short.SelectedIndex = 0;
            cbts_disp2long.SelectedIndex = 4;
            cbts_potishort.SelectedIndex = 0;
            cbts_potilong.SelectedIndex = 0;

            cb_bluetoothmode.SelectedIndex = 1;


            //SWITCH_THROTTLE=0, SWITCH_DISPLAY1=1, SWITCH_DISPLAY2=2
            cbts_menuup.SelectedIndex = 2;
            cbts_menudown.SelectedIndex = 1;

            string githubversion = get_githubversion();
            if (githubversion != "")
            {
                if (githubversion == appVersion)
                    tb_console.AppendText("\r\nyour APC version is up to date, fine");
                else
                {
                    tb_console.AppendText("\r\nyour APC version is OUTDATED! Please update. Current version is "+githubversion);
                    DialogResult dialogResult = MessageBox.Show("Your APC version is not up to date! Should I download newest APC version and update?\n\n Changes in "+githubversion+":\n"+updatetext, "Update APC?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        download_newapc();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }

            }
            else
                tb_console.AppendText("\r\ncould not check for new version");
            txb_welcometext.Text = "Version " + appVersion;

        }

        private void listconfigprofiles()
        {
            cb_profile.Items.Clear();
            string[] files = System.IO.Directory.GetFiles(configPath,"*.apc");
            foreach (string file in files)
            {
                cb_profile.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
            tb_console.AppendText("\r\nfound " + cb_profile.Items.Count + " profiles");
        }

        private string get_githubversion()
        {
            string version = "";
            string line = "";
            updatetext = "";
            WebClient webClient = new WebClient();

            tb_console.AppendText("\r\nchecking for version");
            try
            {
                webClient.DownloadFile("https://raw.githubusercontent.com/jenkie/Arduino-Pedelec-Configurator/master/version.txt", appPath + @"\version.txt");
                webClient.Dispose();
                if (System.IO.File.Exists(appPath + @"\version.txt"))
                {
                    System.IO.StreamReader infile = new System.IO.StreamReader(appPath + @"\version.txt");
                    version = infile.ReadLine();
                    while ((line = infile.ReadLine()) != null)
                    {
                        updatetext += line+"\n";
                    }
                }
            }
            catch (Exception ex)
                {
                    tb_console.AppendText("\r\n" + ex.Message);
                }
            return version;
        }

        private void download_newapc()
        {
            WebClient webClient = new WebClient();

            tb_console.AppendText("\r\ndowloading new APC from github");
            try
            {
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                webClient.DownloadFile("https://codeload.github.com/jenkie/Arduino-Pedelec-Configurator/legacy.zip/master", appPath + @"\updated_apc.zip");
                webClient.Dispose();
                MessageBox.Show("I will quit now. Extract everything from updated_apc.zip to the application directory and restart this Software.");
                System.Diagnostics.Process.Start(appPath + @"\updated_apc.zip");
                System.Windows.Forms.Application.Exit();
                }
            catch (Exception ex)
            {
                tb_console.AppendText("\r\n" + ex.Message);
            }
        }

        private void cb_display_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_display.SelectedIndex)
            {
                case 1://Nokia 4-Pin with two switches or 1 switch + automatic display backlight
                    chb_backlight.Visible = true;
                    break;
                case 6://Serial LCD
                    chb_backlight.Visible = true;
                    break;
                default:// all other displays
                    chb_backlight.Enabled = chb_backlight.Checked = false;
                    break;
            }
            if (0 < cb_display.SelectedIndex && cb_display.SelectedIndex < 4)
            {
                nud_display_contrast.Enabled = true;
            }
            else
            {
                nud_display_contrast.Enabled = false;
            }

        }

        private void nud_power_max_ValueChanged(object sender, EventArgs e)
        {
            drawpowergraph();
        }

        private void drawpowergraph()
        {

                powergraph.Series[0].Points.Clear();
                powergraph.Series[0].Points.AddXY(0, 0);
                powergraph.Series[0].Points.AddXY(0, nud_power_thermal.Value);
                powergraph.Series[0].Points.AddXY(nud_thermalsafespeed.Value, nud_power_max.Value);
                powergraph.Series[0].Points.AddXY(nud_speedcutoff_start.Value, nud_power_max.Value);
                powergraph.Series[0].Points.AddXY(nud_speedcutoff_stop.Value, 0);

                powergraph.Series[1].Points.Clear();
                powergraph.Series[1].Points.AddXY(0, 0);
                powergraph.Series[1].Points.AddXY(0, nud_power_thermal.Value);
                powergraph.Series[1].Points.AddXY(nud_thermalsafespeed.Value, nud_power_max_2.Value);
                powergraph.Series[1].Points.AddXY(nud_speedcutoff_start_2.Value, nud_power_max_2.Value);
                powergraph.Series[1].Points.AddXY(nud_speedcutoff_stop_2.Value, 0);
                powergraph.ChartAreas[0].AxisX.Maximum = Math.Max((double)nud_speedcutoff_stop_2.Value,(double)nud_speedcutoff_stop.Value);
                powergraph.ChartAreas[0].AxisX.Minimum = 0;
                powergraph.ChartAreas[0].AxisY.Minimum = 0;

        }

        private void cb_startingaid_CheckedChanged(object sender, EventArgs e)
        {
            nud_startingaid.Enabled = chb_startingaid.Checked;
        }

        private void listserialports()
        {
            cb_serial_menu.Items.Clear();
            string[] strPortNames = SerialPort.GetPortNames();
            foreach (string strPort in strPortNames)
            {
                cb_serial_menu.Items.Add(strPort);
            }
        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bwSerial.IsBusy == false)
            {
                bwSerial.RunWorkerAsync();
            }
        }

        private void bwSerial_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                serialString = spArduino.ReadLine();
                if (serialString.Contains("---raw---"))
                    serialString = serialString.Substring(serialString.IndexOf("---raw---") + 9);
            }
            catch 
            {
                timer1.Enabled = false;
                if (spArduino != null)
                    if (spArduino.IsOpen)
                        spArduino.Close();
                bt_connect_menu.Enabled = true;
            }

        }

        private void bwSerial_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            parseSerialValues(serialString);
        }

        private void parseSerialValues(string stringtoparse)
        {
            try
            {
                //0:voltage 1:current 2:pasfactor*100 3:option-pin 4:poti 5:throttle 6: brake
                string[] stringarray = stringtoparse.Split(';');
                if (stringarray.Length >= 7)
                {
                    //voltage stuff
                    lblVoltageRaw.Text = stringarray[0];
                    tbVoltage.Value = Convert.ToInt32(stringarray[0]);
                    if (chb_external_voltage.Checked)
                        lblVoltageCalc.Text = (tbVoltage.Value * nud_external_voltage_amplitude.Value + nud_external_voltage_offset.Value).ToString();
                    else
                        lblVoltageCalc.Text = (tbVoltage.Value * nud_voltage_amplitude.Value + nud_voltage_offset.Value).ToString();
                    //current stuff
                    lblCurrentRaw.Text = stringarray[1];
                    tbCurrent.Value = Convert.ToInt32(stringarray[1]);
                    if (chb_external_current.Checked)
                        lblCurrentCalc.Text = (tbCurrent.Value * nud_external_current_amplitude.Value + nud_external_current_offset.Value).ToString();
                    else
                    {
                        if (nud_version.Value<22)
                            lblCurrentCalc.Text = ((tbCurrent.Value - 512) * nud_current_amplitude.Value + nud_current_offset.Value).ToString();
                        else
                            lblCurrentCalc.Text = (tbCurrent.Value * nud_current_amplitude.Value + nud_current_offset.Value).ToString();
                    }
                    //pas factor stuff
                    chart_pas.Series[0].Points.AddY(Convert.ToDouble(stringarray[2]) / 100);
                    lbl_pas_factor.Text = ((double)Convert.ToInt32(stringarray[2]) / 100).ToString();
                    //poti stuff
                    lblPotiRaw.Text = stringarray[4];
                    tbPoti.Value = Convert.ToInt32(stringarray[4]);
                    if (tbPoti.Value < Convert.ToInt32(lblPotiMin.Text))
                        lblPotiMin.Text = stringarray[4];
                    if (tbPoti.Value > Convert.ToInt32(lblPotiMax.Text))
                        lblPotiMax.Text = stringarray[4];
                    //throttle stuff
                    lblThrottleRaw.Text = stringarray[5];
                    tbThrottle.Value = Convert.ToInt32(stringarray[5]);
                    if (tbThrottle.Value < Convert.ToInt32(lblThrottleMin.Text))
                        lblThrottleMin.Text = stringarray[5];
                    if (tbThrottle.Value > Convert.ToInt32(lblThrottleMax.Text))
                        lblThrottleMax.Text = stringarray[5];
                    //brake stuff
                    if (chb_brakeinverted.Checked)
                        rbBrake.Checked = Convert.ToBoolean(Convert.ToInt16(stringarray[6]));
                    else
                        rbBrake.Checked = !Convert.ToBoolean(Convert.ToInt16(stringarray[6]));
                    if (rbBrake.Checked)
                        rbBrake.Text = "braking";
                    else
                        rbBrake.Text = "not braking";
                }
                else
                {
                    tb_console.AppendText("\r\n" + stringtoparse);
                }
            }
            catch (Exception ex)
            {
                tb_console.AppendText("\r\n wrong serial format: " + stringtoparse);
            }

        }

        private void saveprofile()
        {
            System.IO.StreamWriter outfile = new System.IO.StreamWriter(configPath + @"\" + cb_profile.Text + ".apc");
            outfile.WriteLine("apc_version;"+ appVersion);
            var elements = GetAll(this, typeof(NumericUpDown)); //numeric updowns
            foreach (NumericUpDown nud in elements)
            {
                outfile.WriteLine(nud.Name + ";" + nud.Value.ToString());
            }

            elements = GetAll(this, typeof(CheckBox)); //checkboxes
            foreach (CheckBox cb in elements)
            {
                outfile.WriteLine(cb.Name + ";" + cb.Checked.ToString());
            }

            elements = GetAll(this, typeof(TextBox)); //textboxes
            foreach (TextBox txb in elements)
            {
                if (txb.Name.IndexOf("txb") > -1)
                    outfile.WriteLine(txb.Name + ";" + txb.Text);
            }

            elements = GetAll(this, typeof(ComboBox)); //comboboxes
            foreach (ComboBox cb in elements)
            {
                if (!((cb.Name == "cb_serial") || (cb.Name == "cb_profile")))
                    outfile.WriteLine(cb.Name + ";" + cb.SelectedIndex.ToString());
            }

            outfile.WriteLine("cbts_disp1long;" + cbts_disp1long.SelectedIndex.ToString());
            outfile.WriteLine("cbts_disp1short;" + cbts_disp1short.SelectedIndex.ToString());
            outfile.WriteLine("cbts_disp2long;" + cbts_disp2long.SelectedIndex.ToString());
            outfile.WriteLine("cbts_disp2short;" + cbts_disp2short.SelectedIndex.ToString());
            outfile.WriteLine("cbts_throttleshort;" + cbts_throttleshort.SelectedIndex.ToString());
            outfile.WriteLine("cbts_throttlelong;" + cbts_throttlelong.SelectedIndex.ToString());
            outfile.WriteLine("cbts_menuup;" + cbts_menuup.SelectedIndex.ToString());
            outfile.WriteLine("cbts_menudown;" + cbts_menudown.SelectedIndex.ToString());
            outfile.WriteLine("cbts_potishort;" + cbts_potishort.SelectedIndex.ToString());
            outfile.WriteLine("cbts_potilong;" + cbts_potilong.SelectedIndex.ToString());

            outfile.WriteLine("tsmi_GRAPHIC;" + tsmi_GRAPHIC.Checked.ToString());
            outfile.WriteLine("tsmi_TIME;" + tsmi_TIME.Checked.ToString());
            outfile.WriteLine("tsmi_BATTERY;" + tsmi_BATTERY.Checked.ToString());
            outfile.WriteLine("tsmi_ENVIRONMENT;" + tsmi_ENVIRONMENT.Checked.ToString());
            outfile.WriteLine("tsmi_HUMAN;" + tsmi_HUMAN.Checked.ToString());
            outfile.WriteLine("tsmi_ODOMETER;" + tsmi_ODO.Checked.ToString());

            outfile.WriteLine("source_local;" + sourcePath_local);


            outfile.Close();
            tb_console.AppendText("\r\nprofile " + cb_profile.Text + " saved");
        }

        private void loadprofile(Boolean quiet=false)
        {
            string[] line;
            string readline;

            if (System.IO.File.Exists(configPath + @"\" + cb_profile.Text + ".apc"))
            {
                System.IO.StreamReader infile = new System.IO.StreamReader(configPath + @"\" + cb_profile.Text + ".apc");
                while((readline = infile.ReadLine()) != null)
                {
                    line = readline.Split(';');
                    if (line[0].IndexOf("apc_version") > -1) //this line gives APC version
                        if ((line[1] != appVersion)&&!quiet)
                            MessageBox.Show("Config file created with version " + line[1]+" of this software, but you are running version " + appVersion +". Take care!");
                    if (line[0].IndexOf("cb_") > -1) //control is a combobox
                        (this.Controls.Find(line[0], true).First() as ComboBox).SelectedIndex = Convert.ToInt16(line[1]);
                    Application.DoEvents();
                    if (line[0].IndexOf("chb_") > -1) //control is a checkbox
                        (this.Controls.Find(line[0], true).First() as CheckBox).Checked = Convert.ToBoolean(line[1]);
                    if (line[0].IndexOf("nud_") > -1) //control is a numeric updown
                        (this.Controls.Find(line[0], true).First() as NumericUpDown).Value = Convert.ToDecimal(line[1]);
                    if (line[0].IndexOf("txb_") > -1) //control is a textbox
                        (this.Controls.Find(line[0], true).First() as TextBox).Text = line[1];
                    if (line[0].IndexOf("cbts_") > -1) //control is a toolstripcombobox
                        switch (line[0])
                        {
                            case "cbts_disp1long":
                                cbts_disp1long.SelectedIndex = Convert.ToInt16(line[1]);
                                break;
                            case "cbts_disp1short":
                                cbts_disp1short.SelectedIndex = Convert.ToInt16(line[1]);
                                break;
                            case "cbts_disp2long":
                                cbts_disp2long.SelectedIndex = Convert.ToInt16(line[1]);
                                break;
                            case "cbts_disp2short":
                                cbts_disp2short.SelectedIndex = Convert.ToInt16(line[1]);
                                break;
                            case "cbts_throttlelong":
                                cbts_throttlelong.SelectedIndex = Convert.ToInt16(line[1]);
                                break;
                            case "cbts_throttleshort":
                                cbts_throttleshort.SelectedIndex = Convert.ToInt16(line[1]);
                                break;
                            case "cbts_menuup":
                                cbts_menuup.SelectedIndex = Convert.ToInt16(line[1]);
                                break;
                            case "cbts_menudown":
                                cbts_menudown.SelectedIndex = Convert.ToInt16(line[1]);
                                break;
                            case "cbts_potishort":
                                cbts_potishort.SelectedIndex = Convert.ToInt16(line[1]);
                                break;
                            case "cbts_potilong":
                                cbts_potilong.SelectedIndex = Convert.ToInt16(line[1]);
                                break;
                        }
                    if (line[0].IndexOf("tsmi_") > -1) //control is a toolstripmenuitem
                        switch (line[0])
                        {
                            case "tsmi_GRAPHIC":
                                tsmi_GRAPHIC.Checked = Convert.ToBoolean(line[1]);
                                break;
                            case "tsmi_TIME":
                                tsmi_TIME.Checked = Convert.ToBoolean(line[1]);
                                break;
                            case "tsmi_BATTERY":
                                tsmi_BATTERY.Checked = Convert.ToBoolean(line[1]);
                                break;
                            case "tsmi_ENVIRONMENT":
                                tsmi_ENVIRONMENT.Checked = Convert.ToBoolean(line[1]);
                                break;
                            case "tsmi_HUMAN":
                                tsmi_HUMAN.Checked = Convert.ToBoolean(line[1]);
                                break;
                            case "tsmi_ODOMETER":
                                tsmi_ODO.Checked = Convert.ToBoolean(line[1]);
                                break;  
                        }
                    if (line[0].IndexOf("source_local") > -1) //local source path found
                    {
                        sourcePath_local = line[1];
                        tssl_localpath.Text = "Local Source: " + sourcePath_local;
                    }

                }

                infile.Close();
                if (!quiet)
                    tb_console.AppendText("\r\nprofile "+cb_profile.Text+" loaded");

            }
        }

        private void chart_pas_Click(object sender, EventArgs e)
        {
            chart_pas.Series[0].Points.Clear();
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            saveprofile();
            listconfigprofiles();
        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            loadprofile(true);
            loadprofile();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(configPath + @"\" + cb_profile.Text + ".apc"))
            {
                DialogResult dialogResult = MessageBox.Show("Delete profile " + cb_profile.Text + " ?", "Comfirm delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    System.IO.File.Delete(configPath + @"\" + cb_profile.Text + ".apc");
                    tb_console.AppendText("\r\ndeleted profile "+ cb_profile.Text);
                    listconfigprofiles();
                    cb_profile.Text = "new Profile";
                }
               
            }

        }

        private void download_github_sources()
        {
            WebClient webClient = new WebClient();

                tb_console.AppendText("\r\ncleaning up sources");
                foreach (string directory in System.IO.Directory.EnumerateDirectories(sourcePath_online))
                {
                    System.IO.Directory.Delete(directory,true);
                }
                System.IO.Directory.CreateDirectory(sourcePath_online);
                tb_console.AppendText("...done\r\ndownloading sources");
                try{
                    System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                    webClient.DownloadFile("https://codeload.github.com/jenkie/Arduino-Pedelec-Controller/legacy.zip/apc" + appVersion, sourcePath_online + @"\git_down.zip");
            }
            catch (Exception ex)
                {
                    tb_console.AppendText("\r\n" + ex.Message);
                    tb_console.AppendText("\r\nusing old sources");
                }
                try
                {
                    System.IO.File.Copy(sourcePath_online + @"\git_down.zip", sourcePath_online + @"\git.zip", true);
                }
                catch (Exception ex)
                {
                }
                tb_console.AppendText("..done\r\nunzipping sources");
                try
                {
                    using (ZipFile zip1 = ZipFile.Read(sourcePath_online + @"\git.zip"))
                    {
                        // here, we extract every entry, but we could extract conditionally
                        // based on entry name, size, date, checkbox status, etc.  
                        foreach (ZipEntry e in zip1)
                        {
                            e.Extract(sourcePath_online, ExtractExistingFileAction.OverwriteSilently);
                        }
                    }
                    //ZipFile.ExtractToDirectory(sourcePath + @"\git.zip", sourcePath); //this works from .net framework 4.5 on!
                    System.IO.Directory.Move(System.IO.Directory.EnumerateDirectories(sourcePath_online).First() + @"\Arduino_Pedelec_Controller", sourcePath_online + @"\Arduino_Pedelec_Controller");
                }
                catch (Exception ex)
                {
                    tb_console.AppendText("\r\n" + ex.Message);
                    tb_console.AppendText("\r\ncould not extract sources");
                }

        }


        private void bt_compile_Click(object sender, EventArgs e)
        {
            try
            {
                bt_disconnect_menu_Click(sender, e);
                tb_console.Text = "";
                if (chb_online.Checked)
                {
                    download_github_sources();
                    tb_console.AppendText("\r\nsources ready");
                    System.IO.StreamWriter outfile = new System.IO.StreamWriter(sourcePath_online + @"\Arduino_Pedelec_Controller\config.h");
                    outfile.WriteLine(createconfigfile());
                    outfile.Close();
                }
                else
                {
                    tb_console.AppendText("\r\nusing local sources");
                    System.IO.StreamWriter outfile = new System.IO.StreamWriter(sourcePath_local + @"\config.h");
                    outfile.WriteLine(createconfigfile());
                    outfile.Close();
                }
                tb_console.AppendText("\r\nconfig.h generated");
                tb_console.AppendText("\r\nlaunched external uploader");
                if (chb_online.Checked)
                {
                    System.Diagnostics.Process.Start(sourcePath_online + @"\Arduino_Pedelec_Controller\Arduino_Pedelec_Controller.ino");
                }
                else
                {
                    System.Diagnostics.Process.Start(sourcePath_local + @"\Arduino_Pedelec_Controller.ino");
                }
            }
            catch (Exception ex)
            {
                tb_console.AppendText("\r\n" + ex.Message);
            }

        }

        private string createconfigfile()
        {
            string tempstring = "\n";
            tempstring+="//created with Arduino Pedelec Configurator "+appVersion+"\n";
            tempstring+="//profile "+cb_profile.Text + "\n";
            tempstring+="#define HARDWARE_REV " + nud_version.Value.ToString()+"\n";
            tempstring+="#ifndef CONFIG_H\n#define CONFIG_H\n#if ARDUINO < 100\n#include <WProgram.h>\n#else\n#include <Arduino.h>\n#endif\n";
            tempstring +="#include \"switches_action.h\"\n";
            tempstring += "#define DISPLAY_TYPE_NONE (1<<0)\n#define DISPLAY_TYPE_NOKIA_5PIN (1<<1)\n#define DISPLAY_TYPE_NOKIA_4PIN (1<<2)\n#define DISPLAY_TYPE_NOKIA (DISPLAY_TYPE_NOKIA_5PIN|DISPLAY_TYPE_NOKIA_4PIN)\n#define DISPLAY_TYPE_16X2_LCD_4BIT (1<<3)\n#define DISPLAY_TYPE_16X2_SERIAL (1<<6)\n#define DISPLAY_TYPE_16X2 (DISPLAY_TYPE_16X2_LCD_4BIT|DISPLAY_TYPE_16X2_SERIAL)\n#define DISPLAY_TYPE_BMS (1<<5)\n#define DISPLAY_TYPE_BMS3 (1<<7)\n#define DISPLAY_TYPE_KINGMETER_618U (1<<4)\n#define DISPLAY_TYPE_KINGMETER_901U (1<<8)\n#define DISPLAY_TYPE_KINGMETER (DISPLAY_TYPE_KINGMETER_618U|DISPLAY_TYPE_KINGMETER_901U)\n#define DISPLAY_TYPE_BAFANG_C961 (1<<9)\n#define DISPLAY_TYPE_BAFANG_C965 (1<<10)\n#define DISPLAY_TYPE_BAFANG_SW102 (1<<11)\n#define DISPLAY_TYPE_BAFANG (DISPLAY_TYPE_BAFANG_C961|DISPLAY_TYPE_BAFANG_C965|DISPLAY_TYPE_BAFANG_SW102)\n";
            switch (cb_display.SelectedIndex)
            {
                case 0:
                    tempstring+="#define DISPLAY_TYPE DISPLAY_TYPE_NONE\n";
                    break;
                case 1:
                    tempstring+="#define DISPLAY_TYPE DISPLAY_TYPE_NOKIA_4PIN\n";
                    break;
                case 2:
                    tempstring+="#define DISPLAY_TYPE DISPLAY_TYPE_NOKIA_5PIN\n";
                    break;
                case 3:
                    tempstring+="#define DISPLAY_TYPE DISPLAY_TYPE_16X2_LCD_4BIT\n";
                    break;
                case 4:
                    tempstring += "#define DISPLAY_TYPE DISPLAY_TYPE_16X2_SERIAL\n";
                    break;
                case 5:
                    tempstring += "#define DISPLAY_TYPE DISPLAY_TYPE_BMS\n";
                    break;
                case 6:
                    tempstring += "#define DISPLAY_TYPE DISPLAY_TYPE_BMS3\n";
                    break;
                case 7:
                    tempstring += "#define DISPLAY_TYPE DISPLAY_TYPE_KINGMETER_618U\n";
                    break;
                case 8:
                    tempstring += "#define DISPLAY_TYPE DISPLAY_TYPE_KINGMETER_901U\n";
                    break;
                case 9:
                    tempstring += "#define DISPLAY_TYPE DISPLAY_TYPE_BAFANG_C961\n";
                    break;
                case 10:
                    tempstring += "#define DISPLAY_TYPE DISPLAY_TYPE_BAFANG_C965\n";
                    break;
                case 11:
                    tempstring += "#define DISPLAY_TYPE DISPLAY_TYPE_BAFANG_SW102\n";
                    break;
            }
            if (nud_version.Value < 20)
            {
                tempstring += "const int serial_display_16x2_pin = 10;\n";
                tempstring += "const int serial_display_16x2_second_unused_pin = 11;\n";
            }
            else
            {
                tempstring += "const int serial_display_16x2_pin = 17;\n";
                tempstring += "const int serial_display_16x2_second_unused_pin = 16;\n";
            }

            tempstring+="#define NOKIA_LCD_CONTRAST " + nud_display_contrast.Value.ToString()+"\n";

            if (tsmi_BATTERY.Checked)
                tempstring += "#define DV_BATTERY\n";
            if (tsmi_GRAPHIC.Checked)
                tempstring += "#define DV_GRAPHIC\n";
            if (tsmi_TIME.Checked)
                tempstring += "#define DV_TIME\n";
            if (tsmi_ENVIRONMENT.Checked)
                tempstring += "#define DV_ENVIRONMENT\n";
            if (tsmi_HUMAN.Checked)
                tempstring += "#define DV_HUMAN\n";
            if (tsmi_ODO.Checked)
                tempstring += "#define DV_ODOMETER\n";

            tempstring += "#define SERIAL_MODE_NONE (1<<0)\n#define SERIAL_MODE_DEBUG (1<<1)\n#define SERIAL_MODE_ANDROID (1<<2)\n#define SERIAL_MODE_MMC (1<<3)\n#define SERIAL_MODE_LOGVIEW (1<<4)\n#define SERIAL_MODE_IOS (1<<5)\n#define SERIAL_MODE_DISPLAYDEBUG    (1<<6)\n";
            switch (cb_serialmode.SelectedIndex)
            {
                case 0:
                    tempstring+="#define SERIAL_MODE SERIAL_MODE_DEBUG\n";
                    break;
                case 1:
                    tempstring+="#define SERIAL_MODE SERIAL_MODE_NONE\n";
                    break;
                case 2:
                    tempstring+="#define SERIAL_MODE SERIAL_MODE_ANDROID\n";
                    break;
                case 3:
                    tempstring+="#define SERIAL_MODE SERIAL_MODE_MMC\n";
                    break;
                case 4:
                    tempstring+="#define SERIAL_MODE SERIAL_MODE_LOGVIEW\n";
                    break;
                case 5:
                    tempstring += "#define SERIAL_MODE SERIAL_MODE_IOS\n";
                    break;
                case 6:
                    tempstring += "#define SERIAL_MODE SERIAL_MODE_DISPLAYDEBUG\n";
                    break;
            }

            tempstring += "#define BLUETOOTH_MODE_NONE (1<<0)\n#define BLUETOOTH_MODE_DEBUG (1<<1)\n#define BLUETOOTH_MODE_ANDROID (1<<2)\n#define BLUETOOTH_MODE_MMC (1<<3)\n#define BLUETOOTH_MODE_LOGVIEW (1<<4)\n#define BLUETOOTH_MODE_IOS (1<<5)\n#define BLUETOOTH_MODE_DISPLAYDEBUG (1<<6)\n";
            switch (cb_bluetoothmode.SelectedIndex)
            {
                case 0:
                    tempstring += "#define BLUETOOTH_MODE BLUETOOTH_MODE_DEBUG\n";
                    break;
                case 1:
                    tempstring += "#define BLUETOOTH_MODE BLUETOOTH_MODE_NONE\n";
                    break;
                case 2:
                    tempstring += "#define BLUETOOTH_MODE BLUETOOTH_MODE_ANDROID\n";
                    break;
                case 3:
                    tempstring += "#define BLUETOOTH_MODE BLUETOOTH_MODE_MMC\n";
                    break;
                case 4:
                    tempstring += "#define BLUETOOTH_MODE BLUETOOTH_MODE_LOGVIEW\n";
                    break;
                case 5:
                    tempstring += "#define BLUETOOTH_MODE BLUETOOTH_MODE_IOS\n";
                    break;
                case 6:
                    tempstring += "#define BLUETOOTH_MODE BLUETOOTH_MODE_DISPLAYDEBUG\n";
                    break;
            }



            if (chb_bluetoothstartup.Checked)
                tempstring += "#define SUPPORT_BLUETOOTH_ENABLE_ON_STARTUP\n";



            tempstring += "const switch_name MENU_BUTTON_UP = " + cbts_menuup.Text + ";\n";
            tempstring += "const switch_name MENU_BUTTON_DOWN = " + cbts_menudown.Text + ";\n";
            tempstring += "const sw_action SW_THROTTLE_SHORT_PRESS =" + cbts_throttleshort.Text + ";\n";
            tempstring += "const sw_action SW_THROTTLE_LONG_PRESS =" + cbts_throttlelong.Text + ";\n";
            tempstring += "const sw_action SW_DISPLAY1_SHORT_PRESS =" + cbts_disp1short.Text + ";\n";
            tempstring += "const sw_action SW_DISPLAY1_LONG_PRESS =" + cbts_disp1long.Text + ";\n";
            tempstring += "const sw_action SW_DISPLAY2_SHORT_PRESS =" + cbts_disp2short.Text + ";\n";
            tempstring += "const sw_action SW_DISPLAY2_LONG_PRESS =" + cbts_disp2long.Text + ";\n";
            tempstring += "const sw_action SW_POTI_SHORT_PRESS =" + cbts_potishort.Text + ";\n";
            tempstring += "const sw_action SW_POTI_LONG_PRESS =" + cbts_potilong.Text + ";\n";

            if (chb_backlight.Checked)
                tempstring+="#define SUPPORT_DISPLAY_BACKLIGHT\n const int display_backlight_pin = 12;\n";
            if (chb_bmp085.Checked)
                tempstring+="#define SUPPORT_BMP085\n";
            if (chb_dspc01.Checked)
                tempstring += "#define SUPPORT_DSPC01\n";
            if (chb_HRMI.Checked)
                tempstring+="#define SUPPORT_HRMI\n";
            if (chb_rtc.Checked)
                tempstring += "#define SUPPORT_RTC\n";

            if (chb_lightswitch.Checked)
            {
                tempstring += "#define SUPPORT_LIGHTS_SWITCH\n";
                if (chb_lightswitch_startup.Checked)
                    tempstring += "#define SUPPORT_LIGHTS_ENABLE_ON_STARTUP\n";
                if (chb_lightswitch_menu.Checked)
                    tempstring += "#define SUPPORT_LIGHTS_SWITCH_MENU\n";
            }
            switch (cb_controls.SelectedIndex)
            {
                case 1:
                    tempstring+="#define SUPPORT_POTI \n";
                    break;
                case 2:
                    tempstring+="#define SUPPORT_SOFT_POTI\n";
                    break;
                case 3:
                    tempstring += "#define SUPPORT_POTI_SWITCHES\n";
                    break;
            }
            if (chb_switchonpoti.Checked)
                tempstring += "#define SUPPORT_SWITCH_ON_POTI_PIN\n";
            tempstring += "const int poti_level_step_size_in_watts = " + nud_stepsize.Value.ToString() + ";\n";
            tempstring += "const int poti_value_on_startup_in_watts = " + nud_poti_startup.Value.ToString() + ";\n";
            tempstring += "const int fixed_throttle_in_watts = " +nud_fixed_throttle.Value.ToString() + ";\n";
            tempstring += "const int poti_fixed_value_via_switch = " + nud_fixedsoftpoti.Value.ToString() + ";\n";
            if (chb_autocruise.Checked)
            {
                tempstring += "#define SUPPORT_THROTTLE_AUTO_CRUISE\n";
            }

            if (chb_throttle.Checked)
                tempstring+="#define SUPPORT_THROTTLE\n";
            if (chb_brake.Checked)
            {
                tempstring += "#define SUPPORT_BRAKE\n";
                if (chb_brakeinverted.Checked)
                    tempstring += "#define INVERT_BRAKE\n";
            }

            if (chb_resetintegral.Checked)
                tempstring += "#define RESET_PID_ON_BRAKE\n";

             if (chb_brokensensor.Checked)
            {
                tempstring += "#define DETECT_BROKEN_SPEEDSENSOR\n";
            }
           
            if (chb_firstaid.Checked)
            {
                tempstring += "#define SUPPORT_FIRST_AID_MENU\n";
            }
            if (chb_profilemenu.Checked)
            {
                tempstring += "#define SUPPORT_PROFILE_SWITCH_MENU\n";
            }
            if (cb_bottombracket.SelectedIndex>0)
                tempstring+="#define SUPPORT_PAS\n";
            if (cb_bottombracket.SelectedIndex == 2)
            {
                tempstring += "#define SUPPORT_XCELL_RT\n";
                tempstring += "const char msg_torquezero[] PROGMEM = \"Re-zero torque sensor\";\n";
            }
            if (cb_bottombracket.SelectedIndex == 3)
                tempstring += "#define SUPPORT_BBS\n";
            if (cb_bottombracket.SelectedIndex == 4)
            {
                tempstring += "#define SUPPORT_SEMPU_V1\n";
                tempstring += "const char msg_torquezero[] PROGMEM = \"Re-zero torque sensor\";\n";
            }
            if (cb_bottombracket.SelectedIndex == 5)
            {
                tempstring += "#define SUPPORT_SEMPU\n";
                tempstring += "const char msg_torquezero[] PROGMEM = \"Re-zero torque sensor\";\n";
            }
            if (chb_torque_throttle.Checked)
                tempstring += "#define SUPPORT_TORQUE_THROTTLE\n";
            tempstring += "const int torque_throttle_min=" + nud_torquethrottle_min.Value.ToString() + ";\n";
            tempstring += "const int torque_throttle_full=" + nud_torquethrottle_full.Value.ToString() + ";\n";
            tempstring += "#define TORQUE_ZERO " + nud_torque_zero.Value.ToString() + ";\n";
            if (chb_torquezero_auto.Checked)
                tempstring += "#define TORQUE_AUTOZERO\n";
            tempstring += "#define BBS_GEARCHANGEPAUSE " + nud_gearchangepause.Value.ToString() +"\n";
            tempstring += "#define CONTROL_MODE_NORMAL 0\n#define CONTROL_MODE_LIMIT_WH_PER_KM 1\n#define CONTROL_MODE_TORQUE 2\n";
            switch (cb_controlmode.SelectedIndex)
            {
                case 0:
                    tempstring+="#define CONTROL_MODE CONTROL_MODE_NORMAL\n";
                    break;
                case 1:
                    tempstring+="#define CONTROL_MODE CONTROL_MODE_LIMIT_WH_PER_KM\n";
                    break;
                case 2:
                    tempstring+="#define CONTROL_MODE CONTROL_MODE_TORQUE\n";
                    break;
            }
            if (chb_preguess.Checked)
            {
                tempstring += "#define SUPPORT_MOTOR_GUESS\n";
                tempstring += "const int spd_idle=" + nud_idlespeed.Value.ToString() + ";\n";
            }
            if (chb_motorservo.Checked)
            {
                tempstring += "#define SUPPORT_MOTOR_SERVO\n";
            }

            if (chb_chargedetection.Checked)
            {
                tempstring += "#define SUPPORT_BATTERY_CHARGE_DETECTION\n";
            }
            tempstring += "const byte battery_charged_min_voltage = " + nud_chargedetect_min.Value.ToString() + ";\n";

            if (chb_chargecounter.Checked)
            {
                tempstring += "#define SUPPORT_BATTERY_CHARGE_COUNTER\n";
            }

            if (chb_gearshift.Checked)
            {
                tempstring += "#define SUPPORT_GEAR_SHIFT\n";
                tempstring += "const char msg_gear_shift_low_gear[] PROGMEM = \"Low gear active\";\n"; 
                tempstring += "const char msg_gear_shift_high_gear[] PROGMEM = \"High gear active\";\n";
                tempstring += "const char msg_gear_shift_auto_selection[] PROGMEM = \"Auto gear shift\";\n";
            }
            tempstring += "const byte gear_shift_pin_low_gear = " + txb_lowgear.Text + ";\n";
            tempstring += "const byte gear_shift_pin_high_gear = " + txb_highgear.Text + ";\n";

            if (chb_DS1820.Checked)
                tempstring += "#define SUPPORT_TEMP_SENSOR\n";
            tempstring += "const byte temp_pin=" + txb_tempsensepin.Text + ";\n";

            if (chb_thermistor.Checked)
                tempstring += "#define SUPPORT_THERMISTOR\n";
            tempstring += "const byte thermistor_pin=" + txb_thermistorpin.Text + ";\n";
            tempstring += "const float thermistor_t0=" + (1 / nud_therm_t0.Value).ToString() + ";\n";
            tempstring += "const float thermistor_b=" + (1 / nud_therm_beta.Value).ToString() + ";\n";
            tempstring += "const float thermistor_r=" + nud_therm_r.Value.ToString() + ";\n";

            if (chb_thermistor_cutoff.Checked)
                tempstring += "#define SUPPORT_THERMISTOR_CUTOFF\n";
            tempstring += "const int temperature_cutoff_start=" + nud_temperature_cutoff_start.Value.ToString() + ";\n";
            tempstring += "const int temperature_cutoff_stop=" + nud_temperature_cutoff_stop.Value.ToString() + ";\n";


            tempstring += "const int pas_tolerance="+nud_pas_tolerance.Value.ToString()+";\n";
            tempstring+="const int throttle_offset=" + nud_throttle_min.Value.ToString() +";\n";
            tempstring+="const int throttle_max=" + nud_throttle_max.Value.ToString() +";\n";

            tempstring += "const int poti_offset=" + nud_poti_min.Value.ToString() + ";\n";
            tempstring += "const int poti_max=" + nud_poti_max.Value.ToString() + ";\n";

            tempstring+="const int motor_offset=" + nud_motor_min.Value.ToString() +";\n";
            tempstring+="const int motor_max=" + nud_motor_max.Value.ToString() +";\n";
            tempstring+="const boolean startingaidenable = " + chb_startingaid.Checked.ToString().ToLower() +";\n";
            tempstring+="const int startingaid_speed=" + nud_startingaid.Value.ToString() +";\n";
            tempstring+= "const float vmax=" + nud_vmax.Value.ToString() + ";\n";
            tempstring+="const float vcutoff=" + nud_vcutoff.Value.ToString() +";\n";
            tempstring+="const float vemergency_shutdown =" +  nud_vemergency.Value.ToString() +";\n";
            tempstring+="const float wheel_circumference =" + (nud_circumference.Value/1000).ToString() +";\n";
            tempstring+= "const byte wheel_magnets =" + (nud_magnetcount.Value).ToString() + ";\n";
            tempstring+="const int spd_max1=" + nud_speedcutoff_start.Value.ToString() +";\n";
            tempstring+="const int spd_max2=" + nud_speedcutoff_stop.Value.ToString() +";\n";
            tempstring+="const int power_max=" + nud_power_max.Value.ToString() +";\n";
            tempstring+="const int power_poti_max=" + nud_controlmode.Value.ToString() +";\n";
            tempstring+="const int thermal_limit=" + nud_power_thermal.Value.ToString() +";\n";
            tempstring+="const int thermal_safe_speed=" + nud_thermalsafespeed.Value.ToString() +";\n";
            tempstring+="const int whkm_max=" + nud_controlmode.Value.ToString()+";\n";
            tempstring+="const unsigned int idle_shutdown_secs =" + nud_idle_shutdown.Value.ToString()+ ";\n";
            tempstring+="const unsigned int menu_idle_timeout_secs =" + nud_menuidle.Value.ToString() + ";\n";
            tempstring+="const double capacity =" + nud_capacity.Value.ToString() +";\n";
            //config2-parameters
            tempstring += "const double capacity_2 =" + nud_capacity_2.Value.ToString() + ";\n";
            tempstring += "const int spd_max1_2=" + nud_speedcutoff_start_2.Value.ToString() + ";\n";
            tempstring += "const int spd_max2_2=" + nud_speedcutoff_stop_2.Value.ToString() + ";\n";
            tempstring += "const int power_max_2=" + nud_power_max_2.Value.ToString() + ";\n";
            tempstring += "const int power_poti_max_2=" + nud_controlmode_2.Value.ToString() + ";\n";
            tempstring += "const int startingaid_speed_2=" + nud_startingaid_2.Value.ToString() + ";\n";

            tempstring+="const double pas_factor_min=" + nud_pasfactor_min.Value.ToString() +";\n";
            tempstring+="const double pas_factor_max=" + nud_pasfactor_max.Value.ToString() +";\n";
            tempstring+="const int pas_magnets=" + nud_magnets.Value.ToString() + ";\n";
            tempstring+="const int pas_timeout=" + nud_pastimeout.Value.ToString() + ";\n";
            tempstring+="const double cfg_pid_p=" + nud_pidp.Value.ToString()+ ";\n";
            tempstring+="const double cfg_pid_i=" + nud_pidi.Value.ToString()+ ";\n";
            tempstring+="const double cfg_pid_p_throttle =" + nud_pidp_throttle.Value.ToString()+ ";\n";
            tempstring+= "const double cfg_pid_i_throttle =" + nud_pidi_throttle.Value.ToString()+ ";\n";
            tempstring+="const byte pulse_min=" + nud_bpm_min.Value.ToString() +";\n";
            tempstring+="const byte pulse_range=" + (nud_bpm_max.Value-nud_bpm_min.Value).ToString() +";\n";
            tempstring+="const float voltage_amplitude=" + nud_voltage_amplitude.Value.ToString() +";\n";
            tempstring+="const float voltage_offset=" + nud_voltage_offset.Value.ToString() +";\n";
            tempstring+="const float current_amplitude_R11=" + nud_current_amplitude.Value.ToString() + ";\n";
            tempstring+="const float current_amplitude_R13=" + nud_current_amplitude.Value.ToString() + ";\n";
            tempstring+="const float current_amplitude_R22=" + nud_current_amplitude.Value.ToString() + ";\n";
            tempstring+="const float current_offset=" + nud_current_offset.Value.ToString() +";\n";
            if (chb_external_current.Checked)
                tempstring += "#define USE_EXTERNAL_CURRENT_SENSOR\n";
            if (chb_external_voltage.Checked)
                tempstring += "#define USE_EXTERNAL_VOLTAGE_SENSOR\n";
            tempstring+="const float external_voltage_offset ="+nud_external_voltage_offset.Value.ToString()+";\n";
            tempstring+="const float external_voltage_amplitude ="+nud_external_voltage_amplitude.Value.ToString() +";\n";          
            tempstring+="const float external_current_offset ="+nud_external_current_offset.Value.ToString()+";\n";
            tempstring+="const float external_current_amplitude ="+nud_external_current_amplitude.Value.ToString()+";\n";
            tempstring += "const int external_current_in =" + txb_external_current.Text + ";\n";
            tempstring += "const int external_voltage_in =" + txb_external_voltage.Text + ";\n";


            tempstring += "const char msg_welcome[] PROGMEM = \"" + txb_welcometext.Text + "\";\n";
            tempstring += "const char msg_shutdown[] PROGMEM = \"" + txb_goodbye.Text + "\";\n";
            tempstring += "const char msg_battery_charged[] PROGMEM = \"Batt. charged! Resetting counters\";\n";
            tempstring += "const char msg_idle_shutdown[] PROGMEM = \"Idle shutdown. Good night.\";\n";
            tempstring += "const char msg_emergency_shutdown[] PROGMEM = \"Battery undervoltage detected. Emergency shutdown.\";\n";
            tempstring += "const char msg_tempomat_reset[] PROGMEM = \"Tempomat reset\";\n";
            tempstring += "const char msg_unknown_action[] PROGMEM = \"Unknown action!\";\n";
            tempstring += "const char msg_activated[] PROGMEM = \"Activated\";\n";
            tempstring += "const char msg_deactivated[] PROGMEM = \"Deactivated\";\n";
            
            
            
            tempstring+="#endif\n";

            return tempstring.Replace(',', '.').Replace('ä', ',');
        }



        private void nud_bpm_max_ValueChanged(object sender, EventArgs e)
        {
            if (!(nud_bpm_max.Value>nud_bpm_min.Value))
                nud_bpm_min.Value=nud_bpm_max.Value-1;
        }

        private void nud_bpm_min_ValueChanged(object sender, EventArgs e)
        {
            if (!(nud_bpm_max.Value > nud_bpm_min.Value))
                nud_bpm_max.Value = nud_bpm_min.Value + 1;
        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void cb_controlmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cb_controlmode.SelectedIndex)
            {
                case 0:
                    lbl_controlmode.Text = "Poti: max power\n";
                    nud_controlmode.Value = 500;
                    lbl_stepsize_unit.Text = "W";
                    lbl_startup_unit.Text = "W";
                    return;
                case 1:
                    lbl_controlmode.Text = "Poti: max wh/km\n";
                    nud_controlmode.Value = 30;
                    lbl_stepsize_unit.Text = "wh/km";
                    lbl_startup_unit.Text = "wh/km";
                    return;
                case 2:
                    lbl_controlmode.Text = "Poti: max %\n";
                    nud_controlmode.Value = 250;
                    cb_bottombracket.SelectedIndex = 2;
                    lbl_stepsize_unit.Text = "%";
                    lbl_startup_unit.Text = "%";
                    return;
            }
        }

        private void nud_version_ValueChanged(object sender, EventArgs e)
        {
            if (nud_version.Value < 3)
                nud_current_amplitude.Value = 0.0296M;
            else if (nud_version.Value < 22)
                nud_current_amplitude.Value = 0.0741M;
            else
                nud_current_amplitude.Value = 0.04887585533M;
            if (nud_version.Value == 6)
                nud_version.Value = 20;
            if (nud_version.Value == 19)
                nud_version.Value = 5;
            if (nud_version.Value < 20)
            {
                lbl_bluetoothmode.Visible = false;
                cb_bluetoothmode.Visible = false;
            }
            else
            {
                lbl_bluetoothmode.Visible = true;
                cb_bluetoothmode.Visible = true;
            }
        }


        private void panel13_MouseEnter(object sender, EventArgs e)
        {
            panel_display.BackColor = Color.DeepSkyBlue;

        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            panel_display.BackColor = SystemColors.Control;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel_controls.BackColor=desc_poti.BackColor = panel_controlmode.BackColor = Color.DeepSkyBlue; 
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel_controls.BackColor =desc_poti.BackColor=panel_controlmode.BackColor = SystemColors.Control;
        }

        private void panel14_MouseEnter(object sender, EventArgs e)
        {
            panel_throttle.BackColor =desc_throttle.BackColor= Color.DeepSkyBlue;
        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            panel_throttle.BackColor = desc_throttle.BackColor = SystemColors.Control;
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel_brake.BackColor = Color.DeepSkyBlue;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel_brake.BackColor = SystemColors.Control;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel_battery.BackColor = desc_voltage.BackColor=desc_current.BackColor= Color.DeepSkyBlue;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel_battery.BackColor = desc_voltage.BackColor =desc_current.BackColor = SystemColors.Control;
        }

        private void panel18_MouseEnter(object sender, EventArgs e)
        {
            panel_bottombracket.BackColor =desc_pas.BackColor= Color.DeepSkyBlue;
        }

        private void panel18_MouseLeave(object sender, EventArgs e)
        {
            panel_bottombracket.BackColor = desc_pas.BackColor = SystemColors.Control;
        }

        private void panel16_MouseEnter(object sender, EventArgs e)
        {
            panel_motor.BackColor =panel_power.BackColor= Color.DeepSkyBlue;
        }

        private void panel16_MouseLeave(object sender, EventArgs e)
        {
            panel_motor.BackColor = panel_power.BackColor = SystemColors.Control;
        }


        private void nud_speedcutoff_start_ValueChanged(object sender, EventArgs e)
        {
            if (!(nud_speedcutoff_stop.Value > nud_speedcutoff_start.Value))
                nud_speedcutoff_stop.Value = nud_speedcutoff_start.Value + 1;
            drawpowergraph();
        }

        private void nud_speedcutoff_stop_ValueChanged(object sender, EventArgs e)
        {
            if (!((sender as NumericUpDown).Value > nud_speedcutoff_start.Value))
                nud_speedcutoff_start.Value = (sender as NumericUpDown).Value - 1;
            drawpowergraph();
        }

        private void nud_vemergency_ValueChanged(object sender, EventArgs e)
        {
            if (nud_vcutoff.Value < nud_vemergency.Value)
                nud_vcutoff.Value = nud_vemergency.Value;
        }

        private void nud_vcutoff_ValueChanged(object sender, EventArgs e)
        {
            if (nud_vcutoff.Value < nud_vemergency.Value)
                nud_vemergency.Value = nud_vcutoff.Value;
        }

        private void nud_motor_min_ValueChanged(object sender, EventArgs e)
        {
            if (!chb_motorservo.Checked)
                {
                    if (nud_motor_min.Value>255)
                        nud_motor_min.Value=255;
                }
            if (!(nud_motor_max.Value>nud_motor_min.Value))
                nud_motor_max.Value=nud_motor_min.Value+1;
        }

        private void nud_motor_max_ValueChanged(object sender, EventArgs e)
        {
            if (!chb_motorservo.Checked)
            {
                if (nud_motor_max.Value > 255)
                    nud_motor_max.Value = 255;
            }
            if (!(nud_motor_max.Value > nud_motor_min.Value))
                nud_motor_min.Value = nud_motor_max.Value - 1;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rect_motor.Contains(e.Location))
               panel_motor.BackColor =panel_power.BackColor= Color.DeepSkyBlue;
            else
               panel_motor.BackColor = panel_power.BackColor = SystemColors.Control;

        }

        private void nud_vmax_ValueChanged(object sender, EventArgs e)
        {
            if (nud_vmax.Value < nud_vcutoff.Value)
                nud_vcutoff.Value = nud_vmax.Value;
        }

        private void chb_preguess_CheckedChanged(object sender, EventArgs e)
        {
            nud_idlespeed.Enabled = chb_preguess.Checked;
        }

        private void nud_speedcutoff_stop_2_ValueChanged(object sender, EventArgs e)
        {
            if (!((sender as NumericUpDown).Value > nud_speedcutoff_start_2.Value))
                nud_speedcutoff_start_2.Value = (sender as NumericUpDown).Value - 1;
            drawpowergraph();
        }

        private void nud_speedcutoff_start_2_ValueChanged(object sender, EventArgs e)
        {
            if (!(nud_speedcutoff_stop_2.Value > nud_speedcutoff_start_2.Value))
                nud_speedcutoff_stop_2.Value = nud_speedcutoff_start_2.Value + 1;
            drawpowergraph();
        }

        private void nud_power_max_2_ValueChanged(object sender, EventArgs e)
        {
            drawpowergraph();
        }

        private void bt_switch_profile_Click(object sender, EventArgs e)
        {
            if (bt_switch_profile.BackColor == Color.Blue)
            {
                bt_switch_profile.Text = "Show BLUE setup";
                bt_switch_profile.BackColor = Color.Red;
                bt_switch_profile.ForeColor = Color.Blue;
                nud_power_max.Visible = false;
                nud_speedcutoff_start.Visible = false;
                nud_speedcutoff_stop.Visible = false;
                nud_startingaid.Visible = false;
                nud_controlmode.Visible = false;
                nud_capacity.Visible = false;
                nud_power_max_2.Visible = true;
                nud_speedcutoff_start_2.Visible = true;
                nud_speedcutoff_stop_2.Visible = true;
                nud_startingaid_2.Visible = true;
                nud_controlmode_2.Visible = true;
                nud_capacity_2.Visible = true;
                drawpowergraph();
            }
            else
            {
                bt_switch_profile.Text = "Show RED setup";
                bt_switch_profile.BackColor = Color.Blue;
                bt_switch_profile.ForeColor = Color.Red;
                nud_power_max_2.Visible = false;
                nud_speedcutoff_start_2.Visible = false;
                nud_speedcutoff_stop_2.Visible = false;
                nud_startingaid_2.Visible = false;
                nud_controlmode_2.Visible = false;
                nud_capacity_2.Visible = false;
                nud_power_max.Visible = true;
                nud_speedcutoff_start.Visible = true;
                nud_speedcutoff_stop.Visible = true;
                nud_startingaid.Visible = true;
                nud_controlmode.Visible = true;
                nud_capacity.Visible = true;
                drawpowergraph();
            }
        }

        private void chb_online_CheckedChanged(object sender, EventArgs e)
        {
            chb_local.Checked = !chb_online.Checked;
            bt_source_local.Enabled = chb_local.Checked;

        }

        private void chb_local_CheckedChanged(object sender, EventArgs e)
        {
            chb_online.Checked = !chb_local.Checked;
            bt_source_local.Enabled = chb_local.Checked;

        }

        private void bt_source_local_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                sourcePath_local = Path.GetDirectoryName(openFileDialog.FileName);
                tb_console.AppendText("\r\nSelected local source:\r\n");
                tb_console.AppendText(sourcePath_local);
                tssl_localpath.Text = "Local Source: "+sourcePath_local;
            }
        }

        private void cb_controls_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            0 none
            1 poti
            2 soft-poti
            3 up-down-switches
             */
            chb_switchonpoti.Visible=
            chb_switchonpoti.Checked =
            nud_stepsize.Visible=
            lbl_stepsize.Visible=
            lbl_stepsize_unit.Visible=
            nud_poti_max.Visible=
            nud_poti_min.Visible=
            lbl_poti_max.Visible=
            lbl_poti_min.Visible=
            lbl_poti_startup.Visible=
            nud_poti_startup.Visible=
            lbl_startup_unit.Visible =false;
            switch (cb_controls.SelectedIndex)
            {
                case 1:
                    lbl_poti_min.Visible = true;
                    lbl_poti_max.Visible = true;
                    nud_poti_min.Visible = true;
                    nud_poti_max.Visible = true;
                    chb_autocruise.Checked=false;
                    break;
                case 2:
                    lbl_poti_startup.Visible = true;
                    nud_poti_startup.Visible = true;
                    lbl_startup_unit.Visible = true;
                    chb_switchonpoti.Visible = true;
                    break;
                case 3:
                    lbl_poti_startup.Visible = true;
                    nud_poti_startup.Visible = true;
                    lbl_startup_unit.Visible = true;
                    lbl_stepsize.Visible = true;
                    lbl_stepsize_unit.Visible = true;
                    nud_stepsize.Visible = true;
                    chb_switchonpoti.Visible = true;
                    break;
            }

            chb_autocruise.Visible = (chb_throttle.Checked && (cb_controls.SelectedIndex > 1));

        }

        private void contextmenu_throttle_Opening(object sender, CancelEventArgs e)
        {

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (spArduino != null)
                if (spArduino.IsOpen)
                    spArduino.Close();
            timer1.Enabled = false;
            try
            {
                tb_console.AppendText("\r\ntrying to open " + cb_serial_menu.Text);
                spArduino = new SerialPort(cb_serial_menu.Text, 115200);
                spArduino.ReadTimeout = 5000;
                spArduino.Open();
                serialString = spArduino.ReadLine();
                if (serialString.Length > 0)
                    timer1.Enabled = true;
                tb_console.AppendText("...success");
                bt_connect_menu.Enabled = false;
                
            }
            catch (Exception ex)
            {
                if (spArduino != null)
                    if (spArduino.IsOpen)
                        spArduino.Close();
                timer1.Enabled = false;
                cb_serial_menu.Text = "Serial Port";

                tb_console.AppendText("\r\n" + ex.Message);
                bt_connect_menu.Enabled = true;

            }
   
        }

        private void bt_refresh_menu_Click(object sender, EventArgs e)
        {
            listserialports();
        }

        private void bt_disconnect_menu_Click(object sender, EventArgs e)
        {
            if (spArduino != null)
                if (spArduino.IsOpen)
                    spArduino.Close();
            timer1.Enabled = false;
            cb_serial_menu.Text = "Serial Port";
            tb_console.AppendText("\r\ndisconnected serial port");
            bt_connect_menu.Enabled = true;
        }

        private void setTotalKilometersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(spArduino == null || !spArduino.IsOpen)
                MessageBox.Show("Select and connect Serial Port first!");
            else
                try
                {
                    timer1.Enabled = false;
                    while(bwSerial.IsBusy)
                        Application.DoEvents();
                    spArduino.DiscardInBuffer();
                    string kilometerstring = "";
                    int repeats=0;
                    while (!kilometerstring.StartsWith("od") && repeats < 5)
                    {
                        repeats++;
                        spArduino.WriteLine("od?");
                        kilometerstring = spArduino.ReadLine();
                    }
                    spArduino.DiscardInBuffer();
                    timer1.Enabled = true;

                    if (!(repeats == 5))
                    {
                        int kilometers = 0;
                        try
                        {
                            kilometerstring = kilometerstring.Substring(kilometerstring.IndexOf("od") + 2);
                            kilometers = Convert.ToInt16(kilometerstring);
                        }
                        catch
                        {
                        }

                        FormInputBox Inputbox = new FormInputBox("Change total kilometers", kilometers);
                        if (Inputbox.ShowDialog() == DialogResult.OK)
                        {
                            spArduino.WriteLine("od" + Inputbox.kilometers.ToString());
                        }
                    }

                    
                }
                catch 
                { 
                }
        }

        private void chb_lightswitch_CheckedChanged(object sender, EventArgs e)
        {
            if (nud_version.Value<=5)
                if ((chb_lightswitch.Checked) && (cb_bottombracket.SelectedIndex == 2))
                {
                    chb_lightswitch.Checked = false;
                    MessageBox.Show("Please select different bottom bracket - not possible with Thun X-Cell RT");
                }
            chb_lightswitch_menu.Enabled = chb_lightswitch.Checked;
            chb_lightswitch_startup.Enabled = chb_lightswitch.Checked;
        }

        private void chb_rtc_CheckedChanged(object sender, EventArgs e)
        {
            bt_settime_menu.Enabled = chb_rtc.Checked;
        }

        private void bt_settime_menu_Click(object sender, EventArgs e)
        {
            if(spArduino == null || !spArduino.IsOpen)
                MessageBox.Show("Select and connect Serial Port first!");
            else
                try
                {
                    int repeats = 0;
                    timer1.Enabled = false;
                    while (bwSerial.IsBusy)
                        Application.DoEvents();
                    
                    while(!(repeats == 3))
                    {
                        System.Threading.Thread.Sleep(1000);
                        spArduino.DiscardInBuffer();
                        spArduino.WriteLine("hh" + DateTime.Now.Hour.ToString());
                        if (spArduino.ReadLine().StartsWith("hh"))
                            break;
                        repeats++;
                    }
                    repeats = 0;
                    while (!(repeats == 3))
                    {
                        System.Threading.Thread.Sleep(1000);
                        spArduino.DiscardInBuffer();
                        spArduino.WriteLine("mm" + DateTime.Now.Minute.ToString());
                        if (spArduino.ReadLine().StartsWith("mm"))
                            break;
                        repeats++;
                    }
                    repeats = 0;
                    while (!(repeats == 3))
                    {
                        System.Threading.Thread.Sleep(1000);
                        spArduino.DiscardInBuffer();
                        spArduino.WriteLine("ss" + DateTime.Now.Second.ToString());
                        if (spArduino.ReadLine().StartsWith("ss"))
                            break;
                        repeats++;
                    }
                    spArduino.DiscardInBuffer();
                    timer1.Enabled = true;
                    MessageBox.Show("Time successfully set to " + DateTime.Now.ToShortTimeString());
                }
                catch
                {
                }

        }

        private void chb_throttle_CheckedChanged(object sender, EventArgs e)
        {
            nud_throttle_max.Visible = nud_throttle_min.Visible = lbl_thr_min.Visible=lbl_thr_max.Visible=chb_throttle.Checked;
            chb_autocruise.Visible=(chb_throttle.Checked&&(cb_controls.SelectedIndex>1));
        }

        private void chb_chargedetection_CheckedChanged(object sender, EventArgs e)
        {
            nud_chargedetect_min.Visible = lbl_chargedetect_min.Visible = chb_chargedetection.Checked;
        }

        private void chb_gearshift_CheckedChanged(object sender, EventArgs e)
        {
            txb_lowgear.Enabled = txb_highgear.Enabled = chb_gearshift.Checked;
        }

        private void bt_setcounter_menu_Click(object sender, EventArgs e)
        {
            if (spArduino == null || !spArduino.IsOpen)
                MessageBox.Show("Select and connect Serial Port first!");
            else
                try
                {
                    timer1.Enabled = false;
                    while (bwSerial.IsBusy)
                        Application.DoEvents();
                    spArduino.DiscardInBuffer();
                    string counterstring = "";
                    int repeats = 0;
                    while (!counterstring.StartsWith("cc") && repeats < 5)
                    {
                        repeats++;
                        spArduino.WriteLine("cc?");
                        counterstring = spArduino.ReadLine();
                    }
                    spArduino.DiscardInBuffer();
                    timer1.Enabled = true;

                    if (!(repeats == 5))
                    {
                        int chargecounter = 0;
                        try
                        {
                            counterstring = counterstring.Substring(counterstring.IndexOf("cc") + 2);
                            chargecounter = Convert.ToInt16(counterstring);
                        }
                        catch
                        {
                        }

                        FormInputBox Inputbox = new FormInputBox("Change charge counter", chargecounter);
                        if (Inputbox.ShowDialog() == DialogResult.OK)
                        {
                            spArduino.WriteLine("cc" + Inputbox.kilometers.ToString());
                        }
                    }


                }
                catch
                {
                }
        }

        private void chb_motorservo_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_motorservo.Checked)
            {
                nud_motor_min.Value = 1000;
                nud_motor_max.Value = 2000;
            }
            else
            {
                nud_motor_max.Value = 200;
                nud_motor_min.Value = 50;
            }
        }

        private void panel_speedsensor_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            panel_speedsensor.BackColor =  Color.DeepSkyBlue;
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel_speedsensor.BackColor = SystemColors.Control;
        }

        private void chb_external_voltage_CheckedChanged(object sender, EventArgs e)
        {
            txb_external_voltage.Enabled = nud_external_voltage_amplitude.Visible=nud_external_voltage_offset.Visible = chb_external_voltage.Checked;
            nud_voltage_amplitude.Visible = nud_voltage_offset.Visible = !chb_external_voltage.Checked;

        }

        private void chb_external_current_CheckedChanged(object sender, EventArgs e)
        {
            txb_external_current.Enabled =nud_external_current_offset.Visible=nud_external_current_amplitude.Visible= chb_external_current.Checked;
            nud_current_offset.Visible = nud_current_amplitude.Visible = !chb_external_current.Checked;
        }

        private void tsmi_displayview_click(object sender, EventArgs e)
        {
            (sender as ToolStripMenuItem).Checked = !(sender as ToolStripMenuItem).Checked;
        }

        private void contextmenu_display_Opening(object sender, CancelEventArgs e)
        {

        }

        private void chb_torquezero_auto_CheckedChanged(object sender, EventArgs e)
        {
            nud_torque_zero.Enabled = !chb_torquezero_auto.Checked;
        }

        private void chb_thermistor_cutoff_CheckedChanged(object sender, EventArgs e)
        {
            if(!chb_thermistor.Checked)
            {
                chb_thermistor_cutoff.Checked = false;
                MessageBox.Show("Only possible if Thermistor is checked");
            }
        }

        private void lbl_torque_zero_Click(object sender, EventArgs e)
        {

        }

        private void nud_torque_zero_ValueChanged(object sender, EventArgs e)
        {

        }


        





        



    }
}
                
    

