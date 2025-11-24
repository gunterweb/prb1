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

namespace Prb.PreferredCourse.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string name;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnOK.Visibility = Visibility.Hidden;
            lstPreference.IsEnabled = false;

            lstPreference.Items.Add("PRB");
            lstPreference.Items.Add("WFB");
            lstPreference.Items.Add("CIB");
        }

        private void TxtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                btnOK.Visibility = Visibility.Hidden;
            }
            else 
            {
                btnOK.Visibility = Visibility.Visible;

            }
            
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            name = txtName.Text;
                lblWelcome.Content = $"Welkom in Howest, {name}";
            lstPreference.IsEnabled = true;
        }

        private void LstPreference_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string preferredCourse = lstPreference.SelectedItem.ToString();
            tbkFeedBack.Text = $"{name}, je voorkeur gaat uit naar {preferredCourse}";
        }
    }
}
