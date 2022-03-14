using MarketApi.Domain.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Persistance.EF.contexts
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {

        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=MarketApi;Trusted_Connection=true");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
    public class AppDbContext :DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<CampaignProduct> CampaignProducts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions):base(dbContextOptions)
        {

        }
    }
}
