using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
   public class CE_Privilege
    {
        private int _id_rol;
        private string userRol;

        public int Id_rol { get => _id_rol; set => _id_rol = value; }
        public string UserRol { get => userRol; set => userRol = value; }
    }
}
