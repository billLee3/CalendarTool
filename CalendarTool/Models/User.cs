using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarTool.Models
{
    //Test... but I didn't need it. 
    class User
    {
        
        public int UserID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int active { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
    }
}
