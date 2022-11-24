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
            // combo box
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            //inicialization
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

        public int id_user;

        public void Search() {
            con.Open();
            SqlCommand com = new SqlCommand("select * from Users inner join Rol on Users.rol = Rol.id_rol where id_user="+id_user, con);
            SqlDataReader rdr = com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            rdr.Read();
            this.TbNames.Text = rdr["name"].ToString();
            this.TbLastName.Text = rdr["lastname"].ToString();
            this.TbEmail.Text = rdr["email"].ToString();
            this.cbTypeRol.SelectedItem = rdr["userRol"];
            this.TbBirth.Text = rdr["birth"].ToString();
            this.tbUser.Text = rdr["username"].ToString();
            rdr.Close();

            //image upload

            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select img from Users where id_user='"+id_user+"'",con);
            sda.Fill(ds);
            byte[] data= (byte[])ds.Tables[0].Rows[0][0];
            //uses RAM memory as backup storage instead of hard drive or network.
            MemoryStream ms = new MemoryStream();
            ms.Write(data, 0, data.Length);
            ms.Position =0;
            //convert from binary to see the image
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            BitmapImage bmi = new BitmapImage();
            bmi.BeginInit();
            MemoryStream mst = new MemoryStream();
            img.Save(mst, System.Drawing.Imaging.ImageFormat.Bmp);
            mst.Seek(0, SeekOrigin.Begin);
            bmi.StreamSource = mst;
            bmi.EndInit();
            image.Source = bmi;
            con.Close();

        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmdDelete = new SqlCommand("delete from users where id_user  = '" + id_user + "'", con);
            cmdDelete.ExecuteScalar();
            con.Close();
            Content = new Users();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select id_rol from Rol where userRol  = '" + cbTypeRol.Text + "'", con);
            object valor = cmd.ExecuteScalar();
            int id_rol = (int)valor;
            //save on variable the id_rol for  WHERE statement
            string patron = "boutique";
            if (TbNames.Text == "" || TbLastName.Text == "" || TbEmail.Text == "" || TbBirth.Text == "" || cbTypeRol.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
            }
            else
            {
                SqlCommand comd = new SqlCommand("update Users set name='" + TbNames.Text + "',lastname='" + TbLastName.Text + "', email='" + TbEmail.Text + "', birth='" + DateTime.Parse(TbBirth.Text) + "', username='" + cbTypeRol.Text + "',rol='" + id_rol + "' where id_user = '" + id_user + "'", con);
                comd.ExecuteNonQuery();

                if (imageUploaded == true)
                {
                    SqlCommand img = new SqlCommand("update  Users set img = @img where id_user='" + id_user + "'", con);
                    img.Parameters.AddWithValue("@img", SqlDbType.VarBinary).Value = data;
                    img.ExecuteNonQuery();
                }
               
            }
           //little validation password not null
              if(tbPass.Text != "")
            {
                SqlCommand cmdPass = new SqlCommand("update users set password = (EncryptByPassPhrase('" + patron + "', '" + tbPass.Text + "')) where id_user='" + id_user + "'", con);
                cmdPass.ExecuteNonQuery();
            }
            con.Close();
            Content = new Users();
        }
        byte[] data;
        private bool imageUploaded = false;
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
    }
}
