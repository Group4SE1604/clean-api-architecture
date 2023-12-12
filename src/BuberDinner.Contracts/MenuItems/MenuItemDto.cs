using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuberDinner.Contracts.MenuItems
{
    public class MenuItemDto
    {
        public string ItemName { get; set; } = null!;
        public decimal ItemPrice { get; set; }

    }
}