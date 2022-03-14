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
    public class CreateCampaignService : ICreateCampaignService
    {
        private readonly ICampaingRepository _campaingRepository;
        private readonly ICampaignProductRepository _campaignProductRepository;
        public CreateCampaignService(ICampaingRepository campaingRepository, ICampaignProductRepository campaignProductRepository)
        {
            _campaingRepository = campaingRepository;
            _campaignProductRepository = campaignProductRepository;
        }
        public string OnProcess(CreateCampaignRequestService request = null)
        {

            var campaing = new Campaign();
            campaing.Id = Guid.NewGuid().ToString();
            campaing.Name = request.Name;
            campaing.Price = request.Price;
            campaing.Discount = request.Discount;

            foreach (var item in request.Products)
            {
                var campaignProduct = new CampaignProduct();
                campaignProduct.Id = Guid.NewGuid().ToString();
                campaignProduct.AddProduct(item.Id);
                campaignProduct.AddCampaign(campaing.Id);
                _campaignProductRepository.Add(campaignProduct);              
            }

            _campaignProductRepository.Save();
            _campaingRepository.Add(campaing);
            _campaingRepository.Save();
            
            return "Kayıt işlemi başarılı.";


        }
    }
}
