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
		public LoginForm()
		{
			InitializeComponent();
            actualTimeZoneLabel.Text = TimeZoneInfo.Local.StandardName;
			
		}

        private void loginButton_Click(object sender, EventArgs e)
        {
            //add logic to determine if the username is in the database. 
            //if the username is in the database does the password match? 
            if (usernameTextbox.Text != "admin")
            {
                errorLabel.Text = "Username is not in the system.";
            }
            else if (passwordTextBox.Text != "password")
            {
                errorLabel.Text = "Password is incorrect";
            }
            else
            {
                dashboard dashboard = new dashboard();
                dashboard.Show();
            }
            //yes then dashboard action


            //no, then pop an error message. 
            //else... username does not exist
        }
    }
}
