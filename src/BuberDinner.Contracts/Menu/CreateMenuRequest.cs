using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using BuberDinner.Contracts.MenuItems;

namespace BuberDinner.Contracts.Menu
{
    public class CreateMenuRequest
    {
        public string MenuName { get; set; } = null!;
        public string MenuDescription { get; set; } = null!;
        public ICollection<MenuItemDto> MenuItems { get; set; } = null!;
    }


}