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
using WPFAirline;

namespace WpfApplication1
{
    public partial class SeatReservationPage : Page
    {
        public SeatReservationPage()
        {
            InitializeComponent();
            Loaded += SeatReservationPage_Loaded;
        }
        Aircraft plane1 = new Aircraft(20, 1000, true);
        private void SeatReservationPage_Loaded(object sender, RoutedEventArgs e)
        {        
            for (int i = 1; i < plane1.MaxPassengerCount+1; i++)
            {
                seatList.Items.Add(new Seat(i, Price.FirstClass));
            }
        }
        private void ReserveSeatButton_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Visibility = Visibility.Visible;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Visibility = Visibility.Collapsed;
            string input = InputNameBox.Text;
            Flight _addpassenger = new Flight();
            
            int value = seatList.SelectedIndex + 1;
            _addpassenger.AddPassenger(value, input);
            _addpassenger.WriteToFile(@"Flight7501_PassengerManifest.txt");
            MessageBox.Show("Your seat is reserved!");
            seatList.Items.RemoveAt(value - 1);
            InputNameBox.Text = string.Empty;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Visibility = Visibility.Collapsed;
            InputNameBox.Text = string.Empty;
        }

        private void SubmitButton2_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Visibility = Visibility.Collapsed;
            string input = InputNameBox.Text;
            
            Flight _addpassenger = new Flight();
            int value = seatList.SelectedIndex + 1;
            _addpassenger.AddPassenger(value, input);
            _addpassenger.WriteToFile(@"Flight7501_PassengerManifest.txt");
            MessageBox.Show("Your seat is reserved!");
            seatList.Items.RemoveAt(value - 1);
            InputNameBox.Text = string.Empty;
        }

        private void CancelButton2_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Visibility = Visibility.Collapsed;
            InputNameBox.Text = string.Empty;
        }
        private void CancelSeatButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void seatList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}