using Hamburger_Service.Service.ExtraToOrderService;
using Hamburger_Service.Service.OrderService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hamburger_Core.Entity;
using System.Data.Entity;
using Hamburger.Models;

namespace Hamburger
{
    public partial class OrderDetailForm : Form
    {
        private readonly OrderService _os;
        private readonly ExtraToOrderService _extos;
        public OrderDetailForm()
        {
            InitializeComponent();
            _os = new OrderService();
            _extos = new ExtraToOrderService();
        }

        private async void OrderDetailForm_Load(object sender, EventArgs e)
        {
            var totalEarning = await _os.TotalReveneu();
            var totalSellProduct = await _os.TotalSellProduct();
            var totalOrderPiece = _os.GetActives().AsNoTracking().ToList().Count();
            var earningFromEx = await _extos.TotalEarningOfExtra();

            lblTotalEarning.Text = totalEarning.ToString("C2");
            lblNumberOfProductSold.Text = totalSellProduct.ToString();
            lblTotalOrderQuantity.Text = totalOrderPiece.ToString();
            lblTotalEarningOfExtra.Text = earningFromEx.ToString("C2");

            var orders = _os.GetDefault(x => x.Status == Status.Active, x => x.Menu).GroupBy(x => x.Menu.Name).Select(x => new ListOrderModel
            { 
                Name = x.Key,
                Piece = x.Sum(c=>c.Piece)
            }).ToList();

            foreach (var item in orders)
                lstAllOrders.Items.Add(item);
        }

        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var extras = _extos.GetDefault(x => x.Status == Status.Active, x => x.Extra).GroupBy(x => x.ExtraId).Select(x => new ExtraModel()
            {
                Id = x.Key,
                Count = x.Count()
            }).ToList();

            string message = "";

            int totalCount = 0;
            decimal totalPrice = 0;

            foreach (var item in extras)
            {
                item.TotalPrice = await item.CalculateToCount();
                message += $"{item.Name} - Sale: {item.Count} - Earning: {item.TotalPrice}\n";
                message += "----------------------------------------------------------------------------\n";
                totalCount += item.Count;
                totalPrice += item.TotalPrice;
            }

            message += $"Extras - Total Sale: {totalCount} - Total Earning: {totalPrice}";

            MessageBox.Show(message,"Extra Details",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
