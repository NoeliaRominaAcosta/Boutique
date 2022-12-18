using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Negocio
{
   public class CN_Privilegie
    {
        CD_Privilege CD_Privilege = new CD_Privilege();
        #region id privilegio
        public int id_rol(string userRol)
        {
            return CD_Privilege.idPrivilege(userRol);

        }
        #endregion
        #region nombre privilegio
        public CE_Privilege userRol (int id_rol)
        {
            return CD_Privilege.userRol(id_rol);
        }
        #endregion
        #region listar privilegios
        public List<string> searchPrivilegie()
        {
            return CD_Privilege.searchPrivilegie();

        }
        #endregion
    }
}
