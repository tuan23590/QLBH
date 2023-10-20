using MongoDB.Bson;
using MongoDB.Driver;
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
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
namespace QLBH.ThanhTuan
{
    public partial class FormQuanLyPhieuBH : Form
    {
        MongoDBConnection mongoDBConnection = new MongoDBConnection();
        public FormQuanLyPhieuBH()
        {
            InitializeComponent();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            comboBox1.DataSource =  mongoDBConnection.LayDanhSachPhanLoai();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string phanLoai = comboBox1.Text;

            List<List<string>> result = mongoDBConnection.LayThongTinTheoPhanLoai(phanLoai);

            dataGridView1.Rows.Clear();

            foreach (var row in result)
            {
                dataGridView1.Rows.Add(row.ToArray());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string tenSP = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (e.ColumnIndex == 4)
                {
                    
                    FormTongKHMua formTongPhieuBH = new FormTongKHMua(tenSP);
                    formTongPhieuBH.ShowDialog();
                }    
                if (e.ColumnIndex == 5)
                {
                    FormTongPhieuBaoHanh formTongPhieuBaoHanh = new FormTongPhieuBaoHanh(tenSP);
                    formTongPhieuBaoHanh.ShowDialog();  
                }    


            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string tenSP = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string thoiGianBaoHanh = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string namSX = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                mongoDBConnection.CapNhatDuLieuTheoTenSP(tenSP, thoiGianBaoHanh, namSX);
            }
        }

        private void dataGridView1_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
           
        }
    }
}
