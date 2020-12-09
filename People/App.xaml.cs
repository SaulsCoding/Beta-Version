using People.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Xamarin.Forms;

namespace People
{
    public partial class App : Application
    {
        string dbPath => FileAccessHelper.GetLocalFilePath("order.db3");

        public static OrderRepository OrderRepo { get; private set; }
        public App()
        {
            InitializeComponent();

            OrderRepo = new OrderRepository(dbPath);
            //MainPage = new MainPage(new OrderPage());



            var navPage = new NavigationPage(new OrderPage());
            navPage.BarBackgroundColor = Color.FromHex("000000");

            MainPage = navPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
