using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarTool
{
    public partial class updateCustomerForm : Form
    {
        public updateCustomerForm()
        {
            InitializeComponent();
        }

        public updateCustomerForm(int recordID) 
        {
            InitializeComponent();
            customerNumTextBox.Enabled = false;
            customerNumTextBox.Text = recordID.ToString();
            
        }
    }
}
