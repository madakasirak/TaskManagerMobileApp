using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Constants;
using TaskManager.Enums;
using TaskManager.Models;
using TaskManager.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        NavigationPage RootPage { get => Application.Current.MainPage as NavigationPage; }

        LoginViewModel viewModel;

        public Login()
        {
            InitializeComponent();

            this.BindingContext = viewModel = new LoginViewModel();

            viewModel.LoginEvent -= LoginEventHandler;
            viewModel.LoginEvent += LoginEventHandler;
        }

        private async void LoginEventHandler(object sender, LoginResponseArgs e)
        {
            if (e.ResponseCode == ResponseCode.Failure)
            {
                await DisplayAlert(e.Message, "Please Enter Username and Password", "OK");
            }
            else
            {
                await DisplayAlert(e.Message, String.Empty, "OK");

                MessagingCenter.Send<object>(this, AppConstants.EVENT_LAUNCH_MAIN_PAGE);
            }
        }
    }
}