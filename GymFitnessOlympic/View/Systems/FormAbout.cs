using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GymFitnessOlympic.View.Systems
{
    partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            this.ActiveControl = btnClose;
            lblVersion.Text = "Phiên bản: " + Application.ProductVersion;
        }
    }
}
