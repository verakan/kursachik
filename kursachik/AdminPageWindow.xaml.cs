using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
    /// Логика взаимодействия для AdminPageWindow.xaml
    /// </summary>
    public partial class AdminPageWindow : Window
    {

        public AdminPageWindow()
        {
            InitializeComponent();

        }
       

        private void Button_ExitAdmin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddEmployer addEmployer = new AddEmployer();
            addEmployer.Show();
            this.Close();

        }

    

       /* private void DeletEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            AddEmployer addEmployer = new AddEmployer();
            addEmployer.Show();
            this.Close();
        }*/

 

        private void AssortmentButton_Click(object sender, RoutedEventArgs e)
        {
            Assortment assortment = new Assortment();
            assortment.Show();
            this.Close();
        }
    }
}

