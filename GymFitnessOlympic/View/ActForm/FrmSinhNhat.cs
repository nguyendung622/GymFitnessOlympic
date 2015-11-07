using GymFitnessOlympic.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.ActForm
{
    public partial class FrmSinhNhat : UserControl
    {
        public FrmSinhNhat()
        {
            InitializeComponent();
        }

        private void FrmSinhNhat_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData() {
            dataGridView1.AutoGenerateColumns = false;
            var hs = HoiVienController.GetComingBirthDay();
            dataGridView1.DataSource = hs;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
