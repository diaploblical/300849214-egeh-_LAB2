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

namespace RestaurantBillCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Food> appetizer = new ObservableCollection<Food>();
        private ObservableCollection<Food> beverage = new ObservableCollection<Food>();
        private ObservableCollection<Food> dessert = new ObservableCollection<Food>();
        private ObservableCollection<Food> mainCourse = new ObservableCollection<Food>();
        public MainWindow()
        {
            InitializeComponent();
            appetizer.Add(new Food { Name = "Buffalo Wings", Category = "Appetizer", Price = 5.95 });
            appetizer.Add(new Food { Name = "Buffalo Fingers", Category = "Appetizer", Price = 6.95 });
            appetizer.Add(new Food { Name = "Potato Skins", Category = "Appetizer", Price = 8.95 });
            appetizer.Add(new Food { Name = "Nachos", Category = "Appetizer", Price = 8.95 });
            appetizer.Add(new Food { Name = "Mushroom Caps", Category = "Appetizer", Price = 10.95 });
            appetizer.Add(new Food { Name = "Shrimp Cocktail", Category = "Appetizer", Price = 12.95 });
            appetizer.Add(new Food { Name = "Chips and Salsa", Category = "Appetizer", Price = 6.95 });

            beverage.Add(new Food { Name = "Soda", Category = "Beverage", Price = 1.95 });
            beverage.Add(new Food { Name = "Tea", Category = "Beverage", Price = 1.50 });
            beverage.Add(new Food { Name = "Coffee", Category = "Beverage", Price = 1.25 });
            beverage.Add(new Food { Name = "Mineral Water", Category = "Beverage", Price = 2.95 });
            beverage.Add(new Food { Name = "Juice", Category = "Beverage", Price = 2.50 });
            beverage.Add(new Food { Name = "Milk", Category = "Beverage", Price = 1.50 });

            mainCourse.Add(new Food { Name = "Seafood Alfredo", Category = "Main Course", Price = 15.95 });
            mainCourse.Add(new Food { Name = "Chicken Alfredo", Category = "Main Course", Price = 13.95 });
            mainCourse.Add(new Food { Name = "Chicken Picatta", Category = "Main Course", Price = 13.95 });
            mainCourse.Add(new Food { Name = "Turkey Club", Category = "Main Course", Price = 11.95 });
            mainCourse.Add(new Food { Name = "Lobster Pie", Category = "Main Course", Price = 19.95 });
            mainCourse.Add(new Food { Name = "Prime Rib", Category = "Main Course", Price = 20.95 });
            mainCourse.Add(new Food { Name = "Shrimp Scambi", Category = "Main Course", Price = 18.95 });
            mainCourse.Add(new Food { Name = "Turkey Dinner", Category = "Main Course", Price = 13.95 });
            mainCourse.Add(new Food { Name = "Stuffed Chicken", Category = "Main Course", Price = 14.95 });

            dessert.Add(new Food { Name = "Apple Pie", Category = "Dessert", Price = 5.95 });
            dessert.Add(new Food { Name = "Sundae", Category = "Dessert", Price = 3.95 });
            dessert.Add(new Food { Name = "Carrot Cake", Category = "Dessert", Price = 5.95 });
            dessert.Add(new Food { Name = "Mud Pie", Category = "Dessert", Price = 4.95 });
            dessert.Add(new Food { Name = "Apple Crisp", Category = "Dessert", Price = 5.95 });

            appetizerBox.ItemsSource = appetizer;
            beverageBox.ItemsSource = beverage;
            dessertBox.ItemsSource = dessert;
            mainCourseBox.ItemsSource = mainCourse;
        }
    }
}
