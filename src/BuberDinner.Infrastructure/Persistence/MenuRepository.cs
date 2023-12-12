using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Persistence;
using BuberDinner.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace BuberDinner.Infrastructure.Persistence
{
    public class MenuRepository : IMenuRepository
    {
        private readonly AppDbContext _db;

        public MenuRepository(AppDbContext db)
        {
            _db = db;
        }

        public void AddMenu(Menu menu)
        {
            _db.Menus.Add(menu);
            _db.SaveChanges();
        }

        public void DeleteMenu(Menu menu)
        {
            _db.Menus.Remove(menu);
            _db.SaveChanges();
        }

        public Menu? GetMenuById(Guid menuId)
        {
            return _db.Menus.Include(x => x.MenuItems).FirstOrDefault(x => x.MenuId == menuId);

        }

        public List<Menu> GetMenus()
        {
            return _db.Menus.Include(x => x.MenuItems).ToList();
        }

        public bool IsMenuExist(Guid menuId)
        {
            return _db.Menus.Any(x => x.MenuId == menuId);
        }

        public void UpdateMenu(Menu menu)
        {
            throw new NotImplementedException();
        }
    }
}