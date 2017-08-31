using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ResisterCalculator
{
    public partial class MainWindow : Window
    {
        private List<Bands> bandList;
        private List<Bands> toleranceList;
        private CalculateResistor cr;

        private int first, second, third, fourth;

        private string Ohm = "\u2126";
        private string PlusMinus = "\u00B1";

        public MainWindow()
        {
            bandList = new BandList().initBandList();
            toleranceList = new ToleranceList().initToleranceList();
            cr = new CalculateResistor(bandList, toleranceList);
            InitializeComponent();
        }

        private void outputStuff(int one, int two, int three, int four)
        {
            outputBlock.Text = string.Format("{0}{1} {2}{3}.", cr.calculateOutput(one, two, three), Ohm, PlusMinus, toleranceList[four].ToTolerance());
        }

        private void BandOne_Loaded(object sender, RoutedEventArgs e)
        {
            var CBox = sender as ComboBox;
            CBox.ItemsSource = bandList;
            CBox.SelectedIndex = 0;
            first = CBox.SelectedIndex;
        }

        private void BandOne_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var CBox = sender as ComboBox;

            first = CBox.SelectedIndex;
            outputStuff(first, second, third, fourth);
        }

        private void BandTwo_Loaded(object sender, RoutedEventArgs e)
        {
            var CBox = sender as ComboBox;
            CBox.ItemsSource = bandList;
            CBox.SelectedIndex = 0;
            second = CBox.SelectedIndex;
        }

        private void BandTwo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var CBox = sender as ComboBox;

            second = CBox.SelectedIndex;
            outputStuff(first, second, third, fourth);
        }

        private void Multiplier_Loaded(object sender, RoutedEventArgs e)
        {
            var CBox = sender as ComboBox;
            CBox.ItemsSource = bandList;
            CBox.SelectedIndex = 0;
            third = CBox.SelectedIndex;
        }

        private void Multiplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var CBox = sender as ComboBox;

            third = CBox.SelectedIndex;
            outputStuff(first, second, third, fourth);
        }

        private void find_GotFocus(object sender, RoutedEventArgs e)
        {
            var TB = sender as TextBox;
            TB.Text = string.Empty;
        }

        private void Tolerance_Loaded(object sender, RoutedEventArgs e)
        {
            var CBox = sender as ComboBox;
            CBox.ItemsSource = toleranceList;
            CBox.SelectedIndex = 1;
            fourth = CBox.SelectedIndex;
        }

        private void Tolerance_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var CBox = sender as ComboBox;

            fourth = CBox.SelectedIndex;
            outputStuff(first, second, third, fourth);
        }

        private void FourBandCheckBox_Checked(object sender, EventArgs e)
        {
            threeBand.IsChecked = false;
        }

        private void ThreeBandCheckBox_Checked(object sender, EventArgs e)
        {
            fourBand.IsChecked = false;
        }
    }
}
