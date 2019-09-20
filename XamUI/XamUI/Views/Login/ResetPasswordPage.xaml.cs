using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamUI.ViewModels.Login;

namespace XamUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResetPasswordPage : ContentPage
    {
        private ResetPasswordViewModel viewModel;

        public ResetPasswordPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ResetPasswordViewModel();
        }

    }
}