using Hamburger_Model.Entity;
using Hamburger_Model.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger.Models
{
    public class OrderModel
    {
        public OrderModel()
        {
            Extras = new HashSet<Extra>();
        }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public Size Size { get; set; }
        public int Piece { get; set; }
        public decimal Price { get; set; }

        public ICollection<Extra> Extras { get; set; }

        public void Calculate()
        {
            Price = 0;
            Price += Menu.Price;

            switch (Size)
            {
                case Size.Medium:
                    Price += Price * 0.10M;
                    break;
                case Size.Large:
                    Price += Price * 0.20M;
                    break;
            }

            foreach (Extra extra in Extras)
                Price += extra.Price;

            Price *= Piece;
        }

        public override string ToString()
        {
            if (Extras.Count < 1)
                return string.Format($"{Menu.Name}, X {Piece} Piece, {Size} Size, Total : {Price} ₺");
            else
            {
                string extras = null;
                foreach (Extra item in Extras)
                    extras += item.Name + ',';

                extras = extras.Trim(',');

                return string.Format($"{Menu.Name}, X {Piece} Piece, {Size} Size, Ex : {extras}, Total : {Price} ₺");
            }
        }
    }
}
