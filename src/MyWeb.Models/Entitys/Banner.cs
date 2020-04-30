using MyWeb.Models.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyWeb.Models.Entitys
{
    public class Banner : EntityWithDelModAdd<int>
    {
        [MaxLength(200)]
        public string Image { get; set; }
        [MaxLength(200)]
        public string Url { get; set; }
        [MaxLength(200)]
        public string Remark { get; set; }
    }
}
