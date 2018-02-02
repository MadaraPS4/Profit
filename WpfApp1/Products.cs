using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Products:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string city;
        private string product;
        private int price;
        private double profit;



        public string City
        {
            get { return city; }
            set
            {
                city = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("City"));
            }
        }

        public string Product
        {
            get { return product; }
            set
            {
                product = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Product"));
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Price"));
            }
        }
        public double Profit
        {
            get { return profit;}
            set
            {
                profit = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Profit"));
            }
        }


    }
}
