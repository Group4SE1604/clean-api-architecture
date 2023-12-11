using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Persistence;
using BuberDinner.Domain.Entity;

namespace BuberDinner.Infrastructure.Persistence
{
    public class MenuItemRepository : IMenuItemRepository
    {
        public void AddMenuItem(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteMenuItem(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        public List<MenuItem> GetMenuItems()
        {
            throw new NotImplementedException();
        }

        public MenuItem getSingleMenuItem(Guid itemId)
        {
            throw new NotImplementedException();
        }

        public void UpdateMenuItem(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }
    }
}