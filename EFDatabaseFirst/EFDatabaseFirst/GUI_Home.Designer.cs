namespace GUI_QuanLy
{
    partial class GUI_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Home));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.paneldanhmuc = new System.Windows.Forms.Panel();
            this.lbdanhmuc = new System.Windows.Forms.Label();
            this.btndanhmuc = new System.Windows.Forms.PictureBox();
            this.panelQL = new System.Windows.Forms.Panel();
            this.panelnhanvien = new System.Windows.Forms.Panel();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.panelQLxe = new System.Windows.Forms.Panel();
            this.btnQLxe = new System.Windows.Forms.Button();
            this.panelquanly = new System.Windows.Forms.Panel();
            this.btntrangchu = new System.Windows.Forms.Button();
            this.panelQLkhach = new System.Windows.Forms.Panel();
            this.btnQLkhach = new System.Windows.Forms.Button();
            this.panelyeucau = new System.Windows.Forms.Panel();
            this.btnyeucau = new System.Windows.Forms.Button();
            this.panelthuchi = new System.Windows.Forms.Panel();
            this.btnthuchi = new System.Windows.Forms.Button();
            this.panelbaocao = new System.Windows.Forms.Panel();
            this.btnbaocao = new System.Windows.Forms.Button();
            this.panelthoat = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.panelcoder = new System.Windows.Forms.Panel();
            this.lbcoder = new System.Windows.Forms.Label();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panelmain = new System.Windows.Forms.Panel();
            this.panelQLTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.paneldanhmuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btndanhmuc)).BeginInit();
            this.panelQL.SuspendLayout();
            this.panelnhanvien.SuspendLayout();
            this.panelQLxe.SuspendLayout();
            this.panelquanly.SuspendLayout();
            this.panelQLkhach.SuspendLayout();
            this.panelyeucau.SuspendLayout();
            this.panelthuchi.SuspendLayout();
            this.panelbaocao.SuspendLayout();
            this.panelthoat.SuspendLayout();
            this.panelcoder.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.paneldanhmuc);
            this.sidebar.Controls.Add(this.panelQL);
            this.sidebar.Controls.Add(this.panelyeucau);
            this.sidebar.Controls.Add(this.panelthuchi);
            this.sidebar.Controls.Add(this.panelbaocao);
            this.sidebar.Controls.Add(this.panelthoat);
            this.sidebar.Controls.Add(this.panelcoder);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar.MaximumSize = new System.Drawing.Size(259, 746);
            this.sidebar.MinimumSize = new System.Drawing.Size(79, 577);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(259, 699);
            this.sidebar.TabIndex = 0;
            // 
            // paneldanhmuc
            // 
            this.paneldanhmuc.Controls.Add(this.lbdanhmuc);
            this.paneldanhmuc.Controls.Add(this.btndanhmuc);
            this.paneldanhmuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paneldanhmuc.Location = new System.Drawing.Point(3, 2);
            this.paneldanhmuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneldanhmuc.Name = "paneldanhmuc";
            this.paneldanhmuc.Size = new System.Drawing.Size(256, 117);
            this.paneldanhmuc.TabIndex = 0;
            // 
            // lbdanhmuc
            // 
            this.lbdanhmuc.AutoSize = true;
            this.lbdanhmuc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdanhmuc.ForeColor = System.Drawing.Color.White;
            this.lbdanhmuc.Location = new System.Drawing.Point(76, 46);
            this.lbdanhmuc.Name = "lbdanhmuc";
            this.lbdanhmuc.Size = new System.Drawing.Size(123, 31);
            this.lbdanhmuc.TabIndex = 1;
            this.lbdanhmuc.Text = "Danh mục";
            this.lbdanhmuc.Click += new System.EventHandler(this.label1_Click);
            // 
            // btndanhmuc
            // 
            this.btndanhmuc.ErrorImage = null;
            this.btndanhmuc.Image = global::EFDatabaseFirst.Properties.Resources.interface__1_;
            this.btndanhmuc.InitialImage = null;
            this.btndanhmuc.Location = new System.Drawing.Point(12, 46);
            this.btndanhmuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndanhmuc.Name = "btndanhmuc";
            this.btndanhmuc.Size = new System.Drawing.Size(47, 32);
            this.btndanhmuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btndanhmuc.TabIndex = 0;
            this.btndanhmuc.TabStop = false;
            this.btndanhmuc.Click += new System.EventHandler(this.btndanhmuc_Click);
            // 
            // panelQL
            // 
            this.panelQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelQL.Controls.Add(this.panelnhanvien);
            this.panelQL.Controls.Add(this.panelQLxe);
            this.panelQL.Controls.Add(this.panelquanly);
            this.panelQL.Controls.Add(this.panelQLkhach);
            this.panelQL.Location = new System.Drawing.Point(3, 123);
            this.panelQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelQL.MaximumSize = new System.Drawing.Size(256, 210);
            this.panelQL.MinimumSize = new System.Drawing.Size(240, 50);
            this.panelQL.Name = "panelQL";
            this.panelQL.Size = new System.Drawing.Size(256, 210);
            this.panelQL.TabIndex = 8;
            // 
            // panelnhanvien
            // 
            this.panelnhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.panelnhanvien.Controls.Add(this.btnnhanvien);
            this.panelnhanvien.Location = new System.Drawing.Point(-5, 153);
            this.panelnhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelnhanvien.Name = "panelnhanvien";
            this.panelnhanvien.Size = new System.Drawing.Size(269, 54);
            this.panelnhanvien.TabIndex = 4;
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnhanvien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhanvien.ForeColor = System.Drawing.Color.White;
            this.btnnhanvien.Image = global::EFDatabaseFirst.Properties.Resources.employees;
            this.btnnhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhanvien.Location = new System.Drawing.Point(0, -4);
            this.btnnhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btnnhanvien.Size = new System.Drawing.Size(261, 65);
            this.btnnhanvien.TabIndex = 2;
            this.btnnhanvien.Text = "         Nhân viên";
            this.btnnhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhanvien.UseVisualStyleBackColor = true;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // panelQLxe
            // 
            this.panelQLxe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.panelQLxe.Controls.Add(this.btnQLxe);
            this.panelQLxe.Location = new System.Drawing.Point(-3, 52);
            this.panelQLxe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelQLxe.Name = "panelQLxe";
            this.panelQLxe.Size = new System.Drawing.Size(259, 50);
            this.panelQLxe.TabIndex = 2;
            // 
            // btnQLxe
            // 
            this.btnQLxe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLxe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLxe.ForeColor = System.Drawing.Color.White;
            this.btnQLxe.Image = global::EFDatabaseFirst.Properties.Resources.transport;
            this.btnQLxe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLxe.Location = new System.Drawing.Point(-3, -4);
            this.btnQLxe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLxe.Name = "btnQLxe";
            this.btnQLxe.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btnQLxe.Size = new System.Drawing.Size(261, 65);
            this.btnQLxe.TabIndex = 2;
            this.btnQLxe.Text = "         Danh sách xe";
            this.btnQLxe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLxe.UseVisualStyleBackColor = true;
            this.btnQLxe.Click += new System.EventHandler(this.btnQLxe_Click);
            // 
            // panelquanly
            // 
            this.panelquanly.Controls.Add(this.btntrangchu);
            this.panelquanly.Location = new System.Drawing.Point(1, 0);
            this.panelquanly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelquanly.Name = "panelquanly";
            this.panelquanly.Size = new System.Drawing.Size(256, 50);
            this.panelquanly.TabIndex = 1;
            // 
            // btntrangchu
            // 
            this.btntrangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntrangchu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrangchu.ForeColor = System.Drawing.Color.White;
            this.btntrangchu.Image = global::EFDatabaseFirst.Properties.Resources.home__1_;
            this.btntrangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntrangchu.Location = new System.Drawing.Point(-17, -7);
            this.btntrangchu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntrangchu.Name = "btntrangchu";
            this.btntrangchu.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btntrangchu.Size = new System.Drawing.Size(275, 65);
            this.btntrangchu.TabIndex = 2;
            this.btntrangchu.Text = "          Quản lý";
            this.btntrangchu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntrangchu.UseVisualStyleBackColor = true;
            this.btntrangchu.Click += new System.EventHandler(this.btntrangchu_Click);
            // 
            // panelQLkhach
            // 
            this.panelQLkhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.panelQLkhach.Controls.Add(this.btnQLkhach);
            this.panelQLkhach.Location = new System.Drawing.Point(-5, 102);
            this.panelQLkhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelQLkhach.Name = "panelQLkhach";
            this.panelQLkhach.Size = new System.Drawing.Size(269, 54);
            this.panelQLkhach.TabIndex = 3;
            // 
            // btnQLkhach
            // 
            this.btnQLkhach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLkhach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLkhach.ForeColor = System.Drawing.Color.White;
            this.btnQLkhach.Image = global::EFDatabaseFirst.Properties.Resources.user;
            this.btnQLkhach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLkhach.Location = new System.Drawing.Point(0, -4);
            this.btnQLkhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLkhach.Name = "btnQLkhach";
            this.btnQLkhach.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btnQLkhach.Size = new System.Drawing.Size(261, 65);
            this.btnQLkhach.TabIndex = 2;
            this.btnQLkhach.Text = "         Khách hàng";
            this.btnQLkhach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLkhach.UseVisualStyleBackColor = true;
            this.btnQLkhach.Click += new System.EventHandler(this.btnQLkhach_Click);
            // 
            // panelyeucau
            // 
            this.panelyeucau.Controls.Add(this.btnyeucau);
            this.panelyeucau.Location = new System.Drawing.Point(3, 337);
            this.panelyeucau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelyeucau.Name = "panelyeucau";
            this.panelyeucau.Size = new System.Drawing.Size(263, 50);
            this.panelyeucau.TabIndex = 6;
            // 
            // btnyeucau
            // 
            this.btnyeucau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyeucau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyeucau.ForeColor = System.Drawing.Color.White;
            this.btnyeucau.Image = global::EFDatabaseFirst.Properties.Resources.key;
            this.btnyeucau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyeucau.Location = new System.Drawing.Point(-19, -4);
            this.btnyeucau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnyeucau.Name = "btnyeucau";
            this.btnyeucau.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btnyeucau.Size = new System.Drawing.Size(283, 65);
            this.btnyeucau.TabIndex = 2;
            this.btnyeucau.Text = "          Yêu cầu";
            this.btnyeucau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyeucau.UseVisualStyleBackColor = true;
            // 
            // panelthuchi
            // 
            this.panelthuchi.Controls.Add(this.btnthuchi);
            this.panelthuchi.Location = new System.Drawing.Point(3, 391);
            this.panelthuchi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelthuchi.Name = "panelthuchi";
            this.panelthuchi.Size = new System.Drawing.Size(256, 50);
            this.panelthuchi.TabIndex = 4;
            // 
            // btnthuchi
            // 
            this.btnthuchi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthuchi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthuchi.ForeColor = System.Drawing.Color.White;
            this.btnthuchi.Image = global::EFDatabaseFirst.Properties.Resources.invoice;
            this.btnthuchi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthuchi.Location = new System.Drawing.Point(-19, -4);
            this.btnthuchi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthuchi.Name = "btnthuchi";
            this.btnthuchi.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btnthuchi.Size = new System.Drawing.Size(281, 65);
            this.btnthuchi.TabIndex = 2;
            this.btnthuchi.Text = "          Phiếu thu chi";
            this.btnthuchi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthuchi.UseVisualStyleBackColor = true;
            // 
            // panelbaocao
            // 
            this.panelbaocao.Controls.Add(this.btnbaocao);
            this.panelbaocao.Location = new System.Drawing.Point(3, 445);
            this.panelbaocao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelbaocao.Name = "panelbaocao";
            this.panelbaocao.Size = new System.Drawing.Size(263, 50);
            this.panelbaocao.TabIndex = 7;
            // 
            // btnbaocao
            // 
            this.btnbaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbaocao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbaocao.ForeColor = System.Drawing.Color.White;
            this.btnbaocao.Image = global::EFDatabaseFirst.Properties.Resources.report;
            this.btnbaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbaocao.Location = new System.Drawing.Point(-19, -4);
            this.btnbaocao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btnbaocao.Size = new System.Drawing.Size(283, 65);
            this.btnbaocao.TabIndex = 2;
            this.btnbaocao.Text = "          Báo cáo";
            this.btnbaocao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbaocao.UseVisualStyleBackColor = true;
            // 
            // panelthoat
            // 
            this.panelthoat.Controls.Add(this.btnthoat);
            this.panelthoat.Location = new System.Drawing.Point(3, 499);
            this.panelthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelthoat.Name = "panelthoat";
            this.panelthoat.Size = new System.Drawing.Size(263, 50);
            this.panelthoat.TabIndex = 5;
            // 
            // btnthoat
            // 
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.White;
            this.btnthoat.Image = global::EFDatabaseFirst.Properties.Resources._switch;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(-19, -4);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btnthoat.Size = new System.Drawing.Size(283, 65);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "          Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // panelcoder
            // 
            this.panelcoder.Controls.Add(this.lbcoder);
            this.panelcoder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcoder.Location = new System.Drawing.Point(3, 553);
            this.panelcoder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelcoder.Name = "panelcoder";
            this.panelcoder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelcoder.Size = new System.Drawing.Size(263, 127);
            this.panelcoder.TabIndex = 7;
            // 
            // lbcoder
            // 
            this.lbcoder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbcoder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbcoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcoder.ForeColor = System.Drawing.Color.White;
            this.lbcoder.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbcoder.Location = new System.Drawing.Point(-13, 86);
            this.lbcoder.Name = "lbcoder";
            this.lbcoder.Size = new System.Drawing.Size(271, 47);
            this.lbcoder.TabIndex = 6;
            this.lbcoder.Text = "Design by Nguyễn Cảnh Bảo\r\n                 Lâm Thị Diễm My";
            this.lbcoder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panelmain
            // 
            this.panelmain.BackColor = System.Drawing.Color.Transparent;
            this.panelmain.Location = new System.Drawing.Point(265, 71);
            this.panelmain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelmain.MaximumSize = new System.Drawing.Size(1445, 628);
            this.panelmain.MinimumSize = new System.Drawing.Size(1267, 628);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1267, 628);
            this.panelmain.TabIndex = 1;
            // 
            // panelQLTimer
            // 
            this.panelQLTimer.Interval = 10;
            this.panelQLTimer.Tick += new System.EventHandler(this.panelQLTimer_Tick);
            // 
            // GUI_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 699);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUI_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý cho thuê xe";
            this.sidebar.ResumeLayout(false);
            this.paneldanhmuc.ResumeLayout(false);
            this.paneldanhmuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btndanhmuc)).EndInit();
            this.panelQL.ResumeLayout(false);
            this.panelnhanvien.ResumeLayout(false);
            this.panelQLxe.ResumeLayout(false);
            this.panelquanly.ResumeLayout(false);
            this.panelQLkhach.ResumeLayout(false);
            this.panelyeucau.ResumeLayout(false);
            this.panelthuchi.ResumeLayout(false);
            this.panelbaocao.ResumeLayout(false);
            this.panelthoat.ResumeLayout(false);
            this.panelcoder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel paneldanhmuc;
        private System.Windows.Forms.Panel panelquanly;
        private System.Windows.Forms.Button btntrangchu;
        private System.Windows.Forms.Panel panelQLxe;
        private System.Windows.Forms.Button btnQLxe;
        private System.Windows.Forms.Panel panelQLkhach;
        private System.Windows.Forms.Button btnQLkhach;
        private System.Windows.Forms.Button btnthuchi;
        private System.Windows.Forms.PictureBox btndanhmuc;
        private System.Windows.Forms.Label lbdanhmuc;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panelthoat;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Panel panelcoder;
        private System.Windows.Forms.Label lbcoder;
        private System.Windows.Forms.Panel panelQL;
        private System.Windows.Forms.Timer panelQLTimer;
        private System.Windows.Forms.Panel panelthuchi;
        private System.Windows.Forms.Timer hoverQLTimer;
        private System.Windows.Forms.Panel panelyeucau;
        private System.Windows.Forms.Button btnyeucau;
        private System.Windows.Forms.Panel panelnhanvien;
        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Panel panelbaocao;
        private System.Windows.Forms.Button btnbaocao;
    }
}