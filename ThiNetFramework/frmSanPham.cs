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
using ThiNetFramework.DAL;
using ThiNetFramework.View_Model;

namespace ThiNetFramework
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
            NapSanPham();
            var ls = LoaispBLL.GetList();
            comboBox1.DataSource = ls;
            comboBox1.DisplayMember = "TenLoai";
            comboBox1.ValueMember = "MaLoai";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var loaisp = comboBox1.SelectedItem as LoaiSanPham;
            if (loaisp != null)
            {
                var ls = SanPhamBLL.GetList(loaisp.MaLoai);
                sanPhamBindingSource.DataSource = ls;
                dataGridView1.DataSource = sanPhamBindingSource;
            }
        }
        void NapSanPham()
        {
            var ls = SanPhamBLL.GetListVM();
            sanPhamBindingSource.DataSource = ls;
            dataGridView1.DataSource = sanPhamBindingSource;
        }
        public SanPhamVM SelectSanPham
        {
            get
            {
                 return sanPhamBindingSource.Current as SanPhamVM;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            var f = new frmSanPhamCT();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapSanPham();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (SelectSanPham != null)
            {
               var f = new frmSanPhamCT(SelectSanPham);
                var rs = f.ShowDialog();
                if (rs == DialogResult.OK)
                {
                   NapSanPham();
               }
           }
            else
             {
               MessageBox.Show("Không có sản phẩm để sửa!!");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        { 
              if (SelectSanPham != null)
              {
                  if (MessageBox.Show(
                          "Bạn có thực sự muốn xoá?",
                          "Chú ý",
                          MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Question) == DialogResult.OK)
                  {
                      SanPhamBLL.Delete(SelectSanPham.ID);
                      sanPhamBindingSource.RemoveCurrent();
                      MessageBox.Show("Đã xoá thành công", "Thông báo");
                  }
              }
              else
              {
                  MessageBox.Show("Không có sinh viên để xoá");
              }

          }

       
    }
}
    
