using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace XFormsDemo.Forms
{
    public partial class TableViewFormPage : ContentPage
    {
        public TableViewFormPage()
        {
            InitializeComponent();
        }

		void Handle_OnChanged(object sender, Xamarin.Forms.ToggledEventArgs e)
		{
			if (e.Value) 
			{
				notificationAnimationStack.IsVisible = true;
				notificationAnimation.Play();
            }
		}

		void Handle_OnFinish(object sender, System.EventArgs e)
		{
			notificationAnimationStack.IsVisible = false;
		}
        
    }
}
