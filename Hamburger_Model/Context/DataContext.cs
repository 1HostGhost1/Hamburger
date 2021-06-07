using Hamburger_Core.Entity;
using Hamburger_Model.Entity;
using Hamburger_Model.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hamburger_Model.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Name=Conn")
        {

        }

        public DbSet<Extra> Extras { get; set; }
        public DbSet<ExtraToOrder> ExtraToOrders { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ExtraMap());
            modelBuilder.Configurations.Add(new ExtraToOrderMap());
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new OrderMap());
            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            var modifiedEntities = ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);

            foreach (var item in modifiedEntities)
            {
                CoreEntity entity = item.Entity as CoreEntity;
                if (item != null)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            entity.CreatedDate = DateTime.Now;
                            break;
                        case EntityState.Modified:
                            entity.ModifiedDate = DateTime.Now;
                            break;
                        default:
                            break;
                    }
                }
            }
            
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
