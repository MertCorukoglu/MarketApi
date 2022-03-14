using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Application.dtos
{
    public class AddProductRequestService
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal QuantityPerUnit { get; set; }
    }
}
