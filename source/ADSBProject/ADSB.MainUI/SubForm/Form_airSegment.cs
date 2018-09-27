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
    public partial class Form_airSegment : Form_aTemplate
    {
        public delegate void airSegment(Boolean selected, int flag);
        public event airSegment airSegment_event;

        public Form_airSegment()
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
                MessageBox.Show("请输入航段名称！");
                return;
            }
            if (null == comboBox1.Text || comboBox1.Text.Length == 0)
            {
                MessageBox.Show("请选择起点！");
                return;
            }
            if (null == comboBox2.Text || comboBox2.Text.Length == 0)
            {
                MessageBox.Show("请选择终点！");
                return;
            }

            double lat = 20;
            double lang = 40;


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

            TextBox nameBox = new TextBox();
            nameBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameBox.TextAlign = HorizontalAlignment.Center;
            nameBox.Text = name;
            tableLayoutPanel1.Controls.Add(nameBox, 1, i);

            TextBox inc = new TextBox();
            inc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inc.TextAlign = HorizontalAlignment.Center;
            inc.Text = lat.ToString();
            tableLayoutPanel1.Controls.Add(inc, 2, i);

            TextBox outcBegin = new TextBox();
            outcBegin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            outcBegin.TextAlign = HorizontalAlignment.Center;
            outcBegin.Text = lang.ToString();
            tableLayoutPanel1.Controls.Add(outcBegin, 3, i);

            TextBox nameBoxEnd = new TextBox();
            nameBoxEnd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameBoxEnd.TextAlign = HorizontalAlignment.Center;
            nameBoxEnd.Text = name;
            tableLayoutPanel1.Controls.Add(nameBoxEnd, 4, i);

            TextBox incEnd = new TextBox();
            incEnd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            incEnd.TextAlign = HorizontalAlignment.Center;
            incEnd.Text = lat.ToString();
            tableLayoutPanel1.Controls.Add(incEnd, 5, i);

            TextBox outcEnd = new TextBox();
            outcEnd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            outcEnd.TextAlign = HorizontalAlignment.Center;
            outcEnd.Text = lang.ToString();
            tableLayoutPanel1.Controls.Add(outcEnd, 6, i);

            // todo 保存到数据库

            airSegment_event(true, 2);

            // MessageBox.Show("新增成功！");
        }

        private void InitializeGMap()
        {
            // 下拉框初始化
            comboBox1.Items.Add("上海");
            comboBox1.Items.Add("北京");
            comboBox1.Items.Add("南京");

            comboBox2.Items.Add("深圳");
            comboBox2.Items.Add("西安");
            comboBox2.Items.Add("广州");
            // TODO 获取地面目标信息，并初始化tableLayoutPanel1
            // tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50));

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
                            Control ctlNext3 = tableLayoutPanel1.GetControlFromPosition(3, k + 1);
                            tableLayoutPanel1.SetCellPosition(ctlNext3, new TableLayoutPanelCellPosition(3, k));
                            Control ctlNext4 = tableLayoutPanel1.GetControlFromPosition(4, k + 1);
                            tableLayoutPanel1.SetCellPosition(ctlNext1, new TableLayoutPanelCellPosition(4, k));
                            Control ctlNext5 = tableLayoutPanel1.GetControlFromPosition(5, k + 1);
                            tableLayoutPanel1.SetCellPosition(ctlNext2, new TableLayoutPanelCellPosition(5, k));
                            Control ctlNext6 = tableLayoutPanel1.GetControlFromPosition(6, k + 1);
                            tableLayoutPanel1.SetCellPosition(ctlNext3, new TableLayoutPanelCellPosition(6, k));
                        }

                        //移除最后一行，最后为空白行
                        tableLayoutPanel1.RowStyles.RemoveAt(tableLayoutPanel1.RowCount - 1);
                        tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount - 1;

                        airSegment_event(true, 2);

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
