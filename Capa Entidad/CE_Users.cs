using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidad
{
    public class CE_Users
    {
        private int _id_user;
        private string name;
        private string lastname;
        private string email;
        private DateTime birth;
        private int rol;
        private string userName;
        private byte[] _img;
        private string password;
        private string _patron;

        public int Id_user { get => _id_user; set => _id_user = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public int Rol { get => rol; set => rol = value; }
        public string UserName { get => userName; set => userName = value; }
        public byte[] Img { get => _img; set => _img = value; }
        public string Password { get => password; set => password = value; }
        public string Patron { get => _patron; set => _patron = value; }
    }
}
