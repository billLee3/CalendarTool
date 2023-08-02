using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CalendarTool
{
    class Validator
    {
        public bool withinBusinessHours(DateTime start, DateTime end)
        {
            
            if (start.Hour >= 12 && start.Hour < 20)
            {
                MessageBox.Show("Start Time is in range.");
                if(end.Hour < 20 && end.Hour >= 12)
                {
                    return true;
                }else if (end.Hour == 20 && end.Minute == 0 && end.Second == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        public bool overlappingAppointment(string startDate, string endDate)
        {
            DataTable dataTable = new DataTable();
            //Checking all three overlap conditions
            string startOverlapQuery = $"SELECT appointmentId FROM appointment WHERE start >= '{startDate}' AND start < '{endDate}'";
            string endOverlapQuery = $"SELECT appointmentId FROM appointment WHERE end > '{startDate}' AND end <= '{endDate}'";
            string bothOverlapQuery = $"SELECT appointmentId FROM appointment WHERE start <= '{startDate}' AND end >= '{endDate}'";
            //Filling the datatable on these three conditions
            int startAdp = new MySqlDataAdapter(startOverlapQuery, Database.dbConnection.conn).Fill(dataTable);
            int endAdp = new MySqlDataAdapter(endOverlapQuery, Database.dbConnection.conn).Fill(dataTable);
            int bothAdp = new MySqlDataAdapter(bothOverlapQuery, Database.dbConnection.conn).Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool overlappingEnd(DateTime startDate, DateTime endDate)
        {
            string query = $"SELECT * FROM appointment WHERE end BETWEEN {startDate} AND {endDate}";
            return false;
        }

        public bool isCustomer(string customerId)
        {
            string query = $"SELECT * FROM customer WHERE customerId = '{customerId}'";
            MySqlCommand cmd = new MySqlCommand(query, Database.dbConnection.conn);
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }


            return false;
        }
    }
}
