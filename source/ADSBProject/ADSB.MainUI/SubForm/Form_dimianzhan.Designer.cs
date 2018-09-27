namespace ADSB.MainUI.SubForm
{
    partial class Form_dimianzhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_dimianzhan));
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.sLabel_add = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.skinPanel1.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            this.skinPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel1.BackgroundImage")));
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.sLabel_add);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(509, 52);
            this.skinPanel1.TabIndex = 0;
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinPanel2.BackgroundImage")));
            this.skinPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skinPanel2.Controls.Add(this.listView1);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(0, 120);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Radius = 34;
            this.skinPanel2.Size = new System.Drawing.Size(509, 343);
            this.skinPanel2.TabIndex = 1;
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.skinLabel1.ForeColor = System.Drawing.Color.White;
            this.skinLabel1.Location = new System.Drawing.Point(227, 14);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(75, 28);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "地面站";
            // 
            // sLabel_add
            // 
            this.sLabel_add.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.sLabel_add.AutoSize = true;
            this.sLabel_add.BackColor = System.Drawing.Color.Transparent;
            this.sLabel_add.BorderColor = System.Drawing.Color.White;
            this.sLabel_add.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sLabel_add.ForeColor = System.Drawing.Color.White;
            this.sLabel_add.Location = new System.Drawing.Point(20, 18);
            this.sLabel_add.Name = "sLabel_add";
            this.sLabel_add.Size = new System.Drawing.Size(42, 21);
            this.sLabel_add.TabIndex = 1;
            this.sLabel_add.Text = "新增";
            this.sLabel_add.Click += new System.EventHandler(this.sLabel_add_Click);
            // 
            // skinLabel3
            // 
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.White;
            this.skinLabel3.Location = new System.Drawing.Point(457, 18);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(42, 21);
            this.skinLabel3.TabIndex = 2;
            this.skinLabel3.Text = "删除";
            // 
            // skinLabel4
            // 
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.skinLabel4.Location = new System.Drawing.Point(457, 75);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(42, 21);
            this.skinLabel4.TabIndex = 3;
            this.skinLabel4.Text = "新增";
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.skinPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            this.skinPanel3.Controls.Add(this.textBox1);
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Location = new System.Drawing.Point(20, 69);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.Radius = 28;
            this.skinPanel3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel3.Size = new System.Drawing.Size(410, 34);
            this.skinPanel3.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(15, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 25);
            this.textBox1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(509, 343);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form_dimianzhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(509, 463);
            this.Controls.Add(this.skinPanel3);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.skinPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_dimianzhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_dimianzhan";
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel sLabel_add;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinPanel skinPanel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
    }
}