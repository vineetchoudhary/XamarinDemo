using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace XFormsDemo.Forms.CustomCell
{
	public partial class DateCell : ViewCell
	{
		public static readonly BindableProperty LabelProperty = BindableProperty.Create(nameof(Label), typeof(string), typeof(DateCell), "Date");
		public static readonly BindableProperty DefaultDateProperty = BindableProperty.Create(nameof(DefaultDate), typeof(string), typeof(DateCell), "01/01/2000");

		public string Label
		{
			get { return (string)GetValue(LabelProperty); }
			set { SetValue(LabelProperty, value); }
		}
		public string DefaultDate
		{
			get { return (string)GetValue(DefaultDateProperty); }
			set { SetValue(DefaultDateProperty, value); }
		}



        public DateCell()
        {
            InitializeComponent();

			BindingContext = this;
        }
    }
}
