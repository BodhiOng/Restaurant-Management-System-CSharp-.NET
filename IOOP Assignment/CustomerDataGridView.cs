using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public class CustomDataGridView : DataGridView
    {
        protected override AccessibleObject CreateAccessibilityInstance()
        {
            return new ControlAccessibleObject(this);
        }
    }
}
