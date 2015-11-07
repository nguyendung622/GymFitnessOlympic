using GymFitnessOlympic.Controller;
using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.Dialog
{
    public partial class FrmCaList : Form
    {
        public FrmCaList()
        {
            InitializeComponent();
            dgrCa.AutoGenerateColumns = false;
            loadData();
        }

        void loadData() {
            List<CaLamViec> li = CaLamViecController.GetList();
            
            dgrCa.DataSource = li;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgrCa.SelectedRows.Count > 0)
            {
                var c = (CaLamViec)dgrCa.SelectedRows[0].DataBoundItem;
                FrmCaEdit f = new FrmCaEdit(c);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    loadData();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn ca");
            }
        }
    }
}
