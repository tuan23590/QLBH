using QLBH.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.ThanhTuan
{
    public partial class FormThemSP : Form
    {
        MongoDBConnection mongoDBConnection = new MongoDBConnection();
        public FormThemSP()
        {
            InitializeComponent();
            LoadPhanLoaiToComboBox();
        }
        private void LoadPhanLoaiToComboBox()
        {
            List<string> danhSachPhanLoai = mongoDBConnection.LayDanhSachPhanLoai();

            comboBox1.DataSource = danhSachPhanLoai;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tenSP = textBox1.Text;
            List<string> phanLoai = new List<string>();

            foreach (var item in listBox1.Items)
            {
                phanLoai.Add(item.ToString());
            }

            string thoiGianBaoHanh = numericUpDown1.Value.ToString(); 
            string namSX = numericUpDown2.Value.ToString();

            mongoDBConnection.ThemSanPham(tenSP, phanLoai, thoiGianBaoHanh, namSX);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vanBanMoi = comboBox1.Text; // Lấy dòng văn bản từ TextBox

            if (!string.IsNullOrWhiteSpace(vanBanMoi))
            {
                listBox1.Items.Add(vanBanMoi); // Thêm dòng văn bản vào ListBox
                comboBox1.Text = "";
            }     
            else
            {
                MessageBox.Show("Vui lòng nhập dòng văn bản trước khi thêm.");
            }
        }
    }
}
