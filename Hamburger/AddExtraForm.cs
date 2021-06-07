using Hamburger.Helpers;
using Hamburger_Model.Entity;
using Hamburger_Service.Service.ExtraService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger
{
    public partial class AddExtraForm : Form
    {
        private readonly ExtraService _es;
        public AddExtraForm()
        {
            InitializeComponent();
            _es = new ExtraService();
        }

        private async void btnSaveExtra_Click(object sender, EventArgs e)
        {
            try
            {
                var extra = new Extra()
                {
                    Name = txtExtraName.Text,
                    Price = Convert.ToInt32(nmrPrice.Value)
                };

                await _es.Add(extra);

                MessageBox.Show("Extra Has Been Added Successfully", "Extra Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tools.Clean(this.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR! - {ex}");
            }
        }
    }
}
