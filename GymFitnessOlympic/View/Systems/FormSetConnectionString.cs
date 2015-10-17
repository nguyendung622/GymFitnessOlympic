using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;
using GymFitnessOlympic.Utils;
using GymFitnessOlympic.View.Utils;

namespace GymFitnessOlympic.View.Systems
{
    public partial class FormSetConnectionString : Form
    {
        public FormSetConnectionString()
        {
            InitializeComponent();
            this.ActiveControl = txtUserName;
        }

        private string ConnectionStringOnGUI
        {
            get
            {
                var connectionString = string.Format("Data Source={0};Initial Catalog={1};User={2};Password={3};MultipleActiveResultSets=True;persist security info=True;",
                    txtDBServer.Text.Trim(), txtDBName.Text.Trim(), txtUserName.Text, txtPassword.Text);
                return connectionString;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionUtils.WriteConnectionString(ConnectionStringOnGUI);
                this.Close();
            }
            catch (Exception exc)
            {
                DialogUtils.ShowMessage("Không lưu được thông tin kết nối! Lỗi " + exc.Message);
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection tmpConn = new SqlConnection();
                tmpConn.ConnectionString = string.Format("Data Source={0};Initial Catalog={1};User={2};Password={3};MultipleActiveResultSets=True",
                       txtDBServer.Text.Trim(), "master", txtUserName.Text, txtPassword.Text);
                tmpConn.Open();
                if (CheckDatabaseExists(tmpConn))
                {
                    DialogUtils.ShowMessage("Kết nối thành công");
                    //btnOK.Enabled = true;
                }
                else
                {
                    DialogUtils.ShowError("Lỗi.\nKhông thể kết nối đến CSDL");
                }
            }
            catch (Exception exc)
            {
                DialogUtils.ShowError("Lỗi.\nChi tiết lỗi: " + exc.Message);
            }
        }

        private bool CheckDatabaseExists(SqlConnection tmpConn)
        {
            string sqlCreateDBQuery;
            bool rs = false;
            try
            {
                if (chk2005.Checked)
                    sqlCreateDBQuery = string.Format("SELECT count(*) FROM master.dbo.sysdatabases WHERE Name = '{0}'", txtDBName.Text);
                else
                    sqlCreateDBQuery = string.Format("SELECT count(*) FROM sys.databases WHERE Name = '{0}'", txtDBName.Text);
                var sqlCmd = new SqlCommand(sqlCreateDBQuery, tmpConn);
                int databaseID = (int)sqlCmd.ExecuteScalar();
                return rs = databaseID > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối server! Chi tiết: " + ex.Message);
            }
        }

        private void btnQuitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
