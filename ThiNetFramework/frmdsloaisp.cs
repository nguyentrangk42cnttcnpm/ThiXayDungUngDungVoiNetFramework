using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiNetFramework.BLL;
using ThiNetFramework.View_Model;

namespace ThiNetFramework
{
    public partial class frmdsloaisp : Form
    {
        public frmdsloaisp()
        {
            InitializeComponent();
            NapLoaisp();
        }
        void NapLoaisp()
        {
            var ls = LoaispBLL.GetListVM();
            loaiSanPhamBindingSource.DataSource = ls;
            dataGridView1.DataSource = loaiSanPhamBindingSource;
        }
        public LoaispVM selectLoaisp
        {
            get
            {
                return loaiSanPhamBindingSource.Current as LoaispVM;
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            var f = new ThemLoaisp();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapLoaisp();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (selectLoaisp != null)
            {
                var f = new ThemLoaisp(selectLoaisp);
                var rs = f.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    NapLoaisp();
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (selectLoaisp != null)
            {
                if (selectLoaisp.TotalStudent == 0)
                {
                    if (MessageBox.Show(
                        "Bạn có thực sự muốn xoá?",
                        "Chú ý",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        LoaispBLL.Delete(selectLoaisp.MaLoai);
                        loaiSanPhamBindingSource.RemoveCurrent();
                        MessageBox.Show("Đã xoá thành công", "Thông báo");
                    }
                }
                else
                    MessageBox.Show("Trong lớp này đang có loại sản phẩm! Không được xoá", "Chú ý");
            }
        }
    }
}
