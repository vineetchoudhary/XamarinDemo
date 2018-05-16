using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsDemo
{
    public partial class InitialPage : ContentPage
    {
        public InitialPage()
        {
            InitializeComponent();
			//Padding = GetPaddingThickness();
        }
        

		Thickness GetPaddingThickness()
		{
			switch (Device.RuntimePlatform)
			{
				case Device.iOS:
					return new Thickness(0, 20, 0, 0);
				case Device.Android:
					return new Thickness(0, 10, 0, 0);
				default:
					return new Thickness(0, 5, 0, 0);
			}
		}
    }
}
