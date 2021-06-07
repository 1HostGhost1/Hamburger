using Hamburger_Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Model.Entity
{
    public class Extra : CoreEntity
    {
        public Extra()
        {
            ExtraToOrders = new HashSet<ExtraToOrder>();
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<ExtraToOrder> ExtraToOrders { get; set; }
    }
}
