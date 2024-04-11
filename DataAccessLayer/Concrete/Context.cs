using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Bu yöntem, DbContext sınıfının yapılandırılmasını sağlar ve DbContextOptionsBuilder nesnesini kullanarak bağlantı seçeneklerini belirtir.
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-2PUE7SMB;initial Catalog=information_about_the_plant_Db;integrated Security=true;TrustServerCertificate=True;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Galery> Galeries {  get; set; }
        public DbSet<Vision> Visions { get; set; }
        public DbSet<AllUsers> AllUsers { get; set; }
    }
}
