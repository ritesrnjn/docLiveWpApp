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
    public partial class Page5 : PhoneApplicationPage
    {
        private MobileServiceCollection<Casesheet, Casesheet> itemcasesheet;
        private IMobileServiceTable<Casesheet> caseTable = App.MobileService.GetTable<Casesheet>();
        public Page5()
        {
            InitializeComponent();
            this.Loaded += suggestionPageLoaded;
        }

        async void suggestionPageLoaded(object sender, RoutedEventArgs e)
        {

            var test1 = await caseTable
                //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.treatment_advised)
                            .ToEnumerableAsync();
            var test11 = test1.FirstOrDefault();
            sug.Text = test11;
        }
    }
}