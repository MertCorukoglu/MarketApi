using MarketApi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Domain.models
{
    public class Product : Entity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal QuantityPerUnit { get; set; }

        public Product(/*string name,decimal unitprice,decimal quantityPerUnit*/)
        {
            //Id = Guid.NewGuid().ToString();
            //SetName(name);
            //SetUnitPrice(unitprice);
            //SetQuantityPerUnit(quantityPerUnit);

        }
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Lütfen bir isim giriniz.");
            }
            ProductName = name;
        }
        public void SetUnitPrice(decimal unitPrice)
        {
            if (unitPrice < 0)
            {
                throw new Exception("Lütfen geçerli bir fiyat giriniz.");
            }
            UnitPrice = unitPrice;
        }
        public void SetQuantityPerUnit(decimal quantityPerUnit)
        {
            if (quantityPerUnit < 0)
            {
                throw new Exception("Lütfen geçerli bir miktar giriniz.");
            }
            QuantityPerUnit = quantityPerUnit;
        }
    }
}
