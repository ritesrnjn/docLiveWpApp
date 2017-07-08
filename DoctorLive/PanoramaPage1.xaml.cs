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
    public partial class PanoramaPage1 : PhoneApplicationPage
    {

        private MobileServiceCollection<Casesheet, Casesheet> itemcasesheet;
        private IMobileServiceTable<Casesheet> mycasetable = App.MobileService.GetTable<Casesheet>();

        public PanoramaPage1()
        {
            InitializeComponent();
            this.Loaded += casesheetLoaded;
        }

        async void casesheetLoaded(object sender, RoutedEventArgs e)

        {

            try
            
            {
                var test1 = await mycasetable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                           .Select(t => t.vitals_bp)
                                .ToEnumerableAsync();
                var test11 = test1.FirstOrDefault();
                vbp.Text = test11;

                var test18 = await mycasetable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.vitals_bp)
                        .ToEnumerableAsync();
                var test118 = test18.FirstOrDefault();
                vbp.Text = test118;


                var test2 = await mycasetable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.vitals_sugar)
                            .ToEnumerableAsync();
                var test22 = test1.FirstOrDefault();
                vs.Text = test22;

                var test3 = await mycasetable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.vitals_temp)
                            .ToEnumerableAsync();
                var test33 = Convert.ToString(test3.FirstOrDefault());

                vt.Text = test33;

                var test4 = await mycasetable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.personal_history)
                            .ToEnumerableAsync();
                var test44 = test4.FirstOrDefault();
                ph.Text = test44;

                var test5 = await mycasetable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.examination_cardio)
                            .ToEnumerableAsync();
                var test55 = test5.FirstOrDefault();
                ec.Text = test55;

                var test6 = await mycasetable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.examination_respiratory)
                            .ToEnumerableAsync();
                var test66 = test6.FirstOrDefault();
                er.Text = test66;

                var test7 = await mycasetable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.examination_abdomen)
                        .ToEnumerableAsync();
                var test77 = test7.FirstOrDefault();
                ea.Text = test77;

                var test8 = await mycasetable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.diagnosis)
                        .ToEnumerableAsync();
                var test88 = test8.FirstOrDefault();
                d.Text = test88;

            }



            catch
            {
                MessageBox.Show("ConnectivityError");
            }


        }
    }
}