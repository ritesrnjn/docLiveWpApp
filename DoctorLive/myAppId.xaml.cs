using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace DoctorLive
{
    public partial class myAppId : PhoneApplicationPage
    {
        public myAppId()
        {
            InitializeComponent();
            this.Loaded += idPageLoaded;
        }

        async void idPageLoaded(object sender, RoutedEventArgs e)
        {
            string id = string.Format( App.MobileService.CurrentUser.UserId);
            idBox.Text = id;
        }
    }
}