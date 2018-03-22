using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class adbFormForm: Form
    {
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private Label label6;
        private Panel panel7;
        private Label label7;
        private Panel panel8;
        private Label label8;
        private TextBox textBox_esc1_is;
        private TextBox textBox_esc1_speed;
        private TextBox textBox_esc1_vbus;
        private TextBox textBox_esc1_temp;
        private Label label10;
        private Label label9;
        private TextBox textBox_esc1_pwm;
        private TextBox textBox_esc2_pwm;
        private TextBox textBox_esc2_speed;
        private TextBox textBox_esc2_vbus;
        private TextBox textBox_esc2_vs;
        private TextBox textBox_esc2_is;
        private TextBox textBox_esc2_temp;
        private TextBox textBox_esc3_pwm;
        private TextBox textBox_esc3_vbus;
        private TextBox textBox_esc3_speed;
        private TextBox textBox_esc3_vs;
        private TextBox textBox_esc3_is;
        private TextBox textBox_esc4_pwm;
        private TextBox textBox_esc4_speed;
        private TextBox textBox_esc4_temp;
        private TextBox textBox_esc4_vbus;
        private TextBox textBox_esc4_is;
        private TextBox textBox_esc4_vs;
        private TextBox textBox_esc5_pwm;
        private TextBox textBox_esc5_speed;
        private TextBox textBox_esc5_vbus;
        private TextBox textBox_esc5_is;
        private TextBox textBox_esc5_temp;
        private TextBox textBox_esc5_vs;
        private TextBox textBox_esc6_pwm;
        private TextBox textBox_esc6_vs;
        private TextBox textBox_esc6_speed;
        private TextBox textBox_esc6_temp;
        private TextBox textBox_esc6_vbus;
        private TextBox textBox_esc6_is;
        private TextBox textBox_esc7_pwm;
        private TextBox textBox_esc7_speed;
        private TextBox textBox_esc7_vs;
        private TextBox textBox_esc7_is;
        private TextBox textBox_esc7_vbus;
        private TextBox textBox_esc7_temp;
        private TextBox textBox_esc8_pwm;
        private TextBox textBox_esc8_speed;
        private TextBox textBox_esc8_temp;
        private TextBox textBox_esc8_vs;
        private TextBox textBox_esc8_vbus;
        private TextBox textBox_esc8_is;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label14;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label27;
        private Label label28;
        private Label label38;
        private Label label37;
        private Label label35;
        private Label label36;
        private Label label33;
        private Label label34;
        private Label label44;
        private Label label43;
        private Label label42;
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label50;
        private Label label49;
        private Label label48;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label56;
        private Label label55;
        private Label label54;
        private Label label51;
        private Label label52;
        private Label label53;
        private Controls.MyButton Button_RefreshFrame;
        private TextBox textBox_esc3_temp;
        private TextBox textBox_esc1_vs;
        private System.Windows.Forms.BindingSource BindingSourceAdbEsc;

        public adbFormForm(BindingSource binding)
        {
            this.BindingSourceAdbEsc = binding;
            InitializeComponent();

            this.panel1.BackColor = Color.Gray;
            this.panel2.BackColor = Color.Gray;
            this.panel3.BackColor = Color.Gray;
            this.panel4.BackColor = Color.Gray;
            this.panel5.BackColor = Color.Gray;
            this.panel6.BackColor = Color.Gray;
            this.panel7.BackColor = Color.Gray;
            this.panel8.BackColor = Color.Gray;


            // highlight only active ESCs
            switch (MainV2.comPort.MAV.aptype)
            {
                case MAVLink.MAV_TYPE.QUADROTOR:
                    this.panel1.BackColor = Color.YellowGreen;
                    this.panel2.BackColor = Color.YellowGreen;
                    this.panel3.BackColor = Color.YellowGreen;
                    this.panel4.BackColor = Color.YellowGreen;
                    break;
                case MAVLink.MAV_TYPE.HEXAROTOR:
                    this.panel1.BackColor = Color.YellowGreen;
                    this.panel2.BackColor = Color.YellowGreen;
                    this.panel3.BackColor = Color.YellowGreen;
                    this.panel4.BackColor = Color.YellowGreen;
                    this.panel5.BackColor = Color.YellowGreen;
                    this.panel6.BackColor = Color.YellowGreen;
                    break;
                case MAVLink.MAV_TYPE.OCTOROTOR:
                    this.panel1.BackColor = Color.YellowGreen;
                    this.panel2.BackColor = Color.YellowGreen;
                    this.panel3.BackColor = Color.YellowGreen;
                    this.panel4.BackColor = Color.YellowGreen;
                    this.panel5.BackColor = Color.YellowGreen;
                    this.panel6.BackColor = Color.YellowGreen;
                    this.panel7.BackColor = Color.YellowGreen;
                    this.panel8.BackColor = Color.YellowGreen;
                    break;
            }

            Bind_DataToTextBoxes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            switch (comboBox1.Text)
            {
                case "ESC 1":
                    this.label1.DataBindings.Clear();
                    this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc, "adb_esc_id", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
                    this.textBox1.DataBindings.Clear();
                    this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc, "adb_esc_vbus_1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
                    break;
            }
            */
        }

        private void mainloop()
        {
            // typ konfiguracie (QUAD, OCTA etc) ->  MainV2.comPort.MAV.aptype;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Button_RefreshFrame_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Gray;
            panel2.BackColor = Color.Gray;
            panel3.BackColor = Color.Gray;
            panel4.BackColor = Color.Gray;
            panel5.BackColor = Color.Gray;
            panel6.BackColor = Color.Gray;
            panel7.BackColor = Color.Gray;
            panel8.BackColor = Color.Gray;

            // highlight only active ESCs
            switch (MainV2.comPort.MAV.aptype)
            {
                case MAVLink.MAV_TYPE.QUADROTOR:
                    panel1.BackColor = Color.YellowGreen;
                    panel2.BackColor = Color.YellowGreen;
                    panel3.BackColor = Color.YellowGreen;
                    panel4.BackColor = Color.YellowGreen;
                    break;
                case MAVLink.MAV_TYPE.HEXAROTOR:
                    panel1.BackColor = Color.YellowGreen;
                    panel2.BackColor = Color.YellowGreen;
                    panel3.BackColor = Color.YellowGreen;
                    panel4.BackColor = Color.YellowGreen;
                    panel5.BackColor = Color.YellowGreen;
                    panel6.BackColor = Color.YellowGreen;
                    break;
                case MAVLink.MAV_TYPE.OCTOROTOR:
                    panel1.BackColor = Color.YellowGreen;
                    panel2.BackColor = Color.YellowGreen;
                    panel3.BackColor = Color.YellowGreen;
                    panel4.BackColor = Color.YellowGreen;
                    panel5.BackColor = Color.YellowGreen;
                    panel6.BackColor = Color.YellowGreen;
                    panel7.BackColor = Color.YellowGreen;
                    panel8.BackColor = Color.YellowGreen;
                    break;
            }

            Bind_DataToTextBoxes();

        }

        private void Bind_DataToTextBoxes()
        {
            this.textBox_esc1_is.DataBindings.Clear();
            this.textBox_esc1_vbus.DataBindings.Clear();
            this.textBox_esc1_speed.DataBindings.Clear();
            this.textBox_esc1_temp.DataBindings.Clear();
            this.textBox_esc1_vs.DataBindings.Clear();
            this.textBox_esc1_pwm.DataBindings.Clear();

            this.textBox_esc2_is.DataBindings.Clear();
            this.textBox_esc2_vbus.DataBindings.Clear();
            this.textBox_esc2_speed.DataBindings.Clear();
            this.textBox_esc2_temp.DataBindings.Clear();
            this.textBox_esc2_vs.DataBindings.Clear();
            this.textBox_esc2_pwm.DataBindings.Clear();

            this.textBox_esc3_is.DataBindings.Clear();
            this.textBox_esc3_vbus.DataBindings.Clear();
            this.textBox_esc3_speed.DataBindings.Clear();
            this.textBox_esc3_temp.DataBindings.Clear();
            this.textBox_esc3_vs.DataBindings.Clear();
            this.textBox_esc3_pwm.DataBindings.Clear();

            this.textBox_esc4_is.DataBindings.Clear();
            this.textBox_esc4_vbus.DataBindings.Clear();
            this.textBox_esc4_speed.DataBindings.Clear();
            this.textBox_esc4_temp.DataBindings.Clear();
            this.textBox_esc4_vs.DataBindings.Clear();
            this.textBox_esc4_pwm.DataBindings.Clear();

            this.textBox_esc5_is.DataBindings.Clear();
            this.textBox_esc5_vbus.DataBindings.Clear();
            this.textBox_esc5_speed.DataBindings.Clear();
            this.textBox_esc5_temp.DataBindings.Clear();
            this.textBox_esc5_vs.DataBindings.Clear();
            this.textBox_esc5_pwm.DataBindings.Clear();

            this.textBox_esc6_is.DataBindings.Clear();
            this.textBox_esc6_vbus.DataBindings.Clear();
            this.textBox_esc6_speed.DataBindings.Clear();
            this.textBox_esc6_temp.DataBindings.Clear();
            this.textBox_esc6_vs.DataBindings.Clear();
            this.textBox_esc6_pwm.DataBindings.Clear();

            this.textBox_esc7_is.DataBindings.Clear();
            this.textBox_esc7_vbus.DataBindings.Clear();
            this.textBox_esc7_speed.DataBindings.Clear();
            this.textBox_esc7_temp.DataBindings.Clear();
            this.textBox_esc1_vs.DataBindings.Clear();
            this.textBox_esc1_pwm.DataBindings.Clear();

            this.textBox_esc8_is.DataBindings.Clear();
            this.textBox_esc8_vbus.DataBindings.Clear();
            this.textBox_esc8_speed.DataBindings.Clear();
            this.textBox_esc8_temp.DataBindings.Clear();
            this.textBox_esc8_vs.DataBindings.Clear();
            this.textBox_esc8_pwm.DataBindings.Clear();


            switch (MainV2.comPort.MAV.aptype)
            {
                case MAVLink.MAV_TYPE.QUADROTOR:
                    this.textBox_esc1_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc1_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc1_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc1_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc1_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc1_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    break;

                case MAVLink.MAV_TYPE.HEXAROTOR:
                    this.textBox_esc1_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc1_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc1_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc1_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc1_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc1_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc5_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_5",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc5_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_5",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc5_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_5",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc5_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_5",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc5_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_5",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc5_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_5",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc6_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_6",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc6_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_6",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc6_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_6",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc6_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_6",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc6_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_6",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc6_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_6",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));

                    break;

                case MAVLink.MAV_TYPE.OCTOROTOR:
                    this.textBox_esc1_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc1_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc1_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc1_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc1_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc1_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_1",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc2_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_2",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc3_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_3",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc4_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_4",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc5_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_5",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc5_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_5",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc5_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_5",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc5_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_5",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc5_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_5",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc5_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_5",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc6_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_6",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc6_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_6",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc6_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_6",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc6_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_6",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc6_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_6",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc6_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_6",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc7_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_7",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc7_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_7",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc7_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_7",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc7_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_7",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc7_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_7",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc7_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_7",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc8_is.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_is_8",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc8_vs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vs_8",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc8_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_temp_8",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc8_vbus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_vbus_8",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc8_speed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_speed_8",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    this.textBox_esc8_pwm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BindingSourceAdbEsc,
                                                                                   "adb_esc_pwm_8",
                                                                                   true,
                                                                                   System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                   null,
                                                                                   "N2"));
                    break;

            }

        }

        public void RefreshConfigColors()
        {
            panel1.BackColor = Color.Gray;
            panel2.BackColor = Color.Gray;
            panel3.BackColor = Color.Gray;
            panel4.BackColor = Color.Gray;
            panel5.BackColor = Color.Gray;
            panel6.BackColor = Color.Gray;
            panel7.BackColor = Color.Gray;
            panel8.BackColor = Color.Gray;

            // highlight only active ESCs
            switch (MainV2.comPort.MAV.aptype)
            {
                case MAVLink.MAV_TYPE.QUADROTOR:
                    panel1.BackColor = Color.YellowGreen;
                    panel2.BackColor = Color.YellowGreen;
                    panel3.BackColor = Color.YellowGreen;
                    panel4.BackColor = Color.YellowGreen;
                    break;
                case MAVLink.MAV_TYPE.HEXAROTOR:
                    panel1.BackColor = Color.YellowGreen;
                    panel2.BackColor = Color.YellowGreen;
                    panel3.BackColor = Color.YellowGreen;
                    panel4.BackColor = Color.YellowGreen;
                    panel5.BackColor = Color.YellowGreen;
                    panel6.BackColor = Color.YellowGreen;
                    break;
                case MAVLink.MAV_TYPE.OCTOROTOR:
                    panel1.BackColor = Color.YellowGreen;
                    panel2.BackColor = Color.YellowGreen;
                    panel3.BackColor = Color.YellowGreen;
                    panel4.BackColor = Color.YellowGreen;
                    panel5.BackColor = Color.YellowGreen;
                    panel6.BackColor = Color.YellowGreen;
                    panel7.BackColor = Color.YellowGreen;
                    panel8.BackColor = Color.YellowGreen;
                    break;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // adbFormForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "adbFormForm";
            this.ResumeLayout(false);

        }
    }
}
