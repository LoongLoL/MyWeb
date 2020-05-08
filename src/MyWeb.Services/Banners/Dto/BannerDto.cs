using System;
using System.Collections.Generic;
using System.Text;
using MyWeb.Models.Entitys;

namespace MyWeb.Services.Banners.Dto
{
    public class BannerDto : EntityWithDelModAdd<int>
    {
        public string Image { get; set; }
        public string Url { get; set; }
        public string Remark { get; set; }
    }
}
