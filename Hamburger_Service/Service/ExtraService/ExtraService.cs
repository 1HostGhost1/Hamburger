using EF = Hamburger_Model.Entity;
using Hamburger_Service.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Service.Service.ExtraService
{
    public class ExtraService : BaseService<EF.Extra>, IExtraService
    {
    }
}
