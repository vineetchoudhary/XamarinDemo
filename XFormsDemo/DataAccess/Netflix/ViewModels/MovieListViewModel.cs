using System;
using XFormsDemo.DataAccess.Netflix.Common;
using System.Net.Http;
using XFormsDemo.DataAccess.Netflix.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XFormsDemo.DataAccess.Netflix.ViewModels
{
    public class MovieListViewModel : BaseViewModel
    {
        private HttpClient httpClient = new HttpClient();
        private PageDetails<MovieDetails> _moviewPageDetails;
        public PageDetails<MovieDetails> MoviewPageDetails
        {
            get { return _moviewPageDetails; }
            set 
            {
                SetValue( ref _moviewPageDetails, value);
                OnPropertyChanged(nameof(Movies));
            }
        }

        public List<MovieDetails> Movies 
        {
            get { return MoviewPageDetails?.Results; }
        }

        public Command SearchCommand { get; private set; }

        public MovieListViewModel()
        {
            LoadLatestMovies();
            SearchCommand = new Command<string>(SearchMovies);
        }

        private async void LoadLatestMovies()
        {
            var response = await httpClient.GetStringAsync(MovieDetails.PopularUrl);
            MoviewPageDetails = JsonConvert.DeserializeObject<PageDetails<MovieDetails>>(response);
        }

        private async void SearchMovies(string query)
        {
            string searchQuery = MovieDetails.SearchUrl(query);
            Console.WriteLine(searchQuery);
            var response = await httpClient.GetStringAsync(searchQuery);
            MoviewPageDetails = JsonConvert.DeserializeObject<PageDetails<MovieDetails>>(response);
        }
    }
}
