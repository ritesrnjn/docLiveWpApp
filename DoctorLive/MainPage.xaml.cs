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
using Microsoft.Phone.Tasks;

namespace DoctorLive
{
    public class TodoItem
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "complete")]
        public bool Complete { get; set; }
    }

    //public class myProfile
    //{
    //    public string Id { get; set; }

    //    [JsonProperty(PropertyName = "name")]
    //    public string name { get; set; }

    //    [JsonProperty(PropertyName = "age")]
    //    public int age { get; set; }

    //    [JsonProperty(PropertyName = "sex")]
    //    public string sex { get; set; }

    //    [JsonProperty(PropertyName = "mobile")]
    //    public string mobile { get; set; }

    //    [JsonProperty(PropertyName = "email")]
    //    public string email { get; set; }

    //    [JsonProperty(PropertyName = "address")]
    //    public string address { get; set; }

    //    [JsonProperty(PropertyName = "pin")]
    //    public string pin { get; set; }

    //    [JsonProperty(PropertyName = "maritalstatus")]
    //    public string maritalstatus { get; set; }
    //}

    //public class Prescription
    //{
    //    [JsonProperty(PropertyName = "med1")]
    //    public string med1 { get; set; }

    //    [JsonProperty(PropertyName = "strength1")]
    //    public string strength1 { get; set; }

    //    [JsonProperty(PropertyName = "totalqty1")]
    //    public string totalqty1 { get; set; }

    //    [JsonProperty(PropertyName = "dose1")]
    //    public string dose1 { get; set; }

    //    [JsonProperty(PropertyName = "doseqty1")]
    //    public string doseqty1 { get; set; }



    //    [JsonProperty(PropertyName = "med2")]
    //    public string med2 { get; set; }

    //    [JsonProperty(PropertyName = "strength2")]
    //    public string strength2 { get; set; }

    //    [JsonProperty(PropertyName = "totalqty2")]
    //    public string totalqty2 { get; set; }

    //    [JsonProperty(PropertyName = "dose2")]
    //    public string dose2 { get; set; }

    //    [JsonProperty(PropertyName = "doseqty2")]
    //    public string doseqty2 { get; set; }



    //    [JsonProperty(PropertyName = "med3")]
    //    public string med3 { get; set; }

    //    [JsonProperty(PropertyName = "strength3")]
    //    public string strength3 { get; set; }

    //    [JsonProperty(PropertyName = "totalqt3")]
    //    public string totalqty3 { get; set; }

    //    [JsonProperty(PropertyName = "dose3")]
    //    public string dose3 { get; set; }

    //    [JsonProperty(PropertyName = "doseqty3")]
    //    public string doseqty3 { get; set; }



    //    [JsonProperty(PropertyName = "med4")]
    //    public string med4 { get; set; }

    //    [JsonProperty(PropertyName = "strength4")]
    //    public string strength4 { get; set; }

    //    [JsonProperty(PropertyName = "totalqty4")]
    //    public string totalqty4 { get; set; }

    //    [JsonProperty(PropertyName = "dose4")]
    //    public string dose4 { get; set; }

    //    [JsonProperty(PropertyName = "doseqty4")]
    //    public string doseqty4 { get; set; }



    //    [JsonProperty(PropertyName = "med5")]
    //    public string med5 { get; set; }

    //    [JsonProperty(PropertyName = "strength5")]
    //    public string strength5 { get; set; }

    //    [JsonProperty(PropertyName = "totalqty5")]
    //    public string totalqty5 { get; set; }

    //    [JsonProperty(PropertyName = "dose5")]
    //    public string dose5 { get; set; }

    //    [JsonProperty(PropertyName = "doseqty5")]
    //    public string doseqty5 { get; set; }


    //    [JsonProperty(PropertyName = "med6")]
    //    public string med6 { get; set; }

    //    [JsonProperty(PropertyName = "strength6")]
    //    public string strength6 { get; set; }

    //    [JsonProperty(PropertyName = "totalqty6")]
    //    public string totalqty6 { get; set; }

    //    [JsonProperty(PropertyName = "dose6")]
    //    public string dose6 { get; set; }

    //    [JsonProperty(PropertyName = "doseqty6")]
    //    public string doseqty6 { get; set; }



    //    [JsonProperty(PropertyName = "med7")]
    //    public string med7 { get; set; }

    //    [JsonProperty(PropertyName = "strength7")]
    //    public string strength7 { get; set; }

    //    [JsonProperty(PropertyName = "totalqty7")]
    //    public string totalqty7 { get; set; }

    //    [JsonProperty(PropertyName = "dose7")]
    //    public string dose7 { get; set; }

    //    [JsonProperty(PropertyName = "doseqty7")]
    //    public string doseqty7 { get; set; }



    //    [JsonProperty(PropertyName = "med8")]
    //    public string med8 { get; set; }

    //    [JsonProperty(PropertyName = "strength8")]
    //    public string strength8 { get; set; }

    //    [JsonProperty(PropertyName = "totalqty8")]
    //    public string totalqt8 { get; set; }

    //    [JsonProperty(PropertyName = "dose8")]
    //    public string dose8 { get; set; }

    //    [JsonProperty(PropertyName = "doseqty8")]
    //    public string doseqty8 { get; set; }



    //    [JsonProperty(PropertyName = "med9")]
    //    public string med9 { get; set; }

    //    [JsonProperty(PropertyName = "strength9")]
    //    public string strength9 { get; set; }

    //    [JsonProperty(PropertyName = "totalqty9")]
    //    public string totalqty9 { get; set; }

    //    [JsonProperty(PropertyName = "dose9")]
    //    public string dose9 { get; set; }

    //    [JsonProperty(PropertyName = "doseqty9")]
    //    public string doseqty9 { get; set; }


    //    [JsonProperty(PropertyName = "med10")]
    //    public string med10 { get; set; }

    //    [JsonProperty(PropertyName = "strength10")]
    //    public string strength10 { get; set; }

    //    [JsonProperty(PropertyName = "totalqty10")]
    //    public string totalqty10 { get; set; }

    //    [JsonProperty(PropertyName = "dose10")]
    //    public string dose10 { get; set; }

    //    [JsonProperty(PropertyName = "doseqty10")]
    //    public string doseqty10 { get; set; }



    //    [JsonProperty(PropertyName = "name")]
    //    public string name { get; set; }

    //    [JsonProperty(PropertyName = "phoneno")]
    //    public string phoneno { get; set; }


    //    [JsonProperty(PropertyName = "test1")]
    //    public string test1 { get; set; }

    //    [JsonProperty(PropertyName = "test2")]
    //    public string test2 { get; set; }

    //    [JsonProperty(PropertyName = "test3")]
    //    public string test3 { get; set; }

    //    [JsonProperty(PropertyName = "test4")]
    //    public string test4 { get; set; }

    //    [JsonProperty(PropertyName = "test5")]
    //    public string test5 { get; set; }

    //    [JsonProperty(PropertyName = "test6")]
    //    public string test6 { get; set; }


    //}

    public partial class MainPage : PhoneApplicationPage
    {
        // MobileServiceCollectionView implements ICollectionView (useful for databinding to lists) and 
        // is integrated with your Mobile Service to make it easy to bind your data to the ListView
        private MobileServiceCollection<TodoItem, TodoItem> items;

        private IMobileServiceTable<TodoItem> todoTable = App.MobileService.GetTable<TodoItem>();

        //mobileServiceCollectionView for Profile table
        //private MobileServiceCollection<myProfile, myProfile> items1;
        //private IMobileServiceTable<myProfile> profileTable = App.MobileService.GetTable<myProfile>();
        
        ////mobileServiceCollectionView for Prescription table
        //private MobileServiceCollection<Prescription, Prescription> items2;
        //private IMobileServiceTable<Prescription> PrescriptionTable = App.MobileService.GetTable<Prescription>();


        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;

            BuildLocalizedApplicationBar();

            
        }

        private  void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            
                Storyboard1.Begin();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (App.MobileService.CurrentUser != null && App.MobileService.CurrentUser.UserId != null)
                App.MobileService.Logout();

            NavigationService.Navigate(new Uri("/LoginPage.xaml", UriKind.Relative));
        }


        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();

            ApplicationBar.Mode = ApplicationBarMode.Default;
            ApplicationBar.Opacity = 1.0;
            ApplicationBar.IsVisible = true;
            ApplicationBar.IsMenuEnabled = true;

            ApplicationBarIconButton button1 = new ApplicationBarIconButton();
            button1.IconUri = new Uri("/Images/YourImage.png", UriKind.Relative);
            button1.Text = "button 1";
            ApplicationBar.Buttons.Add(button1);
            button1.Click += new EventHandler(button1_Click);

            ApplicationBarMenuItem menuItem1 = new ApplicationBarMenuItem();
            menuItem1.Text = "Edit My Profile";
            ApplicationBar.MenuItems.Add(menuItem1);
            menuItem1.Click += new EventHandler(menuItem1_Click);
            

            //ApplicationBarMenuItem menuItem2 = new ApplicationBarMenuItem();
            //menuItem1.Text = "Request a Prescription";
            //ApplicationBar.MenuItems.Add(menuItem2);
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu item 1 works!");
            //Do work for your application here.
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 1 works!");
            //Do work for your application here.
        }


    }
}