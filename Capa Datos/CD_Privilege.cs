using Capa_datos;
using Capa_Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_Privilege
    {
        readonly CD_Conexion con = new CD_Conexion();
        readonly CE_Privilege ce = new CE_Privilege();

        public int idPrivilege(string userRol) {

            SqlCommand com = new SqlCommand()
            {
                Connection = con.Open(),
                CommandText = "SP_U_Privilegie",
                CommandType = CommandType.StoredProcedure,

            };
            com.Parameters.AddWithValue("@userRol", userRol);
            object valor = com.ExecuteScalar();
            int idPrivilege = (int)valor;
            con.Close();
            //TODO 24:00

            return idPrivilege;
        }
    }
}
