using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger.Models
{
    public class ListOrderModel
    {
        public string Name { get; set; }
        public int Piece { get; set; }

        public override string ToString()
        {
            return string.Format($"{Piece} of the {Name}s are sold out");
        }
    }
}
