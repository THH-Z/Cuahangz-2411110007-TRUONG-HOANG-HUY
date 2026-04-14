namespace GUI
{
    partial class ucNhanVien
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
            this.lblnhanvien = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblmanhanvien = new System.Windows.Forms.Label();
            this.lbltennhanvien = new System.Windows.Forms.Label();
            this.lbldienthoai = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.lblvaitro = new System.Windows.Forms.Label();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnhanvien
            // 
            this.lblnhanvien.AutoSize = true;
            this.lblnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhanvien.Location = new System.Drawing.Point(380, 10);
            this.lblnhanvien.Name = "lblnhanvien";
            this.lblnhanvien.Size = new System.Drawing.Size(134, 25);
            this.lblnhanvien.TabIndex = 0;
            this.lblnhanvien.Text = "NHÂN VIÊN";
            this.lblnhanvien.Click += new System.EventHandler(this.lblnhanvien_Click);
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
            // lblmanhanvien
            // 
            this.lblmanhanvien.AutoSize = true;
            this.lblmanhanvien.Location = new System.Drawing.Point(65, 46);
            this.lblmanhanvien.Name = "lblmanhanvien";
            this.lblmanhanvien.Size = new System.Drawing.Size(75, 13);
            this.lblmanhanvien.TabIndex = 2;
            this.lblmanhanvien.Text = "Mã Nhân Viên";
            // 
            // lbltennhanvien
            // 
            this.lbltennhanvien.AutoSize = true;
            this.lbltennhanvien.Location = new System.Drawing.Point(68, 94);
            this.lbltennhanvien.Name = "lbltennhanvien";
            this.lbltennhanvien.Size = new System.Drawing.Size(79, 13);
            this.lbltennhanvien.TabIndex = 3;
            this.lbltennhanvien.Text = "Tên Nhân Viên";
            // 
            // lbldienthoai
            // 
            this.lbldienthoai.AutoSize = true;
            this.lbldienthoai.Location = new System.Drawing.Point(68, 142);
            this.lbldienthoai.Name = "lbldienthoai";
            this.lbldienthoai.Size = new System.Drawing.Size(59, 13);
            this.lbldienthoai.TabIndex = 4;
            this.lbldienthoai.Text = "Điện Thoại";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(749, 185);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(540, 185);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(162, 46);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(164, 20);
            this.txtmanhanvien.TabIndex = 8;
            this.txtmanhanvien.TextChanged += new System.EventHandler(this.txtmanhanvien_TextChanged);
            this.txtmanhanvien.Leave += new System.EventHandler(this.txtmanhanvien_leave);
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Location = new System.Drawing.Point(162, 88);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(164, 20);
            this.txttennhanvien.TabIndex = 9;
            this.txttennhanvien.TextChanged += new System.EventHandler(this.txttennhanvien_TextChanged);
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(162, 138);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(164, 20);
            this.txtdienthoai.TabIndex = 10;
            this.txtdienthoai.TextChanged += new System.EventHandler(this.txtdienthoai_TextChanged);
            // 
            // lblvaitro
            // 
            this.lblvaitro.AutoSize = true;
            this.lblvaitro.Location = new System.Drawing.Point(71, 190);
            this.lblvaitro.Name = "lblvaitro";
            this.lblvaitro.Size = new System.Drawing.Size(41, 13);
            this.lblvaitro.TabIndex = 11;
            this.lblvaitro.Text = "Vai Trò";
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Location = new System.Drawing.Point(162, 182);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(121, 21);
            this.cbbQuyen.TabIndex = 13;
            this.cbbQuyen.SelectedIndexChanged += new System.EventHandler(this.cbbQuyen_SelectedIndexChanged);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(333, 42);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 14;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(649, 185);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.cbbQuyen);
            this.Controls.Add(this.lblvaitro);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.txttennhanvien);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lbldienthoai);
            this.Controls.Add(this.lbltennhanvien);
            this.Controls.Add(this.lblmanhanvien);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblnhanvien);
            this.Name = "ucNhanVien";
            this.Size = new System.Drawing.Size(898, 562);
            this.Load += new System.EventHandler(this.ucNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnhanvien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblmanhanvien;
        private System.Windows.Forms.Label lbltennhanvien;
        private System.Windows.Forms.Label lbldienthoai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.Label lblvaitro;
        private System.Windows.Forms.ComboBox cbbQuyen;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnThem;
    }
}
