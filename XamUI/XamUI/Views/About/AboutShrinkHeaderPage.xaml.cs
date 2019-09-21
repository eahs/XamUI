using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutShrinkHeaderPage : ContentPage
    {
        public int HeaderHeight { get; set; } = 100;

        public AboutShrinkHeaderPage()
        {
            InitializeComponent();

            this.BindingContext = this;
            MainScrollView.Scrolled += MainScrollView_Scrolled;
        }

        private void MainScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            double progress = Math.Min(e.ScrollY, HeaderHeight) / HeaderHeight;

            dbgLabel.Text = "" + e.ScrollY + " " + MainHeaderImage.Height;
            MainHeaderImage.Scale = 1 + progress;
            MainHeaderImage.Opacity = 1 - progress;
        }
    }
}