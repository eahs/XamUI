
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamUI.ViewModels.Login;

namespace XamUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotPasswordPage : ContentPage
    {
        private ForgotPasswordViewModel viewModel;

        public ForgotPasswordPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ForgotPasswordViewModel();
        }

    }
}