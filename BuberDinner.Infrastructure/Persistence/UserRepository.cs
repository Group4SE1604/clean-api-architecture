using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Persistence;
using BuberDinner.Domain.Entity;

namespace BuberDinner.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;

        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            SaveChanges();

        }

        public User? GetUserByEmail(string email)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            return user;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}