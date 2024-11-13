using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;


namespace kursachik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string AdminLogin = "admin";
        private const string AdminPass = "adminpass";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
         {
             string login = LoginTextBox.Text.Trim();
             string pass = PassBox.Password.Trim();

             if (login.Length < 5)
             {
                 LoginTextBox.ToolTip = "Это поле введено не корректно!";
                 LoginTextBox.Background = Brushes.IndianRed;
             }
             else if (pass.Length < 5)
             {
                 PassBox.ToolTip = "Это поле введено не корректно!";
                 PassBox.Background = Brushes.IndianRed;
             }
             else
             {
                 LoginTextBox.ToolTip = "";
                 LoginTextBox.Background = Brushes.Transparent;
                 PassBox.ToolTip = "";
                 PassBox.Background = Brushes.Transparent;

                 if (login == AdminLogin && pass == AdminPass)
                 {
                     AdminPageWindow adminPageWindow = new AdminPageWindow();
                     adminPageWindow.Show();
                     this.Close();
                 }
                 else
                 {
                     // Проверка данных пользователя в базе данных
                     User authUser = null;
                     using (ApplicationContext db = new ApplicationContext())
                     {
                         authUser = db.Users.Where(b => b.Login == login && b.Pass == pass).FirstOrDefault();
                     }

                     if (authUser != null)
                     {
                         UserPageWindow userPageWindow = new UserPageWindow();
                         userPageWindow.Show();
                         this.Close();
                     }
                     else
                     {
                         MessageBox.Show("Пожалуйста, введите правильные логин и пароль");
                     }
                 }
             }
         }
    }
}