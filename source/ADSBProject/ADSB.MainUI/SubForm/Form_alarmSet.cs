﻿using System;
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
    public partial class Form_alarmSet : Form
    {
        public Form_alarmSet()
        {
            InitializeComponent();
            this.skinTextBox1.Text = ConfigHelper.Instance.GetConfig("alarm_distance");
            this.skinTextBox2.Text = ConfigHelper.Instance.GetConfig("alarm_hight");
        }

        private void sPnl_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (!this.skinTextBox1.Text.Equals(""))
            {
                ConfigHelper.Instance.SetConfig("alarm_distance", this.skinTextBox1.Text);
            }
            if (!this.skinTextBox2.Text.Equals(""))
            {
                ConfigHelper.Instance.SetConfig("alarm_hight", this.skinTextBox2.Text);
            }
        }
    }
}