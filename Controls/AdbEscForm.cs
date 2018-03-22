using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class AdbEscForm: Form
    {
        private TextBox textBox1;
        private ComboBox comboBox1;
        private int esc_id;
        private System.Windows.Forms.BindingSource BindingSourceAdbEsc;


        public AdbEscForm()
        {
            
            InitializeComponent();
            
        }

        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ESC 1",
            "ESC 2",
            "ESC 3",
            "ESC 4",
            "ESC 5",
            "ESC 6",
            "ESC 7",
            "ESC 8"});
            this.comboBox1.Location = new System.Drawing.Point(74, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // AdbEscForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "AdbEscForm";
            this.ResumeLayout(false);
            this.PerformLayout();
            //
            // BindingSourceAdbEsc
            //
            this.BindingSourceAdbEsc = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceAdbEsc)).BeginInit();
            this.BindingSourceAdbEsc.DataSource = typeof(MissionPlanner.CurrentState);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceAdbEsc)).BeginInit();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "ESC 1":
                    this.textBox1.DataBindings.Clear();
                    this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("airspeed", this.BindingSourceAdbEsc.DataSource, "airspeed", true));
                    break;
            }
        }
    }
}
