using MarketApi.Application.dtos;
using MarketApi.Domain.models;
using MarketApi.Domain.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Application.services
{
    public class AddProductService : IAddProductService
    {
        private readonly IProductRepository _productRepository;

        public AddProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public string OnProcess(AddProductRequestService request = null)
        {
            try
            {
                var product = new Product()
                {
                    Id = Guid.NewGuid().ToString(),
                    ProductName = request.ProductName,
                    QuantityPerUnit = request.QuantityPerUnit,
                    UnitPrice = request.UnitPrice
                   

                };
                _productRepository.Add(product);
                _productRepository.Save();
                return "Ürün ekleme işlemi başarılı.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
