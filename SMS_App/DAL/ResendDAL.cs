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
    class ResendDAL
        {

            //SQL Objects
            //Connection
            private SqlConnection con = new SQLCon().getCon();        private SqlCommand cmd = new SqlCommand();

        public void Add(ResendBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Resend_Insert";
                cmd.Parameters.Clear();

                cmd.Parameters.Add("@sms_id", SqlDbType.Int).Value = obj.sms_id;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        

        public void Update(ResendBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Resend_Update";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@resend_id", SqlDbType.Int).Value = obj.resend_id;
             cmd.Parameters.Add("@sms_id", SqlDbType.Int).Value = obj.sms_id;
             cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.ExecuteNonQuery();
                con.Close();
                    }
                    catch (SqlException e1)
                    {
                       MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

        public List<ResendBAL> LoadbyId(ResendBAL obj)
        {
            try
            {
                //Local

          SqlDataReader dr;
                 List<ResendBAL> listt = new List<ResendBAL>();
         con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Resend_LOADByID";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@resend_id", SqlDbType.Int).Value = obj.resend_id;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ResendBAL obj1 = new ResendBAL();
float x = 0;                obj1.resend_id = Convert.ToInt32(dr["resend_id"].ToString());
                obj1.sms_id = Convert.ToInt32(dr["sms_id"].ToString());
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

        public List<ResendBAL> LoadAll()
        {
            try
            {
                //Local

          SqlDataReader dr;
                 List<ResendBAL> listt = new List<ResendBAL>();
          con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Resend_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ResendBAL obj1 = new ResendBAL();
                float x=0;                obj1.resend_id = Convert.ToInt32(dr["resend_id"].ToString());
                obj1.sms_id = Convert.ToInt32(dr["sms_id"].ToString());
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

        public List<ResendBAL> Search(ResendBAL obj)
        {
            try
            {
                //Local

          SqlDataReader dr;
                 List<ResendBAL> listt = new List<ResendBAL>();
         con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Resend_Search";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@resend_id", SqlDbType.Int).Value = obj.resend_id;
             cmd.Parameters.Add("@sms_id", SqlDbType.Int).Value = obj.sms_id;
             cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ResendBAL obj1 = new ResendBAL();
float x = 0;                obj1.resend_id = Convert.ToInt32(dr["resend_id"].ToString());
                obj1.sms_id = Convert.ToInt32(dr["sms_id"].ToString());
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

        public void Delete(ResendBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Resend_Delete";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@resend_id", SqlDbType.Int).Value = obj.resend_id;
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