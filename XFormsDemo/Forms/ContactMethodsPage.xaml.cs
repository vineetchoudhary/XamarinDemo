using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsDemo.Forms
{
    public partial class ContactMethodsPage : ContentPage
    {
		public ListView ContactMethodList { get { return contactMethodList; } }

        public ContactMethodsPage()
        {
            InitializeComponent();
			contactMethodList.ItemsSource = new List<String> { "None", "SMS", "Email", "SMS+Email" };
        }
    }
}
