using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XFormsDemo.DataAccess.Netflix.ViewModels;
using XFormsDemo.DataAccess.Netflix.Models;

namespace XFormsDemo.DataAccess.Netflix
{
    public partial class MovieListPage : ContentPage
    {
        private MovieListViewModel ViewModel
        {
            get { return BindingContext as MovieListViewModel; }
            set { BindingContext = value; }
        }

        public MovieListPage()
        {
            InitializeComponent();
            ViewModel = new MovieListViewModel();
        }


        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            Navigation.PushAsync(new MovieDetailsPage(e.SelectedItem as MovieDetails));
            moviewListView.SelectedItem = null;
        }

        void Handle_Login_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new LoginPage());
        }
    }
}
