using MyWeb.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWeb.IRepository
{
    public interface IUsersRepository
    {
        User GetUserById(long id);

        IEnumerable<User> GetUsers();

        void DeleteUser(long id);

        void AddUser(User user);

        void UpdateUser(User updateUser);
    }
}
