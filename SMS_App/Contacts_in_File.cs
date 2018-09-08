using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_App
{
    class Contacts_in_File
    {
        public string GetContacts(string file)
        {
            try
            {
                StreamReader sr = new StreamReader(file);
                var line= sr.ReadToEnd();
                string[] data = line.Split(',');
                string no = "";
                for (int i = 0; i < data.Length; i++)
                {
                    if (i != data.Length - 1)
                    {
                        no += data[i].Trim() + ",";
                    }
                    else
                    {
                        no += data[i].Trim();
                    }
                }
                return no;

            }
            catch (Exception)
            {
                return null;
            }
                    
        }
    }
}
