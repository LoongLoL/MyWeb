using MyWeb.IRepository;
using MyWeb.Models;
using MyWeb.Models.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWeb.Repository
{
    public class UsersRepository : RepositoryBase, IUsersRepository
    {
        private readonly MyWebDbContext _context;

        public UsersRepository(MyWebDbContext context)
        {
            _context = context;
        }
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(long id)
        {
            var user = _context.Users.Find(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public User GetUserById(long id)
        {
            var user = _context.Users.Find(id);
            return user;
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users;
        }

        public void UpdateUser(User updateUser)
        {
            var user = _context.Users.Attach(updateUser);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
