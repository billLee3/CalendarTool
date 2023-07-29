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

            startDateTimePicker.Value.ToLocalTime();
            endDateTimePicker.Value.ToLocalTime();
        }

		private void createApptButton_Click(object sender, EventArgs e)
		{
            //int userId = int.Parse(userIDTextBox.Text);
            int userId = getUserID(GlobalConfig.userName);
            if (userId == -1)
            {
                MessageBox.Show("You got problems buddy.");
                return;
            }
            int customerId = int.Parse(customerIDTextBox.Text);

            string start = startDateTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss");
            
            DateTime startDt = DateTime.Parse(start);
            DateTime startDtUTC = TimeZoneInfo.ConvertTimeToUtc(startDt);
            string startUTC = startDtUTC.ToString("yyyy-MM-dd hh:mm:ss");
            
            string end = endDateTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss");
            DateTime endDt = DateTime.Parse(end);
            DateTime endDtUTC = TimeZoneInfo.ConvertTimeToUtc(endDt);
            string endUTC = endDtUTC.ToString("yyyy-MM-dd hh:mm:ss");

            string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss");
            
            string lastUpdate = DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss");

            Validator validator = new Validator();
            bool withinBusinessHours = validator.withinBusinessHours(startDtUTC, endDtUTC);
            if (withinBusinessHours == true)
            {
                MessageBox.Show("Within Business Hours!");
                string createApptQuery = $"INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                $"VALUES ({customerId}, {userId}, '{apptTitleTextBox.Text}', '{descriptionTextBox.Text}', '{locationTextBox.Text}', '{pocTextBox.Text}', '{apptTypeTextBox.Text}', '{urlTextBox.Text}', '{startUTC}', '{endUTC}', '{createDate}', '{GlobalConfig.userName}', '{lastUpdate}', '{GlobalConfig.userName}' )";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(createApptQuery, Database.dbConnection.conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                }

                dashboard dashboard = new dashboard();
                dashboard.Show();
                Close();
            }
            else
            {
                errorLabel.Text = "Appointment isn't within business hours. ";
            }

            
        }

        public int getUserID(string userName)
        {
            string userIdQuery = $"SELECT userId FROM user WHERE userName = '{userName}'";

            MySqlCommand cmd = new MySqlCommand(userIdQuery, Database.dbConnection.conn);
            var result = cmd.ExecuteScalar();

            try
            {
                if (result != null)
                {
                    int id = Convert.ToInt32(result);
                    return id;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        
	}
}
