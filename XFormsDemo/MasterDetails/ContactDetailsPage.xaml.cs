using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsDemo.MasterDetails
{
    public partial class ContactDetailsPage : ContentPage
    {
		public ContactDetailsPage(Contact contact)
        {
			if (contact == null)
				throw new ArgumentNullException(nameof(contact), "contact paramenter can't be null.");
            InitializeComponent();
			BindingContext = contact;
        }
              
    }
}
