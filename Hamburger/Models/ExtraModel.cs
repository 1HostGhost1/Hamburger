using Hamburger_Service.Service.ExtraService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger.Models
{
    public class ExtraModel
    {
        private readonly ExtraService _exs;
        public ExtraModel()
        {
            _exs = new ExtraService();
        }
        public int Id { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }

        public string Name { get; set; }

        public async Task<decimal> CalculateToCount()
        {
            var ex = await _exs.GetById(Id);
            Name = ex.Name;
            TotalPrice = ex.Price * Count;
            return TotalPrice;
        }
    }
}
