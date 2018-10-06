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
            Air_Route air_Route = new Air_Route(1, name, comboBox1.Text);
            ProfileHelper.Instance.Update("INSERT INTO AirRoute (Id, Name, AirSegmentName) VALUES (" + air_Route.Id + ", '" + air_Route.Name + "', '" + air_Route.AirSegmentName + "')");

            if (null != comboBox2.Text && comboBox2.Text.Length > 0)
            {
                air_Route = new Air_Route(2, name, comboBox2.Text);
                ProfileHelper.Instance.Update("INSERT INTO AirRoute (Id, Name, AirSegmentName) VALUES (" + air_Route.Id + ", '" + air_Route.Name + "', '" + air_Route.AirSegmentName + "')");

                if (null != comboBox3.Text && comboBox3.Text.Length > 0)
                {
                    air_Route = new Air_Route(3, name, comboBox3.Text);
                    ProfileHelper.Instance.Update("INSERT INTO AirRoute (Id, Name, AirSegmentName) VALUES (" + air_Route.Id + ", '" + air_Route.Name + "', '" + air_Route.AirSegmentName + "')");

                    if (null != comboBox4.Text && comboBox4.Text.Length > 0)
                    {
                        air_Route = new Air_Route(4, name, comboBox4.Text);
                        ProfileHelper.Instance.Update("INSERT INTO AirRoute (Id, Name, AirSegmentName) VALUES (" + air_Route.Id + ", '" + air_Route.Name + "', '" + air_Route.AirSegmentName + "')");

                        if (null != comboBox5.Text && comboBox5.Text.Length > 0)
                        {
                            air_Route = new Air_Route(5, name, comboBox5.Text);
                            ProfileHelper.Instance.Update("INSERT INTO AirRoute (Id, Name, AirSegmentName) VALUES (" + air_Route.Id + ", '" + air_Route.Name + "', '" + air_Route.AirSegmentName + "')");
                        }
                    }
                }
            }

            // todo 保存到数据库

            showAllAirRoute();
            airRoute_event(true, 2);

            // MessageBox.Show("新增成功！");
        }

        private void InitializeGMap()
        {
            // 下拉框初始化
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM AirSegment ");
            foreach (Dictionary<string, object> dictionary in result)
            {
                String name = Convert.ToString(dictionary["Name"]);
                comboBox1.Items.Add(name);
                comboBox2.Items.Add(name);
                comboBox3.Items.Add(name);
                comboBox4.Items.Add(name);
                comboBox5.Items.Add(name);
            }

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
                int id = Convert.ToInt16(dictionary["Id"]);
                String name = Convert.ToString(dictionary["Name"]);
                String airSegmentName = Convert.ToString(dictionary["AirSegmentName"]);
                Air_Route air_Route = new Air_Route(id, name, airSegmentName);
                airRouteList.Add(air_Route);
            }

            this.dataGridView1.DataSource = null;
            if (null != airRouteList && airRouteList.Count() > 0)
            {
                this.dataGridView1.DataSource = this.airRouteList;
            }
            
        }


    }
}

public class Air_Route
{
    private String name;
    public String Name
    {
        get { return name; }
        set { name = value; }
    }

    private int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    private String airSegmentName;
    public String AirSegmentName
    {
        get { return airSegmentName; }
        set { airSegmentName = value; }
    }

    public Air_Route(int id, String name, String airSegmentName)
    {
        this.id = id;
        this.name = name;
        this.airSegmentName = airSegmentName;
    }
}