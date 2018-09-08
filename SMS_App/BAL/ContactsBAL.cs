using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SMS_App.BAL
{
    class ContactsBAL
        {
        public int cnt_id { get; set; }
        public string cnt_FirstName { get; set; }
        public string cnt_LastName { get; set; }
        public string cnt_Number { get; set; }
        public bool status { get; set; }
    }
}