using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsDemo
{
    public partial class GridLoginPage : ContentPage
    {
        public GridLoginPage()
        {
            InitializeComponent();
        }

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			DisplayAlert("Error", "Invalid Operation.", "Ok");
		}
    }
}
