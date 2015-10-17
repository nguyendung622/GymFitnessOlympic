using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymFitnessOlympic.Models;
using GymFitnessOlympic.View.Systems;
using GymFitnessOlympic.View.UserControls;

namespace GymFitnessOlympic.View
{
    public partial class FormMain : Form
    {
        public static AppUser NguoiSuDung { get; private set; }

        public FormMain()
        {
            InitializeComponent();
            LoadUcWelcome();
        }

        #region Private method
        public void LoadUcWelcome()
        {
            var ucWelcome = new Welcome();
            ucWelcome.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ucWelcome);
        }
        public void Logout()
        {
            FormMain.NguoiSuDung = null;
            lblLoginStatus.Text = "Chưa đăng nhập";
            LoadUcWelcome();
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
            frm.ShowDialog();
        }
    }
}
