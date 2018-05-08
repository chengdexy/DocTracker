using DocTracker.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//MainContext.cs
namespace DocTracker.DAL
{
    class MainContext : DbContext
    {
        public MainContext() : base("MainContext")
        {

        }

        public DbSet<Doc> Docs { get; set; }
        public DbSet<Oper> Opers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doc>().HasMany(d => d.Opers)
                .WithRequired(op => op.Doc);

            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
