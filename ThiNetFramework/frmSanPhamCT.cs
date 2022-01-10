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
    public partial class frmSanPhamCT : Form
    {
        SanPhamVM sanphamVM;
        public frmSanPhamCT(SanPhamVM sanphamVM = null)
        {
            InitializeComponent();
            this.sanphamVM = sanphamVM;
            if (sanphamVM == null)
            {
                this.Text = "Thêm mới sản phẩm";
            }
            else
            {
                this.Text = "Cập nhật dữ liệu sản phẩm";
                txtmasp.Text = sanphamVM.MaSP;
                txttensp.Text = sanphamVM.Tensp;
                dmsoluong.Text = sanphamVM.soluong;
                txtgia.Text = sanphamVM.gia;
                txtmaloai.Text = sanphamVM.MaLoai.ToString();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var masp = txtmasp.Text;
            var tensp = txttensp.Text;
            var sl = dmsoluong.Text;
            var gia = txtgia.Text;
            long maloai = long.Parse(txtmaloai.Text);

            if (string.IsNullOrEmpty(txtmasp.Text))
            {
                errorProvider1.SetError(txtmasp, "Mã sản phẩm không được để trống");
                return;
            }
            else if (string.IsNullOrEmpty(tensp))
            {
                errorProvider1.SetError(txttensp, "Tên sản phẩm không được để trống");
                return;
            }
            else if (string.IsNullOrEmpty(sl))
            {
                errorProvider1.SetError(dmsoluong, "Số lượng không được để trống");
                return;
            }
            else if (string.IsNullOrEmpty(gia))
            {
                errorProvider1.SetError(txtgia, "Giá được để trống");
                return;
            }
            else if (string.IsNullOrEmpty(txtmaloai.Text))
            {
                errorProvider1.SetError(txtmaloai, "Mã loại không được để trống");
                return;
            }
            var rs = kq.ThanhCong;
            if (sanphamVM == null)
            {
                //Thêm mới dl
                rs = SanPhamBLL.Add(new SanPhamVM
                {
                    MaSP = masp,
                    Tensp = tensp,
                    soluong = sl,
                    gia = gia,
                    MaLoai = maloai
                });
            }
            else
            {
                //Cập nhật dl
                sanphamVM.MaSP = masp;
                sanphamVM.Tensp = tensp;
                sanphamVM.soluong = sl;
                sanphamVM.gia = gia;
                sanphamVM.MaLoai = maloai;
                rs = SanPhamBLL.Update(sanphamVM);
            }
            if (rs == kq.ThanhCong)
            {
                DialogResult = DialogResult.OK;
            }
            else if (rs == kq.matrung)
            {
                MessageBox.Show("Mã sản phẩm không được trùng nhau", "Thông báo");
            }
        }
    }
}
