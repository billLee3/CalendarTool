﻿using System;
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
        
        public dashboard()
        {
            InitializeComponent();
            string apptQuery = "Select * from appointment";
            string custQuery = "Select * from customer";
            DateTime now = DateTime.UtcNow;
            

            //SQL Adapter code found at the following https://stackoverflow.com/questions/21132596/how-to-import-data-from-mysql-database-to-datagridview
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(apptQuery, Database.dbConnection.conn))
            {
                
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                appointmentsDGV.DataSource = dt;

                for (int idx = 0; idx < dt.Rows.Count; idx++)
                {
                    
                    dt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                    dt.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["end"], TimeZoneInfo.Local).ToString();
                    dt.Rows[idx]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["createDate"], TimeZoneInfo.Local).ToString();
                    dt.Rows[idx]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[idx]["lastUpdate"], TimeZoneInfo.Local).ToString();
                }
                
                
            }
            appointmentsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentsDGV.ReadOnly = true;
            appointmentsDGV.MultiSelect = false;
            appointmentsDGV.AllowUserToAddRows = false;

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(custQuery, Database.dbConnection.conn))
            {
                DataTable dt2 = new DataTable();
                adapter.Fill(dt2);

                customersDGV.DataSource = dt2;

                for (int idx = 0; idx < dt2.Rows.Count; idx++)
                { 
                    dt2.Rows[idx]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt2.Rows[idx]["createDate"], TimeZoneInfo.Local).ToString();
                    dt2.Rows[idx]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt2.Rows[idx]["lastUpdate"], TimeZoneInfo.Local).ToString();
                }
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

		private void createApptButton_Click(object sender, EventArgs e)
		{
            addAppointmentForm newForm = new addAppointmentForm();
            newForm.Show();
		}

		private void updateApptButton_Click(object sender, EventArgs e)
		{
            var selectedRowIndex = (int)(appointmentsDGV.CurrentCell.RowIndex);
            var selectedApptID = appointmentsDGV.Rows[selectedRowIndex].Cells[0].Value;

            if (selectedApptID != null) 
            {
                updateAppointmentForm updateForm = new updateAppointmentForm((int)selectedApptID);
                updateForm.Show();
            }

            Close();
		}

		private void deleteApptButton_Click(object sender, EventArgs e)
		{
            var selectedRowIndex = (int)(appointmentsDGV.CurrentCell.RowIndex);
            var selectedApptID = appointmentsDGV.Rows[selectedRowIndex].Cells[0].Value;
            confirmDeleteForm confirmDelete = new confirmDeleteForm("appointment", selectedApptID);
            confirmDelete.Show();
		}

		private void createCustomerButton_Click(object sender, EventArgs e)
		{
            addCustomerForm newForm = new addCustomerForm();
            newForm.Show();
        }

		private void updateCustomerButton_Click(object sender, EventArgs e)
		{
            var selectedRowIndex = (int)(customersDGV.CurrentCell.RowIndex);
            var selectedCustomerID = customersDGV.Rows[selectedRowIndex].Cells[0].Value;

            if (selectedCustomerID != null)
            {
                updateCustomerForm updateForm = new updateCustomerForm((int)selectedCustomerID);
                updateForm.Show();

                this.Close();
            }
        }

		private void deleteCustomerButton_Click(object sender, EventArgs e)
		{
            var selectedRowIndex = (int)(customersDGV.CurrentCell.RowIndex);
            var selectedCustID = customersDGV.Rows[selectedRowIndex].Cells[0].Value;

            confirmDeleteForm confirmDelete = new confirmDeleteForm("customer", selectedCustID);
            confirmDelete.Show();
            Close();
        }

        private void monthlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void calendarView_Click(object sender, EventArgs e)
        {
            CalendarView calendarView = new CalendarView();
            calendarView.Show();
        }

        private void typebyMonthButton_Click(object sender, EventArgs e)
        {
            MonthlyTypes monthlyTypes = new MonthlyTypes();
            monthlyTypes.Show();

            this.Close();
        }

        private void customerScheduleButton_Click(object sender, EventArgs e)
        {
            customerSchedule customerSchedule = new customerSchedule();
            customerSchedule.Show();

            this.Close();
        }

        private void userCreationsButton_Click(object sender, EventArgs e)
        {
            userCreation userCreation = new userCreation();
            userCreation.Show();

            this.Close();
        }
    }
}
