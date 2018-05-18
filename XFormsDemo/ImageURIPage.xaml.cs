using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsDemo
{
    public partial class ImageURIPage : ContentPage
    {
		public ImageURIPage()
		{
			InitializeComponent();
			//image.Source = ImageSource.FromFile("CoverImage.jpg");

			//var imageSource = new UriImageSource
			//{
			//	Uri = new Uri("http://lorempixel.com/1920/1080/nature/4/"),
			//	CachingEnabled = false,
			//	CacheValidity = new TimeSpan(7, 0, 0, 0)
			//};
			//image.Source = imageSource;
		}
    }
}
