using SMS_App.BAL;
using SMS_App.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
namespace SMS_App.DAL
{
    class ContactsDAL
        {

            //SQL Objects
            //Connection
            private SqlConnection con = new SQLCon().getCon();        private SqlCommand cmd = new SqlCommand();

        public void Add(ContactsBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Contacts_Insert";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@cnt_FirstName", SqlDbType.VarChar).Value = obj.cnt_FirstName;
             cmd.Parameters.Add("@cnt_LastName", SqlDbType.VarChar).Value = obj.cnt_LastName;
             cmd.Parameters.Add("@cnt_Number", SqlDbType.VarChar).Value = obj.cnt_Number;
             cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.ExecuteNonQuery();
                con.Close();
                    }
                    catch (SqlException e1)
                    {
                       MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

        public void Update(ContactsBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Contacts_Update";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@cnt_id", SqlDbType.Int).Value = obj.cnt_id;
             cmd.Parameters.Add("@cnt_FirstName", SqlDbType.VarChar).Value = obj.cnt_FirstName;
             cmd.Parameters.Add("@cnt_LastName", SqlDbType.VarChar).Value = obj.cnt_LastName;
             cmd.Parameters.Add("@cnt_Number", SqlDbType.VarChar).Value = obj.cnt_Number;
             cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.ExecuteNonQuery();
                con.Close();
                    }
                    catch (SqlException e1)
                    {
                       MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

        public ContactsBAL LoadbyId(int obj)
        {
            try
            {
                //Local

          SqlDataReader dr;
         con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Contacts_LOADByID";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@cnt_id", SqlDbType.Int).Value = obj;
                dr = cmd.ExecuteReader();
 ContactsBAL obj1 = new ContactsBAL();                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                       float x = 0;                obj1.cnt_id = Convert.ToInt32(dr["cnt_id"].ToString());
                obj1.cnt_FirstName = dr["cnt_FirstName"].ToString();
                obj1.cnt_LastName = dr["cnt_LastName"].ToString();
                obj1.cnt_Number = dr["cnt_Number"].ToString();
                obj1.status =(bool) dr["status"];

         }
         }
         dr.Close();
           con.Close();
          return obj1;                
}
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public List<ContactsBAL> LoadAll()
        {
            try
            {
                //Local

          SqlDataReader dr;
                 List<ContactsBAL> listt = new List<ContactsBAL>();
          con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Contacts_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ContactsBAL obj1 = new ContactsBAL();
                float x=0;                obj1.cnt_id = Convert.ToInt32(dr["cnt_id"].ToString());
                obj1.cnt_FirstName = dr["cnt_FirstName"].ToString();
                obj1.cnt_LastName = dr["cnt_LastName"].ToString();
                obj1.cnt_Number = dr["cnt_Number"].ToString();
                obj1.status =(bool) dr["status"];
                listt.Add(obj1);
         }
         }
         dr.Close();
           con.Close();
                return listt; 
}
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public List<ContactsBAL> Search(ContactsBAL obj)
        {
            try
            {
                //Local

          SqlDataReader dr;
                 List<ContactsBAL> listt = new List<ContactsBAL>();
         con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Contacts_Search";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@cnt_id", SqlDbType.Int).Value = obj.cnt_id;
             cmd.Parameters.Add("@cnt_FirstName", SqlDbType.VarChar).Value = obj.cnt_FirstName;
             cmd.Parameters.Add("@cnt_LastName", SqlDbType.VarChar).Value = obj.cnt_LastName;
             cmd.Parameters.Add("@cnt_Number", SqlDbType.VarChar).Value = obj.cnt_Number;
             cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ContactsBAL obj1 = new ContactsBAL();
float x = 0;                obj1.cnt_id = Convert.ToInt32(dr["cnt_id"].ToString());
                obj1.cnt_FirstName = dr["cnt_FirstName"].ToString();
                obj1.cnt_LastName = dr["cnt_LastName"].ToString();
                obj1.cnt_Number = dr["cnt_Number"].ToString();
                obj1.status =(bool) dr["status"];
listt.Add(obj1);
         }
         }
         dr.Close();
           con.Close();
                return listt; 
}
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public List<ContactsBAL> LoadAll_SQLQuery(string query)
        {
            try
            {
                //Local

          SqlDataReader dr;
                 List<ContactsBAL> listt = new List<ContactsBAL>();
          con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "query";
                

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ContactsBAL obj1 = new ContactsBAL();
                float x=0;                obj1.cnt_id = Convert.ToInt32(dr["cnt_id"].ToString());
                obj1.cnt_FirstName = dr["cnt_FirstName"].ToString();
                obj1.cnt_LastName = dr["cnt_LastName"].ToString();
                obj1.cnt_Number = dr["cnt_Number"].ToString();
                obj1.status =(bool) dr["status"];
                listt.Add(obj1);
         }
         }
         dr.Close();
           con.Close();
                return listt; 
}
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public void Delete(int id)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Contacts_Delete";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@cnt_id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
                con.Close();
                    }
                    catch (SqlException e1)
                    {
                       MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
        }
}