using Hamburger.Helpers;
using Hamburger_Service.Service.MenuService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF = Hamburger_Model.Entity;

namespace Hamburger
{
    public partial class AddHamburgerForm : Form
    {
        private readonly MenuService _ms;
        public AddHamburgerForm()
        {
            InitializeComponent();
            _ms = new MenuService();
        }

        private async void btnSaveMenu_Click(object sender, EventArgs e)
        {
            try
            {
                var menu = new EF.Menu()
                {
                    Name = txtMenuName.Text,
                    Price = Convert.ToInt32(nmrPrice.Value)
                };

                await _ms.Add(menu);

                MessageBox.Show("Menu Has Been Added Successfully", "Menu Details",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Tools.Clean(this.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR! - {ex}");
            }
        }
    }
}
