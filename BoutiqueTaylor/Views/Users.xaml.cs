using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Capa_Negocio;
namespace BoutiqueTaylor.Views
{
    /// <summary>
    /// Lógica de interacción para Users.xaml
    /// </summary>
    public partial class Users : UserControl
    {
        readonly CN_Users object_CN_Users = new CN_Users();
        public Users()
        {
            InitializeComponent();
            ShowData();
        }

        void ShowData()
        {
         
            GridData.ItemsSource = object_CN_Users.SearchUsers().DefaultView;
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
