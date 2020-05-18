using MyWeb.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Repository.IRepositorys
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetUserByNamePwd(string name, string password);
    }
}
