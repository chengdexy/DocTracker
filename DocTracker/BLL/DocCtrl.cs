using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocTracker.DAL;
using DocTracker.Model;

namespace DocTracker.BLL
{

    static class DocCtrl
    {
        private static MainContext db = new MainContext();

        //添加一个新公文
        internal static void Add(Doc doc)
        {
            db.Docs.Add(doc);
            db.SaveChanges();
        }

        //删除指定id的doc
        internal static void Delete(int id)
        {
            if (Exist(id))
            {
                db.Docs.Remove(Find(id));
                db.SaveChanges();
            }
        }
        
        //修改数据库中的doc为参数传递来的doc
        internal static void Modify(Doc doc)
        {
            db.Entry(doc).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        //返回指定id的doc
        internal static Doc Find(int id)
        {
            return db.Docs.Find(id);
        }

        //指定id的doc是否存在
        internal static bool Exist(int id)
        {
            return Find(id) != null;
        }

        //返回最新的一个doc
        internal static Doc Last()
        {
            return db.Docs.OrderByDescending(od => od.ID).FirstOrDefault();
        }

        //返回所有doc的list
        internal static List<Doc> List()
        {
            return db.Docs.ToList();
        }




    }
}
