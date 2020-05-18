using System;
using System.Collections.Generic;
using System.Text;
using MyWeb.Services.Dto;
using MyWeb.Repository;
using MyWeb.Models.Entitys;
using MyWeb.Repository.IRepositorys;
using MyWeb.Services.Users.Dto;
using AutoMapper;
using System.Linq;

namespace MyWeb.Services.Users
{
    public class UserAppService : AppServiceBase, IUserAppService
    {
        private readonly IUserRepository _userRepository;

        public UserAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ResponseDto AddUser(AddUserDto user)
        {
            var entity = user.MapTo<User, AddUserDto>();
            _userRepository.Add(entity);
            return new ResponseDto { Code = 200, Message = "添加用户成功！" };
        }

        public ResponseDto DeleteUser(long id)
        {
            _userRepository.Remove(id);
            return new ResponseDto { Code = 200, Message = "删除用户成功！" };
        }

        public ResponseDto GetUserById(long id)
        {
            var entity = _userRepository.GetById(id);
            var user = entity.MapTo<UserDto, User>();
            return new ResponseDto { Code = 200, Message = "获取用户成功！", Data = user };
        }

        public ResponseDto GetUserByNamePwd(string name, string pwd)
        {

            var entity = _userRepository.GetUserByNamePwd(name, pwd).Result;
            if (entity == null) return new ResponseDto { Code = 500, Message = "获取用户失败！" };
            var user = entity.MapTo<UserDto, User>();
            return new ResponseDto { Code = 200, Message = "获取用户成功！", Data = user };
        }

        public ResponseDto GetUsers()
        {
            var userList = _userRepository.GetAll().MapTo<List<UserDto>, IQueryable<User>>();
            return new ResponseDto { Code = 200, Message = "获取用户成功！", Data = userList };
        }

        public ResponseDto GetUsersByPage(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ResponseDto UpdateUser(UpdateUserDto updateUser)
        {
            var user = updateUser.MapTo<User, UpdateUserDto>();
            _userRepository.Update(user);
            return new ResponseDto { Code = 200, Message = "更新用户成功！" };
        }
    }
}
