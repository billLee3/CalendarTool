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
            customerNameTextBox.Enabled = false;
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
            if (isValid() == true)
            {
                int entryCountryID = updateCountry();
                int entryCityID = updateCity(entryCountryID);
                int entryAddressID = updateAddress(entryCityID);
                updateCustomer(entryAddressID);
                MessageBox.Show("Record updated!");
                dashboard dashboard = new dashboard();
                dashboard.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Form is invalid. ");
            }
            
           
        }

        private int updateCountry()
        {
            int countryID = 0;
            string query = $"SELECT countryId FROM country where country = '{countryTextBox.Text}'";
            MySqlCommand cmd = new MySqlCommand(query, Database.dbConnection.conn);
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                countryID = int.Parse(result.ToString());
                return countryID;
            }
            else
            {
                //Country doesn't exist. Create new country.
                string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
                string insertQuery = $"INSERT INTO country(country, createDate, createdBy, lastUpdate, lastUpdateBy ) VALUES('{countryTextBox.Text}', '{createDate}', '{GlobalConfig.userName}', '{createDate}', '{GlobalConfig.userName}')";
                MySqlCommand insertCMD = new MySqlCommand(insertQuery, Database.dbConnection.conn);
                insertCMD.ExecuteNonQuery();
                var result2 = cmd.ExecuteScalar();
                countryID = int.Parse(result2.ToString());
                return countryID;
                
            }

        }

         
        private int updateCity(int entryCountryID)
        {
             
            int cityID = 0;
            string query = $"SELECT cityId FROM city WHERE city = '{cityTextBox.Text}'";
            string countryQuery = $"SELECT countryId FROM city WHERE city = '{cityTextBox.Text}'";
            MySqlCommand cmd = new MySqlCommand(query, Database.dbConnection.conn);
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                cityID = int.Parse(result.ToString());

                MySqlCommand countryCMD = new MySqlCommand(countryQuery, Database.dbConnection.conn);
                var countryResult = countryCMD.ExecuteScalar();
                if (countryResult != null)
                {
                    int countryID = int.Parse(countryResult.ToString());
                    if (countryID != entryCountryID)
                    {
                        //May need to be an INSERT statement and not an UPDATE. 
                        string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
                        string insertCityQuery = $"INSERT INTO city(city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{cityTextBox.Text}', {entryCountryID}, '{createDate}', '{GlobalConfig.userName}', '{createDate}', '{GlobalConfig.userName}')";
                        //string updateCityQuery = $"UPDATE city SET countryId = {updateCountry()} WHERE cityId = {cityID}";
                        MySqlCommand updateCity = new MySqlCommand(insertCityQuery, Database.dbConnection.conn);
                        updateCity.ExecuteNonQuery();
                        var newID = cmd.ExecuteScalar();
                        cityID = int.Parse(newID.ToString());
                        return cityID;
                    }
                    else
                    {
                        return cityID;
                    }
                }
                else
                {
                    return cityID;
                }

            }
            else
            {
                //City Name is different so we are inserting and not updating
                
                string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
                string insertCityQuery = $"INSERT INTO city(city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{cityTextBox.Text}', {entryCountryID}, '{createDate}', '{GlobalConfig.userName}', '{createDate}', '{GlobalConfig.userName}')";
                MySqlCommand insertCMD = new MySqlCommand(insertCityQuery, Database.dbConnection.conn);
                insertCMD.ExecuteNonQuery();
                
                var insertResult = cmd.ExecuteScalar();
                cityID = int.Parse(insertResult.ToString());
                return cityID;
            }
                
            
            

            
        }

        
        private int updateAddress(int entryCityID)
        {
            
            int addressID = 0;
            int cityID = 0;
            string zip = "";
            string phoneNum = "";
            string query = $"SELECT addressId FROM address WHERE address = '{address1TextBox.Text}' AND address2 = '{address2TextBox.Text}'";
            
            MySqlCommand cmd = new MySqlCommand(query, Database.dbConnection.conn);
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                addressID = int.Parse(result.ToString());
                //Ignoring pho
                string cityQuery = $"SELECT cityId, postalCode, phone FROM address WHERE addressId = {addressID}";
                MySqlCommand cityCMD = new MySqlCommand(cityQuery, Database.dbConnection.conn);
                //var cityResult = cityCMD.ExecuteScalar();
                var reader = cityCMD.ExecuteReader();
                while (reader.Read())
                {
                    cityID = reader.GetInt32("cityId");
                    zip = reader.GetString("postalCode");
                    phoneNum = reader.GetString("phone");
                }
                reader.Close();
                if (cityID != entryCityID)
                {
                         
                    string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
                        
                    string insertAddressQuery = $"INSERT INTO address(address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{address1TextBox.Text}', '{address2TextBox.Text}', {entryCityID}, '{zipTextBox.Text}', '{phoneNumTextBox.Text}','{createDate}', '{GlobalConfig.userName}', '{createDate}', '{GlobalConfig.userName}')";
                    //string updateAddressQuery = $"UPDATE city SET countryId = {updateCountry()} WHERE cityId = {cityID}";
                    MySqlCommand insertAddress = new MySqlCommand(insertAddressQuery, Database.dbConnection.conn);
                    insertAddress.ExecuteNonQuery();
                    string newCMD = $"SELECT addressID FROM address WHERE address = '{address1TextBox.Text}' AND address2 = '{address2TextBox.Text}' AND cityId = {entryCityID}";
                    MySqlCommand selectNewID = new MySqlCommand(newCMD, Database.dbConnection.conn);
                    var newID = selectNewID.ExecuteScalar();
                    addressID = int.Parse(newID.ToString());
                    return addressID;
                }else if (zip != zipTextBox.Text)
                {
                    string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

                    string insertAddressQuery = $"INSERT INTO address(address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{address1TextBox.Text}', '{address2TextBox.Text}', {entryCityID}, '{zipTextBox.Text}', '{phoneNumTextBox.Text}','{createDate}', '{GlobalConfig.userName}', '{createDate}', '{GlobalConfig.userName}')";
                    //string updateAddressQuery = $"UPDATE city SET countryId = {updateCountry()} WHERE cityId = {cityID}";
                    MySqlCommand insertAddress = new MySqlCommand(insertAddressQuery, Database.dbConnection.conn);
                    insertAddress.ExecuteNonQuery();
                    string newCMD = $"SELECT addressID FROM address WHERE address = '{address1TextBox.Text}' AND address2 = '{address2TextBox.Text}' AND cityId = {entryCityID}";
                    MySqlCommand selectNewID = new MySqlCommand(newCMD, Database.dbConnection.conn);
                    var newID = selectNewID.ExecuteScalar();
                    addressID = int.Parse(newID.ToString());
                    return addressID;
                }
                else if (phoneNum != phoneNumTextBox.Text)
                {
                    string updateQuery = $"UPDATE address SET phone = {phoneNum} WHERE addressId = {addressID}";
                    MySqlCommand updateCMD = new MySqlCommand(updateQuery, Database.dbConnection.conn);
                    updateCMD.ExecuteNonQuery();
                    return addressID;
                }
                else
                {
                    return addressID;
                }
                

            }
            else
            {
                //Address Name is different so we are inserting and not updating
                MessageBox.Show("New address in 1 or 2");
                
                string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
                string insertAddressQuery = $"INSERT INTO address(address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{address1TextBox.Text}', '{address2TextBox.Text}', {entryCityID}, '{zipTextBox.Text}', '{phoneNumTextBox.Text}','{createDate}', '{GlobalConfig.userName}', '{createDate}', '{GlobalConfig.userName}')";
                MySqlCommand insertCMD = new MySqlCommand(insertAddressQuery, Database.dbConnection.conn);
                insertCMD.ExecuteNonQuery();

                var insertResult = cmd.ExecuteScalar();
                addressID = int.Parse(insertResult.ToString());
                return addressID;
            }
        }

        
        private void updateCustomer(int entryAddressID)
        {
            int customerID = 0;
            int active = 0;
            string query = $"SELECT customerId, active FROM customer WHERE customerName = '{customerNameTextBox.Text}'";
            MySqlCommand cmd = new MySqlCommand(query, Database.dbConnection.conn);
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customerID = reader.GetInt32("customerId");
                    active = reader.GetInt32("active");
                }
                reader.Close();
                
                string selectAddressID = $"SELECT addressId FROM customer WHERE customerId = {customerID}";
                MySqlCommand getAddressID = new MySqlCommand(selectAddressID, Database.dbConnection.conn);
                var dbAddressIdRaw = getAddressID.ExecuteScalar();
                int dbAddressID = int.Parse(dbAddressIdRaw.ToString());
                if(dbAddressID != entryAddressID)
                {
                    string updateCustAddressID = $"UPDATE customer SET addressId = {entryAddressID} WHERE customerId = {customerID}";
                    MySqlCommand updateCMD = new MySqlCommand(updateCustAddressID, Database.dbConnection.conn);
                    updateCMD.ExecuteNonQuery();
                }
                if (active != int.Parse(activeTextbox.Text))
                {
                    int activeValue = int.Parse(activeTextbox.Text);
                    string updateCustAddressID = $"UPDATE customer SET active = {activeValue} WHERE customerId = {customerID}";
                    MySqlCommand updateCMD2 = new MySqlCommand(updateCustAddressID, Database.dbConnection.conn);
                    updateCMD2.ExecuteNonQuery();
                }

            }
            else
            {
                string createDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
                string insertNewCustomer = $"INSERT INTO customer(customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{customerNameTextBox.Text}', {entryAddressID}, 1, '{createDate}', '{GlobalConfig.userName}', '{createDate}', '{GlobalConfig.userName}')";
                MySqlCommand insertCust = new MySqlCommand(insertNewCustomer, Database.dbConnection.conn);
                insertCust.ExecuteNonQuery();
            }
        }

        private bool isValid()
        {
            if (cityTextBox.Text == "")
            {
                errorLabel.Text = "You need a city name. ";
                return false;
            }
            if (countryTextBox.Text == "")
            {
                errorLabel.Text = "You need a country name.";
                return false;
            }
            if (address1TextBox.Text == "")
            {
                errorLabel.Text = "You need an address. ";
                return false;
            }
            if (customerNameTextBox.Text == "")
            {
                errorLabel.Text = "You need a customer name";
                return false;
            }
            if (zipTextBox.Text == "")
            {
                errorLabel.Text = "You need a zip code.";
                return false;
            }
            int activeNum = int.Parse(activeTextbox.Text);
            if (activeNum == 1 || activeNum == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show(activeNum.ToString());
                errorLabel.Text = "Select 1 for active and 0 for inactive.";
                return false;
            }
                
            return true;
        }
    }


}
