using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Persistence;
using BuberDinner.Domain.Entity;

namespace BuberDinner.Infrastructure.Persistence
{
    public class MenuRepository : IMenuRepository
    {
        public void AddMenu(Menu menu)
        {
            throw new NotImplementedException();
        }

        public void DeleteMenu(Menu menu)
        {
            throw new NotImplementedException();
        }

        public Menu GetMenuById(Guid menuId)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetMenus()
        {
            throw new NotImplementedException();
        }

        public void UpdateMenu(Menu menu)
        {
            throw new NotImplementedException();
        }
    }
}