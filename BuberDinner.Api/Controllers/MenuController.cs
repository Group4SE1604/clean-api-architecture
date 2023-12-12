using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Api.Filter;
using BuberDinner.Application.Persistence;
using BuberDinner.Application.Services.Menu;
using BuberDinner.Contracts.Menu;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [ErrorHandlingFilter]
    public class MenuController : ControllerBase
    {
        private readonly IMenuRepository _menuRepository;
        private readonly IMenuService _menuService;

        public MenuController(IMenuRepository menuRepository, IMenuService menuService)
        {
            _menuRepository = menuRepository;
            _menuService = menuService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var menus = _menuRepository.GetMenus();
            return Ok(menus);
        }
        [HttpPost]
        public IActionResult CreateMenu(CreateMenuRequest request)
        {
            _menuService.CreateMenu(request);
            return Ok("Menu create success");
        }
        [HttpDelete("{menuId}")]
        public IActionResult DeleteMenu(Guid menuId)
        {
            _menuService.DeleteMenu(menuId);
            return Ok("Menu delete success");
        }
        [HttpGet("{menuId}")]
        public IActionResult GetMenuById(Guid menuId)
        {
            var menu = _menuRepository.GetMenuById(menuId);
            return Ok(menu);
        }


    }
}