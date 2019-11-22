using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using PayCenter.Models;
using Xamarin.Forms;

namespace PayCenter.ViewModels
{
    public class ActivityPageViewModel : INotifyPropertyChanged
    {
        public ActivityPageViewModel()
        {
            Title = "Activity";
            Activities = MockData.Activities;
            RefreshCommand = new Command(Refresh);
        }

        #region Properties
        public string Title { get; set; }
        public List<Activity> Activities { get; set; }
        public ICommand RefreshCommand { get; private set; }

        bool isRefreshing;
        public bool IsRefreshing
        {
            get => isRefreshing;
            set
            {
                if (value != isRefreshing)
                {
                    isRefreshing = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsRefreshing"));
                }
            }
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods
        async void Refresh()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            IsRefreshing = !IsRefreshing;
        }
        #endregion
    }
}
