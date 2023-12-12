using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BuberDinner.Contracts.Menu;
using BuberDinner.Contracts.MenuItems;
using BuberDinner.Domain.Entity;

namespace BuberDinner.Application.Common.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MenuItemDto, MenuItem>();
            CreateMap<CreateMenuRequest, Menu>();



        }

    }
}