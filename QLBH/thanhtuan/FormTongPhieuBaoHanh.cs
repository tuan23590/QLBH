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
    public partial class FormTongPhieuBaoHanh : Form
    {
        MongoDBConnection mongoDBConnection = new MongoDBConnection();
        public FormTongPhieuBaoHanh(string tenSP)
        {
            InitializeComponent();
            HienThiThongTinBaoHanhTheoTenSP(tenSP);
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void HienThiThongTinBaoHanhTheoTenSP(string tenSP)
        {
            List<List<string>> result = mongoDBConnection.LayDanhSachBaoHanhTheoTenSP(tenSP);

            // Đổ dữ liệu vào DataGridView
            dataGridView1.Rows.Clear();
            if (result == null)
                return;
            foreach (var row in result)
            {
                dataGridView1.Rows.Add(row.ToArray());
            }
        }
    }
}
