namespace QLBH
{
    partial class FormDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_dangky = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(782, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(630, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(630, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(759, 229);
            this.txt_taikhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(303, 22);
            this.txt_taikhoan.TabIndex = 3;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(759, 281);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(303, 22);
            this.txt_matkhau.TabIndex = 4;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(706, 333);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(179, 36);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "ĐĂNG NHẬP";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_dangky
            // 
            this.btn_dangky.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_dangky.ForeColor = System.Drawing.Color.White;
            this.btn_dangky.Location = new System.Drawing.Point(905, 333);
            this.btn_dangky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(179, 36);
            this.btn_dangky.TabIndex = 6;
            this.btn_dangky.Text = "ĐĂNG KÝ";
            this.btn_dangky.UseVisualStyleBackColor = false;
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImage = global::QLBH.Properties.Resources.aaaa;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(1061, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(49, 48);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLBH.Properties.Resources._1612759368397;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 534);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_dangky);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_dangky;
        private System.Windows.Forms.Button btn_exit;
    }
}