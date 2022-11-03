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
        }
    }
}
