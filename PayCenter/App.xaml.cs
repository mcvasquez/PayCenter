using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using PayCenter.Helpers;
using PayCenter.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PayCenter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start($"ios={Secrets.AppCenter_iOS_Secret};" +
                  "uwp={Your UWP App secret here};" +
                  $"android={Secrets.AppCenter_Android_Secret}",
                  typeof(Analytics), typeof(Crashes));
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
