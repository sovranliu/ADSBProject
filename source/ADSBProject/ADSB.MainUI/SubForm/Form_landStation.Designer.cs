﻿using System.Windows.Forms;

namespace ADSB.MainUI.SubForm
{
    partial class Form_landStation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_landStation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.sPnl_close = new CCWin.SkinControl.SkinPanel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox2 = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBox3 = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBox4 = new CCWin.SkinControl.SkinTextBox();
            this.horizonLine1 = new ADSB.MainUI.Controls.HorizonLine();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox5 = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBox6 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.cb_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.经度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.纬度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.环数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.环距离 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.skinLabel1.Location = new System.Drawing.Point(99, 21);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(117, 28);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "地面站管理";
            // 
            // sPnl_close
            // 
            this.sPnl_close.BackColor = System.Drawing.Color.Transparent;
            this.sPnl_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sPnl_close.BackgroundImage")));
            this.sPnl_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sPnl_close.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sPnl_close.DownBack = null;
            this.sPnl_close.Location = new System.Drawing.Point(888, 0);
            this.sPnl_close.MouseBack = null;
            this.sPnl_close.Name = "sPnl_close";
            this.sPnl_close.NormlBack = null;
            this.sPnl_close.Size = new System.Drawing.Size(22, 22);
            this.sPnl_close.TabIndex = 3;
            this.sPnl_close.Click += new System.EventHandler(this.sPnl_close_Click);
            this.sPnl_close.Paint += new System.Windows.Forms.PaintEventHandler(this.sPnl_close_Paint);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BackRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.skinButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(104)))), ((int)(((byte)(190)))));
            this.skinButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(104)))), ((int)(((byte)(190)))));
            this.skinButton1.BorderInflate = new System.Drawing.Size(0, 0);
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(104)))), ((int)(((byte)(190)))));
            this.skinButton1.FadeGlow = false;
            this.skinButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinButton1.Font = new System.Drawing.Font("微软雅黑", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinButton1.ForeColor = System.Drawing.Color.White;
            this.skinButton1.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton1.IsDrawBorder = false;
            this.skinButton1.IsDrawGlass = false;
            this.skinButton1.Location = new System.Drawing.Point(29, 244);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 44;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(110, 44);
            this.skinButton1.TabIndex = 9;
            this.skinButton1.Text = "新增";
            this.skinButton1.UseMnemonic = false;
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinLabel8
            // 
            this.skinLabel8.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel8.Location = new System.Drawing.Point(11, 95);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(48, 19);
            this.skinLabel8.TabIndex = 15;
            this.skinLabel8.Text = "名称：";
            this.skinLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinLabel9
            // 
            this.skinLabel9.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel9.Location = new System.Drawing.Point(11, 150);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(48, 19);
            this.skinLabel9.TabIndex = 16;
            this.skinLabel9.Text = "经度：";
            this.skinLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinLabel3
            // 
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel3.Location = new System.Drawing.Point(231, 150);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(48, 19);
            this.skinLabel3.TabIndex = 17;
            this.skinLabel3.Text = "纬度：";
            this.skinLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinTextBox2
            // 
            this.skinTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox2.DownBack = null;
            this.skinTextBox2.Icon = null;
            this.skinTextBox2.IconIsButton = false;
            this.skinTextBox2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.IsPasswordChat = '\0';
            this.skinTextBox2.IsSystemPasswordChar = false;
            this.skinTextBox2.Lines = new string[0];
            this.skinTextBox2.Location = new System.Drawing.Point(96, 86);
            this.skinTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox2.MaxLength = 32767;
            this.skinTextBox2.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox2.MouseBack = null;
            this.skinTextBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Multiline = true;
            this.skinTextBox2.Name = "skinTextBox2";
            this.skinTextBox2.NormlBack = null;
            this.skinTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox2.ReadOnly = false;
            this.skinTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox2.Size = new System.Drawing.Size(120, 40);
            // 
            // 
            // 
            this.skinTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinTextBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox2.SkinTxt.Multiline = true;
            this.skinTextBox2.SkinTxt.Name = "BaseText";
            this.skinTextBox2.SkinTxt.Size = new System.Drawing.Size(110, 30);
            this.skinTextBox2.SkinTxt.TabIndex = 0;
            this.skinTextBox2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.SkinTxt.WaterText = "";
            this.skinTextBox2.TabIndex = 19;
            this.skinTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.WaterText = "";
            this.skinTextBox2.WordWrap = true;
            // 
            // skinTextBox3
            // 
            this.skinTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox3.DownBack = null;
            this.skinTextBox3.Icon = null;
            this.skinTextBox3.IconIsButton = false;
            this.skinTextBox3.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox3.IsPasswordChat = '\0';
            this.skinTextBox3.IsSystemPasswordChar = false;
            this.skinTextBox3.Lines = new string[0];
            this.skinTextBox3.Location = new System.Drawing.Point(96, 138);
            this.skinTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox3.MaxLength = 32767;
            this.skinTextBox3.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox3.MouseBack = null;
            this.skinTextBox3.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox3.Multiline = true;
            this.skinTextBox3.Name = "skinTextBox3";
            this.skinTextBox3.NormlBack = null;
            this.skinTextBox3.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox3.ReadOnly = false;
            this.skinTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox3.Size = new System.Drawing.Size(120, 40);
            // 
            // 
            // 
            this.skinTextBox3.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox3.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox3.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinTextBox3.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox3.SkinTxt.Multiline = true;
            this.skinTextBox3.SkinTxt.Name = "BaseText";
            this.skinTextBox3.SkinTxt.Size = new System.Drawing.Size(110, 30);
            this.skinTextBox3.SkinTxt.TabIndex = 0;
            this.skinTextBox3.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox3.SkinTxt.WaterText = "";
            this.skinTextBox3.TabIndex = 19;
            this.skinTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox3.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox3.WaterText = "";
            this.skinTextBox3.WordWrap = true;
            // 
            // skinTextBox4
            // 
            this.skinTextBox4.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox4.DownBack = null;
            this.skinTextBox4.Icon = null;
            this.skinTextBox4.IconIsButton = false;
            this.skinTextBox4.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox4.IsPasswordChat = '\0';
            this.skinTextBox4.IsSystemPasswordChar = false;
            this.skinTextBox4.Lines = new string[0];
            this.skinTextBox4.Location = new System.Drawing.Point(296, 138);
            this.skinTextBox4.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox4.MaxLength = 32767;
            this.skinTextBox4.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox4.MouseBack = null;
            this.skinTextBox4.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox4.Multiline = true;
            this.skinTextBox4.Name = "skinTextBox4";
            this.skinTextBox4.NormlBack = null;
            this.skinTextBox4.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox4.ReadOnly = false;
            this.skinTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox4.Size = new System.Drawing.Size(120, 40);
            // 
            // 
            // 
            this.skinTextBox4.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox4.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox4.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinTextBox4.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox4.SkinTxt.Multiline = true;
            this.skinTextBox4.SkinTxt.Name = "BaseText";
            this.skinTextBox4.SkinTxt.Size = new System.Drawing.Size(110, 30);
            this.skinTextBox4.SkinTxt.TabIndex = 0;
            this.skinTextBox4.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox4.SkinTxt.WaterText = "";
            this.skinTextBox4.TabIndex = 19;
            this.skinTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox4.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox4.WaterText = "";
            this.skinTextBox4.WordWrap = true;
            // 
            // horizonLine1
            // 
            this.horizonLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.horizonLine1.LineBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.horizonLine1.LineDashColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.horizonLine1.LineDashLength = 5;
            this.horizonLine1.LineLength = 217;
            this.horizonLine1.LineWidth = 1;
            this.horizonLine1.Location = new System.Drawing.Point(108, 62);
            this.horizonLine1.Margin = new System.Windows.Forms.Padding(4);
            this.horizonLine1.Name = "horizonLine1";
            this.horizonLine1.Size = new System.Drawing.Size(219, 3);
            this.horizonLine1.TabIndex = 20;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(534, 62);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(363, 469);
            this.gMapControl1.TabIndex = 21;
            this.gMapControl1.Zoom = 0D;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BackRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.skinButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(104)))), ((int)(((byte)(190)))));
            this.skinButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(104)))), ((int)(((byte)(190)))));
            this.skinButton2.BorderInflate = new System.Drawing.Size(0, 0);
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(104)))), ((int)(((byte)(190)))));
            this.skinButton2.FadeGlow = false;
            this.skinButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinButton2.Font = new System.Drawing.Font("微软雅黑", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinButton2.ForeColor = System.Drawing.Color.White;
            this.skinButton2.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton2.IsDrawBorder = false;
            this.skinButton2.IsDrawGlass = false;
            this.skinButton2.Location = new System.Drawing.Point(162, 244);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Radius = 44;
            this.skinButton2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton2.Size = new System.Drawing.Size(117, 44);
            this.skinButton2.TabIndex = 22;
            this.skinButton2.Text = "删除";
            this.skinButton2.UseMnemonic = false;
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false; 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb_check,
            this.name,
            this.IP,
            this.经度,
            this.纬度,
            this.环数,
            this.环距离,
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(12, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(504, 226);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[0];
            this.skinTextBox1.Location = new System.Drawing.Point(296, 86);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = true;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(120, 40);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Multiline = true;
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(110, 30);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 21;
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel2.Location = new System.Drawing.Point(231, 98);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(34, 19);
            this.skinLabel2.TabIndex = 20;
            this.skinLabel2.Text = "IP：";
            this.skinLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinTextBox5
            // 
            this.skinTextBox5.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox5.DownBack = null;
            this.skinTextBox5.Icon = null;
            this.skinTextBox5.IconIsButton = false;
            this.skinTextBox5.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox5.IsPasswordChat = '\0';
            this.skinTextBox5.IsSystemPasswordChar = false;
            this.skinTextBox5.Lines = new string[0];
            this.skinTextBox5.Location = new System.Drawing.Point(96, 190);
            this.skinTextBox5.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox5.MaxLength = 32767;
            this.skinTextBox5.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox5.MouseBack = null;
            this.skinTextBox5.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox5.Multiline = true;
            this.skinTextBox5.Name = "skinTextBox5";
            this.skinTextBox5.NormlBack = null;
            this.skinTextBox5.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox5.ReadOnly = false;
            this.skinTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox5.Size = new System.Drawing.Size(120, 40);
            // 
            // 
            // 
            this.skinTextBox5.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox5.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox5.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinTextBox5.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox5.SkinTxt.Multiline = true;
            this.skinTextBox5.SkinTxt.Name = "BaseText";
            this.skinTextBox5.SkinTxt.Size = new System.Drawing.Size(110, 30);
            this.skinTextBox5.SkinTxt.TabIndex = 0;
            this.skinTextBox5.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox5.SkinTxt.WaterText = "";
            this.skinTextBox5.TabIndex = 22;
            this.skinTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox5.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox5.WaterText = "";
            this.skinTextBox5.WordWrap = true;
            // 
            // skinTextBox6
            // 
            this.skinTextBox6.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox6.DownBack = null;
            this.skinTextBox6.Icon = null;
            this.skinTextBox6.IconIsButton = false;
            this.skinTextBox6.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox6.IsPasswordChat = '\0';
            this.skinTextBox6.IsSystemPasswordChar = false;
            this.skinTextBox6.Lines = new string[0];
            this.skinTextBox6.Location = new System.Drawing.Point(296, 190);
            this.skinTextBox6.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox6.MaxLength = 32767;
            this.skinTextBox6.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox6.MouseBack = null;
            this.skinTextBox6.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox6.Multiline = true;
            this.skinTextBox6.Name = "skinTextBox6";
            this.skinTextBox6.NormlBack = null;
            this.skinTextBox6.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox6.ReadOnly = false;
            this.skinTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox6.Size = new System.Drawing.Size(120, 40);
            // 
            // 
            // 
            this.skinTextBox6.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox6.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox6.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinTextBox6.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox6.SkinTxt.Multiline = true;
            this.skinTextBox6.SkinTxt.Name = "BaseText";
            this.skinTextBox6.SkinTxt.Size = new System.Drawing.Size(110, 30);
            this.skinTextBox6.SkinTxt.TabIndex = 0;
            this.skinTextBox6.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox6.SkinTxt.WaterText = "";
            this.skinTextBox6.TabIndex = 23;
            this.skinTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox6.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox6.WaterText = "";
            this.skinTextBox6.WordWrap = true;
            // 
            // skinLabel4
            // 
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel4.Location = new System.Drawing.Point(231, 200);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(61, 19);
            this.skinLabel4.TabIndex = 21;
            this.skinLabel4.Text = "环距离：";
            this.skinLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinLabel5
            // 
            this.skinLabel5.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel5.Location = new System.Drawing.Point(11, 202);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(48, 19);
            this.skinLabel5.TabIndex = 20;
            this.skinLabel5.Text = "环数：";
            this.skinLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinLabel6
            // 
            this.skinLabel6.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel6.Location = new System.Drawing.Point(445, 86);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(23, 19);
            this.skinLabel6.TabIndex = 24;
            this.skinLabel6.Text = "ID";
            this.skinLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.skinLabel6.Visible = false;
            // 
            // skinLabel7
            // 
            this.skinLabel7.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel7.ForeColor = System.Drawing.Color.Red;
            this.skinLabel7.Location = new System.Drawing.Point(303, 258);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(89, 21);
            this.skinLabel7.TabIndex = 25;
            this.skinLabel7.Text = "当前主地面站";
            this.skinLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinLabel10
            // 
            this.skinLabel10.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel10.Location = new System.Drawing.Point(396, 258);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(0, 19);
            this.skinLabel10.TabIndex = 26;
            this.skinLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_check
            // 
            this.cb_check.DataPropertyName = "cb_check";
            this.cb_check.HeaderText = "主地面站";
            this.cb_check.Name = "cb_check";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            // 
            // IP
            // 
            this.IP.DataPropertyName = "ip";
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            // 
            // 经度
            // 
            this.经度.DataPropertyName = "lat";
            this.经度.HeaderText = "经度";
            this.经度.Name = "经度";
            // 
            // 纬度
            // 
            this.纬度.DataPropertyName = "lng";
            this.纬度.HeaderText = "纬度";
            this.纬度.Name = "纬度";
            // 
            // 环数
            // 
            this.环数.DataPropertyName = "num";
            this.环数.HeaderText = "环数";
            this.环数.Name = "环数";
            // 
            // 环距离
            // 
            this.环距离.DataPropertyName = "length";
            this.环距离.HeaderText = "环距离";
            this.环距离.Name = "环距离";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Form_landStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(911, 573);
            this.Controls.Add(this.skinLabel10);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.skinTextBox5);
            this.Controls.Add(this.skinTextBox6);
            this.Controls.Add(this.skinTextBox1);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.horizonLine1);
            this.Controls.Add(this.skinTextBox2);
            this.Controls.Add(this.skinTextBox3);
            this.Controls.Add(this.skinTextBox4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel9);
            this.Controls.Add(this.skinLabel8);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.sPnl_close);
            this.Controls.Add(this.skinLabel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_landStation";
            this.Text = "Form_landStation";
            this.TopMost = false;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinPanel sPnl_close;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinTextBox skinTextBox2;
        private CCWin.SkinControl.SkinTextBox skinTextBox3;
        private CCWin.SkinControl.SkinTextBox skinTextBox4;
        private Controls.HorizonLine horizonLine1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox skinTextBox5;
        private CCWin.SkinControl.SkinTextBox skinTextBox6;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewCheckBoxColumn cb_check;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn IP;
        private DataGridViewTextBoxColumn 经度;
        private DataGridViewTextBoxColumn 纬度;
        private DataGridViewTextBoxColumn 环数;
        private DataGridViewTextBoxColumn 环距离;
        private DataGridViewTextBoxColumn ID;
    }
}