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

namespace Prb.Variables.Conversion.Wpf
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

        private decimal vatTax = 0.21M;

        private void btnProcessOrder_Click(object sender, RoutedEventArgs e)
        {
            //declareer hier je variabelen, en converteer de .Text waarden uit de Textboxes naar een passend type
            //consider it "done"

            decimal liters = decimal.Parse(txtLitersToBuy.Text);
            decimal pricePerLiter = decimal.Parse(txtPricePerLiter.Text);
            float vat = (float)vatTax;
            short persons = short.Parse(txtPersons.Text);
            bool consent = bool.Parse(txtConsent.Text);

            ProcessOrder(
                liters,
                pricePerLiter,
                vat,
                persons,
                consent);
        }

        private void ProcessOrder(decimal liters, decimal pricePerLiter, float vat, short persons, bool consent)
        {
            decimal price = liters * pricePerLiter;
            decimal vatAmount = price * (decimal)vat;
            decimal priceWithVat = price + vatAmount;
            decimal litersPerPerson = liters / persons;

            txtPriceNoVat.Text = price.ToString();
            txtVAT.Text = vatAmount.ToString();
            txtPrice.Text = priceWithVat.ToString();
            txtLitersPerPerson.Text = litersPerPerson.ToString();
        }

    }
}
