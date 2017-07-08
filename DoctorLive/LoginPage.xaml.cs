using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using DoctorLive.Resources;

namespace DoctorLive
{

    public class myProfile
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }




        [JsonProperty(PropertyName = "age")]
        public int age { get; set; }

        [JsonProperty(PropertyName = "sex")]
        public string sex { get; set; }

        [JsonProperty(PropertyName = "mobile")]
        public string mobile { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string email { get; set; }

        [JsonProperty(PropertyName = "address")]
        public string address { get; set; }

        [JsonProperty(PropertyName = "pin")]
        public string pin { get; set; }

        [JsonProperty(PropertyName = "maritalstatus")]
        public string maritalstatus { get; set; }
    }

    public class Prescription
    {
        public string Id { get; set; }


        [JsonProperty(PropertyName = "med1")]
        public string med1 { get; set; }

        [JsonProperty(PropertyName = "strength1")]
        public string strength1 { get; set; }

        [JsonProperty(PropertyName = "totalqty1")]
        public string totalqty1 { get; set; }

        [JsonProperty(PropertyName = "dose1")]
        public string dose1 { get; set; }

        [JsonProperty(PropertyName = "doesqty1")]
        public string doseqty1 { get; set; }



        [JsonProperty(PropertyName = "med2")]
        public string med2 { get; set; }

        [JsonProperty(PropertyName = "strength2")]
        public string strength2 { get; set; }

        [JsonProperty(PropertyName = "totalqty2")]
        public string totalqty2 { get; set; }

        [JsonProperty(PropertyName = "dose2")]
        public string dose2 { get; set; }

        [JsonProperty(PropertyName = "doesqty2")]
        public string doseqty2 { get; set; }



        [JsonProperty(PropertyName = "med3")]
        public string med3 { get; set; }

        [JsonProperty(PropertyName = "strength3")]
        public string strength3 { get; set; }

        [JsonProperty(PropertyName = "totalqty3")]
        public string totalqty3 { get; set; }

        [JsonProperty(PropertyName = "dose3")]
        public string dose3 { get; set; }

        [JsonProperty(PropertyName = "doesqty3")]
        public string doseqty3 { get; set; }



        [JsonProperty(PropertyName = "med4")]
        public string med4 { get; set; }

        [JsonProperty(PropertyName = "strength4")]
        public string strength4 { get; set; }

        [JsonProperty(PropertyName = "totalqty4")]
        public string totalqty4 { get; set; }

        [JsonProperty(PropertyName = "dose4")]
        public string dose4 { get; set; }

        [JsonProperty(PropertyName = "doesqty4")]
        public string doseqty4 { get; set; }



        [JsonProperty(PropertyName = "med5")]
        public string med5 { get; set; }

        [JsonProperty(PropertyName = "strength5")]
        public string strength5 { get; set; }

        [JsonProperty(PropertyName = "totalqty5")]
        public string totalqty5 { get; set; }

        [JsonProperty(PropertyName = "dose5")]
        public string dose5 { get; set; }

        [JsonProperty(PropertyName = "doesqty5")]
        public string doseqty5 { get; set; }


        [JsonProperty(PropertyName = "med6")]
        public string med6 { get; set; }

        [JsonProperty(PropertyName = "strength6")]
        public string strength6 { get; set; }

        [JsonProperty(PropertyName = "totalqty6")]
        public string totalqty6 { get; set; }

        [JsonProperty(PropertyName = "dose6")]
        public string dose6 { get; set; }

        [JsonProperty(PropertyName = "doesqty6")]
        public string doseqty6 { get; set; }



        [JsonProperty(PropertyName = "med7")]
        public string med7 { get; set; }

        [JsonProperty(PropertyName = "strength7")]
        public string strength7 { get; set; }

        [JsonProperty(PropertyName = "totalqty7")]
        public string totalqty7 { get; set; }

        [JsonProperty(PropertyName = "dose7")]
        public string dose7 { get; set; }

        [JsonProperty(PropertyName = "doesqty7")]
        public string doseqty7 { get; set; }



        [JsonProperty(PropertyName = "med8")]
        public string med8 { get; set; }

        [JsonProperty(PropertyName = "strength8")]
        public string strength8 { get; set; }

        [JsonProperty(PropertyName = "totalqty8")]
        public string totalqt8 { get; set; }

        [JsonProperty(PropertyName = "dose8")]
        public string dose8 { get; set; }

        [JsonProperty(PropertyName = "doesqty8")]
        public string doseqty8 { get; set; }



        [JsonProperty(PropertyName = "med9")]
        public string med9 { get; set; }

        [JsonProperty(PropertyName = "strength9")]
        public string strength9 { get; set; }

        [JsonProperty(PropertyName = "totalqty9")]
        public string totalqty9 { get; set; }

        [JsonProperty(PropertyName = "dose9")]
        public string dose9 { get; set; }

        [JsonProperty(PropertyName = "doesqty9")]
        public string doseqty9 { get; set; }


        [JsonProperty(PropertyName = "med10")]
        public string med10 { get; set; }

        [JsonProperty(PropertyName = "strength10")]
        public string strength10 { get; set; }

        [JsonProperty(PropertyName = "totalqty10")]
        public string totalqty10 { get; set; }

        [JsonProperty(PropertyName = "dose10")]
        public string dose10 { get; set; }

        [JsonProperty(PropertyName = "doesqty10")]
        public string doseqty10 { get; set; }



        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "phoneno")]
        public string phoneno { get; set; }


        [JsonProperty(PropertyName = "test1")]
        public string test1 { get; set; }

        [JsonProperty(PropertyName = "test2")]
        public string test2 { get; set; }

        [JsonProperty(PropertyName = "test3")]
        public string test3 { get; set; }

        [JsonProperty(PropertyName = "test4")]
        public string test4 { get; set; }

        [JsonProperty(PropertyName = "test5")]
        public string test5 { get; set; }

        [JsonProperty(PropertyName = "test6")]
        public string test6 { get; set; }

        [JsonProperty(PropertyName = "t1")]
        public string t1 { get; set; }

        [JsonProperty(PropertyName = "t2")]
        public string t2 { get; set; }

        [JsonProperty(PropertyName = "t3")]
        public string t3 { get; set; }

        [JsonProperty(PropertyName = "t4")]
        public string t4 { get; set; }

        [JsonProperty(PropertyName = "t5")]
        public string t5 { get; set; }

        [JsonProperty(PropertyName = "t6")]
        public string t6 { get; set; }



    }

    public class Casesheet
    {

        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "age")]
        public int age { get; set; }

        [JsonProperty(PropertyName = "sex")]
        public string sex { get; set; }

        [JsonProperty(PropertyName = "admission_date")]
        public DateTime admission_date { get; set; }

        [JsonProperty(PropertyName = "complaints_history")]
        public string complaints_history { get; set; }

        [JsonProperty(PropertyName = "vitals_bp")]
        public string vitals_bp { get; set; }

        [JsonProperty(PropertyName = "vitals_sugar")]
        public string vitals_sugar { get; set; }

        [JsonProperty(PropertyName = "vitals_temp")]
        public int vitals_temp { get; set; }

        [JsonProperty(PropertyName = "presonal_history")]
        public string personal_history { get; set; }

        [JsonProperty(PropertyName = "examination_cardio")]
        public string examination_cardio { get; set; }

        [JsonProperty(PropertyName = "examination_respiratory")]
        public string examination_respiratory { get; set; }

        [JsonProperty(PropertyName = "examination_abdomen")]
        public string examination_abdomen { get; set; }

        [JsonProperty(PropertyName = "diagnosis")]
        public string diagnosis { get; set; }

        [JsonProperty(PropertyName = "treatment_advised")]
        public string treatment_advised { get; set; }

    }

    public class notificationtable
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "notificationstring")]
        public string notificationstring { get; set; }


    }

    public partial class Page2 : PhoneApplicationPage
    {

        private MobileServiceCollection<myProfile, myProfile> items1;
        private IMobileServiceTable<myProfile> profileTable = App.MobileService.GetTable<myProfile>();

        //mobileServiceCollectionView for Prescription table
        private MobileServiceCollection<Prescription, Prescription> items2;
        private IMobileServiceTable<Prescription> PrescriptionTable = App.MobileService.GetTable<Prescription>();


        private MobileServiceCollection<notificationtable, notificationtable> itemsnotification;
        private IMobileServiceTable<notificationtable> notiTable = App.MobileService.GetTable<notificationtable>();


        private MobileServiceCollection<Casesheet, Casesheet> itemcasesheet;
        private IMobileServiceTable<Casesheet> caseTable = App.MobileService.GetTable<Casesheet>();

        public Page2()
        {
            InitializeComponent();
        }

        private async void fbButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ////TODO: Call LoginAsync: 
                await App.MobileService.LoginAsync(MobileServiceAuthenticationProvider.Facebook);
                //string message = string.Format("you are logged in with {0}", App.MobileService.CurrentUser.UserId);

           // NavigationService.Navigate(new Uri("BasicDetails.xaml", UriKind.Relative));
                
                //MessageBox.Show(message);
                
                
              RefreshTodoItems();

                //txtStatus.Text = string.Format("Logged in with: {0}", App.MobileService.CurrentUser.UserId);
            }
            catch (InvalidOperationException)
            {
                //txtStatus.Text = string.Format("Error Occured: \n {0}", iopEx.ToString());

                string message = string.Format("OOPS !! Something Went Wrong..!! Please try again");
            }
        }

        private async void RefreshTodoItems()
        {
            // The query excludes completed TodoItems
            try
            {

                var names = await profileTable
                    //.Where(t => t.name == "bedant")
                   .Select(t => t.name)
                        .ToEnumerableAsync();
                var myName = names.FirstOrDefault();

                if (myName != null)
                {
                    NavigationService.Navigate(new Uri("/menuPage.xaml", UriKind.Relative));
                }
                else
                {
                    NavigationService.Navigate(new Uri("/BasicDetails.xaml", UriKind.Relative));
                }

                //string a = myName;
                //myname.Text = a;
            }
            catch (MobileServiceInvalidOperationException e)
            {
                MessageBox.Show(e.Message, "Error loading items", MessageBoxButton.OK);
            }
        }

        private async void googleButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ////TODO: Call LoginAsync: 
                await App.MobileService.LoginAsync(MobileServiceAuthenticationProvider.Google);
             //   NavigationService.Navigate(new Uri("/Page3.xaml", UriKind.Relative));
                RefreshTodoItems();

                //string message = string.Format("you are logged in with {0}", App.MobileService.CurrentUser.UserId);
                //MessageBox.Show(message);



                //txtStatus.Text = string.Format("Logged in with: {0}", App.MobileService.CurrentUser.UserId);
            }
            catch (InvalidOperationException)
            {
                //txtStatus.Text = string.Format("Error Occured: \n {0}", iopEx.ToString());

                string message = string.Format("OOPS !! Something Went Wrong..!! Please try again");
            }
        }

        private async void twitterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ////TODO: Call LoginAsync: 
                await App.MobileService.LoginAsync(MobileServiceAuthenticationProvider.Twitter);
                //string message = string.Format("you are logged in with {0}", App.MobileService.CurrentUser.UserId);
                //MessageBox.Show(message);
                RefreshTodoItems();
                //txtStatus.Text = string.Format("Logged in with: {0}", App.MobileService.CurrentUser.UserId);
            }
            catch (InvalidOperationException)
            {
                //txtStatus.Text = string.Format("Error Occured: \n {0}", iopEx.ToString());

                string message = string.Format("OOPS !! Something Went Wrong..!! Please try again");
            }
        }

        private async void msButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ////TODO: Call LoginAsync: 
                await App.MobileService.LoginAsync(MobileServiceAuthenticationProvider.MicrosoftAccount);

                RefreshTodoItems();
                //string message = string.Format("you are logged in with {0}", App.MobileService.CurrentUser.UserId);
                //MessageBox.Show(message);
                //txtStatus.Text = string.Format("Logged in with: {0}", App.MobileService.CurrentUser.UserId);
            }
            catch (InvalidOperationException)
            {
                //txtStatus.Text = string.Format("Error Occured: \n {0}", iopEx.ToString());

                string message = string.Format("OOPS !! Something Went Wrong..!! Please try again");
            }
        }



    }
}