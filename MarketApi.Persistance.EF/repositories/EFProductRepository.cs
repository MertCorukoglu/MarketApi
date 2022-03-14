using MarketApi.Core;
using MarketApi.Domain.models;
using MarketApi.Domain.repositories;
using MarketApi.Persistance.EF.contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Persistance.EF.repositories
{
    public class EFProductRepository :EFBaseRepository<Product, AppDbContext>, IProductRepository
    {
        public EFProductRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
