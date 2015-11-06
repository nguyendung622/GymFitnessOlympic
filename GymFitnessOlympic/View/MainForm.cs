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

namespace GymFitnessOlympic.View
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static AppUser User { get; private set; }
        public MainForm()
        {
            InitializeComponent();
            //ribbonControl.SelectedPage = rbTabManager;
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
            rbBtnChangePassword.Enabled = false;
            rbBtnRole.Enabled = false;
            rbTabManager.Visible = rbTabOperator.Visible = rbTabStatistics.Visible = false;
            LoadUcWelcome();
        }
        public void Login(AppUser user)
        {
            #region Cập nhật giao diện
            MainForm.User = user;

            lblLoginStatus.Text = string.Format("Đã đăng nhập ({0} - {1})",
                MainForm.User.UserName, MainForm.User.Role);
            var isAdmin = user.Role == (int)VAITRO.Admin;
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

        private void rbBtnAbout_Click(object sender, EventArgs e)
        {
            var frm = new FormAbout();
            frm.ShowDialog();
        }

        private void rbBtnLogin_Click(object sender, EventArgs e)
        {
            var frm = new FormLogin();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Login(frm.User);
            }
        }

        private void rbBtnLogout_Click(object sender, EventArgs e)
        {
            if (GymFitnessOlympic.View.Utils.DialogUtils.ShowOKCancel("Bạn có chắc chắn muốn đăng xuất không?") == System.Windows.Forms.DialogResult.OK)
            {
                Logout();
            }
        }

        private void ribbonOrbOptionButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbBtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void rbBtnChangePassword_Click(object sender, EventArgs e)
        {
            var frm = new FormChangePassword(User);
            frm.ShowDialog();
        }

        private void rbBtnQLPhongTap_Click(object sender, EventArgs e)
        {
            var UC = new QLPhongTap();
            LoadUC(UC);
        }

        private void rbBtnQLNhanVien_Click(object sender, EventArgs e)
        {
            var UC = new QLNhanVien();
            LoadUC(UC);
        }

        private void rbBtnQLHoiVien_Click(object sender, EventArgs e)
        {
            var UC = new QLHoiVien();
            LoadUC(UC);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUcWelcome();
        }
    }
}
