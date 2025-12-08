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

namespace Prb.FavoriteCity_Void.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region constants
        const string HeadDutch = "Je lievelingsstad is ";
        const string ChoiceDutch = "Kies je lievelingsstad";
        const string HeadEnglish = "Your favorite city is ";
        const string ChoiceEnglish = "Choose your favorite city";
        #endregion

        string city;
        string sentenceHead;
        string feedback;

        public MainWindow()
        {
            InitializeComponent();
            sentenceHead = HeadDutch;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillLstCities();
            HideButtons();
            Title = ChoiceDutch;
        }

        private void BtnNL_Click(object sender, RoutedEventArgs e)
        {
            ShowDutchFeedback();
        }

        private void BtnENG_Click(object sender, RoutedEventArgs e)
        {
            ShowEnglishFeedback();
        }

        private void LstCities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            city = lstCities.SelectedItem.ToString();
            RefreshFeedback();
            ShowButtons();
        }

        private void HideButtons()
        {
            btnENG.Visibility = Visibility.Hidden;
            btnNL.Visibility = Visibility.Hidden;
        }

        private void ShowButtons()
        {
            btnENG.Visibility = Visibility.Visible;
            btnNL.Visibility = Visibility.Visible;
        }

        private void FillLstCities()
        {
            lstCities.Items.Add("Antwerpen");
            lstCities.Items.Add("Brugge");
            lstCities.Items.Add("Brussel");
            lstCities.Items.Add("Leuven");
            lstCities.Items.Add("Gent");
        }

        private void RefreshFeedback()
        {
            string feedback = sentenceHead + " " + city;
            lblFavoriteCity.Content = feedback;
        }
                   
        private void ShowEnglishFeedback()
        {
            string title;
            title = ChoiceEnglish;
            Title = title;

            sentenceHead = HeadEnglish;
            RefreshFeedback();
        }

        private void ShowDutchFeedback()
        {
            string title;
            title = ChoiceDutch;
            Title = title;

            sentenceHead = HeadDutch;
            RefreshFeedback();
        }
    }
}
