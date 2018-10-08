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
    public partial class Form_setup : Form_aTemplate
    {
        public Form_setup()
        {
            InitializeComponent();
            String my_sAddress = ConfigHelper.Instance.GetConfig("my_sAddress");
            if (!string.IsNullOrWhiteSpace(my_sAddress))
            {
                skinTextBox3.Text = my_sAddress;
            }
        }

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(skinTextBox3.Text))
            {
                ConfigHelper.Instance.SetConfig("my_sAddress", skinTextBox3.Text);
            }
        }
    }
}
