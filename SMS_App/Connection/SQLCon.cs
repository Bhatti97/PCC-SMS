using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_App.Connection
{
    class SQLCon
    {
        string server = "";
        string database = "";
        string userid = "";
        string password = "";
        private SqlConnection con;
        //

        public SQLCon()
        {
            string line = "";
            try
            {
                string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string file = dir + @"\Connection\SQLconfig.txt";
                StreamReader sr = new StreamReader(file);
                line = sr.ReadToEnd();
                string[] data = line.Split(',');

                server   = data [0].Trim();
                database = data [1].Trim();
                userid   = data [2].Trim();
                password = data [3].Trim();

                sr.Close();
                con = new SqlConnection("Data Source=" + server + "; Initial Catalog=" + database + ";User ID=" + userid + "; Password=" + password + ";");
                //"Data Source=RASHID-PC;Initial Catalog=DSection;User ID=sa; Password=Allah"
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
           
        }

        SqlCommand cmd = new SqlCommand();



        public SqlConnection getCon()
        {
            return con;
        }








    }
}
