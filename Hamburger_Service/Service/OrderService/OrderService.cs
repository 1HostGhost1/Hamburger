using EF = Hamburger_Model.Entity;
using Hamburger_Service.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Hamburger_Core.Entity;

namespace Hamburger_Service.Service.OrderService
{
    public class OrderService : BaseService<EF.Order>, IOrderService
    {
        public async Task<decimal> TotalReveneu()
        {

            return await Any(x => x.Status == Status.Active) ? GetDefault(x => x.Status == Status.Active)
                .Select(x => x.Price).ToListAsync().Result.Aggregate((x, y) => x + y) : 0m;
        }

        public async Task<int> TotalSellProduct()
        {
            return await Any(x => x.Status == Status.Active) ? GetDefault(x => x.Status == Status.Active)
                .Select(x => x.Piece).ToListAsync().Result.Aggregate((x, y) => x + y) : 0;
        }
    }
}
