using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System;
using GymFitnessOlympic.Utils;

namespace QldtSdh.DAL.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection = false)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public static DBContext GetContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection = false)
        {
            return new DBContext(existingConnection, contextOwnsConnection);
        }

        public static DBContext GetContext()
        {
            //var defaultContext = new DAL.Models.CEMS4UG_DHKHContext();
            //return defaultContext;
            System.Diagnostics.Debug.WriteLine("Bắt đầu tạo DbContext " + System.DateTime.Now.ToString("hh:MM:ss"));
            System.Data.Common.DbConnection dbConnection = null;
            try
            {
                var dbProviderFactory = System.Data.Common.DbProviderFactories.GetFactory("System.Data.Sqlclient");
                dbConnection = dbProviderFactory.CreateConnection();
                dbConnection.ConnectionString = ConnectionUtils.AppDbConnection;
                dbConnection.Open();
                System.Diagnostics.Debug.WriteLine("Đã tạo xong dbConnection " + System.DateTime.Now.ToString("hh:MM:ss"));
                var context = new DBContext();
                System.Diagnostics.Debug.WriteLine("Đã tạo xong DbContext " + System.DateTime.Now.ToString("hh:MM:ss"));
                return new DBContext(dbConnection, true);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tạo DbContext SDH " + ex);
            }
        }
    }
}