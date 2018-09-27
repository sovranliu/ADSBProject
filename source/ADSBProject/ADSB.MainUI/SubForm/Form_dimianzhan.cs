using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; 
using System.Windows.Forms;

namespace ADSB.MainUI.SubForm
{
    public partial class Form_dimianzhan : Form
    {
        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex); 
        public Form_dimianzhan()
        {
            InitializeComponent();
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
        }

        private void sLabel_add_Click(object sender, EventArgs e)
        {

            listView1.View = View.List;
            this.listView1.BeginUpdate();
            for(int i=0;i<10;i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = "item" + i;
                this.listView1.Items.Add(lvi);

            }
            this.listView1.EndUpdate();


        }
    }
}
