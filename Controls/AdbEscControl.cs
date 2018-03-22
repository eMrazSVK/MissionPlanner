using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MissionPlanner.Controls
{
    public partial class AdbEscControl: UserControl
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        

        private string LabelIdString;
        private string IsBindingString;
        private string VbusBindingString;
        private string SpeedBindingString;
        private string TempBindingString;
        private string VsBindingString;
        private string PwmBindingString;
        private BindingSource AdbEscBindingSource;
        private int escId;

        public AdbEscControl()
        {
            InitializeComponent();
            HideCaret(textBoxIs.Handle);
            HideCaret(textBoxVbus.Handle);
            HideCaret(textBoxSpeed.Handle);
            HideCaret(textBoxTemp.Handle);
            HideCaret(textBoxVs.Handle);
            HideCaret(textBoxPwm.Handle);
        }

        public void setEscId(int escId)
        {
            this.escId = escId;
            this.labelEscId.Text = "ESC " + escId.ToString();
        }

        public void setBindings(BindingSource source)
        {
            AdbEscBindingSource = source;

            IsBindingString = "adb_esc_is_" + escId.ToString();
            VbusBindingString = "adb_esc_vbus_" + escId.ToString();
            SpeedBindingString = "adb_esc_speed_" + escId.ToString();
            TempBindingString = "adb_esc_temp_" + escId.ToString();
            VsBindingString = "adb_esc_vs_" + escId.ToString();
            PwmBindingString = "adb_esc_pwm_" + escId.ToString();
            

            this.textBoxIs.DataBindings.Add(new System.Windows.Forms.Binding("Text", 
                                                                             this.AdbEscBindingSource,
                                                                             this.IsBindingString,
                                                                             true,
                                                                             System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                             null,
                                                                             "N2"));

            this.textBoxVbus.DataBindings.Add(new System.Windows.Forms.Binding("Text",
                                                                                this.AdbEscBindingSource,
                                                                                this.VbusBindingString,
                                                                                true,
                                                                                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                null,
                                                                                "N2"));

            this.textBoxSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text",
                                                                                 this.AdbEscBindingSource,
                                                                                 this.SpeedBindingString,
                                                                                 true,
                                                                                 System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                                 null,
                                                                                 "N2"));

            this.textBoxTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text",
                                                                               this.AdbEscBindingSource,
                                                                               this.TempBindingString,
                                                                               true,
                                                                               System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                               null,
                                                                               "N2"));

            this.textBoxVs.DataBindings.Add(new System.Windows.Forms.Binding("Text",
                                                                             this.AdbEscBindingSource,
                                                                             this.VsBindingString,
                                                                             true,
                                                                             System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                             null,
                                                                             "N2"));

            this.textBoxPwm.DataBindings.Add(new System.Windows.Forms.Binding("Text",
                                                                             this.AdbEscBindingSource,
                                                                             this.PwmBindingString,
                                                                             true,
                                                                             System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged,
                                                                             null,
                                                                             "N2"));


        }
    }
}
