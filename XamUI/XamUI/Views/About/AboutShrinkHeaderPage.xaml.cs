using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamUI.ViewModels.About;

namespace XamUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutShrinkHeaderPage : ContentPage
    {
        private AboutPageViewModel viewModel;

        public AboutShrinkHeaderPage()
        {
            InitializeComponent();

            this.BindingContext = viewModel = new AboutPageViewModel();
            MainScrollView.Scrolled += MainScrollView_Scrolled;
        }

        private void MainScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            double progress = Math.Min(e.ScrollY, viewModel.HeaderBounds.Height) / viewModel.HeaderBounds.Height;

            MainHeaderImage.Scale = 1 + progress;
            MainHeaderImage.Opacity = 1 - progress;
        }
    }
}