using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyWeb.Models;
using MyWeb.Models.Entitys;

namespace MyWeb.Repository
{
    public class BannerRepository : Repository<Banner>, IBannerRepository
    {
        public BannerRepository(MyWebDbContext context)
            : base(context)
        {

        }
    }
}
