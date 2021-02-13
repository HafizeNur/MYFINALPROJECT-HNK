using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    //Context:Veri tabanı tabloları ile proje classlarını bağlar
    //İndirdiğimiz paketteki efcore ile ilişkilendirmek gerekir.Context sınıfı olduğunu tanıtmamız lazım.
    public class NorthwindContext:DbContext
    {
        //Hangi veritabanı ile ilişkilendireceğimizi belirtir.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-PJQL535\SQLEXPRESS;Database=Northwind;Trusted_Connection=true");
           optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
          ///  base.OnConfiguring(optionsBuilder);
        }
        //Hangi nesnem neye karsılık gelecek.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
