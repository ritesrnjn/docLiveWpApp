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
    public partial class PanoramaPage2 : PhoneApplicationPage
    {

        private MobileServiceCollection<Prescription, Prescription> items2;
        private IMobileServiceTable<Prescription> PrescriptionTable = App.MobileService.GetTable<Prescription>();
        public PanoramaPage2()
        {
            InitializeComponent();
            this.Loaded += medicinePageLoaded;
        }

        async void medicinePageLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var test1 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                           .Select(t => t.med1)
                                .ToEnumerableAsync();
                var test11 = test1.FirstOrDefault();
                m1Name.Text = test11;


                var test2 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.strength1)
                            .ToEnumerableAsync();
                var test22 = test1.FirstOrDefault();
                m1Strength.Text = test22;

                var test3 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.dose1)
                            .ToEnumerableAsync();
                var test33 = Convert.ToString(test3.FirstOrDefault());

                m1Dose.Text = test33;

                var test4 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.doseqty1)
                            .ToEnumerableAsync();
                var test44 = test4.FirstOrDefault();
                m1DoseQty.Text = test44;

                var test5 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.med2)
                            .ToEnumerableAsync();
                var test55 = test5.FirstOrDefault();
                m2Name.Text = test55;

                var test6 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.strength2)
                            .ToEnumerableAsync();
                var test66 = test6.FirstOrDefault();
                m2Strength.Text = test66;

                var test7 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.dose2)
                        .ToEnumerableAsync();
                var test77 = test7.FirstOrDefault();
                m2Dose.Text = test77;

                var test8 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.doseqty2)
                        .ToEnumerableAsync();
                var test88 = test8.FirstOrDefault();
                m2DoseQty.Text = test88;

                var test9 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.med3)
                        .ToEnumerableAsync();
                var test99 = test9.FirstOrDefault();
                m3Name.Text = test99;

                var test10 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.strength3)
                        .ToEnumerableAsync();
                var test100 = test10.FirstOrDefault();
                m3Strength.Text = test100;

                var test13 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.dose3)
                        .ToEnumerableAsync();
                var test111 = test13.FirstOrDefault();
                m3Dose.Text = test111;


                var test15 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.doseqty3)
                        .ToEnumerableAsync();
                var test115 = test15.FirstOrDefault();
                m3DoseQty.Text = test115;


                var test16 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.med4)
                        .ToEnumerableAsync();
                var test116 = test16.FirstOrDefault();
                m4Name.Text = test116;

                var test17 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.strength4)
                        .ToEnumerableAsync();
                var test117 = test17.FirstOrDefault();
                m4Strength.Text = test117;


                var test18 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.dose4)
                        .ToEnumerableAsync();
                var test118 = test18.FirstOrDefault();
                m4Dose.Text = test118;

                var test19 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.doseqty4)
                        .ToEnumerableAsync();
                var test119 = test19.FirstOrDefault();
                m4DoseQty.Text = test119;



                

            }



            catch
            {
                MessageBox.Show("ConnectivityError");
            }

        }
    }
}