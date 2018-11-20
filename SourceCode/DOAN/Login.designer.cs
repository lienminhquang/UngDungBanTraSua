namespace DOAN
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bubtnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bubtnLogin);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.bunifuSeparator4);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.bunifuSeparator3);
            this.panel1.Location = new System.Drawing.Point(-1, 270);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 325);
            this.panel1.TabIndex = 0;
            // 
            // bubtnLogin
            // 
            this.bubtnLogin.ActiveBorderThickness = 1;
            this.bubtnLogin.ActiveCornerRadius = 30;
            this.bubtnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bubtnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.bubtnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bubtnLogin.BackColor = System.Drawing.Color.White;
            this.bubtnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bubtnLogin.BackgroundImage")));
            this.bubtnLogin.ButtonText = "Login";
            this.bubtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bubtnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubtnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.bubtnLogin.IdleBorderThickness = 1;
            this.bubtnLogin.IdleCornerRadius = 30;
            this.bubtnLogin.IdleFillColor = System.Drawing.Color.White;
            this.bubtnLogin.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bubtnLogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bubtnLogin.Location = new System.Drawing.Point(71, 244);
            this.bubtnLogin.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bubtnLogin.Name = "bubtnLogin";
            this.bubtnLogin.Size = new System.Drawing.Size(283, 58);
            this.bubtnLogin.TabIndex = 2;
            this.bubtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bubtnLogin.Click += new System.EventHandler(this.bubtnLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(352, 161);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.lockun);
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtPass.ForeColor = System.Drawing.Color.Gray;
            this.txtPass.Location = new System.Drawing.Point(69, 150);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(279, 27);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "Password";
            this.txtPass.Enter += new System.EventHandler(this.Enter2);
            this.txtPass.Leave += new System.EventHandler(this.Leave2);
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator4.LineThickness = 2;
            this.bunifuSeparator4.Location = new System.Drawing.Point(69, 185);
            this.bunifuSeparator4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(280, 4);
            this.bunifuSeparator4.TabIndex = 3;
            this.bunifuSeparator4.Transparency = 100;
            this.bunifuSeparator4.Vertical = false;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtUser.ForeColor = System.Drawing.Color.Gray;
            this.txtUser.Location = new System.Drawing.Point(73, 94);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(279, 27);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "User Name";
            this.txtUser.Enter += new System.EventHandler(this.Enter1);
            this.txtUser.Leave += new System.EventHandler(this.Leave1);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator3.LineThickness = 2;
            this.bunifuSeparator3.Location = new System.Drawing.Point(73, 128);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(280, 4);
            this.bunifuSeparator3.TabIndex = 1;
            this.bunifuSeparator3.Transparency = 100;
            this.bunifuSeparator3.Vertical = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DOAN.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 633);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bubtnLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPass;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private System.Windows.Forms.TextBox txtUser;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

