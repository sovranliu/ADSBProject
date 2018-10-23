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
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("请输入航段名称！");
                return;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("请选择起点！");
                return;
            }
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("请选择终点！");
                return;
            }

            if (string.IsNullOrEmpty(comboBox3.Text))
            {
                MessageBox.Show("请选择类型！");
                return;
            }

            Air_Segment airSegmente = new Air_Segment(0, name, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text);
            if (skinLabel5.Text.Equals("ID"))
            {
                // 插入数据库
                ProfileHelper.Instance.Update("INSERT INTO AirSegment (Id, Name, BeginWayPoint, EndWayPoint, Type, Show) VALUES ( NULL, '" +
                    airSegmente.Name + "', '" + airSegmente.BeginWayPoint + "', '" + airSegmente.EndWayPoint + "', '" +
                    airSegmente.Type + "', '" + airSegmente.Show + "')");
            }
            else if (!string.IsNullOrWhiteSpace(skinLabel5.Text))
            {
                // 更新数据库
                ProfileHelper.Instance.Update(
                   "UPDATE AirSegment set " +
                        " Name = '" + airSegmente.Name + "', " +
                        " BeginWayPoint = '" + airSegmente.BeginWayPoint + "', " +
                        " EndWayPoint = '" + airSegmente.EndWayPoint + "', " +
                        " Type = '" + airSegmente.Type + "', " +
                        " Show = '" + airSegmente.Show + "'" + 
                        " where ID = " + skinLabel5.Text);

                // 更新后初始化组件
                skinTextBox2.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";

                skinButton1.Text = "新增";
            }

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
            comboBox3.Items.Add("民航航班");
            comboBox3.Items.Add("自定航班");
            comboBox4.Items.Add("是");
            comboBox4.Items.Add("否");

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
                int id = Convert.ToInt32(dictionary["ID"]);
                String name = Convert.ToString(dictionary["Name"]);
                String beginWayPoint = Convert.ToString(dictionary["BeginWayPoint"]);
                String endWayPoint = Convert.ToString(dictionary["EndWayPoint"]);
                String type = Convert.ToString(dictionary["Type"]);
                String show = Convert.ToString(dictionary["Show"]);
                Air_Segment air_Segment = new Air_Segment(id, name, beginWayPoint, endWayPoint, type, show);
                airSegmentList.Add(air_Segment);
            }

            this.dataGridView1.DataSource = null;
            if (null != airSegmentList && airSegmentList.Count() > 0)
            {
                this.dataGridView1.DataSource = this.airSegmentList;
            }
        }

        // 更新
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            String name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            String beginWayPoint = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            String endWayPoint = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String type = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            String show = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());

            skinButton1.Text = "更新";
            showAllAirSegment();
            showLable(id, name, beginWayPoint, endWayPoint, type, show);
        }

        private void showLable(int id, String name, String beginWayPoint, String endWayPoint, String type, String show)
        {
            skinTextBox2.Text = name;
            comboBox1.Text = beginWayPoint;
            comboBox2.Text = endWayPoint;
            comboBox3.Text = type;
            comboBox4.Text = show;

            skinLabel5.Text = id.ToString();
        }
    }
}
public class Air_Segment
{
    private int id;
    public int ID
    {
        get { return id; }
        set { id = value; }
    }
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

    private String type;
    public String Type
    {
        get { return type; }
        set { type = value; }
    }

    private String show;
    public String Show
    {
        get { return show; }
        set { show = value; }
    }
    public Air_Segment(int id, String name, String beginWayPoint, String endWayPoint, String type, String show)
    {
        this.id = id;
        this.name = name;
        this.BeginWayPoint = beginWayPoint;
        this.EndWayPoint = endWayPoint;
        this.Type = type;
        this.Show = show;
    }
}