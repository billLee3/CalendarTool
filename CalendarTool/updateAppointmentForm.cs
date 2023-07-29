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
    public partial class updateAppointmentForm : Form
    {
        public updateAppointmentForm()
        {
            InitializeComponent();
        }

        public updateAppointmentForm(int recordID) 
        {
            InitializeComponent();
            apptIDTextBox.Enabled = false;
            apptIDTextBox.Text = recordID.ToString();

            string apptQuery = $"Select * from appointment where appointmentID = {recordID}";
            //Grab the information from the SQL Connection
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(apptQuery, Database.dbConnection.conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable userTable = ds.Tables[0];
                DataRow row1 = userTable.Rows[0];
                
                if (row1 != null) 
                {
                    string customerID = row1.Field<int>("customerId").ToString();
                    customerIDTextBox.Text = customerID;

                    string userID = row1.Field<int>("userId").ToString();
                    userIDTextBox.Text = userID;

                    string title = row1.Field<string>("title");
                    apptTitleTextBox.Text = title;

                    string description = row1.Field<string>("description");
                    descriptionTextBox.Text = description;

                    string location = row1.Field<string>("location");
                    locationTextBox.Text = location;

                    string contact = row1.Field<string>("contact");
                    pocTextBox.Text = contact;

                    string type = row1.Field<string>("type");
                    apptTypeTextBox.Text = type;

                    string url = row1.Field<string>("url");
                    urlTextBox.Text = url;
                    
                    DateTime startDateTime = row1.Field<DateTime>("start").ToLocalTime();
                    startDateTimePicker.Value = startDateTime.ToLocalTime();

                    DateTime endDateTime = row1.Field<DateTime>("end").ToLocalTime();
                    endDateTimePicker.Value = endDateTime.ToLocalTime();
                    
                }
            }
                
        }

		private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

        //Need help here
		private void createApptButton_Click(object sender, EventArgs e)
		{
            
            int apptID = int.Parse(apptIDTextBox.Text);
            int customerID = int.Parse(customerIDTextBox.Text);
            int userID = int.Parse(userIDTextBox.Text);
            startDateTimePicker.Value.ToUniversalTime();
            
            string startDate = startDateTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss");
            endDateTimePicker.Value.ToUniversalTime();
            string endDate = endDateTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss");
            string lastUpdate = DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss");
            string updateApptQuery = $"UPDATE appointment SET customerId={customerID}, userId = {userID}, title = '{apptTitleTextBox.Text}', description = '{descriptionTextBox.Text}', location = '{locationTextBox.Text}', contact = '{pocTextBox.Text}', type = '{apptTypeTextBox.Text}', url = '{urlTextBox.Text}', start = '{startDate}', end = '{endDate}', lastUpdate='{lastUpdate}', lastUpdateBy='{GlobalConfig.userName}' WHERE appointmentId = '{apptID}'";
            
            
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(updateApptQuery, Database.dbConnection.conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
            }

            dashboard dashboard = new dashboard();
            dashboard.Show();
            Close();
        }

		private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

        private void cancelNewApptButton_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            Close();
        }
    }
}
