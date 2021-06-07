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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChilForm(new CreateOrderForm());
        }

        private void orderDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChilForm(new OrderDetailForm());
        }

        private void addHamburgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChilForm(new AddHamburgerForm());
        }

        private void addExtraMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChilForm(new AddExtraForm());
        }

        private void ChilForm(Form _childForm)
        {
            this.Width = _childForm.Width + 20;
            this.Height = _childForm.Height + 67;

            bool durum = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                    frm.Close();
            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }
    }
}
