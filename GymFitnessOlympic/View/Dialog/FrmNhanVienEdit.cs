using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Controller;
using System.IO;
using GymFitnessOlympic.Models.DataFiller;
using GymFitnessOlympic.Models.Util;

namespace GymFitnessOlympic.View.Dialog
{
    public partial class FrmNhanVienEdit : DevExpress.XtraEditors.XtraForm
    {
        NhanVien current;
        bool isThem = false;
        bool isHaveFile = false;
        public FrmNhanVienEdit(NhanVien nv = null)
        {
            InitializeComponent();
            current = nv;
            if (current != null)
            {
                Text = "Chỉnh sửa nhân viên";
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
            List<Quyen> quyens = QuyenController.GetList();
            cbbChucVu.DataSource = quyens;
            cbbChucVu.DisplayMember = "TenQuyen";
            cbbChucVu.ValueMember = "MaQuyen";
            cbbPhong.Properties.NullText = "Vui lòng chọn một phòng";
            cbbChucVu.SelectedIndex = 1;
        }

        private void loadField()
        {

            txtDiaChi.Text = current.DiaChi;
            txtSoDienThoai.Text = current.SoDienThoai;
            txtTenNhanVien.Text = current.TenNhanVien;
            txtUserName.Text = current.UserName;
            cbbPhong.EditValue = current.PhongTap.MaPhongTap;
            txtSoDienThoai.Text = current.SoDienThoai;
            radNam.Checked = current.GioiTinh;
            if (current.Anh != null)
            {
                imgAnh.Image = StreamUtilities.byteArrayToImage(current.Anh);
            }
            cbbPhong.EditValue = current.PhongTap.MaPhongTap;
            cbbChucVu.SelectedValue = current.Quyen.MaQuyen;
            btnSave.Text = "Cập nhật";
            Text = "Chỉnh sửa hội viên";
            if (current.GioiTinh)
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbbPhong.GetSelectedDataRow() == null) {
                //cbbPhong.ShowPopup();
                //cbbPhong.Focus();
                //return;
            }
            if (dxValidationProvider1.Validate())
            {
                current = prepareNhanVien();
                if (isThem)
                {
                    if (NhanVienController.Add(current) == CODE_RESULT_RETURN.ThanhCong)
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
                    if (NhanVienController.Update(current) == CODE_RESULT_RETURN.ThanhCong)
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
        }

        NhanVien prepareNhanVien()
        {
            if (current == null)
            {
                current = new NhanVien()
                {
                    Password = "123456"
                };
                current.Password = CryptoMd5.MD5Hash(current.Password);
            }
            current.DiaChi = txtDiaChi.Text.Trim();
            current.SoDienThoai = txtSoDienThoai.Text.Trim();
            current.TenNhanVien = txtTenNhanVien.Text.Trim();
            current.UserName = txtUserName.Text.Trim();
            //current.Password = "123456";
            current.Quyen = (Quyen)cbbChucVu.SelectedItem;
            current.PhongTap = (PhongTap)cbbPhong.GetSelectedDataRow();

            var o = cbbPhong.GetSelectedDataRow();
            if (isHaveFile)
            {
                String fileName = opd.FileName;
                Bitmap bmp = new Bitmap(fileName);
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                byte[] bimage = new byte[fs.Length];
                fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                fs.Close();

                byte[] Photo = bimage;
                current.Anh = Photo;
            }
            var phong = (PhongTap)cbbPhong.GetSelectedDataRow();
            current.PhongTap = phong;
            return current;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imgAnh_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void imgAnh_MouseClick(object sender, MouseEventArgs e)
        {
            if (opd.ShowDialog() == DialogResult.OK)
            {
                imgAnh.Image = Image.FromFile(opd.FileName);
                isHaveFile = true;
            }
        }
    }
}