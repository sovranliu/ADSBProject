namespace ADSB.MainUI.SubForm
{
    partial class Form_playback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_playback));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.sPnl_close = new CCWin.SkinControl.SkinPanel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox2 = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBox3 = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBox4 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.myCheckBox1 = new ADSB.MainUI.Controls.myCheckBox();
            this.myCheckBox2 = new ADSB.MainUI.Controls.myCheckBox();
            this.myCheckBox3 = new ADSB.MainUI.Controls.myCheckBox();
            this.horizonLine1 = new ADSB.MainUI.Controls.HorizonLine();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.skinLabel1.Location = new System.Drawing.Point(144, 22);
            this.skinLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(146, 41);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "回放设置";
            this.skinLabel1.Click += new System.EventHandler(this.skinLabel1_Click);
            // 
            // sPnl_close
            // 
            this.sPnl_close.BackColor = System.Drawing.Color.Transparent;
            this.sPnl_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sPnl_close.BackgroundImage")));
            this.sPnl_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sPnl_close.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sPnl_close.DownBack = null;
            this.sPnl_close.Location = new System.Drawing.Point(381, 4);
            this.sPnl_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sPnl_close.MouseBack = null;
            this.sPnl_close.Name = "sPnl_close";
            this.sPnl_close.NormlBack = null;
            this.sPnl_close.Size = new System.Drawing.Size(33, 33);
            this.sPnl_close.TabIndex = 3;
            this.sPnl_close.Click += new System.EventHandler(this.sPnl_close_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel2.Location = new System.Drawing.Point(30, 146);
            this.skinLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.skinLabel2.Size = new System.Drawing.Size(86, 24);
            this.skinLabel2.TabIndex = 5;
            this.skinLabel2.Text = "开始时间:";
            this.skinLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.skinLabel2.Click += new System.EventHandler(this.skinLabel2_Click);
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
            this.skinButton1.Location = new System.Drawing.Point(114, 378);
            this.skinButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 44;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(195, 66);
            this.skinButton1.TabIndex = 9;
            this.skinButton1.Text = "确定";
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
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel8.Location = new System.Drawing.Point(30, 222);
            this.skinLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(86, 24);
            this.skinLabel8.TabIndex = 15;
            this.skinLabel8.Text = "速率选择:";
            this.skinLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinLabel3
            // 
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel3.Location = new System.Drawing.Point(24, 298);
            this.skinLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(96, 24);
            this.skinLabel3.TabIndex = 17;
            this.skinLabel3.Text = "S模式地址:";
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
            this.skinTextBox2.Location = new System.Drawing.Point(128, 123);
            this.skinTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox2.MaxLength = 32767;
            this.skinTextBox2.MinimumSize = new System.Drawing.Size(42, 42);
            this.skinTextBox2.MouseBack = null;
            this.skinTextBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Multiline = true;
            this.skinTextBox2.Name = "skinTextBox2";
            this.skinTextBox2.NormlBack = null;
            this.skinTextBox2.Padding = new System.Windows.Forms.Padding(8, 15, 8, 8);
            this.skinTextBox2.ReadOnly = false;
            this.skinTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox2.Size = new System.Drawing.Size(112, 60);
            // 
            // 
            // 
            this.skinTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinTextBox2.SkinTxt.Location = new System.Drawing.Point(8, 15);
            this.skinTextBox2.SkinTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.skinTextBox2.SkinTxt.Multiline = true;
            this.skinTextBox2.SkinTxt.Name = "BaseText";
            this.skinTextBox2.SkinTxt.Size = new System.Drawing.Size(96, 37);
            this.skinTextBox2.SkinTxt.TabIndex = 0;
            this.skinTextBox2.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBox2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.SkinTxt.WaterText = "开始时间";
            this.skinTextBox2.TabIndex = 19;
            this.skinTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBox2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.WaterText = "开始时间";
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
            this.skinTextBox3.Location = new System.Drawing.Point(274, 123);
            this.skinTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox3.MaxLength = 32767;
            this.skinTextBox3.MinimumSize = new System.Drawing.Size(42, 42);
            this.skinTextBox3.MouseBack = null;
            this.skinTextBox3.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox3.Multiline = true;
            this.skinTextBox3.Name = "skinTextBox3";
            this.skinTextBox3.NormlBack = null;
            this.skinTextBox3.Padding = new System.Windows.Forms.Padding(8, 15, 8, 8);
            this.skinTextBox3.ReadOnly = false;
            this.skinTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox3.Size = new System.Drawing.Size(112, 60);
            // 
            // 
            // 
            this.skinTextBox3.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox3.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox3.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinTextBox3.SkinTxt.Location = new System.Drawing.Point(8, 15);
            this.skinTextBox3.SkinTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.skinTextBox3.SkinTxt.Multiline = true;
            this.skinTextBox3.SkinTxt.Name = "BaseText";
            this.skinTextBox3.SkinTxt.Size = new System.Drawing.Size(96, 37);
            this.skinTextBox3.SkinTxt.TabIndex = 0;
            this.skinTextBox3.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBox3.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox3.SkinTxt.WaterText = "结束时间";
            this.skinTextBox3.TabIndex = 19;
            this.skinTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skinTextBox3.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox3.WaterText = "结束时间";
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
            this.skinTextBox4.Location = new System.Drawing.Point(128, 278);
            this.skinTextBox4.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox4.MaxLength = 32767;
            this.skinTextBox4.MinimumSize = new System.Drawing.Size(42, 42);
            this.skinTextBox4.MouseBack = null;
            this.skinTextBox4.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox4.Multiline = true;
            this.skinTextBox4.Name = "skinTextBox4";
            this.skinTextBox4.NormlBack = null;
            this.skinTextBox4.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.skinTextBox4.ReadOnly = false;
            this.skinTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox4.Size = new System.Drawing.Size(260, 60);
            // 
            // 
            // 
            this.skinTextBox4.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox4.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox4.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinTextBox4.SkinTxt.Location = new System.Drawing.Point(8, 8);
            this.skinTextBox4.SkinTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.skinTextBox4.SkinTxt.Multiline = true;
            this.skinTextBox4.SkinTxt.Name = "BaseText";
            this.skinTextBox4.SkinTxt.Size = new System.Drawing.Size(244, 44);
            this.skinTextBox4.SkinTxt.TabIndex = 0;
            this.skinTextBox4.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox4.SkinTxt.WaterText = "";
            this.skinTextBox4.TabIndex = 19;
            this.skinTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox4.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox4.WaterText = "";
            this.skinTextBox4.WordWrap = true;
            // 
            // skinLabel4
            // 
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel4.Location = new System.Drawing.Point(234, 132);
            this.skinLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(46, 38);
            this.skinLabel4.TabIndex = 28;
            this.skinLabel4.Text = "－";
            this.skinLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // myCheckBox1
            // 
            this.myCheckBox1.AutoSize = true;
            this.myCheckBox1.BackColor = System.Drawing.Color.White;
            this.myCheckBox1.BaseColor = System.Drawing.Color.White;
            this.myCheckBox1.CheckButtonWidth = 17;
            this.myCheckBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.myCheckBox1.Location = new System.Drawing.Point(128, 219);
            this.myCheckBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myCheckBox1.Name = "myCheckBox1";
            this.myCheckBox1.Size = new System.Drawing.Size(72, 28);
            this.myCheckBox1.TabIndex = 35;
            this.myCheckBox1.Text = "正常";
            this.myCheckBox1.UseVisualStyleBackColor = false;
            this.myCheckBox1.Click += new System.EventHandler(this.myCheckBox1_Click);
            // 
            // myCheckBox2
            // 
            this.myCheckBox2.AutoSize = true;
            this.myCheckBox2.BackColor = System.Drawing.Color.White;
            this.myCheckBox2.BaseColor = System.Drawing.Color.White;
            this.myCheckBox2.CheckButtonWidth = 17;
            this.myCheckBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCheckBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.myCheckBox2.Location = new System.Drawing.Point(226, 219);
            this.myCheckBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myCheckBox2.Name = "myCheckBox2";
            this.myCheckBox2.Size = new System.Drawing.Size(65, 28);
            this.myCheckBox2.TabIndex = 36;
            this.myCheckBox2.Text = "2倍";
            this.myCheckBox2.UseVisualStyleBackColor = false;
            this.myCheckBox2.Click += new System.EventHandler(this.myCheckBox2_Click);
            // 
            // myCheckBox3
            // 
            this.myCheckBox3.AutoSize = true;
            this.myCheckBox3.BackColor = System.Drawing.Color.White;
            this.myCheckBox3.BaseColor = System.Drawing.Color.White;
            this.myCheckBox3.CheckButtonWidth = 17;
            this.myCheckBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCheckBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.myCheckBox3.Location = new System.Drawing.Point(326, 219);
            this.myCheckBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myCheckBox3.Name = "myCheckBox3";
            this.myCheckBox3.Size = new System.Drawing.Size(65, 28);
            this.myCheckBox3.TabIndex = 37;
            this.myCheckBox3.Text = "5倍";
            this.myCheckBox3.UseVisualStyleBackColor = false;
            this.myCheckBox3.Click += new System.EventHandler(this.myCheckBox3_Click);
            // 
            // horizonLine1
            // 
            this.horizonLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.horizonLine1.LineBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.horizonLine1.LineDashColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.horizonLine1.LineDashLength = 5;
            this.horizonLine1.LineLength = 217;
            this.horizonLine1.LineWidth = 1;
            this.horizonLine1.Location = new System.Drawing.Point(48, 93);
            this.horizonLine1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.horizonLine1.Name = "horizonLine1";
            this.horizonLine1.Size = new System.Drawing.Size(219, 3);
            this.horizonLine1.TabIndex = 38;
            // 
            // Form_playback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(420, 474);
            this.Controls.Add(this.horizonLine1);
            this.Controls.Add(this.myCheckBox3);
            this.Controls.Add(this.myCheckBox2);
            this.Controls.Add(this.myCheckBox1);
            this.Controls.Add(this.skinLabel8);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.sPnl_close);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinTextBox4);
            this.Controls.Add(this.skinTextBox3);
            this.Controls.Add(this.skinTextBox2);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form_playback";
            this.Text = "Form_playback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinPanel sPnl_close;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinTextBox skinTextBox2;
        private CCWin.SkinControl.SkinTextBox skinTextBox3;
        private CCWin.SkinControl.SkinTextBox skinTextBox4;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private Controls.myCheckBox myCheckBox1;
        private Controls.myCheckBox myCheckBox2;
        private Controls.myCheckBox myCheckBox3;
        private Controls.HorizonLine horizonLine1;
    }
}