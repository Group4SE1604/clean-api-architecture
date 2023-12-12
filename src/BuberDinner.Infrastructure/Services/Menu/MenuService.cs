using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BuberDinner.Application.Persistence;
using BuberDinner.Application.Services.Menu;
using BuberDinner.Contracts.Menu;

namespace BuberDinner.Infrastructure.Services.Menu
{
    public class MenuService : IMenuService
    {
        private readonly IMapper _mapper;
        private readonly IMenuRepository _menuRepository;

        public MenuService(IMapper mapper, IMenuRepository menuRepository)
        {
            _mapper = mapper;
            _menuRepository = menuRepository;
        }

        public void CreateMenu(CreateMenuRequest request)
        {
            var menu = _mapper.Map<Domain.Entity.Menu>(request);
            _menuRepository.AddMenu(menu);
        }

        public void DeleteMenu(Guid menuId)
        {
            var menu = _menuRepository.GetMenuById(menuId) ?? throw new KeyNotFoundException("Menu is not found");
            _menuRepository.DeleteMenu(menu);
        }

        public Domain.Entity.Menu GetMenuById(Guid menuId)
        {
            var menu = _menuRepository.GetMenuById(menuId) ?? throw new KeyNotFoundException("Menu is not found");
            return menu;
        }
    }


}