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
using System.Xml.Linq;

namespace Prb.Variables.Hello.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //string name;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TxtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            String name = txtUserName.Text;
            lblFeedback.Content = "Je naam is " + name;
        }
 
        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            String name = txtUserName.Text;
            name = name.ToUpper();
            lblUpperCase.Content = name;

            MessageBox.Show("Ben jij werkelijk dé " + name + "?");

            int number = 0;
            bool trueOrFalse = Convert.ToBoolean(number);
            MessageBox.Show("number = " + number);
            MessageBox.Show("Getal = " + trueOrFalse);

            long longNumber = 0;
            int number2 = (int)longNumber;
            MessageBox.Show("LoongNumber = " + longNumber);
            MessageBox.Show("Int number = " + number2);
        }


    }
}