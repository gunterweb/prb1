using System.Windows;
using System.Windows.Controls;

namespace Prb.LievelingsStad_Void.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string city;
        string sentenceHead;

        const string HeadDutch = "Je lievelingsstad is ";
        const string HeadEnglish = "Your favorite city is ";
        const string ChoiceDutch = "Kies je lievelingsstad";
        const string ChoiceEnglish = "Choose your favorite city";

        public MainWindow()
        {
            InitializeComponent();
            sentenceHead = HeadDutch;
        }

        private void WndMainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            FillLstCities();

            HideButtons();

            Title = ChoiceDutch;
        }

        private void HideButtons()
        {
            btnEn.Visibility = Visibility.Hidden;
            btnNl.Visibility = Visibility.Hidden;
        }
        private void ShowButtons()
        {
            btnEn.Visibility = Visibility.Visible;
            btnNl.Visibility = Visibility.Visible;
        }

        private void FillLstCities()
        {
            lstCities.Items.Add("Antwerpen");
            lstCities.Items.Add("Brugge");
            lstCities.Items.Add("Brussel");
            lstCities.Items.Add("Gent");
            lstCities.Items.Add("Hasselt");
        }

        private void RefreshFeedback()
        {
            string feedback = sentenceHead + " " + city;
            lblFavoriteCity.Content = feedback;
        }


        private void LstCities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            city = lstCities.SelectedItem.ToString();
            RefreshFeedback();

            ShowButtons();
        }

        private void BtnEn_Click(object sender, RoutedEventArgs e)
        {
            string title;
            title = ChoiceEnglish;
            Title = title;

            sentenceHead = HeadEnglish;
            RefreshFeedback();
        }

        private void BtnNl_Click(object sender, RoutedEventArgs e)
        {
            string title;
            title = ChoiceDutch;
            Title = title;

            sentenceHead = HeadDutch;
            RefreshFeedback();
        }
    }
}
