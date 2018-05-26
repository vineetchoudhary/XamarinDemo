using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace XFormsDemo.Forms
{
    public partial class TableViewFormPage : ContentPage
    {
        public TableViewFormPage()
        {
            InitializeComponent();
        }

		async void Handle_OnChanged(object sender, Xamarin.Forms.ToggledEventArgs e)
		{
			if (e.Value) 
			{
				Loader.IsVisible = true;
				await Task.Delay(5000);
				Loader.IsVisible = false;
            }
		}

		void Handle_OnFinish(object sender, System.EventArgs e)
		{
			
		}
        
        void Handle_Tapped(object sender, System.EventArgs e)
		{
			var contactMethodPage = new ContactMethodsPage();
			contactMethodPage.ContactMethodList.ItemSelected += (source, args) =>
			{
                contactMethod.Text = args.SelectedItem.ToString();
				Navigation.PopAsync();
			};
			Navigation.PushAsync(contactMethodPage);
		}
    }
}
