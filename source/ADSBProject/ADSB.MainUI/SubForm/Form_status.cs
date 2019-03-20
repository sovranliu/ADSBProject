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
    public partial class Form_status : Form_aTemplate
    {
        public Form_status()
        {
            InitializeComponent();
            InittextBox();
        }

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (null != textBox1.Text && textBox1.Text.Length > 0)
            {
                ConfigHelper.Instance.SetConfig("ip_intit", textBox1.Text);
            }
            if (null != textBox2.Text && textBox2.Text.Length > 0)
            {
                ConfigHelper.Instance.SetConfig("port_init", textBox2.Text);
            }
            if (null != comboBox1.Text)
            {
                DataSource dataSource = MainForm.dataSource;
                byte b = (byte) Int32.Parse(comboBox1.Text);
                dataSource.setType(b);
            }
            this.Close();
        }

        private void InittextBox()
        {
            String ip_intit = ConfigHelper.Instance.GetConfig("ip_intit");
            String port_init = ConfigHelper.Instance.GetConfig("port_init");

            if (null == ip_intit || ip_intit.Length == 0)
            {
                textBox1.Text = "127.0.0.1";
            }
            else
            {
                textBox1.Text = ip_intit;
            }

            if (null == port_init || port_init.Length == 0)
            {
                textBox2.Text = "2333";
            }
            else
            {
                textBox2.Text = port_init;
            }
        }


    }
}
