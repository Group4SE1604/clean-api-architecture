using System.Security.Cryptography.X509Certificates;
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

        private readonly AppDbContext _db;

        public MenuItemRepository(AppDbContext db)
        {
            _db = db;
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteMenuItem(MenuItem menuItem)
        {
            _db.MenuItems.Remove(menuItem);
            _db.SaveChanges();
        }

        public List<MenuItem> GetMenuItems()
        {
            return _db.MenuItems.ToList();
        }

        public List<MenuItem> GetMenuItemsByMenu(Guid menuId)
        {
            var listItems = _db.MenuItems.Where(x => x.MenuId == menuId).ToList();
            return listItems;
        }

        public MenuItem? getSingleMenuItem(Guid itemId)
        {
            var item = _db.MenuItems.FirstOrDefault(x => x.ItemId == itemId);
            return item;
        }

        public MenuItem? SearchMenuItem(string itemName)
        {
            var item = _db.MenuItems.Where(x => x.ItemName.Contains(itemName)).FirstOrDefault();
            return item;
        }

        public void UpdateMenuItem(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }
    }
}