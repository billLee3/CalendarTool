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
    public partial class addAppointmentForm : Form
    {
        public addAppointmentForm()
        {
            InitializeComponent();
        }

		private void createApptButton_Click(object sender, EventArgs e)
		{
            startDateTimePicker.Format = DateTimePickerFormat.Custom;
            startDateTimePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            string start = startDateTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss");

		}
	}
}
