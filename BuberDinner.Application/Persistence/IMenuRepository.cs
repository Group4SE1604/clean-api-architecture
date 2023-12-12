using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Domain.Entity;

namespace BuberDinner.Application.Persistence
{
    public interface IMenuRepository
    {
        void AddMenu(Menu menu);
        Menu? GetMenuById(Guid menuId);

        List<Menu> GetMenus();

        void UpdateMenu(Menu menu);

        void DeleteMenu(Menu menu);

        bool IsMenuExist(Guid menuId);




    }
}