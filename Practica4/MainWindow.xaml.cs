using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Practica4.Hobby_shopDataSetTableAdapters;

namespace Practica4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Shop_EmployeesTableAdapter employees = new Shop_EmployeesTableAdapter();
        ProductsTableAdapter products = new ProductsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            EmployeesDataGrid.ItemsSource = employees.GetData();


            ProductsDataGrid.ItemsSource = products.GetData();
            EmployeesComboBox.ItemsSource = employees.GetData();
            EmployeesComboBox.DisplayMemberPath = "Employees_Last_Name";
        }
        private void EmployeesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(EmployeesComboBox.SelectedItem != null)
            {
                var ID = (int)(EmployeesComboBox.SelectedItem as DataRowView).Row[0];
                EmployeesDataGrid.ItemsSource = employees.FilterByName(ID);
            }
        }
        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {
            EmployeesDataGrid.ItemsSource = employees.GetData();
        }
        public void ShowEmployees_Click(object sender, RoutedEventArgs e)
        {

           

            EmployeesDataGrid.Visibility = Visibility.Visible;
            ProductsDataGrid.Visibility = Visibility.Collapsed;
        }
        public void ShowProducts_Click(object sender, RoutedEventArgs e)
        {

           

            EmployeesDataGrid.Visibility = Visibility.Collapsed;
            ProductsDataGrid.Visibility = Visibility.Visible;
        }
        private void OpenNewWindowButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
        }
        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            if (EmployeesDataGrid.Visibility == Visibility.Visible)
            {
            EmployeesDataGrid.ItemsSource = employees.SearchByName(SearchTxt.Text);

            }
            else
            {
                ProductsDataGrid.ItemsSource = products.SearchByNamePro(SearchTxt.Text);
            }
        }
    }
}
