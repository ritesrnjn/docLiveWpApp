using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
//using DemoLocation.Resources;
using Microsoft.Phone.Tasks;
using Windows.System;
using System.Device.Location;
using System.Xml.Linq;
using Windows.Devices.Geolocation;

namespace DoctorLive
{
    public partial class menuPage : PhoneApplicationPage
    {
        public menuPage()
        {
            InitializeComponent();
        }

        private void Panorama_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void img1_Click(object sender, RoutedEventArgs e)
        {
           // GetCoordinate();
        }

        private void appontment_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.Relative));
            NavigationService.Navigate(new Uri("/Page4.xaml", UriKind.Relative));
        }

        private void img2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ProfilePage.xaml", UriKind.Relative));
        }

        private void img4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PrescriptionPage.xaml", UriKind.Relative));
        }

        private void item3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/myAppId.xaml", UriKind.Relative));
        }

        private void img3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PanoramaPage1.xaml", UriKind.Relative));
        }

        private void item2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/FeedPage1.xaml", UriKind.Relative));
        }


        //    private void GetCoordinate()
        //    {
        //        GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High)
        //        {
        //            MovementThreshold = 1
        //        };

        //        watcher.PositionChanged += this.watcher_PositionChanged;
        //        watcher.StatusChanged += this.watcher_StatusChanged;
        //        watcher.Start();
        //    }

        //    private void watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        //    {
        //        switch (e.Status)
        //        {
        //            case GeoPositionStatus.Disabled:
        //                // location is unsupported on this device
        //                break;
        //            case GeoPositionStatus.NoData:
        //                // data unavailable
        //                break;
        //        }
        //    }

        //    private void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        //    {
        //        var epl = e.Position.Location;

        //        // Access the position information thusly:
        //        lati.Text = epl.Latitude.ToString("0.000");
        //        longi.Text = epl.Longitude.ToString("0.000");

        //        CivicAddressResolver civicResolver = new CivicAddressResolver();
        //        CivicAddress c = civicResolver.ResolveAddress(new GeoCoordinate(Convert.ToDouble(lati.Text), Convert.ToDouble(longi.Text)));


        //        var webClient = new WebClient();
        //        webClient.OpenReadCompleted += new OpenReadCompletedEventHandler(GoogleMapsReverseGeocodeAsync_Completed);
        //        string queryString = "http://maps.googleapis.com/maps/api/geocode/xml?latlng=" + lati.Text + "," + longi.Text + "&sensor=false";
        //        webClient.OpenReadAsync(new Uri(queryString));
        //        //location.Text = queryString;

        //        // sendsms();

        //    }

        //    void sendsms()
        //    {
        //        SmsComposeTask SMSCompose = new SmsComposeTask();
        //        SMSCompose.To = "98861089200";
        //        SMSCompose.Body = location.Text;
        //        SMSCompose.Show();
        //    }
        //    private void GoogleMapsReverseGeocodeAsync_Completed(object sender, OpenReadCompletedEventArgs e)
        //    {
        //        XDocument doc = XDocument.Load(e.Result);

        //        // Handle status of request
        //        var status = doc.Descendants("status").First();
        //        if (status != null)
        //        {
        //            string requestStatus = status.Value;
        //            switch (requestStatus)
        //            {
        //                case "OK":  // indicates that no errors occurred; the address was successfully parsed and at least one geocode was returned.
        //                    var addresses =
        //                        from query
        //                        in doc.Descendants("result")
        //                        select new StreetAddress
        //                        {
        //                            formatted_address = (string)query.Element("formatted_address"),
        //                            type = (string)query.Element("type"),
        //                        };

        //                    if (addresses.Count() > 0)
        //                    {
        //                        StreetAddress currentAddress = addresses.First();
        //                        string myAddress = "Street address unknown";
        //                        myAddress = currentAddress.formatted_address;
        //                        location.Text = myAddress;
        //                        sendsms();
        //                    }
        //                    break;
        //                case "ZERO_RESULTS":    // indicates that the geocode was successful but returned no results. This may occur if the geocode was passed a non-existent address or a latlng in a remote location.
        //                case "OVER_QUERY_LIMIT":    // indicates that you are over your quota.
        //                case "REQUEST_DENIED":  // indicates that your request was denied, generally because of lack of a sensor parameter.
        //                case "INVALID_REQUEST": // generally indicates that the query (address or latlng) is missing.
        //                default:
        //                    break;
        //            }

        //        }
        //    }
        //}

        //class StreetAddress
        //{
        //    public string formatted_address;
        //    public string type;
        //}


    }

}

