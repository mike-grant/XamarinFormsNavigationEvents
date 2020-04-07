using System;
using Xamarin.Forms;
using XamarinFormsNavigationEvents.Services;
using XamarinFormsNavigationEvents.Views;

namespace XamarinFormsNavigationEvents
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();

            Application.Current.PageAppearing += OnPageAppearing;
        }

        private void OnPageAppearing(object sender, Page e)
        {
            if (e is ContentPage)
            {
                Console.WriteLine($"Navigated to {e.GetType()}");
            }

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
