using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsDemo
{
    public partial class ImageListPage : ContentPage
    {
		int currentIndex = 1;
		const int minIndex = 1;
        const int maxIndex = 10;
        const String baseURL = "http://lorempixel.com/1920/1080/city/";

        public ImageListPage()
        {
            InitializeComponent();
			updateImage();
        }

		void PrevButton_Handle_Clicked(object sender, System.EventArgs e)
		{
			currentIndex = (currentIndex == minIndex) ? maxIndex : (currentIndex - 1);
			updateImage();
		}

		void NextButton_Handle_Clicked(object sender, System.EventArgs e)
		{
			currentIndex = (currentIndex == maxIndex) ? minIndex : (currentIndex + 1);
			updateImage();
		}

		void Handle_Tapped(object sender, System.EventArgs e)
		{
			NextButton_Handle_Clicked(sender, e);
		}

		void updateImage()
		{
			var uriString = String.Format("{0}{1}", baseURL, currentIndex);
			image.Source = ImageSource.FromUri(new Uri(uriString));
		}
    }
}
