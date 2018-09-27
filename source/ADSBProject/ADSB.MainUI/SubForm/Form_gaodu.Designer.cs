namespace ADSB.MainUI.SubForm
{
    partial class Form_gaodu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_gaodu));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.sPnl_close = new CCWin.SkinControl.SkinPanel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
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
            this.skinLabel1.Text = "高度过滤";
            // 
            // sPnl_close
            // 
            this.sPnl_close.BackColor = System.Drawing.Color.Transparent;
            this.sPnl_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sPnl_close.BackgroundImage")));
            this.sPnl_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sPnl_close.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sPnl_close.DownBack = null;
            this.sPnl_close.Location = new System.Drawing.Point(254, 3);
            this.sPnl_close.MouseBack = null;
            this.sPnl_close.Name = "sPnl_close";
            this.sPnl_close.NormlBack = null;
            this.sPnl_close.Size = new System.Drawing.Size(22, 22);
            this.sPnl_close.TabIndex = 3;
            this.sPnl_close.Click += new System.EventHandler(this.sPnl_close_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.skinLabel2.Location = new System.Drawing.Point(74, 88);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(128, 17);
            this.skinLabel2.TabIndex = 5;
            this.skinLabel2.Text = "请输入高度过滤范围：";
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
            this.skinTextBox1.Location = new System.Drawing.Point(57, 121);
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
            this.skinTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(164, 40);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Multiline = true;
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(154, 30);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 8;
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
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
            this.skinButton1.Location = new System.Drawing.Point(76, 191);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 44;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(130, 44);
            this.skinButton1.TabIndex = 9;
            this.skinButton1.Text = "确定";
            this.skinButton1.UseMnemonic = false;
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // horizonLine1
            // 
            this.horizonLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.horizonLine1.LineBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.horizonLine1.LineDashColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.horizonLine1.LineDashLength = 5;
            this.horizonLine1.LineLength = 216;
            this.horizonLine1.LineWidth = 1;
            this.horizonLine1.Location = new System.Drawing.Point(32, 62);
            this.horizonLine1.Name = "horizonLine1";
            this.horizonLine1.Size = new System.Drawing.Size(218, 3);
            this.horizonLine1.TabIndex = 10;
            // 
            // Form_gaodu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(280, 255);
            this.Controls.Add(this.horizonLine1);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.skinTextBox1);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.sPnl_close);
            this.Controls.Add(this.skinLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_gaodu";
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
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private Controls.HorizonLine horizonLine1;
    }
}