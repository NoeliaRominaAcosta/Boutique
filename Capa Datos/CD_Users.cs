using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Capa_Entidad;


namespace Capa_datos
{
    public class CD_Users
    {
        private readonly CD_Conexion con = new CD_Conexion();
        private readonly  CE_Users ce = new CE_Users();


        #region crudUsers
        public void CD_Add(CE_Users users)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.Open(),
                CommandText = "SP_U_Insert",
                CommandType = CommandType.StoredProcedure

            };
            com.Parameters.AddWithValue("@Name", users.Name);
            com.Parameters.AddWithValue("@lastname", users.Lastname);
            com.Parameters.AddWithValue("@email", users.Email);        
            com.Parameters.AddWithValue("@birth", SqlDbType.Date).Value = users.Birth;
            com.Parameters.AddWithValue("@rol", users.Rol);
            com.Parameters.AddWithValue("@username", users.UserName);
            com.Parameters.AddWithValue("@img", users.Img);
            com.Parameters.AddWithValue("@password", users.Password);
            com.Parameters.AddWithValue("@patron", users.Patron);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.Close();

        }
        #endregion
        #region search


        public CE_Users CD_Search(int id_user)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_U_Search", con.Open());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id_user", SqlDbType.Int).Value = id_user;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.Name = Convert.ToString(row[1]);
            ce.Lastname = Convert.ToString(row[2]);
            ce.Email = Convert.ToString(row[3]);
            ce.Birth = Convert.ToDateTime(row[4]);
            ce.Rol = Convert.ToInt32(row[5]);
            ce.Img = (byte[])row[6];
            ce.UserName = Convert.ToString(row[7]);
            
            return ce;

        }
        #endregion
        #region delete
        public void CD_Delete(CE_Users Users)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con.Open();
            com.CommandText = "SP_U_Delete";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_user", Users.Id_user);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.Close();
        }

        #endregion
        #region update data
        public void CD_Update(CE_Users users) {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.Open(),
                CommandText = "SP_U_Update",
                CommandType = CommandType.StoredProcedure

            };
            com.Parameters.AddWithValue("@id_user", users.Id_user);
            com.Parameters.AddWithValue("@Name", users.Name);
            com.Parameters.AddWithValue("@lastname", users.Lastname);
            com.Parameters.AddWithValue("@email", users.Email);
            com.Parameters.AddWithValue("@username", users.UserName);
            com.Parameters.AddWithValue("@email", users.Email);
            com.Parameters.AddWithValue("@birth", SqlDbType.Date).Value = users.Birth;
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.Close();

        }

        #endregion

        #region update password
        public void CD_UpdatePassword(CE_Users users) {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.Open(),
                CommandText = "SP_U_UpdatePassword",
                CommandType = CommandType.StoredProcedure

            };
            com.Parameters.AddWithValue("@id_user", users.Id_user);
            com.Parameters.AddWithValue("@password", users.Password);
            com.Parameters.AddWithValue("@patron", users.Patron);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.Close();

        }

        #endregion
        #region update profile picture

        public void CD_UpdateIMG(CE_Users users) {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.Open(),
                CommandText = "SP_U_UpdateIMG",
                CommandType = CommandType.StoredProcedure

            };
            com.Parameters.AddWithValue("@id_user", users.Id_user);
            com.Parameters.AddWithValue("@img", users.Img);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.Close();
        }
        #endregion

        public DataTable SearchUsers()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_U_Users",con.Open());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.Close();
            return dt;

        }
    }
}
