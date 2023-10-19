namespace QLBH.ThanhTam
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.chkBaoHanh = new System.Windows.Forms.CheckBox();
            this.chkKhongBaoHanh = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoLanBaoHanh = new System.Windows.Forms.TextBox();
            this.radBaThang = new System.Windows.Forms.RadioButton();
            this.radSauThang = new System.Windows.Forms.RadioButton();
            this.radMotNam = new System.Windows.Forms.RadioButton();
            this.radHaiNam = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(156, 123);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(599, 22);
            this.txtTenSanPham.TabIndex = 3;
            this.txtTenSanPham.TextChanged += new System.EventHandler(this.txtTenSanPham_TextChanged);
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(156, 155);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(599, 22);
            this.txtMaSanPham.TabIndex = 4;
            this.txtMaSanPham.TextChanged += new System.EventHandler(this.txtMaSanPham_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(156, 198);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(599, 22);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số Lượng:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 7;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(796, 112);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 38);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(796, 162);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 40);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên Khách Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã Khách hàng:";
            // 
            // grDanhSach
            // 
            this.grDanhSach.Controls.Add(this.dataGridView1);
            this.grDanhSach.Location = new System.Drawing.Point(16, 309);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Size = new System.Drawing.Size(891, 222);
            this.grDanhSach.TabIndex = 14;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh Sách";
            this.grDanhSach.Enter += new System.EventHandler(this.grDanhSach_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(891, 201);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(156, 43);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(599, 22);
            this.txtTenKhachHang.TabIndex = 15;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(156, 79);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(599, 22);
            this.txtMaKhachHang.TabIndex = 16;
            this.txtMaKhachHang.TextChanged += new System.EventHandler(this.txtMaKhachHang_TextChanged);
            // 
            // chkBaoHanh
            // 
            this.chkBaoHanh.AutoSize = true;
            this.chkBaoHanh.Location = new System.Drawing.Point(178, 246);
            this.chkBaoHanh.Name = "chkBaoHanh";
            this.chkBaoHanh.Size = new System.Drawing.Size(85, 20);
            this.chkBaoHanh.TabIndex = 18;
            this.chkBaoHanh.Text = "bảo hành";
            this.chkBaoHanh.UseVisualStyleBackColor = true;
            this.chkBaoHanh.CheckedChanged += new System.EventHandler(this.chkBaoHanh_CheckedChanged);
            // 
            // chkKhongBaoHanh
            // 
            this.chkKhongBaoHanh.AutoSize = true;
            this.chkKhongBaoHanh.Location = new System.Drawing.Point(178, 283);
            this.chkKhongBaoHanh.Name = "chkKhongBaoHanh";
            this.chkKhongBaoHanh.Size = new System.Drawing.Size(161, 20);
            this.chkKhongBaoHanh.TabIndex = 19;
            this.chkKhongBaoHanh.Text = "không hỗ trợ bảo hành";
            this.chkKhongBaoHanh.UseVisualStyleBackColor = true;
            this.chkKhongBaoHanh.CheckedChanged += new System.EventHandler(this.chkKhongBaoHanh_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Trạng thái bảo hành";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Thời gian bảo hành";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Số lần bảo hành";
            // 
            // txtSoLanBaoHanh
            // 
            this.txtSoLanBaoHanh.Location = new System.Drawing.Point(557, 281);
            this.txtSoLanBaoHanh.Name = "txtSoLanBaoHanh";
            this.txtSoLanBaoHanh.Size = new System.Drawing.Size(100, 22);
            this.txtSoLanBaoHanh.TabIndex = 23;
            this.txtSoLanBaoHanh.TextChanged += new System.EventHandler(this.txtSoLanBaoHanh_TextChanged);
            // 
            // radBaThang
            // 
            this.radBaThang.AutoSize = true;
            this.radBaThang.Location = new System.Drawing.Point(557, 245);
            this.radBaThang.Name = "radBaThang";
            this.radBaThang.Size = new System.Drawing.Size(77, 20);
            this.radBaThang.TabIndex = 24;
            this.radBaThang.TabStop = true;
            this.radBaThang.Text = "3 Tháng";
            this.radBaThang.UseVisualStyleBackColor = true;
            this.radBaThang.CheckedChanged += new System.EventHandler(this.radBaThang_CheckedChanged);
            // 
            // radSauThang
            // 
            this.radSauThang.AutoSize = true;
            this.radSauThang.Location = new System.Drawing.Point(640, 246);
            this.radSauThang.Name = "radSauThang";
            this.radSauThang.Size = new System.Drawing.Size(77, 20);
            this.radSauThang.TabIndex = 25;
            this.radSauThang.TabStop = true;
            this.radSauThang.Text = "6 Tháng";
            this.radSauThang.UseVisualStyleBackColor = true;
            this.radSauThang.CheckedChanged += new System.EventHandler(this.radSauThang_CheckedChanged);
            // 
            // radMotNam
            // 
            this.radMotNam.AutoSize = true;
            this.radMotNam.Location = new System.Drawing.Point(723, 246);
            this.radMotNam.Name = "radMotNam";
            this.radMotNam.Size = new System.Drawing.Size(67, 20);
            this.radMotNam.TabIndex = 26;
            this.radMotNam.TabStop = true;
            this.radMotNam.Text = "1 Năm";
            this.radMotNam.UseVisualStyleBackColor = true;
            this.radMotNam.CheckedChanged += new System.EventHandler(this.radMotNam_CheckedChanged);
            // 
            // radHaiNam
            // 
            this.radHaiNam.AutoSize = true;
            this.radHaiNam.Location = new System.Drawing.Point(796, 246);
            this.radHaiNam.Name = "radHaiNam";
            this.radHaiNam.Size = new System.Drawing.Size(67, 20);
            this.radHaiNam.TabIndex = 27;
            this.radHaiNam.TabStop = true;
            this.radHaiNam.Text = "2 Năm";
            this.radHaiNam.UseVisualStyleBackColor = true;
            this.radHaiNam.CheckedChanged += new System.EventHandler(this.radHaiNam_CheckedChanged);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(796, 56);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 39);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 543);
            this.Controls.Add(this.radHaiNam);
            this.Controls.Add(this.radMotNam);
            this.Controls.Add(this.radSauThang);
            this.Controls.Add(this.radBaThang);
            this.Controls.Add(this.txtSoLanBaoHanh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkKhongBaoHanh);
            this.Controls.Add(this.chkBaoHanh);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.grDanhSach);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSanPham_FormClosing);
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.grDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grDanhSach;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.CheckBox chkBaoHanh;
        private System.Windows.Forms.CheckBox chkKhongBaoHanh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoLanBaoHanh;
        private System.Windows.Forms.RadioButton radBaThang;
        private System.Windows.Forms.RadioButton radSauThang;
        private System.Windows.Forms.RadioButton radMotNam;
        private System.Windows.Forms.RadioButton radHaiNam;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}