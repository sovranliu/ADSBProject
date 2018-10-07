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
    public partial class Form_mapTool : Form_aTemplate
    {
        // 1-空域checkbox选择显示，2-新增、删除了关注
        public delegate void changebox2(Boolean selected, int flag);
        public event changebox2 changebox2_event;
        
        // 1-航段checkbox选择显示，2-新增、删除了关注
        public delegate void changebox3(Boolean selected, int flag);
        public event changebox3 changebox3_event;

        // 1-机场checkbox选择显示，2-新增、删除了关注
        public delegate void changebox4(Boolean selected, int flag);
        public event changebox4 changebox4_event;
        
        // 1-航路点checkbox选择显示，2-新增、删除了关注
        public delegate void changebox5(Boolean selected, int flag);
        public event changebox5 changebox5_event;
        
        public delegate void changebox6(Boolean selected, int flag);
        public event changebox6 changebox6_event;

        // 1-地面站checkbox选择显示，2-新增、删除了关注
        public delegate void changebox7(Boolean selected, int flag);
        public event changebox7 changebox7_event;

        public Form_mapTool()
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

        // 空域
        private void myCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (myCheckBox2.CheckState == CheckState.Checked)
            {
                changebox2_event(true, 1);
                return;
            }
            changebox2_event(false, 1);
        }

        public void myCheckBox2_Selected()
        {
            myCheckBox2.Checked = true;
        }

        // 航段
        private void myCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (myCheckBox3.CheckState == CheckState.Checked)
            {
                changebox3_event(true, 1);
                return;
            }
            changebox3_event(false, 1);
        }

        public void myCheckBox3_Selected()
        {
            myCheckBox3.Checked = true;
        }


        // 机场
        private void myCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (myCheckBox4.CheckState == CheckState.Checked)
            {
                changebox4_event(true, 1);
                return;
            }
            changebox4_event(false, 1);
        }

        public void myCheckBox4_Selected()
        {
            myCheckBox4.Checked = true;
        }

        // 航路点
        private void myCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (myCheckBox5.CheckState == CheckState.Checked)
            {
                changebox5_event(true, 1);
                return;
            }
            changebox5_event(false, 1);
        }

        public void myCheckBox5_Selected()
        {
            myCheckBox5.Checked = true;
        }



        // 地面站
        private void myCheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (myCheckBox7.CheckState == CheckState.Checked)
            {
                changebox7_event(true, 1);
                return;
            }
            changebox7_event(false, 1);
        }

        public void myCheckBox7_Selected()
        {
            myCheckBox7.Checked = true;
        }

    }
}
