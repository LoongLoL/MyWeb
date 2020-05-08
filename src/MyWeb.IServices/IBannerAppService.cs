using MyWeb.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using MyWeb.Models.Models;

namespace MyWeb.IServices
{
    public interface IBannerAppService
    {
        ResponseDto AddBanner(AddBannerDto dto);
        ResponseDto GetBannerList();
        ResponseDto DeleteBanne(int id);
        ResponseDto UpdateBanner(UpdateBannerDto dto);
    }
}
