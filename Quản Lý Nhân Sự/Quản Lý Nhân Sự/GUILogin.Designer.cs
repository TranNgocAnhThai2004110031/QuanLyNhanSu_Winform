namespace Quản_Lý_Nhân_Sự
{
    partial class GUILogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUILogin));
            this.gradientPanel1 = new GradientPanelDemo.GradientPanel();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonshow = new System.Windows.Forms.Button();
            this.buttonhide = new System.Windows.Forms.Button();
            this.vbButtonLogin = new CustomButton.VBButton();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.IndianRed;
            this.gradientPanel1.ColorCenter = System.Drawing.Color.Empty;
            this.gradientPanel1.ColorTop = System.Drawing.SystemColors.MenuHighlight;
            this.gradientPanel1.Controls.Add(this.textBoxUsername);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.buttonshow);
            this.gradientPanel1.Controls.Add(this.buttonhide);
            this.gradientPanel1.Controls.Add(this.vbButtonLogin);
            this.gradientPanel1.Controls.Add(this.textBoxPass);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Location = new System.Drawing.Point(-3, -5);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(595, 740);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mix);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsername.Location = new System.Drawing.Point(196, 345);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxUsername.Size = new System.Drawing.Size(252, 41);
            this.textBoxUsername.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 42);
            this.panel2.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.tew;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(482, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = resources.GetString("button2.Text");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.tắt_copy;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(545, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = resources.GetString("button1.Text");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonshow
            // 
            this.buttonshow.BackColor = System.Drawing.SystemColors.Control;
            this.buttonshow.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.hidepassope1;
            this.buttonshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonshow.FlatAppearance.BorderSize = 0;
            this.buttonshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonshow.Location = new System.Drawing.Point(407, 431);
            this.buttonshow.Name = "buttonshow";
            this.buttonshow.Size = new System.Drawing.Size(37, 29);
            this.buttonshow.TabIndex = 8;
            this.buttonshow.UseVisualStyleBackColor = false;
            this.buttonshow.Click += new System.EventHandler(this.buttonshow_Click);
            // 
            // buttonhide
            // 
            this.buttonhide.BackColor = System.Drawing.SystemColors.Control;
            this.buttonhide.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.hidepassclos1;
            this.buttonhide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonhide.FlatAppearance.BorderSize = 0;
            this.buttonhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhide.Location = new System.Drawing.Point(407, 431);
            this.buttonhide.Name = "buttonhide";
            this.buttonhide.Size = new System.Drawing.Size(28, 29);
            this.buttonhide.TabIndex = 7;
            this.buttonhide.UseVisualStyleBackColor = false;
            this.buttonhide.Click += new System.EventHandler(this.buttonhide_Click);
            // 
            // vbButtonLogin
            // 
            this.vbButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vbButtonLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vbButtonLogin.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.đăng_nhập;
            this.vbButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vbButtonLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButtonLogin.BorderRadius = 20;
            this.vbButtonLogin.BorderSize = 0;
            this.vbButtonLogin.FlatAppearance.BorderSize = 0;
            this.vbButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButtonLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vbButtonLogin.Location = new System.Drawing.Point(253, 530);
            this.vbButtonLogin.Name = "vbButtonLogin";
            this.vbButtonLogin.Size = new System.Drawing.Size(116, 69);
            this.vbButtonLogin.TabIndex = 6;
            this.vbButtonLogin.Text = "Login";
            this.vbButtonLogin.TextColor = System.Drawing.SystemColors.ControlText;
            this.vbButtonLogin.UseVisualStyleBackColor = false;
            this.vbButtonLogin.Click += new System.EventHandler(this.vbButtonLogin_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPass.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.Black;
            this.textBoxPass.Location = new System.Drawing.Point(196, 427);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPass.Size = new System.Drawing.Size(252, 41);
            this.textBoxPass.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(78, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(68, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(260, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "LOG IN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.logo2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(207, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 192);
            this.panel1.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(591, 733);
            this.Controls.Add(this.gradientPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox hienMK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private GradientPanelDemo.GradientPanel gradientPanel1;
        private CustomButton.VBButton vbButtonLogin;
        public System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonshow;
        private System.Windows.Forms.Button buttonhide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBoxUsername;
    }
}

