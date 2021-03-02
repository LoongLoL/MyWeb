using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using MyWeb.Api.Controllers;
using MyWeb.Services.Banners;
using MyWeb.Services.Dto;

namespace MyWeb.Api.Controllers
{
    [Route("api/[controller]")]
    public class BannerController : ApiControllerBase
    {
        private IBannerAppService _bannerAppService;

        public BannerController(IBannerAppService bannerAppService)
        {
            _bannerAppService = bannerAppService;
        }

        [HttpGet]
        [Authorize]
        [Route("getBanner")]
        public ResponseDto GetBannerList()
        {
            var result = _bannerAppService.GetBannerList();
            return new ResponseDto
            {
                Code = 200,
                Data = result
            };
        }
    }
}
