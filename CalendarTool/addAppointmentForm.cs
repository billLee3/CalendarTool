using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            int userId = int.Parse(userIDTextBox.Text);
            int customerId = int.Parse(customerIDTextBox.Text);

            string start = startDateTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss");
            string end = endDateTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss");

            string createDate = DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss");
            string createdBy = "test";
            string lastUpdate = DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss");
            string lastUpdateBy = "test";

            string createApptQuery = $"INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                $"VALUES ({customerId}, {userId}, '{apptTitleTextBox.Text}', '{descriptionTextBox.Text}', '{locationTextBox.Text}', '{pocTextBox.Text}', '{apptTypeTextBox.Text}', '{urlTextBox.Text}', '{start}', '{end}', '{createDate}', '{createdBy}', '{lastUpdate}', '{lastUpdateBy}' )";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(createApptQuery, Database.dbConnection.conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
            }

            dashboard dashboard = new dashboard();
            dashboard.Show();
            Close();
        }
	}
}
