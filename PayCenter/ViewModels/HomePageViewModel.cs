using System;
using System.Collections.Generic;
using System.Windows.Input;
using PayCenter.Models;
using PayCenter.Views;
using Xamarin.Forms;

namespace PayCenter.ViewModels
{
    public class HomePageViewModel
    {
        public HomePageViewModel()
        {
            Users = MockData.Users;
            Activities = MockData.RecentActivities;

            GoToActivityCommand = new Command(GotoActivityPage);
            GotoBalanceCommannd = new Command(GotoBalancePage);
        }

        #region Properties
        public List<User> Users { get; set; }
        public List<Activity> Activities { get; set; }
        public ICommand GoToActivityCommand { get; private set; }
        public ICommand GotoBalanceCommannd { get; set; }
        #endregion

        #region Methods
        async void GotoActivityPage()
        {
            var mainPage = Application.Current.MainPage as NavigationPage;
            await mainPage.PushAsync(new ActivityPage());
        }

        async void GotoBalancePage()
        {
            var mainPage = Application.Current.MainPage as NavigationPage;
            await mainPage.PushAsync(new BalancePage());
        }
        #endregion
    }
}
