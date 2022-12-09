using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;


namespace Capa_datos
{
    public class CD_Conexion
    {
        private readonly SqlConnection con = new SqlConnection("Data Source=NOELIA; initial catalog=boutiquetaylor; integrated security=true;");
        public SqlConnection Open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            return con;
        }
        public SqlConnection Close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
            return con;
        }
    }
}
