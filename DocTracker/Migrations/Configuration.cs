namespace DocTracker.Migrations
{
    using DocTracker.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DocTracker.DAL.MainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DocTracker.DAL.MainContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var docs = new List<Doc>();
            var doc = new Doc
            {
                Title = "测试公文",
                Copies = 15,
                DocNumber = "测试发[2018]1号",
                ReceiveDate = DateTime.Now,
                Remark = "这里市备注",
                Scope = "测试组,政府,区委,政协",
                SecretLv = SecretLevel.NormalSecret, //秘密
                SendDate = DateTime.Now,
                YearNumber = 2018,
                Opers = new List<Oper>()
            };
            var oper = new Oper
            {
                DocID = 1,
                Name = "操作1"
            };
            doc.Opers.Add(oper);
            docs.Add(doc);
            docs.ForEach(d => context.Docs.AddOrUpdate(od => od.Title, d));
            context.SaveChanges();
        }
    }
}
