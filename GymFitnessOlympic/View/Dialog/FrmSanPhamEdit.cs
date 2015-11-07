using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Models.DataFiller;
using GymFitnessOlympic.Models.Util;
using System.IO;

namespace GymFitnessOlympic.View.Dialog
{
    public partial class FrmSanPhamEdit : DevExpress.XtraEditors.XtraForm
    {
        bool isThem = false;
        SanPham current;
        bool isHaveFile = false;

        public FrmSanPhamEdit(SanPham h = null)
        {
            InitializeComponent();
            current = h;
            if (current != null)
            {
                Text = "Chỉnh sửa sản phẩm";
                btnAdd.Text = "Cập nhật";
                loadField();
                isThem = false;
            }
            else
            {
                isThem = true;
            }
            DataFiller.fillPhongCombo(cbbPhong);
        }



        private void loadField()
        {

            txtTen.Text = current.TenSanPham;
            //txtMaSauna.Text = current.MaSauna;
            txtGia.Text = current.Gia.ToString();

        }


        SanPham prepareSanPham()
        {
            if (current == null)
            {
                current = new SanPham();
            }

            current.Gia = int.Parse(txtGia.Text);
            current.PhongTap = Login1.GetPhongHienTai();
            current.TenSanPham = txtTen.Text;
            if (isHaveFile)
            {
                String fileName = opd.FileName;
                Bitmap bmp = new Bitmap(fileName);
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                byte[] bimage = new byte[fs.Length];
                fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                fs.Close();

                byte[] Photo = bimage;
                //hv.Anh = Photo;
            }
            var phong = (PhongTap)cbbPhong.SelectedItem;
            return current;


        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int gia;
            if (txtTen.Text == "")
            {
                dxErrorProvider1.SetError(txtTen, "Chưa nhập tên");
                txtTen.Focus();
                return;
            }
            if (txtGia.Text == "")
            {
                dxErrorProvider1.SetError(txtGia, "Chưa nhập giá");
                txtGia.Focus();
                return;
            }
            if (!int.TryParse(txtGia.Text, out gia))
            {
                dxErrorProvider1.SetError(txtGia, "Giá không hợp lệ");
                txtGia.Focus();
                return;
            }
            if (cbbPhong.SelectedItem == null)
            {
                dxErrorProvider1.SetError(txtGia, "Chưa chọn phòng");
                txtGia.Focus();
                return;
            }
            current = prepareSanPham();
            if (isThem)
            {
                if (SanPhamController.Add(current) == CODE_RESULT_RETURN.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm");
                }
            }
            else
            {
                if (SanPhamController.Update(current) == CODE_RESULT_RETURN.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi cập nhật");
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            opd.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            String fileName = opd.FileName;
            //pictureEdit1.Image = Image.FromFile(fileName);
            isHaveFile = true;
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
        }


        private void pictureEdit1_MouseClick(object sender, MouseEventArgs e)
        {
            opd.ShowDialog();
        }

        private void txtHoTen_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dxValidationProvider1_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            // MessageBox.Show("aaa");
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}