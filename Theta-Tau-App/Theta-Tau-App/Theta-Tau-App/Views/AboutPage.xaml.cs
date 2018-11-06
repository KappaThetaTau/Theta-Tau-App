using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Theta_Tau_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            var title = new Label
            {
                Text = "About TT",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Maroon,
                FontAttributes = FontAttributes.Bold,
            };

            var description = new Label
            {
                Text = "Theta Tau is more than just a co-ed fraternity to us; it is a brotherhood. Here, we have built life-long relationships and learnt to navigate our school and career with the support of each other.",
                TextColor = Color.Gold,
                FontAttributes = FontAttributes.Italic,
            };


            Content = new StackLayout
            {
                BackgroundColor = Color.Black,
                Padding = 30,
                Spacing = 10,
                Children = { title, description }
            };

        }
    }
}