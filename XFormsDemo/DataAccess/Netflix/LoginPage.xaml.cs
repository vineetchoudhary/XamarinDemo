using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsDemo.DataAccess.Netflix
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void Handle_Password_UnFocused(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            loginAnimation.Animation = "wolf_watch_bottom.json";
        }

        void Handle_Password_Focused(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            loginAnimation.Animation = "wolf_peek.json";
        }

        void Handle_Skip_Login_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
