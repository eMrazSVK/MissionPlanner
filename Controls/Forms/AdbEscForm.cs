using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.Controls.Forms
{
    public partial class AdbEscForm: Form
    {
        private TableLayoutPanel tableLayoutPanel1;
        private AdbEscControl adbEscControl1;
        private AdbEscControl adbEscControl2;
        private AdbEscControl adbEscControl3;
        private AdbEscControl adbEscControl4;
        private AdbEscControl adbEscControl5;
        private AdbEscControl adbEscControl6;
        private AdbEscControl adbEscControl7;
        private AdbEscControl adbEscControl8;
        private Label labelFrameType;
        private BindingSource BindingSourceAdbEsc;
        private Panel panelImageFrame;
        private string FrameTypeString;

        public AdbEscForm(BindingSource source)
        {
            this.BindingSourceAdbEsc = source;
            InitializeComponent();
            this.SetColorsActiveEsc();
            this.SetFrameTypeLabel();
            this.SetBindings();
            this.SetImageLabelFrame();
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelFrameType = new System.Windows.Forms.Label();
            this.panelImageFrame = new System.Windows.Forms.Panel();
            this.adbEscControl1 = new MissionPlanner.Controls.AdbEscControl();
            this.adbEscControl2 = new MissionPlanner.Controls.AdbEscControl();
            this.adbEscControl3 = new MissionPlanner.Controls.AdbEscControl();
            this.adbEscControl4 = new MissionPlanner.Controls.AdbEscControl();
            this.adbEscControl5 = new MissionPlanner.Controls.AdbEscControl();
            this.adbEscControl6 = new MissionPlanner.Controls.AdbEscControl();
            this.adbEscControl7 = new MissionPlanner.Controls.AdbEscControl();
            this.adbEscControl8 = new MissionPlanner.Controls.AdbEscControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.adbEscControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.adbEscControl2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.adbEscControl3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.adbEscControl4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.adbEscControl5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.adbEscControl6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.adbEscControl7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.adbEscControl8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelImageFrame, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 35);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelFrameType
            // 
            this.labelFrameType.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFrameType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFrameType.Location = new System.Drawing.Point(0, 0);
            this.labelFrameType.Name = "labelFrameType";
            this.labelFrameType.Size = new System.Drawing.Size(655, 33);
            this.labelFrameType.TabIndex = 1;
            this.labelFrameType.Text = "label1";
            this.labelFrameType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelImageFrame
            // 
            this.panelImageFrame.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelImageFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelImageFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageFrame.Location = new System.Drawing.Point(216, 123);
            this.panelImageFrame.Margin = new System.Windows.Forms.Padding(1);
            this.panelImageFrame.Name = "panelImageFrame";
            this.panelImageFrame.Size = new System.Drawing.Size(211, 118);
            this.panelImageFrame.TabIndex = 8;
            // 
            // adbEscControl1
            // 
            this.adbEscControl1.AutoSize = true;
            this.adbEscControl1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adbEscControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adbEscControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adbEscControl1.Location = new System.Drawing.Point(2, 2);
            this.adbEscControl1.Margin = new System.Windows.Forms.Padding(1);
            this.adbEscControl1.Name = "adbEscControl1";
            this.adbEscControl1.Size = new System.Drawing.Size(211, 118);
            this.adbEscControl1.TabIndex = 0;
            // 
            // adbEscControl2
            // 
            this.adbEscControl2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adbEscControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adbEscControl2.Location = new System.Drawing.Point(216, 2);
            this.adbEscControl2.Margin = new System.Windows.Forms.Padding(1);
            this.adbEscControl2.Name = "adbEscControl2";
            this.adbEscControl2.Size = new System.Drawing.Size(211, 118);
            this.adbEscControl2.TabIndex = 1;
            // 
            // adbEscControl3
            // 
            this.adbEscControl3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adbEscControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adbEscControl3.Location = new System.Drawing.Point(430, 2);
            this.adbEscControl3.Margin = new System.Windows.Forms.Padding(1);
            this.adbEscControl3.Name = "adbEscControl3";
            this.adbEscControl3.Size = new System.Drawing.Size(213, 118);
            this.adbEscControl3.TabIndex = 2;
            // 
            // adbEscControl4
            // 
            this.adbEscControl4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adbEscControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adbEscControl4.Location = new System.Drawing.Point(2, 123);
            this.adbEscControl4.Margin = new System.Windows.Forms.Padding(1);
            this.adbEscControl4.Name = "adbEscControl4";
            this.adbEscControl4.Size = new System.Drawing.Size(211, 118);
            this.adbEscControl4.TabIndex = 3;
            // 
            // adbEscControl5
            // 
            this.adbEscControl5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adbEscControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adbEscControl5.Location = new System.Drawing.Point(430, 123);
            this.adbEscControl5.Margin = new System.Windows.Forms.Padding(1);
            this.adbEscControl5.Name = "adbEscControl5";
            this.adbEscControl5.Size = new System.Drawing.Size(213, 118);
            this.adbEscControl5.TabIndex = 4;
            // 
            // adbEscControl6
            // 
            this.adbEscControl6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adbEscControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adbEscControl6.Location = new System.Drawing.Point(2, 244);
            this.adbEscControl6.Margin = new System.Windows.Forms.Padding(1);
            this.adbEscControl6.Name = "adbEscControl6";
            this.adbEscControl6.Size = new System.Drawing.Size(211, 120);
            this.adbEscControl6.TabIndex = 5;
            // 
            // adbEscControl7
            // 
            this.adbEscControl7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adbEscControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adbEscControl7.Location = new System.Drawing.Point(216, 244);
            this.adbEscControl7.Margin = new System.Windows.Forms.Padding(1);
            this.adbEscControl7.Name = "adbEscControl7";
            this.adbEscControl7.Size = new System.Drawing.Size(211, 120);
            this.adbEscControl7.TabIndex = 6;
            // 
            // adbEscControl8
            // 
            this.adbEscControl8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adbEscControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adbEscControl8.Location = new System.Drawing.Point(430, 244);
            this.adbEscControl8.Margin = new System.Windows.Forms.Padding(1);
            this.adbEscControl8.Name = "adbEscControl8";
            this.adbEscControl8.Size = new System.Drawing.Size(213, 120);
            this.adbEscControl8.TabIndex = 7;
            // 
            // AdbEscForm
            // 
            this.ClientSize = new System.Drawing.Size(655, 404);
            this.Controls.Add(this.labelFrameType);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdbEscForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        // https://stackoverflow.com/questions/1922040/resize-an-image-c-sharp
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }


        private void SetImageLabelFrame()
        {
            Image FrameImage;
            Image FrameImage2;
            string FrameType = "";
            string path = System.Environment.CurrentDirectory;
            string path2 = path.Substring(0, path.LastIndexOf("bin")) + "Resources" + "\\frames-04.png";
            FrameImage = Image.FromFile(path2);
            FrameImage2 = (Image)ResizeImage(FrameImage, this.panelImageFrame.Height, panelImageFrame.Height);
            this.panelImageFrame.BackgroundImage = FrameImage2;

            if (MainV2.comPort.MAV.FrameString == "OCTA_QUAD")
            {
                path2 = path.Substring(0, path.LastIndexOf("bin")) + "Resources" + "\\FW icons 2013+logos-06.png";
                FrameImage = Image.FromFile(path2);
                FrameImage2 = (Image)ResizeImage(FrameImage, this.panelImageFrame.Height, panelImageFrame.Height);
                this.panelImageFrame.BackgroundImage = FrameImage2;
                return;
            }

            switch (MainV2.comPort.MAV.param["FRAME_TYPE"].ToString())
            {
                case "0":
                    FrameType = "+";
                    break;
                case "1":
                    FrameType = "X";
                    break;
                case "2":
                    FrameType = "V";
                    break;
                case "3":
                    FrameType = "H";
                    break;
                case "4":
                    FrameType = "V-Tail";
                    break;
                case "5":
                    FrameType = "A-Tail";
                    break;
                case "10":
                    FrameType = "Y6B";
                    break;
            }

            

            switch (MainV2.comPort.MAV.aptype)
            {
                case MAVLink.MAV_TYPE.QUADROTOR:
                    switch (FrameType)
                    {
                        case "+":
                            path2 = path.Substring(0, path.LastIndexOf("bin")) + "Resources" + "\\frames-03.png";
                            FrameImage = Image.FromFile(path2);
                            FrameImage2 = (Image)ResizeImage(FrameImage, this.panelImageFrame.Height, panelImageFrame.Height);
                            this.panelImageFrame.BackgroundImage = FrameImage2;
                            break;
                        case "X":
                            path2 = path.Substring(0, path.LastIndexOf("bin")) + "Resources" + "\\frames-04.png";
                            FrameImage = Image.FromFile(path2);
                            FrameImage2 = (Image)ResizeImage(FrameImage, this.panelImageFrame.Height, panelImageFrame.Height);
                            this.panelImageFrame.BackgroundImage = FrameImage2;
                            break;
                        case "H":
                            path2 = path.Substring(0, path.LastIndexOf("bin")) + "Resources" + "\\frames-h.png";
                            FrameImage = Image.FromFile(path2);
                            FrameImage2 = (Image)ResizeImage(FrameImage, this.panelImageFrame.Height, panelImageFrame.Height);
                            this.panelImageFrame.BackgroundImage = FrameImage2;
                            break;
                    }
                    break;
                case MAVLink.MAV_TYPE.HEXAROTOR:
                    switch (FrameType)
                    {
                        case "+":
                            path2 = path.Substring(0, path.LastIndexOf("bin")) + "Resources" + "\\frames-07.png";
                            FrameImage = Image.FromFile(path2);
                            FrameImage2 = (Image)ResizeImage(FrameImage, this.panelImageFrame.Height, panelImageFrame.Height);
                            this.panelImageFrame.BackgroundImage = FrameImage2;
                            break;
                        case "X":
                            path2 = path.Substring(0, path.LastIndexOf("bin")) + "Resources" + "\\frames-06.png";
                            FrameImage = Image.FromFile(path2);
                            FrameImage2 = (Image)ResizeImage(FrameImage, this.panelImageFrame.Height, panelImageFrame.Height);
                            this.panelImageFrame.BackgroundImage = FrameImage2;
                            break;
                    }
                    break;
                case MAVLink.MAV_TYPE.OCTOROTOR:
                    switch (FrameType)
                    {
                        case "+":
                            path2 = path.Substring(0, path.LastIndexOf("bin")) + "Resources" + "\\FW icons 2013+logos-11.png";
                            FrameImage = Image.FromFile(path2);
                            FrameImage2 = (Image)ResizeImage(FrameImage, this.panelImageFrame.Height, panelImageFrame.Height);
                            this.panelImageFrame.BackgroundImage = FrameImage2;
                            break;
                        case "X":
                            path2 = path.Substring(0, path.LastIndexOf("bin")) + "Resources" + "\\FW icons 2013+logos-12.png";
                            FrameImage = Image.FromFile(path2);
                            FrameImage2 = (Image)ResizeImage(FrameImage, this.panelImageFrame.Height, panelImageFrame.Height);
                            this.panelImageFrame.BackgroundImage = FrameImage2;
                            break;
                    }
                    break;
            }
           
        }

        private void SetFrameTypeLabel()
        {
            string FrameType, FrameClass;
            FrameType = "";
            FrameClass = "";
            try
            {
                FrameClass = MainV2.comPort.MAV.FrameString + " ";
            }
            catch (Exception e)
            {
                FrameClass = "";
            }
            
            try
            {
                switch (MainV2.comPort.MAV.param["FRAME_TYPE"].ToString())
                {
                    case "0":
                        FrameType = "+";
                        break;
                    case "1":
                        FrameType = "X";
                        break;
                    case "2":
                        FrameType = "V";
                        break;
                    case "3":
                        FrameType = "H";
                        break;
                    case "4":
                        FrameType = "V-Tail";
                        break;
                    case "5":
                        FrameType = "A-Tail";
                        break;
                    case "10":
                        FrameType = "Y6B";
                        break;
                }
            }
            catch (Exception e)
            {
                FrameType = "Error reading FRAME properties";
            }

            FrameTypeString = FrameClass + FrameType;
            this.labelFrameType.Text = FrameTypeString;
        }

        private void SetColorsActiveEsc()
        {
            this.adbEscControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adbEscControl2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adbEscControl3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adbEscControl4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adbEscControl5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adbEscControl6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adbEscControl7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adbEscControl8.BackColor = System.Drawing.SystemColors.ControlDarkDark;

            switch (MainV2.comPort.MAV.aptype)
            {
                case MAVLink.MAV_TYPE.TRICOPTER:
                    adbEscControl1.BackColor = Color.YellowGreen;
                    adbEscControl2.BackColor = Color.YellowGreen;
                    adbEscControl4.BackColor = Color.YellowGreen;
                    break;
                case MAVLink.MAV_TYPE.QUADROTOR:
                    adbEscControl1.BackColor = Color.YellowGreen;
                    adbEscControl2.BackColor = Color.YellowGreen;
                    adbEscControl3.BackColor = Color.YellowGreen;
                    adbEscControl4.BackColor = Color.YellowGreen;
                    break;
                case MAVLink.MAV_TYPE.HEXAROTOR:
                    adbEscControl1.BackColor = Color.YellowGreen;
                    adbEscControl2.BackColor = Color.YellowGreen;
                    adbEscControl3.BackColor = Color.YellowGreen;
                    adbEscControl4.BackColor = Color.YellowGreen;
                    adbEscControl5.BackColor = Color.YellowGreen;
                    adbEscControl6.BackColor = Color.YellowGreen;
                    break;
                case MAVLink.MAV_TYPE.OCTOROTOR:
                    adbEscControl1.BackColor = Color.YellowGreen;
                    adbEscControl2.BackColor = Color.YellowGreen;
                    adbEscControl3.BackColor = Color.YellowGreen;
                    adbEscControl4.BackColor = Color.YellowGreen;
                    adbEscControl5.BackColor = Color.YellowGreen;
                    adbEscControl6.BackColor = Color.YellowGreen;
                    adbEscControl7.BackColor = Color.YellowGreen;
                    adbEscControl8.BackColor = Color.YellowGreen;
                    break;
            }
        }

        private void SetBindings()
        {
            this.adbEscControl1.setEscId(1);
            this.adbEscControl1.setBindings(this.BindingSourceAdbEsc);

            this.adbEscControl2.setEscId(2);
            this.adbEscControl2.setBindings(this.BindingSourceAdbEsc);

            this.adbEscControl3.setEscId(3);
            this.adbEscControl3.setBindings(this.BindingSourceAdbEsc);

            this.adbEscControl4.setEscId(4);
            this.adbEscControl4.setBindings(this.BindingSourceAdbEsc);

            this.adbEscControl5.setEscId(5);
            this.adbEscControl5.setBindings(this.BindingSourceAdbEsc);

            this.adbEscControl6.setEscId(6);
            this.adbEscControl6.setBindings(this.BindingSourceAdbEsc);

            this.adbEscControl7.setEscId(7);
            this.adbEscControl7.setBindings(this.BindingSourceAdbEsc);

            this.adbEscControl8.setEscId(8);
            this.adbEscControl8.setBindings(this.BindingSourceAdbEsc);
        }
    }
}
