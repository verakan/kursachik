﻿using System;
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
    /// Логика взаимодействия для Assortment.xaml
    /// </summary>
    public partial class Assortment : Window
    {
        public Assortment()
        {
            InitializeComponent();
        }

        private void Button_ExitAssortment_Click(object sender, RoutedEventArgs e)
        {
            AdminPageWindow adminPageWindow = new AdminPageWindow();
            adminPageWindow.Show();
            this.Close();
        }



        /*private void Addproducts_Click(object sender, RoutedEventArgs e)
        {

        }*/
    }

}
