using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XFormsDemo.Navigations.Models;

namespace XFormsDemo.Navigations
{
    public partial class NPActivityPage : ContentPage
    {
    
        public NPActivityPage()
        {
            InitializeComponent();
			var list = new List<NPActivity>
			{
				new NPActivity{Name="Vineet", Activity="Your facebook friend Vineet is on Instagram", Image="http://lorempixel.com/100/100/people/1"},
				new NPActivity{Name="Vishal", Activity="Your facebook friend Vishal is on Instagram", Image="http://lorempixel.com/100/100/people/2"},
				new NPActivity{Name="Vinay", Activity="Your facebook friend Vinay is on Instagram", Image="http://lorempixel.com/100/100/people/3"},
				new NPActivity{Name="Anit", Activity="Your facebook friend Anit is on Instagram", Image="http://lorempixel.com/100/100/people/4"},
				new NPActivity{Name="Anuj", Activity="Your facebook friend Anuj is on Instagram", Image="http://lorempixel.com/100/100/people/5"},
				new NPActivity{Name="Amit", Activity="Your facebook friend Amit is on Instagram", Image="http://lorempixel.com/100/100/people/6"},
				new NPActivity{Name="Mamta", Activity="Your facebook friend Mamta is on Instagram", Image="http://lorempixel.com/100/100/people/7"},
				new NPActivity{Name="Sapna", Activity="Your facebook friend Sapna is on Instagram", Image="http://lorempixel.com/100/100/people/8"},
				new NPActivity{Name="Dolly", Activity="Your facebook friend Dolly is on Instagram", Image="http://lorempixel.com/100/100/people/9"},
				new NPActivity{Name="Pulkit", Activity="Your facebook friend Pulkit is on Instagram", Image="http://lorempixel.com/100/100/people/10"},
			};

			activitiesList.ItemsSource = list;
        }
      

		public void SelecteItem_Handle(object sender, SelectedItemChangedEventArgs args)
		{
			activitiesList.SelectedItem = null;
			NPActivity activity = args.SelectedItem as NPActivity;
			if (activity != null)
			{
				Navigation.PushAsync(new NPUserProfilePage(activity));
            }
		}
    }
}
