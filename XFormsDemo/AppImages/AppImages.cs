using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFormsDemo.AppImages
{
	[ContentProperty("ResourceId")]
	public class AppImages : IMarkupExtension
    {
		public string ResourceId { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			if (String.IsNullOrWhiteSpace(ResourceId)) 
				return null;

			return ImageSource.FromResource(ResourceId);
		}
	}
}
