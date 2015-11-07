using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using GymFitnessOlympic.View.Systems;
using GymFitnessOlympic.View.UserControls;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.Controller;
using GymFitnessOlympic.View.MainForms;
using GymFitnessOlympic.View.ActForm;
using GymFitnessOlympic.View.Dialog;
using GymFitnessOlympic.View.ActForm.ThongKe;
using TanHongPhat;
using GymFitnessOlympic.Models.Util;
using GymFitnessOlympic.View.UserControls.QuanLy;

namespace GymFitnessOlympic.View
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static NhanVien User { get; private set; }
        public MainForm()
        {
            InitializeComponent();
            Logout();
        }
        #region Private method
        public void LoadUcWelcome()
        {
            var ucWelcome = new Welcome();
            ucWelcome.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ucWelcome);
        }
        public void LoadUC(UserControl ucContent)
        {
            pnMain.Controls.Clear();
            ucContent.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ucContent);
        }
        public void Logout()
        {
            MainForm.User = null;
            lblLoginStatus.Text = "Chưa đăng nhập";
            rbBtnLogout.Enabled = rbBtnLogoutQuick.Enabled = false;
            rbBtnLogin.Enabled = true;
            rbBtnChangePassword.Enabled = false;
            rbBtnRole.Enabled = false;
            rbTabManager.Visible = rbTabOperator.Visible = rbTabStatistics.Visible = false;
            pnMain.Controls.Clear();
            LoadUcWelcome();
        }
        public void Login(NhanVien user)
        {
            #region Cập nhật giao diện
            MainForm.User = user;

            lblLoginStatus.Text = string.Format("Đã đăng nhập ({0} - {1})",
                MainForm.User.UserName, MainForm.User.Quyen);
            var isAdmin = user.Quyen.MaQuyen == 1;
            rbBtnLogin.Enabled = rbBtnLoginQuick.Enabled = false;
            rbBtnLogout.Enabled = rbBtnLogoutQuick.Enabled = true;
            rbBtnChangePassword.Enabled = true;
            rbBtnRole.Enabled = rbTabManager.Visible = isAdmin;
            rbTabOperator.Visible = rbTabStatistics.Visible = true;
            /*
             * Phần quyền sử dụng hệ thống
             * Khi nào triển khai thì uncomment
             */
            //var myItems = BizPhanQuyen.GetItems(this.msMain);
            //var lsUser_Function = BizPhanQuyen.GetListByUser(nguoiSuDung.UserName);
            //foreach (var item in myItems)
            //{
            //    if (lsUser_Function.Contains(item.Text))
            //        item.Visible = true;
            //    else
            //        item.Visible = false;
            //}


            /*
             * Dù có phần quyền như thế nào đi nữa thì những chức năng dưới vẫn phải theo quy tắc này
             */
            /*
             * Chỉ để thuận tiện cho việc test. Khi triển khai nhớ uncoomment
             */
            //miHeThong_CauHinh.Visible = miHeThong_PhanQuyen.Visible = miHeThong_NhatKyHoatDong.Visible = miHeThong_QuanLyNguoiDung.Visible = isAdmin;

            /*
             * Khi triển khai thì comment những dòng sau
             */
            //miDuLieu.Visible = !isAdmin;
            //miDaoTao.Visible = !isAdmin;
            //miKhaoThi.Visible = !isAdmin;
            //miXetTotNghiep.Visible = !isAdmin;
            //lnkHocKy.Visible = !isAdmin;
            #endregion

            #region Nạp dữ liệu ban đầu
            // 1. Nạp danh sách Năm học, học kỳ

            // 2. SetHocKy
            #endregion
        }
        #endregion

        #region "Menu button"
        private void rbBtnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FormLogin();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                FrmChonCa chonCa = new FrmChonCa();
                if (chonCa.ShowDialog() == DialogResult.OK)
                {
                    this.Login(frm.User);
                }
                else {
                    Logout();
                }
            }
        }
        
        private void rbBtnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (GymFitnessOlympic.View.Utils.DialogUtils.ShowOKCancel("Bạn có chắc chắn muốn đăng xuất không?") == System.Windows.Forms.DialogResult.OK)
            {
                Logout();
            }
        }

        private void rbBtnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FormChangePassword(User);
            frm.ShowDialog();
        }

        private void rbBtnInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new FormAbout();
            frm.ShowDialog();
        }
        
        private void rbBtnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUcWelcome();
        }
        #region "Ribon bar button"
        private void rbBtnQLPhongTap_ItemClick(object sender, ItemClickEventArgs e)
        {
            var UC = new QLPhongTap();
            LoadUC(UC);
        }

        private void rbBtnQLNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            var UC = new QLNhanVien();
            LoadUC(UC);
        }
        #endregion

        private void rbBtnQLHoiVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUC(new QLHoiVien());
        }

        private void rbBtnQLGoiTap_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUC(new QLGoiTap());
        }

        private void rbBtnQLSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUC(new QLSanPham());
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUC(new FrmCheckinNhanVien());
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUC(new FrmCheckOutNhanVien());
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUC(new FrmCheckinHoiVien());
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUC(new FrmBanHang());
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUC(new FrmLichSuNhanVien());
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUC(new FrmLichSuHoiVien());
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUC(new FrmSinhNhat());
        }

        private void rbBtnQLPhieuThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            var pt = new FrmLichSuPhieuThu();
            LoadUC(pt);
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rbBtnThongKeHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUC(new FrmLichSuHoaDon());
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            var acc = Login1.GetTaiKhoanHienTai();
            LoadUC(new FrmLichSuPhieuThu(acc ));
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUC(new FrmLichSuHoaDon(Login1.TaiKhoanHienTai));
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUC(new FrmBanHang());
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUC(new FrmBanHang(isNhap:true));
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadUC(new FrmKiemKho());
        }
    }
}
