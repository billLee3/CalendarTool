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
    public partial class dashboard : Form
    {
        //May need to look into this piece. The Binding Source is what keeps the DGVs up to date. 
        private BindingSource appointments;
        private BindingSource customers;

        public dashboard()
        {
            InitializeComponent();
            string apptQuery = "Select * from appointment";
            string custQuery = "Select * from customer";
            

            //SQL Adapter code found at the following https://stackoverflow.com/questions/21132596/how-to-import-data-from-mysql-database-to-datagridview
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(apptQuery, Database.dbConnection.conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                appointmentsDGV.DataSource = ds.Tables[0];
            }
            appointmentsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentsDGV.ReadOnly = true;
            appointmentsDGV.MultiSelect = false;
            appointmentsDGV.AllowUserToAddRows = false;

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(custQuery, Database.dbConnection.conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                customersDGV.DataSource = ds.Tables[0];
            }
            customersDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customersDGV.ReadOnly = true;
            customersDGV.MultiSelect = false;
            customersDGV.AllowUserToAddRows = false;

            //if (!appointmentsDGV.CurrentRow.Selected)
            //{
                //var A = appointmentsDGV.CurrentRow.DataBoundItem;
            //}
        }

       

        private void newCustomerTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            appointmentsDGV.ClearSelection();
        }

        private void customerBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            customersDGV.ClearSelection();
        }

        
        
    }
}
