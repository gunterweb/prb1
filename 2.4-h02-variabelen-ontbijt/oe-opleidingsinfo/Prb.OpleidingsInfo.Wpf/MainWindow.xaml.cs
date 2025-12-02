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

namespace Prb.OpleidingsInfo.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string naamOpleiding;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TxtKostOpleiding_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbAantalStudenten.Items.Add(20);
            cmbAantalStudenten.Items.Add(21);
            cmbAantalStudenten.Items.Add(22);
            cmbAantalStudenten.Items.Add(23);
            cmbAantalStudenten.Items.Add(24);
            cmbAantalStudenten.Items.Add(25);

            cmbAantalStudenten.SelectedIndex = 0;
        }

        private void BtnInfoOpleiding_Click(object sender, RoutedEventArgs e)
        {
            //naam van de opleiding, locatie, kost.
            string naamOpleiding = txtOpleiding.Text;
            string locatieOpleiding = txtGemeente.Text;
            decimal kostOpleiding = decimal.Parse(txtKostOpleiding.Text);

            //            string samenvatting = $"Naam opleiding: { naamOpleiding}\nLocatie: { locatieOpleiding}\nKostOpleiding: {kostOpleiding.ToString("0.00")}\n\n ";

            string samenvatting = $"Naam opleiding: {naamOpleiding}";
            samenvatting += $"\nlocatieOpleiding: {locatieOpleiding}";
            samenvatting += $"\nkostOpleiding: {kostOpleiding.ToString("0.00")} ";

            tbkToonInfo.Text = samenvatting;
            

        }

        private void BtnInfoStudenten_Click(object sender, RoutedEventArgs e)
        {
            //naam opleiding, aantal studenten, gemiddelde leeftijd, aantal hersencellen.
            NaamOpleiding = txtOpleiding.Text;
            int aantalStudenten = (int)cmbAantalStudenten.SelectedItem;
        }
    }
}
