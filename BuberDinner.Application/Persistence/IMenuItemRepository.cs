using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Domain.Entity;

namespace BuberDinner.Application.Persistence
{
    public interface IMenuItemRepository
    {
        List<MenuItem> GetMenuItems();
        MenuItem? getSingleMenuItem(Guid itemId);
        void AddMenuItem(MenuItem menuItem);
        void UpdateMenuItem(MenuItem menuItem);
        void DeleteMenuItem(MenuItem menuItem);

        List<MenuItem> GetMenuItemsByMenu(Guid menuId);

        MenuItem? SearchMenuItem(string itemName);

    }
}