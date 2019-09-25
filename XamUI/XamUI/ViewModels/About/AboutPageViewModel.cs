using Xamarin.Forms;

namespace XamUI.ViewModels.About
{
    public class AboutPageViewModel : BaseViewModel
    {
        // These two properties are available if you use the shrinking header about page
        public Xamarin.Forms.Rectangle HeaderBounds { get; } = new Rectangle(0, 0, 1, 100);  // Only modify the last parameter (height)
        public Xamarin.Forms.Color HeaderBackgroundColor { get; set; } = Xamarin.Forms.Color.Blue;

        public AboutPageViewModel()
        {
        }

        public string AboutVersion { get; } = "Version 1.0";
        public string AboutTitle { get; } = "Xamarin UI";
        public string AboutDescription { get; } = "Cupcake ipsum dolor. Sit amet <strong>dessert donut</strong> jelly-o liquorice powder. Cookie icing marzipan marshmallow ice cream. Liquorice dragée toffee apple pie lollipop pie caramels. Bonbon chocolate bar sugar plum chocolate bar cotton candy cotton candy pie marzipan.";

    }
}
