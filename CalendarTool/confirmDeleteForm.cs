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
    public partial class confirmDeleteForm : Form
    {
        public static string type;
        public static object id;
        public confirmDeleteForm()
        {
            InitializeComponent();
        }

        public confirmDeleteForm(string objType, object objId)
        {
            InitializeComponent();
            type = objType;
            id = objId;

            
            disclaimerLabel.Text = $"Are you sure you want to delete this {objType}?";
            
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            
            if (id != null)
            {
                string deleteQuery = "";
                if (type == "appointment")
                {
                    deleteQuery = $"DELETE FROM appointment WHERE appointmentId = {id}";
                }else if (type == "customer")
                {
                    deleteQuery = $"DELETE FROM customer WHERE customerId = {id}";
                }
                
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(deleteQuery, Database.dbConnection.conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                }
                MessageBox.Show("You deleted the appointment. ");
                dashboard dashboard = new dashboard();
                dashboard.Show();
                Close();
            }
        }

        private void No_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
