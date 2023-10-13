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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnDangKySanPham_Click_1(object sender, EventArgs e)
        {
            Form1 formDangKySanPham = new Form1();
            formDangKySanPham.Show();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoPhieuBaoHanh_Click(object sender, EventArgs e)
        {

        }

        private void btnThemThongTinSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhSachSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap formDangNhap = new DangNhap();
            formDangNhap.Show();
        }
    }
}
