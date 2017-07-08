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

    public class Contact
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }




        [JsonProperty(PropertyName = "Address")]
        public int Address { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string city { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string state { get; set; }

        [JsonProperty(PropertyName = "zip")]
        public string zip { get; set; }

        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

    }
    public partial class TestPage : PhoneApplicationPage
    {

        private MobileServiceCollection<Contact, Contact> items1;
        private IMobileServiceTable<Contact> profileTable = App.MobileService.GetTable<Contact>();
        public TestPage()
        {
            InitializeComponent();
        }
         private async void InsertTodoItem(Contact todoprescription)
        {


            
            

            await profileTable.InsertAsync(todoprescription);

            //items.Add(todoItem);



        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var myName = name.Text;
               

                var todoprescription = new Contact { Name = myName};

               
                InsertTodoItem(todoprescription);

                //NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }

           
        }
       



    }
}