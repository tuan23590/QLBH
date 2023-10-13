using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            string hoTen = txt_hoten.Text;
            string ngaySinh = txt_ngaysinh.Text;
            string cccd = txt_cccd.Text;
            string soDt = txt_sodt.Text;
            string email = txt_email.Text;
            string tenDangNhap = txt_taikhoan.Text;
            string matKhau = txt_matkhau.Text;
            string loaiNhanVien = txt_loainv.Text;

            if (!DateTime.TryParse(ngaySinh, out DateTime ngaySinhDateTime))
            {
                MessageBox.Show("Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng ngày (dd/MM/yyyy).");
            }


            if (!long.TryParse(cccd, out long cccdNumber))
            {
                MessageBox.Show("Số CCCD không hợp lệ. Vui lòng chỉ nhập số.");
                return;
            }

            if (!long.TryParse(soDt, out long soDtNumber))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng chỉ nhập số.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ. Định dạng đúng là example@gmail.com.");
                return; // Dừng quy trình đăng ký
            }



            var dbClient = new MongoClient("mongodb://localhost:27017");
            var database = dbClient.GetDatabase("QLBH");
            var collection = database.GetCollection<BsonDocument>("NhanVien");

            var nhanVien = new BsonDocument
        {
            { "HoTen", hoTen },
            { "NgaySinh", ngaySinh },
            { "CCCD", cccd },
            { "SDT", soDt },
            { "Email", email },
            { "TaiKhoan", new BsonDocument
                {
                    { "TenDangNhap", tenDangNhap },
                    { "MatKhau", matKhau }
                }
            },
            { "LoaiNhanVien", loaiNhanVien }
        };

            collection.InsertOne(nhanVien);
            MessageBox.Show("Đăng ký thành công!");

            this.Close();
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
