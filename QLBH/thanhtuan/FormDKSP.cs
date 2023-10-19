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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLBH.ThanhTuan
{
    public partial class FormDKSP : Form
    {
        MongoDBConnection mongoDBConnection = new MongoDBConnection();
        public FormDKSP()
        {
            InitializeComponent();
            LoadComboBox();
        }
        private void LoadComboBox()
        {
            List<string> danhSachPhanLoai = mongoDBConnection.LayDanhSachPhanLoai();

            comboBox1.DataSource = danhSachPhanLoai;
            string[] tinhArr = new string[]
            {
                "Tỉnh A",
                "Tỉnh B",
                "Tỉnh C"
                
            };
            string[] huyenArr = new string[]
            {
                "Huyện 1",
                "Huyện 2",
                "Huyện 3"
            };

            string[] xaArr = new string[]
            {
                "Xã X",
                "Xã Y",
                "Xã Z"
            };
            comboBox4.DataSource = tinhArr;
            comboBox5.DataSource = huyenArr;
            comboBox6.DataSource = xaArr;

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tenSP = textBox1.Text; 
            string tenKH = comboBox3.Text; 
            string sdt = textBox5.Text; 
            string email = textBox4.Text;
            string ngayMua = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string tp = comboBox4.Text;
            string quan = comboBox5.Text; 
            string phuong = comboBox6.Text;
            string soNhaTenDuong = textBox8.Text;

            mongoDBConnection.ThemThongTinBaoHanhTheoTenSP(tenSP, tenKH, sdt, email, ngayMua, tp, quan, phuong, soNhaTenDuong);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormThemSP form = new FormThemSP();
            form.ShowDialog();
            LoadComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> danhSachTenSP = mongoDBConnection.LayDanhSachTenSPTheoInput(comboBox1.Text.ToString());
            comboBox2.DataSource = danhSachTenSP;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var thongTin = mongoDBConnection.LayThoiGianBaoHanhVaNamSXTheoTenSP(comboBox2.Text);

            if (!string.IsNullOrEmpty(thongTin.Item1) && !string.IsNullOrEmpty(thongTin.Item2))
            {
                textBox1.Text = comboBox2.Text;
                textBox2.Text = comboBox1.Text;
                numericUpDown1.Value = int.Parse(thongTin.Item1);
                numericUpDown2.Value = int.Parse(thongTin.Item2);
            }
        }
    }
}
