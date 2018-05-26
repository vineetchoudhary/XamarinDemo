using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsDemo.DataAccess
{
    public partial class ApplicationPropertiesPage : ContentPage
    {
        public ApplicationPropertiesPage()
        {
            InitializeComponent();
			BindingContext = AppSettings.Current;
        }


    }
}
