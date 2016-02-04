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
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            Aircraft Bombardiar = new Aircraft(20, 1000, true);
            Aircraft Boeing = new Aircraft(80, 2000, true);
            Aircraft Airbus = new Aircraft(150, 4000, true);
            flightList.Items.Add(new Flight(1234, Bombardiar, "Milwaukee", "St. Louis").ToString());
            flightList.Items.Add(new Flight(7501, Boeing, "Milwaukee", "Boston").ToString());
            //flightList.Items.Add(new Flight(9001, Bombardiar, "Milwaukee", "Seattle").ToString());
            //flightList.Items.Add(new Flight(8405, Boeing, "Milwaukee", "Las Vegas").ToString());
            //flightList.Items.Add(new Flight(5423, Airbus, "Milwaukee", "Orlando").ToString());
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("SeatReservationPage.xaml", UriKind.RelativeOrAbsolute));

        }
    }
}
