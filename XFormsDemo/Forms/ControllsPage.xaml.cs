using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsDemo.Forms
{
    public partial class ControllsPage : ContentPage
    {
        public ControllsPage()
        {
            InitializeComponent();
        }

		void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
		{
			Console.WriteLine("Switch is {0}", e.Value);
		}

		void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			Console.WriteLine("Slider value is to {0} from {1}", e.NewValue, e.OldValue);
		}

		void Handle_ValueChanged_1(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			Console.WriteLine("Stepper value is to {0} from {1}", e.NewValue, e.OldValue);           
		}
    }
}
