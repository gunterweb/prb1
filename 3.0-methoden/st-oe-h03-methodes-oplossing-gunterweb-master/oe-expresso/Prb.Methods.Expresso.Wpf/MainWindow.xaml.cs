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

namespace Prb.Methods.Expresso.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal pricePerCoffee = 2.5m;

        string queuedOrder = "";

        int numberOfCustomers = 0;
        int numberOfCoffeesSold = 0;
        decimal profit = 0m;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbSize.Items.Add("Small");
            cmbSize.Items.Add("Medium");
            cmbSize.Items.Add("Large");
            cmbSize.SelectedIndex = 1;

            lstCoffees.Items.Add("Lungo");
            lstCoffees.Items.Add("Americano");
            lstCoffees.Items.Add("Espresso");
            lstCoffees.Items.Add("Double Espresso");
            lstCoffees.Items.Add("Latte");
            lstCoffees.SelectedIndex = 0;

            stpQueue.Visibility = Visibility.Hidden;
            EmptyTextBoxes();
            UpdateStats();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            lstCoffees.Items.Add(txtNewCoffee.Text);
            EmptyTextBoxes();
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            int numberOfCups = int.Parse(txtCups.Text);
            decimal tip = decimal.Parse(txtTip.Text);
            decimal totalPrice = CalculatePrice(numberOfCups, tip);
            string typeOfCoffee = (string)lstCoffees.SelectedItem;
            string coffeeSize = (string)cmbSize.SelectedItem;

            lstOrders.Items.Add(GenerateMessage(numberOfCups, coffeeSize, typeOfCoffee, totalPrice));

            CoffeesBought(numberOfCups, totalPrice);
            UpdateStats();
            EmptyTextBoxes();
        }

        private void Queue_Click(object sender, RoutedEventArgs e)
        {

            int numberOfCups = int.Parse(txtCups.Text);
            decimal tip = decimal.Parse(txtTip.Text);
            decimal totalPrice = CalculatePrice(numberOfCups, tip);
            string typeOfCoffee = lstCoffees.SelectedItem.ToString();
            string coffeeSize = cmbSize.SelectedItem.ToString();



            queuedOrder = GenerateMessage(numberOfCups, coffeeSize, typeOfCoffee, totalPrice) + " (wacht)";

            stpQueue.Visibility = Visibility.Visible;
            btnQueue.IsEnabled = false;

            CoffeesBought(numberOfCups, totalPrice);
            UpdateStats();
            EmptyTextBoxes();
        }

        private void CoffeesBought(int numberOfCups, decimal totalPrice)
        {
            numberOfCustomers++;
            numberOfCoffeesSold += numberOfCups;
            profit += totalPrice;
        }

        private void EmptyQueue_Click(object sender, RoutedEventArgs e)
        {
            lstOrders.Items.Add(queuedOrder);
            queuedOrder = "";
            stpQueue.Visibility = Visibility.Hidden;
            btnQueue.IsEnabled = true;
        }

        private void EmptyTextBoxes()
        {
            txtNewCoffee.Text = "";
            txtCups.Text = "0";
            txtTip.Text = "0";
        }

        private void UpdateStats()
        {
            lblCoffeesSold.Content = numberOfCoffeesSold;
            lblNumberOfCustomers.Content = numberOfCustomers;
            lblProfit.Content = profit;

        }

        private decimal CalculatePrice(int numberOfCups, decimal tip)
        {
            return (numberOfCups * pricePerCoffee) + tip;
        }

        private string GenerateMessage(int numberOfCups, string coffeeSize, string typeOfCoffee, decimal totalPrice)
        {
            return $"{numberOfCups} {coffeeSize} {typeOfCoffee} besteld voor {totalPrice}.";
        }
    }
}
