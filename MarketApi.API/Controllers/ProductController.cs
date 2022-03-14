using MarketApi.API.Modals;
using MarketApi.Application.dtos;
using MarketApi.Application.services;
using MarketApi.Domain.repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IAddProductService _addProductService;
        private readonly IProductRepository _productRepository;
        private readonly ICreateCampaignService _createCampaignService;
        private readonly ICampaingRepository _campaingRepository;

        public ProductController(IAddProductService addProductService, IProductRepository productRepository, ICreateCampaignService createCampaignService, ICampaingRepository campaingRepository)
        {
            _addProductService = addProductService;
            _productRepository = productRepository;
            _createCampaignService = createCampaignService;
            _campaingRepository = campaingRepository;
        }

        [HttpGet("getallproduct")]
        public IActionResult GetAllProduct()
        {
            var response = _productRepository.GetQuery();
            return Ok(response);
        }
        [HttpPost("createproduct")]
        public IActionResult CreateProduct([FromBody] AddProductRequestService model)
        {
            var response = _addProductService.OnProcess(model);
            return Ok(response);
        }
        [HttpPost("createcampaign")]
        public IActionResult CreateCampaign([FromBody] CreateCampaignInputModel model)
        {
            var campaing = new CreateCampaignRequestService()
            {
                Discount = model.DiscountRate,
                Price = model.CampaignPrice,
                Name = model.Name,
                Products = model.Products

            };

            var response = _createCampaignService.OnProcess(campaing);

            return Ok();
        }

        [HttpGet("getallcampaign")]
        public IActionResult GetAllCampaign()
        {
            var response = _campaingRepository.GetQuery();
            return Ok(response);
        }
    }
}
