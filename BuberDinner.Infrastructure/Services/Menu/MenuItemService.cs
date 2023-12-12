using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Persistence;
using BuberDinner.Application.Services.Menu;
using BuberDinner.Domain.Entity;

namespace BuberDinner.Infrastructure.Services.Menu
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IMenuItemRepository _menuItemRepository;
        private readonly IMenuRepository _menuRepository;

        public MenuItemService(IMenuItemRepository menuItemRepository, IMenuRepository menuRepository)
        {
            _menuItemRepository = menuItemRepository;
            _menuRepository = menuRepository;
        }
        public void DeleteMenuItems(Guid itemId)
        {
            throw new NotImplementedException();
        }

        public MenuItem GetMenuByName(string menuName)
        {
            var item = _menuItemRepository.SearchMenuItem(menuName) ?? throw new KeyNotFoundException("Item is not found");
            return item;

        }

        public List<MenuItem> GetMenuItemsByMenu(Guid menuId)
        {
            if (!_menuRepository.IsMenuExist(menuId))
                throw new KeyNotFoundException("Menu is not found");
            var menuItems = _menuItemRepository.GetMenuItemsByMenu(menuId);
            return menuItems;
        }
    }
}