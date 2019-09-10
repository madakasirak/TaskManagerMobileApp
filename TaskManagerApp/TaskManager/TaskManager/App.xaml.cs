using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TaskManager.Services;
using TaskManager.Views;
using TaskManager.Constants;

namespace TaskManager
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            MainPage = new Login();

            MessagingCenter.Subscribe<object>(this, AppConstants.EVENT_LAUNCH_LOGIN_PAGE, SetLoginPageAsRootPage);
            MessagingCenter.Subscribe<object>(this, AppConstants.EVENT_LAUNCH_MAIN_PAGE, SetMainPageAsRootPage);
        }

        private void SetLoginPageAsRootPage(object sender)
        {
            MainPage = new Login();
        }

        private void SetMainPageAsRootPage(object sender)
        {
            MainPage = new TaskManager.Views.TaskManager();
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
