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
    
    public partial class updateCustomerForm : Form
    {
        public static int recordID;
        public updateCustomerForm()
        {
            InitializeComponent();
        }

        public updateCustomerForm(int recordID) 
        {
            InitializeComponent();
            customerNumTextBox.Enabled = false;
            customerNumTextBox.Text = recordID.ToString();
            int addressId = 0;
            string customer = $"SELECT * FROM customer WHERE customerId = {recordID}";
            MySqlCommand cmd = new MySqlCommand(customer, Database.dbConnection.conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                customerNameTextBox.Text = $"{reader.GetString("customerName")}";
                activeTextbox.Text = $"{reader.GetInt32("active").ToString()}";
                addressId = reader.GetInt32("addressId");
            }

            reader.Close();
            string address = $"SELECT * FROM address WHERE addressId = {addressId}";
            MySqlCommand addressCmd = new MySqlCommand(address, Database.dbConnection.conn);
            MySqlDataReader addressReader = addressCmd.ExecuteReader();

            int cityId = 0;

            while (addressReader.Read())
            {
                address1TextBox.Text = $"{addressReader.GetString("address")}";
                address2TextBox.Text = $"{addressReader.GetString("address2")}";
                zipTextBox.Text = $"{addressReader.GetString("postalCode")}";
                phoneNumTextBox.Text = $"{addressReader.GetString("phone")}";
                
                cityId = addressReader.GetInt32("cityId");
            }
            addressReader.Close();

            string city = $"SELECT * FROM city WHERE cityId = {cityId}";
            MySqlCommand cityCmd = new MySqlCommand(city, Database.dbConnection.conn);
            reader = cityCmd.ExecuteReader();

            int countryId = 0;
            while (reader.Read())
            {
                cityTextBox.Text = $"{reader.GetString("city")}";
                countryId = reader.GetInt32("countryId");
            }
            reader.Close();
            string country = $"SELECT * FROM country WHERE countryId = {countryId}";
            MySqlCommand countryCmd = new MySqlCommand(country, Database.dbConnection.conn);
            reader = countryCmd.ExecuteReader();

            while (reader.Read())
            {
                countryTextBox.Text = $"{reader.GetString("country")}";
            }
            reader.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createCustomerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
