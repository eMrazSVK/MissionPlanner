using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class AdbEscView : Form
    {
        private IContainer components;
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

        public AdbEscView(BindingSource binding)
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

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_esc1_is = new System.Windows.Forms.TextBox();
            this.textBox_esc1_vbus = new System.Windows.Forms.TextBox();
            this.textBox_esc1_speed = new System.Windows.Forms.TextBox();
            this.textBox_esc1_temp = new System.Windows.Forms.TextBox();
            this.textBox_esc1_vs = new System.Windows.Forms.TextBox();
            this.textBox_esc1_pwm = new System.Windows.Forms.TextBox();
            this.textBox_esc2_is = new System.Windows.Forms.TextBox();
            this.textBox_esc2_temp = new System.Windows.Forms.TextBox();
            this.textBox_esc2_vbus = new System.Windows.Forms.TextBox();
            this.textBox_esc2_vs = new System.Windows.Forms.TextBox();
            this.textBox_esc2_speed = new System.Windows.Forms.TextBox();
            this.textBox_esc2_pwm = new System.Windows.Forms.TextBox();
            this.textBox_esc4_temp = new System.Windows.Forms.TextBox();
            this.textBox_esc4_is = new System.Windows.Forms.TextBox();
            this.textBox_esc4_vs = new System.Windows.Forms.TextBox();
            this.textBox_esc4_vbus = new System.Windows.Forms.TextBox();
            this.textBox_esc4_speed = new System.Windows.Forms.TextBox();
            this.textBox_esc4_pwm = new System.Windows.Forms.TextBox();
            this.textBox_esc3_vs = new System.Windows.Forms.TextBox();
            this.textBox_esc3_is = new System.Windows.Forms.TextBox();
            this.textBox_esc3_vbus = new System.Windows.Forms.TextBox();
            this.textBox_esc3_temp = new System.Windows.Forms.TextBox();
            this.textBox_esc3_speed = new System.Windows.Forms.TextBox();
            this.textBox_esc3_pwm = new System.Windows.Forms.TextBox();
            this.textBox_esc5_is = new System.Windows.Forms.TextBox();
            this.textBox_esc5_temp = new System.Windows.Forms.TextBox();
            this.textBox_esc5_vs = new System.Windows.Forms.TextBox();
            this.textBox_esc5_speed = new System.Windows.Forms.TextBox();
            this.textBox_esc5_vbus = new System.Windows.Forms.TextBox();
            this.textBox_esc5_pwm = new System.Windows.Forms.TextBox();
            this.textBox_esc6_vs = new System.Windows.Forms.TextBox();
            this.textBox_esc6_temp = new System.Windows.Forms.TextBox();
            this.textBox_esc6_is = new System.Windows.Forms.TextBox();
            this.textBox_esc6_vbus = new System.Windows.Forms.TextBox();
            this.textBox_esc6_speed = new System.Windows.Forms.TextBox();
            this.textBox_esc6_pwm = new System.Windows.Forms.TextBox();
            this.textBox_esc7_is = new System.Windows.Forms.TextBox();
            this.textBox_esc7_vbus = new System.Windows.Forms.TextBox();
            this.textBox_esc7_temp = new System.Windows.Forms.TextBox();
            this.textBox_esc7_speed = new System.Windows.Forms.TextBox();
            this.textBox_esc7_vs = new System.Windows.Forms.TextBox();
            this.textBox_esc7_pwm = new System.Windows.Forms.TextBox();
            this.textBox_esc8_temp = new System.Windows.Forms.TextBox();
            this.textBox_esc8_vbus = new System.Windows.Forms.TextBox();
            this.textBox_esc8_is = new System.Windows.Forms.TextBox();
            this.textBox_esc8_vs = new System.Windows.Forms.TextBox();
            this.textBox_esc8_speed = new System.Windows.Forms.TextBox();
            this.textBox_esc8_pwm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.Button_RefreshFrame = new MissionPlanner.Controls.MyButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_esc1_pwm);
            this.panel1.Controls.Add(this.textBox_esc1_speed);
            this.panel1.Controls.Add(this.textBox_esc1_vs);
            this.panel1.Controls.Add(this.textBox_esc1_vbus);
            this.panel1.Controls.Add(this.textBox_esc1_temp);
            this.panel1.Controls.Add(this.textBox_esc1_is);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.textBox_esc2_pwm);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.textBox_esc2_speed);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.textBox_esc2_vbus);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.textBox_esc2_vs);
            this.panel2.Controls.Add(this.textBox_esc2_is);
            this.panel2.Controls.Add(this.textBox_esc2_temp);
            this.panel2.Location = new System.Drawing.Point(218, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.textBox_esc3_pwm);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.textBox_esc3_vbus);
            this.panel3.Controls.Add(this.textBox_esc3_speed);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.textBox_esc3_vs);
            this.panel3.Controls.Add(this.textBox_esc3_temp);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.textBox_esc3_is);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Location = new System.Drawing.Point(12, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label32);
            this.panel4.Controls.Add(this.textBox_esc4_pwm);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox_esc4_speed);
            this.panel4.Controls.Add(this.label31);
            this.panel4.Controls.Add(this.textBox_esc4_temp);
            this.panel4.Controls.Add(this.textBox_esc4_vbus);
            this.panel4.Controls.Add(this.textBox_esc4_is);
            this.panel4.Controls.Add(this.label30);
            this.panel4.Controls.Add(this.textBox_esc4_vs);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.label27);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Location = new System.Drawing.Point(218, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label38);
            this.panel5.Controls.Add(this.textBox_esc5_pwm);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.textBox_esc5_speed);
            this.panel5.Controls.Add(this.textBox_esc5_vbus);
            this.panel5.Controls.Add(this.label37);
            this.panel5.Controls.Add(this.textBox_esc5_is);
            this.panel5.Controls.Add(this.textBox_esc5_temp);
            this.panel5.Controls.Add(this.textBox_esc5_vs);
            this.panel5.Controls.Add(this.label35);
            this.panel5.Controls.Add(this.label36);
            this.panel5.Controls.Add(this.label33);
            this.panel5.Controls.Add(this.label34);
            this.panel5.Location = new System.Drawing.Point(12, 224);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label44);
            this.panel6.Controls.Add(this.textBox_esc6_pwm);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.textBox_esc6_vs);
            this.panel6.Controls.Add(this.textBox_esc6_speed);
            this.panel6.Controls.Add(this.textBox_esc6_temp);
            this.panel6.Controls.Add(this.label43);
            this.panel6.Controls.Add(this.textBox_esc6_vbus);
            this.panel6.Controls.Add(this.textBox_esc6_is);
            this.panel6.Controls.Add(this.label42);
            this.panel6.Controls.Add(this.label39);
            this.panel6.Controls.Add(this.label40);
            this.panel6.Controls.Add(this.label41);
            this.panel6.Location = new System.Drawing.Point(218, 224);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label50);
            this.panel7.Controls.Add(this.textBox_esc7_pwm);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.textBox_esc7_speed);
            this.panel7.Controls.Add(this.textBox_esc7_vs);
            this.panel7.Controls.Add(this.textBox_esc7_is);
            this.panel7.Controls.Add(this.textBox_esc7_vbus);
            this.panel7.Controls.Add(this.label49);
            this.panel7.Controls.Add(this.textBox_esc7_temp);
            this.panel7.Controls.Add(this.label48);
            this.panel7.Controls.Add(this.label45);
            this.panel7.Controls.Add(this.label46);
            this.panel7.Controls.Add(this.label47);
            this.panel7.Location = new System.Drawing.Point(12, 330);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel8.Controls.Add(this.label56);
            this.panel8.Controls.Add(this.textBox_esc8_pwm);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.textBox_esc8_speed);
            this.panel8.Controls.Add(this.textBox_esc8_temp);
            this.panel8.Controls.Add(this.textBox_esc8_vs);
            this.panel8.Controls.Add(this.textBox_esc8_vbus);
            this.panel8.Controls.Add(this.textBox_esc8_is);
            this.panel8.Controls.Add(this.label55);
            this.panel8.Controls.Add(this.label54);
            this.panel8.Controls.Add(this.label51);
            this.panel8.Controls.Add(this.label52);
            this.panel8.Controls.Add(this.label53);
            this.panel8.Location = new System.Drawing.Point(218, 330);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 100);
            this.panel8.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESC 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ESC 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ESC 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ESC 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ESC 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ESC 6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ESC 7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "ESC 8";
            // 
            // textBox_esc1_is
            // 
            this.textBox_esc1_is.Location = new System.Drawing.Point(43, 19);
            this.textBox_esc1_is.Name = "textBox_esc1_is";
            this.textBox_esc1_is.ReadOnly = true;
            this.textBox_esc1_is.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc1_is.TabIndex = 1;
            // 
            // textBox_esc1_vbus
            // 
            this.textBox_esc1_vbus.Location = new System.Drawing.Point(43, 45);
            this.textBox_esc1_vbus.Name = "textBox_esc1_vbus";
            this.textBox_esc1_vbus.ReadOnly = true;
            this.textBox_esc1_vbus.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc1_vbus.TabIndex = 1;
            this.textBox_esc1_vbus.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc1_speed
            // 
            this.textBox_esc1_speed.Location = new System.Drawing.Point(43, 71);
            this.textBox_esc1_speed.Name = "textBox_esc1_speed";
            this.textBox_esc1_speed.ReadOnly = true;
            this.textBox_esc1_speed.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc1_speed.TabIndex = 1;
            // 
            // textBox_esc1_temp
            // 
            this.textBox_esc1_temp.Location = new System.Drawing.Point(129, 19);
            this.textBox_esc1_temp.Name = "textBox_esc1_temp";
            this.textBox_esc1_temp.ReadOnly = true;
            this.textBox_esc1_temp.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc1_temp.TabIndex = 1;
            // 
            // textBox_esc1_vs
            // 
            this.textBox_esc1_vs.Location = new System.Drawing.Point(129, 45);
            this.textBox_esc1_vs.Name = "textBox_esc1_vs";
            this.textBox_esc1_vs.ReadOnly = true;
            this.textBox_esc1_vs.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc1_vs.TabIndex = 1;
            this.textBox_esc1_vs.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc1_pwm
            // 
            this.textBox_esc1_pwm.Location = new System.Drawing.Point(129, 71);
            this.textBox_esc1_pwm.Name = "textBox_esc1_pwm";
            this.textBox_esc1_pwm.ReadOnly = true;
            this.textBox_esc1_pwm.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc1_pwm.TabIndex = 1;
            // 
            // textBox_esc2_is
            // 
            this.textBox_esc2_is.Location = new System.Drawing.Point(41, 19);
            this.textBox_esc2_is.Name = "textBox_esc2_is";
            this.textBox_esc2_is.ReadOnly = true;
            this.textBox_esc2_is.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc2_is.TabIndex = 1;
            // 
            // textBox_esc2_temp
            // 
            this.textBox_esc2_temp.Location = new System.Drawing.Point(127, 19);
            this.textBox_esc2_temp.Name = "textBox_esc2_temp";
            this.textBox_esc2_temp.ReadOnly = true;
            this.textBox_esc2_temp.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc2_temp.TabIndex = 1;
            // 
            // textBox_esc2_vbus
            // 
            this.textBox_esc2_vbus.Location = new System.Drawing.Point(41, 45);
            this.textBox_esc2_vbus.Name = "textBox_esc2_vbus";
            this.textBox_esc2_vbus.ReadOnly = true;
            this.textBox_esc2_vbus.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc2_vbus.TabIndex = 1;
            this.textBox_esc2_vbus.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc2_vs
            // 
            this.textBox_esc2_vs.Location = new System.Drawing.Point(127, 45);
            this.textBox_esc2_vs.Name = "textBox_esc2_vs";
            this.textBox_esc2_vs.ReadOnly = true;
            this.textBox_esc2_vs.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc2_vs.TabIndex = 1;
            this.textBox_esc2_vs.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc2_speed
            // 
            this.textBox_esc2_speed.Location = new System.Drawing.Point(41, 71);
            this.textBox_esc2_speed.Name = "textBox_esc2_speed";
            this.textBox_esc2_speed.ReadOnly = true;
            this.textBox_esc2_speed.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc2_speed.TabIndex = 1;
            // 
            // textBox_esc2_pwm
            // 
            this.textBox_esc2_pwm.Location = new System.Drawing.Point(127, 71);
            this.textBox_esc2_pwm.Name = "textBox_esc2_pwm";
            this.textBox_esc2_pwm.ReadOnly = true;
            this.textBox_esc2_pwm.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc2_pwm.TabIndex = 1;
            // 
            // textBox_esc4_temp
            // 
            this.textBox_esc4_temp.Location = new System.Drawing.Point(127, 16);
            this.textBox_esc4_temp.Name = "textBox_esc4_temp";
            this.textBox_esc4_temp.ReadOnly = true;
            this.textBox_esc4_temp.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc4_temp.TabIndex = 1;
            // 
            // textBox_esc4_is
            // 
            this.textBox_esc4_is.Location = new System.Drawing.Point(41, 16);
            this.textBox_esc4_is.Name = "textBox_esc4_is";
            this.textBox_esc4_is.ReadOnly = true;
            this.textBox_esc4_is.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc4_is.TabIndex = 1;
            // 
            // textBox_esc4_vs
            // 
            this.textBox_esc4_vs.Location = new System.Drawing.Point(127, 42);
            this.textBox_esc4_vs.Name = "textBox_esc4_vs";
            this.textBox_esc4_vs.ReadOnly = true;
            this.textBox_esc4_vs.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc4_vs.TabIndex = 1;
            this.textBox_esc4_vs.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc4_vbus
            // 
            this.textBox_esc4_vbus.Location = new System.Drawing.Point(41, 42);
            this.textBox_esc4_vbus.Name = "textBox_esc4_vbus";
            this.textBox_esc4_vbus.ReadOnly = true;
            this.textBox_esc4_vbus.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc4_vbus.TabIndex = 1;
            this.textBox_esc4_vbus.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc4_speed
            // 
            this.textBox_esc4_speed.Location = new System.Drawing.Point(41, 68);
            this.textBox_esc4_speed.Name = "textBox_esc4_speed";
            this.textBox_esc4_speed.ReadOnly = true;
            this.textBox_esc4_speed.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc4_speed.TabIndex = 1;
            // 
            // textBox_esc4_pwm
            // 
            this.textBox_esc4_pwm.Location = new System.Drawing.Point(127, 68);
            this.textBox_esc4_pwm.Name = "textBox_esc4_pwm";
            this.textBox_esc4_pwm.ReadOnly = true;
            this.textBox_esc4_pwm.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc4_pwm.TabIndex = 1;
            // 
            // textBox_esc3_vs
            // 
            this.textBox_esc3_vs.Location = new System.Drawing.Point(129, 42);
            this.textBox_esc3_vs.Name = "textBox_esc3_vs";
            this.textBox_esc3_vs.ReadOnly = true;
            this.textBox_esc3_vs.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc3_vs.TabIndex = 1;
            this.textBox_esc3_vs.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc3_is
            // 
            this.textBox_esc3_is.Location = new System.Drawing.Point(43, 16);
            this.textBox_esc3_is.Name = "textBox_esc3_is";
            this.textBox_esc3_is.ReadOnly = true;
            this.textBox_esc3_is.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc3_is.TabIndex = 1;
            // 
            // textBox_esc3_vbus
            // 
            this.textBox_esc3_vbus.Location = new System.Drawing.Point(43, 42);
            this.textBox_esc3_vbus.Name = "textBox_esc3_vbus";
            this.textBox_esc3_vbus.ReadOnly = true;
            this.textBox_esc3_vbus.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc3_vbus.TabIndex = 1;
            this.textBox_esc3_vbus.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc3_temp
            // 
            this.textBox_esc3_temp.Location = new System.Drawing.Point(129, 16);
            this.textBox_esc3_temp.Name = "textBox_esc3_temp";
            this.textBox_esc3_temp.ReadOnly = true;
            this.textBox_esc3_temp.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc3_temp.TabIndex = 1;
            // 
            // textBox_esc3_speed
            // 
            this.textBox_esc3_speed.Location = new System.Drawing.Point(43, 68);
            this.textBox_esc3_speed.Name = "textBox_esc3_speed";
            this.textBox_esc3_speed.ReadOnly = true;
            this.textBox_esc3_speed.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc3_speed.TabIndex = 1;
            // 
            // textBox_esc3_pwm
            // 
            this.textBox_esc3_pwm.Location = new System.Drawing.Point(129, 68);
            this.textBox_esc3_pwm.Name = "textBox_esc3_pwm";
            this.textBox_esc3_pwm.ReadOnly = true;
            this.textBox_esc3_pwm.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc3_pwm.TabIndex = 1;
            // 
            // textBox_esc5_is
            // 
            this.textBox_esc5_is.Location = new System.Drawing.Point(43, 15);
            this.textBox_esc5_is.Name = "textBox_esc5_is";
            this.textBox_esc5_is.ReadOnly = true;
            this.textBox_esc5_is.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc5_is.TabIndex = 1;
            // 
            // textBox_esc5_temp
            // 
            this.textBox_esc5_temp.Location = new System.Drawing.Point(129, 15);
            this.textBox_esc5_temp.Name = "textBox_esc5_temp";
            this.textBox_esc5_temp.ReadOnly = true;
            this.textBox_esc5_temp.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc5_temp.TabIndex = 1;
            // 
            // textBox_esc5_vs
            // 
            this.textBox_esc5_vs.Location = new System.Drawing.Point(129, 41);
            this.textBox_esc5_vs.Name = "textBox_esc5_vs";
            this.textBox_esc5_vs.ReadOnly = true;
            this.textBox_esc5_vs.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc5_vs.TabIndex = 1;
            this.textBox_esc5_vs.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc5_speed
            // 
            this.textBox_esc5_speed.Location = new System.Drawing.Point(43, 67);
            this.textBox_esc5_speed.Name = "textBox_esc5_speed";
            this.textBox_esc5_speed.ReadOnly = true;
            this.textBox_esc5_speed.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc5_speed.TabIndex = 1;
            // 
            // textBox_esc5_vbus
            // 
            this.textBox_esc5_vbus.Location = new System.Drawing.Point(43, 41);
            this.textBox_esc5_vbus.Name = "textBox_esc5_vbus";
            this.textBox_esc5_vbus.ReadOnly = true;
            this.textBox_esc5_vbus.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc5_vbus.TabIndex = 1;
            this.textBox_esc5_vbus.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc5_pwm
            // 
            this.textBox_esc5_pwm.Location = new System.Drawing.Point(129, 67);
            this.textBox_esc5_pwm.Name = "textBox_esc5_pwm";
            this.textBox_esc5_pwm.ReadOnly = true;
            this.textBox_esc5_pwm.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc5_pwm.TabIndex = 1;
            // 
            // textBox_esc6_vs
            // 
            this.textBox_esc6_vs.Location = new System.Drawing.Point(127, 41);
            this.textBox_esc6_vs.Name = "textBox_esc6_vs";
            this.textBox_esc6_vs.ReadOnly = true;
            this.textBox_esc6_vs.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc6_vs.TabIndex = 1;
            this.textBox_esc6_vs.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc6_temp
            // 
            this.textBox_esc6_temp.Location = new System.Drawing.Point(127, 15);
            this.textBox_esc6_temp.Name = "textBox_esc6_temp";
            this.textBox_esc6_temp.ReadOnly = true;
            this.textBox_esc6_temp.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc6_temp.TabIndex = 1;
            // 
            // textBox_esc6_is
            // 
            this.textBox_esc6_is.Location = new System.Drawing.Point(41, 15);
            this.textBox_esc6_is.Name = "textBox_esc6_is";
            this.textBox_esc6_is.ReadOnly = true;
            this.textBox_esc6_is.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc6_is.TabIndex = 1;
            // 
            // textBox_esc6_vbus
            // 
            this.textBox_esc6_vbus.Location = new System.Drawing.Point(41, 41);
            this.textBox_esc6_vbus.Name = "textBox_esc6_vbus";
            this.textBox_esc6_vbus.ReadOnly = true;
            this.textBox_esc6_vbus.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc6_vbus.TabIndex = 1;
            this.textBox_esc6_vbus.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc6_speed
            // 
            this.textBox_esc6_speed.Location = new System.Drawing.Point(41, 67);
            this.textBox_esc6_speed.Name = "textBox_esc6_speed";
            this.textBox_esc6_speed.ReadOnly = true;
            this.textBox_esc6_speed.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc6_speed.TabIndex = 1;
            // 
            // textBox_esc6_pwm
            // 
            this.textBox_esc6_pwm.Location = new System.Drawing.Point(127, 67);
            this.textBox_esc6_pwm.Name = "textBox_esc6_pwm";
            this.textBox_esc6_pwm.ReadOnly = true;
            this.textBox_esc6_pwm.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc6_pwm.TabIndex = 1;
            // 
            // textBox_esc7_is
            // 
            this.textBox_esc7_is.Location = new System.Drawing.Point(43, 13);
            this.textBox_esc7_is.Name = "textBox_esc7_is";
            this.textBox_esc7_is.ReadOnly = true;
            this.textBox_esc7_is.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc7_is.TabIndex = 1;
            // 
            // textBox_esc7_vbus
            // 
            this.textBox_esc7_vbus.Location = new System.Drawing.Point(43, 39);
            this.textBox_esc7_vbus.Name = "textBox_esc7_vbus";
            this.textBox_esc7_vbus.ReadOnly = true;
            this.textBox_esc7_vbus.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc7_vbus.TabIndex = 1;
            this.textBox_esc7_vbus.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc7_temp
            // 
            this.textBox_esc7_temp.Location = new System.Drawing.Point(129, 13);
            this.textBox_esc7_temp.Name = "textBox_esc7_temp";
            this.textBox_esc7_temp.ReadOnly = true;
            this.textBox_esc7_temp.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc7_temp.TabIndex = 1;
            // 
            // textBox_esc7_speed
            // 
            this.textBox_esc7_speed.Location = new System.Drawing.Point(43, 65);
            this.textBox_esc7_speed.Name = "textBox_esc7_speed";
            this.textBox_esc7_speed.ReadOnly = true;
            this.textBox_esc7_speed.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc7_speed.TabIndex = 1;
            // 
            // textBox_esc7_vs
            // 
            this.textBox_esc7_vs.Location = new System.Drawing.Point(129, 39);
            this.textBox_esc7_vs.Name = "textBox_esc7_vs";
            this.textBox_esc7_vs.ReadOnly = true;
            this.textBox_esc7_vs.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc7_vs.TabIndex = 1;
            this.textBox_esc7_vs.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc7_pwm
            // 
            this.textBox_esc7_pwm.Location = new System.Drawing.Point(129, 65);
            this.textBox_esc7_pwm.Name = "textBox_esc7_pwm";
            this.textBox_esc7_pwm.ReadOnly = true;
            this.textBox_esc7_pwm.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc7_pwm.TabIndex = 1;
            // 
            // textBox_esc8_temp
            // 
            this.textBox_esc8_temp.Location = new System.Drawing.Point(127, 13);
            this.textBox_esc8_temp.Name = "textBox_esc8_temp";
            this.textBox_esc8_temp.ReadOnly = true;
            this.textBox_esc8_temp.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc8_temp.TabIndex = 1;
            // 
            // textBox_esc8_vbus
            // 
            this.textBox_esc8_vbus.Location = new System.Drawing.Point(41, 39);
            this.textBox_esc8_vbus.Name = "textBox_esc8_vbus";
            this.textBox_esc8_vbus.ReadOnly = true;
            this.textBox_esc8_vbus.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc8_vbus.TabIndex = 1;
            this.textBox_esc8_vbus.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc8_is
            // 
            this.textBox_esc8_is.Location = new System.Drawing.Point(41, 13);
            this.textBox_esc8_is.Name = "textBox_esc8_is";
            this.textBox_esc8_is.ReadOnly = true;
            this.textBox_esc8_is.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc8_is.TabIndex = 1;
            // 
            // textBox_esc8_vs
            // 
            this.textBox_esc8_vs.Location = new System.Drawing.Point(127, 39);
            this.textBox_esc8_vs.Name = "textBox_esc8_vs";
            this.textBox_esc8_vs.ReadOnly = true;
            this.textBox_esc8_vs.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc8_vs.TabIndex = 1;
            this.textBox_esc8_vs.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_esc8_speed
            // 
            this.textBox_esc8_speed.Location = new System.Drawing.Point(41, 65);
            this.textBox_esc8_speed.Name = "textBox_esc8_speed";
            this.textBox_esc8_speed.ReadOnly = true;
            this.textBox_esc8_speed.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc8_speed.TabIndex = 1;
            // 
            // textBox_esc8_pwm
            // 
            this.textBox_esc8_pwm.Location = new System.Drawing.Point(127, 65);
            this.textBox_esc8_pwm.Name = "textBox_esc8_pwm";
            this.textBox_esc8_pwm.ReadOnly = true;
            this.textBox_esc8_pwm.Size = new System.Drawing.Size(31, 20);
            this.textBox_esc8_pwm.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Is";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Vbus";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Speed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(89, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Temp";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(104, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Vs";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(89, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "PWM";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Is";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Vbus";
            this.label16.Click += new System.EventHandler(this.label10_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(2, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Speed";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(89, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Temp";
            this.label18.Click += new System.EventHandler(this.label12_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(104, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Vs";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(89, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "PWM";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(26, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Is";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Vbus";
            this.label22.Click += new System.EventHandler(this.label10_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 71);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = "Speed";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(90, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 4;
            this.label24.Text = "Temp";
            this.label24.Click += new System.EventHandler(this.label12_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(105, 45);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(19, 13);
            this.label25.TabIndex = 5;
            this.label25.Text = "Vs";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(90, 71);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 6;
            this.label26.Text = "PWM";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(26, 19);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(15, 13);
            this.label27.TabIndex = 2;
            this.label27.Text = "Is";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(10, 45);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(31, 13);
            this.label28.TabIndex = 2;
            this.label28.Text = "Vbus";
            this.label28.Click += new System.EventHandler(this.label10_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 71);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(38, 13);
            this.label29.TabIndex = 3;
            this.label29.Text = "Speed";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(90, 19);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(34, 13);
            this.label30.TabIndex = 4;
            this.label30.Text = "Temp";
            this.label30.Click += new System.EventHandler(this.label12_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(105, 45);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(19, 13);
            this.label31.TabIndex = 5;
            this.label31.Text = "Vs";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(90, 71);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 13);
            this.label32.TabIndex = 6;
            this.label32.Text = "PWM";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(10, 44);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(31, 13);
            this.label33.TabIndex = 2;
            this.label33.Text = "Vbus";
            this.label33.Click += new System.EventHandler(this.label10_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(26, 18);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(15, 13);
            this.label34.TabIndex = 2;
            this.label34.Text = "Is";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 70);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(38, 13);
            this.label35.TabIndex = 3;
            this.label35.Text = "Speed";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(90, 18);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(34, 13);
            this.label36.TabIndex = 4;
            this.label36.Text = "Temp";
            this.label36.Click += new System.EventHandler(this.label12_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(105, 44);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(19, 13);
            this.label37.TabIndex = 5;
            this.label37.Text = "Vs";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(90, 70);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(34, 13);
            this.label38.TabIndex = 6;
            this.label38.Text = "PWM";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(26, 18);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(15, 13);
            this.label39.TabIndex = 2;
            this.label39.Text = "Is";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(10, 44);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(31, 13);
            this.label40.TabIndex = 2;
            this.label40.Text = "Vbus";
            this.label40.Click += new System.EventHandler(this.label10_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(90, 18);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(34, 13);
            this.label41.TabIndex = 4;
            this.label41.Text = "Temp";
            this.label41.Click += new System.EventHandler(this.label12_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(3, 70);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(38, 13);
            this.label42.TabIndex = 3;
            this.label42.Text = "Speed";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(105, 44);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(19, 13);
            this.label43.TabIndex = 5;
            this.label43.Text = "Vs";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(90, 70);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(34, 13);
            this.label44.TabIndex = 6;
            this.label44.Text = "PWM";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(90, 16);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(34, 13);
            this.label45.TabIndex = 4;
            this.label45.Text = "Temp";
            this.label45.Click += new System.EventHandler(this.label12_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(10, 42);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(31, 13);
            this.label46.TabIndex = 2;
            this.label46.Text = "Vbus";
            this.label46.Click += new System.EventHandler(this.label10_Click);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(26, 16);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(15, 13);
            this.label47.TabIndex = 2;
            this.label47.Text = "Is";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(3, 68);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(38, 13);
            this.label48.TabIndex = 3;
            this.label48.Text = "Speed";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(105, 42);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(19, 13);
            this.label49.TabIndex = 5;
            this.label49.Text = "Vs";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(90, 68);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(34, 13);
            this.label50.TabIndex = 6;
            this.label50.Text = "PWM";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(25, 16);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(15, 13);
            this.label51.TabIndex = 2;
            this.label51.Text = "Is";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(9, 42);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(31, 13);
            this.label52.TabIndex = 2;
            this.label52.Text = "Vbus";
            this.label52.Click += new System.EventHandler(this.label10_Click);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(89, 16);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(34, 13);
            this.label53.TabIndex = 4;
            this.label53.Text = "Temp";
            this.label53.Click += new System.EventHandler(this.label12_Click);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(2, 68);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(38, 13);
            this.label54.TabIndex = 3;
            this.label54.Text = "Speed";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(104, 42);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(19, 13);
            this.label55.TabIndex = 5;
            this.label55.Text = "Vs";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(89, 68);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(34, 13);
            this.label56.TabIndex = 6;
            this.label56.Text = "PWM";
            // 
            // Button_RefreshFrame
            // 
            this.Button_RefreshFrame.Location = new System.Drawing.Point(12, 436);
            this.Button_RefreshFrame.Name = "Button_RefreshFrame";
            this.Button_RefreshFrame.Size = new System.Drawing.Size(403, 23);
            this.Button_RefreshFrame.TabIndex = 8;
            this.Button_RefreshFrame.Text = "Refresh";
            this.Button_RefreshFrame.UseVisualStyleBackColor = true;
            this.Button_RefreshFrame.Click += new System.EventHandler(this.Button_RefreshFrame_Click);
            // 
            // AdbEscView
            // 
            this.ClientSize = new System.Drawing.Size(427, 462);
            this.Controls.Add(this.Button_RefreshFrame);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdbEscView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

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
    }
}
