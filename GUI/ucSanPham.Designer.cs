namespace GUI
{
    partial class ucSanPham
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
            this.lblSanPham = new System.Windows.Forms.Label();
            this.lblmasanpham = new System.Windows.Forms.Label();
            this.lblTensanpham = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.lblgia = new System.Windows.Forms.Label();
            this.txtmasanpham = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtsoluongsanpham = new System.Windows.Forms.TextBox();
            this.txttensanpham = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
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
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanPham.Location = new System.Drawing.Point(387, 17);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(130, 25);
            this.lblSanPham.TabIndex = 1;
            this.lblSanPham.Text = "SẢN PHẨM";
            // 
            // lblmasanpham
            // 
            this.lblmasanpham.AutoSize = true;
            this.lblmasanpham.Location = new System.Drawing.Point(55, 57);
            this.lblmasanpham.Name = "lblmasanpham";
            this.lblmasanpham.Size = new System.Drawing.Size(74, 13);
            this.lblmasanpham.TabIndex = 2;
            this.lblmasanpham.Text = "Mã Sản Phẩm";
            this.lblmasanpham.Click += new System.EventHandler(this.lblmasanpham_Click);
            // 
            // lblTensanpham
            // 
            this.lblTensanpham.AutoSize = true;
            this.lblTensanpham.Location = new System.Drawing.Point(51, 100);
            this.lblTensanpham.Name = "lblTensanpham";
            this.lblTensanpham.Size = new System.Drawing.Size(78, 13);
            this.lblTensanpham.TabIndex = 3;
            this.lblTensanpham.Text = "Tên Sản Phẩm";
            this.lblTensanpham.Click += new System.EventHandler(this.lblTensanpham_Click);
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Location = new System.Drawing.Point(58, 143);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(53, 13);
            this.lblsoluong.TabIndex = 4;
            this.lblsoluong.Text = "Số Lượng";
            this.lblsoluong.Click += new System.EventHandler(this.lblsoluong_Click);
            // 
            // lblgia
            // 
            this.lblgia.AutoSize = true;
            this.lblgia.Location = new System.Drawing.Point(68, 186);
            this.lblgia.Name = "lblgia";
            this.lblgia.Size = new System.Drawing.Size(23, 13);
            this.lblgia.TabIndex = 5;
            this.lblgia.Text = "Giá";
            this.lblgia.Click += new System.EventHandler(this.lblgia_Click);
            // 
            // txtmasanpham
            // 
            this.txtmasanpham.Location = new System.Drawing.Point(143, 50);
            this.txtmasanpham.Name = "txtmasanpham";
            this.txtmasanpham.Size = new System.Drawing.Size(181, 20);
            this.txtmasanpham.TabIndex = 6;
            this.txtmasanpham.TextChanged += new System.EventHandler(this.txtmasanpham_leave);
            this.txtmasanpham.Leave += new System.EventHandler(this.txtmasanpham_leave);
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(143, 179);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(181, 20);
            this.txtgia.TabIndex = 7;
            this.txtgia.TextChanged += new System.EventHandler(this.txtgia_TextChanged);
            // 
            // txtsoluongsanpham
            // 
            this.txtsoluongsanpham.Location = new System.Drawing.Point(143, 136);
            this.txtsoluongsanpham.Name = "txtsoluongsanpham";
            this.txtsoluongsanpham.Size = new System.Drawing.Size(181, 20);
            this.txtsoluongsanpham.TabIndex = 8;
            this.txtsoluongsanpham.TextChanged += new System.EventHandler(this.txtsoluongsanpham_TextChanged);
            // 
            // txttensanpham
            // 
            this.txttensanpham.Location = new System.Drawing.Point(143, 93);
            this.txttensanpham.Name = "txttensanpham";
            this.txttensanpham.Size = new System.Drawing.Size(181, 20);
            this.txttensanpham.TabIndex = 9;
            this.txttensanpham.TextChanged += new System.EventHandler(this.txttensanpham_TextChanged);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(507, 186);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(614, 186);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(720, 186);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(330, 48);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 15;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // ucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txttensanpham);
            this.Controls.Add(this.txtsoluongsanpham);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtmasanpham);
            this.Controls.Add(this.lblgia);
            this.Controls.Add(this.lblsoluong);
            this.Controls.Add(this.lblTensanpham);
            this.Controls.Add(this.lblmasanpham);
            this.Controls.Add(this.lblSanPham);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ucSanPham";
            this.Size = new System.Drawing.Size(898, 562);
            this.Load += new System.EventHandler(this.ucSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.Label lblmasanpham;
        private System.Windows.Forms.Label lblTensanpham;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label lblgia;
        private System.Windows.Forms.TextBox txtmasanpham;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtsoluongsanpham;
        private System.Windows.Forms.TextBox txttensanpham;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btntimkiem;
    }
}
