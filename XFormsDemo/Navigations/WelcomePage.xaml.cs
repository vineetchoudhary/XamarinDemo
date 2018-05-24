using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsDemo.Navigations
{
	public partial class WelcomePage : NavigationRootPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

		async void Handle_Back_Button_Clicked(object sender, System.EventArgs e)
		{
			//await Navigation.PopAsync();  
			await Navigation.PopModalAsync();
		}
        
    }
}
