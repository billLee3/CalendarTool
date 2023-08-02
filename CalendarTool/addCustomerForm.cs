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
        public static int initID = -1;
        public addCustomerForm()
        {
            InitializeComponent();
        }

        public addCustomerForm(int recordID)
        {
            InitializeComponent();
            initID = recordID;
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
                    string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
                    string lastUpdate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
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
            string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            
            string lastUpdate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            
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
            string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            
            string lastUpdate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            
            //Error came up here...test with address2 filled in. 
            string createAddressQuery = $"INSERT INTO address(address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{addressName}', '{address2TextBox.Text}', {cityId}, '{zipTextBox.Text}', '{phoneNumTextBox.Text}', '{createDate}', '{GlobalConfig.userName}', '{lastUpdate}', '{GlobalConfig.userName}')";
            MySqlCommand cmd = new MySqlCommand(createAddressQuery, Database.dbConnection.conn);
            cmd.ExecuteNonQuery();
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
            string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            
            string lastUpdate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            
            string createCustomer = $"INSERT INTO customer(customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{customerName}', {addressId}, 1, '{createDate}', '{GlobalConfig.userName}', '{lastUpdate}', '{GlobalConfig.userName}')";
            MySqlCommand cmd = new MySqlCommand(createCustomer, Database.dbConnection.conn);
            cmd.ExecuteScalar();
        }
        private void createCustomerButton_Click(object sender, EventArgs e)
        {
            int addressId = 0;
            if (initID == -1)
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
                        addressId = Convert.ToInt32(result);
                        if (addressId == isAddress(address1TextBox.Text))
                        {
                            MessageBox.Show("This customer already exists.");
                            return;
                        }
                    }

                }
                else if (customerId == -1)
                {
                    createAddress(address1TextBox.Text, cityId);
                    addressId = isAddress(address1TextBox.Text);
                    createCustomer(customerNameTextBox.Text, addressId);
                    MessageBox.Show("Created new customer!");
                }
                Close();
            }
            else
            {
                //disabling customer name because if the person's name is changing then they should just be listed an inactive. 
                customerNameTextBox.Enabled = false;
                initID = isCustomer(customerNameTextBox.Text);
                //MessageBox.Show(initID.ToString());

                int addressID = isAddress(address1TextBox.Text);
                if (addressID != -1)
                {
                    int cityID = determineCity(addressID);
                    string updateAddressQuery = $"UPDATE address SET cityId = {cityID} WHERE addressId = {addressID}";
                    MySqlCommand updateAddressCMD = new MySqlCommand(updateAddressQuery, Database.dbConnection.conn);
                    updateAddressCMD.ExecuteNonQuery();
                }
                else
                {
                    int cityID = determineCity(addressID);
                    createAddress(address1TextBox.Text, cityID);
                   
                }

                
                int activeNum = Convert.ToInt32(activeTextbox.Text);
                string lastUpdate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
                
                //FOR SOME REASON
                string customerQuery = $"UPDATE customer SET addressId = {isAddress(address1TextBox.Text)}, active = {activeNum}, lastUpdate = '{lastUpdate}', lastUpdateBy = '{GlobalConfig.userName}' WHERE customerId = {initID}";

                MySqlCommand cmd = new MySqlCommand(customerQuery, Database.dbConnection.conn);
                cmd.ExecuteNonQuery();
            }
            
        }

        public int determineCity(int addressID)
        {
            string addressQuery = $"SELECT cityId FROM address WHERE addressId = {addressID}";
            MessageBox.Show($"Address ID = {addressID}");

            MySqlCommand cityCMD = new MySqlCommand(addressQuery, Database.dbConnection.conn);
            var result = cityCMD.ExecuteScalar();

            int dbCityId = 0;
            if (result != null)
            {
                int resultID = Convert.ToInt32(result);
                if (resultID == isCity(cityTextBox.Text))
                {
                    dbCityId = resultID;
                    MessageBox.Show($"ID matches previous. ID is {resultID}");
                }
                else if (isCity(cityTextBox.Text) == -1)
                {
                    //This may not work but we will test. 
                    int countryID = createCountry();
                    MessageBox.Show($"Country ID is {countryID}");
                    if (countryID == -1)
                    {
                        countryID = createCountry();
                    }
                    createCity(cityTextBox.Text, countryID);
                    dbCityId = isCity(cityTextBox.Text);
                    MessageBox.Show($"New one. ID is {dbCityId}");
                }
                else //In this case the address city exists but isn't associated with this customer
                {
                    dbCityId = isCity(cityTextBox.Text);
                    MessageBox.Show($"City existed but somewhere else. ");
                }
                
            }
            return dbCityId;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
