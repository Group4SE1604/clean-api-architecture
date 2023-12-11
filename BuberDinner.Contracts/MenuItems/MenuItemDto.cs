using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuberDinner.Contracts.MenuItems
{
    public class MenuItemDto
    {
        public Guid ItemId { get; set; } = Guid.NewGuid();
        public string ItemName { get; set; } = null!;
        public decimal ItemPrice { get; set; }
        public Guid MenuId { get; set; }

    }
}