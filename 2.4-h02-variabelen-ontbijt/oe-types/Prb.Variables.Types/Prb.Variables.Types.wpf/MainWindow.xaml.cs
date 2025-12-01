using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prb.Variables.Types.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string campus = "Howest Brugge";
        private double latitude = 3.8404096;
        private double longitude = 51.0754816;
        private float prijsLunch = 4.50f;
        private bool hasCafetaria = true;
        private byte aantalLokalen = 200;
        private int aantalStudenten = 10000;

        public MainWindow()
        {
            InitializeComponent();
            Title = campus;
        }

        private void btnShowValues_Click(object sender, RoutedEventArgs e)
        {
            txtLatitude.Text = latitude.ToString();
            txtLongitude.Text = longitude.ToString();
            ckbHasCafetaria.IsChecked = Convert.ToBoolean(hasCafetaria);
            txtLunchCosts.Text = prijsLunch.ToString();
            txtRooms.Text = aantalLokalen.ToString();
            txtStudents.Text = aantalStudenten.ToString();
        }
    }
}