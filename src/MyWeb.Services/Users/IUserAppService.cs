using MyWeb.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using MyWeb.Services.Dto;
using MyWeb.Services.Users.Dto;

namespace MyWeb.Services.Users
{
    public interface IUserAppService
    {
        /// <summary>
        /// 通过用户名和密码获取用户信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        ResponseDto GetUserByNamePwd(string name, string pwd);
        /// <summary>
        /// 根据Id获取指定数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ResponseDto GetUserById(long id);
        /// <summary>
        /// 获取全部数据
        /// </summary>
        /// <returns></returns>
        ResponseDto GetUsers();
        /// <summary>
        /// 分页获取数据
        /// </summary>
        /// <returns></returns>
        ResponseDto GetUsersByPage(int pageIndex, int pageSize);
        /// <summary>
        /// 根据Id删除指定数据，返回删除结果
        /// </summary>
        /// <param name="id"></param>
        ResponseDto DeleteUser(long id);
        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        ResponseDto AddUser(AddUserDto user);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="updateUser"></param>
        /// <returns></returns>
        ResponseDto UpdateUser(UpdateUserDto updateUser);
    }
}
