using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace kursachik
{
    /// <summary>
    /// Логика взаимодействия для AddEmployer.xaml
    /// </summary>
    public partial class AddEmployer : Window
    {
        ApplicationContext db;
        public AddEmployer()
        {
            InitializeComponent();
            db = new ApplicationContext();

        }
        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text.Trim();
            string pass = PasswordBox.Password.Trim();
            string name = NameTextBox.Text.Trim();
            string surname = SurnameTextBox.Text.Trim();


            bool isValid = true;

            if (login.Length < 5)
            {
                LoginTextBox.ToolTip = "Это поле введено некорректно!";
                LoginTextBox.Background = Brushes.IndianRed;
                isValid = false;
            }
            else
            {
                LoginTextBox.ToolTip = "";
                LoginTextBox.Background = Brushes.Transparent;
            }

            if (pass.Length < 5)
            {
                PasswordBox.ToolTip = "Это поле введено некорректно!";
                PasswordBox.Background = Brushes.IndianRed;
                isValid = false;
            }
            else
            {
                PasswordBox.ToolTip = "";
                PasswordBox.Background = Brushes.Transparent;
            }

            if (name.Length == 0)
            {
                NameTextBox.ToolTip = "Это поле введено некорректно!";
                NameTextBox.Background = Brushes.IndianRed;
                isValid = false;
            }
            else
            {
                NameTextBox.ToolTip = "";
                NameTextBox.Background = Brushes.Transparent;
            }

            if (surname.Length == 0)
            {
                SurnameTextBox.ToolTip = "Это поле введено некорректно!";
                SurnameTextBox.Background = Brushes.IndianRed;
                isValid = false;
            }
            else
            {
                SurnameTextBox.ToolTip = "";
                SurnameTextBox.Background = Brushes.Transparent;
            }



            if (isValid)
            {
                // Добавление нового сотрудника в базу данных 
                MessageBox.Show("Данные введены корректно!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                User user = new User(login, pass, name, surname);

                db.Users.Add(user);
                db.SaveChanges();

                AdminPageWindow adminPageWindow = new AdminPageWindow();
                adminPageWindow.Show();
                this.Close();
            }
        }
        private void Button_ExitAdmin_Click(object sender, RoutedEventArgs e)
        { // Логика для выхода из окна администратора
          this.Close();
        }
        
    }
    
}

