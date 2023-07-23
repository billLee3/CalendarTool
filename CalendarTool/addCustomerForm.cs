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
    public partial class addCustomerForm : Form
    {
        public addCustomerForm()
        {
            InitializeComponent();
        }

        public int createCountry()
        {
            //Query the country table
            string countryName = countryTextBox.Text;
            string countryQuery = $"SELECT countryId FROM country WHERE country = '{countryName}'";
            
                try
                {
                MySqlCommand cmd = new MySqlCommand(countryQuery, Database.dbConnection.conn);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    int id = Convert.ToInt32(result);
                    return id;
                }
                else
                { 
                    string createdBy = GlobalConfig.userName;
                    string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss");
                    string lastUpdate = DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss");
                    //Need to make sure the date times are in the right format. 
                    string countryAddString = $"INSERT INTO country(country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{countryName}', '{createDate}', '{createdBy}', '{lastUpdate}', '{createdBy}')";
                    try 
                    {
                        MySqlCommand cmd2 = new MySqlCommand(countryAddString, Database.dbConnection.conn);
                        cmd2.ExecuteScalar();
                    }
                    catch (Exception ex2) 
                    {
                        MessageBox.Show(ex2.ToString());
                        return -1;
                    }

                    MySqlCommand cmd3 = new MySqlCommand(countryQuery, Database.dbConnection.conn);
                    var result2 = cmd3.ExecuteScalar();
                    if (result2 != null)
                    {
                        int id = Convert.ToInt32(result2);
                        return id;
                    }
                    else { return -1; }
                
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return -1;
                }
                //return ID
            
        }

        public int isCity(string cityName)
        {
            
            string cityQuery = $"SELECT cityId FROM city WHERE city = '{cityName}'";
            MySqlCommand cmd = new MySqlCommand(cityQuery, Database.dbConnection.conn);
            try 
            {
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    int id = Convert.ToInt32(result);
                    return id;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return -1;
        }

        public void createCity(string cityName, int countryId)
        {
            int country = countryId;
            string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss");
            
            string lastUpdate = DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss");
            
            string createCity = $"INSERT INTO city(city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{cityName}', {country}, '{createDate}', '{GlobalConfig.userName}', '{lastUpdate}', '{GlobalConfig.userName}')";
            MySqlCommand cmd = new MySqlCommand(createCity, Database.dbConnection.conn);
            cmd.ExecuteScalar();
        }

        public int isAddress(string addressName)
        {

            string cityQuery = $"SELECT addressId FROM address WHERE address = '{addressName}'";
            MySqlCommand cmd = new MySqlCommand(cityQuery, Database.dbConnection.conn);
            try
            {
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    int id = Convert.ToInt32(result);
                    return id;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return -1;
        }
        public void createAddress(string addressName, int cityId)
        {
            int country = cityId;
            string postalCode = zipTextBox.Text;
            string phoneNum = phoneNumTextBox.Text;
            string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss");
            
            string lastUpdate = DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss");
            
            //LEFT OFF HERE
            string createAddressQuery = $"INSERT INTO address(address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{addressName}', '{address2TextBox.Text}', {cityId}, '{zipTextBox.Text}', '{phoneNumTextBox.Text}', '{createDate}', '{GlobalConfig.userName}', '{lastUpdate}', '{GlobalConfig.userName}')";
            MySqlCommand cmd = new MySqlCommand(createAddressQuery, Database.dbConnection.conn);
            cmd.ExecuteScalar();
        }

        public int isCustomer(string customerName)
        {
            string customerQuery = $"SELECT customerId FROM customer WHERE customerName = '{customerName}'";
            MySqlCommand cmd = new MySqlCommand(customerQuery, Database.dbConnection.conn);
            try
            {
                var result = cmd.ExecuteScalar();
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

        public void createCustomer(string customerName, int addressId)
        {
            string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss");
            
            string lastUpdate = DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss");
            
            string createCustomer = $"INSERT INTO customer(customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{customerName}', {addressId}, 1, '{createDate}', '{GlobalConfig.userName}', '{lastUpdate}', '{GlobalConfig.userName}')";
            MySqlCommand cmd = new MySqlCommand(createCustomer, Database.dbConnection.conn);
            cmd.ExecuteScalar();
        }
        private void createCustomerButton_Click(object sender, EventArgs e)
        {
            int countryID = createCountry();
            int cityId = isCity(cityTextBox.Text);
            if (cityId == -1)
            {
                createCity(cityTextBox.Text, countryID);
                cityId = isCity(cityTextBox.Text);
            }

            int customerId = isCustomer(customerNameTextBox.Text);
            MessageBox.Show((customerNameTextBox.Text));
            MessageBox.Show(customerId.ToString());
            if (customerId != -1)
            {
                string getAddressId = $"SELECT addressId FROM customer WHERE customerId = {customerId}";
                MySqlCommand cmd = new MySqlCommand(getAddressId, Database.dbConnection.conn);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    int addressId = Convert.ToInt32(result);
                    if (addressId == isAddress(address1TextBox.Text))
                    {
                        MessageBox.Show("This customer already exists.");
                        return;
                    }
                }
                
            }
            else if(customerId == -1)
            {
                createAddress(address1TextBox.Text, cityId);
                int addressId = isAddress(address1TextBox.Text);
                createCustomer(customerNameTextBox.Text, addressId);
                MessageBox.Show("Created new customer!");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
