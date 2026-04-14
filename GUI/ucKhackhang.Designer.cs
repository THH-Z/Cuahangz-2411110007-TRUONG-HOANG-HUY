namespace GUI
{
    partial class ucKhackhang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtmakhachhang = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txttenkhachhang = new System.Windows.Forms.TextBox();
            this.lblmakhachhang = new System.Windows.Forms.Label();
            this.lbltenKhachHang = new System.Windows.Forms.Label();
            this.lbldiemthoai = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(370, 10);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(161, 25);
            this.lblKhachHang.TabIndex = 0;
            this.lblKhachHang.Text = "KHÁCH HÀNG";
            this.lblKhachHang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblKhachHang.Click += new System.EventHandler(this.lblKhachHang_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(553, 170);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(645, 170);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(738, 170);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 331);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtmakhachhang
            // 
            this.txtmakhachhang.Location = new System.Drawing.Point(152, 46);
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new System.Drawing.Size(195, 20);
            this.txtmakhachhang.TabIndex = 5;
            this.txtmakhachhang.TextChanged += new System.EventHandler(this.txtmakhachhang_TextChanged);
            this.txtmakhachhang.Leave += new System.EventHandler(this.txtmakhachhang_leave);
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(152, 175);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(195, 20);
            this.txtdienthoai.TabIndex = 6;
            this.txtdienthoai.TextChanged += new System.EventHandler(this.txtdienthoai_TextChanged);
            // 
            // txttenkhachhang
            // 
            this.txttenkhachhang.Location = new System.Drawing.Point(152, 105);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.Size = new System.Drawing.Size(195, 20);
            this.txttenkhachhang.TabIndex = 7;
            this.txttenkhachhang.TextChanged += new System.EventHandler(this.txttenkhachhang_TextChanged);
            // 
            // lblmakhachhang
            // 
            this.lblmakhachhang.AutoSize = true;
            this.lblmakhachhang.Location = new System.Drawing.Point(55, 53);
            this.lblmakhachhang.Name = "lblmakhachhang";
            this.lblmakhachhang.Size = new System.Drawing.Size(85, 13);
            this.lblmakhachhang.TabIndex = 8;
            this.lblmakhachhang.Text = "Mã Khách Hàng";
            // 
            // lbltenKhachHang
            // 
            this.lbltenKhachHang.AutoSize = true;
            this.lbltenKhachHang.Location = new System.Drawing.Point(55, 114);
            this.lbltenKhachHang.Name = "lbltenKhachHang";
            this.lbltenKhachHang.Size = new System.Drawing.Size(89, 13);
            this.lbltenKhachHang.TabIndex = 9;
            this.lbltenKhachHang.Text = "Tên Khách Hàng";
            // 
            // lbldiemthoai
            // 
            this.lbldiemthoai.AutoSize = true;
            this.lbldiemthoai.Location = new System.Drawing.Point(55, 175);
            this.lbldiemthoai.Name = "lbldiemthoai";
            this.lbldiemthoai.Size = new System.Drawing.Size(59, 13);
            this.lbldiemthoai.TabIndex = 10;
            this.lbldiemthoai.Text = "Điện Thoại";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(353, 46);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 11;
            this.btntimkiem.Text = "Tìm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // ucKhackhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.lbldiemthoai);
            this.Controls.Add(this.lbltenKhachHang);
            this.Controls.Add(this.lblmakhachhang);
            this.Controls.Add(this.txttenkhachhang);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.txtmakhachhang);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.lblKhachHang);
            this.Name = "ucKhackhang";
            this.Size = new System.Drawing.Size(898, 562);
            this.Load += new System.EventHandler(this.ucKhackhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmakhachhang;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txttenkhachhang;
        private System.Windows.Forms.Label lblmakhachhang;
        private System.Windows.Forms.Label lbltenKhachHang;
        private System.Windows.Forms.Label lbldiemthoai;
        private System.Windows.Forms.Button btntimkiem;
    }
}
