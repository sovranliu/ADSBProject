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
        private List<Route_WayPoint> routeWayPointList = new List<Route_WayPoint>();

        public Form_airRoute()
        {
            InitializeComponent();
            InitializeGMap();
        }

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            String name = skinTextBox2.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("请输入航线名称！");
                return;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("请选择航线起点！");
                return;
            }
            if (string.IsNullOrEmpty(comboBox5.Text))
            {
                MessageBox.Show("请选择航线终点！");
                return;
            }
            if (string.IsNullOrEmpty(comboBox3.Text))
            {
                MessageBox.Show("请选择类型！");
                return;
            }
            if (string.IsNullOrEmpty(comboBox4.Text))
            {
                MessageBox.Show("请选中是否显示！");
                return;
            }
            Air_Route air_Route = new Air_Route(1, name, comboBox1.Text, comboBox5.Text, comboBox3.Text, comboBox4.Text);
            if (skinLabel5.Text.Equals("ID"))
            {
                ProfileHelper.Instance.Update("INSERT INTO AirRoute (Id, Name, PointBegin, PointEnd, Type, Show) VALUES ( NULL, '" +
                    air_Route.Name + "', '" + air_Route.PointBegin + "', '" + air_Route.PointEnd + "', '" +
                    air_Route.Type + "', '" + air_Route.Show + "')");


                //skinButton1.Text = "继续";
                //comboBox3.Visible = false;
                //comboBox4.Visible = false;
                //int num = Convert.ToInt32(skinTextBox1.Text) + 1;
                //skinTextBox1.Text = num.ToString();
            }
            else
            {
                List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM AirRoute WHERE ID = " + skinLabel5.Text);
                if (result.Count > 0)
                {
                    String nameUpdate = Convert.ToString(result[0]["Name"]);
                    // 更改其他列的信息
                    ProfileHelper.Instance.Update(
                    "UPDATE AirRoute set " +
                        " Name = '" + air_Route.Name + "', " +
                        " Type = '" + air_Route.Type + "', " +
                        " Show = '" + air_Route.Show + "', " +
                        " PointBegin = '" + air_Route.PointBegin + "', " +
                        " PointEnd = '" + air_Route.PointEnd + "' " +
                        " where Name = '" + nameUpdate + "'");

                    ProfileHelper.Instance.Update(
                   "UPDATE RouteWayPoint set " +
                       " PortId = '" + air_Route.Name + "'" +
                       " where PortId = '" + nameUpdate + "'");

                }
                init();
            }

            showAllAirRoute();
            airRoute_event(true, 2);
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            String name = skinTextBox3.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("请选择航线！");
                return;
            }

            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("请选择航站点！");
                return;
            }

            int num = Convert.ToInt32(skinTextBox1.Text);
            String wayPoint = comboBox2.Text;

            Route_WayPoint routeWayPoint = new Route_WayPoint(0, name, comboBox2.Text, num);
            if (skinLabel11.Text.Equals("ID"))
            {
                ProfileHelper.Instance.Update("INSERT INTO RouteWayPoint (Id, PortId, WayPoint, Num) VALUES ( NULL, '" +
                   routeWayPoint.PortId + "', '" + routeWayPoint.WayPoint + "', " + routeWayPoint.Num + ")");

                skinTextBox1.Text = (num + 1).ToString();
            }
            else
            {
                List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM RouteWayPoint WHERE ID = " + skinLabel11.Text);
                if (result.Count > 0)
                {
                    // 更改其他列的信息
                    ProfileHelper.Instance.Update(
                    "UPDATE RouteWayPoint set " +
                        " WayPoint = '" + routeWayPoint.WayPoint + "'" +
                        " where ID = '" + skinLabel11.Text + "'");

                    skinButton1.Text = "新增";
                    comboBox2.SelectedValue = "";
                    skinButton3.Visible = false;
                }
            }

            showAllRouteWaypoint(name);
            
        }

        private void InitializeGMap()
        {
            // 下拉框初始化
            List<Dictionary<string, object>> resultWayPoint = ProfileHelper.Instance.Select("SELECT * FROM WayPoint");
            foreach (Dictionary<string, object> dictionary in resultWayPoint)
            {
                String name = Convert.ToString(dictionary["Name"]);
                comboBox2.Items.Add(name);
            }

            List<Dictionary<string, object>> resultAirPort = ProfileHelper.Instance.Select("SELECT * FROM AirPort");
            foreach (Dictionary<string, object> dictionary in resultAirPort)
            {
                String name = Convert.ToString(dictionary["Name"]);
                comboBox1.Items.Add(name);
                comboBox5.Items.Add(name);
            }

            skinTextBox1.Text = "1";
            comboBox3.Items.Add("民航航线");
            comboBox3.Items.Add("自定航班");
            comboBox4.Items.Add("是");
            comboBox4.Items.Add("否");
            skinButton3.Visible = false;
            skinButton6.Visible = false;
            showAllAirRoute();
        }


        private void skinButton2_Click(object sender, EventArgs e)
        {
            if (!"ID".Equals(skinLabel11.Text.ToString()))
            {
                int id = Convert.ToInt32(skinLabel11.Text);
                String name = "";
                List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM RouteWayPoint WHERE ID = " + skinLabel11.Text);
                if (result.Count > 0)
                {
                    name = result[0]["PortId"].ToString();
                }
                ProfileHelper.Instance.Update("Delete FROM RouteWayPoint WHERE ID = " + id + "");

                showAllRouteWaypoint(name);
                skinButton1.Text = "新增";
                skinLabel11.Text = "ID";
            }
            init();
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
                String pointBegin = Convert.ToString(dictionary["PointBegin"]);
                String pointEnd = Convert.ToString(dictionary["PointEnd"]);
                String type = Convert.ToString(dictionary["Type"]);
                String show = Convert.ToString(dictionary["Show"]);
                Air_Route air_Route = new Air_Route(id, name, pointBegin, pointEnd, type, show);
                airRouteList.Add(air_Route);
            }

            this.dataGridView1.DataSource = null;
            if (null != airRouteList && airRouteList.Count() > 0)
            {
                this.dataGridView1.DataSource = this.airRouteList;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            String pointBegin = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String pointEnd = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            String type = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            String show = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            showLable(id, name, pointBegin, pointEnd, type, show);
            showAllRouteWaypoint(name);
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT MAX(Num) as Num FROM RouteWayPoint WHERE PortId = '" + name + "'");
            if (null != result && result.Count > 0)
            {
                if (null != result[0]["Num"] && result[0]["Num"].ToString().Length > 0)
                {
                    skinTextBox1.Text = (Convert.ToInt32(result[0]["Num"]) + 1).ToString();
                }
                else
                {
                    skinTextBox1.Text = "1";
                }
            }
            skinButton1.Text = "新增";
        }

        private void showAllRouteWaypoint(String name)
        {
            skinLabel11.Text = "ID";
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM RouteWayPoint WHERE PortId = '" + name + "'");
            routeWayPointList.Clear();
            foreach (Dictionary<string, object> dictionary in result)
            {
                int id = Convert.ToInt16(dictionary["ID"]);
                String portId = Convert.ToString(dictionary["PortId"]);
                String wayPoint = Convert.ToString(dictionary["WayPoint"]);
                int num = Convert.ToInt32(dictionary["Num"]);
                Route_WayPoint routeWayPoint = new Route_WayPoint(id, portId, wayPoint, num);
                routeWayPointList.Add(routeWayPoint);
            }

            this.dataGridView2.DataSource = null;
            if (null != routeWayPointList && routeWayPointList.Count() > 0)
            {
                this.dataGridView2.DataSource = this.routeWayPointList;
            }
        }

        private void showLable(int id, String name, String pointBegin, String pointEnd, String type, String show)
        {
            skinLabel5.Text = id.ToString();

            skinButton4.Text = "更新";
            skinButton6.Visible = true;
            skinTextBox2.Text = name;
            skinTextBox3.Text = name;
            
            int sel = comboBox1.Items.IndexOf(pointBegin);
            comboBox1.SelectedIndex = sel;
            sel = comboBox5.Items.IndexOf(pointEnd);
            comboBox5.SelectedIndex = sel;
            sel = comboBox3.Items.IndexOf(type);
            comboBox3.SelectedIndex = sel;
            sel = comboBox4.Items.IndexOf(show);
            comboBox4.SelectedIndex = sel;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            String portId = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            int num = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
            String wayPoint = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();

            showLableDown(id, portId, wayPoint, num);
        }

        private void showLableDown(int id, String portId, string wayPoint, int num)
        {
            skinLabel11.Text = id.ToString();
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM RouteWayPoint WHERE ID = " + id);
            if (null != result & result.Count > 0)
            {
                skinTextBox1.Text = result[0]["Num"].ToString();
            }
            
            skinButton1.Text = "更新";
            skinButton3.Visible = true;
            int sel = comboBox2.Items.IndexOf(wayPoint);
            comboBox2.SelectedIndex = sel;
        }

        private void init()
        {
            skinLabel5.Text = "ID";
            skinLabel11.Text = "ID";

            skinTextBox1.Text = "1";
            skinTextBox2.Text = "";
            skinTextBox3.Text = "";
            
            skinButton4.Text = "新增";
            comboBox1.SelectedValue = "";
            comboBox2.SelectedValue = "";
            comboBox5.SelectedValue = "";
            comboBox3.SelectedValue = "";
            comboBox4.SelectedValue = "";

            skinButton6.Visible = false;

        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            skinButton1.Text = "新增";
            skinButton3.Visible = false;
        }

        private void skinButton6_Click(object sender, EventArgs e)
        {
            skinButton4.Text = "新增";
            skinButton6.Visible = false;
        }

        private void skinButton5_Click(object sender, EventArgs e)
        {
            if (!"ID".Equals(skinLabel5.Text.ToString()))
            {
                String name = "";
                List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM AirRoute WHERE ID = " + skinLabel5.Text.ToString());
                if (result.Count > 0)
                {
                    name = result[0]["Name"].ToString();
                }
                ProfileHelper.Instance.Update("Delete FROM AirRoute WHERE Name = \"" + name + "\"");

                ProfileHelper.Instance.Update("Delete FROM RouteWayPoint WHERE PortId = '" + name + "'");

                showAllAirRoute();
            }
            init();
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

    private String pointBegin;
    public String PointBegin
    {
        get { return pointBegin; }
        set { pointBegin = value; }
    }

    private String pointEnd;
    public String PointEnd
    {
        get { return pointEnd; }
        set { pointEnd = value; }
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

    public Air_Route(int id, String name, String pointBegin, String pointEnd, String type, String show)
    {
        this.id = id;
        this.name = name;
        this.pointBegin = pointBegin;
        this.pointEnd = pointEnd;
        this.type = type;
        this.show = show;
    }
}


public class Route_WayPoint
{
    private int id;
    public int ID
    {
        get { return id; }
        set { id = value; }
    }
    private String portId;
    public String PortId
    {
        get { return portId; }
        set { portId = value; }
    }

    private String wayPoint;
    public String WayPoint
    {
        get { return wayPoint; }
        set { wayPoint = value; }
    }

    private int num;
    public int Num
    {
        get { return num; }
        set { num = value; }
    }
   
    public Route_WayPoint(int id, String portId, String wayPoint, int num)
    {
        this.id = id;
        this.portId = portId;
        this.wayPoint = wayPoint;
        this.num = num;
    }
}