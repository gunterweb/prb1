using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Prb.Lines.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PopulateComboBoxes();

            SetInitialValueComboBoxes();
        }

        private void SetInitialValueComboBoxes()
        {
            cmbPositionFromLeft.SelectedIndex = 0;
            cmbPositionFromTop.SelectedIndex = 1;
            cmbLengthHorizontal.SelectedIndex = 2;
            cmbLengthVertical.SelectedIndex = 3;
        }

        private void PopulateComboBoxes()
        {
            cmbPositionFromLeft.Items.Add(100.0);
            cmbPositionFromLeft.Items.Add(200.0);
            cmbPositionFromLeft.Items.Add(300.0);
            cmbPositionFromLeft.Items.Add(400.0);

            cmbPositionFromTop.ItemsSource = cmbPositionFromLeft.Items;

            cmbLengthHorizontal.Items.Add(100.0);
            cmbLengthHorizontal.Items.Add(200.0);
            cmbLengthHorizontal.Items.Add(300.0);
            cmbLengthHorizontal.Items.Add(400.0);
            cmbLengthHorizontal.Items.Add(500.0);

            cmbLengthVertical.ItemsSource = cmbLengthHorizontal.Items;
        }
    
        private void DrawVerticalLine(double distanceFromLeft, double length, double strokeThickness = 5)
        {
            Line line = new Line();
            line.X1 = distanceFromLeft;
            line.X2 = distanceFromLeft;
            line.Y1 = 0;
            line.Y2 = line.Y1 + length;
            line.StrokeThickness = strokeThickness;
            line.Stroke = new SolidColorBrush(Colors.Red);
            canSquareRight.Children.Add(line);
        }

        private void DrawHorizontalLine(double distanceFromTop, double length, double strokeThickness = 5)
        {
            Line line = new Line();
            line.X1 = 0;
            line.X2 = line.X1 + length;
            line.Y1 = distanceFromTop;
            line.Y2 = distanceFromTop;
            line.StrokeThickness = strokeThickness;
            line.Stroke = new SolidColorBrush(Colors.White);
            canSquare.Children.Add(line);
        }        

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            canSquare.Children.Clear();
            canSquareRight.Children.Clear();
        }

        private void BtnDrawHorizontalLine_Click(object sender, RoutedEventArgs e)
        {
            double distanceFromTop;
            double length;

            distanceFromTop = (double)cmbPositionFromTop.SelectedItem;
            length = (double)cmbLengthHorizontal.SelectedItem;

            DrawHorizontalLine(distanceFromTop, length);
        }

        private void BtnDrawVerticalLine_Click(object sender, RoutedEventArgs e)
        {
            double distanceFromLeft;
            double length;
            double strokeThickness = random.Next(1, 11);

            distanceFromLeft = (double)cmbPositionFromLeft.SelectedItem;
            length = (double)cmbLengthVertical.SelectedItem;

            DrawVerticalLine(distanceFromLeft, length, strokeThickness);
        }
    }
}
