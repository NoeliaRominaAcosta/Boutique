using Capa_datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_Privilege
    {
        readonly CD_Conexion con = new CD_Conexion();
        readonly CE_Privilege ce = new CE_Privilege();

        #region id privilegio

        public int idPrivilege(string userRol) {

            SqlCommand com = new SqlCommand()
            {
                Connection = con.Open(),
                CommandText = "SP_P_Id_rol",
                CommandType = CommandType.StoredProcedure,

            };
            com.Parameters.AddWithValue("@userRol", userRol);
            object valor = com.ExecuteScalar();
            int idPrivilege = (int)valor;
            con.Close();
           

            return idPrivilege;
        }
        #endregion
        #region nombre privilegio
        public CE_Privilege userRol(int id_rol)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_U_Privilegie", con.Open());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id_rol", SqlDbType.Int).Value= id_rol;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.UserRol = Convert.ToString(row[0]);
            return ce;
        }
        #endregion
        #region listar privilegios
        public List<string> searchPrivilegie()
        {
            SqlCommand com = new SqlCommand() {
                Connection = con.Open(),
                CommandText = "SP_P_PrivilegieCreate",
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader reader = com.ExecuteReader();
            List<string> lista = new List<string>();
            while (reader.Read())
            {
                lista.Add(Convert.ToString(reader["userRol"]));
            }
            con.Close();
            return lista;
        }
        #endregion
    }
}
