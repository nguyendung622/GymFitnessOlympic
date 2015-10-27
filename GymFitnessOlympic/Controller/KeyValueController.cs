using GymFitnessOlympic.Models;
using QldtSdh.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymFitnessOlympic.Controller
{
    class KeyValueController
    {
        internal static List<KeyValueConfig> GetList()
        {
            using (var context = DBContext.GetContext())
            {
                var nvs = context.KeyValueDbSet;
                return nvs.ToList();
            }
        }

        internal static string Get(string key)
        {
            using (var context = DBContext.GetContext())
            {
                var nv = context.KeyValueDbSet.FirstOrDefault(n => n.Key == key);
                return nv.Value;
            }
        }


        internal static CODE_RESULT_RETURN Set(String key, String value)
        {
            using (var context = DBContext.GetContext())
            {
                try
                {
                    var n1 = context.KeyValueDbSet.FirstOrDefault(n => n.Key == key);
                    if (n1 != null)
                    {
                        n1.Value = value;
                        context.SaveChanges();
                        return CODE_RESULT_RETURN.ThanhCong;
                    }
                    else
                    {
                        KeyValueConfig kv = new KeyValueConfig();
                        kv.Key = key;
                        kv.Value = value;
                        context.KeyValueDbSet.Add(kv);
                        context.SaveChanges();
                        return CODE_RESULT_RETURN.ThanhCong;
                    }
                    return CODE_RESULT_RETURN.MaTrung;
                }
                catch
                {
                    return CODE_RESULT_RETURN.ThatBai;
                }
            }
        }


        internal static CODE_RESULT_RETURN Delete(string key)
        {
            using (var context = DBContext.GetContext())
            {
                var pt = context.KeyValueDbSet.FirstOrDefault(p => p.Key == key);
                if (pt != null)
                {
                    context.KeyValueDbSet.Remove(pt);
                    context.SaveChanges();
                    return CODE_RESULT_RETURN.ThanhCong;
                }
                return CODE_RESULT_RETURN.ThatBai;
            }
        }
    }
}
