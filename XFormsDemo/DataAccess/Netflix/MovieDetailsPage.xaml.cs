using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XFormsDemo.DataAccess.Netflix.Models;

namespace XFormsDemo.DataAccess.Netflix
{
    public partial class MovieDetailsPage : ContentPage
    {
        public MovieDetailsPage(MovieDetails movie)
        {
            InitializeComponent();
            BindingContext = movie;
        }
    }
}
