using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace XFormsDemo
{
    public partial class ButtonImagePage : ContentPage
    {
        public ButtonImagePage()
        {
            InitializeComponent();
			Analytics.TrackEvent("Button Image Page");
        }
    }
}
