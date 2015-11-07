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
    public partial class FrmHoiVienEdit : DevExpress.XtraEditors.XtraForm
    {
        bool isThem = false;
        HoiVien current;
        bool isHaveFile = false;

        public FrmHoiVienEdit(HoiVien h = null)
        {
            InitializeComponent();
            current = h;
            if (current != null)
            {
                Text = "Chỉnh sửa hội viên";
                loadField();
                isThem = false;
                cbbPhong.Enabled = false;
            }
            else {
                isThem = true;
                getMa();
            }
            cbbPhong.Properties.NullText = "Chọn một phòng tập";
            DataFiller.fillPhongCombo(cbbPhong);
        }

        void getMa() {
           // txtMaSauna.Text = Guid.NewGuid().ToString();
            txtMaHoiVien.Text = Guid.NewGuid().ToString();
        }

        private void loadField()
        {

            txtDiaChi.Text = current.DiaChi;
            txtHoTen.Text = current.TenHoiVien;
            txtMaHoiVien.Text = current.MaGYM;
            //txtMaSauna.Text = current.MaSauna;
            txtSoDienThoai.Text = current.SoDienThoai;
            datNgaySinh.DateTime = current.NgaySinh;
            if (current.Anh != null) {
                pictureEdit1.Image = StreamUtilities.byteArrayToImage(current.Anh);
            }
            cbbPhong.EditValue = current.PhongTap.MaPhongTap;
            btnAdd.Text = "Cập nhật";
            Text = "Chỉnh sửa hội viên";
            if (current.GioiTinh)
            {
                radNam.Checked =true;
            }
            else {
                radNu.Checked = true;
            }
        }


        HoiVien prepareHoiVien()
        {
          
                HoiVien hv = new HoiVien()
                {
                    TenHoiVien = txtHoTen.Text.Trim(),
                    GioiTinh = radNam.Checked,
                    NgaySinh = datNgaySinh.DateTime,
                    SoDienThoai = txtSoDienThoai.Text.Trim(),
                    DiaChi = txtDiaChi.Text,
                    MaGYM = txtMaHoiVien.Text,
                    NgayHetHanGYM = DateTime.Now,
                    NgayHetHanSauNa = DateTime.Now,
                };
                if (isHaveFile) {
                    String fileName = opd.FileName;
                    Bitmap bmp = new Bitmap(fileName);
                    FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    byte[] bimage = new byte[fs.Length];
                    fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                    fs.Close();

                    byte[] Photo = bimage;
                    hv.Anh = Photo;
                }
                var phong = (PhongTap)cbbPhong.GetSelectedDataRow();
                hv.PhongTap = phong;
                return hv;
            
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
           //txtSoDienThoai.rul
            if (dxValidationProvider1.Validate())
            {
                current = prepareHoiVien();
                if (isThem)
                {
                    if (HoiVienController.Add(current) == CODE_RESULT_RETURN.ThanhCong)
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
                    if (HoiVienController.Update(current) == CODE_RESULT_RETURN.ThanhCong)
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
            pictureEdit1.Image = Image.FromFile(fileName);
            isHaveFile = true;
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
            opd.ShowDialog();
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