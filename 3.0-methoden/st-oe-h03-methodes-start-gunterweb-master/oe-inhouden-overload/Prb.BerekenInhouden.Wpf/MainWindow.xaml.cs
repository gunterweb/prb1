using System;
using System.Windows;
using System.Windows.Controls;

namespace Prb.BerekenInhouden.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const double PiNumber = Math.PI;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HideAllGrids();
        }

        private void BtnBar_Click(object sender, RoutedEventArgs e)
        {
            ShowGrid(grdBar);
            ClearInputAndCalculations();
            txtHeight.Focus();
        }

        private void BtnCylinder_Click(object sender, RoutedEventArgs e)
        {
            ShowGrid(grdCylinder);
            grdCylinder.Margin = new Thickness(10, 127, 0, 0);
            grdCylinder.Margin = grdBar.Margin;
            ClearInputAndCalculations();
            txtHeight.Focus();
        }

        private void BtnCalculateBar_Click(object sender, RoutedEventArgs e)
        {
            int length, width, heigth;
            int contentBar;
            string calculationDetails;

            length = int.Parse(txtLength.Text);
            width = int.Parse(txtWidth.Text);
            heigth = int.Parse(txtHeight.Text);

            contentBar = GetContentBar(heigth, length, width);

            calculationDetails = $"Berekening inhoud van de balk\n" +
                                      $"Breedte: {width}\n" +
                                      $"Lengte: {length}\n" +
                                      $"Hoogte: {heigth}\n" +
                                      $"{length} * {width} * {heigth} = {contentBar.ToString("0.00")}";
            ClearInputAndCalculations();

            tbkCalculationBar.Text = calculationDetails;

            txtHeight.Focus();
        }

        private void BtnCalculateCylinder_Click(object sender, RoutedEventArgs e)
        {
            int heigth;
            float diameter;
            float contentCylinder;
            string calculationDetails;

            diameter = float.Parse(txtDiameter.Text);
            heigth = int.Parse(txtHeight.Text);
            contentCylinder = GetContentCylinder(heigth, diameter);

            calculationDetails = $"Berekening inhoud van de cilinder\n" +
                $"Diameter: {diameter}\n" +
                $"Hoogte: {heigth}\n" +
                $"({diameter} / 2)² * π * {heigth} = {contentCylinder.ToString("0.00")}";

            ClearInputAndCalculations();

            tbkCalculationCylinder.Text = calculationDetails;

            txtHeight.Focus();
        }

        float GetContentCylinder(int height, float diameter)
        {
            float content;
            content = (float)Math.Pow(diameter / 2, 2) * (float)PiNumber * height;
            return content;
        }

        int GetContentBar(int height, int length, int width)
        {
            int content;
            content = height * length * width;
            return content;
        }

        void ShowGrid(Grid gridToShow)
        {
            HideAllGrids();
            grdHeight.Visibility = Visibility.Visible;
            gridToShow.Visibility = Visibility.Visible;
        }
        
        void HideAllGrids()
        {
            grdBar.Visibility = Visibility.Hidden;
            grdCylinder.Visibility = Visibility.Hidden;
            grdHeight.Visibility = Visibility.Hidden;
        }

        void ClearInputAndCalculations()
        {
            txtWidth.Clear();
            txtDiameter.Text = string.Empty;
            txtHeight.Text = "";
            txtLength.Text = "";
            tbkCalculationBar.Text = "";
            tbkCalculationCylinder.Text = "";
        }

    }
}
