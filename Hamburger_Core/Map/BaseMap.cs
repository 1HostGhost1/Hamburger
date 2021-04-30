using Hamburger_Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hamburger_Core.Map
{
    public class BaseMap<T> : EntityTypeConfiguration<T> where T : CoreEntity
    {
        public BaseMap()
        {
            Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Status)
                .HasColumnName("Status")
                .HasColumnOrder(2)
                .IsRequired();

            Property(x => x.CreatedDate)
                .HasColumnName("CreatedDate")
                .HasColumnType("datetime2")
                .HasColumnOrder(3)
                .IsRequired();

            Property(x => x.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .HasColumnType("datetime2")
                .HasColumnOrder(4)
                .IsRequired();
        }
    }
}
