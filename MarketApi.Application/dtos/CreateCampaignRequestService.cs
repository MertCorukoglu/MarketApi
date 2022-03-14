using MarketApi.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Application.dtos
{
    public class CreateCampaignRequestService
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public List<Product> Products { get; set; }
    }
}
