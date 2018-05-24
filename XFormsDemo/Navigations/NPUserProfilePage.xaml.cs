using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XFormsDemo.Navigations.Models;

namespace XFormsDemo.Navigations
{
    public partial class NPUserProfilePage : ContentPage
    {
		public NPUserProfilePage(NPActivity activity)
        {
            InitializeComponent();
			BindingContext = activity;
        }
    }
}
