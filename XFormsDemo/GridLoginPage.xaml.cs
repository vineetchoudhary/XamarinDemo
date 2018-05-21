using System;
using System.Collections.Generic;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace XFormsDemo
{
    public partial class GridLoginPage : ContentPage
    {
        public GridLoginPage()
        {
            InitializeComponent();
			Analytics.TrackEvent("Grid Login Page");
			Console.Write("Hello there!!");
        }

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			DisplayAlert("Error", "Invalid Operation.", "Ok");
			Analytics.TrackEvent("Alert Presented.", new Dictionary<string, string>{
				{"title", "Error"},
				{"message", "Invalid Operations."},
				{"cancel_button_title", "Ok"}
			});
		}
    }
}
