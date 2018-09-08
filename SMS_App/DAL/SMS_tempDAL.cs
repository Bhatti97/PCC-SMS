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
    class SMS_tempDAL
        {

            //SQL Objects
            //Connection
            private SqlConnection con = new SQLCon().getCon();        private SqlCommand cmd = new SqlCommand();

        public void Add(SMS_tempBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SMS_temp_Insert";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@phoneNo", SqlDbType.VarChar).Value = obj.phoneNo;
             cmd.Parameters.Add("@message", SqlDbType.VarChar).Value = obj.message;
             cmd.Parameters.Add("@TimeStamp", SqlDbType.DateTime).Value = obj.TimeStamp;
             cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.ExecuteNonQuery();
                con.Close();
                    }
                    catch (SqlException e1)
                    {
                       MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

        public void Update(SMS_tempBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SMS_temp_Update";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@smstemp_id", SqlDbType.Int).Value = obj.smstemp_id;
             cmd.Parameters.Add("@phoneNo", SqlDbType.VarChar).Value = obj.phoneNo;
             cmd.Parameters.Add("@message", SqlDbType.VarChar).Value = obj.message;
             cmd.Parameters.Add("@TimeStamp", SqlDbType.DateTime).Value = obj.TimeStamp;
             cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                cmd.ExecuteNonQuery();
                con.Close();
                    }
                    catch (SqlException e1)
                    {
                       MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

        public List<SMS_tempBAL> LoadbyId(SMS_tempBAL obj)
        {
            try
            {
                //Local

          SqlDataReader dr;
                 List<SMS_tempBAL> listt = new List<SMS_tempBAL>();
         con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SMS_temp_LOADByID";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@smstemp_id", SqlDbType.Int).Value = obj.smstemp_id;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        SMS_tempBAL obj1 = new SMS_tempBAL();
float x = 0;                obj1.smstemp_id = Convert.ToInt32(dr["smstemp_id"].ToString());
                obj1.phoneNo = dr["phoneNo"].ToString();
                obj1.message = dr["message"].ToString();
                obj1.TimeStamp =Convert.ToDateTime( dr["TimeStamp"].ToString());
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

        public List<SMS_tempBAL> LoadAll()
        {
            try
            {
                //Local
                SqlDataReader dr;
                List<SMS_tempBAL> listt = new List<SMS_tempBAL>();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SMS_temp_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        SMS_tempBAL obj1 = new SMS_tempBAL();
                        float x = 0; obj1.smstemp_id = Convert.ToInt32(dr["smstemp_id"].ToString());
                        obj1.phoneNo = dr["phoneNo"].ToString();
                        obj1.message = dr["message"].ToString();
                        obj1.TimeStamp = Convert.ToDateTime(dr["TimeStamp"].ToString());
                        obj1.status = (bool)dr["status"];
                        listt.Add(obj1);
                    }
                }
                dr.Close();
                con.Close();
                return listt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public List<SMS_tempBAL> Search(SMS_tempBAL obj)
        {
            try
            {
                //Local

          SqlDataReader dr;
                 List<SMS_tempBAL> listt = new List<SMS_tempBAL>();
         con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SMS_temp_Search";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@smstemp_id", SqlDbType.Int).Value = obj.smstemp_id;
             cmd.Parameters.Add("@phoneNo", SqlDbType.VarChar).Value = obj.phoneNo;
             cmd.Parameters.Add("@message", SqlDbType.VarChar).Value = obj.message;
             cmd.Parameters.Add("@TimeStamp", SqlDbType.DateTime).Value = obj.TimeStamp;
             cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        SMS_tempBAL obj1 = new SMS_tempBAL();
float x = 0;                obj1.smstemp_id = Convert.ToInt32(dr["smstemp_id"].ToString());
                obj1.phoneNo = dr["phoneNo"].ToString();
                obj1.message = dr["message"].ToString();
                obj1.TimeStamp =Convert.ToDateTime( dr["TimeStamp"].ToString());
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

        public void Delete(SMS_tempBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SMS_temp_Delete";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@smstemp_id", SqlDbType.Int).Value = obj.smstemp_id;
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