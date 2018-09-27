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
    public partial class Form_airPort : Form_aTemplate
    {
        public delegate void airPort(Boolean selected, int flag);
        public event airPort airPort_event;

        public Form_airPort()
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
                MessageBox.Show("请输入机场名称！");
                return;
            }
            if (null == skinTextBox3.Text || skinTextBox3.Text.Length == 0)
            {
                MessageBox.Show("请输入经纬度！");
                return;
            }
            if (null == skinTextBox4.Text || skinTextBox4.Text.Length == 0)
            {
                MessageBox.Show("请输入经纬度！");
                return;
            }
            double lat = System.Convert.ToDouble(skinTextBox3.Text);
            double lang = System.Convert.ToDouble(skinTextBox4.Text);


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

            TextBox outc = new TextBox();
            outc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            outc.TextAlign = HorizontalAlignment.Center;
            outc.Text = lang.ToString();
            tableLayoutPanel1.Controls.Add(outc, 3, i);

            // todo 保存到数据库

            airPort_event(true, 2);

            // MessageBox.Show("新增成功！");
        }

        private void InitializeGMap()
        {
            this.gMapControl1.CacheLocation = System.Windows.Forms.Application.StartupPath;    //缓冲区路径
            this.gMapControl1.MapProvider = GMapProviders.GoogleChinaMap;                      //谷歌中国区地图加载
            this.gMapControl1.Manager.Mode = AccessMode.ServerAndCache;                        //地图模式
            this.gMapControl1.MinZoom = 1;                                                     //最小比例
            this.gMapControl1.MaxZoom = 23;                                                    //最大比例
            this.gMapControl1.Zoom = 10;                                                       //当前比例
            this.gMapControl1.ShowCenter = false;                                              //不显示中心十字点
            this.gMapControl1.DragButton = System.Windows.Forms.MouseButtons.Left;             //左键拖拽地图
            this.gMapControl1.Position = new PointLatLng(23.16, 113.27);                     //初始化地址 广州(23.16, 113.27) 北京(39.3, 116.5)
            this.gMapControl1.MouseDown += new MouseEventHandler(mapControl_MouseDown);

            // TODO 获取地面目标信息，并初始化tableLayoutPanel1
           // tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50));
            
        }

        private void mapControl_MouseDown(object sender, MouseEventArgs e)
        {
            PointLatLng point = gMapControl1.FromLocalToLatLng(e.X, e.Y);
            skinTextBox3.Text = point.Lat.ToString();
            skinTextBox4.Text = point.Lng.ToString();
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
                        }

                        //移除最后一行，最后为空白行
                        tableLayoutPanel1.RowStyles.RemoveAt(tableLayoutPanel1.RowCount - 1);
                        tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount - 1;

                        airPort_event(true, 2);

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
