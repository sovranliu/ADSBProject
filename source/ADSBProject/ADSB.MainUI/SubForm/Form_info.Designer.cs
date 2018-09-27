namespace ADSB.MainUI.SubForm
{
    partial class Form_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_info));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.sPnl_close = new CCWin.SkinControl.SkinPanel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel13 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel14 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel15 = new CCWin.SkinControl.SkinLabel();
            this.horizonLine1 = new ADSB.MainUI.Controls.HorizonLine();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.skinLabel1.Location = new System.Drawing.Point(96, 15);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(96, 28);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "本机信息";
            // 
            // sPnl_close
            // 
            this.sPnl_close.BackColor = System.Drawing.Color.Transparent;
            this.sPnl_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sPnl_close.BackgroundImage")));
            this.sPnl_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sPnl_close.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sPnl_close.DownBack = null;
            this.sPnl_close.Location = new System.Drawing.Point(254, 4);
            this.sPnl_close.MouseBack = null;
            this.sPnl_close.Name = "sPnl_close";
            this.sPnl_close.NormlBack = null;
            this.sPnl_close.Size = new System.Drawing.Size(22, 22);
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
            this.skinLabel2.Location = new System.Drawing.Point(86, 82);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(44, 17);
            this.skinLabel2.TabIndex = 5;
            this.skinLabel2.Text = "纬度：";
            this.skinLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.skinButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.Color.White;
            this.skinButton1.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton1.IsDrawBorder = false;
            this.skinButton1.IsDrawGlass = false;
            this.skinButton1.Location = new System.Drawing.Point(55, 260);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 44;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(170, 44);
            this.skinButton1.TabIndex = 9;
            this.skinButton1.Text = "我知道了";
            this.skinButton1.UseMnemonic = false;
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(104)))), ((int)(((byte)(190)))));
            this.skinLabel4.Location = new System.Drawing.Point(146, 82);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(36, 17);
            this.skinLabel4.TabIndex = 11;
            this.skinLabel4.Text = "0000";
            this.skinLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(104)))), ((int)(((byte)(190)))));
            this.skinLabel5.Location = new System.Drawing.Point(146, 106);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(36, 17);
            this.skinLabel5.TabIndex = 12;
            this.skinLabel5.Text = "0000";
            this.skinLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.skinLabel8.Location = new System.Drawing.Point(86, 106);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(44, 17);
            this.skinLabel8.TabIndex = 15;
            this.skinLabel8.Text = "经度：";
            this.skinLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinLabel9
            // 
            this.skinLabel9.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel9.Location = new System.Drawing.Point(86, 130);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(44, 17);
            this.skinLabel9.TabIndex = 16;
            this.skinLabel9.Text = "地速：";
            this.skinLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.skinLabel3.Location = new System.Drawing.Point(86, 154);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(44, 17);
            this.skinLabel3.TabIndex = 17;
            this.skinLabel3.Text = "航向：";
            this.skinLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinLabel10
            // 
            this.skinLabel10.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel10.Location = new System.Drawing.Point(62, 178);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(68, 17);
            this.skinLabel10.TabIndex = 18;
            this.skinLabel10.Text = "飞机标识：";
            this.skinLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinLabel11
            // 
            this.skinLabel11.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel11.Location = new System.Drawing.Point(86, 202);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(44, 17);
            this.skinLabel11.TabIndex = 19;
            this.skinLabel11.Text = "高度：";
            this.skinLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinLabel12
            // 
            this.skinLabel12.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel12.AutoSize = true;
            this.skinLabel12.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel12.BorderColor = System.Drawing.Color.White;
            this.skinLabel12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinLabel12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel12.Location = new System.Drawing.Point(62, 226);
            this.skinLabel12.Name = "skinLabel12";
            this.skinLabel12.Size = new System.Drawing.Size(68, 17);
            this.skinLabel12.TabIndex = 20;
            this.skinLabel12.Text = "UAT时间：";
            this.skinLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(104)))), ((int)(((byte)(190)))));
            this.skinLabel6.Location = new System.Drawing.Point(146, 130);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(36, 17);
            this.skinLabel6.TabIndex = 21;
            this.skinLabel6.Text = "0000";
            this.skinLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(104)))), ((int)(((byte)(190)))));
            this.skinLabel7.Location = new System.Drawing.Point(146, 154);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(36, 17);
            this.skinLabel7.TabIndex = 22;
            this.skinLabel7.Text = "0000";
            this.skinLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skinLabel13
            // 
            this.skinLabel13.AutoSize = true;
            this.skinLabel13.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel13.BorderColor = System.Drawing.Color.White;
            this.skinLabel13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(104)))), ((int)(((byte)(190)))));
            this.skinLabel13.Location = new System.Drawing.Point(146, 178);
            this.skinLabel13.Name = "skinLabel13";
            this.skinLabel13.Size = new System.Drawing.Size(36, 17);
            this.skinLabel13.TabIndex = 23;
            this.skinLabel13.Text = "0000";
            this.skinLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skinLabel14
            // 
            this.skinLabel14.AutoSize = true;
            this.skinLabel14.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel14.BorderColor = System.Drawing.Color.White;
            this.skinLabel14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(104)))), ((int)(((byte)(190)))));
            this.skinLabel14.Location = new System.Drawing.Point(146, 202);
            this.skinLabel14.Name = "skinLabel14";
            this.skinLabel14.Size = new System.Drawing.Size(36, 17);
            this.skinLabel14.TabIndex = 24;
            this.skinLabel14.Text = "0000";
            this.skinLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skinLabel15
            // 
            this.skinLabel15.AutoSize = true;
            this.skinLabel15.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel15.BorderColor = System.Drawing.Color.White;
            this.skinLabel15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(104)))), ((int)(((byte)(190)))));
            this.skinLabel15.Location = new System.Drawing.Point(146, 226);
            this.skinLabel15.Name = "skinLabel15";
            this.skinLabel15.Size = new System.Drawing.Size(36, 17);
            this.skinLabel15.TabIndex = 25;
            this.skinLabel15.Text = "0000";
            this.skinLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // horizonLine1
            // 
            this.horizonLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.horizonLine1.LineBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.horizonLine1.LineDashColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.horizonLine1.LineDashLength = 5;
            this.horizonLine1.LineLength = 217;
            this.horizonLine1.LineWidth = 1;
            this.horizonLine1.Location = new System.Drawing.Point(32, 62);
            this.horizonLine1.Name = "horizonLine1";
            this.horizonLine1.Size = new System.Drawing.Size(219, 3);
            this.horizonLine1.TabIndex = 26;
            // 
            // Form_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(280, 324);
            this.Controls.Add(this.horizonLine1);
            this.Controls.Add(this.skinLabel15);
            this.Controls.Add(this.skinLabel14);
            this.Controls.Add(this.skinLabel13);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.skinLabel12);
            this.Controls.Add(this.skinLabel11);
            this.Controls.Add(this.skinLabel10);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel9);
            this.Controls.Add(this.skinLabel8);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.sPnl_close);
            this.Controls.Add(this.skinLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_info";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_liangcheng";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.AppWorkspace;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinPanel sPnl_close;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinLabel skinLabel12;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel13;
        private CCWin.SkinControl.SkinLabel skinLabel14;
        private CCWin.SkinControl.SkinLabel skinLabel15;
        private Controls.HorizonLine horizonLine1;
    }
}