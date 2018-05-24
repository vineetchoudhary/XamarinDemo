using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsDemo.Navigations
{
    public partial class NavigationRootPage : ContentPage
    {
        public NavigationRootPage()
        {
            InitializeComponent();
			//NavigationPage.SetHasNavigationBar(this, false);
			NavigationPage.SetBackButtonTitle(this, String.Empty);
        }

		protected override bool OnBackButtonPressed()
		{
			DisplayAlert("Fuck", "We disabled it.", "LoL");
			return true;
		}
	}
}
