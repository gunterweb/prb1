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

namespace Prb.Lines.Wpf
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
    
        private void DrawLineRight(int dikte = 20)
        {
            double positie = (double)cmbPositionFromLeft.SelectedItem;
            double lengte = (double)cmbLengthVertical.SelectedItem;

            Line line = new Line();
            line.X1 = positie;
            line.Y1 = 0;
            line.X2 = positie;
            line.Y2 = lengte;
            line.StrokeThickness = dikte;
            line.Stroke = new SolidColorBrush(Colors.Red);
            canSquareRight.Children.Add(line);
        }
        private void DrawLineLeft(int dikte = 50)
        {
            double positie = (double)cmbPositionFromTop.SelectedItem;
            double lengte = (double)cmbLengthHorizontal.SelectedItem;

            Line line = new Line();
            line.X1 = 0;
            line.Y1 = positie;
            line.X2 = lengte;
            line.Y2 = positie;
            line.StrokeThickness = dikte;
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
            DrawLineLeft();
        }

        private void BtnDrawVerticalLine_Click(object sender, RoutedEventArgs e)
        {
            DrawLineRight();
        }
   
    }
}
