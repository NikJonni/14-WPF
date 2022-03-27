using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _14_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<Products> products;
        public MainWindow()
        {        
            InitializeComponent();
            products = new ObservableCollection<Products>();
            products.Add(new Products()
            {
                ProdName = "Хлеб",
                ProdPrice = 50,
                ProdImage = "Data/Хлебушек.jpg",
                ProductCategory = ProductCategorys.Food

            });
            products.Add(new Products()
            {
                ProdName = "Молоко",
                ProdPrice = 70,
                ProdImage = "Data/Молоко.jpg",
                ProductCategory = ProductCategorys.Food

            });
            products.Add(new Products()
            {
                ProdName = "Апельсины",
                ProdPrice = 70,
                ProdImage = "Data/Апельсин.jpg",
                ProductCategory = ProductCategorys.Food

            });
            products.Add(new Products()
            {
                ProdName = "Пылесос",
                ProdPrice = 1500,
                ProdImage = "Data/Пылесос.jpg",
                ProductCategory = ProductCategorys.Appliances

            });
            products.Add(new Products()
            {
                ProdName = "Утюг",
                ProdPrice = 1000,
                ProdImage = "Data/Утюг.jpg",
                ProductCategory = ProductCategorys.Appliances

            });
            /* не работает картинка*/
            //products.Add(new Products()
            //{
            //    ProdName = "Стиральная машина",
            //    ProdPrice = 3000,
            //    ProdImage = "Data/Машина.jpg",
            //    ProductCategory = ProductCategorys.Appliances
            //});
            listBox.ItemsSource = products;
        }
    }
}
