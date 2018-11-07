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

        // 1-航迹圈checkbox选择显示，2-新增、删除了关注
        public delegate void changebox9(Boolean selected);
        public event changebox9 changebox9_event;

        // 1-地面站距离环checkbox选择显示，2-新增、删除了关注
        public delegate void changebox10(Boolean selected);
        public event changebox10 changebox10_event;
        
        // 1-机场距离环checkbox选择显示，2-新增、删除了关注
        public delegate void changebox11(Boolean selected);
        public event changebox11 changebox11_event;
        
        // 1-航线checkbox选择显示，2-新增、删除了关注
        public delegate void changebox12(Boolean selected, int flag);
        public event changebox12 changebox12_event;


        public Form_mapTool()
        {
            InitializeComponent();

            // 初始化下拉框的值
            String comboBox = ConfigHelper.Instance.GetConfig("show_num");
            if (!string.IsNullOrEmpty(comboBox))
            {
                int sel = skinComboBox2.Items.IndexOf(comboBox);
                skinComboBox2.SelectedIndex = sel;
            }
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
            }
            else
            {
                changebox4_event(false, 1);
            }

            box10Set();
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
            }
            else
            {
                changebox7_event(false, 1);
            }
            box9Set();
            box10Set();
        }

        public void myCheckBox7_Selected()
        {
            myCheckBox7.Checked = true;
        }

        // 航迹圈过滤
        private void myCheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (myCheckBox9.CheckState == CheckState.Checked)
            {
                changebox9_event(true);
            }
            else
            {
                changebox9_event(false);
            }

            box7Set();
            // box4Set();
        }

        public void myCheckBox9_Selected()
        {
            myCheckBox9.Checked = true;
        }

        private void box4Set()
        {
            if (myCheckBox4.CheckState == CheckState.Checked)
            {
                changebox4_event(true, 1);
            }
            else
            {
                if (changebox4_event != null)
                {
                    changebox4_event(false, 1);
                }
            }
        }

        private void box7Set()
        {
            if (myCheckBox7.CheckState == CheckState.Checked)
            {
                changebox7_event(true, 1);
            }
            else
            {
                if (changebox7_event != null)
                {
                    changebox7_event(false, 1);
                }
            }
        }

        private void box9Set()
        {
            if (myCheckBox9.CheckState == CheckState.Checked)
            {
                changebox9_event(true);
            }
            else
            {
                if (changebox9_event != null)
                {
                    changebox9_event(false);
                }
            }
        }

        private void box10Set()
        {
            if (myCheckBox10.CheckState == CheckState.Checked)
            {
                changebox10_event(true);
            }
            else
            {
                if (changebox10_event != null)
                {
                    changebox10_event(false);
                }
            }
        }

        

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void myCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        // 地面站距离环
        private void myCheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (myCheckBox10.CheckState == CheckState.Checked)
            {
                changebox10_event(true);
            }
            else
            {
                if (changebox10_event != null)
                {
                    changebox10_event(false);
                }
            }
        }

        public void myCheckBox10_Selected()
        {
            myCheckBox10.Checked = true;
        }

        // 机场距离环
        private void myCheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (myCheckBox11.CheckState == CheckState.Checked)
            {
                changebox11_event(true);
            }
            else
            {
                if (changebox11_event != null)
                {
                    changebox11_event(false);
                }
            }
        }

        public void myCheckBox11_Selected()
        {
            myCheckBox11.Checked = true;
        }

        // 展示多少个轨迹点
        private void skinComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(skinComboBox2.Text))
            {
                ConfigHelper.Instance.SetConfig("show_num", skinComboBox2.Text);
            }
        }

        // 航线
        private void myCheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (myCheckBox12.CheckState == CheckState.Checked)
            {
                changebox12_event(true, 1);
            }
            else
            {
                if (changebox12_event != null)
                {
                    changebox12_event(false, 1);
                }
            }
        }

        public void myCheckBox12_Selected()
        {
            myCheckBox12.Checked = true;
        }
    }
}
