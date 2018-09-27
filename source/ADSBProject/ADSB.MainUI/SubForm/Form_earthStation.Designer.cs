namespace ADSB.MainUI.SubForm
{
    partial class Form_earthStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_earthStation));
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
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(201)))));
            this.skinLabel1.Location = new System.Drawing.Point(85, 15);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(117, 28);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "新增地面站";
            this.skinLabel1.Click += new System.EventHandler(this.skinLabel1_Click);
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
            this.skinButton1.Location = new System.Drawing.Point(75, 252);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 44;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(130, 44);
            this.skinButton1.TabIndex = 9;
            this.skinButton1.Text = "保存设置";
            this.skinButton1.UseMnemonic = false;
            this.skinButton1.UseVisualStyleBackColor = false;
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
            this.skinLabel8.Location = new System.Drawing.Point(33, 97);
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
            this.skinLabel9.Location = new System.Drawing.Point(33, 148);
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
            this.skinLabel3.Location = new System.Drawing.Point(33, 199);
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
            this.skinTextBox2.Location = new System.Drawing.Point(85, 82);
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
            this.skinTextBox2.Size = new System.Drawing.Size(165, 40);
            // 
            // 
            // 
            this.skinTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinTextBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox2.SkinTxt.Multiline = true;
            this.skinTextBox2.SkinTxt.Name = "BaseText";
            this.skinTextBox2.SkinTxt.Size = new System.Drawing.Size(155, 30);
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
            this.skinTextBox3.Location = new System.Drawing.Point(85, 135);
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
            this.skinTextBox3.Size = new System.Drawing.Size(165, 40);
            // 
            // 
            // 
            this.skinTextBox3.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox3.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox3.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinTextBox3.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox3.SkinTxt.Multiline = true;
            this.skinTextBox3.SkinTxt.Name = "BaseText";
            this.skinTextBox3.SkinTxt.Size = new System.Drawing.Size(155, 30);
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
            this.skinTextBox4.Location = new System.Drawing.Point(85, 188);
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
            this.skinTextBox4.Size = new System.Drawing.Size(165, 40);
            // 
            // 
            // 
            this.skinTextBox4.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox4.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox4.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinTextBox4.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox4.SkinTxt.Multiline = true;
            this.skinTextBox4.SkinTxt.Name = "BaseText";
            this.skinTextBox4.SkinTxt.Size = new System.Drawing.Size(155, 30);
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
            this.horizonLine1.Location = new System.Drawing.Point(32, 62);
            this.horizonLine1.Name = "horizonLine1";
            this.horizonLine1.Size = new System.Drawing.Size(152, 3);
            this.horizonLine1.TabIndex = 20;
            // 
            // Form_earthStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(280, 316);
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
            this.Name = "Form_earthStation";
            this.Text = "Form_earthStation";
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
    }
}