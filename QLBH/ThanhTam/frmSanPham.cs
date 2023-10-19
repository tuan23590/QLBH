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

namespace QLBH.ThanhTam
{
    public partial class frmSanPham : Form
    {
        private IMongoCollection<BsonDocument> SanPhamCollection;

        public frmSanPham()
        {
            InitializeComponent();
            InitializeMongoDB(); // Khởi tạo kết nối MongoDB
        }

        private void InitializeMongoDB()
        {
            var dbClient = new MongoClient("mongodb://localhost:27017");
            var database = dbClient.GetDatabase("CSDL"); // Thay "TenCSDL" bằng tên CSDL thực
            SanPhamCollection = database.GetCollection<BsonDocument>("SanPham");
        }

        private void LoadSanPhamData()
        {
            // Xóa dữ liệu hiện có trong DataGridView
            dataGridView1.Rows.Clear();

            // Lấy danh sách sản phẩm từ MongoDB
            var sanPhamList = SanPhamCollection.Find(new BsonDocument()).ToList();

            // Hiển thị danh sách sản phẩm trong DataGridView
            foreach (var sanPham in sanPhamList)
            {
                string tenSanPham = sanPham["TenSanPham"].AsString;
                string maSanPham = sanPham["MaSanPham"].AsString;
                int soLuong = sanPham["SoLuong"].AsInt32;

                // Thêm dòng mới vào DataGridView
                dataGridView1.Rows.Add(tenSanPham, maSanPham, soLuong);
            }
        }

        private string tenKhachHang = ""; // Khai báo biến để lưu tên khách hàng
        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            // Cập nhật biến tenKhachHang với nội dung mới từ hộp văn bản
            tenKhachHang = txtTenKhachHang.Text;
        }

        private string maKhachHang = ""; // Khai báo biến để lưu mã khách hàng
        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            maKhachHang = txtMaKhachHang.Text;
        }

        private string tenSanPham = ""; // Khai báo biến để lưu tên sản phẩm
        private void txtTenSanPham_TextChanged(object sender, EventArgs e)
        {
            // Cập nhật biến tenSanPham với nội dung mới từ hộp văn bản
            tenSanPham = txtTenSanPham.Text;
        }

        private string maSanPham = "";
        private void txtMaSanPham_TextChanged(object sender, EventArgs e)
        {
            maSanPham=txtMaSanPham.Text;
        }

        private int soLuong = 0; // Khai báo biến để lưu số lượng
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoLuong.Text, out int newSoLuong))
            {
                // Kiểm tra xem giá trị nhập vào có phải là một số nguyên hợp lệ không
                soLuong = newSoLuong; // Cập nhật biến soLuong với giá trị mới
                                      // có thể sử dụng biến soLuong trong các xử lý khác
            }
            else
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng chỉ nhập số nguyên.");
                // Nếu người dùng nhập không phải là số nguyên, hiển thị thông báo lỗi.
            }
        }

        private void chkBaoHanh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBaoHanh.Checked)
            {
                // Đã chọn trạng thái bảo hành, thực hiện mã lệnh cần thiết
                chkKhongBaoHanh.Checked = false; // Đảm bảo chỉ một trong hai checkbox được chọn
            }
        }

        private void chkKhongBaoHanh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKhongBaoHanh.Checked)
            {
                // Đã chọn trạng thái không bảo hành, thực hiện mã lệnh cần thiết
                chkBaoHanh.Checked = false; // Đảm bảo chỉ một trong hai checkbox được chọn
            }
        }

        private void radBaThang_CheckedChanged(object sender, EventArgs e)
        {
            if (radBaThang.Checked)
            {
                // Đã chọn bảo hành 3 tháng, thực hiện mã lệnh cần thiết

                // Đảm bảo chỉ một trong bốn radio button được chọn
                radSauThang.Checked = false;
                radMotNam.Checked = false;
                radHaiNam.Checked = false;
            }
        }

        private void radSauThang_CheckedChanged(object sender, EventArgs e)
        {
            if (radSauThang.Checked)
            {
                // Đã chọn bảo hành 6 tháng, thực hiện mã lệnh cần thiết

                // Đảm bảo chỉ một trong bốn radio button được chọn
                radBaThang.Checked = false;
                radMotNam.Checked = false;
                radHaiNam.Checked = false;
            }
        }

        private void radMotNam_CheckedChanged(object sender, EventArgs e)
        {
            if (radMotNam.Checked)
            {
                // Đã chọn bảo hành 1 năm, thực hiện mã lệnh cần thiết

                // Đảm bảo chỉ một trong bốn radio button được chọn
                radBaThang.Checked = false;
                radSauThang.Checked = false;
                radHaiNam.Checked = false;
            }
        }

        private void radHaiNam_CheckedChanged(object sender, EventArgs e)
        {
            if (radHaiNam.Checked)
            {
                // Đã chọn bảo hành 2 năm, thực hiện mã lệnh cần thiết

                // Đảm bảo chỉ một trong bốn radio button được chọn
                radBaThang.Checked = false;
                radSauThang.Checked = false;
                radMotNam.Checked = false;
            }
        }

        private void txtSoLanBaoHanh_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập giá trị hợp lệ hay không
            if (!int.TryParse(txtSoLanBaoHanh.Text, out int soLanBaoHanh))
            {
                // Người dùng đã nhập giá trị không hợp lệ, bạn có thể hiển thị một thông báo lỗi
                MessageBox.Show("Vui lòng chỉ nhập số nguyên cho số lần bảo hành.");
                // Xóa nội dung không hợp lệ và tập trung vào hộp văn bản
                txtSoLanBaoHanh.Text = string.Empty;
                txtSoLanBaoHanh.Focus();
            }
            else
            {
                // Giá trị nhập vào là một số nguyên hợp lệ, có thể sử dụng giá trị này (soLanBaoHanh) cho các mục đích khác.
            }
        }

        private void grDanhSach_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại thêm sản phẩm (ví dụ: FormThemSanPham)
            frmSanPham formSanPham = new frmSanPham();
            DialogResult result = formSanPham.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Lấy thông tin sản phẩm từ form ThemSanPham
                string tenSanPham = formSanPham.txtTenSanPham.Text;
                string maSanPham = formSanPham.txtTenSanPham.Text;
                int soLuong = Convert.ToInt32(formSanPham.txtSoLuong.Text);

                // Thực hiện chèn thông tin sản phẩm vào MongoDB
                var sanPham = new BsonDocument
        {
            { "TenSanPham", tenSanPham },
            { "MaSanPham", maSanPham },
            { "SoLuong", soLuong }
            // Thêm các trường thông tin sản phẩm khác tại đây
        };

                SanPhamCollection.InsertOne(sanPham);

                // Cập nhật danh sách sản phẩm
                LoadSanPhamData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng đã chọn sản phẩm trong DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy ID hoặc mã sản phẩm của sản phẩm được chọn (tùy thuộc vào cách bạn lưu trong MongoDB)
                string maSanPham = dataGridView1.SelectedRows[0].Cells["MaSanPham"].Value.ToString(); // Thay "MaSanPham" bằng tên cột mã sản phẩm trong DataGridView

                // Thực hiện xóa sản phẩm khỏi MongoDB bằng ID hoặc mã sản phẩm
                var filter = Builders<BsonDocument>.Filter.Eq("MaSanPham", maSanPham); // Thay "MaSanPham" bằng tên trường mã sản phẩm trong MongoDB
                SanPhamCollection.DeleteOne(filter);

                // Cập nhật danh sách sản phẩm sau khi xóa
                LoadSanPhamData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng đã chọn sản phẩm trong DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy ID hoặc mã sản phẩm của sản phẩm được chọn (tùy thuộc vào cách bạn lưu trong MongoDB)
                string maSanPham = dataGridView1.SelectedRows[0].Cells["MaSanPham"].Value.ToString(); // Thay "MaSanPham" bằng tên cột mã sản phẩm trong DataGridView

                // Hiển thị hộp thoại chỉnh sửa thông tin sản phẩm (ví dụ: FormSuaSanPham)
                frmSanPham formSanPham = new frmSanPham();
                DialogResult result = formSanPham.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Lấy thông tin sản phẩm được chỉnh sửa từ form SuaSanPham
                    string tenSanPham = formSanPham.txtTenSanPham.Text;
                    int soLuong = Convert.ToInt32(formSanPham.txtSoLuong.Text);

                    // Thực hiện cập nhật thông tin sản phẩm trong MongoDB bằng ID hoặc mã sản phẩm
                    var filter = Builders<BsonDocument>.Filter.Eq("MaSanPham", maSanPham); // Thay "MaSanPham" bằng tên trường mã sản phẩm trong MongoDB
                    var update = Builders<BsonDocument>.Update
                        .Set("TenSanPham", tenSanPham)
                        .Set("SoLuong", soLuong);
                    SanPhamCollection.UpdateOne(filter, update);

                    // Cập nhật danh sách sản phẩm sau khi chỉnh sửa
                    LoadSanPhamData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần chỉnh sửa.");
            }
        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng form không?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
