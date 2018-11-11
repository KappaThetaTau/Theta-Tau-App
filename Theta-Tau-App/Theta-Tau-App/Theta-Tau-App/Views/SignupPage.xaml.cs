using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.MobileServices;
using System.Text;
using System.Security.Cryptography;

namespace Theta_Tau_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPage : ContentPage
    {
        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static MobileServiceClient MobileService = new MobileServiceClient("https://testuserauth.azurewebsites.net");
        public SignupPage()
        {

            var displayText = new Label
            {
                Text = "Input information to login to your account",
            };
            var First = new Entry
            {
                Placeholder = "First Name",
            };

            var Last = new Entry
            {
                Placeholder = "Last Name",
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
                Text = "Login!"
            };

            signupButton.Clicked += async (object sender, EventArgs e) => {
                // add logic here, or in another function
                string hash = ComputeSha256Hash(password.Text);
                string first_name = First.Text;
                string last_name = Last.Text;
                //UserInfo item = new UserInfo { First = "Mike", Last = "Testy", init_pass = "test1", pass_hash = "holder", email = "mjshea3@illinois.edu" };
                //UserInfo query = MobileService.GetTable<UserInfo>().LookupAsync();
                //await MobileService.GetTable<UserInfo>().InsertAsync(item);
                //Navigation.PushAsync(new MainPage());
            };


            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = {
                    displayText, First, Last, password, signupButton
                }
            };
        }
    }
}


