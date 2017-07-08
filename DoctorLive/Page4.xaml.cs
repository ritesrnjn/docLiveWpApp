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
    public partial class Page4 : PhoneApplicationPage
    {
        public Page4()
        {
            InitializeComponent();
        }
         String Specialization;
        private void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Specialization = "specialization 1";
            NavigationService.Navigate(new Uri("/Appointment.xaml?msg=" + Specialization, UriKind.Relative));
        }

        private void TextBlock_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Specialization = "specialization 2";
            NavigationService.Navigate(new Uri("/Appointment.xaml?msg=" + Specialization, UriKind.Relative));
        }

        private void TextBlock_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Specialization = "specialization 3";
            NavigationService.Navigate(new Uri("/Appointment.xaml?msg=" + Specialization, UriKind.Relative));
        }

        private void TextBlock_Tap_3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Specialization = "specialization 4";
            NavigationService.Navigate(new Uri("/Appointment.xaml?msg=" + Specialization, UriKind.Relative));
        }

        private void TextBlock_Tap_4(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Specialization = "specialization 5";
            NavigationService.Navigate(new Uri("/Appointment.xaml?msg=" + Specialization, UriKind.Relative));
        }

        private void TextBlock_Tap_5(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Specialization = "specialization 6";
            NavigationService.Navigate(new Uri("/Appointment.xaml?msg=" + Specialization, UriKind.Relative));
        }
    }
}