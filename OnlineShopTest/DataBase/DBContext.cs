using Microsoft.EntityFrameworkCore;
using OnlineShopTest.Models;


namespace OnlineShopTest.DataBase
{
    public class DBContext : DbContext
    {
        public virtual DbSet<CustomerModel> Customers { get; set; }

        public virtual DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-0TBMFCS;initial catalog=ShopTest;trusted_connection=true;TrustServerCertificate=True");
        }

    }

}
