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
    public class EFCampaignRepository : EFBaseRepository<Campaign,AppDbContext>, ICampaingRepository
    {
        public EFCampaignRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
