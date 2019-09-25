
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamUI.ViewModels.Login;

namespace XamUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private LoginPageViewModel viewModel;

        public LoginPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new LoginPageViewModel();
        }

    }
}