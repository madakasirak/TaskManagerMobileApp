﻿using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace TaskManager.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://hostanalytics.com/")));
        }

        public ICommand OpenWebCommand { get; }
    }
}