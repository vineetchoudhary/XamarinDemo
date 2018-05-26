using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsDemo.DataAccess.Rest
{
    public partial class RestPostPage : ContentPage
    {
        public RestPostPage()
		{
            InitializeComponent();
			BindingContext = PostManager.Default;
        }

    }
}
