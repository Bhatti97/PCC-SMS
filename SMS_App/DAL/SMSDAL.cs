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
    class SMSDAL
        {

            //SQL Objects
            //Connection
            private SqlConnection con = new SQLCon().getCon();        private SqlCommand cmd = new SqlCommand();

        public void Add(SMSBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SMS_Insert";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@phoneNo", SqlDbType.VarChar).Value = obj.phoneNo;
             cmd.Parameters.Add("@Message", SqlDbType.VarChar).Value = obj.Message;
             cmd.Parameters.Add("@IsDelieverd", SqlDbType.Bit).Value = obj.IsDelieverd;
             cmd.Parameters.Add("@IsSeen", SqlDbType.Bit).Value = obj.IsSeen;
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

        public void Update(SMSBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SMS_Update";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@sms_id", SqlDbType.Int).Value = obj.sms_id;
             cmd.Parameters.Add("@phoneNo", SqlDbType.VarChar).Value = obj.phoneNo;
             cmd.Parameters.Add("@Message", SqlDbType.VarChar).Value = obj.Message;
             cmd.Parameters.Add("@IsDelieverd", SqlDbType.Bit).Value = obj.IsDelieverd;
             cmd.Parameters.Add("@IsSeen", SqlDbType.Bit).Value = obj.IsSeen;
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

        public List<SMSBAL> LoadbyId(SMSBAL obj)
        {
            try
            {
                //Local

          SqlDataReader dr;
                 List<SMSBAL> listt = new List<SMSBAL>();
         con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SMS_LOADByID";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@sms_id", SqlDbType.Int).Value = obj.sms_id;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        SMSBAL obj1 = new SMSBAL();
float x = 0;                obj1.sms_id = Convert.ToInt32(dr["sms_id"].ToString());
                obj1.phoneNo = dr["phoneNo"].ToString();
                obj1.Message = dr["Message"].ToString();
                obj1.IsDelieverd =(bool) dr["IsDelieverd"];
                obj1.IsSeen =(bool) dr["IsSeen"];
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

        public List<SMSBAL> LoadAll()
        {
            try
            {
                //Local

          SqlDataReader dr;
                 List<SMSBAL> listt = new List<SMSBAL>();
          con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SMS_LOADALL";
                cmd.Parameters.Clear();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        SMSBAL obj1 = new SMSBAL();
                float x=0;                obj1.sms_id = Convert.ToInt32(dr["sms_id"].ToString());
                obj1.phoneNo = dr["phoneNo"].ToString();
                obj1.Message = dr["Message"].ToString();
                obj1.IsDelieverd =(bool) dr["IsDelieverd"];
                obj1.IsSeen =(bool) dr["IsSeen"];
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

        public List<SMSBAL> Search(SMSBAL obj)
        {
            try
            {
                //Local

          SqlDataReader dr;
                 List<SMSBAL> listt = new List<SMSBAL>();
         con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SMS_Search";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@sms_id", SqlDbType.Int).Value = obj.sms_id;
             cmd.Parameters.Add("@phoneNo", SqlDbType.VarChar).Value = obj.phoneNo;
             cmd.Parameters.Add("@Message", SqlDbType.VarChar).Value = obj.Message;
             cmd.Parameters.Add("@TimeStamp", SqlDbType.DateTime).Value = obj.TimeStamp;
             cmd.Parameters.Add("@status", SqlDbType.Bit).Value = obj.status;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        SMSBAL obj1 = new SMSBAL();
float x = 0;                obj1.sms_id = Convert.ToInt32(dr["sms_id"].ToString());
                obj1.phoneNo = dr["phoneNo"].ToString();
                obj1.Message = dr["Message"].ToString();
                obj1.IsDelieverd =(bool) dr["IsDelieverd"];
                obj1.IsSeen =(bool) dr["IsSeen"];
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

        public void Delete(SMSBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SMS_Delete";
                cmd.Parameters.Clear();

             cmd.Parameters.Add("@sms_id", SqlDbType.Int).Value = obj.sms_id;
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