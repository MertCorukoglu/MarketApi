using MarketApi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Domain.models
{
    public class Campaign : Entity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }



        public Campaign(/*string name, decimal price, decimal discount, CampaignProduct campaignProduct*/)
        {
            //Id = Guid.NewGuid().ToString();
            //SetName(name);
            //SetPrice(price);
            //SetDiscount(discount);
            //CampaignProduct = campaignProduct;

        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Lütfen bir isim giriniz.");
            }
            Name = name;
        }
        public void SetPrice(decimal price)
        {
            if (price<0)
            {
                throw new Exception("Lütfen geçerli bir fiyat giriniz.");
            }
            Price = price;
        }
        public void SetDiscount(decimal discount)
        {
            if (discount<0)
            {
                throw new Exception("Lütfen geçerli bir indirim giriniz.");
            }
            Discount = discount;
        }
        

    }

    
}
