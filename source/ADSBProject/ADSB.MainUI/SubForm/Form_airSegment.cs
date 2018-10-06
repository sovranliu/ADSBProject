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
        private List<Air_Segment> airSegmentList = new List<Air_Segment>();

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

            Air_Segment airSegmente = new Air_Segment(name, comboBox1.Text, comboBox2.Text);
            // 插入数据库
            ProfileHelper.Instance.Update("INSERT INTO AirSegment (Name, BeginWayPoint, EndWayPoint) VALUES ('" + airSegmente.Name + "', '" + airSegmente.BeginWayPoint + "', '" + airSegmente.EndWayPoint + "')");
            showAllAirSegment();
            airSegment_event(true, 2);
        }

        private void InitializeGMap()
        {
            // 下拉框初始化
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM WayPoint");
            foreach (Dictionary<string, object> dictionary in result)
            {
                String name = Convert.ToString(dictionary["Name"]);
                comboBox1.Items.Add(name);
                comboBox2.Items.Add(name);
            }

            showAllAirSegment();
            // TODO 获取地面目标信息，并初始化tableLayoutPanel1
            // tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50));

        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            String name = this.dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            ProfileHelper.Instance.Update("Delete FROM AirSegment WHERE Name = \"" + name + "\"");
            showAllAirSegment();
        }

        /**
         * 从数据库里面查出所有的数据，展示。
         * */
        private void showAllAirSegment()
        {
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM AirSegment");
            airSegmentList.Clear();
            foreach (Dictionary<string, object> dictionary in result)
            {
                String name = Convert.ToString(dictionary["Name"]);
                String beginWayPoint = Convert.ToString(dictionary["BeginWayPoint"]);
                String endWayPoint = Convert.ToString(dictionary["EndWayPoint"]);
                Air_Segment air_Segment = new Air_Segment(name, beginWayPoint, endWayPoint);
                airSegmentList.Add(air_Segment);
            }

            this.dataGridView1.DataSource = null;
            if (null != airSegmentList && airSegmentList.Count() > 0)
            {
                this.dataGridView1.DataSource = this.airSegmentList;
            }

        }

    }
}
public class Air_Segment
{
    private String name;
    public String Name
    {
        get { return name; }
        set { name = value; }
    }

    private String beginWayPoint;
    public String BeginWayPoint
    {
        get { return beginWayPoint; }
        set { beginWayPoint = value; }
    }

    private String endWayPoint;
    public String EndWayPoint
    {
        get { return endWayPoint; }
        set { endWayPoint = value; }
    }

    public Air_Segment(String name, String beginWayPoint, String endWayPoint)
    {
        this.name = name;
        this.BeginWayPoint = beginWayPoint;
        this.EndWayPoint = endWayPoint;
    }
}