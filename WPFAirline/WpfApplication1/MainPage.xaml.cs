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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        List<Flight> availableFlights = new List<Flight>();
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            Flight flight1 = new Flight(7501, "Milwaukee", "Boston");
            Flight flight2 = new Flight(8405, "Milwaukee", "Las Vegas");
            Flight flight3 = new Flight(5423, "Milwaukee", "Orlando");

            
            availableFlights.Add(flight1);
            availableFlights.Add(flight2);
            availableFlights.Add(flight3);

            foreach (Flight flight in availableFlights)
            {
                flightList.Items.Add(flight.ToString());
            }


        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string userFlight = flightList.Text;
            NavigationService nav = NavigationService.GetNavigationService(this.flightList);
            if (userFlight == availableFlights[0].ToString())
            {
                nav.Navigate(new Uri("SeatReservationPage.xaml", UriKind.RelativeOrAbsolute));
            }
            else if(userFlight == availableFlights[1].ToString())
            {
                nav.Navigate(new Uri("SeatReservationPage.xaml", UriKind.RelativeOrAbsolute));
            }
            else if (userFlight == availableFlights[2].ToString())
            {
                nav.Navigate(new Uri("SeatReservationPage.xaml", UriKind.RelativeOrAbsolute));
            }
            else
            {
                MessageBox.Show("Error: No flight was chosen.\nPlease select a flight.");
            }
            
           
        }

    }
}
