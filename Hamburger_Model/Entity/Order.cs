﻿using Hamburger_Core.Entity;
using Hamburger_Model.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Model.Entity
{
    public class Order : CoreEntity
    {
        public Order()
        {
            ExtraToOrders = new HashSet<ExtraToOrder>();
        }

        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public Size Size { get; set; }
        public int Piece { get; set; }
        public decimal Price { get; set; }
        public ICollection<ExtraToOrder> ExtraToOrders { get; set; }
    }
}
