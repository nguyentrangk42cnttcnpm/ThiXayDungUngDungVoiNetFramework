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
    public partial class ThemLoaisp : Form
    {
        LoaispVM loaispVM;
        public ThemLoaisp(LoaispVM loaispVM = null)
        {
            InitializeComponent();
            this.loaispVM = loaispVM;
            if (loaispVM == null)
            {
                this.Text = "Thêm mới loại sản phẩm";
            }
            else
            {
                this.Text = "Cập nhật dữ liệu loại sản phẩm";
                txttenloai.Text = loaispVM.TenLoai;
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var tenloai = txttenloai.Text;
            if (string.IsNullOrEmpty(tenloai))
            {
                errorProvider1.SetError(txttenloai, "Loại sản phẩm học không được để trống");
                return;
            }

            var rs = KETQUA.ThanhCong;
            if (loaispVM == null)
            {
                //Thêm mới dl
                rs = LoaispBLL.Add(new LoaispVM
                {
                    TenLoai = tenloai
                });
            }
            else
            {
                //Cập nhật dl
                loaispVM.TenLoai = tenloai;
                rs = LoaispBLL.Update(loaispVM);
            }
            if (rs == KETQUA.ThanhCong)
            {
                DialogResult = DialogResult.OK;
            }
            else if (rs == KETQUA.TenTrung)
            {
                MessageBox.Show("Tên loại sản phẩm không được trùng nhau", "Thông báo");
            }
        }

    }
}
