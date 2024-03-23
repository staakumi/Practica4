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

namespace Practica4
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private Hobby_shopEntities context = new Hobby_shopEntities();
        public Window2()
        {
            InitializeComponent();
            EmployeesDgr.ItemsSource = context.Shop_Employees.ToList();



            ProductsDgr.ItemsSource = context.Products.ToList();

        }
        private void ShowEmployees_ClickEF(object sender, RoutedEventArgs e)
        {

       

            EmployeesDgr.Visibility = Visibility.Visible;
            ProductsDgr.Visibility = Visibility.Collapsed;
        }
        private void ShowProducts_ClickEF(object sender, RoutedEventArgs e)
        {

           

            EmployeesDgr.Visibility = Visibility.Collapsed;
            ProductsDgr.Visibility = Visibility.Visible;
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            if(EmployeesDgr.Visibility == Visibility.Visible)
            {

            EmployeesDgr.ItemsSource = context.Shop_Employees.ToList().Where(item => item.Employees_Last_Name.Contains(SearchTxt.Text));
            }
            else
            {
                ProductsDgr.ItemsSource = context.Products.ToList().Where(item => item.Products_Name.Contains(SearchTxt.Text));
            }
        }
    }
}
