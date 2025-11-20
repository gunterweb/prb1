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

namespace Prb.Inleiding.FirstApp.Wpf
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

        //Event Handler method for the Button Click event
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            //display a messagebox (popup dialog) with the user's name
            MessageBox.Show("Hello " + txtName.Text + ", welcome to C#!", "Hello!");
        }
    }
}