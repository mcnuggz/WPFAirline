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
    public partial class MainPage : Page
    {
        public List<Flight> availableFlights = new List<Flight>();
        public Flight flight1;
        public Flight flight2;
        public Flight flight3;

        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }
   
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            flight1 = new Flight(7501, "Milwaukee", "Boston", "8:15am", "2/15/16");
            flight2 = new Flight(8405, "Milwaukee", "Las Vegas", "10:40am", "3/16/2016");
            flight3 = new Flight(5423, "Milwaukee", "Orlando", "10:15pm", "3/25/2016"); 
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
                nav.Navigate(new Uri("SeatReservationPage2.xaml", UriKind.RelativeOrAbsolute));
            }
            else if (userFlight == availableFlights[2].ToString())
            {
                nav.Navigate(new Uri("SeatReservationPage3.xaml", UriKind.RelativeOrAbsolute));
            }
            else
            {
                MessageBox.Show("Error: No flight was chosen.\nPlease select a flight.");
            }
            
           
        }

    }
}
