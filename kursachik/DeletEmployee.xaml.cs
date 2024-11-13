/*using System;
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
    /// Логика взаимодействия для DeletEmployeeButton_Click.xaml
    /// </summary>
    public partial class DeletEmployeeButton_Click : Window
    {
        ApplicationContext db;
        public DeletEmployeeButton_Click()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }
    }
    private void DeletEmployeeButton_Click(object sender, RoutedEventArgs e)
    {
        if (UsersDataGrid.SelectedItem is User selectedUser)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранного сотрудника?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    db.Users.Attach(selectedUser);
                    db.Users.Remove(selectedUser);
                    db.SaveChanges();
                    LoadUsers(); // Обновляем данные в DataGrid после удаления

                    MessageBox.Show("Сотрудник успешно удален", "Удаление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении сотрудника: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        else
        {
            MessageBox.Show("Пожалуйста, выберите сотрудника для удаления.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}*/

