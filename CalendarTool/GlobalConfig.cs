using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CalendarTool
{
    class GlobalConfig
    {
        public static string userName;
        public static List<string> apptTypes = new List<string> {"Scrum", "Presentation", "Stand-up"};
        public static List<string> customerIds;


    }
}
