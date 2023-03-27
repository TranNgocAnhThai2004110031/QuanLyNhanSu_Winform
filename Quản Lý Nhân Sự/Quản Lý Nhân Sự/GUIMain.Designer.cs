namespace Quản_Lý_Nhân_Sự
{
    partial class GUIMain
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
            this.panelChild = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxPhongBan = new System.Windows.Forms.ComboBox();
            this.vbButton1 = new CustomButton.VBButton();
            this.textBoxMaNhanViẻn = new System.Windows.Forms.TextBox();
            this.textBoxHovaTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelNhanSu = new System.Windows.Forms.Panel();
            this.buttonNhanVien = new System.Windows.Forms.Button();
            this.buttonPhongban = new System.Windows.Forms.Button();
            this.buttonNhanSu = new System.Windows.Forms.Button();
            this.panelSYSTEM = new System.Windows.Forms.Panel();
            this.buttonDangXuat = new System.Windows.Forms.Button();
            this.buttonQLTK = new System.Windows.Forms.Button();
            this.buttonHeThong = new System.Windows.Forms.Button();
            this.panelLOGO = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelNhanSu.SuspendLayout();
            this.panelSYSTEM.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChild
            // 
            this.panelChild.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.Untitled_3;
            this.panelChild.Controls.Add(this.label2);
            this.panelChild.Controls.Add(this.dataGridView2);
            this.panelChild.Controls.Add(this.groupBox2);
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(294, 46);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1206, 954);
            this.panelChild.TabIndex = 2;
            this.panelChild.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mix);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(360, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "DANH SÁCH NHÂN VIÊN ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(42, 572);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1131, 382);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.comboBoxPhongBan);
            this.groupBox2.Controls.Add(this.vbButton1);
            this.groupBox2.Controls.Add(this.textBoxMaNhanViẻn);
            this.groupBox2.Controls.Add(this.textBoxHovaTen);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(168, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 364);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // comboBoxPhongBan
            // 
            this.comboBoxPhongBan.FormattingEnabled = true;
            this.comboBoxPhongBan.Items.AddRange(new object[] {
            "Tài chính",
            "Kế toán",
            "Nhân sự",
            "Maketing"});
            this.comboBoxPhongBan.Location = new System.Drawing.Point(402, 138);
            this.comboBoxPhongBan.Name = "comboBoxPhongBan";
            this.comboBoxPhongBan.Size = new System.Drawing.Size(317, 33);
            this.comboBoxPhongBan.TabIndex = 9;
            this.comboBoxPhongBan.TextChanged += new System.EventHandler(this.vbButton1_Click);
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vbButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vbButton1.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.tim_kiem;
            this.vbButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 20;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(505, 263);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(88, 78);
            this.vbButton1.TabIndex = 8;
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
            // 
            // textBoxMaNhanViẻn
            // 
            this.textBoxMaNhanViẻn.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMaNhanViẻn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaNhanViẻn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaNhanViẻn.Location = new System.Drawing.Point(402, 201);
            this.textBoxMaNhanViẻn.Name = "textBoxMaNhanViẻn";
            this.textBoxMaNhanViẻn.Size = new System.Drawing.Size(317, 34);
            this.textBoxMaNhanViẻn.TabIndex = 7;
            this.textBoxMaNhanViẻn.TextChanged += new System.EventHandler(this.vbButton1_Click);
            // 
            // textBoxHovaTen
            // 
            this.textBoxHovaTen.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxHovaTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHovaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHovaTen.Location = new System.Drawing.Point(402, 75);
            this.textBoxHovaTen.Name = "textBoxHovaTen";
            this.textBoxHovaTen.Size = new System.Drawing.Size(317, 34);
            this.textBoxHovaTen.TabIndex = 5;
            this.textBoxHovaTen.TextChanged += new System.EventHandler(this.vbButton1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mã Nhân Viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Phòng Ban:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ và Tên:";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.Bck;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panelNhanSu);
            this.panel2.Controls.Add(this.buttonNhanSu);
            this.panel2.Controls.Add(this.panelSYSTEM);
            this.panel2.Controls.Add(this.buttonHeThong);
            this.panel2.Controls.Add(this.panelLOGO);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 954);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = global::Quản_Lý_Nhân_Sự.Properties.Resources.helpicon1;
            this.button2.Location = new System.Drawing.Point(0, 611);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 19, 0);
            this.button2.Size = new System.Drawing.Size(294, 91);
            this.button2.TabIndex = 6;
            this.button2.Text = "Trợ Giúp";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::Quản_Lý_Nhân_Sự.Properties.Resources.thongkeicon2;
            this.button1.Location = new System.Drawing.Point(0, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 91);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thống Kê";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelNhanSu
            // 
            this.panelNhanSu.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.Untitled_3;
            this.panelNhanSu.Controls.Add(this.buttonNhanVien);
            this.panelNhanSu.Controls.Add(this.buttonPhongban);
            this.panelNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNhanSu.Location = new System.Drawing.Point(0, 425);
            this.panelNhanSu.Name = "panelNhanSu";
            this.panelNhanSu.Size = new System.Drawing.Size(294, 95);
            this.panelNhanSu.TabIndex = 4;
            // 
            // buttonNhanVien
            // 
            this.buttonNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNhanVien.FlatAppearance.BorderSize = 0;
            this.buttonNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhanVien.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNhanVien.Location = new System.Drawing.Point(0, 50);
            this.buttonNhanVien.Name = "buttonNhanVien";
            this.buttonNhanVien.Size = new System.Drawing.Size(294, 40);
            this.buttonNhanVien.TabIndex = 1;
            this.buttonNhanVien.Text = "Nhân Sự";
            this.buttonNhanVien.UseVisualStyleBackColor = false;
            this.buttonNhanVien.Click += new System.EventHandler(this.buttonNhanVien_Click);
            // 
            // buttonPhongban
            // 
            this.buttonPhongban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonPhongban.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPhongban.FlatAppearance.BorderSize = 0;
            this.buttonPhongban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPhongban.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPhongban.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPhongban.Location = new System.Drawing.Point(0, 0);
            this.buttonPhongban.Name = "buttonPhongban";
            this.buttonPhongban.Size = new System.Drawing.Size(294, 50);
            this.buttonPhongban.TabIndex = 0;
            this.buttonPhongban.Text = "Phòng Ban";
            this.buttonPhongban.UseVisualStyleBackColor = false;
            this.buttonPhongban.Click += new System.EventHandler(this.buttonPhongban_Click);
            // 
            // buttonNhanSu
            // 
            this.buttonNhanSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNhanSu.FlatAppearance.BorderSize = 0;
            this.buttonNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNhanSu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhanSu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNhanSu.Image = global::Quản_Lý_Nhân_Sự.Properties.Resources.nhansu23;
            this.buttonNhanSu.Location = new System.Drawing.Point(0, 334);
            this.buttonNhanSu.Name = "buttonNhanSu";
            this.buttonNhanSu.Size = new System.Drawing.Size(294, 91);
            this.buttonNhanSu.TabIndex = 3;
            this.buttonNhanSu.Text = "Nhân Sự";
            this.buttonNhanSu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNhanSu.UseVisualStyleBackColor = false;
            this.buttonNhanSu.Click += new System.EventHandler(this.buttonNhanSu_Click);
            // 
            // panelSYSTEM
            // 
            this.panelSYSTEM.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.Untitled_3;
            this.panelSYSTEM.Controls.Add(this.buttonDangXuat);
            this.panelSYSTEM.Controls.Add(this.buttonQLTK);
            this.panelSYSTEM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSYSTEM.Location = new System.Drawing.Point(0, 234);
            this.panelSYSTEM.Name = "panelSYSTEM";
            this.panelSYSTEM.Size = new System.Drawing.Size(294, 100);
            this.panelSYSTEM.TabIndex = 2;
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDangXuat.FlatAppearance.BorderSize = 0;
            this.buttonDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangXuat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDangXuat.Location = new System.Drawing.Point(0, 50);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(294, 50);
            this.buttonDangXuat.TabIndex = 1;
            this.buttonDangXuat.Text = "Đăng Xuất";
            this.buttonDangXuat.UseVisualStyleBackColor = false;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // buttonQLTK
            // 
            this.buttonQLTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonQLTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonQLTK.FlatAppearance.BorderSize = 0;
            this.buttonQLTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQLTK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonQLTK.Location = new System.Drawing.Point(0, 0);
            this.buttonQLTK.Name = "buttonQLTK";
            this.buttonQLTK.Size = new System.Drawing.Size(294, 50);
            this.buttonQLTK.TabIndex = 0;
            this.buttonQLTK.Text = "Quản Lý Tài Khoản ";
            this.buttonQLTK.UseVisualStyleBackColor = false;
            this.buttonQLTK.Click += new System.EventHandler(this.buttonQLTK_Click);
            // 
            // buttonHeThong
            // 
            this.buttonHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHeThong.FlatAppearance.BorderSize = 0;
            this.buttonHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHeThong.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHeThong.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHeThong.Image = global::Quản_Lý_Nhân_Sự.Properties.Resources.SystEMisc;
            this.buttonHeThong.Location = new System.Drawing.Point(0, 143);
            this.buttonHeThong.Name = "buttonHeThong";
            this.buttonHeThong.Size = new System.Drawing.Size(294, 91);
            this.buttonHeThong.TabIndex = 1;
            this.buttonHeThong.Text = "Hệ Thống";
            this.buttonHeThong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHeThong.UseVisualStyleBackColor = false;
            this.buttonHeThong.Click += new System.EventHandler(this.buttonHeThong_Click);
            // 
            // panelLOGO
            // 
            this.panelLOGO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLOGO.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.logosau2;
            this.panelLOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLOGO.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLOGO.Location = new System.Drawing.Point(0, 0);
            this.panelLOGO.Name = "panelLOGO";
            this.panelLOGO.Size = new System.Drawing.Size(294, 143);
            this.panelLOGO.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.Untitled_2_01;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 46);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mix);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.tew;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(1272, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 46);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.restone;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(1348, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 46);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose.BackgroundImage = global::Quản_Lý_Nhân_Sự.Properties.Resources.tắt_copy;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonClose.Location = new System.Drawing.Point(1424, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(76, 46);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // GUIMain
            // 
            this.ClientSize = new System.Drawing.Size(1500, 1000);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mix);
            this.panelChild.ResumeLayout(false);
            this.panelChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelNhanSu.ResumeLayout(false);
            this.panelSYSTEM.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHeThomg;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuanlyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuanLy;
        private System.Windows.Forms.ToolStripMenuItem tsmiNhanvien;
        private System.Windows.Forms.ToolStripMenuItem tsmiPhongBan;
        private System.Windows.Forms.ToolStripMenuItem tsmiThongKe;
        private System.Windows.Forms.ToolStripMenuItem tsmiTroGiup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.ComboBox cbPhongBan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDangXuat;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmQuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem tsmDangXuat;
        private System.Windows.Forms.ToolStripMenuItem nhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmPhongBan;
        private System.Windows.Forms.ToolStripMenuItem tsmNhaSu;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Button lamMoi;
        private System.Windows.Forms.Button timKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelNhanSu;
        private System.Windows.Forms.Button buttonNhanVien;
        private System.Windows.Forms.Button buttonPhongban;
        private System.Windows.Forms.Button buttonNhanSu;
        private System.Windows.Forms.Panel panelSYSTEM;
        private System.Windows.Forms.Button buttonDangXuat;
        private System.Windows.Forms.Button buttonQLTK;
        private System.Windows.Forms.Button buttonHeThong;
        private System.Windows.Forms.Panel panelLOGO;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxPhongBan;
        private CustomButton.VBButton vbButton1;
        private System.Windows.Forms.TextBox textBoxMaNhanViẻn;
        private System.Windows.Forms.TextBox textBoxHovaTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonClose;
    }
}