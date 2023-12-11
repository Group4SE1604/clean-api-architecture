using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuberDinner.Domain.Entity
{
    public class Menu
    {
        public Guid MenuId { get; set; } = Guid.NewGuid();
        public ICollection<MenuItem> MenuItems { get; set; } = null!;
        public string MenuName { get; set; } = null!;
        public string MenuDescription { get; set; } = null!;

    }
}