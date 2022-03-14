using MarketApi.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketApi.API.Modals
{
    public class CreateCampaignInputModel
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal CampaignPrice { get; set; }

    }
}
