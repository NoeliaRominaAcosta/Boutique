using Microsoft.Win32;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System;
using Capa_Entidad;
using Capa_Negocio;
using System.Collections.Generic;

namespace BoutiqueTaylor.Views
{
    /// <summary>
    /// Lógica de interacción para CrudUsers.xaml
    /// </summary>
    public partial class CrudUsers : Page
    {
        readonly CN_Users object_CN_Users = new CN_Users();
        readonly CE_Users object_CE_Users = new CE_Users();
        readonly CN_Privilegie object_CN_Privilegie = new CN_Privilegie();
        public CrudUsers()
        {
            InitializeComponent();
            CargarDB();
            // combo box
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            //inicialization
            Content = new Users();
        }
        void CargarDB()
          
        {
            List<string> privilegie = object_CN_Privilegie.searchPrivilegie();
            for (int i= 0; i<privilegie.Count; i++)
            {
                cbTypeRol.Items.Add(privilegie[i]);
            }
        }
        public bool validate() {
            if (TbNames.Text == "" || TbLastName.Text == "" || TbEmail.Text == "" || TbBirth.Text == "" || cbTypeRol.Text == "")
            {
                return false;
            }
            else {
                return true;
            }
        }
        public int id_user;
        public string patron = "boutique";
        #region create
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (validate() == true && tbPass.Text != "")
            {
                int Rol = object_CN_Privilegie.id_rol(cbTypeRol.Text);
                object_CE_Users.Name = TbNames.Text;
                object_CE_Users.Lastname = TbLastName.Text;
                object_CE_Users.Email = TbEmail.Text;
                object_CE_Users.Birth = DateTime.Parse(TbBirth.Text );
                object_CE_Users.Rol = Rol;
                object_CE_Users.UserName = tbUser.Text;
                object_CE_Users.Img =data;
                object_CE_Users.Password = tbPass.Text;
                object_CE_Users.Patron = patron;

                object_CN_Users.Add(object_CE_Users);
                Content = new Users();
            }
            else {
                MessageBox.Show("Los campos deben llenarse");
            }
        }
        #endregion
        #region search
        public void Search() {
            var a = object_CN_Users.Search(id_user);
            TbNames.Text = a.Name;
            TbLastName.Text = a.Lastname;
            TbEmail.Text = a.Email;
            TbBirth.Text = a.Birth.ToString();
            TbTypeRol.Text = a.Rol.ToString();
            var b = object_CN_Privilegie.userRol(a.Rol);
            cbTypeRol.Text = b.UserRol;

            ImageSourceConverter img = new ImageSourceConverter();
            image.Source = (ImageSource)img.ConvertFrom(a.Img);
            tbUser.Text = a.UserName;


        }
        #endregion
        #region delete
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            object_CE_Users.Id_user = id_user;
            object_CN_Users.Delete(object_CE_Users);
            Content = new Users();
        }
        #endregion
        #region update
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (validate() == true)
            {
                int Rol = object_CN_Privilegie.id_rol(cbTypeRol.Text);
                object_CE_Users.Id_user = id_user;
                object_CE_Users.Name = TbNames.Text;
                object_CE_Users.Lastname = TbLastName.Text;
                object_CE_Users.Email = TbEmail.Text;
                object_CE_Users.Birth = DateTime.Parse(TbBirth.Text);
                object_CE_Users.Rol = Rol;
                object_CE_Users.UserName = tbUser.Text;

                object_CN_Users.update(object_CE_Users);
                Content = new Users();


            }
            else {
                MessageBox.Show("Los campos deben llenarse");
            }
            if (tbPass.Text != "") {
                object_CE_Users.Id_user = id_user;
                object_CE_Users.Password = tbPass.Text;
                object_CE_Users.Patron = patron;

                object_CN_Users.updatePassword(object_CE_Users);
                Content = new Users();
            }

            if (imageUploaded == true) {
                object_CE_Users.Id_user = id_user;
                object_CE_Users.Img = data;
                object_CN_Users.updateIMG(object_CE_Users);
                Content = new Users();
            }
        }
        #endregion
        byte[] data;
        private bool imageUploaded = false;
        #region update picture
        private void upload(object sender, RoutedEventArgs e)
        {
            //show image selected and convert to binary
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == true)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                data = new byte[fs.Length];
                fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                ImageSourceConverter imgs = new ImageSourceConverter();
                image.SetValue(Image.SourceProperty, imgs.ConvertFromString(ofd.FileName.ToString()));
            }
            imageUploaded = true;
        }
        #endregion
    }
}
