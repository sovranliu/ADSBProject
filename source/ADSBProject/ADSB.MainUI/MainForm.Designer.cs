using System.Windows.Forms;
using GMap.NET.WindowsForms;

namespace ADSB.MainUI
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timerSPBarPlayback = new System.Windows.Forms.Timer(this.components);
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinProgressBar1 = new CCWin.SkinControl.SkinProgressBar();
            this.maskPlaybackRun = new ADSB.MainUI.Controls.MaskCircleLayer();
            this.button2 = new System.Windows.Forms.Button();
            this.maskPlaybackSetup = new ADSB.MainUI.Controls.MaskLayer();
            this.panelEx1 = new ADSB.MainUI.Controls.PanelEx(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.mapmask = new ADSB.MainUI.Controls.MaskLayer();
            this.skinPanel15 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel34 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel33 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel24 = new CCWin.SkinControl.SkinPanel();
            this.skinLine19 = new CCWin.SkinControl.SkinLine();
            this.skinPanel11 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel32 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel31 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel23 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel30 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel22 = new CCWin.SkinControl.SkinPanel();
            this.skinLine18 = new CCWin.SkinControl.SkinLine();
            this.skinLabel29 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel21 = new CCWin.SkinControl.SkinPanel();
            this.skinLine17 = new CCWin.SkinControl.SkinLine();
            this.skinPanel20 = new CCWin.SkinControl.SkinPanel();
            this.skinLine16 = new CCWin.SkinControl.SkinLine();
            this.skinLabel28 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel19 = new CCWin.SkinControl.SkinPanel();
            this.skinLine15 = new CCWin.SkinControl.SkinLine();
            this.skinLabel27 = new CCWin.SkinControl.SkinLabel();
            this.sPnl_dimianzhan = new CCWin.SkinControl.SkinPanel();
            this.skinLabel26 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel18 = new CCWin.SkinControl.SkinPanel();
            this.skinLine14 = new CCWin.SkinControl.SkinLine();
            this.skinLine9 = new CCWin.SkinControl.SkinLine();
            this.skinLine8 = new CCWin.SkinControl.SkinLine();
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLine1 = new CCWin.SkinControl.SkinLine();
            this.skinLine12 = new CCWin.SkinControl.SkinLine();
            this.skinLabel14 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel14 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel13 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel12 = new CCWin.SkinControl.SkinPanel();
            this.skinLine10 = new CCWin.SkinControl.SkinLine();
            this.skinLine11 = new CCWin.SkinControl.SkinLine();
            this.skinLabel19 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel21 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel22 = new CCWin.SkinControl.SkinLabel();
            this.gMapControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.skinPanel15.SuspendLayout();
            this.skinPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.AutoSize = true;
            this.gMapControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gMapControl1.BackColor = System.Drawing.Color.MistyRose;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Controls.Add(this.textBox5);
            this.gMapControl1.Controls.Add(this.textBox4);
            this.gMapControl1.Controls.Add(this.textBox3);
            this.gMapControl1.Controls.Add(this.textBox2);
            this.gMapControl1.Controls.Add(this.textBox1);
            this.gMapControl1.Controls.Add(this.panel1);
            this.gMapControl1.Controls.Add(this.dataGridView1);
            this.gMapControl1.Controls.Add(this.skinProgressBar1);
            this.gMapControl1.Controls.Add(this.maskPlaybackRun);
            this.gMapControl1.Controls.Add(this.button2);
            this.gMapControl1.Controls.Add(this.maskPlaybackSetup);
            this.gMapControl1.Controls.Add(this.panelEx1);
            this.gMapControl1.Controls.Add(this.button1);
            this.gMapControl1.Controls.Add(this.mapmask);
            this.gMapControl1.Controls.Add(this.skinPanel15);
            this.gMapControl1.Controls.Add(this.skinPanel3);
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(200);
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
            this.gMapControl1.Size = new System.Drawing.Size(1366, 749);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.mapControl_OnMarkerClick);
            this.gMapControl1.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.sMonitorDis_MouseOn);
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sMonitorDis_MouseDown);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(150, 184);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 35;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(150, 150);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 34;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 182);
            this.panel1.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(27, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "高度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(27, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "纬度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(27, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "经度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(35, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "FID：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "S模式地址：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb_check,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(35, 336);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(344, 219);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            // 
            // cb_check
            // 
            this.cb_check.DataPropertyName = "IsChecked";
            this.cb_check.FalseValue = false;
            this.cb_check.HeaderText = "选择";
            this.cb_check.Name = "cb_check";
            this.cb_check.ReadOnly = true;
            this.cb_check.TrueValue = true;
            this.cb_check.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "对象";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "编号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "显示半径";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "地面站Id";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // skinProgressBar1
            // 
            this.skinProgressBar1.Back = null;
            this.skinProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.skinProgressBar1.BarBack = null;
            this.skinProgressBar1.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.skinProgressBar1.Location = new System.Drawing.Point(0, 620);
            this.skinProgressBar1.Name = "skinProgressBar1";
            this.skinProgressBar1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar1.Size = new System.Drawing.Size(1280, 2);
            this.skinProgressBar1.TabIndex = 27;
            this.skinProgressBar1.TrackFore = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.skinProgressBar1.Value = 2;
            this.skinProgressBar1.Visible = false;
            // 
            // maskPlaybackRun
            // 
            this.maskPlaybackRun.BackColor = System.Drawing.Color.Transparent;
            this.maskPlaybackRun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maskPlaybackRun.BackgroundImage")));
            this.maskPlaybackRun.Location = new System.Drawing.Point(613, 640);
            this.maskPlaybackRun.Name = "maskPlaybackRun";
            this.maskPlaybackRun.Size = new System.Drawing.Size(52, 52);
            this.maskPlaybackRun.TabIndex = 26;
            this.maskPlaybackRun.Transparency = 100;
            this.maskPlaybackRun.Visible = false;
            this.maskPlaybackRun.Click += new System.EventHandler(this.maskPlaybackRun_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1245, 590);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 26);
            this.button2.TabIndex = 29;
            this.button2.Text = "取消测距";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // maskPlaybackSetup
            // 
            this.maskPlaybackSetup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.maskPlaybackSetup.Location = new System.Drawing.Point(31, 653);
            this.maskPlaybackSetup.Name = "maskPlaybackSetup";
            this.maskPlaybackSetup.Size = new System.Drawing.Size(56, 19);
            this.maskPlaybackSetup.TabIndex = 25;
            this.maskPlaybackSetup.Transparency = 100;
            this.maskPlaybackSetup.Click += new System.EventHandler(this.maskPlaybackSetup_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 635);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1362, 110);
            this.panelEx1.TabIndex = 21;
            this.panelEx1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEx1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1245, 560);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 27);
            this.button1.TabIndex = 28;
            this.button1.Text = "测距";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mapmask
            // 
            this.mapmask.BackColor = System.Drawing.Color.Black;
            this.mapmask.Location = new System.Drawing.Point(35, 77);
            this.mapmask.Name = "mapmask";
            this.mapmask.Size = new System.Drawing.Size(150, 150);
            this.mapmask.TabIndex = 24;
            this.mapmask.Transparency = 45;
            this.mapmask.Visible = false;
            // 
            // skinPanel15
            // 
            this.skinPanel15.BackColor = System.Drawing.Color.White;
            this.skinPanel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinPanel15.BackRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.skinPanel15.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.skinPanel15.Controls.Add(this.skinLabel34);
            this.skinPanel15.Controls.Add(this.skinLabel33);
            this.skinPanel15.Controls.Add(this.skinPanel24);
            this.skinPanel15.Controls.Add(this.skinLine19);
            this.skinPanel15.Controls.Add(this.skinPanel11);
            this.skinPanel15.Controls.Add(this.skinLabel32);
            this.skinPanel15.Controls.Add(this.skinLabel31);
            this.skinPanel15.Controls.Add(this.skinPanel23);
            this.skinPanel15.Controls.Add(this.skinLabel30);
            this.skinPanel15.Controls.Add(this.skinPanel22);
            this.skinPanel15.Controls.Add(this.skinLine18);
            this.skinPanel15.Controls.Add(this.skinLabel29);
            this.skinPanel15.Controls.Add(this.skinPanel21);
            this.skinPanel15.Controls.Add(this.skinLine17);
            this.skinPanel15.Controls.Add(this.skinPanel20);
            this.skinPanel15.Controls.Add(this.skinLine16);
            this.skinPanel15.Controls.Add(this.skinLabel28);
            this.skinPanel15.Controls.Add(this.skinPanel19);
            this.skinPanel15.Controls.Add(this.skinLine15);
            this.skinPanel15.Controls.Add(this.skinLabel27);
            this.skinPanel15.Controls.Add(this.sPnl_dimianzhan);
            this.skinPanel15.Controls.Add(this.skinLabel26);
            this.skinPanel15.Controls.Add(this.skinPanel18);
            this.skinPanel15.Controls.Add(this.skinLine14);
            this.skinPanel15.Controls.Add(this.skinLine9);
            this.skinPanel15.Controls.Add(this.skinLine8);
            this.skinPanel15.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel15.DownBack = null;
            this.skinPanel15.Location = new System.Drawing.Point(1252, 75);
            this.skinPanel15.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanel15.MouseBack = null;
            this.skinPanel15.Name = "skinPanel15";
            this.skinPanel15.NormlBack = null;
            this.skinPanel15.Palace = true;
            this.skinPanel15.Radius = 48;
            this.skinPanel15.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel15.Size = new System.Drawing.Size(59, 477);
            this.skinPanel15.TabIndex = 19;
            // 
            // skinLabel34
            // 
            this.skinLabel34.AutoSize = true;
            this.skinLabel34.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel34.BorderColor = System.Drawing.Color.White;
            this.skinLabel34.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel34.Location = new System.Drawing.Point(0, 387);
            this.skinLabel34.Name = "skinLabel34";
            this.skinLabel34.Size = new System.Drawing.Size(63, 16);
            this.skinLabel34.TabIndex = 38;
            this.skinLabel34.Text = "常用飞行器";
            this.skinLabel34.Click += new System.EventHandler(this.skinLabel34_Click);
            // 
            // skinLabel33
            // 
            this.skinLabel33.AutoSize = true;
            this.skinLabel33.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel33.BorderColor = System.Drawing.Color.White;
            this.skinLabel33.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel33.Location = new System.Drawing.Point(6, 337);
            this.skinLabel33.Name = "skinLabel33";
            this.skinLabel33.Size = new System.Drawing.Size(52, 16);
            this.skinLabel33.TabIndex = 36;
            this.skinLabel33.Text = "告警条件";
            this.skinLabel33.Click += new System.EventHandler(this.skinLabel33_Click);
            // 
            // skinPanel24
            // 
            this.skinPanel24.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel24.BackgroundImage")));
            this.skinPanel24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel24.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel24.DownBack = null;
            this.skinPanel24.Location = new System.Drawing.Point(19, 364);
            this.skinPanel24.MouseBack = null;
            this.skinPanel24.Name = "skinPanel24";
            this.skinPanel24.NormlBack = null;
            this.skinPanel24.Size = new System.Drawing.Size(20, 20);
            this.skinPanel24.TabIndex = 37;
            // 
            // skinLine19
            // 
            this.skinLine19.BackColor = System.Drawing.Color.Transparent;
            this.skinLine19.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine19.LineHeight = 1;
            this.skinLine19.Location = new System.Drawing.Point(9, 307);
            this.skinLine19.Name = "skinLine19";
            this.skinLine19.Size = new System.Drawing.Size(46, 2);
            this.skinLine19.TabIndex = 35;
            this.skinLine19.Text = "skinLine19";
            // 
            // skinPanel11
            // 
            this.skinPanel11.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel11.BackgroundImage")));
            this.skinPanel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel11.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel11.DownBack = null;
            this.skinPanel11.Location = new System.Drawing.Point(19, 315);
            this.skinPanel11.MouseBack = null;
            this.skinPanel11.Name = "skinPanel11";
            this.skinPanel11.NormlBack = null;
            this.skinPanel11.Size = new System.Drawing.Size(20, 20);
            this.skinPanel11.TabIndex = 35;
            // 
            // skinLabel32
            // 
            this.skinLabel32.AutoSize = true;
            this.skinLabel32.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel32.BorderColor = System.Drawing.Color.White;
            this.skinLabel32.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel32.Location = new System.Drawing.Point(16, 197);
            this.skinLabel32.Name = "skinLabel32";
            this.skinLabel32.Size = new System.Drawing.Size(30, 16);
            this.skinLabel32.TabIndex = 33;
            this.skinLabel32.Text = "航段";
            this.skinLabel32.Click += new System.EventHandler(this.skinLabel32_Click);
            // 
            // skinLabel31
            // 
            this.skinLabel31.AutoSize = true;
            this.skinLabel31.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel31.BorderColor = System.Drawing.Color.White;
            this.skinLabel31.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel31.Location = new System.Drawing.Point(16, 291);
            this.skinLabel31.Name = "skinLabel31";
            this.skinLabel31.Size = new System.Drawing.Size(30, 16);
            this.skinLabel31.TabIndex = 34;
            this.skinLabel31.Text = "空域";
            this.skinLabel31.Click += new System.EventHandler(this.skinLabel31_Click);
            // 
            // skinPanel23
            // 
            this.skinPanel23.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel23.BackgroundImage")));
            this.skinPanel23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel23.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel23.DownBack = null;
            this.skinPanel23.Location = new System.Drawing.Point(19, 173);
            this.skinPanel23.MouseBack = null;
            this.skinPanel23.Name = "skinPanel23";
            this.skinPanel23.NormlBack = null;
            this.skinPanel23.Size = new System.Drawing.Size(20, 20);
            this.skinPanel23.TabIndex = 32;
            // 
            // skinLabel30
            // 
            this.skinLabel30.AutoSize = true;
            this.skinLabel30.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel30.BorderColor = System.Drawing.Color.White;
            this.skinLabel30.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel30.Location = new System.Drawing.Point(16, 243);
            this.skinLabel30.Name = "skinLabel30";
            this.skinLabel30.Size = new System.Drawing.Size(30, 16);
            this.skinLabel30.TabIndex = 31;
            this.skinLabel30.Text = "航线";
            this.skinLabel30.Click += new System.EventHandler(this.skinLabel30_Click);
            // 
            // skinPanel22
            // 
            this.skinPanel22.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel22.BackgroundImage")));
            this.skinPanel22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel22.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel22.DownBack = null;
            this.skinPanel22.Location = new System.Drawing.Point(19, 267);
            this.skinPanel22.MouseBack = null;
            this.skinPanel22.Name = "skinPanel22";
            this.skinPanel22.NormlBack = null;
            this.skinPanel22.Size = new System.Drawing.Size(20, 20);
            this.skinPanel22.TabIndex = 33;
            // 
            // skinLine18
            // 
            this.skinLine18.BackColor = System.Drawing.Color.Transparent;
            this.skinLine18.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine18.LineHeight = 1;
            this.skinLine18.Location = new System.Drawing.Point(7, 260);
            this.skinLine18.Name = "skinLine18";
            this.skinLine18.Size = new System.Drawing.Size(46, 2);
            this.skinLine18.TabIndex = 32;
            this.skinLine18.Text = "skinLine18";
            // 
            // skinLabel29
            // 
            this.skinLabel29.AutoSize = true;
            this.skinLabel29.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel29.BorderColor = System.Drawing.Color.White;
            this.skinLabel29.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel29.Location = new System.Drawing.Point(11, 149);
            this.skinLabel29.Name = "skinLabel29";
            this.skinLabel29.Size = new System.Drawing.Size(41, 16);
            this.skinLabel29.TabIndex = 31;
            this.skinLabel29.Text = "航路点";
            this.skinLabel29.Click += new System.EventHandler(this.skinLabel29_Click);
            // 
            // skinPanel21
            // 
            this.skinPanel21.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel21.BackgroundImage")));
            this.skinPanel21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel21.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel21.DownBack = null;
            this.skinPanel21.Location = new System.Drawing.Point(19, 221);
            this.skinPanel21.MouseBack = null;
            this.skinPanel21.Name = "skinPanel21";
            this.skinPanel21.NormlBack = null;
            this.skinPanel21.Size = new System.Drawing.Size(20, 20);
            this.skinPanel21.TabIndex = 30;
            // 
            // skinLine17
            // 
            this.skinLine17.BackColor = System.Drawing.Color.Transparent;
            this.skinLine17.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine17.LineHeight = 1;
            this.skinLine17.Location = new System.Drawing.Point(3, 213);
            this.skinLine17.Name = "skinLine17";
            this.skinLine17.Size = new System.Drawing.Size(46, 2);
            this.skinLine17.TabIndex = 29;
            this.skinLine17.Text = "skinLine17";
            // 
            // skinPanel20
            // 
            this.skinPanel20.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel20.BackgroundImage")));
            this.skinPanel20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel20.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel20.DownBack = null;
            this.skinPanel20.Location = new System.Drawing.Point(19, 127);
            this.skinPanel20.MouseBack = null;
            this.skinPanel20.Name = "skinPanel20";
            this.skinPanel20.NormlBack = null;
            this.skinPanel20.Size = new System.Drawing.Size(20, 20);
            this.skinPanel20.TabIndex = 30;
            // 
            // skinLine16
            // 
            this.skinLine16.BackColor = System.Drawing.Color.Transparent;
            this.skinLine16.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine16.LineHeight = 1;
            this.skinLine16.Location = new System.Drawing.Point(7, 166);
            this.skinLine16.Name = "skinLine16";
            this.skinLine16.Size = new System.Drawing.Size(46, 2);
            this.skinLine16.TabIndex = 29;
            this.skinLine16.Text = "skinLine16";
            // 
            // skinLabel28
            // 
            this.skinLabel28.AutoSize = true;
            this.skinLabel28.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel28.BorderColor = System.Drawing.Color.White;
            this.skinLabel28.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel28.Location = new System.Drawing.Point(16, 101);
            this.skinLabel28.Name = "skinLabel28";
            this.skinLabel28.Size = new System.Drawing.Size(30, 16);
            this.skinLabel28.TabIndex = 28;
            this.skinLabel28.Text = "机场";
            this.skinLabel28.Click += new System.EventHandler(this.skinLabel28_Click);
            // 
            // skinPanel19
            // 
            this.skinPanel19.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel19.BackgroundImage")));
            this.skinPanel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel19.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel19.DownBack = null;
            this.skinPanel19.Location = new System.Drawing.Point(19, 78);
            this.skinPanel19.MouseBack = null;
            this.skinPanel19.Name = "skinPanel19";
            this.skinPanel19.NormlBack = null;
            this.skinPanel19.Size = new System.Drawing.Size(20, 20);
            this.skinPanel19.TabIndex = 26;
            // 
            // skinLine15
            // 
            this.skinLine15.BackColor = System.Drawing.Color.Transparent;
            this.skinLine15.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine15.LineHeight = 1;
            this.skinLine15.Location = new System.Drawing.Point(7, 410);
            this.skinLine15.Name = "skinLine15";
            this.skinLine15.Size = new System.Drawing.Size(46, 2);
            this.skinLine15.TabIndex = 27;
            this.skinLine15.Text = "skinLine15";
            // 
            // skinLabel27
            // 
            this.skinLabel27.AutoSize = true;
            this.skinLabel27.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel27.BorderColor = System.Drawing.Color.White;
            this.skinLabel27.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel27.Location = new System.Drawing.Point(11, 54);
            this.skinLabel27.Name = "skinLabel27";
            this.skinLabel27.Size = new System.Drawing.Size(41, 16);
            this.skinLabel27.TabIndex = 26;
            this.skinLabel27.Text = "地面站";
            this.skinLabel27.Click += new System.EventHandler(this.skinLabel27_Click);
            // 
            // sPnl_dimianzhan
            // 
            this.sPnl_dimianzhan.BackColor = System.Drawing.Color.Transparent;
            this.sPnl_dimianzhan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sPnl_dimianzhan.BackgroundImage")));
            this.sPnl_dimianzhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sPnl_dimianzhan.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sPnl_dimianzhan.DownBack = null;
            this.sPnl_dimianzhan.Location = new System.Drawing.Point(19, 24);
            this.sPnl_dimianzhan.MouseBack = null;
            this.sPnl_dimianzhan.Name = "sPnl_dimianzhan";
            this.sPnl_dimianzhan.NormlBack = null;
            this.sPnl_dimianzhan.Size = new System.Drawing.Size(20, 20);
            this.sPnl_dimianzhan.TabIndex = 25;
            this.sPnl_dimianzhan.Click += new System.EventHandler(this.sPnl_dimianzhan_Click);
            this.sPnl_dimianzhan.Paint += new System.Windows.Forms.PaintEventHandler(this.sPnl_dimianzhan_Paint);
            // 
            // skinLabel26
            // 
            this.skinLabel26.AutoSize = true;
            this.skinLabel26.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel26.BorderColor = System.Drawing.Color.White;
            this.skinLabel26.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel26.Location = new System.Drawing.Point(16, 437);
            this.skinLabel26.Name = "skinLabel26";
            this.skinLabel26.Size = new System.Drawing.Size(30, 16);
            this.skinLabel26.TabIndex = 24;
            this.skinLabel26.Text = "回放";
            this.skinLabel26.Click += new System.EventHandler(this.sPnl_playback_click);
            // 
            // skinPanel18
            // 
            this.skinPanel18.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel18.BackgroundImage")));
            this.skinPanel18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel18.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel18.DownBack = null;
            this.skinPanel18.Location = new System.Drawing.Point(22, 418);
            this.skinPanel18.MouseBack = null;
            this.skinPanel18.Name = "skinPanel18";
            this.skinPanel18.NormlBack = null;
            this.skinPanel18.Size = new System.Drawing.Size(14, 16);
            this.skinPanel18.TabIndex = 23;
            // 
            // skinLine14
            // 
            this.skinLine14.BackColor = System.Drawing.Color.Transparent;
            this.skinLine14.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine14.LineHeight = 1;
            this.skinLine14.Location = new System.Drawing.Point(9, 356);
            this.skinLine14.Name = "skinLine14";
            this.skinLine14.Size = new System.Drawing.Size(46, 2);
            this.skinLine14.TabIndex = 18;
            this.skinLine14.Text = "skinLine14";
            // 
            // skinLine9
            // 
            this.skinLine9.BackColor = System.Drawing.Color.Transparent;
            this.skinLine9.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine9.LineHeight = 1;
            this.skinLine9.Location = new System.Drawing.Point(7, 119);
            this.skinLine9.Name = "skinLine9";
            this.skinLine9.Size = new System.Drawing.Size(46, 2);
            this.skinLine9.TabIndex = 17;
            this.skinLine9.Text = "skinLine9";
            // 
            // skinLine8
            // 
            this.skinLine8.BackColor = System.Drawing.Color.Transparent;
            this.skinLine8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine8.LineHeight = 1;
            this.skinLine8.Location = new System.Drawing.Point(7, 71);
            this.skinLine8.Name = "skinLine8";
            this.skinLine8.Size = new System.Drawing.Size(46, 2);
            this.skinLine8.TabIndex = 0;
            this.skinLine8.Text = "skinLine8";
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.White;
            this.skinPanel3.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.skinPanel3.Controls.Add(this.skinLabel1);
            this.skinPanel3.Controls.Add(this.skinLine1);
            this.skinPanel3.Controls.Add(this.skinLine12);
            this.skinPanel3.Controls.Add(this.skinLabel14);
            this.skinPanel3.Controls.Add(this.skinPanel14);
            this.skinPanel3.Controls.Add(this.skinPanel13);
            this.skinPanel3.Controls.Add(this.skinPanel12);
            this.skinPanel3.Controls.Add(this.skinLine10);
            this.skinPanel3.Controls.Add(this.skinLine11);
            this.skinPanel3.Controls.Add(this.skinLabel19);
            this.skinPanel3.Controls.Add(this.skinLabel21);
            this.skinPanel3.Controls.Add(this.skinLabel22);
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Location = new System.Drawing.Point(875, 10);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.Radius = 5;
            this.skinPanel3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel3.Size = new System.Drawing.Size(438, 63);
            this.skinPanel3.TabIndex = 14;
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel1.Location = new System.Drawing.Point(367, 24);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 25;
            this.skinLabel1.Text = "系统设置";
            this.skinLabel1.Click += new System.EventHandler(this.skinLabel1_Click);
            // 
            // skinLine1
            // 
            this.skinLine1.BackColor = System.Drawing.Color.Transparent;
            this.skinLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine1.LineHeight = 100;
            this.skinLine1.Location = new System.Drawing.Point(351, 19);
            this.skinLine1.Margin = new System.Windows.Forms.Padding(0);
            this.skinLine1.Name = "skinLine1";
            this.skinLine1.Size = new System.Drawing.Size(7, 26);
            this.skinLine1.TabIndex = 24;
            this.skinLine1.Text = "skinLine1";
            // 
            // skinLine12
            // 
            this.skinLine12.BackColor = System.Drawing.Color.Transparent;
            this.skinLine12.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine12.LineHeight = 100;
            this.skinLine12.Location = new System.Drawing.Point(280, 19);
            this.skinLine12.Margin = new System.Windows.Forms.Padding(0);
            this.skinLine12.Name = "skinLine12";
            this.skinLine12.Size = new System.Drawing.Size(7, 26);
            this.skinLine12.TabIndex = 23;
            this.skinLine12.Text = "skinLine12";
            // 
            // skinLabel14
            // 
            this.skinLabel14.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel14.AutoSize = true;
            this.skinLabel14.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel14.BorderColor = System.Drawing.Color.White;
            this.skinLabel14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel14.Location = new System.Drawing.Point(292, 24);
            this.skinLabel14.Name = "skinLabel14";
            this.skinLabel14.Size = new System.Drawing.Size(56, 17);
            this.skinLabel14.TabIndex = 22;
            this.skinLabel14.Text = "离线地图";
            this.skinLabel14.Click += new System.EventHandler(this.skinLabel14_Click);
            // 
            // skinPanel14
            // 
            this.skinPanel14.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel14.BackgroundImage")));
            this.skinPanel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel14.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel14.DownBack = null;
            this.skinPanel14.Location = new System.Drawing.Point(213, 24);
            this.skinPanel14.MouseBack = null;
            this.skinPanel14.Name = "skinPanel14";
            this.skinPanel14.NormlBack = null;
            this.skinPanel14.Size = new System.Drawing.Size(21, 21);
            this.skinPanel14.TabIndex = 21;
            // 
            // skinPanel13
            // 
            this.skinPanel13.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel13.BackgroundImage")));
            this.skinPanel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel13.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel13.DownBack = null;
            this.skinPanel13.Location = new System.Drawing.Point(121, 24);
            this.skinPanel13.MouseBack = null;
            this.skinPanel13.Name = "skinPanel13";
            this.skinPanel13.NormlBack = null;
            this.skinPanel13.Size = new System.Drawing.Size(21, 19);
            this.skinPanel13.TabIndex = 20;
            // 
            // skinPanel12
            // 
            this.skinPanel12.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel12.BackgroundImage")));
            this.skinPanel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel12.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel12.DownBack = null;
            this.skinPanel12.Location = new System.Drawing.Point(27, 23);
            this.skinPanel12.MouseBack = null;
            this.skinPanel12.Name = "skinPanel12";
            this.skinPanel12.NormlBack = null;
            this.skinPanel12.Size = new System.Drawing.Size(22, 22);
            this.skinPanel12.TabIndex = 19;
            // 
            // skinLine10
            // 
            this.skinLine10.BackColor = System.Drawing.Color.Transparent;
            this.skinLine10.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine10.LineHeight = 100;
            this.skinLine10.Location = new System.Drawing.Point(189, 19);
            this.skinLine10.Margin = new System.Windows.Forms.Padding(0);
            this.skinLine10.Name = "skinLine10";
            this.skinLine10.Size = new System.Drawing.Size(7, 26);
            this.skinLine10.TabIndex = 17;
            this.skinLine10.Text = "skinLine10";
            // 
            // skinLine11
            // 
            this.skinLine11.BackColor = System.Drawing.Color.Transparent;
            this.skinLine11.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine11.LineHeight = 100;
            this.skinLine11.Location = new System.Drawing.Point(100, 19);
            this.skinLine11.Margin = new System.Windows.Forms.Padding(0);
            this.skinLine11.Name = "skinLine11";
            this.skinLine11.Size = new System.Drawing.Size(7, 26);
            this.skinLine11.TabIndex = 16;
            this.skinLine11.Text = "skinLine11";
            // 
            // skinLabel19
            // 
            this.skinLabel19.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel19.AutoSize = true;
            this.skinLabel19.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel19.BorderColor = System.Drawing.Color.White;
            this.skinLabel19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel19.Location = new System.Drawing.Point(240, 24);
            this.skinLabel19.Name = "skinLabel19";
            this.skinLabel19.Size = new System.Drawing.Size(32, 17);
            this.skinLabel19.TabIndex = 5;
            this.skinLabel19.Text = "工具";
            this.skinLabel19.Click += new System.EventHandler(this.sLabel_Tool_Click);
            // 
            // skinLabel21
            // 
            this.skinLabel21.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel21.AutoSize = true;
            this.skinLabel21.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel21.BorderColor = System.Drawing.Color.White;
            this.skinLabel21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel21.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.skinLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel21.Location = new System.Drawing.Point(148, 24);
            this.skinLabel21.Name = "skinLabel21";
            this.skinLabel21.Size = new System.Drawing.Size(32, 17);
            this.skinLabel21.TabIndex = 4;
            this.skinLabel21.Text = "告警";
            this.skinLabel21.Click += new System.EventHandler(this.sLabel_alarm_Click);
            // 
            // skinLabel22
            // 
            this.skinLabel22.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel22.AutoSize = true;
            this.skinLabel22.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel22.BorderColor = System.Drawing.Color.White;
            this.skinLabel22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel22.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel22.Location = new System.Drawing.Point(52, 24);
            this.skinLabel22.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel22.Name = "skinLabel22";
            this.skinLabel22.Size = new System.Drawing.Size(44, 17);
            this.skinLabel22.TabIndex = 3;
            this.skinLabel22.Text = "飞行器";
            this.skinLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skinLabel22.Click += new System.EventHandler(this.sLabel_flyFilter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.gMapControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 飞行监控系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.gMapControl1.ResumeLayout(false);
            this.gMapControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.skinPanel15.ResumeLayout(false);
            this.skinPanel15.PerformLayout();
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private CCWin.SkinControl.SkinTabControl sTabControl;
        //private CCWin.SkinControl.SkinTabPage sTpMonitor;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private CCWin.SkinControl.SkinPanel skinPanel3;
        private CCWin.SkinControl.SkinLine skinLine10;
        private CCWin.SkinControl.SkinLine skinLine11;
        private CCWin.SkinControl.SkinLabel skinLabel19;
        private CCWin.SkinControl.SkinLabel skinLabel21;
        private CCWin.SkinControl.SkinLabel skinLabel22;
        private CCWin.SkinControl.SkinPanel skinPanel12;
        private CCWin.SkinControl.SkinPanel skinPanel13;
        private CCWin.SkinControl.SkinPanel skinPanel14;
        private CCWin.SkinControl.SkinPanel skinPanel15;
        private CCWin.SkinControl.SkinLine skinLine8;
        private CCWin.SkinControl.SkinLine skinLine14;
        private CCWin.SkinControl.SkinLine skinLine9;
        private CCWin.SkinControl.SkinLabel skinLabel26;
        private CCWin.SkinControl.SkinPanel skinPanel18;
        private CCWin.SkinControl.SkinLabel skinLabel27;
        private CCWin.SkinControl.SkinPanel sPnl_dimianzhan;
        private Controls.PanelEx panelEx1;
        private Controls.MaskLayer mapmask;
        private Controls.MaskLayer maskPlaybackSetup;
        private Controls.MaskCircleLayer maskPlaybackRun;
        private CCWin.SkinControl.SkinProgressBar skinProgressBar1;
        private System.Windows.Forms.Timer timerSPBarPlayback;
        private System.Windows.Forms.Button button1;
        private Button button2;
        private CCWin.SkinControl.SkinLabel skinLabel28;
        private CCWin.SkinControl.SkinPanel skinPanel19;
        private CCWin.SkinControl.SkinLine skinLine15;
        private CCWin.SkinControl.SkinLabel skinLabel30;
        private CCWin.SkinControl.SkinLabel skinLabel29;
        private CCWin.SkinControl.SkinPanel skinPanel21;
        private CCWin.SkinControl.SkinLine skinLine17;
        private CCWin.SkinControl.SkinPanel skinPanel20;
        private CCWin.SkinControl.SkinLine skinLine16;
        private CCWin.SkinControl.SkinLabel skinLabel31;
        private CCWin.SkinControl.SkinPanel skinPanel22;
        private CCWin.SkinControl.SkinLine skinLine18;
        private CCWin.SkinControl.SkinLabel skinLabel32;
        private CCWin.SkinControl.SkinPanel skinPanel23;
        private CCWin.SkinControl.SkinLabel skinLabel33;
        private CCWin.SkinControl.SkinLine skinLine19;
        private CCWin.SkinControl.SkinPanel skinPanel11;
        private CCWin.SkinControl.SkinLabel skinLabel34;
        private CCWin.SkinControl.SkinPanel skinPanel24;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewCheckBoxColumn cb_check;
        private CCWin.SkinControl.SkinLabel skinLabel14;
        private CCWin.SkinControl.SkinLine skinLine12;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLine skinLine1;
        // private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}


