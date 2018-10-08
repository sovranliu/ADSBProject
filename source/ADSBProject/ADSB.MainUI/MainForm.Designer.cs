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
            this.sTabControl = new CCWin.SkinControl.SkinTabControl();
            this.sTpFly = new CCWin.SkinControl.SkinTabPage();
            this.sPnl_Func = new CCWin.SkinControl.SkinPanel();
            this.sPnl_Compass = new CCWin.SkinControl.SkinPanel();
            this.skinPanel7 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel20 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.skinLine7 = new CCWin.SkinControl.SkinLine();
            this.skinPanel6 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel5 = new CCWin.SkinControl.SkinPanel();
            this.sPnl_liangcheng = new CCWin.SkinControl.SkinPanel();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.skinLine6 = new CCWin.SkinControl.SkinLine();
            this.skinLine5 = new CCWin.SkinControl.SkinLine();
            this.skinLine4 = new CCWin.SkinControl.SkinLine();
            this.skinLine3 = new CCWin.SkinControl.SkinLine();
            this.skinLine1 = new CCWin.SkinControl.SkinLine();
            this.skinLine2 = new CCWin.SkinControl.SkinLine();
            this.sLabel_info = new CCWin.SkinControl.SkinLabel();
            this.skinLabel18 = new CCWin.SkinControl.SkinLabel();
            this.sLabelAltitude = new CCWin.SkinControl.SkinLabel();
            this.skinLabel16 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel15 = new CCWin.SkinControl.SkinLabel();
            this.sLabel_expandCompass = new CCWin.SkinControl.SkinLabel();
            this.skinLabel13 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel4 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.sPanelMonitor = new CCWin.SkinControl.SkinPanel();
            this.sLabelMonitor = new CCWin.SkinControl.SkinLabel();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.sLabel2 = new CCWin.SkinControl.SkinLabel();
            this.slabel1 = new CCWin.SkinControl.SkinLabel();
            this.sTpMonitor = new CCWin.SkinControl.SkinTabPage();
            this.skinProgressBar1 = new CCWin.SkinControl.SkinProgressBar();
            this.maskPlaybackRun = new ADSB.MainUI.Controls.MaskCircleLayer();
            this.maskPlaybackSetup = new ADSB.MainUI.Controls.MaskLayer();
            this.panelEx1 = new ADSB.MainUI.Controls.PanelEx(this.components);
            this.mapmask = new ADSB.MainUI.Controls.MaskLayer();
            this.skinPanel15 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel34 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel33 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel24 = new CCWin.SkinControl.SkinPanel();
            this.skinLine19 = new CCWin.SkinControl.SkinLine();
            this.skinPanel11 = new CCWin.SkinControl.SkinPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.skinLabel32 = new CCWin.SkinControl.SkinLabel();
            this.button1 = new System.Windows.Forms.Button();
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
            this.skinPanel14 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel13 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel12 = new CCWin.SkinControl.SkinPanel();
            this.skinLine10 = new CCWin.SkinControl.SkinLine();
            this.skinLine11 = new CCWin.SkinControl.SkinLine();
            this.skinLine12 = new CCWin.SkinControl.SkinLine();
            this.skinLine13 = new CCWin.SkinControl.SkinLine();
            this.skinLabel19 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel21 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel22 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel23 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel24 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel10 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel17 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel17 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel16 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel14 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel8 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel9 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel25 = new CCWin.SkinControl.SkinLabel();
            this.sPnl_Fly = new CCWin.SkinControl.SkinPanel();
            this.sLabel_fly = new CCWin.SkinControl.SkinLabel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.timerSPBarPlayback = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTabControl.SuspendLayout();
            this.sTpFly.SuspendLayout();
            this.skinPanel7.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            this.skinPanel4.SuspendLayout();
            this.sPanelMonitor.SuspendLayout();
            this.sTpMonitor.SuspendLayout();
            this.skinPanel15.SuspendLayout();
            this.skinPanel3.SuspendLayout();
            this.skinPanel8.SuspendLayout();
            this.skinPanel9.SuspendLayout();
            this.sPnl_Fly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sTabControl
            // 
            this.sTabControl.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.sTabControl.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.sTabControl.Controls.Add(this.sTpFly);
            this.sTabControl.Controls.Add(this.sTpMonitor);
            this.sTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTabControl.HeadBack = null;
            this.sTabControl.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.sTabControl.ItemSize = new System.Drawing.Size(70, 36);
            this.sTabControl.Location = new System.Drawing.Point(0, 0);
            this.sTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.sTabControl.Name = "sTabControl";
            this.sTabControl.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("sTabControl.PageArrowDown")));
            this.sTabControl.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("sTabControl.PageArrowHover")));
            this.sTabControl.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("sTabControl.PageCloseHover")));
            this.sTabControl.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("sTabControl.PageCloseNormal")));
            this.sTabControl.PageDown = ((System.Drawing.Image)(resources.GetObject("sTabControl.PageDown")));
            this.sTabControl.PageHover = ((System.Drawing.Image)(resources.GetObject("sTabControl.PageHover")));
            this.sTabControl.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.sTabControl.PageNorml = null;
            this.sTabControl.SelectedIndex = 1;
            this.sTabControl.Size = new System.Drawing.Size(1920, 1100);
            this.sTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.sTabControl.TabIndex = 0;
            // 
            // sTpFly
            // 
            this.sTpFly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.sTpFly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sTpFly.Controls.Add(this.sPnl_Func);
            this.sTpFly.Controls.Add(this.sPnl_Compass);
            this.sTpFly.Controls.Add(this.skinPanel7);
            this.sTpFly.Controls.Add(this.skinPanel6);
            this.sTpFly.Controls.Add(this.skinPanel5);
            this.sTpFly.Controls.Add(this.sPnl_liangcheng);
            this.sTpFly.Controls.Add(this.skinPanel2);
            this.sTpFly.Controls.Add(this.skinPanel1);
            this.sTpFly.Controls.Add(this.skinLabel10);
            this.sTpFly.Controls.Add(this.skinLabel9);
            this.sTpFly.Controls.Add(this.skinLabel8);
            this.sTpFly.Controls.Add(this.skinLabel5);
            this.sTpFly.Controls.Add(this.skinLabel6);
            this.sTpFly.Controls.Add(this.skinLabel7);
            this.sTpFly.Controls.Add(this.skinLabel4);
            this.sTpFly.Controls.Add(this.skinLabel3);
            this.sTpFly.Controls.Add(this.skinLabel1);
            this.sTpFly.Controls.Add(this.skinLabel2);
            this.sTpFly.Controls.Add(this.sLabel2);
            this.sTpFly.Controls.Add(this.slabel1);
            this.sTpFly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTpFly.Location = new System.Drawing.Point(0, 36);
            this.sTpFly.Margin = new System.Windows.Forms.Padding(4);
            this.sTpFly.Name = "sTpFly";
            this.sTpFly.Size = new System.Drawing.Size(1920, 1064);
            this.sTpFly.TabIndex = 0;
            this.sTpFly.TabItemImage = null;
            this.sTpFly.Text = "skinTabPage1";
            this.sTpFly.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sTpFly_MouseDown);
            this.sTpFly.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sTpFly_MouseMove_1);
            // 
            // sPnl_Func
            // 
            this.sPnl_Func.BackColor = System.Drawing.Color.Transparent;
            this.sPnl_Func.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sPnl_Func.BackRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.sPnl_Func.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sPnl_Func.DownBack = null;
            this.sPnl_Func.Location = new System.Drawing.Point(1786, 45);
            this.sPnl_Func.Margin = new System.Windows.Forms.Padding(0);
            this.sPnl_Func.MouseBack = null;
            this.sPnl_Func.Name = "sPnl_Func";
            this.sPnl_Func.NormlBack = null;
            this.sPnl_Func.Palace = true;
            this.sPnl_Func.Radius = 59;
            this.sPnl_Func.Size = new System.Drawing.Size(105, 104);
            this.sPnl_Func.TabIndex = 17;
            this.sPnl_Func.Paint += new System.Windows.Forms.PaintEventHandler(this.sPnl_Func_Paint);
            // 
            // sPnl_Compass
            // 
            this.sPnl_Compass.BackColor = System.Drawing.Color.Transparent;
            this.sPnl_Compass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sPnl_Compass.BackgroundImage")));
            this.sPnl_Compass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sPnl_Compass.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sPnl_Compass.DownBack = null;
            this.sPnl_Compass.Location = new System.Drawing.Point(590, 206);
            this.sPnl_Compass.Margin = new System.Windows.Forms.Padding(4);
            this.sPnl_Compass.MouseBack = null;
            this.sPnl_Compass.Name = "sPnl_Compass";
            this.sPnl_Compass.NormlBack = null;
            this.sPnl_Compass.Size = new System.Drawing.Size(741, 741);
            this.sPnl_Compass.TabIndex = 16;
            this.sPnl_Compass.Paint += new System.Windows.Forms.PaintEventHandler(this.sPnl_Compass_Paint);
            // 
            // skinPanel7
            // 
            this.skinPanel7.BackColor = System.Drawing.Color.White;
            this.skinPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinPanel7.BackRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.skinPanel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.skinPanel7.Controls.Add(this.skinLabel20);
            this.skinPanel7.Controls.Add(this.skinLabel12);
            this.skinPanel7.Controls.Add(this.skinLine7);
            this.skinPanel7.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel7.DownBack = null;
            this.skinPanel7.Location = new System.Drawing.Point(1791, 843);
            this.skinPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanel7.MouseBack = null;
            this.skinPanel7.Name = "skinPanel7";
            this.skinPanel7.NormlBack = null;
            this.skinPanel7.Palace = true;
            this.skinPanel7.Radius = 48;
            this.skinPanel7.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel7.Size = new System.Drawing.Size(78, 141);
            this.skinPanel7.TabIndex = 15;
            // 
            // skinLabel20
            // 
            this.skinLabel20.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel20.AutoSize = true;
            this.skinLabel20.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel20.BorderColor = System.Drawing.Color.White;
            this.skinLabel20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel20.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel20.ForeColor = System.Drawing.Color.Black;
            this.skinLabel20.Location = new System.Drawing.Point(27, 92);
            this.skinLabel20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel20.Name = "skinLabel20";
            this.skinLabel20.Size = new System.Drawing.Size(30, 25);
            this.skinLabel20.TabIndex = 17;
            this.skinLabel20.Text = "夜";
            // 
            // skinLabel12
            // 
            this.skinLabel12.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel12.AutoSize = true;
            this.skinLabel12.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel12.BorderColor = System.Drawing.Color.White;
            this.skinLabel12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel12.ForeColor = System.Drawing.Color.Black;
            this.skinLabel12.Location = new System.Drawing.Point(27, 28);
            this.skinLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel12.Name = "skinLabel12";
            this.skinLabel12.Size = new System.Drawing.Size(30, 25);
            this.skinLabel12.TabIndex = 16;
            this.skinLabel12.Text = "日";
            // 
            // skinLine7
            // 
            this.skinLine7.BackColor = System.Drawing.Color.Transparent;
            this.skinLine7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine7.LineHeight = 1;
            this.skinLine7.Location = new System.Drawing.Point(15, 70);
            this.skinLine7.Margin = new System.Windows.Forms.Padding(4);
            this.skinLine7.Name = "skinLine7";
            this.skinLine7.Size = new System.Drawing.Size(52, 3);
            this.skinLine7.TabIndex = 0;
            this.skinLine7.Text = "skinLine7";
            // 
            // skinPanel6
            // 
            this.skinPanel6.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel6.BackgroundImage")));
            this.skinPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel6.DownBack = null;
            this.skinPanel6.Location = new System.Drawing.Point(1791, 1014);
            this.skinPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel6.MouseBack = null;
            this.skinPanel6.Name = "skinPanel6";
            this.skinPanel6.NormlBack = null;
            this.skinPanel6.Size = new System.Drawing.Size(78, 78);
            this.skinPanel6.TabIndex = 15;
            // 
            // skinPanel5
            // 
            this.skinPanel5.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel5.BackgroundImage")));
            this.skinPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel5.DownBack = null;
            this.skinPanel5.Location = new System.Drawing.Point(1676, 1014);
            this.skinPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel5.MouseBack = null;
            this.skinPanel5.Name = "skinPanel5";
            this.skinPanel5.NormlBack = null;
            this.skinPanel5.Size = new System.Drawing.Size(78, 78);
            this.skinPanel5.TabIndex = 15;
            // 
            // sPnl_liangcheng
            // 
            this.sPnl_liangcheng.BackColor = System.Drawing.Color.Transparent;
            this.sPnl_liangcheng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sPnl_liangcheng.BackgroundImage")));
            this.sPnl_liangcheng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sPnl_liangcheng.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sPnl_liangcheng.DownBack = null;
            this.sPnl_liangcheng.Location = new System.Drawing.Point(1560, 1014);
            this.sPnl_liangcheng.Margin = new System.Windows.Forms.Padding(0);
            this.sPnl_liangcheng.MouseBack = null;
            this.sPnl_liangcheng.Name = "sPnl_liangcheng";
            this.sPnl_liangcheng.NormlBack = null;
            this.sPnl_liangcheng.Size = new System.Drawing.Size(78, 78);
            this.sPnl_liangcheng.TabIndex = 14;
            this.sPnl_liangcheng.Click += new System.EventHandler(this.sPnl_liangcheng_Click);
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.White;
            this.skinPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.skinPanel2.Controls.Add(this.skinLine6);
            this.skinPanel2.Controls.Add(this.skinLine5);
            this.skinPanel2.Controls.Add(this.skinLine4);
            this.skinPanel2.Controls.Add(this.skinLine3);
            this.skinPanel2.Controls.Add(this.skinLine1);
            this.skinPanel2.Controls.Add(this.skinLine2);
            this.skinPanel2.Controls.Add(this.sLabel_info);
            this.skinPanel2.Controls.Add(this.skinLabel18);
            this.skinPanel2.Controls.Add(this.sLabelAltitude);
            this.skinPanel2.Controls.Add(this.skinLabel16);
            this.skinPanel2.Controls.Add(this.skinLabel15);
            this.skinPanel2.Controls.Add(this.sLabel_expandCompass);
            this.skinPanel2.Controls.Add(this.skinLabel13);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(872, 45);
            this.skinPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Radius = 5;
            this.skinPanel2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel2.Size = new System.Drawing.Size(900, 94);
            this.skinPanel2.TabIndex = 13;
            // 
            // skinLine6
            // 
            this.skinLine6.BackColor = System.Drawing.Color.Transparent;
            this.skinLine6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine6.LineHeight = 100;
            this.skinLine6.Location = new System.Drawing.Point(764, 24);
            this.skinLine6.Margin = new System.Windows.Forms.Padding(0);
            this.skinLine6.Name = "skinLine6";
            this.skinLine6.Size = new System.Drawing.Size(4, 39);
            this.skinLine6.TabIndex = 19;
            this.skinLine6.Text = "skinLine6";
            // 
            // skinLine5
            // 
            this.skinLine5.BackColor = System.Drawing.Color.Transparent;
            this.skinLine5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine5.LineHeight = 100;
            this.skinLine5.Location = new System.Drawing.Point(628, 24);
            this.skinLine5.Margin = new System.Windows.Forms.Padding(0);
            this.skinLine5.Name = "skinLine5";
            this.skinLine5.Size = new System.Drawing.Size(4, 39);
            this.skinLine5.TabIndex = 18;
            this.skinLine5.Text = "skinLine5";
            // 
            // skinLine4
            // 
            this.skinLine4.BackColor = System.Drawing.Color.Transparent;
            this.skinLine4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine4.LineHeight = 100;
            this.skinLine4.Location = new System.Drawing.Point(508, 24);
            this.skinLine4.Margin = new System.Windows.Forms.Padding(0);
            this.skinLine4.Name = "skinLine4";
            this.skinLine4.Size = new System.Drawing.Size(4, 39);
            this.skinLine4.TabIndex = 17;
            this.skinLine4.Text = "skinLine4";
            // 
            // skinLine3
            // 
            this.skinLine3.BackColor = System.Drawing.Color.Transparent;
            this.skinLine3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine3.LineHeight = 100;
            this.skinLine3.Location = new System.Drawing.Point(388, 24);
            this.skinLine3.Margin = new System.Windows.Forms.Padding(0);
            this.skinLine3.Name = "skinLine3";
            this.skinLine3.Size = new System.Drawing.Size(4, 39);
            this.skinLine3.TabIndex = 16;
            this.skinLine3.Text = "skinLine3";
            // 
            // skinLine1
            // 
            this.skinLine1.BackColor = System.Drawing.Color.Transparent;
            this.skinLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine1.LineHeight = 100;
            this.skinLine1.Location = new System.Drawing.Point(268, 24);
            this.skinLine1.Margin = new System.Windows.Forms.Padding(0);
            this.skinLine1.Name = "skinLine1";
            this.skinLine1.Size = new System.Drawing.Size(4, 39);
            this.skinLine1.TabIndex = 15;
            this.skinLine1.Text = "skinLine1";
            // 
            // skinLine2
            // 
            this.skinLine2.BackColor = System.Drawing.Color.Transparent;
            this.skinLine2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine2.LineHeight = 100;
            this.skinLine2.Location = new System.Drawing.Point(148, 24);
            this.skinLine2.Margin = new System.Windows.Forms.Padding(0);
            this.skinLine2.Name = "skinLine2";
            this.skinLine2.Size = new System.Drawing.Size(4, 39);
            this.skinLine2.TabIndex = 14;
            this.skinLine2.Text = "skinLine2";
            // 
            // sLabel_info
            // 
            this.sLabel_info.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.sLabel_info.AutoSize = true;
            this.sLabel_info.BackColor = System.Drawing.Color.Transparent;
            this.sLabel_info.BorderColor = System.Drawing.Color.White;
            this.sLabel_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sLabel_info.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sLabel_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sLabel_info.Location = new System.Drawing.Point(812, 20);
            this.sLabel_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sLabel_info.Name = "sLabel_info";
            this.sLabel_info.Size = new System.Drawing.Size(48, 50);
            this.sLabel_info.TabIndex = 7;
            this.sLabel_info.Text = "本机\r\n信息";
            this.sLabel_info.Click += new System.EventHandler(this.sLabel_info_Click);
            // 
            // skinLabel18
            // 
            this.skinLabel18.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel18.AutoSize = true;
            this.skinLabel18.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel18.BorderColor = System.Drawing.Color.White;
            this.skinLabel18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel18.Location = new System.Drawing.Point(676, 20);
            this.skinLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel18.Name = "skinLabel18";
            this.skinLabel18.Size = new System.Drawing.Size(48, 50);
            this.skinLabel18.TabIndex = 6;
            this.skinLabel18.Text = "距离\r\n过滤";
            this.skinLabel18.Click += new System.EventHandler(this.sLabel_distanceFilter_Click);
            // 
            // sLabelAltitude
            // 
            this.sLabelAltitude.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.sLabelAltitude.AutoSize = true;
            this.sLabelAltitude.BackColor = System.Drawing.Color.Transparent;
            this.sLabelAltitude.BorderColor = System.Drawing.Color.White;
            this.sLabelAltitude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sLabelAltitude.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sLabelAltitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sLabelAltitude.Location = new System.Drawing.Point(550, 20);
            this.sLabelAltitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sLabelAltitude.Name = "sLabelAltitude";
            this.sLabelAltitude.Size = new System.Drawing.Size(48, 50);
            this.sLabelAltitude.TabIndex = 5;
            this.sLabelAltitude.Text = "高度\r\n过滤";
            this.sLabelAltitude.Click += new System.EventHandler(this.sLabelAltitude_Click);
            // 
            // skinLabel16
            // 
            this.skinLabel16.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel16.AutoSize = true;
            this.skinLabel16.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel16.BorderColor = System.Drawing.Color.White;
            this.skinLabel16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.skinLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel16.Location = new System.Drawing.Point(429, 32);
            this.skinLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel16.Name = "skinLabel16";
            this.skinLabel16.Size = new System.Drawing.Size(48, 25);
            this.skinLabel16.TabIndex = 4;
            this.skinLabel16.Text = "防拥";
            // 
            // skinLabel15
            // 
            this.skinLabel15.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel15.AutoSize = true;
            this.skinLabel15.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel15.BorderColor = System.Drawing.Color.White;
            this.skinLabel15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel15.Location = new System.Drawing.Point(308, 32);
            this.skinLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel15.Name = "skinLabel15";
            this.skinLabel15.Size = new System.Drawing.Size(48, 25);
            this.skinLabel15.TabIndex = 3;
            this.skinLabel15.Text = "航迹";
            // 
            // sLabel_expandCompass
            // 
            this.sLabel_expandCompass.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.sLabel_expandCompass.AutoSize = true;
            this.sLabel_expandCompass.BackColor = System.Drawing.Color.Transparent;
            this.sLabel_expandCompass.BorderColor = System.Drawing.Color.White;
            this.sLabel_expandCompass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sLabel_expandCompass.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sLabel_expandCompass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sLabel_expandCompass.Location = new System.Drawing.Point(190, 20);
            this.sLabel_expandCompass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sLabel_expandCompass.Name = "sLabel_expandCompass";
            this.sLabel_expandCompass.Size = new System.Drawing.Size(48, 50);
            this.sLabel_expandCompass.TabIndex = 2;
            this.sLabel_expandCompass.Text = "扩展\r\n罗盘";
            this.sLabel_expandCompass.Click += new System.EventHandler(this.sLabel_expandCompass_Click);
            // 
            // skinLabel13
            // 
            this.skinLabel13.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel13.AutoSize = true;
            this.skinLabel13.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel13.BorderColor = System.Drawing.Color.White;
            this.skinLabel13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel13.Location = new System.Drawing.Point(58, 32);
            this.skinLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel13.Name = "skinLabel13";
            this.skinLabel13.Size = new System.Drawing.Size(48, 25);
            this.skinLabel13.TabIndex = 1;
            this.skinLabel13.Text = "模式";
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.White;
            this.skinPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.skinPanel1.Controls.Add(this.skinPanel4);
            this.skinPanel1.Controls.Add(this.sPanelMonitor);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(584, 45);
            this.skinPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Radius = 5;
            this.skinPanel1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel1.Size = new System.Drawing.Size(273, 94);
            this.skinPanel1.TabIndex = 12;
            // 
            // skinPanel4
            // 
            this.skinPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.skinPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.skinPanel4.Controls.Add(this.skinLabel11);
            this.skinPanel4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel4.DownBack = null;
            this.skinPanel4.Location = new System.Drawing.Point(26, 12);
            this.skinPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel4.MouseBack = null;
            this.skinPanel4.Name = "skinPanel4";
            this.skinPanel4.NormlBack = null;
            this.skinPanel4.Radius = 5;
            this.skinPanel4.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel4.Size = new System.Drawing.Size(120, 68);
            this.skinPanel4.TabIndex = 14;
            // 
            // skinLabel11
            // 
            this.skinLabel11.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.ForeColor = System.Drawing.Color.White;
            this.skinLabel11.Location = new System.Drawing.Point(18, 20);
            this.skinLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(84, 25);
            this.skinLabel11.TabIndex = 0;
            this.skinLabel11.Text = "飞行模式";
            // 
            // sPanelMonitor
            // 
            this.sPanelMonitor.BackColor = System.Drawing.Color.White;
            this.sPanelMonitor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.sPanelMonitor.Controls.Add(this.sLabelMonitor);
            this.sPanelMonitor.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sPanelMonitor.DownBack = null;
            this.sPanelMonitor.Location = new System.Drawing.Point(26, 12);
            this.sPanelMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.sPanelMonitor.MouseBack = null;
            this.sPanelMonitor.Name = "sPanelMonitor";
            this.sPanelMonitor.NormlBack = null;
            this.sPanelMonitor.Radius = 5;
            this.sPanelMonitor.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.sPanelMonitor.Size = new System.Drawing.Size(222, 68);
            this.sPanelMonitor.TabIndex = 13;
            this.sPanelMonitor.Click += new System.EventHandler(this.sPanelMonitor_Click);
            // 
            // sLabelMonitor
            // 
            this.sLabelMonitor.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.sLabelMonitor.AutoSize = true;
            this.sLabelMonitor.BackColor = System.Drawing.Color.Transparent;
            this.sLabelMonitor.BorderColor = System.Drawing.Color.White;
            this.sLabelMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sLabelMonitor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sLabelMonitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.sLabelMonitor.Location = new System.Drawing.Point(129, 20);
            this.sLabelMonitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sLabelMonitor.Name = "sLabelMonitor";
            this.sLabelMonitor.Size = new System.Drawing.Size(84, 25);
            this.sLabelMonitor.TabIndex = 1;
            this.sLabelMonitor.Text = "监控模式";
            this.sLabelMonitor.Click += new System.EventHandler(this.sPanelMonitor_Click);
            // 
            // skinLabel10
            // 
            this.skinLabel10.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.ForeColor = System.Drawing.Color.White;
            this.skinLabel10.Location = new System.Drawing.Point(441, 108);
            this.skinLabel10.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(49, 31);
            this.skinLabel10.TabIndex = 11;
            this.skinLabel10.Text = "OK";
            // 
            // skinLabel9
            // 
            this.skinLabel9.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.ForeColor = System.Drawing.Color.White;
            this.skinLabel9.Location = new System.Drawing.Point(441, 76);
            this.skinLabel9.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(49, 31);
            this.skinLabel9.TabIndex = 10;
            this.skinLabel9.Text = "OK";
            // 
            // skinLabel8
            // 
            this.skinLabel8.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.ForeColor = System.Drawing.Color.White;
            this.skinLabel8.Location = new System.Drawing.Point(441, 45);
            this.skinLabel8.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(49, 31);
            this.skinLabel8.TabIndex = 9;
            this.skinLabel8.Text = "OK";
            // 
            // skinLabel5
            // 
            this.skinLabel5.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.skinLabel5.Location = new System.Drawing.Point(358, 108);
            this.skinLabel5.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(77, 31);
            this.skinLabel5.TabIndex = 8;
            this.skinLabel5.Text = "TIME:";
            // 
            // skinLabel6
            // 
            this.skinLabel6.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.skinLabel6.Location = new System.Drawing.Point(358, 76);
            this.skinLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(80, 31);
            this.skinLabel6.TabIndex = 7;
            this.skinLabel6.Text = "ESAR:";
            // 
            // skinLabel7
            // 
            this.skinLabel7.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.skinLabel7.Location = new System.Drawing.Point(358, 45);
            this.skinLabel7.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(82, 31);
            this.skinLabel7.TabIndex = 6;
            this.skinLabel7.Text = "CDTT:";
            // 
            // skinLabel4
            // 
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.White;
            this.skinLabel4.Location = new System.Drawing.Point(171, 108);
            this.skinLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(131, 31);
            this.skinLabel4.TabIndex = 5;
            this.skinLabel4.Text = "ALT+1000";
            // 
            // skinLabel3
            // 
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.White;
            this.skinLabel3.Location = new System.Drawing.Point(171, 76);
            this.skinLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(102, 31);
            this.skinLabel3.TabIndex = 4;
            this.skinLabel3.Text = "GS1000";
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.White;
            this.skinLabel1.Location = new System.Drawing.Point(170, 45);
            this.skinLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(121, 31);
            this.skinLabel1.TabIndex = 3;
            this.skinLabel1.Text = "CUA4032";
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.skinLabel2.Location = new System.Drawing.Point(39, 108);
            this.skinLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(128, 31);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "高      度：";
            // 
            // sLabel2
            // 
            this.sLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.sLabel2.AutoSize = true;
            this.sLabel2.BackColor = System.Drawing.Color.Transparent;
            this.sLabel2.BorderColor = System.Drawing.Color.White;
            this.sLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.sLabel2.Location = new System.Drawing.Point(39, 76);
            this.sLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.sLabel2.Name = "sLabel2";
            this.sLabel2.Size = new System.Drawing.Size(116, 31);
            this.sLabel2.TabIndex = 1;
            this.sLabel2.Text = "地速指示:";
            // 
            // slabel1
            // 
            this.slabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.slabel1.AutoSize = true;
            this.slabel1.BackColor = System.Drawing.Color.Transparent;
            this.slabel1.BorderColor = System.Drawing.Color.White;
            this.slabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.slabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.slabel1.Location = new System.Drawing.Point(39, 45);
            this.slabel1.Margin = new System.Windows.Forms.Padding(0);
            this.slabel1.Name = "slabel1";
            this.slabel1.Size = new System.Drawing.Size(116, 31);
            this.slabel1.TabIndex = 0;
            this.slabel1.Text = "本机标识:";
            // 
            // sTpMonitor
            // 
            this.sTpMonitor.BackColor = System.Drawing.Color.Transparent;
            this.sTpMonitor.Controls.Add(this.dataGridView1);
            this.sTpMonitor.Controls.Add(this.skinProgressBar1);
            this.sTpMonitor.Controls.Add(this.maskPlaybackRun);
            this.sTpMonitor.Controls.Add(this.maskPlaybackSetup);
            this.sTpMonitor.Controls.Add(this.panelEx1);
            this.sTpMonitor.Controls.Add(this.mapmask);
            this.sTpMonitor.Controls.Add(this.skinPanel15);
            this.sTpMonitor.Controls.Add(this.skinPanel3);
            this.sTpMonitor.Controls.Add(this.skinPanel8);
            this.sTpMonitor.Controls.Add(this.gMapControl1);
            this.sTpMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTpMonitor.Location = new System.Drawing.Point(0, 36);
            this.sTpMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.sTpMonitor.Name = "sTpMonitor";
            this.sTpMonitor.Size = new System.Drawing.Size(1920, 1064);
            this.sTpMonitor.TabIndex = 1;
            this.sTpMonitor.TabItemImage = null;
            this.sTpMonitor.Text = "skinTabPage2";
            // 
            // skinProgressBar1
            // 
            this.skinProgressBar1.Back = null;
            this.skinProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.skinProgressBar1.BarBack = null;
            this.skinProgressBar1.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.skinProgressBar1.Location = new System.Drawing.Point(0, 930);
            this.skinProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.skinProgressBar1.Name = "skinProgressBar1";
            this.skinProgressBar1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar1.Size = new System.Drawing.Size(1920, 3);
            this.skinProgressBar1.TabIndex = 27;
            this.skinProgressBar1.TrackFore = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.skinProgressBar1.Value = 2;
            this.skinProgressBar1.Visible = false;
            // 
            // maskPlaybackRun
            // 
            this.maskPlaybackRun.BackColor = System.Drawing.Color.Transparent;
            this.maskPlaybackRun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maskPlaybackRun.BackgroundImage")));
            this.maskPlaybackRun.Location = new System.Drawing.Point(920, 960);
            this.maskPlaybackRun.Margin = new System.Windows.Forms.Padding(4);
            this.maskPlaybackRun.Name = "maskPlaybackRun";
            this.maskPlaybackRun.Size = new System.Drawing.Size(78, 78);
            this.maskPlaybackRun.TabIndex = 26;
            this.maskPlaybackRun.Transparency = 100;
            this.maskPlaybackRun.Visible = false;
            this.maskPlaybackRun.Click += new System.EventHandler(this.maskPlaybackRun_Click);
            // 
            // maskPlaybackSetup
            // 
            this.maskPlaybackSetup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.maskPlaybackSetup.Location = new System.Drawing.Point(46, 980);
            this.maskPlaybackSetup.Margin = new System.Windows.Forms.Padding(4);
            this.maskPlaybackSetup.Name = "maskPlaybackSetup";
            this.maskPlaybackSetup.Size = new System.Drawing.Size(84, 28);
            this.maskPlaybackSetup.TabIndex = 25;
            this.maskPlaybackSetup.Transparency = 100;
            this.maskPlaybackSetup.Click += new System.EventHandler(this.maskPlaybackSetup_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 899);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1920, 165);
            this.panelEx1.TabIndex = 21;
            this.panelEx1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEx1_Paint);
            // 
            // mapmask
            // 
            this.mapmask.BackColor = System.Drawing.Color.Black;
            this.mapmask.Location = new System.Drawing.Point(52, 116);
            this.mapmask.Margin = new System.Windows.Forms.Padding(4);
            this.mapmask.Name = "mapmask";
            this.mapmask.Size = new System.Drawing.Size(225, 225);
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
            this.skinPanel15.Controls.Add(this.button2);
            this.skinPanel15.Controls.Add(this.skinLabel32);
            this.skinPanel15.Controls.Add(this.button1);
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
            this.skinPanel15.Location = new System.Drawing.Point(1786, 45);
            this.skinPanel15.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanel15.MouseBack = null;
            this.skinPanel15.Name = "skinPanel15";
            this.skinPanel15.NormlBack = null;
            this.skinPanel15.Palace = true;
            this.skinPanel15.Radius = 48;
            this.skinPanel15.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel15.Size = new System.Drawing.Size(88, 811);
            this.skinPanel15.TabIndex = 19;
            // 
            // skinLabel34
            // 
            this.skinLabel34.AutoSize = true;
            this.skinLabel34.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel34.BorderColor = System.Drawing.Color.White;
            this.skinLabel34.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel34.Location = new System.Drawing.Point(16, 776);
            this.skinLabel34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel34.Name = "skinLabel34";
            this.skinLabel34.Size = new System.Drawing.Size(58, 21);
            this.skinLabel34.TabIndex = 38;
            this.skinLabel34.Text = "中心机";
            this.skinLabel34.Click += new System.EventHandler(this.skinLabel34_Click);
            // 
            // skinLabel33
            // 
            this.skinLabel33.AutoSize = true;
            this.skinLabel33.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel33.BorderColor = System.Drawing.Color.White;
            this.skinLabel33.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel33.Location = new System.Drawing.Point(9, 506);
            this.skinLabel33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel33.Name = "skinLabel33";
            this.skinLabel33.Size = new System.Drawing.Size(74, 21);
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
            this.skinPanel24.Location = new System.Drawing.Point(28, 742);
            this.skinPanel24.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel24.MouseBack = null;
            this.skinPanel24.Name = "skinPanel24";
            this.skinPanel24.NormlBack = null;
            this.skinPanel24.Size = new System.Drawing.Size(30, 30);
            this.skinPanel24.TabIndex = 37;
            // 
            // skinLine19
            // 
            this.skinLine19.BackColor = System.Drawing.Color.Transparent;
            this.skinLine19.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine19.LineHeight = 1;
            this.skinLine19.Location = new System.Drawing.Point(14, 461);
            this.skinLine19.Margin = new System.Windows.Forms.Padding(4);
            this.skinLine19.Name = "skinLine19";
            this.skinLine19.Size = new System.Drawing.Size(69, 3);
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
            this.skinPanel11.Location = new System.Drawing.Point(28, 472);
            this.skinPanel11.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel11.MouseBack = null;
            this.skinPanel11.Name = "skinPanel11";
            this.skinPanel11.NormlBack = null;
            this.skinPanel11.Size = new System.Drawing.Size(30, 30);
            this.skinPanel11.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-1, 609);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 40);
            this.button2.TabIndex = 29;
            this.button2.Text = "取消测距";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // skinLabel32
            // 
            this.skinLabel32.AutoSize = true;
            this.skinLabel32.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel32.BorderColor = System.Drawing.Color.White;
            this.skinLabel32.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel32.Location = new System.Drawing.Point(24, 295);
            this.skinLabel32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel32.Name = "skinLabel32";
            this.skinLabel32.Size = new System.Drawing.Size(42, 21);
            this.skinLabel32.TabIndex = 33;
            this.skinLabel32.Text = "航段";
            this.skinLabel32.Click += new System.EventHandler(this.skinLabel32_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 41);
            this.button1.TabIndex = 28;
            this.button1.Text = "测距";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // skinLabel31
            // 
            this.skinLabel31.AutoSize = true;
            this.skinLabel31.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel31.BorderColor = System.Drawing.Color.White;
            this.skinLabel31.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel31.Location = new System.Drawing.Point(24, 436);
            this.skinLabel31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel31.Name = "skinLabel31";
            this.skinLabel31.Size = new System.Drawing.Size(42, 21);
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
            this.skinPanel23.Location = new System.Drawing.Point(28, 260);
            this.skinPanel23.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel23.MouseBack = null;
            this.skinPanel23.Name = "skinPanel23";
            this.skinPanel23.NormlBack = null;
            this.skinPanel23.Size = new System.Drawing.Size(30, 30);
            this.skinPanel23.TabIndex = 32;
            // 
            // skinLabel30
            // 
            this.skinLabel30.AutoSize = true;
            this.skinLabel30.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel30.BorderColor = System.Drawing.Color.White;
            this.skinLabel30.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel30.Location = new System.Drawing.Point(24, 365);
            this.skinLabel30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel30.Name = "skinLabel30";
            this.skinLabel30.Size = new System.Drawing.Size(42, 21);
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
            this.skinPanel22.Location = new System.Drawing.Point(28, 401);
            this.skinPanel22.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel22.MouseBack = null;
            this.skinPanel22.Name = "skinPanel22";
            this.skinPanel22.NormlBack = null;
            this.skinPanel22.Size = new System.Drawing.Size(30, 30);
            this.skinPanel22.TabIndex = 33;
            // 
            // skinLine18
            // 
            this.skinLine18.BackColor = System.Drawing.Color.Transparent;
            this.skinLine18.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine18.LineHeight = 1;
            this.skinLine18.Location = new System.Drawing.Point(10, 390);
            this.skinLine18.Margin = new System.Windows.Forms.Padding(4);
            this.skinLine18.Name = "skinLine18";
            this.skinLine18.Size = new System.Drawing.Size(69, 3);
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
            this.skinLabel29.Location = new System.Drawing.Point(16, 224);
            this.skinLabel29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel29.Name = "skinLabel29";
            this.skinLabel29.Size = new System.Drawing.Size(58, 21);
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
            this.skinPanel21.Location = new System.Drawing.Point(28, 331);
            this.skinPanel21.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel21.MouseBack = null;
            this.skinPanel21.Name = "skinPanel21";
            this.skinPanel21.NormlBack = null;
            this.skinPanel21.Size = new System.Drawing.Size(30, 30);
            this.skinPanel21.TabIndex = 30;
            // 
            // skinLine17
            // 
            this.skinLine17.BackColor = System.Drawing.Color.Transparent;
            this.skinLine17.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine17.LineHeight = 1;
            this.skinLine17.Location = new System.Drawing.Point(5, 320);
            this.skinLine17.Margin = new System.Windows.Forms.Padding(4);
            this.skinLine17.Name = "skinLine17";
            this.skinLine17.Size = new System.Drawing.Size(69, 3);
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
            this.skinPanel20.Location = new System.Drawing.Point(28, 190);
            this.skinPanel20.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel20.MouseBack = null;
            this.skinPanel20.Name = "skinPanel20";
            this.skinPanel20.NormlBack = null;
            this.skinPanel20.Size = new System.Drawing.Size(30, 30);
            this.skinPanel20.TabIndex = 30;
            // 
            // skinLine16
            // 
            this.skinLine16.BackColor = System.Drawing.Color.Transparent;
            this.skinLine16.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine16.LineHeight = 1;
            this.skinLine16.Location = new System.Drawing.Point(10, 249);
            this.skinLine16.Margin = new System.Windows.Forms.Padding(4);
            this.skinLine16.Name = "skinLine16";
            this.skinLine16.Size = new System.Drawing.Size(69, 3);
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
            this.skinLabel28.Location = new System.Drawing.Point(24, 152);
            this.skinLabel28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel28.Name = "skinLabel28";
            this.skinLabel28.Size = new System.Drawing.Size(42, 21);
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
            this.skinPanel19.Location = new System.Drawing.Point(28, 117);
            this.skinPanel19.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel19.MouseBack = null;
            this.skinPanel19.Name = "skinPanel19";
            this.skinPanel19.NormlBack = null;
            this.skinPanel19.Size = new System.Drawing.Size(30, 30);
            this.skinPanel19.TabIndex = 26;
            // 
            // skinLine15
            // 
            this.skinLine15.BackColor = System.Drawing.Color.Transparent;
            this.skinLine15.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine15.LineHeight = 1;
            this.skinLine15.Location = new System.Drawing.Point(10, 646);
            this.skinLine15.Margin = new System.Windows.Forms.Padding(4);
            this.skinLine15.Name = "skinLine15";
            this.skinLine15.Size = new System.Drawing.Size(69, 3);
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
            this.skinLabel27.Location = new System.Drawing.Point(16, 81);
            this.skinLabel27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel27.Name = "skinLabel27";
            this.skinLabel27.Size = new System.Drawing.Size(58, 21);
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
            this.sPnl_dimianzhan.Location = new System.Drawing.Point(28, 36);
            this.sPnl_dimianzhan.Margin = new System.Windows.Forms.Padding(4);
            this.sPnl_dimianzhan.MouseBack = null;
            this.sPnl_dimianzhan.Name = "sPnl_dimianzhan";
            this.sPnl_dimianzhan.NormlBack = null;
            this.sPnl_dimianzhan.Size = new System.Drawing.Size(30, 30);
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
            this.skinLabel26.Location = new System.Drawing.Point(22, 699);
            this.skinLabel26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel26.Name = "skinLabel26";
            this.skinLabel26.Size = new System.Drawing.Size(42, 21);
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
            this.skinPanel18.Location = new System.Drawing.Point(28, 670);
            this.skinPanel18.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel18.MouseBack = null;
            this.skinPanel18.Name = "skinPanel18";
            this.skinPanel18.NormlBack = null;
            this.skinPanel18.Size = new System.Drawing.Size(21, 24);
            this.skinPanel18.TabIndex = 23;
            // 
            // skinLine14
            // 
            this.skinLine14.BackColor = System.Drawing.Color.Transparent;
            this.skinLine14.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine14.LineHeight = 1;
            this.skinLine14.Location = new System.Drawing.Point(14, 550);
            this.skinLine14.Margin = new System.Windows.Forms.Padding(4);
            this.skinLine14.Name = "skinLine14";
            this.skinLine14.Size = new System.Drawing.Size(69, 3);
            this.skinLine14.TabIndex = 18;
            this.skinLine14.Text = "skinLine14";
            // 
            // skinLine9
            // 
            this.skinLine9.BackColor = System.Drawing.Color.Transparent;
            this.skinLine9.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine9.LineHeight = 1;
            this.skinLine9.Location = new System.Drawing.Point(10, 179);
            this.skinLine9.Margin = new System.Windows.Forms.Padding(4);
            this.skinLine9.Name = "skinLine9";
            this.skinLine9.Size = new System.Drawing.Size(69, 3);
            this.skinLine9.TabIndex = 17;
            this.skinLine9.Text = "skinLine9";
            // 
            // skinLine8
            // 
            this.skinLine8.BackColor = System.Drawing.Color.Transparent;
            this.skinLine8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine8.LineHeight = 1;
            this.skinLine8.Location = new System.Drawing.Point(10, 106);
            this.skinLine8.Margin = new System.Windows.Forms.Padding(4);
            this.skinLine8.Name = "skinLine8";
            this.skinLine8.Size = new System.Drawing.Size(69, 3);
            this.skinLine8.TabIndex = 0;
            this.skinLine8.Text = "skinLine8";
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.White;
            this.skinPanel3.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.skinPanel3.Controls.Add(this.skinPanel14);
            this.skinPanel3.Controls.Add(this.skinPanel13);
            this.skinPanel3.Controls.Add(this.skinPanel12);
            this.skinPanel3.Controls.Add(this.skinLine10);
            this.skinPanel3.Controls.Add(this.skinLine11);
            this.skinPanel3.Controls.Add(this.skinLine12);
            this.skinPanel3.Controls.Add(this.skinLine13);
            this.skinPanel3.Controls.Add(this.skinLabel19);
            this.skinPanel3.Controls.Add(this.skinLabel21);
            this.skinPanel3.Controls.Add(this.skinLabel22);
            this.skinPanel3.Controls.Add(this.skinLabel23);
            this.skinPanel3.Controls.Add(this.skinLabel24);
            this.skinPanel3.Controls.Add(this.skinPanel10);
            this.skinPanel3.Controls.Add(this.skinPanel17);
            this.skinPanel3.Controls.Add(this.skinLabel17);
            this.skinPanel3.Controls.Add(this.skinPanel16);
            this.skinPanel3.Controls.Add(this.skinLabel14);
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Location = new System.Drawing.Point(885, 45);
            this.skinPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.Radius = 5;
            this.skinPanel3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel3.Size = new System.Drawing.Size(885, 94);
            this.skinPanel3.TabIndex = 14;
            // 
            // skinPanel14
            // 
            this.skinPanel14.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel14.BackgroundImage")));
            this.skinPanel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel14.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel14.DownBack = null;
            this.skinPanel14.Location = new System.Drawing.Point(568, 28);
            this.skinPanel14.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel14.MouseBack = null;
            this.skinPanel14.Name = "skinPanel14";
            this.skinPanel14.NormlBack = null;
            this.skinPanel14.Size = new System.Drawing.Size(32, 32);
            this.skinPanel14.TabIndex = 21;
            // 
            // skinPanel13
            // 
            this.skinPanel13.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel13.BackgroundImage")));
            this.skinPanel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel13.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel13.DownBack = null;
            this.skinPanel13.Location = new System.Drawing.Point(429, 32);
            this.skinPanel13.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel13.MouseBack = null;
            this.skinPanel13.Name = "skinPanel13";
            this.skinPanel13.NormlBack = null;
            this.skinPanel13.Size = new System.Drawing.Size(32, 28);
            this.skinPanel13.TabIndex = 20;
            // 
            // skinPanel12
            // 
            this.skinPanel12.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel12.BackgroundImage")));
            this.skinPanel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel12.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel12.DownBack = null;
            this.skinPanel12.Location = new System.Drawing.Point(288, 30);
            this.skinPanel12.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel12.MouseBack = null;
            this.skinPanel12.Name = "skinPanel12";
            this.skinPanel12.NormlBack = null;
            this.skinPanel12.Size = new System.Drawing.Size(33, 33);
            this.skinPanel12.TabIndex = 19;
            // 
            // skinLine10
            // 
            this.skinLine10.BackColor = System.Drawing.Color.Transparent;
            this.skinLine10.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine10.LineHeight = 100;
            this.skinLine10.Location = new System.Drawing.Point(538, 24);
            this.skinLine10.Margin = new System.Windows.Forms.Padding(0);
            this.skinLine10.Name = "skinLine10";
            this.skinLine10.Size = new System.Drawing.Size(4, 39);
            this.skinLine10.TabIndex = 17;
            this.skinLine10.Text = "skinLine10";
            // 
            // skinLine11
            // 
            this.skinLine11.BackColor = System.Drawing.Color.Transparent;
            this.skinLine11.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine11.LineHeight = 100;
            this.skinLine11.Location = new System.Drawing.Point(404, 24);
            this.skinLine11.Margin = new System.Windows.Forms.Padding(0);
            this.skinLine11.Name = "skinLine11";
            this.skinLine11.Size = new System.Drawing.Size(4, 39);
            this.skinLine11.TabIndex = 16;
            this.skinLine11.Text = "skinLine11";
            // 
            // skinLine12
            // 
            this.skinLine12.BackColor = System.Drawing.Color.Transparent;
            this.skinLine12.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine12.LineHeight = 100;
            this.skinLine12.Location = new System.Drawing.Point(268, 24);
            this.skinLine12.Margin = new System.Windows.Forms.Padding(0);
            this.skinLine12.Name = "skinLine12";
            this.skinLine12.Size = new System.Drawing.Size(4, 39);
            this.skinLine12.TabIndex = 15;
            this.skinLine12.Text = "skinLine12";
            // 
            // skinLine13
            // 
            this.skinLine13.BackColor = System.Drawing.Color.Transparent;
            this.skinLine13.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(226)))));
            this.skinLine13.LineHeight = 100;
            this.skinLine13.Location = new System.Drawing.Point(134, 24);
            this.skinLine13.Margin = new System.Windows.Forms.Padding(0);
            this.skinLine13.Name = "skinLine13";
            this.skinLine13.Size = new System.Drawing.Size(4, 39);
            this.skinLine13.TabIndex = 14;
            this.skinLine13.Text = "skinLine13";
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
            this.skinLabel19.Location = new System.Drawing.Point(608, 32);
            this.skinLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel19.Name = "skinLabel19";
            this.skinLabel19.Size = new System.Drawing.Size(48, 25);
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
            this.skinLabel21.Location = new System.Drawing.Point(470, 32);
            this.skinLabel21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel21.Name = "skinLabel21";
            this.skinLabel21.Size = new System.Drawing.Size(48, 25);
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
            this.skinLabel22.Location = new System.Drawing.Point(326, 32);
            this.skinLabel22.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel22.Name = "skinLabel22";
            this.skinLabel22.Size = new System.Drawing.Size(66, 25);
            this.skinLabel22.TabIndex = 3;
            this.skinLabel22.Text = "飞行器";
            this.skinLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skinLabel22.Click += new System.EventHandler(this.sLabel_flyFilter_Click);
            // 
            // skinLabel23
            // 
            this.skinLabel23.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel23.AutoSize = true;
            this.skinLabel23.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel23.BorderColor = System.Drawing.Color.White;
            this.skinLabel23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel23.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel23.Location = new System.Drawing.Point(201, 32);
            this.skinLabel23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel23.Name = "skinLabel23";
            this.skinLabel23.Size = new System.Drawing.Size(48, 25);
            this.skinLabel23.TabIndex = 2;
            this.skinLabel23.Text = "设置";
            this.skinLabel23.Click += new System.EventHandler(this.sLabel_Set1_Click);
            // 
            // skinLabel24
            // 
            this.skinLabel24.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel24.AutoSize = true;
            this.skinLabel24.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel24.BorderColor = System.Drawing.Color.White;
            this.skinLabel24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel24.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel24.Location = new System.Drawing.Point(54, 32);
            this.skinLabel24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel24.Name = "skinLabel24";
            this.skinLabel24.Size = new System.Drawing.Size(48, 25);
            this.skinLabel24.TabIndex = 1;
            this.skinLabel24.Text = "模式";
            this.skinLabel24.Click += new System.EventHandler(this.sLabel_Mode_Click);
            // 
            // skinPanel10
            // 
            this.skinPanel10.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel10.BackgroundImage")));
            this.skinPanel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel10.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel10.DownBack = null;
            this.skinPanel10.Location = new System.Drawing.Point(159, 30);
            this.skinPanel10.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel10.MouseBack = null;
            this.skinPanel10.Name = "skinPanel10";
            this.skinPanel10.NormlBack = null;
            this.skinPanel10.Size = new System.Drawing.Size(33, 33);
            this.skinPanel10.TabIndex = 18;
            // 
            // skinPanel17
            // 
            this.skinPanel17.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel17.BackgroundImage")));
            this.skinPanel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinPanel17.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel17.DownBack = null;
            this.skinPanel17.Location = new System.Drawing.Point(810, 14);
            this.skinPanel17.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel17.MouseBack = null;
            this.skinPanel17.Name = "skinPanel17";
            this.skinPanel17.NormlBack = null;
            this.skinPanel17.Size = new System.Drawing.Size(36, 36);
            this.skinPanel17.TabIndex = 21;
            // 
            // skinLabel17
            // 
            this.skinLabel17.AutoSize = true;
            this.skinLabel17.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel17.BorderColor = System.Drawing.Color.White;
            this.skinLabel17.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel17.Location = new System.Drawing.Point(792, 54);
            this.skinLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel17.Name = "skinLabel17";
            this.skinLabel17.Size = new System.Drawing.Size(74, 21);
            this.skinLabel17.TabIndex = 22;
            this.skinLabel17.Text = "飞行计划";
            this.skinLabel17.Click += new System.EventHandler(this.sPnl_flyPlan_click);
            // 
            // skinPanel16
            // 
            this.skinPanel16.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel16.BackgroundImage")));
            this.skinPanel16.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel16.DownBack = null;
            this.skinPanel16.Location = new System.Drawing.Point(727, 12);
            this.skinPanel16.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel16.MouseBack = null;
            this.skinPanel16.Name = "skinPanel16";
            this.skinPanel16.NormlBack = null;
            this.skinPanel16.Size = new System.Drawing.Size(36, 38);
            this.skinPanel16.TabIndex = 19;
            // 
            // skinLabel14
            // 
            this.skinLabel14.AutoSize = true;
            this.skinLabel14.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel14.BorderColor = System.Drawing.Color.White;
            this.skinLabel14.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.skinLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinLabel14.Location = new System.Drawing.Point(707, 54);
            this.skinLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel14.Name = "skinLabel14";
            this.skinLabel14.Size = new System.Drawing.Size(74, 21);
            this.skinLabel14.TabIndex = 20;
            this.skinLabel14.Text = "导航管理";
            this.skinLabel14.Click += new System.EventHandler(this.sLabel_guideManagement_Click);
            // 
            // skinPanel8
            // 
            this.skinPanel8.BackColor = System.Drawing.Color.White;
            this.skinPanel8.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.skinPanel8.Controls.Add(this.skinPanel9);
            this.skinPanel8.Controls.Add(this.sPnl_Fly);
            this.skinPanel8.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel8.DownBack = null;
            this.skinPanel8.Location = new System.Drawing.Point(564, 45);
            this.skinPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel8.MouseBack = null;
            this.skinPanel8.Name = "skinPanel8";
            this.skinPanel8.NormlBack = null;
            this.skinPanel8.Radius = 5;
            this.skinPanel8.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel8.Size = new System.Drawing.Size(273, 94);
            this.skinPanel8.TabIndex = 14;
            // 
            // skinPanel9
            // 
            this.skinPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.skinPanel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.skinPanel9.Controls.Add(this.skinLabel25);
            this.skinPanel9.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel9.DownBack = null;
            this.skinPanel9.Location = new System.Drawing.Point(128, 12);
            this.skinPanel9.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel9.MouseBack = null;
            this.skinPanel9.Name = "skinPanel9";
            this.skinPanel9.NormlBack = null;
            this.skinPanel9.Radius = 5;
            this.skinPanel9.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel9.Size = new System.Drawing.Size(120, 68);
            this.skinPanel9.TabIndex = 14;
            // 
            // skinLabel25
            // 
            this.skinLabel25.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel25.AutoSize = true;
            this.skinLabel25.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel25.BorderColor = System.Drawing.Color.White;
            this.skinLabel25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel25.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel25.ForeColor = System.Drawing.Color.White;
            this.skinLabel25.Location = new System.Drawing.Point(18, 20);
            this.skinLabel25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel25.Name = "skinLabel25";
            this.skinLabel25.Size = new System.Drawing.Size(84, 25);
            this.skinLabel25.TabIndex = 0;
            this.skinLabel25.Text = "监控模式";
            // 
            // sPnl_Fly
            // 
            this.sPnl_Fly.BackColor = System.Drawing.Color.White;
            this.sPnl_Fly.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.sPnl_Fly.Controls.Add(this.sLabel_fly);
            this.sPnl_Fly.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sPnl_Fly.DownBack = null;
            this.sPnl_Fly.Location = new System.Drawing.Point(26, 12);
            this.sPnl_Fly.Margin = new System.Windows.Forms.Padding(4);
            this.sPnl_Fly.MouseBack = null;
            this.sPnl_Fly.Name = "sPnl_Fly";
            this.sPnl_Fly.NormlBack = null;
            this.sPnl_Fly.Radius = 5;
            this.sPnl_Fly.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.sPnl_Fly.Size = new System.Drawing.Size(222, 68);
            this.sPnl_Fly.TabIndex = 13;
            this.sPnl_Fly.Click += new System.EventHandler(this.sPnl_Fly_Click);
            // 
            // sLabel_fly
            // 
            this.sLabel_fly.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.sLabel_fly.AutoSize = true;
            this.sLabel_fly.BackColor = System.Drawing.Color.Transparent;
            this.sLabel_fly.BorderColor = System.Drawing.Color.White;
            this.sLabel_fly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sLabel_fly.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sLabel_fly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.sLabel_fly.Location = new System.Drawing.Point(9, 20);
            this.sLabel_fly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sLabel_fly.Name = "sLabel_fly";
            this.sLabel_fly.Size = new System.Drawing.Size(84, 25);
            this.sLabel_fly.TabIndex = 1;
            this.sLabel_fly.Text = "飞行模式";
            this.sLabel_fly.Click += new System.EventHandler(this.sPnl_Fly_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(4);
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
            this.gMapControl1.Size = new System.Drawing.Size(1920, 1064);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.mapControl_OnMarkerClick);
            this.gMapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sMonitorDis_MouseDown);
            // 
            // timerSPBarPlayback
            // 
            this.playBackTimer.Interval = 1000;
            this.playBackTimer.Tick += new System.EventHandler(this.playBackTimer_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(52, 410);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S模式地址";
            this.Column1.Name = "Column1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1100);
            this.Controls.Add(this.sTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 飞行监控系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sTabControl.ResumeLayout(false);
            this.sTpFly.ResumeLayout(false);
            this.sTpFly.PerformLayout();
            this.skinPanel7.ResumeLayout(false);
            this.skinPanel7.PerformLayout();
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel4.ResumeLayout(false);
            this.skinPanel4.PerformLayout();
            this.sPanelMonitor.ResumeLayout(false);
            this.sPanelMonitor.PerformLayout();
            this.sTpMonitor.ResumeLayout(false);
            this.skinPanel15.ResumeLayout(false);
            this.skinPanel15.PerformLayout();
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            this.skinPanel8.ResumeLayout(false);
            this.skinPanel9.ResumeLayout(false);
            this.skinPanel9.PerformLayout();
            this.sPnl_Fly.ResumeLayout(false);
            this.sPnl_Fly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl sTabControl;
        private CCWin.SkinControl.SkinTabPage sTpMonitor;
        private CCWin.SkinControl.SkinTabPage sTpFly;
        private CCWin.SkinControl.SkinLabel slabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel sLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinControl.SkinPanel sPanelMonitor;
        private CCWin.SkinControl.SkinPanel skinPanel4;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinLabel sLabelMonitor;
        private CCWin.SkinControl.SkinLine skinLine2;
        private CCWin.SkinControl.SkinLabel skinLabel13;
        private CCWin.SkinControl.SkinLabel skinLabel16;
        private CCWin.SkinControl.SkinLabel skinLabel15;
        private CCWin.SkinControl.SkinLabel sLabel_expandCompass;
        private CCWin.SkinControl.SkinLabel sLabelAltitude;
        private CCWin.SkinControl.SkinLabel skinLabel18;
        private CCWin.SkinControl.SkinLabel sLabel_info;
        private CCWin.SkinControl.SkinLine skinLine6;
        private CCWin.SkinControl.SkinLine skinLine5;
        private CCWin.SkinControl.SkinLine skinLine4;
        private CCWin.SkinControl.SkinLine skinLine3;
        private CCWin.SkinControl.SkinLine skinLine1;
        private CCWin.SkinControl.SkinPanel skinPanel6;
        private CCWin.SkinControl.SkinPanel skinPanel5;
        private CCWin.SkinControl.SkinPanel sPnl_liangcheng;
        private CCWin.SkinControl.SkinPanel skinPanel7;
        private CCWin.SkinControl.SkinLine skinLine7;
        private CCWin.SkinControl.SkinLabel skinLabel20;
        private CCWin.SkinControl.SkinLabel skinLabel12;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private CCWin.SkinControl.SkinPanel sPnl_Compass;
        private CCWin.SkinControl.SkinPanel sPnl_Func;
        private CCWin.SkinControl.SkinPanel skinPanel8;
        private CCWin.SkinControl.SkinPanel skinPanel9;
        private CCWin.SkinControl.SkinLabel skinLabel25;
        private CCWin.SkinControl.SkinPanel sPnl_Fly;
        private CCWin.SkinControl.SkinLabel sLabel_fly;
        private CCWin.SkinControl.SkinPanel skinPanel3;
        private CCWin.SkinControl.SkinLine skinLine10;
        private CCWin.SkinControl.SkinLine skinLine11;
        private CCWin.SkinControl.SkinLine skinLine12;
        private CCWin.SkinControl.SkinLine skinLine13;
        private CCWin.SkinControl.SkinLabel skinLabel19;
        private CCWin.SkinControl.SkinLabel skinLabel21;
        private CCWin.SkinControl.SkinLabel skinLabel22;
        private CCWin.SkinControl.SkinLabel skinLabel23;
        private CCWin.SkinControl.SkinLabel skinLabel24;
        private CCWin.SkinControl.SkinPanel skinPanel10;
        private CCWin.SkinControl.SkinPanel skinPanel12;
        private CCWin.SkinControl.SkinPanel skinPanel13;
        private CCWin.SkinControl.SkinPanel skinPanel14;
        private CCWin.SkinControl.SkinPanel skinPanel15;
        private CCWin.SkinControl.SkinLine skinLine8;
        private CCWin.SkinControl.SkinLine skinLine14;
        private CCWin.SkinControl.SkinLine skinLine9;
        private CCWin.SkinControl.SkinLabel skinLabel14;
        private CCWin.SkinControl.SkinPanel skinPanel16;
        private CCWin.SkinControl.SkinLabel skinLabel26;
        private CCWin.SkinControl.SkinPanel skinPanel18;
        private CCWin.SkinControl.SkinLabel skinLabel17;
        private CCWin.SkinControl.SkinPanel skinPanel17;
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
    }
}

