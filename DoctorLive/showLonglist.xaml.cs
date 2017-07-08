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
    public partial class showLonglist : PhoneApplicationPage
    {
        private MobileServiceCollection<Prescription, Prescription> items2;
        private IMobileServiceTable<Prescription> PrescriptionTable = App.MobileService.GetTable<Prescription>();
        public showLonglist()
        {

             
            InitializeComponent();
            this.Loaded += showPrescriptionPageLoaded;
        }

        async void showPrescriptionPageLoaded(object sender, RoutedEventArgs e)
        {
            RefreshTodoItems();
        }
        private async void RefreshTodoItems()
        {
            // This code refreshes the entries in the list view be querying the TodoItems table.
            // The query excludes completed TodoItems
            try
            {
                items2 = await PrescriptionTable
                    //.Where(todoItem => todoItem.Complete == false)
                    .ToCollectionAsync();
            }
            catch (MobileServiceInvalidOperationException e)
            {
                MessageBox.Show(e.Message, "Error loading items", MessageBoxButton.OK);
            }

            ListItems.ItemsSource = items2;
        }

        private void CheckBoxComplete_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            string prescriptionName = tb.Text;
            MessageBox.Show(prescriptionName);

        }
    }
}