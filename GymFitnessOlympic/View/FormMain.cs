using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GymFitnessOlympic.View.UserControls;

namespace GymFitnessOlympic.View
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            var ucWelcome = new Welcome();
            ucWelcome.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ucWelcome);
        }
    }
}
