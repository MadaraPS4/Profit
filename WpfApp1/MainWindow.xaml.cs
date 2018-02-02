using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using Newtonsoft.Json;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Products> products = new ObservableCollection<Products>();
        public MainWindow()
        {
            InitializeComponent();
            products.Add(new Products {City="Астана",Product="Яблоки", Price=100,Profit=300 });
            products.Add(new Products { City = "Иркутск", Product = "Яблоки", Price = 300, Profit = 500 });
            products.Add(new Products { City = "Уральск", Product = "Яблоки", Price = 60, Profit = 500 });



            int amount = 5;//килограмм
            int pokupnayaCena = 80;//килограмм
            int dostavaka = 10;
            double nalog = 30; //процентов
            int arendaPomeshenia = 20;

            //Цены
            int priceAppleAstana = 300;
            int priceAppleIrkustk = 500;
            int priceAppleUralks = 100;
            

            double profitAstana = (priceAppleAstana*amount-(amount*pokupnayaCena - dostavaka-arendaPomeshenia))*1/nalog;
            double profitIrkustsk = (priceAppleIrkustk*amount-(amount*pokupnayaCena - dostavaka-arendaPomeshenia))*1/nalog;
            double profitUrlaks = (priceAppleUralks*amount - (amount*pokupnayaCena - dostavaka-arendaPomeshenia))*1/nalog;


            foreach (var x in products)
            {
                if (x.City == "Астана")
                {
                    x.Price = priceAppleAstana;
                    x.Profit = profitAstana;
                }
                if (x.City == "Иркутск")
                {
                    x.Price = priceAppleIrkustk;
                    x.Profit = profitIrkustsk;
                }
                if (x.City == "Уральск")
                {
                    x.Price = priceAppleUralks;
                    x.Profit = profitUrlaks;
                }
            }

            datagrid.ItemsSource = products;

            
            var json = JsonConvert.SerializeObject(products);

            File.WriteAllText(@"C:\Users\ЗейтынБ\Documents\Visual Studio 2017\products.json", json);

        }
    }
}
