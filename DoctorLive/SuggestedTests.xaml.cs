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
    public partial class Page3 : PhoneApplicationPage
    {

        private MobileServiceCollection<Prescription, Prescription> items2;
        private IMobileServiceTable<Prescription> PrescriptionTable = App.MobileService.GetTable<Prescription>();
        public Page3()


        {
            InitializeComponent();
            this.Loaded += thisPageLoaded; 
        }

        async void thisPageLoaded(object sender, RoutedEventArgs e)
        {
            try { 
            var test1 = await PrescriptionTable
                     //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                       .Select(t => t.test1)
                            .ToEnumerableAsync();
            var test11 = test1.FirstOrDefault();
            tt1.Text = test11;


            var test2 = await PrescriptionTable
                //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.test2)
                        .ToEnumerableAsync();
            var test22 = test2.FirstOrDefault();
            tt2.Text = test22;

            var test3 = await PrescriptionTable
                //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.test3)
                        .ToEnumerableAsync();
            var test33 = test3.FirstOrDefault();
            tt3.Text = test33;

            var test4 = await PrescriptionTable
                //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.test4)
                        .ToEnumerableAsync();
            var test44 = test4.FirstOrDefault();
            tt4.Text = test44;

            var test5 = await PrescriptionTable
                //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.test5)
                        .ToEnumerableAsync();
            var test55 = test5.FirstOrDefault();
            tt5.Text = test55;

            var test6 = await PrescriptionTable
                //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.test6)
                        .ToEnumerableAsync();
            var test66 = test6.FirstOrDefault();
            tt6.Text = test66;



            }
            catch
            {
                MessageBox.Show("connectivity Problem");
            }
        }

        private async void InsertTodoItem(Prescription todoprescription)
        {


            

            await PrescriptionTable.InsertAsync(todoprescription);

            //items.Add(todoItem);



        }

        private async void cb1_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                

                var todoprescription = new Prescription { t1 = "done" };
                InsertTodoItem(todoprescription);

                var test6 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.t1)
                        .ToEnumerableAsync();
                var test66 = test6.FirstOrDefault();
                tb1.Text = test66;

            }
            catch
            {
                MessageBox.Show("Invalid input");
            }

            
        }

        private async void cb2_Checked(object sender, RoutedEventArgs e)
        {
            try
            {


                var todoprescription = new Prescription { t2 = "done" };
                InsertTodoItem(todoprescription);

                var test6 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.t2)
                        .ToEnumerableAsync();
                var test66 = test6.FirstOrDefault();
                tb2.Text = test66;

            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
            
        }

        private async void cb3_Checked(object sender, RoutedEventArgs e)
        {
            try
            {


                var todoprescription = new Prescription { t3 = "done" };
                InsertTodoItem(todoprescription);

                var test6 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.t3)
                        .ToEnumerableAsync();
                var test66 = test6.FirstOrDefault();
                tb3.Text = test66;

            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private async void cb4_Checked(object sender, RoutedEventArgs e)
        {
            try{
            var todoprescription = new Prescription { t4 = "done" };
                InsertTodoItem(todoprescription);

                var test6 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.t4)
                        .ToEnumerableAsync();
                var test66 = test6.FirstOrDefault();
                tb4.Text = test66;

            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private async void cb5_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                var todoprescription = new Prescription { t5 = "done" };
                InsertTodoItem(todoprescription);

                var test6 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.t5)
                        .ToEnumerableAsync();
                var test66 = test6.FirstOrDefault();
                tb5.Text = test66;

            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private async void cb6_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                var todoprescription = new Prescription { t6 = "done" };
                InsertTodoItem(todoprescription);

                var test6 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.t6)
                        .ToEnumerableAsync();
                var test66 = test6.FirstOrDefault();
                tb6.Text = test66;

            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private async void cb6_Unchecked(object sender, RoutedEventArgs e)
        {
            try
            {
                var todoprescription = new Prescription { t6 = " " };
                InsertTodoItem(todoprescription);

                var test6 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.t6)
                        .ToEnumerableAsync();
                var test66 = test6.FirstOrDefault();
                tb6.Text = test66;

            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private async void cb5_Unchecked(object sender, RoutedEventArgs e)
        {
            try
            {
                var todoprescription = new Prescription { t5 = " " };
                InsertTodoItem(todoprescription);

                var test6 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.t5)
                        .ToEnumerableAsync();
                var test66 = test6.FirstOrDefault();
                tb5.Text = test66;

            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private async void cb4_Unchecked(object sender, RoutedEventArgs e)
        {
            try
            {
                var todoprescription = new Prescription { t4 = " " };
                InsertTodoItem(todoprescription);

                var test6 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.t4)
                        .ToEnumerableAsync();
                var test66 = test6.FirstOrDefault();
                tb4.Text = test66;

            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private async void cb3_Unchecked(object sender, RoutedEventArgs e)
        {
            try
            {


                var todoprescription = new Prescription { t3 = " " };
                InsertTodoItem(todoprescription);

                var test6 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.t3)
                        .ToEnumerableAsync();
                var test66 = test6.FirstOrDefault();
                tb3.Text = test66;

            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private async void cb2_Unchecked(object sender, RoutedEventArgs e)
        {
            try
            {


                var todoprescription = new Prescription { t2 = " " };
                InsertTodoItem(todoprescription);

                var test6 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.t2)
                        .ToEnumerableAsync();
                var test66 = test6.FirstOrDefault();
                tb2.Text = test66;

            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private async void cb1_Unchecked(object sender, RoutedEventArgs e)
        {
            try
            {


                var todoprescription = new Prescription { t1 = " " };
                InsertTodoItem(todoprescription);

                var test6 = await PrescriptionTable
                    //.Where(t => t.UserId == App.MobileService.CurrentUser.UserId)
                   .Select(t => t.t1)
                        .ToEnumerableAsync();
                var test66 = test6.FirstOrDefault();
                tb1.Text = test66;

            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}