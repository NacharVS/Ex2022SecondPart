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
using WpfExzamen.Models;
using WpfExzamen.MongoDB;

namespace WpfExzamen.Pages
{
    /// <summary>
    /// Логика взаимодействия для Admition.xaml
    /// </summary>
    public partial class Admition : Page
    {
        public byte[] ImageBin { get; set; }

        public Admition()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (EdName.Text != "" && EdPrice.Text != "")
            {
  

                Item item = new Item();
                item.Name = EdName.Text;
                item.Price = int.Parse(EdPrice.Text);
                item.Image = ImageBin;

                MongoDBAction.AddItemToDB(item);

                MessageBox.Show("Succses!");

                EdName.Text = "";
                EdPrice.Text = "";
            }
        }


  
    }
}
