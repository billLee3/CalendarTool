using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CalendarTool
{
	public partial class LoginForm : Form
	{
        private BindingSource userBindingSource;
		public LoginForm()
		{
			InitializeComponent();
            actualTimeZoneLabel.Text = TimeZoneInfo.Local.StandardName;
            Database.dbConnection.startConnection();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //add logic to determine if the username is in the database. 
            //if the username is in the database does the password match? 
            string userQuery = "Select * from user";



            using (MySqlDataAdapter adapter = new MySqlDataAdapter(userQuery, Database.dbConnection.conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable userTable = ds.Tables[0];
                DataRow row1 = userTable.Rows[0];
                string userName = row1.Field<String>("userName");
                if (userName == usernameTextbox.Text)
                {
                    
                    string password = row1.Field<String>("password");
                    if (password == passwordTextBox.Text)
                    {
                        dashboard dashboard = new dashboard();
                        dashboard.Show();
                       
                    } else
                    {
                        errorLabel.Text = GlobalValues.passwordWarningText;
                    }
                }
                else
                {
                    errorLabel.Text = GlobalValues.usernameWarningText;
                }
                //Figure out the ORM and classes here. 



                //yes then dashboard action


                //no, then pop an error message. 
                //else... username does not exist
            }
        }

        private void loginExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
