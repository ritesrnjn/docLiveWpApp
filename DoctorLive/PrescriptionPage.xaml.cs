using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.WindowsAzure.MobileServices;

namespace DoctorLive
{
    public partial class PrescriptionPage : PhoneApplicationPage
    {
        private MobileServiceCollection<myProfile, myProfile> items1;
        private IMobileServiceTable<myProfile> profileTable = App.MobileService.GetTable<myProfile>();
        public PrescriptionPage()
        {
            InitializeComponent();
            this.Loaded += prescription_page_laded;
        }

        async void prescription_page_laded(object sender, RoutedEventArgs e)
        {
            var test1 = await profileTable
                //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                            .Select(t => t.name)
                                 .ToEnumerableAsync();
            var test11 = test1.FirstOrDefault();
            nameDisplay.Text = test11;

        }

        private void Tests_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SuggestedTests.xaml", UriKind.Relative));
        }

        private void Tests1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Suggestions.xaml", UriKind.Relative));
        }

        private void Med_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PanoramaPage2.xaml", UriKind.Relative));
        }
    }
}