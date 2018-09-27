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
    public partial class Form_earthStation : Form_aTemplate
    {
        public Form_earthStation()
        {
            InitializeComponent();
        }

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
