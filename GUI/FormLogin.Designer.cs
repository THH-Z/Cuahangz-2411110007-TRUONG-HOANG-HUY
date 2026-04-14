namespace GUI
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lbldangnhap = new System.Windows.Forms.Label();
            this.lbltentaikhoan = new System.Windows.Forms.Label();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.txttentaikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldangnhap
            // 
            this.lbldangnhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbldangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldangnhap.Location = new System.Drawing.Point(0, 0);
            this.lbldangnhap.Name = "lbldangnhap";
            this.lbldangnhap.Size = new System.Drawing.Size(800, 38);
            this.lbldangnhap.TabIndex = 0;
            this.lbldangnhap.Text = "ĐĂNG NHẬP";
            this.lbldangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbldangnhap.Click += new System.EventHandler(this.lbldangnhap_Click);
            // 
            // lbltentaikhoan
            // 
            this.lbltentaikhoan.AutoSize = true;
            this.lbltentaikhoan.BackColor = System.Drawing.SystemColors.Info;
            this.lbltentaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltentaikhoan.Location = new System.Drawing.Point(234, 116);
            this.lbltentaikhoan.Name = "lbltentaikhoan";
            this.lbltentaikhoan.Size = new System.Drawing.Size(108, 16);
            this.lbltentaikhoan.TabIndex = 1;
            this.lbltentaikhoan.Text = "Tên Tài Khoản";
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.BackColor = System.Drawing.SystemColors.Info;
            this.lblmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatkhau.Location = new System.Drawing.Point(234, 156);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(70, 16);
            this.lblmatkhau.TabIndex = 2;
            this.lblmatkhau.Text = "Mật Khẩu";
            // 
            // txttentaikhoan
            // 
            this.txttentaikhoan.Location = new System.Drawing.Point(348, 115);
            this.txttentaikhoan.Name = "txttentaikhoan";
            this.txttentaikhoan.Size = new System.Drawing.Size(180, 20);
            this.txttentaikhoan.TabIndex = 3;
            this.txttentaikhoan.TextChanged += new System.EventHandler(this.txttentaikhoan_TextChanged);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(348, 155);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(180, 20);
            this.txtmatkhau.TabIndex = 4;
            this.txtmatkhau.UseSystemPasswordChar = true;
            this.txtmatkhau.TextChanged += new System.EventHandler(this.txtmatkhau_TextChanged);
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.IndianRed;
            this.btndangnhap.Location = new System.Drawing.Point(228, 158);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(75, 23);
            this.btndangnhap.TabIndex = 5;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btndangnhap);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Location = new System.Drawing.Point(195, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 291);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnthoat.Location = new System.Drawing.Point(309, 158);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttentaikhoan);
            this.Controls.Add(this.lblmatkhau);
            this.Controls.Add(this.lbltentaikhoan);
            this.Controls.Add(this.lbldangnhap);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldangnhap;
        private System.Windows.Forms.Label lbltentaikhoan;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.TextBox txttentaikhoan;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthoat;
    }
}