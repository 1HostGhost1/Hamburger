using Hamburger_Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Model.Entity
{
    public class ExtraToOrder : CoreEntity
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ExtraId { get; set; }
        public Extra Extra { get; set; }
    }
}
