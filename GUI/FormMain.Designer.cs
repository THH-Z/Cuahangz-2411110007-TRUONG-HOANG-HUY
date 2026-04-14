namespace GUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.paneltop = new System.Windows.Forms.Panel();
            this.txttenacc = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btndangxuat = new System.Windows.Forms.Button();
            this.lblcuahangz = new System.Windows.Forms.Label();
            this.panelleft = new System.Windows.Forms.Panel();
            this.llblChitietdonhang = new System.Windows.Forms.LinkLabel();
            this.llblhoadon = new System.Windows.Forms.LinkLabel();
            this.llblkhachhang = new System.Windows.Forms.LinkLabel();
            this.llblnhanvien = new System.Windows.Forms.LinkLabel();
            this.llblsanpham = new System.Windows.Forms.LinkLabel();
            this.panelmain = new System.Windows.Forms.Panel();
            this.panelchinh = new System.Windows.Forms.Panel();
            this.paneltop.SuspendLayout();
            this.panelleft.SuspendLayout();
            this.panelmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.Cyan;
            this.paneltop.Controls.Add(this.txttenacc);
            this.paneltop.Controls.Add(this.btnthoat);
            this.paneltop.Controls.Add(this.btndangxuat);
            this.paneltop.Controls.Add(this.lblcuahangz);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1098, 89);
            this.paneltop.TabIndex = 0;
            this.paneltop.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltop_Paint);
            // 
            // txttenacc
            // 
            this.txttenacc.BackColor = System.Drawing.Color.Cyan;
            this.txttenacc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttenacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenacc.Location = new System.Drawing.Point(3, 3);
            this.txttenacc.Name = "txttenacc";
            this.txttenacc.Size = new System.Drawing.Size(100, 22);
            this.txttenacc.TabIndex = 4;
            this.txttenacc.TextChanged += new System.EventHandler(this.txttenacc_TextChanged);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(990, 32);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(96, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btndangxuat
            // 
            this.btndangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangxuat.Location = new System.Drawing.Point(990, 3);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(96, 23);
            this.btndangxuat.TabIndex = 2;
            this.btndangxuat.Text = "ĐĂNG XUẤT";
            this.btndangxuat.UseVisualStyleBackColor = true;
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // lblcuahangz
            // 
            this.lblcuahangz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuahangz.Location = new System.Drawing.Point(290, 32);
            this.lblcuahangz.Name = "lblcuahangz";
            this.lblcuahangz.Size = new System.Drawing.Size(519, 23);
            this.lblcuahangz.TabIndex = 0;
            this.lblcuahangz.Text = "QUẢN LÝ CỬA HÀNG";
            this.lblcuahangz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcuahangz.Click += new System.EventHandler(this.lblcuahangz_Click);
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelleft.Controls.Add(this.llblChitietdonhang);
            this.panelleft.Controls.Add(this.llblhoadon);
            this.panelleft.Controls.Add(this.llblkhachhang);
            this.panelleft.Controls.Add(this.llblnhanvien);
            this.panelleft.Controls.Add(this.llblsanpham);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 89);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(200, 562);
            this.panelleft.TabIndex = 1;
            // 
            // llblChitietdonhang
            // 
            this.llblChitietdonhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblChitietdonhang.Location = new System.Drawing.Point(13, 148);
            this.llblChitietdonhang.Name = "llblChitietdonhang";
            this.llblChitietdonhang.Size = new System.Drawing.Size(167, 23);
            this.llblChitietdonhang.TabIndex = 5;
            this.llblChitietdonhang.TabStop = true;
            this.llblChitietdonhang.Text = "5. Chi Tiết Hoá Đơn";
            this.llblChitietdonhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llblChitietdonhang.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblChitietdonhang_LinkClicked);
            // 
            // llblhoadon
            // 
            this.llblhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblhoadon.Location = new System.Drawing.Point(13, 119);
            this.llblhoadon.Name = "llblhoadon";
            this.llblhoadon.Size = new System.Drawing.Size(167, 23);
            this.llblhoadon.TabIndex = 3;
            this.llblhoadon.TabStop = true;
            this.llblhoadon.Text = "4. Hoá Đơn";
            this.llblhoadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llblhoadon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblhoadon_LinkClicked);
            // 
            // llblkhachhang
            // 
            this.llblkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblkhachhang.Location = new System.Drawing.Point(13, 32);
            this.llblkhachhang.Name = "llblkhachhang";
            this.llblkhachhang.Size = new System.Drawing.Size(167, 23);
            this.llblkhachhang.TabIndex = 2;
            this.llblkhachhang.TabStop = true;
            this.llblkhachhang.Text = "1. Khách Hàng";
            this.llblkhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llblkhachhang.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblkhachhang_LinkClicked);
            // 
            // llblnhanvien
            // 
            this.llblnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblnhanvien.Location = new System.Drawing.Point(12, 61);
            this.llblnhanvien.Name = "llblnhanvien";
            this.llblnhanvien.Size = new System.Drawing.Size(167, 23);
            this.llblnhanvien.TabIndex = 1;
            this.llblnhanvien.TabStop = true;
            this.llblnhanvien.Text = "2. Nhân viên";
            this.llblnhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llblnhanvien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblnhanvien_LinkClicked);
            // 
            // llblsanpham
            // 
            this.llblsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblsanpham.Location = new System.Drawing.Point(12, 90);
            this.llblsanpham.Name = "llblsanpham";
            this.llblsanpham.Size = new System.Drawing.Size(167, 23);
            this.llblsanpham.TabIndex = 0;
            this.llblsanpham.TabStop = true;
            this.llblsanpham.Text = "3. Sản Phẩm";
            this.llblsanpham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llblsanpham.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblsanpham_LinkClicked);
            // 
            // panelmain
            // 
            this.panelmain.Controls.Add(this.panelchinh);
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(200, 89);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(898, 562);
            this.panelmain.TabIndex = 2;
            // 
            // panelchinh
            // 
            this.panelchinh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelchinh.BackgroundImage")));
            this.panelchinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchinh.Location = new System.Drawing.Point(0, 0);
            this.panelchinh.Name = "panelchinh";
            this.panelchinh.Size = new System.Drawing.Size(898, 562);
            this.panelchinh.TabIndex = 7;
            this.panelchinh.Paint += new System.Windows.Forms.PaintEventHandler(this.panelchinh_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 651);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quảng Lý Cửa Hàng";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.panelleft.ResumeLayout(false);
            this.panelmain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Label lblcuahangz;
        private System.Windows.Forms.Button btndangxuat;
        private System.Windows.Forms.LinkLabel llblsanpham;
        private System.Windows.Forms.LinkLabel llblkhachhang;
        private System.Windows.Forms.LinkLabel llblnhanvien;
        private System.Windows.Forms.LinkLabel llblhoadon;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.LinkLabel llblChitietdonhang;
        private System.Windows.Forms.TextBox txttenacc;
        private System.Windows.Forms.Panel panelchinh;
    }
}

