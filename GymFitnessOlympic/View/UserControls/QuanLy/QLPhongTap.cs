using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.UserControls
{
    public partial class QLPhongTap : UserControl
    {
        public QLPhongTap()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = btnEdit.Visible = btnDelete.Visible = false;
            btnSave.Visible = btnCancel.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = btnEdit.Visible = btnDelete.Visible = false;
            btnSave.Visible = btnCancel.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = btnEdit.Visible = btnDelete.Visible = true;
            btnSave.Visible = btnCancel.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = btnEdit.Visible = btnDelete.Visible = true;
            btnSave.Visible = btnCancel.Visible = false;
        }
    }
}
