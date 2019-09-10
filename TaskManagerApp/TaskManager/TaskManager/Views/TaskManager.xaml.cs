using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Constants;
using TaskManager.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskManager : ContentPage
    {
        TaskManagerViewModel viewModel;

        public TaskManager()
        {
            InitializeComponent();

            BindingContext = viewModel = new TaskManagerViewModel();
        }

        private void BtnLogout_Clicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            MessagingCenter.Send<object>(this, AppConstants.EVENT_LAUNCH_LOGIN_PAGE);
        }
    }
}