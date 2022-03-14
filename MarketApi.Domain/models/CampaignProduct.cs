using MarketApi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Domain.models
{
    public class CampaignProduct : Entity
    {


        public string ProductId { get; set; }
        public string CampaignId { get; set; }

        public CampaignProduct()
        {

        }
        public void AddProduct(string productId)
        {
            if (productId == null)
            {
                throw new Exception("ProductId boş geçilemez");
            }
            ProductId = productId;
        }
        public void AddCampaign(string campaignId)
        {
            if (campaignId == null)
            {
                throw new Exception("CampaignId boş geçilemez");
            }
            CampaignId = campaignId;
        }
    }
}
