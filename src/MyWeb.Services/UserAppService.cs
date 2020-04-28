using MyWeb.IRepository;
using MyWeb.IServices;
using MyWeb.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWeb.Services
{
    public class UserAppService : AppServiceBase, IUserAppService
    {
        private readonly IUsersRepository _uesrRepository;

        public UserAppService(IUsersRepository userRepository)
        {
            _uesrRepository = userRepository;
        }

        public User GetUserById(long id)
        {
            throw new NotImplementedException();
        }

        public User GetUserByNameAndPassword(string name, string password)
        {
            throw new NotImplementedException();
        }
    }
}
