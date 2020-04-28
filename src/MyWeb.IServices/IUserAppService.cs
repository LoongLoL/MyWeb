using MyWeb.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWeb.IServices
{
    public interface IUserAppService
    {
        User GetUserById(long id);

        User GetUserByNameAndPassword(string name, string password);
    }
}
