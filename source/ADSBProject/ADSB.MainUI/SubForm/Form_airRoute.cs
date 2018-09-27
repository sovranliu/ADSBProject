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
using GMap.NET;
using GMap.NET.MapProviders;

namespace ADSB.MainUI.SubForm
{
    public partial class Form_airRoute : Form_aTemplate
    {
        public delegate void airRoute(Boolean selected, int flag);
        public event airRoute airRoute_event;

        public Form_airRoute()
        {
            InitializeComponent();
            InitializeGMap();
        }

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            String name = skinTextBox2.Text;
            if (null == name || name.Length == 0)
            {
                MessageBox.Show("请输入航线名称！");
                return;
            }
            if (null == comboBox1.Text || comboBox1.Text.Length == 0)
            {
                MessageBox.Show("请至少选择一个航段！");
                return;
            }
            // todo 判断余下的航段是否有选择


            // 动态添加一行
            tableLayoutPanel1.RowCount++;
            //设置高度
            tableLayoutPanel1.Height = tableLayoutPanel1.RowCount * 40;
            // 行高
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));
            // 设置cell样式，
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            int i = tableLayoutPanel1.RowCount - 1;
            // 添加控件
            CheckBox p = new CheckBox();
            p.Anchor = AnchorStyles.None;
            p.TextAlign = ContentAlignment.MiddleCenter;
            tableLayoutPanel1.Controls.Add(p, 0, tableLayoutPanel1.RowCount - 1);
            p.Text = "" + i;

            TextBox nameBoxBegin = new TextBox();
            nameBoxBegin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameBoxBegin.TextAlign = HorizontalAlignment.Center;
            nameBoxBegin.Text = name;
            tableLayoutPanel1.Controls.Add(nameBoxBegin, 1, i);

            TextBox incBegin = new TextBox();
            incBegin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            incBegin.TextAlign = HorizontalAlignment.Center;
            incBegin.Text = comboBox1.Text;
            tableLayoutPanel1.Controls.Add(incBegin, 2, i);

            // todo 保存到数据库

            airRoute_event(true, 2);

            // MessageBox.Show("新增成功！");
        }

        private void InitializeGMap()
        {
            // 下拉框初始化
            comboBox1.Items.Add("上海-北京");
            comboBox1.Items.Add("北京-南京");
            comboBox1.Items.Add("南京-上海");

            comboBox2.Items.Add("深圳-西安");
            comboBox2.Items.Add("西安-广州");
            comboBox2.Items.Add("广州-深圳");

            comboBox3.Items.Add("深圳3-西安");
            comboBox3.Items.Add("西安3-广州");
            comboBox3.Items.Add("广州3-深圳");

            comboBox4.Items.Add("深圳4-西安");
            comboBox4.Items.Add("西安4-广州");
            comboBox4.Items.Add("广州4-深圳");

            comboBox5.Items.Add("深圳5-西安");
            comboBox5.Items.Add("西安5-广州");
            comboBox5.Items.Add("广州5-深圳");
        }


        private void skinButton2_Click(object sender, EventArgs e)
        {
            // 行数
            int row = 0;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                Control ctl = tableLayoutPanel1.Controls[i];
                // 默认CheckBox为行首控件
                if (ctl.GetType().ToString().Contains("CheckBox"))
                {
                    CheckBox rb = (CheckBox)ctl;
                    if (rb.Checked)
                    {
                        // 删除当前行的所有控件
                        for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                        {
                            tableLayoutPanel1.Controls.RemoveAt(i);
                        }

                        // 移动,当前行row的下行往上移动
                        for (int k = row; k < tableLayoutPanel1.RowCount - 1; k++)
                        {
                            Control ctlNext = tableLayoutPanel1.GetControlFromPosition(0, k + 1);
                            ctlNext.Text = k.ToString();
                            tableLayoutPanel1.SetCellPosition(ctlNext, new TableLayoutPanelCellPosition(0, k));
                            Control ctlNext1 = tableLayoutPanel1.GetControlFromPosition(1, k + 1);
                            tableLayoutPanel1.SetCellPosition(ctlNext1, new TableLayoutPanelCellPosition(1, k));
                            Control ctlNext2 = tableLayoutPanel1.GetControlFromPosition(2, k + 1);
                            tableLayoutPanel1.SetCellPosition(ctlNext2, new TableLayoutPanelCellPosition(2, k));
                        }

                        //移除最后一行，最后为空白行
                        tableLayoutPanel1.RowStyles.RemoveAt(tableLayoutPanel1.RowCount - 1);
                        tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount - 1;

                        airRoute_event(true, 2);

                        break;
                    }
                    row++;//行数加加
                }
            }

            // 重新计算高度，否则最后一行偏大
            tableLayoutPanel1.Height = tableLayoutPanel1.RowCount * 40;
        }

   
    }
}
