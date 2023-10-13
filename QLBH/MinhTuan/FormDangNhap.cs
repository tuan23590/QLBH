using MongoDB.Bson;
using MongoDB.Driver;
using QLBH.Connection;
using QLBH.ThanhTuan;
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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            var dbConnection = new MongoDBConnection();
            string collectionName = "NhanVien";
            var allData = dbConnection.ShowAll<BsonDocument>(collectionName);

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string taiKhoan = txt_taikhoan.Text;
            string matKhau = txt_matkhau.Text;

            if (KiemTraDangNhap(taiKhoan, matKhau))
            {
                this.Hide(); 
                FormMain formTrangChu = new FormMain();
                formTrangChu.ShowDialog(); 
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu. Vui lòng thử lại.");
            }
        }
            private static bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            var dbConnection = new MongoDBConnection();
            string collectionName = "NhanVien";

            var filter = Builders<BsonDocument>.Filter.Eq("TaiKhoan.TenDangNhap", taiKhoan) & Builders<BsonDocument>.Filter.Eq("TaiKhoan.MatKhau", matKhau);
            var result = dbConnection.Search(collectionName, filter);

            return result.Count() > 0;
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            FormDangKy formDangKy = new FormDangKy();
            formDangKy.Show();
        }
    }
}
