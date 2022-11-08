using Microsoft.Win32;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BoutiqueTaylor.Views
{
    /// <summary>
    /// Lógica de interacción para CrudUsers.xaml
    /// </summary>
    public partial class CrudUsers : Page
    {
        public CrudUsers()
        {
            InitializeComponent();
            CargarDB();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Content = new Users();
        }
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conectionDB"].ConnectionString);
        void CargarDB()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select userRol from Rol",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbTypeRol.Items.Add(dr["userRol"].ToString());
            }
            con.Close();
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if(TbNames.Text == "" || TbLastName.Text == "" ||TbEmail.Text == "" || TbBirth.Text == "" || cbTypeRol.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select id_rol from Rol where userRol  = '"+cbTypeRol.Text+"'", con);
                object valor = cmd.ExecuteScalar();
                int rol = (int)valor;
                string patron = "boutique";
                if (imageUploaded == true)
                {
                    SqlCommand com = new SqlCommand("insert into  Users(name, lastname, email, birth, img, rol, username,password) values(@name, @lastname, @email, @birth, @img, @rol,@username,(EncryptByPassPhrase('" + patron + "','" + tbPass.Text + "')))", con);
                    com.Parameters.Add("@name", SqlDbType.VarChar).Value = TbNames.Text;
                    com.Parameters.Add("@lastname", SqlDbType.VarChar).Value = TbLastName.Text;
                    com.Parameters.Add("@email", SqlDbType.VarChar).Value = TbEmail.Text;
                    com.Parameters.Add("@birth", SqlDbType.Date).Value = TbBirth.Text;
                    com.Parameters.Add("@rol", SqlDbType.Int).Value = rol;
                    com.Parameters.Add("@username", SqlDbType.VarChar).Value = tbUser.Text;
                    com.Parameters.AddWithValue("@img", SqlDbType.VarBinary).Value = data;
                    com.ExecuteNonQuery();
                    Content = new Users();
                }
                else
                {
                    MessageBox.Show("debes subir imagen de perfil para usuario");
                }
                con.Close();
               
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {

        }
        byte[] data;
        private bool imageUploaded = false;
        private void upload(object sender, RoutedEventArgs e)
        {
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
    }
}
