using System;
using System.Collections.Generic;
using System.Text;
using MyWeb.Services.Dto;
using MyWeb.Repository;
using MyWeb.Models.Entitys;

namespace MyWeb.Services.Users
{
    public class UserAppService : AppServiceBase, IUserAppService
    {
        private readonly IUserRepository _userRepository;

        public UserAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ResponseDto AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public ResponseDto DeleteUser(long id)
        {
            throw new NotImplementedException();
        }

        public ResponseDto GetUserById(long id)
        {
            throw new NotImplementedException();
        }

        public ResponseDto GetUserByNameAndPwd(string name, string pwd)
        {
            throw new NotImplementedException();
        }

        public ResponseDto GetUsers()
        {
            throw new NotImplementedException();
        }

        public ResponseDto GetUsersByPage(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ResponseDto UpdateUser(User updateUser)
        {
            throw new NotImplementedException();
        }
    }
}
