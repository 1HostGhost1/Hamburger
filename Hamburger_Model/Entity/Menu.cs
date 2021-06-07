using Hamburger_Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Model.Entity
{
    public class Menu : CoreEntity
    {
        public Menu()
        {
            Orders = new HashSet<Order>();
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
