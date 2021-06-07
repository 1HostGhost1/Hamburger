using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger.Helpers
{
    public class Tools
    {
        public static void Clean(Control.ControlCollection collection)
        {
            foreach (Control item in collection)
            {
                if (item is TextBox)
                    (item as TextBox).Clear();
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = -1;
                else if (item is CheckBox)
                    (item as CheckBox).Checked = false;
                else if (item is RadioButton)
                {
                    RadioButton rb = item as RadioButton;
                    if (rb.Name == "rbMedium")
                        rb.Checked = true;
                    else
                        rb.Checked = false;
                }
                else if (item is NumericUpDown)
                    (item as NumericUpDown).Value = 1;
                else if (item is GroupBox)
                    Clean((item as GroupBox).Controls);
                else if (item is FlowLayoutPanel)
                    Clean((item as FlowLayoutPanel).Controls);
            }
        }
    }
}
