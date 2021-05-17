using System;
using System.Collections;
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
using System.IO;
using System.Diagnostics;
namespace RestaurantBillCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<RestaurantsMenu> Beverages = new List<RestaurantsMenu>();
        List<RestaurantsMenu> Appetizer = new List<RestaurantsMenu>();
        List<RestaurantsMenu> Main_Course = new List<RestaurantsMenu>();
        List<RestaurantsMenu> Dessert = new List<RestaurantsMenu>();

        ObservableCollection<RestaurantsMenu> order = new ObservableCollection<RestaurantsMenu>();
        public double subTotal;
        public double Total;
        public double tax;
        public bool flag = true;

        public MainWindow()
        {
            InitializeComponent();


            Beverages.Add(new RestaurantsMenu { Name = "Soda", Price = 1.95, Category = "Beverage" });
            Beverages.Add(new RestaurantsMenu { Name = "Tea", Price = 1.50, Category = "Beverage" });
            Beverages.Add(new RestaurantsMenu { Name = "Coffee", Price = 1.25, Category = "Beverage" });
            Beverages.Add(new RestaurantsMenu { Name = "Mineral Water", Price = 2.95, Category = "Beverage" });
            Beverages.Add(new RestaurantsMenu { Name = "Juice", Price = 2.50, Category = "Beverage" });
            Beverages.Add(new RestaurantsMenu { Name = "Milk", Price = 1.50, Category = "Beverage" });
            beverageCombo.ItemsSource = Beverages;

            Appetizer.Add(new RestaurantsMenu { Name = "Buffalo Wings", Price = 5.95, Category = "Appetizer" });
            Appetizer.Add(new RestaurantsMenu { Name = "Buffalo Fingers", Price = 6.95, Category = "Appetizer" });
            Appetizer.Add(new RestaurantsMenu { Name = "Potato Skins", Price = 8.95, Category = "Appetizer" });
            Appetizer.Add(new RestaurantsMenu { Name = "Nachos", Price = 8.95, Category = "Appetizer" });
            Appetizer.Add(new RestaurantsMenu { Name = "Mushroom Caps", Price = 10.95, Category = "Appetizer" });
            Appetizer.Add(new RestaurantsMenu { Name = "Shrimp Cocktail", Price = 12.95, Category = "Appetizer" });
            Appetizer.Add(new RestaurantsMenu { Name = "Chips and Salsa", Price = 6.95, Category = "Appetizer" });
            AppetizerCombo.ItemsSource = Appetizer;

            Main_Course.Add(new RestaurantsMenu { Name = "Seafood Alfredo", Price = 13.95, Category = "Main Course" });
            Main_Course.Add(new RestaurantsMenu { Name = "Chicken Alfredo", Price = 13.95, Category = "Main Course" });
            Main_Course.Add(new RestaurantsMenu { Name = "Turkey Club", Price = 11.95, Category = "Main Course" });
            Main_Course.Add(new RestaurantsMenu { Name = "Lobster Pie", Price = 19.95, Category = "Main Course" });
            Main_Course.Add(new RestaurantsMenu { Name = "Prime Rib", Price = 20.95, Category = "Main Course" });
            Main_Course.Add(new RestaurantsMenu { Name = "Shrimp Scampi", Price = 18.95, Category = "Main Course" });
            Main_Course.Add(new RestaurantsMenu { Name = "Turkey Dinner", Price = 13.95, Category = "Main Course" });
            Main_Course.Add(new RestaurantsMenu { Name = "Stuffed Chicken", Price = 14.95, Category = "Main Course" });
            MainCombo.ItemsSource = Main_Course;

            Dessert.Add(new RestaurantsMenu { Name = "Apple Pie", Price = 5.95, Category = "Dessert" });
            Dessert.Add(new RestaurantsMenu { Name = "Sundae", Price = 3.95, Category = "Dessert" });
            Dessert.Add(new RestaurantsMenu { Name = "Carrot Cake", Price = 5.95, Category = "Dessert" });
            Dessert.Add(new RestaurantsMenu { Name = "Mud Pie", Price = 4.95, Category = "Dessert" });
            Dessert.Add(new RestaurantsMenu { Name = "Apple Crisp", Price = 5.95, Category = "Dessert" });
            DessertCombo.ItemsSource = Dessert;

        }
        public void AddItem(RestaurantsMenu items)
        {
            int index;
            if (order.Contains(items))
            {
                index = order.IndexOf(items);
                order[index].quantity++;
                order.Remove(items);
                order.Insert(index, items);
                dataGridOrder.ItemsSource = order;
                subTotal += order[index].Price;
                TxtSub.Text = $"{subTotal:c}";
                tax = subTotal * 0.13;
                txttax.Text = $"{tax:c}";
                Total = subTotal + tax;
                txtTotal.Text = $"{Total:c}";

            }
            else
            {
                order.Add(items);
                index = order.IndexOf(items);
                order[index].quantity++;
                dataGridOrder.ItemsSource = order;
                subTotal += order[index].Price;
                TxtSub.Text = $"{subTotal:c}";
                tax = subTotal * 0.13;
                txttax.Text = $"{tax:c}";
                Total = subTotal + tax;
                txtTotal.Text = $"{Total:c}";
            }
        }


        private void CbBeverage_DropDownClosed(object sender, EventArgs e)
        {
            if (beverageCombo.SelectedItem != null)
            {
                RestaurantsMenu item = (RestaurantsMenu)beverageCombo.SelectedItem;
                AddItem(item);
            }
        }

        private void CbMainCourse_DropDownClosed(object sender, EventArgs e)
        {
            if (MainCombo.SelectedItem != null)
            {
                RestaurantsMenu item = (RestaurantsMenu)MainCombo.SelectedItem;
                AddItem(item);
            }
        }
        private void CbDessert_DropDownClosed(object sender, EventArgs e)
        {
            if (DessertCombo.SelectedItem != null)
            {
                RestaurantsMenu item = (RestaurantsMenu)DessertCombo.SelectedItem;
                AddItem(item);
            }
        }
        private void CbAppetizer_DropDownClosed(object sender, EventArgs e)
        {
            if (AppetizerCombo.SelectedItem != null)
            {
                RestaurantsMenu item = (RestaurantsMenu)AppetizerCombo.SelectedItem;
                AddItem(item);
            }
        }

        private void btRemove_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridOrder.SelectedIndex >= 0)
            {
                RestaurantsMenu menu = (RestaurantsMenu)dataGridOrder.SelectedItem;
                subTotal -= menu.Price;

                subtxt.Text = "$" + Convert.ToString(subTotal);
                taxT.Text = "$" + Convert.ToString(Math.Round(subTotal * 0.13, 2));
                txtTotal.Text = "$" + Convert.ToString(Math.Round(subTotal * 1.13, 2));

                order.RemoveAt(dataGridOrder.SelectedIndex);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            foreach (RestaurantsMenu item in order)
            {
                item.quantity = 0;
            }
            order.Clear();
            AppetizerCombo.SelectedIndex = -1;
            beverageCombo.SelectedIndex = -1;
            DessertCombo.SelectedIndex = -1;
            MainCombo.SelectedIndex = -1;
            subTotal = 0;
            TxtSub.Text = $"{subTotal:c}";
            tax = 0;
            txttax.Text = $"{tax:c}";
            Total = 0;
            txtTotal.Text = $"{Total:c}";

        }
        private void DgrOrder(object sender, EventArgs e)
        {
            subTotal = 0;
            foreach (RestaurantsMenu items in order)
            {
                double newPrice = items.Price * items.quantity;
                subTotal += newPrice;
            }
            TxtSub.Text = $"{subTotal:c}";
            tax = subTotal * 0.13;
            txttax.Text = $"{tax:c}";
            Total = subTotal + tax;
            txtTotal.Text = $"{Total:c}";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
                MessageBox.Show("Order Complete");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login restaurants = new Login();
            btn.Children.Add(restaurants);

        }

        private void btnCentennail_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "centennialcollege.ca");
        }
    }
}



  