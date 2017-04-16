using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using School.Models;
using School.Areas.Menu2A.Models;

namespace School.DAL
{
    public class DefaultConnection : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MenuModal>().ToTable("tblMenu");
            modelBuilder.Entity<Menu2Model>().ToTable("tblAddClass");


        }
        public DbSet<MenuModal> Menus { get; set; }

        public DbSet<Menu2Model> Menu2Model { get; set; }
    }
}