using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RestaurantBillCalculator
{
    public class Food : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        private void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
