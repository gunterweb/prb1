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

namespace Prb.Methods.CalculateCost.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        #region Methods
        decimal CalculateTotalPrice(decimal price, int days)
        {
            decimal totalPrice;
            totalPrice = price * days;
            return totalPrice;

        }

        #endregion

        #region EventHandlers
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Voorzien van vooraf ingevulde velden voor testdoeleinden
            double startPrice = 25.75;
            txtDayPrice.Text = startPrice.ToString();
        }
        private void BtnCalculateTotalPrice_Click(object sender, RoutedEventArgs e)
        {
            decimal totalPrice, dayPrice;
            int dayCount;

            // Waarden ophalen uit Controls en omzetten naar type
            dayPrice = decimal.Parse(txtDayPrice.Text);
            dayCount = int.Parse(txtNumberOfDays.Text);

            // Berekening aan de hand van methode CalculateTotalPrice
            totalPrice = CalculateTotalPrice(dayPrice, dayCount);

            // Weergeven in de GUI
            lblTotalPrice.Content = "€" + totalPrice.ToString();
            

        }
        private void SldNumberOfDays_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double numberOfDays = sldNumberOfDays.Value;
            txtNumberOfDays.Text = numberOfDays.ToString("0");
        }

        #endregion

    }
}
