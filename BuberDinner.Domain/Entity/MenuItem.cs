using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BuberDinner.Domain.Entity
{
    public class MenuItem
    {
        public Guid ItemId { get; set; } = Guid.NewGuid();
        public string ItemName { get; set; } = null!;
        public decimal ItemPrice { get; set; }
        [JsonIgnore]
        public Guid MenuId { get; set; }

        [JsonIgnore]
        public Menu Menu { get; set; } = null!;

    }
}