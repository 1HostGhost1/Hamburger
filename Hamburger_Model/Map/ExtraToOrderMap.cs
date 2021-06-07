using Hamburger_Core.Map;
using Hamburger_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Model.Map
{
    public class ExtraToOrderMap : BaseMap<ExtraToOrder>
    {
        public ExtraToOrderMap()
        {
            ToTable("dbo.ExtraToOrder");

            Property(x => x.ExtraId).IsRequired();
            Property(x => x.OrderId).IsRequired();
        }
    }
}
