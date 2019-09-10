using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskManager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TenantSelection : ContentPage
    {
        TenantSelectionViewModel viewModel;

        public TenantSelection()
        {
            InitializeComponent();

            this.BindingContext = viewModel = new TenantSelectionViewModel();
        }
    }
}