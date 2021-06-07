using Hamburger_Core.Map;
using Hamburger_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Model.Map
{
    public class ExtraMap : BaseMap<Extra>
    {
        public ExtraMap()
        {
            ToTable("dbo.Extras");

            Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnOrder(5)
                .IsRequired();

            Property(x => x.Price)
                .HasColumnName("Price")
                .HasColumnOrder(6)
                .IsRequired();
        }
    }
}
