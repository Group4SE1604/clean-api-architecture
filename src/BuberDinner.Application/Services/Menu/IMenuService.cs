using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Contracts.Menu;

namespace BuberDinner.Application.Services.Menu
{
    public interface IMenuService
    {
        void CreateMenu(CreateMenuRequest request);
        void DeleteMenu(Guid menuId);

        Domain.Entity.Menu GetMenuById(Guid menuId);



    }
}