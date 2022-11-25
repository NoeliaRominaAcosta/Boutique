using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BoutiqueTaylor.Views
{
    /// <summary>
    /// Lógica de interacción para Users.xaml
    /// </summary>
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
            ShowData();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conectionDB"].ConnectionString);
        void ShowData()
        {
            con.Open();
            SqlCommand command= new SqlCommand("Select id_user, name,lastname,email,userRol from Users inner join Rol on Users.rol = Rol.id_rol order by id_user ASC",con);
            SqlDataAdapter dat = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dat.Fill(dt);
            GridData.ItemsSource = dt.DefaultView;
            con.Close();
        }
        private void BtnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            CrudUsers ventana= new CrudUsers();
            FrameUsers.Content = ventana;
            content.Visibility = Visibility.Hidden;
            ventana.create.Visibility = Visibility.Visible;
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrudUsers ventana = new CrudUsers();
            ventana.id_user = id;
            ventana.Search();
            FrameUsers.Content = ventana;
            content.Visibility = Visibility.Hidden;

            //campos no se pueden editar
            ventana.Title.Text = "Consultando";
            ventana.TbNames.IsEnabled = false;
            ventana.tbPass.IsEnabled = false;
            ventana.TbLastName.IsEnabled = false;
            ventana.TbTypeRol.IsEnabled = false;
            ventana.TbEmail.IsEnabled = false;
            ventana.TbBirth.IsEnabled = false;
            ventana.tbUser.IsEnabled = false;

        }

        private void Update(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrudUsers ventana = new CrudUsers();
            ventana.id_user = id;
            ventana.Search();
            FrameUsers.Content = ventana;
            content.Visibility = Visibility.Hidden;

            //campos si se pueden editar
            ventana.Title.Text = "Editando";
            ventana.TbNames.IsEnabled = true;
            ventana.tbPass.IsEnabled = true;
            ventana.TbLastName.IsEnabled = true;
            ventana.TbTypeRol.IsEnabled = true;
            ventana.TbEmail.IsEnabled = true;
            ventana.TbBirth.IsEnabled = true;
            ventana.tbUser.IsEnabled = true;
            ventana.update.Visibility = Visibility.Visible;

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            int id = (int)((Button)sender).CommandParameter;
            CrudUsers ventana = new CrudUsers();
            ventana.id_user = id;
            ventana.Search();
            content.Visibility = Visibility.Hidden;

            FrameUsers.Content = ventana;
            //campos no se pueden editar
            ventana.Title.Text = "Eliminar Usuario";
            ventana.TbNames.IsEnabled = false;
            ventana.tbPass.IsEnabled = false;
            ventana.TbLastName.IsEnabled = false;
            ventana.TbTypeRol.IsEnabled = false;
            ventana.TbEmail.IsEnabled = false;
            ventana.TbBirth.IsEnabled = false;
            ventana.tbUser.IsEnabled = false;
            ventana.delete.Visibility = Visibility.Visible;
        }
    }
}
