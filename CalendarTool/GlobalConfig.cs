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
    class GlobalConfig
    {
        public static string userName;
        public static List<string> apptTypes = new List<string> {"Scrum", "Presentation", "Stand-up"};
        public static List<string> customerIds;

        //Using a an expression lambda in this instance allows the application to use this function throughout the code base to quickly output a MessageBox that is templatized. Increasing effeciency by reusing funtionality and dependencies within this .cs file. 
        public static Action<string> successMessage = type =>
        {
            string message = "";
            if (type == "login")
            {
                message = "You successully logged in.";
            }
            else
            {
                message = $"You successfully added {type} record to the database. ";
            }
            MessageBox.Show(message);
        };
    }
}
