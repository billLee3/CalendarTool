using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarTool
{
    class Validator
    {
        public bool withinBusinessHours(DateTime start, DateTime end)
        {
            //8AM EST is 12PM UTC
            string startTimeUTC = "12:00:00";
            //4PM EST is 8PM UTC
            string endTimeUTC = "20:00:00";

            if (start.Hour >= 12 && start.Hour < 20)
            {
                MessageBox.Show("Start Time is in range.");
                if(end.Hour < 20 && end.Hour > 12)
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
    }
}
