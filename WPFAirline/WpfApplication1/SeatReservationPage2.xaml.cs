﻿using System;
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
    /// Interaction logic for SeatReservationPage2.xaml
    /// </summary>
    public partial class SeatReservationPage2 : Page
    {
        public SeatReservationPage2()
        {
            InitializeComponent();
            Loaded += SeatReservationPage2_Loaded;
        }
        Aircraft plane1 = new Aircraft(80, 2000, true);

        private void SeatReservationPage2_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < plane1.MaxPassengerCount + 1; i++)
            {
                seatList.Items.Add(new Seat(i, Price.Business));
            }
        }
       private void ReserveSeatButton_Click(object sender, RoutedEventArgs e)
        {
            // Reserve Seat button clicked, shows input box.
            InputBox.Visibility = Visibility.Visible;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Submit button Clicked, Hides InputBox and handle the input text.
            InputBox.Visibility = Visibility.Collapsed;
            // Do something with the Input
            string input = InputNameBox.Text;
            Flight _addpassenger = new Flight();
            int value = seatList.SelectedIndex + 1;
            _addpassenger.AddPassenger(value, input);
            _addpassenger.WriteToFile(@"Flight8405_PassengerManifest.txt");
            MessageBox.Show("Your seat is reserved!");
            seatList.Items.RemoveAt(value - 1);
            // Clear InputBox.
            InputNameBox.Text = string.Empty;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Cancel Button Clicked! Hides InputBox until reserve seat button is clicked again.
            InputBox.Visibility = Visibility.Collapsed;

            // Clear InputBox.
            InputNameBox.Text = string.Empty;
        }

        private void seatList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
