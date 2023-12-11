using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuberDinner.Domain.Entity
{
    public class MenuItem
    {
        public Guid ItemId { get; set; } = Guid.NewGuid();
        public string ItemName { get; set; } = null!;
        public decimal ItemPrice { get; set; }
        public Guid MenuId { get; set; }

        public Menu Menu { get; set; } = null!;





    }
}