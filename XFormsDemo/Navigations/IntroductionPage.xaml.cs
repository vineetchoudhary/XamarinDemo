using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsDemo.Navigations
{
	public partial class IntroductionPage : NavigationRootPage
    {
        public IntroductionPage()
        {
            InitializeComponent();
			//NavigationPage.SetBackButtonTitle(this, "Hello");
        }

		async void Handle_Next_Button_Clicked(object sender, System.EventArgs e)
		{
			//await Navigation.PushAsync(new WelcomePage());

			await Navigation.PushModalAsync(new WelcomePage());
		}
       
	}
}
