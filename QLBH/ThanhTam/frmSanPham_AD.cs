using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.ThanhTam
{
    public partial class frmSanPham_AD : Form
    {
        public frmSanPham_AD()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmSanPham formSanPham = new frmSanPham();
            formSanPham.ShowDialog();

            frmTraCuu formTraCuu = new frmTraCuu();
            formTraCuu.ShowDialog();
        }
    }
}
