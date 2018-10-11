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
    public partial class Form_setup : Form_aTemplate
    {
        public delegate void commonPlane(Boolean selected);
        public event commonPlane commonPlane_event;
        public Form_setup()
        {
            InitializeComponent();

            // 中心飞行器
            String my_sAddress = ConfigHelper.Instance.GetConfig("my_sAddress");
            if (!string.IsNullOrWhiteSpace(my_sAddress))
            {
                skinTextBox3.Text = my_sAddress;
            }

            showAllCommonPlane();
        }

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(skinTextBox3.Text))
            {
                ConfigHelper.Instance.SetConfig("my_sAddress", skinTextBox3.Text);
            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            String name = skinTextBox1.Text;
            if (null == name || name.Length == 0)
            {
                MessageBox.Show("请取一个名字！");
                return;
            }
            String sModeAddress = skinTextBox2.Text;
            if (null == sModeAddress || sModeAddress.Length == 0)
            {
                MessageBox.Show("请输入常用飞行器S模式地址！");
                return;
            }
            
            // 插入数据库
            ProfileHelper.Instance.Update("INSERT INTO CommonPlane (ID, Name, SModeAddress) " +
            "VALUES (NULL, '" + name + "', '" + sModeAddress + "')");

            showAllCommonPlane();
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            if (null != dataGridView1.CurrentRow)
            {
                String id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                ProfileHelper.Instance.Update("Delete FROM CommonPlane WHERE ID = \"" + id + "\"");
                showAllCommonPlane();
            }
        }

        private List<Common_Plane> commonPlaneList = new List<Common_Plane>();

        private void showAllCommonPlane()
        {
            List<Dictionary<string, object>> result = ProfileHelper.Instance.Select("SELECT * FROM CommonPlane");
            commonPlaneList.Clear();
            foreach (Dictionary<string, object> dictionary in result)
            {
                int id = Convert.ToInt32(dictionary["ID"]);
                String name = Convert.ToString(dictionary["Name"]);
                String sModeAddress = Convert.ToString(dictionary["SModeAddress"]);

                Common_Plane air_Port = new Common_Plane(id, name, sModeAddress);
                commonPlaneList.Add(air_Port);
            }

            this.dataGridView1.DataSource = null;
            if (null != commonPlaneList && commonPlaneList.Count() > 0)
            {
                this.dataGridView1.DataSource = this.commonPlaneList;
            }

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected)
            {
                if (null != dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    string cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    int id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    String name = Convert.ToString(this.dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    String sModeAddress = Convert.ToString(this.dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    // 更新数据库
                    ProfileHelper.Instance.Update(
                       "UPDATE CommonPlane set " +
                            " Name = '" + name + "', " +
                            " SModeAddress = '" + sModeAddress +
                            "' where ID = " + id);
                }
                skinTextBox1.Text = "";
                skinTextBox2.Text = "";
            }

        }

        public class Common_Plane
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
            private String sModeAddress;
            public String SModeAddress
            {
                get { return sModeAddress; }
                set { sModeAddress = value; }
            }

            public Common_Plane(int id, String name, String sModeAddress)
            {
                this.id = id;
                this.name = name;
                this.sModeAddress = sModeAddress;
            }
        }

        private void sPnl_close_Paint(object sender, PaintEventArgs e)
        {
            commonPlane_event(true);
        }
    }
}
