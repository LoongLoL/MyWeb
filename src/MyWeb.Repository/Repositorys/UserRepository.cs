using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWeb.Models;
using MyWeb.Models.Entitys;
using MyWeb.Repository.IRepositorys;

namespace MyWeb.Repository.Repositorys
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(MyWebDbContext context)
            : base(context)
        {

        }

        public async Task<User> GetUserByNamePwd(string name, string password)
        {
            var user = await DbSet.FirstOrDefaultAsync(x => x.Name == name && x.Password == password);
            return user;
        }
    }
}
