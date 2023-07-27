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
    public partial class CalendarView : Form
    {
        BindingSource appointments;
        DataView dataView;
        public CalendarView()
        {
            InitializeComponent();
            allRadioButton.Checked = true;



            string apptQuery = "Select * from appointment";
            int index = 0;
            MySqlCommand cmd = new MySqlCommand(apptQuery, Database.dbConnection.conn);

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(apptQuery, Database.dbConnection.conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                appointmentCalendarDGV.DataSource = ds.Tables[0];
                DataTable fullTable = ds.Tables[0];
                dataView = new DataView(fullTable);
            }
            appointmentCalendarDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentCalendarDGV.ReadOnly = true;
            appointmentCalendarDGV.MultiSelect = false;
            appointmentCalendarDGV.AllowUserToAddRows = false;
            

        }

        private void weeklyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            int subtractToBegin = 0;
            int addToEnd = 0;
            DateTime today = DateTime.Today;
            string dayOfWeek = DateTime.Today.DayOfWeek.ToString();
            MessageBox.Show(dayOfWeek);
            switch (dayOfWeek)
            {
                case "Sunday":
                    addToEnd = 6;
                    break;
                case "Monday":
                    subtractToBegin = -1;
                    addToEnd = 5;
                    break;
                case "Tuesday":
                    subtractToBegin = -2;
                    addToEnd = 4;
                    break;
                case "Wednesday":
                    subtractToBegin = -3;
                    addToEnd = 3;
                    break;
                case "Thursday":
                    subtractToBegin = -4;
                    addToEnd = 2;
                    break;
                case "Friday":
                    subtractToBegin = -5;
                    addToEnd = 1;
                    break;
                case "Saturday":
                    subtractToBegin = -6;
                    break;
            }

            DateTime beginningWeek = today.AddDays(subtractToBegin);
            DateTime endWeek = today.AddDays(addToEnd);
            string begin = beginningWeek.ToString("yyyy-MM-dd hh:mm:ss");
            string end = endWeek.ToString("yyyy-MM-dd hh:mm:ss");

            string query = $"SELECT * FROM appointment WHERE (start BETWEEN '{begin}' AND '{end}')";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, Database.dbConnection.conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                appointmentCalendarDGV.DataSource = ds.Tables[0];
            }
        }

        private void monthlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            int month = DateTime.Today.Month;
            int year = DateTime.Today.Year;
            int addAmount = 0;
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                addAmount = 31;
            }else if (month == 2)
            {
                if (year % 4 == 0)
                {
                    addAmount = 29;
                }else if (year % 400 == 0 && year % 100 == 0)
                {
                    addAmount = 29;
                }
                else
                {
                    addAmount = 28;
                }
            }
            else
            {
                addAmount = 30;
            }
            
            //Only checking current year and month
            
            string startDate = $"{year}-0{month}-01 00:00:00";
            string endDate = $"{year}-0{month}-{addAmount} 23:59:59";

            string query = $"SELECT * FROM appointment WHERE (start BETWEEN '{startDate}' AND '{endDate}')";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, Database.dbConnection.conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                appointmentCalendarDGV.DataSource = ds.Tables[0];
            }




        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           

            //FILTER TABLE. BETWEEN THE 2 DATES
        }
    }
}
