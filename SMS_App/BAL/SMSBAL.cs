using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SMS_App.BAL
{
    class SMSBAL
        {
        public int sms_id { get; set; }
        public string phoneNo { get; set; }
        public string Message { get; set; }
        public bool IsDelieverd { get; set; }
        public bool IsSeen { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool status { get; set; }
    }
}