using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsDemo.AlertActionSheet
{
    public partial class AlertActionSheetPage : ContentPage
    {

		public AlertActionSheetPage()
        {
            InitializeComponent();
        }

		async void Handle_Alert_Clicked(object sender, System.EventArgs e)
		{
			var accept = await DisplayAlert("Hello there!!!", "Are you sure?", "Yes", "No");
			if (accept)
			{
				await DisplayAlert("Thank You!!", "", "OK");
			}
		}

		async void Handle_ActionSheet_Clicked(object sender, System.EventArgs e)
		{
			var response = await DisplayActionSheet("Hello there!!!", "Cancel", "Delete", "Message", "Call", "Block");
			await DisplayAlert("Response", response, "OK");
		}
    }
}
