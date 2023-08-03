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
    public partial class customerSchedule : Form
    {
        public customerSchedule()
        {
            InitializeComponent();
            getCustomerIDs();
            cbCustNum.DataSource = GlobalConfig.customerIds;

            scheduleDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            scheduleDGV.ReadOnly = true;
            scheduleDGV.MultiSelect = false;
            scheduleDGV.AllowUserToAddRows = false;

            int index = cbCustNum.SelectedIndex;
            int customerID = int.Parse(GlobalConfig.customerIds[index]);
            loadDGV(customerID);

        }

        public void loadDGV(int customerID)
        {
            scheduleDGV.ClearSelection();
            string query = $"SELECT title, type, start, end, location FROM appointment WHERE customerId = {customerID}";
            DataTable dt = new DataTable();
            using(MySqlDataAdapter adp = new MySqlDataAdapter(query, Database.dbConnection.conn))
            {
                adp.Fill(dt);
                DataView dv = dt.DefaultView;
                dv.Sort = "start";
                scheduleDGV.DataSource = dv;
            }
        }

        public void getCustomerIDs()
        {
            string query = "SELECT customerId FROM customer";


            using (MySqlDataAdapter adp = new MySqlDataAdapter(query, Database.dbConnection.conn))
            {
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                int rows = dt.Rows.Count;
                List<string> list = new List<string>();

                //Running a for loop via a lambda function. 
                dt.Rows.Cast<DataRow>().ToList().ForEach(row => list.Add(row[0].ToString()));
                GlobalConfig.customerIds = list;

                //using lamdba expression to efficiently reorder the code so the order is sequential. 
                List<string> ids = GlobalConfig.customerIds.OrderBy(i => i).ToList();
                GlobalConfig.customerIds = ids;


            }
        }

        private void cbCustNum_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cbCustNum.SelectedIndex;
            int customerID = int.Parse(GlobalConfig.customerIds[index]);
            loadDGV(customerID);
        }
    }
}
