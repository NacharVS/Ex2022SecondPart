using ExamSecondWpf.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamSecondWpf.Pages
{
    /// <summary>
    /// Interaction logic for CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        public User CurrentUser;
        private List<Item> _products = new List<Item>();

        private List<Item> _items = new List<Item>()
        {
            new Item() { Name = "Помидор", Price = 250},
            new Item() { Name = "Огурец", Price = 100},
            new Item() { Name = "Яблоко", Price = 150},
        };

        public CatalogPage()
        {
            InitializeComponent();

            CurrentUser = new User();
            lvCatalog.ItemsSource = _items;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (lvCatalog.SelectedItem != null)
            {
                var item = (Item)lvCatalog.SelectedItem;
                _products.Add(item);

                lvBasket.ItemsSource = null;
                lvBasket.ItemsSource = _products;
            }
        }

        private void btnDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            if (lvBasket.SelectedItem != null)
            {
                var item = (Item)lvBasket.SelectedItem;
                _products.Remove(item);

                lvBasket.ItemsSource = null;
                lvBasket.ItemsSource = _products;
            }
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            if (_products.Count > 0)
            {
                int price = 0;

                foreach (var item in lvBasket.Items)
                {
                    price += ((Item)item).Price;
                }

                if (CurrentUser.Balance >= price)
                {
                    CurrentUser.Balance -= price;

                    _products.Clear();

                    lvBasket.ItemsSource = null;

                    var Connection = new MongoConnection();

                    Connection.AddPurchaseInfo(new Purchase() { UserName = CurrentUser.Name, Price = price, Date = DateTime.Now, Products = _products });
                }
                else
                {
                    MessageBox.Show("Недостаточно средств на счете!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
