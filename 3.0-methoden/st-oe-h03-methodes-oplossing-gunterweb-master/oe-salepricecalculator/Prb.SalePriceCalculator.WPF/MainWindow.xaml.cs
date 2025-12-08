using System.Windows;

namespace Prb.SalePriceCalculator.WPF
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

        private void RdbEndUser_Checked(object sender, RoutedEventArgs e)
        {
            decimal defaultPrice = decimal.Parse(txtDefaultSalePrice.Text);
            lblSalePrice.Content = CalculateSalePrice(defaultPrice).ToString("#,##0.00");
        }

        private void RdbShopOwner_Checked(object sender, RoutedEventArgs e)
        {
            decimal defaultPrice = decimal.Parse(txtDefaultSalePrice.Text);
            lblSalePrice.Content = CalculateSalePrice(defaultPrice, 25).ToString("#,##0.00");
        }

        private void RdbWholeSaler_Checked(object sender, RoutedEventArgs e)
        {
            decimal defaultPrice = decimal.Parse(txtDefaultSalePrice.Text);
            lblSalePrice.Content = CalculateSalePrice(defaultPrice, 35).ToString("#,##0.00");
        }

        private decimal CalculateSalePrice(decimal defaultPrice, float discountPerCent = 0)
        {
            decimal discount = defaultPrice * ((decimal)discountPerCent / 100);
            return defaultPrice - discount;
        }
    }
}
