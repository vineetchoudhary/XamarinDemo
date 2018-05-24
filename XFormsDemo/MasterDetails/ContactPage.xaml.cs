using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.ComponentModel;
using System.Threading.Tasks;

namespace XFormsDemo.MasterDetails
{
	public partial class ContactPage : ContentPage
    {
		const string image = "https://raw.githubusercontent.com/vineetchoudhary/AppBox-iOSAppsWirelessInstallation/master/AppBox/Assets.xcassets/AppIcon.appiconset/iOSBetaTest-feature256-256.png";
      
        public ContactPage()
        {
			InitializeComponent();
			var contacts = new List<Contact> 
			{
				new Contact{ Id=1, Name="Vineet Choudhary", Status="Hello there!!!", ImageURL=image},
				new Contact{ Id=2, Name="Vishal Choudhary", Status="Hey there!!!", ImageURL=image}
			};
			contactList.ItemsSource = contacts;
        }

		async void Handle_Cell_Tapped(object sender, System.EventArgs e)
		{
			contactList.SelectedItem = null;
			var selectedContact = ((sender as ImageCell)?.CommandParameter as Contact);
			var contactDetailsPage = new ContactDetailsPage(selectedContact);
			await Navigation.PushAsync(contactDetailsPage);
		}
    }
}
