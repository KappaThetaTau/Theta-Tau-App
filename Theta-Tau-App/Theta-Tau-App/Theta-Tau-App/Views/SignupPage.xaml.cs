using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Theta_Tau_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            var displayText = new Label
            {
                Text = "Input information to create your account",
            };
            var name = new Entry
            {
                Placeholder = "Name",
            };
            var roleNumber = new Entry
            {
                Placeholder = "Role Number",
            };
            var username = new Entry
            {
                Placeholder = "Username",
            };
            var email = new Entry
            {
                Placeholder = "Email",
            };
            var phone = new Entry
            {
                Placeholder = "Phone Number",
            };
            var password = new Entry
            {
                Placeholder = "Password",
                IsPassword = true,
            };
            var signupButton = new Button
            {
                Text = "Create My Account!"
            };

            signupButton.Clicked += (object sender, EventArgs e) => {
                // add logic here
            };

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = {
                    displayText, name, email, password, signupButton
                }
            };
        }
    }
}

