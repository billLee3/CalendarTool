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
            getTypes();
            getCustomerIDs();
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
            Validator validator = new Validator();
            bool validCustomer = validator.isCustomer(custIDcomboBox.SelectedValue.ToString());
            if (isValid())
            {
                if (validCustomer != true)
                {
                    errorLabel.Text = "Enter a valid customer ID. ";
                }
                else
                {


                    string start = startDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");

                    DateTime startDt = DateTime.Parse(start);
                    DateTime startDtUTC = TimeZoneInfo.ConvertTimeToUtc(startDt);
                    string startUTC = startDtUTC.ToString("yyyy-MM-dd HH:mm:ss");

                    string end = endDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                    DateTime endDt = DateTime.Parse(end);
                    DateTime endDtUTC = TimeZoneInfo.ConvertTimeToUtc(endDt);
                    string endUTC = endDtUTC.ToString("yyyy-MM-dd HH:mm:ss");

                    string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

                    string lastUpdate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");


                    bool withinBusinessHours = validator.withinBusinessHours(startDtUTC, endDtUTC);
                    if (withinBusinessHours == true)
                    {
                        bool overlap = validator.overlappingAppointment(startUTC, endUTC);
                        if (overlap == false)
                        {
                            string createApptQuery = $"INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                        $"VALUES ({custIDcomboBox.SelectedValue}, {userId}, '{apptTitleTextBox.Text}', '{descriptionTextBox.Text}', '{locationTextBox.Text}', '{pocTextBox.Text}', '{typeComboBox.SelectedValue}', '{urlTextBox.Text}', '{startUTC}', '{endUTC}', '{createDate}', '{GlobalConfig.userName}', '{lastUpdate}', '{GlobalConfig.userName}' )";

                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(createApptQuery, Database.dbConnection.conn))
                            {
                                DataSet ds = new DataSet();
                                adapter.Fill(ds);
                            }
                            GlobalConfig.successMessage("appointment");
                            dashboard dashboard = new dashboard();
                            dashboard.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("There is an overlapping appointment.");
                        }



                    }
                    else
                    {
                        errorLabel.Text = "Appointment isn't within business hours. ";
                    }
                }
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

        private void cancelNewApptButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void getTypes()
        {
            //using lamdba expression to efficiently reorder the values alphabetically for easier readability. The lambda expression is more efficient because it does the work of several lines of code all in one line of code. 
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

                //Running a for loop via a lambda function. More effecient because it reduces the size of this .cs file and accomplishes what several lines would do all in one single line. 
                dt.Rows.Cast<DataRow>().ToList().ForEach(row => list.Add(row[0].ToString()));
                GlobalConfig.customerIds = list;
                
                //using lamdba expression to efficiently reorder the code so the order is sequential and places them in a list all in one line of code rather than several lines of code adding to the requirements of the application. 
                List<string> ids = GlobalConfig.customerIds.OrderBy(i => i).ToList();
                custIDcomboBox.DataSource = ids;
            }
        }

        private bool isValid()
        {
            if (apptTitleTextBox.Text == "")
            {
                errorLabel.Text = "Add a title. ";
                return false;
            }
            if (descriptionTextBox.Text == "")
            {
                errorLabel.Text = "Add a description.";
                return false;
            }
            if (custIDcomboBox.SelectedValue.ToString() == "")
            {
                errorLabel.Text = "Select a customer ID. ";
                return false;
            }
            if (typeComboBox.SelectedValue.ToString() == "")
            {
                errorLabel.Text = "Select an appointment type. ";
                return false;
            }
            if (locationTextBox.Text == "")
            {
                errorLabel.Text = "Add a location. ";
                return false;
            }

            if (pocTextBox.Text == "")
            {
                errorLabel.Text = "Add a POC.";
                return false;
            }

            if (urlTextBox.Text == "")
            {
                errorLabel.Text = "Add a url. ";
                return false;
            }
            return true;
        }
    }
}
