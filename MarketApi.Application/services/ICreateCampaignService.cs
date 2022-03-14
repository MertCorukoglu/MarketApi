using MarketApi.Application.dtos;
using MarketApi.Core.application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApi.Application.services
{
    public interface ICreateCampaignService : IApplicationService<CreateCampaignRequestService, string>
    {
    }
}
