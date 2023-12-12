using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Domain.Entity;

namespace BuberDinner.Application.Services.Menu
{
    public interface IMenuItemService
    {
        List<MenuItem> GetMenuItemsByMenu(Guid menuId);

        void DeleteMenuItems(Guid itemId);
        MenuItem GetMenuByName(string menuName);



    }
}