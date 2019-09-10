using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaskManager.Models;
using Xamarin.Forms;
using TaskManager.Enums;

namespace TaskManager.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _userName;
        public string UserName
        {
            get
            {
                return _userName;
            }

            set
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand LoginCommand { get; }

        public event EventHandler<LoginResponseArgs> LoginEvent;

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginCommandHandler());
        }

        private async Task LoginCommandHandler()
        {
            LoginResponseArgs args;
            if (string.IsNullOrEmpty(this.UserName) || string.IsNullOrEmpty(this.Password))
            {
                args = new LoginResponseArgs(ResponseCode.Failure, "Invalid values.");
            }
            else
            {
                if (this.UserName == "abc@gmail.com" && this.Password == "123")
                {
                    args = new LoginResponseArgs(ResponseCode.Success, "Login Success");
                }
                else
                {
                    args = new LoginResponseArgs(ResponseCode.Failure, "Invalid Username and Password");
                }
            }

            LoginEvent?.Invoke(this, args);
        }
    }
}
