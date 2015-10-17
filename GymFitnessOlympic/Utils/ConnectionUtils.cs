using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Utils
{
    class ConnectionUtils
    {
        /// <summary>
        /// Lấy chuỗi kết nối
        /// </summary>
        public static string AppDbConnection
        {
            get
            {
                var connectionString = ReadConnectionString();
                if (connectionString == null)
                    return ConfigurationManager.ConnectionStrings["DBContext"].ConnectionString;
                else
                    return connectionString;
            }
        }

        /// <summary>
        /// Đọc chuỗi kết nối từ file
        /// </summary>
        /// <returns></returns>
        public static string ReadConnectionString()
        {
            var appPath = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            var configPath = System.IO.Path.Combine(appPath, "appConnection.bin");
            if (System.IO.File.Exists(configPath) == false)
                return null;
            using (var sr = new System.IO.StreamReader(configPath))
            {
                var st = sr.ReadToEnd();
                var st2 = "";
                for (int i = 0; i < st.Length; i++)
                    st2 += Convert.ToChar(Convert.ToInt32(st[i]) - 255);
                sr.Close();
                return st2;
            }
        }

        /// <summary>
        /// Ghi chuỗi kết nối xuống file theo dạng được mã hóa
        /// </summary>
        /// <param name="st"></param>
        public static void WriteConnectionString(string st)
        {
            //string folderPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "QLHP");
            var appPath = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            var configPath = System.IO.Path.Combine(appPath, "appConnection.bin");
            using (var sw = new System.IO.StreamWriter(configPath))
            {
                var st2 = "";
                for (int i = 0; i < st.Length; i++)
                    st2 += Convert.ToChar(Convert.ToInt32(st[i]) + 255);
                sw.Write(st2);
                sw.Close();
            }
        }
    }
}
