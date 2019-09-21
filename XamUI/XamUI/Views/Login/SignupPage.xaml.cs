using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamUI.ViewModels.Login;

namespace XamUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPage : ContentPage
    {
        private SignupPageViewModel viewModel;

        public SignupPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new SignupPageViewModel();
        }

    }
}