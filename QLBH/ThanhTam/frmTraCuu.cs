using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Text.RegularExpressions;

namespace QLBH.ThanhTam
{
    public partial class frmTraCuu : Form
    {
        private IMongoCollection<BsonDocument> SanPhamCollection;
        public frmTraCuu()
        {
            InitializeComponent();
            InitializeMongoDB(); // Khởi tạo kết nối MongoDB
        }

        private void InitializeMongoDB()
        {
            var dbClient = new MongoClient("mongodb://localhost:27017");
            var database = dbClient.GetDatabase("CSDL");
            SanPhamCollection = database.GetCollection<BsonDocument>("SanPham");
        }

        private void txtMaSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu nhập trên các trường tìm kiếm
            txtTenSanPham.Text = string.Empty;
            txtTenKhachHang.Text = string.Empty;
            txtMaSanPham.Text = string.Empty;
            txtMaKhachHang.Text = string.Empty;
            // Xóa hiển thị thông tin trong groupbox
            dataGridView1.Controls.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường tìm kiếm
            string tenSanPham = txtTenSanPham.Text.Trim();
            string tenKhachHang = txtTenKhachHang.Text.Trim();
            string maSanPham = txtMaSanPham.Text.Trim();
            string maKhachHang = txtMaKhachHang.Text.Trim();

            // Tạo các điều kiện tìm kiếm dựa trên thông tin đã nhập
            var filterBuilder = Builders<BsonDocument>.Filter;
            var filter = filterBuilder.Empty; // Điều kiện ban đầu rỗng

            if (!string.IsNullOrEmpty(tenSanPham))
            {
                filter = filter & filterBuilder.Regex("TenSanPham", new BsonRegularExpression(new System.Text.RegularExpressions.Regex(tenSanPham, RegexOptions.IgnoreCase)));
            }

            if (!string.IsNullOrEmpty(tenKhachHang))
            {
                filter = filter & filterBuilder.Regex("TenKhachHang", new BsonRegularExpression(new System.Text.RegularExpressions.Regex(tenKhachHang, RegexOptions.IgnoreCase)));
            }

            if (!string.IsNullOrEmpty(maSanPham))
            {
                filter = filter & filterBuilder.Eq("MaSanPham", maSanPham);
            }

            if (!string.IsNullOrEmpty(maKhachHang))
            {
                filter = filter & filterBuilder.Eq("MaKhachHang", maKhachHang);
            }

            // Thực hiện truy vấn MongoDB dựa trên điều kiện tìm kiếm
            var results = SanPhamCollection.Find(filter).ToList();

            // Hiển thị kết quả trong groupbox
            dataGridView1.Controls.Clear();

            if (results.Count > 0)
            {
                int y = 10;
                foreach (var result in results)
                {
                    Label label = new Label
                    {
                        Text = result["TenSanPham"].AsString, // Thay "TenSanPham" bằng tên trường thực tế
                        Location = new System.Drawing.Point(10, y),
                        AutoSize = true
                    };

                    dataGridView1.Controls.Add(label);
                    y += 20;
                }
            }
            else
            {
                Label label = new Label
                {
                    Text = "Không tìm thấy kết quả.",
                    Location = new System.Drawing.Point(10, y),
                    AutoSize = true
                };

                dataGridView1.Controls.Add(label);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
