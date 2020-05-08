
using System;
using System.Collections.Generic;
using System.Text;
using MyWeb.Services.Banners.Dto;
using MyWeb.Services.Dto;

namespace MyWeb.Services.Banners
{
    public interface IBannerAppService
    {
        ResponseDto AddBanner(AddBannerDto dto);
        ResponseDto GetBannerList();
        ResponseDto DeleteBanner(int id);
        ResponseDto UpdateBanner(UpdateBannerDto dto);
    }
}
