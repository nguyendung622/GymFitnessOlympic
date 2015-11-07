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
    public partial class FrmGoiTapEdit : DevExpress.XtraEditors.XtraForm
    {
        bool isThem = false;
        GoiTap current;

        public FrmGoiTapEdit(GoiTap h = null)
        {
            InitializeComponent();
            current = h;
            if (current != null)
            {
                Text = "Chỉnh sửa gói tập";
                loadField();
                isThem = false;
                cbbPhong.Enabled = false;
            }
            else
            {
                isThem = true;
            }
            cbbPhong.Properties.NullText = "Chọn một phòng tập";
            DataFiller.fillPhongCombo(cbbPhong);
        }



        private void loadField()
        {

            txtGia.Text = current.Gia.ToString();
            txtTen.Text = current.TenGoiTap;
            //txtMaSauna.Text = current.MaSauna;
            txtSoThang.Text = current.SoThang.ToString();

            cbbPhong.EditValue = current.PhongTap.MaPhongTap;
            btnAdd.Text = "Cập nhật";
            Text = "Chỉnh sửa hội viên";
            if (current.Type == 1)
            {
                radGYM.Checked = true;
            }
            else
            {
                radSauna.Checked = true;
            }
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            String sTen = txtTen.Text;
            String sSoThang = txtSoThang.Text;
            String sGia = txtGia.Text;
            int soThang, gia;
            if (sTen == "")
            {
                dxErrorProvider1.SetError(txtTen, "Tên không được trống");
                txtTen.Focus();
                return;
            }
            if (sSoThang == "")
            {
                dxErrorProvider1.SetError(txtSoThang, "Chưa nhập số tháng");
                txtTen.Focus();
                return;
            }

            if (!int.TryParse(sSoThang, out soThang))
            {
                dxErrorProvider1.SetError(txtSoThang, "Số tháng không hợp lệ");
                txtSoThang.Focus();
                return;
            }

            if (sGia == "")
            {
                dxErrorProvider1.SetError(txtSoThang, "Chưa nhập giá");
                txtGia.Focus();
                return;
            }

            if (!int.TryParse(sGia, out gia))
            {
                dxErrorProvider1.SetError(txtSoThang, "Giá không hợp lệ");
                txtGia.Focus();
                return;
            }

            PhongTap p = (PhongTap)cbbPhong.GetSelectedDataRow();

            if (p == null)
            {
                dxErrorProvider1.SetError(cbbPhong, "Chưa chọn phòng tập");
                cbbPhong.Focus();
                return;
            }
            if (current == null)
            {
                current = new GoiTap()
                {
                    MaGoiTap = -1
                };
            }
            current.TenGoiTap = sTen;
            current.SoThang = soThang;
            current.Gia = gia;
            current.Type = radGYM.Checked ? 1 : 2;
            current.PhongTap = p;
            if (isThem)
            {
                if (GoiTapController.Add(current) == CODE_RESULT_RETURN.ThanhCong)
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
                if (GoiTapController.Update(current) == CODE_RESULT_RETURN.ThanhCong)
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
        }



        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
        }

        void loadData()
        {
            var l = HoiVienController.GetList();

        }

        private void pictureEdit1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void txtHoTen_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dxValidationProvider1_ValidationFailed(object sender, DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventArgs e)
        {
            // MessageBox.Show("aaa");
        }

    }
}