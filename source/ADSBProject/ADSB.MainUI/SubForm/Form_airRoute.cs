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
        private List<Air_Route> airRouteList = new List<Air_Route>();

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
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("请输入航线名称！");
                return;
            }
            if (string.IsNullOrEmpty(skinTextBox1.Text))
            {
                MessageBox.Show("请至少选择一个航段！");
                return;
            }
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("请至少选择一个航段！");
                return;
            }
            if (string.IsNullOrEmpty(comboBox3.Text))
            {
                MessageBox.Show("请至少选择一个航段！");
                return;
            }
            if (string.IsNullOrEmpty(comboBox4.Text))
            {
                MessageBox.Show("请至少选择一个航段！");
                return;
            }
            Air_Route air_Route = new Air_Route(1, name, skinTextBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text);
            ProfileHelper.Instance.Update("INSERT INTO AirRoute (Id, Name, PointType, PointName, Type, Show) VALUES ( NULL, '" + 
                air_Route.Name + "', '" + air_Route.PointType + "', '" + air_Route.PointName + "', '" + 
                air_Route.Type + "', '" + air_Route.Show + "')");

            skinButton3.Visible = true;
            skinButton1.Text = "继续";
            int num = Convert.ToInt32(skinTextBox1.Text) + 1;
            skinTextBox1.Text = num.ToString();

            showAllAirRoute();
            airRoute_event(true, 2);
        }

        private void InitializeGMap()
        {
            // 下拉框初始化
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM WayPoint");
            foreach (Dictionary<string, object> dictionary in result)
            {
                String name = Convert.ToString(dictionary["Name"]);
                comboBox2.Items.Add(name);
            }

            skinTextBox1.Text = "1";
            comboBox3.Items.Add("民航航班");
            comboBox3.Items.Add("自定航班");
            comboBox4.Items.Add("是");
            comboBox4.Items.Add("否");

            showAllAirRoute();
        }


        private void skinButton2_Click(object sender, EventArgs e)
        {
            String name = this.dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            ProfileHelper.Instance.Update("Delete FROM AirRoute WHERE Name = \"" + name + "\"");
            showAllAirRoute();
        }

        /**
        * 从数据库里面查出所有的数据，展示。
        * */
        private void showAllAirRoute()
        {
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM AirRoute ORDER BY Name");
            airRouteList.Clear();
            foreach (Dictionary<string, object> dictionary in result)
            {
                int id = Convert.ToInt16(dictionary["ID"]);
                String name = Convert.ToString(dictionary["Name"]);
                String pointType = Convert.ToString(dictionary["PointType"]);
                String pointName = Convert.ToString(dictionary["PointName"]);
                String type = Convert.ToString(dictionary["Type"]);
                String show = Convert.ToString(dictionary["Show"]);
                Air_Route air_Route = new Air_Route(id, name, pointType, pointName, type, show);
                airRouteList.Add(air_Route);
            }

            this.dataGridView1.DataSource = null;
            if (null != airRouteList && airRouteList.Count() > 0)
            {
                this.dataGridView1.DataSource = this.airRouteList;
            }
            
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            skinButton3.Visible = false;
            skinTextBox1.Text = "1";
            skinButton1.Text = "新增";
        }
    }
}

public class Air_Route
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

    private String pointType;
    public String PointType
    {
        get { return pointType; }
        set { pointType = value; }
    }

    private String pointName;
    public String PointName
    {
        get { return pointName; }
        set { pointName = value; }
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

    public Air_Route(int id, String name, String pointType, String pointName, String type, String show)
    {
        this.id = id;
        this.name = name;
        this.pointType = pointType;
        this.pointName = pointName;
        this.type = type;
        this.show = show;
    }
}