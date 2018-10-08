using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADSB.MainUI.SubForm
{
    public partial class Form_alarmSet : Form
    {
        private static String ALARM_HIGHT = "alarm_hight";
        private static String ALARM_DISTANCE = "alarm_distance";

        public Form_alarmSet()
        {
            InitializeComponent();
        }

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            if (!this.skinTextBox1.Text.Equals(""))
            {
                ConfigHelper.Instance.SetConfig(ALARM_DISTANCE, this.skinTextBox1.Text);
            }
            if (!this.skinTextBox2.Text.Equals(""))
            {
                ConfigHelper.Instance.SetConfig(ALARM_HIGHT, this.skinTextBox2.Text);
            }

            this.Close();
        }

    }
}
