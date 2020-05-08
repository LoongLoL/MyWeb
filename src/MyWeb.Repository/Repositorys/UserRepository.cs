using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyWeb.Models;
using MyWeb.Models.Entitys;

namespace MyWeb.Repository.Repositorys
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(MyWebDbContext context)
            : base(context)
        {

        }
    }
}
