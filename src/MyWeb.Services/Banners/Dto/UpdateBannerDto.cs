using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using MyWeb.Models.Entitys;

namespace MyWeb.Services.Banners.Dto
{
    public class UpdateBannerDto : Entity
    {
        [MaxLength(200)]
        public string Image { get; set; }
        [MaxLength(200)]
        public string Url { get; set; }

        [MaxLength(200)]
        public string Remark { get; set; }
    }
}
