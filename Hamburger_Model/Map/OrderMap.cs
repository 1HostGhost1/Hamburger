using Hamburger_Core.Map;
using Hamburger_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Model.Map
{
    public class OrderMap : BaseMap<Order>
    {
        public OrderMap()
        {
            ToTable("dbo.Orders");
        }
    }
}
