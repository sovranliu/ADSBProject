namespace ADSB.MainUI.SubForm
{
    partial class Form_mapTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mapTool));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.sPnl_close = new CCWin.SkinControl.SkinPanel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinComboBox2 = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.myCheckBox9 = new ADSB.MainUI.Controls.myCheckBox();
            this.myCheckBox8 = new ADSB.MainUI.Controls.myCheckBox();
            this.myCheckBox7 = new ADSB.MainUI.Controls.myCheckBox();
            this.myCheckBox6 = new ADSB.MainUI.Controls.myCheckBox();
            this.myCheckBox5 = new ADSB.MainUI.Controls.myCheckBox();
            this.myCheckBox4 = new ADSB.MainUI.Controls.myCheckBox();
            this.myCheckBox3 = new ADSB.MainUI.Controls.myCheckBox();
            this.myCheckBox2 = new ADSB.MainUI.Controls.myCheckBox();
            this.myCheckBox1 = new ADSB.MainUI.Controls.myCheckBox();
            this.horizonLine1 = new ADSB.MainUI.Controls.HorizonLine();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.skinLabel1.Location = new System.Drawing.Point(186, 22);
            this.skinLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(146, 41);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "地图工具";
            this.skinLabel1.Click += new System.EventHandler(this.skinLabel1_Click);
            // 
            // sPnl_close
            // 
            this.sPnl_close.BackColor = System.Drawing.Color.Transparent;
            this.sPnl_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sPnl_close.BackgroundImage")));
            this.sPnl_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sPnl_close.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sPnl_close.DownBack = null;
            this.sPnl_close.Location = new System.Drawing.Point(465, 4);
            this.sPnl_close.Margin = new System.Windows.Forms.Padding(4);
            this.sPnl_close.MouseBack = null;
            this.sPnl_close.Name = "sPnl_close";
            this.sPnl_close.NormlBack = null;
            this.sPnl_close.Size = new System.Drawing.Size(33, 33);
            this.sPnl_close.TabIndex = 3;
            this.sPnl_close.Click += new System.EventHandler(this.sPnl_close_Click);
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
            this.skinButton1.Location = new System.Drawing.Point(124, 405);
            this.skinButton1.Margin = new System.Windows.Forms.Padding(4);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 44;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(255, 66);
            this.skinButton1.TabIndex = 9;
            this.skinButton1.Text = "我知道了";
            this.skinButton1.UseMnemonic = false;
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinComboBox2
            // 
            this.skinComboBox2.BaseColor = System.Drawing.Color.White;
            this.skinComboBox2.BorderColor = System.Drawing.Color.Silver;
            this.skinComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinComboBox2.FormattingEnabled = true;
            this.skinComboBox2.ItemBorderColor = System.Drawing.Color.White;
            this.skinComboBox2.Items.AddRange(new object[] {
            "3"});
            this.skinComboBox2.Location = new System.Drawing.Point(366, 298);
            this.skinComboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.skinComboBox2.Name = "skinComboBox2";
            this.skinComboBox2.Size = new System.Drawing.Size(74, 56);
            this.skinComboBox2.TabIndex = 23;
            this.skinComboBox2.WaterText = "";
            // 
            // skinLabel6
            // 
            this.skinLabel6.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel6.Location = new System.Drawing.Point(246, 314);
            this.skinLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(117, 27);
            this.skinLabel6.TabIndex = 43;
            this.skinLabel6.Text = "航迹点个数:";
            this.skinLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // myCheckBox9
            // 
            this.myCheckBox9.AutoSize = true;
            this.myCheckBox9.BackColor = System.Drawing.Color.White;
            this.myCheckBox9.BaseColor = System.Drawing.Color.White;
            this.myCheckBox9.CheckButtonWidth = 17;
            this.myCheckBox9.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCheckBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.myCheckBox9.Location = new System.Drawing.Point(63, 316);
            this.myCheckBox9.Margin = new System.Windows.Forms.Padding(4);
            this.myCheckBox9.Name = "myCheckBox9";
            this.myCheckBox9.Size = new System.Drawing.Size(138, 31);
            this.myCheckBox9.TabIndex = 42;
            this.myCheckBox9.Text = "航迹圈过滤";
            this.myCheckBox9.UseVisualStyleBackColor = false;
            this.myCheckBox9.CheckedChanged += new System.EventHandler(this.myCheckBox9_CheckedChanged);
            // 
            // myCheckBox8
            // 
            this.myCheckBox8.AutoSize = true;
            this.myCheckBox8.BackColor = System.Drawing.Color.White;
            this.myCheckBox8.BaseColor = System.Drawing.Color.White;
            this.myCheckBox8.CheckButtonWidth = 17;
            this.myCheckBox8.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCheckBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.myCheckBox8.Location = new System.Drawing.Point(63, 260);
            this.myCheckBox8.Margin = new System.Windows.Forms.Padding(4);
            this.myCheckBox8.Name = "myCheckBox8";
            this.myCheckBox8.Size = new System.Drawing.Size(238, 31);
            this.myCheckBox8.TabIndex = 41;
            this.myCheckBox8.Text = "转换公制（默认英制）";
            this.myCheckBox8.UseVisualStyleBackColor = false;
            // 
            // myCheckBox7
            // 
            this.myCheckBox7.AutoSize = true;
            this.myCheckBox7.BackColor = System.Drawing.Color.White;
            this.myCheckBox7.BaseColor = System.Drawing.Color.White;
            this.myCheckBox7.CheckButtonWidth = 17;
            this.myCheckBox7.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCheckBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.myCheckBox7.Location = new System.Drawing.Point(372, 260);
            this.myCheckBox7.Margin = new System.Windows.Forms.Padding(4);
            this.myCheckBox7.Name = "myCheckBox7";
            this.myCheckBox7.Size = new System.Drawing.Size(98, 31);
            this.myCheckBox7.TabIndex = 40;
            this.myCheckBox7.Text = "地面站";
            this.myCheckBox7.UseVisualStyleBackColor = false;
            this.myCheckBox7.CheckedChanged += new System.EventHandler(this.myCheckBox7_CheckedChanged);
            // 
            // myCheckBox6
            // 
            this.myCheckBox6.AutoSize = true;
            this.myCheckBox6.BackColor = System.Drawing.Color.White;
            this.myCheckBox6.BaseColor = System.Drawing.Color.White;
            this.myCheckBox6.CheckButtonWidth = 17;
            this.myCheckBox6.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCheckBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.myCheckBox6.Location = new System.Drawing.Point(372, 206);
            this.myCheckBox6.Margin = new System.Windows.Forms.Padding(4);
            this.myCheckBox6.Name = "myCheckBox6";
            this.myCheckBox6.Size = new System.Drawing.Size(78, 31);
            this.myCheckBox6.TabIndex = 39;
            this.myCheckBox6.Text = "天气";
            this.myCheckBox6.UseVisualStyleBackColor = false;
            // 
            // myCheckBox5
            // 
            this.myCheckBox5.AutoSize = true;
            this.myCheckBox5.BackColor = System.Drawing.Color.White;
            this.myCheckBox5.BaseColor = System.Drawing.Color.White;
            this.myCheckBox5.CheckButtonWidth = 17;
            this.myCheckBox5.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCheckBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.myCheckBox5.Location = new System.Drawing.Point(218, 206);
            this.myCheckBox5.Margin = new System.Windows.Forms.Padding(4);
            this.myCheckBox5.Name = "myCheckBox5";
            this.myCheckBox5.Size = new System.Drawing.Size(98, 31);
            this.myCheckBox5.TabIndex = 38;
            this.myCheckBox5.Text = "航路点";
            this.myCheckBox5.UseVisualStyleBackColor = false;
            this.myCheckBox5.CheckedChanged += new System.EventHandler(this.myCheckBox5_CheckedChanged);
            // 
            // myCheckBox4
            // 
            this.myCheckBox4.AutoSize = true;
            this.myCheckBox4.BackColor = System.Drawing.Color.White;
            this.myCheckBox4.BaseColor = System.Drawing.Color.White;
            this.myCheckBox4.CheckButtonWidth = 17;
            this.myCheckBox4.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCheckBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.myCheckBox4.Location = new System.Drawing.Point(63, 206);
            this.myCheckBox4.Margin = new System.Windows.Forms.Padding(4);
            this.myCheckBox4.Name = "myCheckBox4";
            this.myCheckBox4.Size = new System.Drawing.Size(78, 31);
            this.myCheckBox4.TabIndex = 37;
            this.myCheckBox4.Text = "机场";
            this.myCheckBox4.UseVisualStyleBackColor = false;
            this.myCheckBox4.CheckedChanged += new System.EventHandler(this.myCheckBox4_CheckedChanged);
            // 
            // myCheckBox3
            // 
            this.myCheckBox3.AutoSize = true;
            this.myCheckBox3.BackColor = System.Drawing.Color.White;
            this.myCheckBox3.BaseColor = System.Drawing.Color.White;
            this.myCheckBox3.CheckButtonWidth = 17;
            this.myCheckBox3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCheckBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.myCheckBox3.Location = new System.Drawing.Point(372, 152);
            this.myCheckBox3.Margin = new System.Windows.Forms.Padding(4);
            this.myCheckBox3.Name = "myCheckBox3";
            this.myCheckBox3.Size = new System.Drawing.Size(78, 31);
            this.myCheckBox3.TabIndex = 36;
            this.myCheckBox3.Text = "航段";
            this.myCheckBox3.UseVisualStyleBackColor = false;
            this.myCheckBox3.CheckedChanged += new System.EventHandler(this.myCheckBox3_CheckedChanged);
            // 
            // myCheckBox2
            // 
            this.myCheckBox2.AutoSize = true;
            this.myCheckBox2.BackColor = System.Drawing.Color.White;
            this.myCheckBox2.BaseColor = System.Drawing.Color.White;
            this.myCheckBox2.CheckButtonWidth = 17;
            this.myCheckBox2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCheckBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.myCheckBox2.Location = new System.Drawing.Point(218, 152);
            this.myCheckBox2.Margin = new System.Windows.Forms.Padding(4);
            this.myCheckBox2.Name = "myCheckBox2";
            this.myCheckBox2.Size = new System.Drawing.Size(78, 31);
            this.myCheckBox2.TabIndex = 35;
            this.myCheckBox2.Text = "空域";
            this.myCheckBox2.UseVisualStyleBackColor = false;
            this.myCheckBox2.CheckedChanged += new System.EventHandler(this.myCheckBox2_CheckedChanged);
            // 
            // myCheckBox1
            // 
            this.myCheckBox1.AutoSize = true;
            this.myCheckBox1.BackColor = System.Drawing.Color.White;
            this.myCheckBox1.BaseColor = System.Drawing.Color.White;
            this.myCheckBox1.CheckButtonWidth = 17;
            this.myCheckBox1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.myCheckBox1.Location = new System.Drawing.Point(63, 152);
            this.myCheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.myCheckBox1.Name = "myCheckBox1";
            this.myCheckBox1.Size = new System.Drawing.Size(98, 31);
            this.myCheckBox1.TabIndex = 34;
            this.myCheckBox1.Text = "飞行器";
            this.myCheckBox1.UseVisualStyleBackColor = false;
            // 
            // horizonLine1
            // 
            this.horizonLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.horizonLine1.LineBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.horizonLine1.LineDashColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.horizonLine1.LineDashLength = 5;
            this.horizonLine1.LineLength = 267;
            this.horizonLine1.LineWidth = 1;
            this.horizonLine1.Location = new System.Drawing.Point(56, 93);
            this.horizonLine1.Margin = new System.Windows.Forms.Padding(6);
            this.horizonLine1.Name = "horizonLine1";
            this.horizonLine1.Size = new System.Drawing.Size(269, 3);
            this.horizonLine1.TabIndex = 44;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel1.BackgroundImage")));
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(162, 148);
            this.skinPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(27, 33);
            this.skinPanel1.TabIndex = 45;
            // 
            // Form_mapTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(504, 502);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.horizonLine1);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.myCheckBox9);
            this.Controls.Add(this.myCheckBox8);
            this.Controls.Add(this.myCheckBox7);
            this.Controls.Add(this.myCheckBox6);
            this.Controls.Add(this.myCheckBox5);
            this.Controls.Add(this.myCheckBox4);
            this.Controls.Add(this.myCheckBox3);
            this.Controls.Add(this.myCheckBox2);
            this.Controls.Add(this.myCheckBox1);
            this.Controls.Add(this.skinComboBox2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.sPnl_close);
            this.Controls.Add(this.skinLabel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_mapTool";
            this.Text = "Form_mapTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinPanel sPnl_close;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinComboBox skinComboBox2;
        private Controls.myCheckBox myCheckBox1;
        private Controls.myCheckBox myCheckBox2;
        private Controls.myCheckBox myCheckBox3;
        private Controls.myCheckBox myCheckBox4;
        private Controls.myCheckBox myCheckBox5;
        private Controls.myCheckBox myCheckBox6;
        private Controls.myCheckBox myCheckBox7;
        private Controls.myCheckBox myCheckBox8;
        private Controls.myCheckBox myCheckBox9;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private Controls.HorizonLine horizonLine1;
        private CCWin.SkinControl.SkinPanel skinPanel1;
    }
}