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
        public static bool IsUserLoggedIn { get; set; }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            MainPage = new Login();

            MessagingCenter.Subscribe<object>(this, AppConstants.EVENT_LAUNCH_LOGIN_PAGE, SetLoginPageAsRootPage);
            MessagingCenter.Subscribe<object>(this, AppConstants.EVENT_LAUNCH_MAIN_PAGE, SetTaskManagerPageAsRootPage);
            MessagingCenter.Subscribe<object>(this, AppConstants.EVENT_LAUNCH_TENANT_SELECTION_PAGE, SetTenantSelectionPageAsRootPage);
        }

        private void SetTenantSelectionPageAsRootPage(object obj)
        {
            MainPage = new TaskManager.Views.TenantSelection();
        }

        private void SetLoginPageAsRootPage(object sender)
        {
            MainPage = new TaskManager.Views.Login();
        }

        private void SetTaskManagerPageAsRootPage(object sender)
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
