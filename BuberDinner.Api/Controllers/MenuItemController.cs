using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Api.Filter;
using BuberDinner.Application.Persistence;
using BuberDinner.Application.Services.Menu;
using BuberDinner.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BuberDinner.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    [ErrorHandlingFilter]

    public class MenuItemController : ControllerBase
    {
        private readonly IMenuItemRepository _menuItemRepository;
        private readonly IMenuItemService _menuItemService;

        public MenuItemController(IMenuItemRepository menuItemRepository, IMenuItemService menuItemService)
        {
            _menuItemRepository = menuItemRepository;
            _menuItemService = menuItemService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var menuItems = _menuItemRepository.GetMenuItems();
            return Ok(menuItems);
        }

        [HttpGet("{menuId}")]
        public IActionResult GetMenuItemsByMenu(Guid menuId)
        {
            var menuItems = _menuItemService.GetMenuItemsByMenu(menuId);
            return Ok(menuItems);
        }
        [HttpGet("{itemId}")]
        public IActionResult GetMenuItemById(Guid itemId)
        {
            var menuItem = _menuItemRepository.getSingleMenuItem(itemId);
            return Ok(menuItem);
        }
        [HttpGet]
        public IActionResult SearchMenuItem(string itemName)
        {
            var menuItem = _menuItemRepository.SearchMenuItem(itemName);
            return Ok(menuItem);
        }


    }
}