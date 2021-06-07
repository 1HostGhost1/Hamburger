using Hamburger_Core.Service;
using EF = Hamburger_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Service.Service.MenuService
{
    public interface IMenuService : ICoreService<EF.Menu>
    {
    }
}
