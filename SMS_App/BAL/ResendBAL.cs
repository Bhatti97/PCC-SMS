using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SMS_App.BAL
{
    class ResendBAL
        {
        public int resend_id { get; set; }
        public int sms_id { get; set; }
        public bool status { get; set; }
    }
}