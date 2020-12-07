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

        public static OrderRepository PersonRepo { get; private set; }
        public App()
        {
            InitializeComponent();

            PersonRepo = new OrderRepository(dbPath);
            //MainPage = new MainPage(new OrderPage());
            var orders = new NavigationPage(new OrderPage());
            //peoples.BarBackgroundColor = Color.FromHex("000000");

            MainPage = orders;
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
