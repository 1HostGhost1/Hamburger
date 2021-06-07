using EF = Hamburger_Model.Entity;
using Hamburger_Service.Service.ExtraService;
using Hamburger_Service.Service.ExtraToOrderService;
using Hamburger_Service.Service.MenuService;
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
using Hamburger.Models;
using Hamburger.Helpers;

namespace Hamburger
{
    public partial class CreateOrderForm : Form
    {
        private readonly OrderService _os;
        private readonly ExtraService _exs;
        private readonly MenuService _ms;
        private readonly ExtraToOrderService _etos;
        public CreateOrderForm()
        {

            _os = new OrderService();
            _exs = new ExtraService();
            _ms = new MenuService();
            _etos = new ExtraToOrderService();
            InitializeComponent();
        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            rbMedium.Checked = true;
            btnCompleteOrder.Enabled = false;

            cmbMenus.Items.AddRange(_ms.GetActives().ToArray());
            cmbMenus.DisplayMember = "Name";

            var extras = _exs.GetActives().ToList();

            foreach (EF.Extra item in extras)
                flpExtraMaterial.Controls.Add(new CheckBox() { Text = item.Name, Tag = item });
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            OrderModel orderModel = new OrderModel();
            orderModel.MenuId = ((EF.Menu)cmbMenus.SelectedItem).Id;
            orderModel.Menu = (EF.Menu)cmbMenus.SelectedItem;
            orderModel.Size = rbSmall.Checked ? EF.Enums.Size.Small : (rbMedium.Checked ? EF.Enums.Size.Medium : (rbLarge.Checked ? EF.Enums.Size.Large : EF.Enums.Size.Medium));
            orderModel.Piece = (int)nmrPiece.Value;

            foreach (CheckBox item in flpExtraMaterial.Controls)
                if (item.Checked)
                    orderModel.Extras.Add((EF.Extra)item.Tag);

            orderModel.Calculate();
            lstOrders.Items.Add(orderModel);
            CalculateTotal();

            btnCompleteOrder.Enabled = true;
            Tools.Clean(this.Controls);
        }

        private decimal CalculateTotal()
        {
            decimal totalPrice = 0;
            for (int i = 0; i < lstOrders.Items.Count; i++)
            {
                OrderModel currentOrder = lstOrders.Items[i] as OrderModel;
                totalPrice += currentOrder.Price;
            }

            lblTotalPrice.Text = totalPrice.ToString("C2");
            return totalPrice;
        }

        private async void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Total Order Price: {CalculateTotal().ToString("C2")}, Do You Want To Complete The Order?", "Order Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (OrderModel item in lstOrders.Items)
                {
                    EF.Order order = new EF.Order()
                    {
                        Status = Hamburger_Core.Entity.Status.Active,
                        MenuId = item.MenuId,
                        Piece = item.Piece,
                        Size = item.Size,
                        Price = item.Price,
                    };

                    order = await _os.Add(order);

                    foreach (var extra in item.Extras)
                    {
                        EF.ExtraToOrder extraToOrder = new EF.ExtraToOrder()
                        {
                            OrderId = order.Id,
                            ExtraId = extra.Id
                        };
                        await _etos.Add(extraToOrder);
                    }
                }
            }

            lstOrders.Items.Clear();
            CalculateTotal();
            Tools.Clean(this.Controls);
            MessageBox.Show("Your Order Has Been Completed");
        }
    }
}
