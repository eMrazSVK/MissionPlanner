namespace MissionPlanner.Controls
{
    partial class AdbEscControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEscId = new System.Windows.Forms.Label();
            this.labelIs = new System.Windows.Forms.Label();
            this.labelVbus = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelVs = new System.Windows.Forms.Label();
            this.labelPwm = new System.Windows.Forms.Label();
            this.textBoxIs = new System.Windows.Forms.TextBox();
            this.textBoxVbus = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.textBoxVs = new System.Windows.Forms.TextBox();
            this.textBoxPwm = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Controls.Add(this.labelIs, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelVbus, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSpeed, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelTemp, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelVs, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelPwm, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxIs, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxVbus, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSpeed, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTemp, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxVs, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPwm, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelEscId, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelEscId
            // 
            this.labelEscId.AutoSize = true;
            this.labelEscId.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelEscId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEscId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)), true);
            this.labelEscId.Location = new System.Drawing.Point(180, 0);
            this.labelEscId.Margin = new System.Windows.Forms.Padding(0);
            this.labelEscId.Name = "labelEscId";
            this.labelEscId.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetRowSpan(this.labelEscId, 6);
            this.labelEscId.Size = new System.Drawing.Size(20, 120);
            this.labelEscId.TabIndex = 12;
            this.labelEscId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIs
            // 
            this.labelIs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelIs.AutoSize = true;
            this.labelIs.Location = new System.Drawing.Point(3, 3);
            this.labelIs.Name = "labelIs";
            this.labelIs.Size = new System.Drawing.Size(18, 13);
            this.labelIs.TabIndex = 0;
            this.labelIs.Text = "Is:";
            // 
            // labelVbus
            // 
            this.labelVbus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelVbus.AutoSize = true;
            this.labelVbus.Location = new System.Drawing.Point(3, 23);
            this.labelVbus.Name = "labelVbus";
            this.labelVbus.Size = new System.Drawing.Size(34, 13);
            this.labelVbus.TabIndex = 1;
            this.labelVbus.Text = "Vbus:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(3, 43);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(41, 13);
            this.labelSpeed.TabIndex = 2;
            this.labelSpeed.Text = "Speed:";
            // 
            // labelTemp
            // 
            this.labelTemp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(3, 63);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(37, 13);
            this.labelTemp.TabIndex = 3;
            this.labelTemp.Text = "Temp:";
            // 
            // labelVs
            // 
            this.labelVs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelVs.AutoSize = true;
            this.labelVs.Location = new System.Drawing.Point(3, 83);
            this.labelVs.Name = "labelVs";
            this.labelVs.Size = new System.Drawing.Size(22, 13);
            this.labelVs.TabIndex = 4;
            this.labelVs.Text = "Vs:";
            // 
            // labelPwm
            // 
            this.labelPwm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPwm.AutoSize = true;
            this.labelPwm.Location = new System.Drawing.Point(3, 103);
            this.labelPwm.Name = "labelPwm";
            this.labelPwm.Size = new System.Drawing.Size(33, 13);
            this.labelPwm.TabIndex = 5;
            this.labelPwm.Text = "Pwm:";
            // 
            // textBoxIs
            // 
            this.textBoxIs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxIs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIs.Location = new System.Drawing.Point(73, 3);
            this.textBoxIs.Name = "textBoxIs";
            this.textBoxIs.ReadOnly = true;
            this.textBoxIs.Size = new System.Drawing.Size(100, 13);
            this.textBoxIs.TabIndex = 6;
            // 
            // textBoxVbus
            // 
            this.textBoxVbus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxVbus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVbus.Location = new System.Drawing.Point(73, 23);
            this.textBoxVbus.Name = "textBoxVbus";
            this.textBoxVbus.ReadOnly = true;
            this.textBoxVbus.Size = new System.Drawing.Size(100, 13);
            this.textBoxVbus.TabIndex = 7;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSpeed.Location = new System.Drawing.Point(73, 43);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.ReadOnly = true;
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 13);
            this.textBoxSpeed.TabIndex = 8;
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTemp.Location = new System.Drawing.Point(73, 63);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.ReadOnly = true;
            this.textBoxTemp.Size = new System.Drawing.Size(100, 13);
            this.textBoxTemp.TabIndex = 9;
            // 
            // textBoxVs
            // 
            this.textBoxVs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxVs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVs.Location = new System.Drawing.Point(73, 83);
            this.textBoxVs.Name = "textBoxVs";
            this.textBoxVs.ReadOnly = true;
            this.textBoxVs.Size = new System.Drawing.Size(100, 13);
            this.textBoxVs.TabIndex = 10;
            // 
            // textBoxPwm
            // 
            this.textBoxPwm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPwm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPwm.Location = new System.Drawing.Point(73, 103);
            this.textBoxPwm.Name = "textBoxPwm";
            this.textBoxPwm.ReadOnly = true;
            this.textBoxPwm.Size = new System.Drawing.Size(100, 13);
            this.textBoxPwm.TabIndex = 11;
            // 
            // AdbEscControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdbEscControl";
            this.Size = new System.Drawing.Size(200, 120);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelIs;
        private System.Windows.Forms.Label labelVbus;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelVs;
        private System.Windows.Forms.Label labelPwm;
        private System.Windows.Forms.TextBox textBoxIs;
        private System.Windows.Forms.TextBox textBoxVbus;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.TextBox textBoxVs;
        private System.Windows.Forms.TextBox textBoxPwm;
        private System.Windows.Forms.Label labelEscId;
    }
}
