using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_App
{
    public static class PhoneBookLocalStorage
    {
        public static List<string> list = new List<string>();
        public static bool phonebookSMSWindowOpen = false;
        public static bool localStorageReaded = false;
        public static bool IsInList(string str)
        {            
                string[] temp = str.Split(',');
                for (int i = 0; i < temp.Length; i++)
                {
                    if (list.Where(m => m.Equals(temp[i])).Count() > 0)
                    return true;
                }
            
            return false;
        }
        public static List<string> GetList()
        {
            return list;
        }
      

    }
  
}
