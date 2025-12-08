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

namespace Prb.Methods.Quiz.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int totalScore = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ResetGui();
        }

        private void BtnAnswer1b_Click(object sender, RoutedEventArgs e)
        {
            ProcessQuestion1("Het antwoord is verkeerd");
        }

        private void BtnAnswer1a_Click(object sender, RoutedEventArgs e)
        {
            ProcessQuestion1("Het antwoord is verkeerd");
        }

        private void BtnAnswer1c_Click(object sender, RoutedEventArgs e)
        {
            ProcessQuestion1("Xamarin is juist!", 1);
        }

        private void BtnAnswer2a_Click(object sender, RoutedEventArgs e)
        {
            ProcessQuestion2("Het antwoord is verkeerd");
        }

        private void BtnAnswer2b_Click(object sender, RoutedEventArgs e)
        {
            ProcessQuestion2(".NET Core is juist!", 1);
        }

        private void BtnAnswer2c_Click(object sender, RoutedEventArgs e)
        {
            ProcessQuestion2("Het antwoord is verkeerd");
        }

        private void BtnAnswer3a_Click(object sender, RoutedEventArgs e)
        {
            ProcessQuestion3("Het antwoord is verkeerd");
        }

        private void BtnAnswer3b_Click(object sender, RoutedEventArgs e)
        {
            ProcessQuestion3("Het antwoord is verkeerd");
        }

        private void BtnAnswer3c_Click(object sender, RoutedEventArgs e)
        {
            ProcessQuestion3("Xamarin is juist!", 1);
        }

        void ProcessScore(int increase = 0)
        {
            totalScore += increase;
            lblScore.Content = totalScore;
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            ResetGui();
        }

        void ProcessQuestion1(string feedback, int valueOfScore = 0)
        {
            lblFeedBack1.Content = feedback;
            ProcessScore(valueOfScore);
            wrpQuestion1.IsEnabled = false;
            wrpQuestion2.Visibility = Visibility.Visible;
        }

        void ProcessQuestion2(string feedback, int valueOfScore = 0)
        {
            lblFeedBack2.Content = feedback;
            ProcessScore(valueOfScore);
            wrpQuestion2.IsEnabled = false;
            wrpQuestion3.Visibility = Visibility.Visible;
        }

        void ProcessQuestion3(string feedback, int valueOfScore = 0)
        {
            lblFeedBack3.Content = feedback;
            ProcessScore(valueOfScore);
            wrpQuestion3.IsEnabled = false;
            btnReset.Visibility = Visibility.Visible;
        }

        void ResetGui()
        {
            wrpQuestion1.Visibility = Visibility.Visible;
            wrpQuestion2.Visibility = Visibility.Collapsed;
            wrpQuestion3.Visibility = Visibility.Collapsed;
            btnReset.Visibility = Visibility.Collapsed;
            wrpQuestion1.IsEnabled = true;
            wrpQuestion2.IsEnabled = true;
            wrpQuestion3.IsEnabled = true;
            lblFeedBack1.Content = "Kies het juiste antwoord";
            lblFeedBack2.Content = "Kies het juiste antwoord";
            lblFeedBack3.Content = "Kies het juiste antwoord";
            totalScore = 0;
            lblScore.Content = totalScore.ToString();
        }
    }
}
