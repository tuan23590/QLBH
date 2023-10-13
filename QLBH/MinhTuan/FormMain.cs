using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.ThanhTuan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            List<string> nameButton = new List<string>();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            Form1 formToDisplay = new Form1();
            // Đặt Parent của Form là Panel mục tiêu
            formToDisplay.TopLevel = false;
            formToDisplay.FormBorderStyle = FormBorderStyle.None; // Tắt viền Form (nếu bạn muốn)
            flowLayoutPanel2.Controls.Add(formToDisplay);
            formToDisplay.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a message dialog.", "Message Dialog Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap formDangNhap = new DangNhap();
            formDangNhap.Show();
        }
    }
}
