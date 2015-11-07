using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using GymFitnessOlympic.Models.Util;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace GymFitnessOlympic.Controller
{
    class NhanVienController
    {
        internal static List<NhanVien> GetList(int phongID = -1)
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.NhanVien.Include(n => n.PhongTap).Include(n=>n.Quyen);
                if (phongID != -1)
                {
                    nvs = nvs.Where(n => n.PhongTap.MaPhongTap == phongID);
                }
                return nvs.ToList();
            }
        }


        internal static NhanVien GetByID(int maSP = -1)
        {
            using (var context = DBContext.GetContext())
            {
                if (maSP == -1)
                    return context.NhanVien.FirstOrDefault();
                var nv = context.NhanVien.FirstOrDefault(n => n.MaNhanVien == maSP);
                return nv;
            }
        }

        public static PhongTap GetPhong(int maNV) {
            using (var context = DBContext.GetContext())
            {
                var nv = context.PhongTap.FirstOrDefault(p=>p.DanhSachNhanVien.Select(n=>n.MaNhanVien).Contains(maNV));
                return nv;
            } 
        }

        internal static NhanVien GetByMaThe(string maSP)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.NhanVien.Include(n => n.PhongTap).FirstOrDefault(n => n.MaThe == maSP);
                return nv;
            }
        }

        internal static bool IsCheckedIn(string maSP)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.HistoryNhanVien.OrderByDescending(h=>h.ThoiGian).FirstOrDefault(n => n.NhanVien.MaThe == maSP);
                return (nv!=null && nv.IsCheckin);
                
            }
        }

        internal static bool IsCheckedOut(string maSP)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.HistoryNhanVien.OrderByDescending(h => h.ThoiGian).FirstOrDefault(n => n.NhanVien.MaThe == maSP);
                return (nv == null ||  !nv.IsCheckin);

            }
        }


        internal static CODE_RESULT_RETURN Add(NhanVien nv)
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    var n1 = context.NhanVien.FirstOrDefault(n => n.MaNhanVien == nv.MaNhanVien);
                    if (n1 == null)
                    {
                        //nv.Password = CryptoMd5.MD5Hash(nv.Password);
                        var quyen = context.Quyen.Find(nv.Quyen.MaQuyen);
                        var phong = context.PhongTap.Find(nv.PhongTap.MaPhongTap);
                        nv.Quyen = quyen;
                        nv.PhongTap = phong;
                        context.NhanVien.Add(nv);
                        context.SaveChanges();
                        return CODE_RESULT_RETURN.ThanhCong;
                    }
                    return CODE_RESULT_RETURN.MaTrung;
                }
                catch (DbEntityValidationException dbEx) {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}",
                                                    validationError.PropertyName,
                                                    validationError.ErrorMessage);
                        }
                    }
                    return CODE_RESULT_RETURN.ThatBai;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return CODE_RESULT_RETURN.ThatBai;
                }
            }
        }

        internal static CODE_RESULT_RETURN Update(NhanVien hv)
        {
            using (var db = DBContext.GetContext())
            {
                var hvc = db.NhanVien.FirstOrDefault(h => h.MaNhanVien == hv.MaNhanVien);
                if (hvc != null)
                {
                    hvc.TenNhanVien = hv.TenNhanVien;
                    hvc.UserName = hv.UserName;
                    if (hv.PhongTap != null)
                    {
                        var phongMoi = db.PhongTap.FirstOrDefault(p => p.MaPhongTap == hv.PhongTap.MaPhongTap);
                        hvc.PhongTap = phongMoi;
                    }
                    var quyen = db.Quyen.Find(hv.Quyen.MaQuyen);
                    hvc.Quyen = quyen;
                    hvc.SoDienThoai = hv.SoDienThoai;
                    hvc.DiaChi = hv.DiaChi;
                    hvc.Password = hvc.Password;
                    hvc.Anh = hv.Anh;
                    db.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        internal static CODE_RESULT_RETURN Delete(int id)
        {
            using (var context = DBContext.GetContext())
            {
                var pt = context.NhanVien.FirstOrDefault(p => p.MaNhanVien == id);
                if (pt != null)
                {
                    context.NhanVien.Remove(pt);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

       static string maHoa(String s) {
            return s;
        }

        internal static NhanVien Login(string tenDangNhap, string matKhau)
        {
            var hash = CryptoMd5.MD5Hash(matKhau);
            using (var context = DBContext.GetContext())
            {
                var pt = context.NhanVien.Include(n=>n.Quyen).FirstOrDefault(p => p.UserName == tenDangNhap &&   p.Password ==hash);
                return pt;
            }
        }

        internal static void ChangePassword(NhanVien m_NguoiSuDung, string matKhauMoi)
        {
            using (var db = DBContext.GetContext())
            {
                NhanVien nguoiSuDung = db.NhanVien.Where(
                    nsd => nsd.UserName == m_NguoiSuDung.UserName &&
                        nsd.Password == m_NguoiSuDung.Password).FirstOrDefault();
                if (nguoiSuDung == null)
                    throw new Exception("Thông tin người sử dụng không đúng!");
                else
                {
                    try
                    {
                        nguoiSuDung.Password =CryptoMd5.MD5Hash( matKhauMoi);
                        db.SaveChanges();
                    }
                    catch
                    {
                        throw new Exception("Không thể thay đổi mật khẩu được!");
                    }
                }
            }
        }

        internal static NhanVien GetFirst()
        {
            using (var db = DBContext.GetContext()) {
                return db.NhanVien.FirstOrDefault();
            }
        }
    }
}
