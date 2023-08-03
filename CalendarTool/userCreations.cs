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
    public partial class userCreation : Form
    {
        public static List<string> users;
        public userCreation()
        {
            InitializeComponent();
            getUsers();
            cbUserNum.DataSource = users;

            createdDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            createdDGV.ReadOnly = true;
            createdDGV.MultiSelect = false;
            createdDGV.AllowUserToAddRows = false;

            string user = cbUserNum.SelectedValue.ToString();
           
            loadDGV(user);

        }

        public void loadDGV(string userName)
        {
            createdDGV.ClearSelection();
            string query = $"SELECT createdBy, title, type, start, end, location FROM appointment WHERE createdBy = '{userName}'";
            DataTable dt = new DataTable();
            using(MySqlDataAdapter adp = new MySqlDataAdapter(query, Database.dbConnection.conn))
            {
                adp.Fill(dt);
                DataView dv = dt.DefaultView;
                createdDGV.DataSource = dv;
            }
        }

        public void getUsers()
        {
            string query = "SELECT userName FROM user";

            DataTable dt = new DataTable();
            using (MySqlDataAdapter adp = new MySqlDataAdapter(query, Database.dbConnection.conn))
            {
                
                adp.Fill(dt);


                List<string> tempList = new List<string>();

                //Running a for loop via a lambda function. 
                dt.Rows.Cast<DataRow>().ToList().ForEach(row => tempList.Add(row[0].ToString()));
                users = tempList;
               

                 
                


            }
        }

        private void cbCustNum_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cbUserNum.SelectedIndex;
            string userName = users[index];
            loadDGV(userName);
        }
    }
}
