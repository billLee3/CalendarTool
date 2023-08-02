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
            getCustomerIDs();
            getTypes();
            apptIDTextBox.Enabled = false;
            userIDTextBox.Enabled = false;
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
                    custIDcomboBox.SelectedItem = customerID;

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
                    typeComboBox.SelectedItem = type;

                    string url = row1.Field<string>("url");
                    urlTextBox.Text = url;
                    
                    DateTime startDateTime = row1.Field<DateTime>("start").ToLocalTime();
                    startDateTimePicker.Value = startDateTime;
                   
                    DateTime endDateTime = row1.Field<DateTime>("end").ToLocalTime();
                    endDateTimePicker.Value = endDateTime;
                    
                    
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
            int customerID = int.Parse(custIDcomboBox.SelectedValue.ToString());
            int userID = int.Parse(userIDTextBox.Text);
            startDateTimePicker.Value.ToUniversalTime();
            
            string startDate = startDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");

            //string start = startDateTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss");

            DateTime startDt = DateTime.Parse(startDate);
            DateTime startDtUTC = TimeZoneInfo.ConvertTimeToUtc(startDt);
            string startUTC = startDtUTC.ToString("yyyy-MM-dd HH:mm:ss");

            endDateTimePicker.Value.ToUniversalTime();
            DateTime endDt = DateTime.Parse(endDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            DateTime endDtUTC = TimeZoneInfo.ConvertTimeToUtc(endDt);
            string endUTC = endDtUTC.ToString("yyyy-MM-dd HH:mm:ss");
            
            string lastUpdate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

            Validator validator = new Validator();
            //NEED TO MIRROR SET UP TO THE ADD APPOINTMENT FORM
            bool withinBusinessHours = validator.withinBusinessHours(startDtUTC, endDtUTC);
            if (withinBusinessHours == true)
            {
                string updateApptQuery = $"UPDATE appointment SET customerId={customerID}, userId = {userID}, title = '{apptTitleTextBox.Text}', description = '{descriptionTextBox.Text}', location = '{locationTextBox.Text}', contact = '{pocTextBox.Text}', type = '{typeComboBox.SelectedValue}', url = '{urlTextBox.Text}', start = '{startUTC}', end = '{endUTC}', lastUpdate='{lastUpdate}', lastUpdateBy='{GlobalConfig.userName}' WHERE appointmentId = '{apptID}'";


                using (MySqlDataAdapter adapter = new MySqlDataAdapter(updateApptQuery, Database.dbConnection.conn))
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

		private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

        private void cancelNewApptButton_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            Close();
        }

        private void getTypes()
        {
            //using lamdba expression to efficiently reorder the values alphabetically for easier readability. 
            List<string> types = GlobalConfig.apptTypes.OrderBy(t => t).ToList();
            typeComboBox.DataSource = types;
        }

        private void getCustomerIDs()
        {
            string query = "SELECT customerId FROM customer";


            using (MySqlDataAdapter adp = new MySqlDataAdapter(query, Database.dbConnection.conn))
            {
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                int rows = dt.Rows.Count;
                List<string> list = new List<String>();

                //Running a for loop via a lambda function. 
                dt.Rows.Cast<DataRow>().ToList().ForEach(row => list.Add(row[0].ToString()));
                GlobalConfig.customerIds = list;

                //using lamdba expression to efficiently reorder the code so the order is sequential. 
                List<string> ids = GlobalConfig.customerIds.OrderBy(i => i).ToList();
                custIDcomboBox.DataSource = ids;
            }
        }
    }
}
