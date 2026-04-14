namespace GUI
{
    partial class ucDonHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtmakhachhang = new System.Windows.Forms.TextBox();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.txtmadonhang = new System.Windows.Forms.TextBox();
            this.lblmanhanvien = new System.Windows.Forms.Label();
            this.lblmakhachhang = new System.Windows.Forms.Label();
            this.lblNgaytao = new System.Windows.Forms.Label();
            this.lblmaDonhang = new System.Windows.Forms.Label();
            this.lblDonhang = new System.Windows.Forms.Label();
            this.chonngaytao = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 331);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(703, 181);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(597, 181);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(490, 181);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 22;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtmakhachhang
            // 
            this.txtmakhachhang.Location = new System.Drawing.Point(126, 131);
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new System.Drawing.Size(181, 20);
            this.txtmakhachhang.TabIndex = 20;
            this.txtmakhachhang.TextChanged += new System.EventHandler(this.txtmakhachhang_TextChanged);
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(126, 174);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(181, 20);
            this.txtmanhanvien.TabIndex = 19;
            this.txtmanhanvien.TextChanged += new System.EventHandler(this.txtmanhanvien_TextChanged);
            // 
            // txtmadonhang
            // 
            this.txtmadonhang.Location = new System.Drawing.Point(126, 45);
            this.txtmadonhang.Name = "txtmadonhang";
            this.txtmadonhang.Size = new System.Drawing.Size(181, 20);
            this.txtmadonhang.TabIndex = 18;
            this.txtmadonhang.TextChanged += new System.EventHandler(this.txtmadonhang_leave);
            this.txtmadonhang.Leave += new System.EventHandler(this.txtmadonhang_leave);
            // 
            // lblmanhanvien
            // 
            this.lblmanhanvien.AutoSize = true;
            this.lblmanhanvien.Location = new System.Drawing.Point(37, 181);
            this.lblmanhanvien.Name = "lblmanhanvien";
            this.lblmanhanvien.Size = new System.Drawing.Size(75, 13);
            this.lblmanhanvien.TabIndex = 17;
            this.lblmanhanvien.Text = "Mã Nhân Viên";
            // 
            // lblmakhachhang
            // 
            this.lblmakhachhang.AutoSize = true;
            this.lblmakhachhang.Location = new System.Drawing.Point(34, 138);
            this.lblmakhachhang.Name = "lblmakhachhang";
            this.lblmakhachhang.Size = new System.Drawing.Size(85, 13);
            this.lblmakhachhang.TabIndex = 16;
            this.lblmakhachhang.Text = "Mã Khách Hàng";
            // 
            // lblNgaytao
            // 
            this.lblNgaytao.AutoSize = true;
            this.lblNgaytao.Location = new System.Drawing.Point(34, 95);
            this.lblNgaytao.Name = "lblNgaytao";
            this.lblNgaytao.Size = new System.Drawing.Size(54, 13);
            this.lblNgaytao.TabIndex = 15;
            this.lblNgaytao.Text = "Ngày Tạo";
            // 
            // lblmaDonhang
            // 
            this.lblmaDonhang.AutoSize = true;
            this.lblmaDonhang.Location = new System.Drawing.Point(38, 52);
            this.lblmaDonhang.Name = "lblmaDonhang";
            this.lblmaDonhang.Size = new System.Drawing.Size(74, 13);
            this.lblmaDonhang.TabIndex = 14;
            this.lblmaDonhang.Text = "Mã Đơn Hàng";
            // 
            // lblDonhang
            // 
            this.lblDonhang.AutoSize = true;
            this.lblDonhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonhang.Location = new System.Drawing.Point(370, 12);
            this.lblDonhang.Name = "lblDonhang";
            this.lblDonhang.Size = new System.Drawing.Size(132, 25);
            this.lblDonhang.TabIndex = 13;
            this.lblDonhang.Text = "ĐƠN HÀNG";
            // 
            // chonngaytao
            // 
            this.chonngaytao.Location = new System.Drawing.Point(126, 94);
            this.chonngaytao.Name = "chonngaytao";
            this.chonngaytao.Size = new System.Drawing.Size(200, 20);
            this.chonngaytao.TabIndex = 25;
            this.chonngaytao.ValueChanged += new System.EventHandler(this.chonngaytao_ValueChanged);
            // 
            // ucDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chonngaytao);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txtmakhachhang);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.txtmadonhang);
            this.Controls.Add(this.lblmanhanvien);
            this.Controls.Add(this.lblmakhachhang);
            this.Controls.Add(this.lblNgaytao);
            this.Controls.Add(this.lblmaDonhang);
            this.Controls.Add(this.lblDonhang);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ucDonHang";
            this.Size = new System.Drawing.Size(898, 562);
            this.Load += new System.EventHandler(this.ucDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtmakhachhang;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.TextBox txtmadonhang;
        private System.Windows.Forms.Label lblmanhanvien;
        private System.Windows.Forms.Label lblmakhachhang;
        private System.Windows.Forms.Label lblNgaytao;
        private System.Windows.Forms.Label lblmaDonhang;
        private System.Windows.Forms.Label lblDonhang;
        private System.Windows.Forms.DateTimePicker chonngaytao;
    }
}
