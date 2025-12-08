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

namespace Prb.Methods.SumWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int sum;
        public MainWindow()
        {
            InitializeComponent();
        }

        int CalculateSum(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        int CalculateSum(string numberOneText, string numberTwoText)
        {
            int numberOne = int.Parse(numberOneText);
            int numberTwo = int.Parse(numberTwoText);
            return CalculateSum(numberOne , numberTwo);
           
        }

        private void BtnCalculateSum_Click_1(object sender, RoutedEventArgs e)
        {
            string leftNumber = txtLeftNumber.Text;
            string rightNumber = txtRightNumber.Text;
            sum = CalculateSum(leftNumber, rightNumber);
            MessageBox.Show("De som van " + leftNumber + " en " + rightNumber + " is " + sum, "Som Berekenen");
        }
    }
}