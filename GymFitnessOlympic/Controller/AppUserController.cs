using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using GymFitnessOlympic.Models;

namespace GymFitnessOlympic.Controller
{
    class AppUserController
    {
        internal static AppUser GetUser(string userName, string passWord)
        {
            if (userName == null || passWord == null)
                return null;
            userName = userName.ToLower();
            using (var context = DBContext.GetContext())
            {
                var au = context.AppUserDbSet.Where(e => e.UserName.ToLower() == userName && e.Password == passWord).FirstOrDefault();
                return au;
            }

        }
        internal static AppUser GetUser(string userName)
        {
            if (userName == null)
                return null;
            userName = userName.ToLower();
            using (var context = DBContext.GetContext())
            {
                var au = context.AppUserDbSet.Where(e => e.UserName.ToLower() == userName).FirstOrDefault();
                return au;
            }
        }

        public static List<AppUser> GetList(bool isOnlyActive = false)
        {
            using (var db = DBContext.GetContext())
            {
                if (isOnlyActive)
                    return db.AppUserDbSet.Where(e => e.IsActive == true).OrderBy(e => e.FullName).ToList();
                else
                    return db.AppUserDbSet.OrderBy(e => e.UserName).ToList();
            }
        }

        internal static void ChangePassword(AppUser m_NguoiSuDung, string matKhauMoi)
        {
            using (var db = DBContext.GetContext())
            {
                AppUser nguoiSuDung = db.AppUserDbSet.Where(
                    nsd => nsd.UserName == m_NguoiSuDung.UserName &&
                        nsd.Password == m_NguoiSuDung.Password).FirstOrDefault();
                if (nguoiSuDung == null)
                    throw new Exception("Thông tin người sử dụng không đúng!");
                else
                {
                    try
                    {
                        nguoiSuDung.Password = matKhauMoi;
                        db.SaveChanges();
                    }
                    catch
                    {
                        throw new Exception("Không thể thay đổi mật khẩu được!");
                    }
                }
            }
        }

        internal static CODE_RESULT_RETURN Update(AppUser user)
        {
            using (var db = DBContext.GetContext())
            {
                var ds = (from e in db.AppUserDbSet
                          where e.UserName == user.UserName
                          select e).SingleOrDefault();
                if (ds != null)
                {
                    ds.FullName = user.FullName;
                    ds.Password = user.Password;
                    ds.Role = user.Role;
                    ds.IsActive = user.IsActive;
                    db.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }

        internal static CODE_RESULT_RETURN Add(AppUser user)
        {
            using (var context = DBContext.GetContext())
            {
                var ds = (from e in context.AppUserDbSet
                          where e.UserName == user.UserName
                          select e).SingleOrDefault();
                if (ds != null)
                    return CODE_RESULT_RETURN.MaTrung;
                else
                {
                    context.AppUserDbSet.Add(user);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
            }
        }

        internal static CODE_RESULT_RETURN Delete(AppUser user)
        {
            using (var context = DBContext.GetContext())
            {
                var nsd = (from e in context.AppUserDbSet
                           where e.UserName == user.UserName
                           select e).SingleOrDefault();
                if (nsd != null)
                {
                    try
                    {
                        context.AppUserDbSet.Remove(nsd);
                        context.SaveChanges();
                        return CODE_RESULT_RETURN.ThanhCong;
                    }
                    catch
                    {
                        return CODE_RESULT_RETURN.ThatBai;
                    }
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }
    }
}
