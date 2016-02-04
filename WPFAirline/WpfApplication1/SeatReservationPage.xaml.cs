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
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class SeatReservationPage : Page
    {
        public SeatReservationPage()
        {
            InitializeComponent();
        }
        private void ReserveSeatButton_Click(object sender, RoutedEventArgs e)
        {
            // Reserve Seat button clicked, shows input box.
            InputBox.Visibility = Visibility.Visible;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Submit button Clicked! Hides InputBox and handle the input text.
            InputBox.Visibility = Visibility.Collapsed;

            // Do something with the Input
            String input = InputNameBox.Text;
            Flight _addpassenger = new Flight();
            _addpassenger.AddPassenger(5, input);
            //MyListBox.Items.Add(input); // Add Input to ListBox, need to change.

            // Clear InputBox.
            InputNameBox.Text = String.Empty;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Cancel Button Clicked! Hides InputBox until reserve seat button is clicked again.
            InputBox.Visibility = Visibility.Collapsed;

            // Clear InputBox.
            InputNameBox.Text = String.Empty;
        }
    }
}