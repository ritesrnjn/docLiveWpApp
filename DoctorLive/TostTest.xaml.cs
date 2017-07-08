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
using Newtonsoft.Json;

namespace DoctorLive
{
    


    public partial class TostTest : PhoneApplicationPage
    {

        private MobileServiceCollection<notificationtable, notificationtable> itemsnotification;

        private IMobileServiceTable<notificationtable> notiTable = App.MobileService.GetTable<notificationtable>();
        public TostTest()
        {
            InitializeComponent();


        }

        private void bt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var myName = tb.Text;
                var id = App.MobileService.CurrentUser.UserId;
                var todoItem = new notificationtable { notificationstring = myName};

                
                InsertTodoItem(todoItem);

                //NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }
        private async void InsertTodoItem(notificationtable todoItem)
        {


            await notiTable.InsertAsync(todoItem);
            
        }
    }
}