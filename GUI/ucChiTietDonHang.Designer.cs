namespace GUI
{
    partial class ucChiTietDonHang
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
            this.btnSua = new System.Windows.Forms.Button();
            this.txtmasanpham = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtmadonhang = new System.Windows.Forms.TextBox();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.lblmaSanPham = new System.Windows.Forms.Label();
            this.lblmaDonhang = new System.Windows.Forms.Label();
            this.lblChiTietDonhang = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(717, 175);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtmasanpham
            // 
            this.txtmasanpham.Location = new System.Drawing.Point(128, 82);
            this.txtmasanpham.Name = "txtmasanpham";
            this.txtmasanpham.Size = new System.Drawing.Size(181, 20);
            this.txtmasanpham.TabIndex = 34;
            this.txtmasanpham.TextChanged += new System.EventHandler(this.txtmasanpham_TextChanged);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(128, 125);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(181, 20);
            this.txtsoluong.TabIndex = 33;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            // 
            // txtmadonhang
            // 
            this.txtmadonhang.Location = new System.Drawing.Point(128, 39);
            this.txtmadonhang.Name = "txtmadonhang";
            this.txtmadonhang.Size = new System.Drawing.Size(181, 20);
            this.txtmadonhang.TabIndex = 31;
            this.txtmadonhang.TextChanged += new System.EventHandler(this.txtmadonhang_leave);
            this.txtmadonhang.Leave += new System.EventHandler(this.txtmadonhang_leave);
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Location = new System.Drawing.Point(36, 132);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(53, 13);
            this.lblsoluong.TabIndex = 29;
            this.lblsoluong.Text = "Số Lượng";
            // 
            // lblmaSanPham
            // 
            this.lblmaSanPham.AutoSize = true;
            this.lblmaSanPham.Location = new System.Drawing.Point(36, 89);
            this.lblmaSanPham.Name = "lblmaSanPham";
            this.lblmaSanPham.Size = new System.Drawing.Size(74, 13);
            this.lblmaSanPham.TabIndex = 28;
            this.lblmaSanPham.Text = "Mã Sản Phẩm";
            // 
            // lblmaDonhang
            // 
            this.lblmaDonhang.AutoSize = true;
            this.lblmaDonhang.Location = new System.Drawing.Point(40, 46);
            this.lblmaDonhang.Name = "lblmaDonhang";
            this.lblmaDonhang.Size = new System.Drawing.Size(74, 13);
            this.lblmaDonhang.TabIndex = 27;
            this.lblmaDonhang.Text = "Mã Đơn Hàng";
            // 
            // lblChiTietDonhang
            // 
            this.lblChiTietDonhang.AutoSize = true;
            this.lblChiTietDonhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietDonhang.Location = new System.Drawing.Point(372, 6);
            this.lblChiTietDonhang.Name = "lblChiTietDonhang";
            this.lblChiTietDonhang.Size = new System.Drawing.Size(233, 25);
            this.lblChiTietDonhang.TabIndex = 26;
            this.lblChiTietDonhang.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 331);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(624, 175);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(517, 175);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 38;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // ucChiTietDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtmasanpham);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtmadonhang);
            this.Controls.Add(this.lblsoluong);
            this.Controls.Add(this.lblmaSanPham);
            this.Controls.Add(this.lblmaDonhang);
            this.Controls.Add(this.lblChiTietDonhang);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ucChiTietDonHang";
            this.Size = new System.Drawing.Size(898, 562);
            this.Load += new System.EventHandler(this.ucChiTietDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtmasanpham;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtmadonhang;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label lblmaSanPham;
        private System.Windows.Forms.Label lblmaDonhang;
        private System.Windows.Forms.Label lblChiTietDonhang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnxoa;
    }
}
