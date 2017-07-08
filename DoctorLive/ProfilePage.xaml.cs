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
    public partial class ProfilePage : PhoneApplicationPage
    {
        private MobileServiceCollection<myProfile, myProfile> items1;
        private IMobileServiceTable<myProfile> profileTable = App.MobileService.GetTable<myProfile>();

        public ProfilePage()
        {
            InitializeComponent();
            this.Loaded += profilePageLoaded;
        }



        async void profilePageLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var test1 = await profileTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                           .Select(t => t.name)
                                .ToEnumerableAsync();
                var test11 = test1.FirstOrDefault();
                nameTb.Text = test11;


                var test2 = await profileTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.age)
                            .ToEnumerableAsync();
                var test22 = test2.FirstOrDefault();
                ageTb.Text = Convert.ToString(test22);

                var test3 = await profileTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.sex)
                            .ToEnumerableAsync();
                var test33 = test3.FirstOrDefault();
                sexTb.Text = test33;

                var test4 = await profileTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.email)
                            .ToEnumerableAsync();
                var test44 = test4.FirstOrDefault();
                emailTb.Text = test44;

                var test5 = await profileTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.mobile)
                            .ToEnumerableAsync();
                var test55 = test5.FirstOrDefault();
                phoneTb.Text = test55;

            }

        
            catch{
                MessageBox.Show("connectivity Problem");
            }

    }
    }
}