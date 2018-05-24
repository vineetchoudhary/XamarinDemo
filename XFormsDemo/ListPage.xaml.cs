using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace XFormsDemo
{
    public partial class ListPage : ContentPage
    {
		
        public ListPage()
        {
            InitializeComponent();
			listView.ItemsSource = GetContacts();
        }

		List<ContactGroup> GetContacts(String search = null)
		{
			ContactGroup aContactGroup = new ContactGroup("A", "A")
			{
				new Contact { Id=1, Name="Anit Choudhary", Status="Hey there!", ImageURL="http://lorempixel.com/100/100/people/5", Follow=false },
				new Contact { Id=2, Name="Anuj Choudhary", Status="Hey there!", ImageURL="http://lorempixel.com/100/100/people/6", Follow=true },
				new Contact { Id=3, Name="Amit Choudhary", Status="Hey there!", ImageURL="http://lorempixel.com/100/100/people/7", Follow=false },
			};
			ContactGroup bContactGroup = new ContactGroup("V", "V")
			{
				new Contact { Id=4, Name="Vineet Choudhary", Status="Hey there! I'm using Xamarin and I don't know anything about this.", ImageURL="http://lorempixel.com/100/100/people/1", Follow=true },
				new Contact { Id=5, Name="Vishal Choudhary", Status="Hello form the other side", ImageURL="http://lorempixel.com/100/100/people/2", Follow=false },
				new Contact { Id=6, Name="Vinay Choudhary", Status="No Status", ImageURL="http://lorempixel.com/100/100/people/3", Follow=false }
			};         

			if (!String.IsNullOrWhiteSpace(search)) {
				aContactGroup.RemoveAll((obj) => !obj.Name.Contains(search));
				bContactGroup.RemoveAll((obj) => !obj.Name.Contains(search));
			}

			List<ContactGroup> contacts = new List<ContactGroup>();
			if (aContactGroup.Count > 0) contacts.Add(aContactGroup);
			if (bContactGroup.Count > 0) contacts.Add(bContactGroup);
			return contacts;         
		}

		void Handle_Refreshing(object sender, System.EventArgs e)
		{
			listView.EndRefresh();
		}


		void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			listView.ItemsSource = GetContacts(e.NewTextValue);
		}

       

		void Cell_Handle_Tapped(object sender, System.EventArgs e)
		{
			if (listView.SelectedItem != null) 
			{
				listView.SelectedItem = null;
			}
		}     

  //      void Handle_Clicked(object sender, System.EventArgs e)
		//{
		//	var contact = (sender as Button).CommandParameter as Contact;
		//	contact.Follow = !contact.Follow;         
		//	Console.WriteLine(contact.Name);
		//}
    }
}
                                             