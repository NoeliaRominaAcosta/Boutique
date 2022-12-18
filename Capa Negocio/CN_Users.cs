using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_datos;
using Capa_Entidad;

namespace Capa_Negocio
{
   public class CN_Users
    {
        private readonly CD_Users objData = new CD_Users();
        #region search
        public CE_Users Search(int id_user) {
            return objData.CD_Search(id_user);
        }
        #endregion
        #region ADD
        public void Add(CE_Users users) {
            objData.CD_Add(users);
        }
        #endregion
        #region delete
        public void Delete(CE_Users users)
        {
            objData.CD_Delete(users);
        }
        #endregion
        #region update
        public void update(CE_Users users) {
            objData.CD_Update(users);
        }
        #endregion
        #region update password
        public void updatePassword(CE_Users users)
        {
            objData.CD_UpdatePassword(users);
        }
        #endregion
        #region update profile picture
        public void updateIMG(CE_Users users)
        {
            objData.CD_UpdateIMG(users);
        }
        #endregion

        public DataTable SearchUsers()
        {
            return objData.SearchUsers();
        }
    }
}
