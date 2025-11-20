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

namespace Prb.Variabelen.CharCount.wpf
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

        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            //lees de invoer waarde uit via de tekstbox
            string input = txtInput.Text;


            //tel het aantal karakters
            int count = input.Length;

            //toon het aantal karakters via het label
            lblCount.Content = count;

        }
    }
}