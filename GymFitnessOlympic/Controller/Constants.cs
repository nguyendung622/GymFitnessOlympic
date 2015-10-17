using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymFitnessOlympic.Controller
{
    public enum CODE_RESULT_RETURN
    {
        ThanhCong,
        MaTrung,
        TenTrung,
        ThatBai
    }

    public enum VAITRO
    {
        ChuyenVien,
        Admin
    }

    public enum KHOIKIENTHUC
    {
        KIENTHUCCHUNG = 0,
        KIENTHUCCOSO = 1,
        KIENTHUCCHUYENNGANH = 2,
        KHOALUANTOTNGHIEP = 3
    }

    public enum LOAITHAOTAC
    {
        Thêm,
        Xóa,
        Chỉnh_sửa
    }

    public enum LOAIDOITUONG
    {

    }



    public class EnumWithName<T>
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public static List<EnumWithName<T>> ParseEnum()
        {
            List<EnumWithName<T>> list = new List<EnumWithName<T>>();

            foreach (object o in Enum.GetValues(typeof(T)))
            {
                list.Add(new EnumWithName<T>
                {
                    Name = Enum.GetName(typeof(T), o).Replace('_', ' '),
                    Value = (int)o
                });
            }

            return list;
        }
        public static string GetName(T objEnum)
        {
            try
            {
                return Enum.GetName(typeof(T), objEnum).Replace('_', ' ');
            }
            catch
            {
                return "Không tìm thấy";
            }
        }
    }
    public class ERROR_CONSTANT_STRING
    {
        /// <summary>
        /// Mã trùng
        /// </summary>
        public static string LOI_MATRUNG = "Mã {0} trùng";
        /// <summary>
        /// Mã rỗng
        /// </summary>
        public static string LOI_MARONG = "Mã {0} rỗng";
        /// <summary>
        /// Tên trùng
        /// </summary>
        public static string LOI_TENTRUNG = "Tên {0} trùng";
        /// <summary>
        /// Tên rỗng
        /// </summary>
        public static string LOI_TENRONG = "Tên {0} rỗng";
        /// <summary>
        /// Thêm lỗi
        /// </summary>
        public static string LOI_THEM = "Không thể thêm {0} lúc này";
        /// <summary>
        /// Cập nhật lỗi
        /// </summary>
        public static string LOI_CAPNHAT = "Không thể cập nhật {0} lúc này";
        /// <summary>
        /// Xóa lỗi
        /// </summary>
        public static string LOI_XOA = "Không thể xóa {0} lúc này";
        /// <summary>
        /// Danh sách rỗng
        /// </summary>
        public static string LOI_DANHSACHRONG = "Danh sách {0} rỗng";
        /// <summary>
        /// Lỗi chưa chọn 1 mục trong danh sách
        /// </summary>
        public static string LOI_NOTYET_SELECT_ITEM = "Bạn chưa chọn {0}";
        /// <summary>
        /// Một trường nào đó trống
        /// </summary>
        public static string LOI_FIELD_EMPTY = "Dữ liệu trống";

        public static string LOI_NUMBER_FORMAT = "Bạn phải nhập số";
    }

    public class ENTITY_NAME
    {
        public static string APPUSER = "Người sử dụng";
    }

    public class TITLE_FORM_DETAIL
    {
        public static string ADDNEW = "Thêm mới {0}";
        public static string EDIT = "Cập nhật {0}";
    }

    public class NOTIFY_CONSTANT_STRING
    {
        /// <summary>
        /// Thông báo xác nhận xóa
        /// </summary>
        public static string DELETE = "Bạn có chắc muốn xóa";
    }

    public class InvalidNameException : Exception
    {
        public InvalidNameException(string msg) : base(msg) { }
    }

    public class InvalidObjectException : Exception
    {
        public InvalidObjectException(string msg) : base(msg) { }
    }
}
