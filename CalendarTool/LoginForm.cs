using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
            string userQuery = $"Select * from user where userName = '{usernameTextbox.Text}'";



            using (MySqlDataAdapter adapter = new MySqlDataAdapter(userQuery, Database.dbConnection.conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable userTable = ds.Tables[0];
                try
                {
                    DataRow row1 = userTable.Rows[0];
                    string userName = row1.Field<String>("userName");
                    if (userName == usernameTextbox.Text)
                    {

                        string password = row1.Field<String>("password");
                        if (password == passwordTextBox.Text)
                        {
                            
                            GlobalConfig.userName = usernameTextbox.Text;

                            writeLog(GlobalConfig.userName, "success");
                            GlobalConfig.successMessage("login");
                            notificationCheck(userName);
                            dashboard dashboard = new dashboard();
                            dashboard.Show();

                        }
                        else
                        {
                            errorLabel.Text = GlobalValues.passwordWarningText;
                            writeLog(usernameTextbox.Text, "failure");
                        }
                    }
                }catch (Exception ex)
                {
                    errorLabel.Text = GlobalValues.usernameWarningText;
                }
                
                
                
            }
        }

        private void loginExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void writeLog(string userName, string status)
        {
            //Saves to debug folder within bin folder. 
            //REFERENCE: string exe_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            
            string exe_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
               
                using(StreamWriter w = File.AppendText(exe_path + "\\" + "log.txt"))
                {
                    if (status == "success")
                    {
                        w.WriteLine("Successful Login: ");
                        w.WriteLine($"User: {userName}");
                        w.WriteLine($"TimeStamp: {DateTime.UtcNow.ToString()}");
                        w.WriteLine("---------------------");
                    }
                    else
                    {
                        w.WriteLine("Failed Login Attempt: ");
                        w.WriteLine($"User: {userName}");
                        w.WriteLine($"TimeStamp: {DateTime.UtcNow.ToString()}");
                        w.WriteLine("---------------------");
                    }
                    
                }
                
            }catch (Exception ex)
            {
                MessageBox.Show("Writer failed");
            }
        }



        private void notificationCheck(string username)
        {
            string apptQuery = $"Select * from appointment WHERE createdBy = {username}";
            DateTime now = DateTime.UtcNow;


            //SQL Adapter code found at the following https://stackoverflow.com/questions/21132596/how-to-import-data-from-mysql-database-to-datagridview
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(apptQuery, Database.dbConnection.conn))
            {

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                

                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    //15 Minutes
                    string start = dt.Rows[idx]["start"].ToString();
                    DateTime startDt = DateTime.Parse(start);
                    System.TimeSpan diff = now.Subtract(startDt);
                    double seconds = diff.TotalSeconds;

                    if (seconds <= 900 && seconds > 0)
                    {
                        MessageBox.Show("You have a meeting in within the next 15 minutes. ");
                    }
                }

                
            }
        }
    }
}
