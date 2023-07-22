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
                    string createdBy = "test";
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
            string createdBy = "test";
            string lastUpdate = DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss");
            string lastUpdateBy = "test";
            string createCity = $"INSERT INTO city(city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('{cityName}', {country}, '{createDate}', '{createdBy}', '{lastUpdate}', '{lastUpdateBy}')";
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
        public void createAddress()
        {
            //Takes City Code

            //if address exists then do nothing

            //else add city to database

            //return ID
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
            
            MessageBox.Show(cityId.ToString());
            

        }

        //Save button
    }
}
