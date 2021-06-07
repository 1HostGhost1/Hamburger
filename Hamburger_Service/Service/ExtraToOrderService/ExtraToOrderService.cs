using EF = Hamburger_Model.Entity;
using Hamburger_Service.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hamburger_Core.Entity;
using System.Data.Entity;

namespace Hamburger_Service.Service.ExtraToOrderService
{
    public class ExtraToOrderService : BaseService<EF.ExtraToOrder>, IExtraToOrderService
    {
        public async Task<decimal> TotalEarningOfExtra()
        {
            return await Any(x=>x.Status == Status.Active) ? GetDefault(x => x.Status == Status.Active, x => x.Extra)
                .Select(x => x.Extra.Price).ToListAsync().Result.Aggregate((x, y) => x + y) : 0m;
        }
    }
}
