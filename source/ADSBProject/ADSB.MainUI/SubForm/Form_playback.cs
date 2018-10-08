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
    public partial class Form_playback : Form_aTemplate
    {

        public static DateTime startTime = DateTime.Now.AddDays(-1);
        public static DateTime endTime = DateTime.Now.AddDays(1);
        public static int speed = 1;
        public static List<String> sModeAddressList = new List<string>();

        public Form_playback()
        {
            InitializeComponent();
        }

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinLabel1_Click(object sender, EventArgs e)
        {

        }

        private void skinLabel2_Click(object sender, EventArgs e)
        {

        }

        private void skinPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                startTime = DateTime.ParseExact(skinTextBox2.Text, "yyyy-MM-dd HH:mm:ss", null);
                endTime = DateTime.ParseExact(skinTextBox3.Text, "yyyy-MM-dd HH:mm:ss", null);
                if (myCheckBox1.Checked)
                {
                    speed = 1;
                }
                else if (myCheckBox2.Checked)
                {
                    speed = 2;
                }
                else if (myCheckBox3.Checked)
                {
                    speed = 5;
                }
                sModeAddressList.Clear();
                if(!skinTextBox4.Text.Trim().Equals(""))
                {
                    sModeAddressList = new List<string>(skinTextBox4.Text.Trim().Split(','));
                }
            }
            catch(Exception)
            {
                // MessageBox.Show("参数不正确");
            }
        }

        private void myCheckBox1_Click(object sender, EventArgs e)
        {
            myCheckBox1.Checked = true;
            myCheckBox2.Checked = false;
            myCheckBox3.Checked = false;
        }

        private void myCheckBox2_Click(object sender, EventArgs e)
        {
            myCheckBox1.Checked = false;
            myCheckBox2.Checked = true;
            myCheckBox3.Checked = false;
        }

        private void myCheckBox3_Click(object sender, EventArgs e)
        {
            myCheckBox1.Checked = false;
            myCheckBox2.Checked = false;
            myCheckBox3.Checked = true;
        }
    }
}
