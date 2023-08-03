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
    public partial class MonthlyTypes : Form
    {
        
        List<int> monthNumList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        public MonthlyTypes()
        {
            InitializeComponent();
            cbMonth.DataSource = monthNumList;
            //Default Value is the first in the list. 
            int index = cbMonth.SelectedIndex;
            loadValues(monthNumList[index]);

            
        }

        public void loadValues(int month)
        {
            
            int presentationCount = 0;
            int scrumCount = 0;
            int standUpCount = 0;
            string query = $"SELECT * FROM appointment";
            DataTable dt = new DataTable();

            using (MySqlDataAdapter adp = new MySqlDataAdapter(query, Database.dbConnection.conn))
            {
                adp.Fill(dt);
                foreach(DataRow row in dt.Rows)
                {
                    DateTime start = row.Field<DateTime>("start");
                    DateTime end = row.Field<DateTime>("end");
                    int startMonthNum = start.Month;
                    int endMonthNum = end.Month;
                   
                    if(startMonthNum == month || endMonthNum == month)
                    {
                        string type = row.Field<string>("type");
                        switch (type)
                        {
                            case "Presentation":
                                presentationCount++;
                                break;
                            case "Scrum":
                                scrumCount++;
                                break;
                            case "Stand-up":
                                standUpCount++;
                                break;
                        }
                    }

                }
            }
            presentationNum.Text = presentationCount.ToString();
            scrumNum.Text = scrumCount.ToString();
            standUpNum.Text = standUpCount.ToString();

        }

        private void cbMonth_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cbMonth.SelectedIndex;
            loadValues(monthNumList[index]);
        }
    }
}
