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

namespace Prb.Variables.Operators.wpf
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

        private void lstOperations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstOperations.Items.Add("Optelling: 29 + 7 = " + (29 + 7));
            lstOperations.Items.Add("Modulo: 100 % 97 = " + (100 % 97));
            lstOperations.Items.Add("Deling: 29 / 7 = " + (29 / 7));
            lstOperations.Items.Add("Deling F: 29 / 7 = " + (29F / 7));
            lstOperations.Items.Add("Vierkantswortel van 16 = " + Math.Sqrt(16));
            lstOperations.Items.Add("2 tot de 3de macht = " + Math.Pow(2, 3));
            int loper;
            string valler;

        }
    }
}