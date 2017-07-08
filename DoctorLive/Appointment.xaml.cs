using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace DoctorLive
{
    public partial class Appointment : PhoneApplicationPage
    {
        public Appointment()
        {
            InitializeComponent();
        }

        string x ;
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string msg;
            if (NavigationContext.QueryString.TryGetValue("msg", out msg))
            {
                x = msg;
                //tb.Text = x;
            }
        }

        string DoctorName;

        string mail;
        private void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DoctorName= "Doctor 1";
            mail =string.Format("Need An Appointment\n Specialization:: {0} \n Doctor:: {1}" ,x, DoctorName);
            btnMail_Click();

        }

        private void TextBlock_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DoctorName = "Doctor 2";
            mail = string.Format("Need An Appointment\n Specialization:: {0} \n Doctor:: {1}", x, DoctorName);
            btnMail_Click();
        }

        private void TextBlock_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DoctorName = "Doctor 3";
            mail = string.Format("Need An Appointment\n Specialization:: {0} \n Doctor:: {1}", x, DoctorName);
            btnMail_Click();
        }

        private void TextBlock_Tap_3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DoctorName = "Doctor 4";
            mail = string.Format("Need An Appointment\n Specialization:: {0} \n Doctor:: {1}", x, DoctorName);
            btnMail_Click();
        }

        private void TextBlock_Tap_4(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DoctorName = "Doctor 5";
            mail = string.Format("Need An Appointment\n Specialization:: {0} \n Doctor:: {1}", x, DoctorName);
            btnMail_Click();
        }

        private void TextBlock_Tap_5(object sender, System.Windows.Input.GestureEventArgs e)
        {
            DoctorName = "Doctor 6";
            mail = string.Format("Need An Appointment\n Specialization:: {0} \n Doctor:: {1}", x, DoctorName);
            btnMail_Click();
        }

        async void btnMail_Click()
        {
            EmailComposeTask Myemail_Composetask = new EmailComposeTask();
            Myemail_Composetask.To = "bebi2527@live.in";
            Myemail_Composetask.Cc = "";
            Myemail_Composetask.Subject = "Appointment";
            Myemail_Composetask.Body = mail;
            Myemail_Composetask.Show();
        }
    }
}