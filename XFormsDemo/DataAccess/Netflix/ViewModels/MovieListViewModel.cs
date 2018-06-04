using System;
using XFormsDemo.DataAccess.Netflix.Common;
using System.Net.Http;
using XFormsDemo.DataAccess.Netflix.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms.Internals;

namespace XFormsDemo.DataAccess.Netflix.ViewModels
{
    public class MovieListViewModel : BaseViewModel
    {
        private HttpClient httpClient = new HttpClient();
        private PageDetails<MovieDetails> _moviePageDetails;
        private bool _isBusy = false;
        private bool _isLoadingMore = false;

        public PageDetails<MovieDetails> MoviePageDetails
        {
            get { return _moviePageDetails; }
            set 
            {
                SetValue( ref _moviePageDetails, value);
                OnPropertyChanged(nameof(Movies));
                OnPropertyChanged(nameof(IsEmpty));
                OnPropertyChanged(nameof(IsNotEmpty));
            }
        }

        public ObservableCollection<MovieDetails> Movies 
        {
            get { return MoviePageDetails?.Results; }
        }

        public bool IsEmpty 
        { 
            get 
            { 
                return (MoviePageDetails?.Results?.Count ?? 0) == 0 && !IsBusy; 
            }
        }

        public bool IsNotEmpty { get { return !IsEmpty; } }



        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                SetValue(ref _isBusy, value);
                OnPropertyChanged(nameof(IsEmpty));
                OnPropertyChanged(nameof(IsNotEmpty));
            }
        }

        public bool IsLoadingMore
        {
            get { return _isLoadingMore; }
            set
            {
                SetValue(ref _isLoadingMore, value);
            }
        }

        public Command SearchCommand { get; private set; }
        public Command LoadMoreCommand { get; private set; }

        public MovieListViewModel()
        {
            LoadLatestMovies();
            SearchCommand = new Command<string>(SearchMovies);
            LoadMoreCommand = new Command<MovieDetails>(LoadLatestMovies);
        }

        private async void LoadLatestMovies(MovieDetails movie = null)
        {
            if (movie == null)
            {
                IsBusy = true;
            }
            else 
            {
                var currentIndex = MoviePageDetails?.Results?.IndexOf(movie) ?? 0;
                if (currentIndex == 0 || IsLoadingMore)
                    return;
                if (currentIndex + 5 < MoviePageDetails.Results.Count && MoviePageDetails.Results.Count != MoviePageDetails.TotalResults )
                    return;
                Console.WriteLine("====={0}", currentIndex);
                IsLoadingMore = true;
            }


            await Task.Delay(2000);
            var nextPage = movie == null ? 1 : MoviePageDetails.CurrentPage + 1;
            var response = await httpClient.GetStringAsync(MovieDetails.PopularUrl(nextPage));
            var moviePageDetails = JsonConvert.DeserializeObject<PageDetails<MovieDetails>>(response);
            UpdateMovieList(moviePageDetails);
            IsBusy = IsLoadingMore = false;
        }

        private async void SearchMovies(string query)
        {
            string searchQuery = MovieDetails.SearchUrl(query);
            Console.WriteLine(searchQuery);
            IsBusy = true;
            await Task.Delay(2000);
            var response = await httpClient.GetStringAsync(searchQuery);
            MoviePageDetails = JsonConvert.DeserializeObject<PageDetails<MovieDetails>>(response);
            //UpdateMovieList(moviePageDetails);
            IsBusy = false;
        }

        private void UpdateMovieList(PageDetails<MovieDetails> moviePageDetails)
        {
            if (MoviePageDetails == null)
            {
                MoviePageDetails = moviePageDetails;
            }
            else
            {
                MoviePageDetails.CurrentPage = moviePageDetails.CurrentPage;
                MoviePageDetails.TotalPages = moviePageDetails.TotalPages;
                MoviePageDetails.TotalResults = moviePageDetails.TotalPages;
                moviePageDetails.Results.ForEach((obj) => 
                {
                    MoviePageDetails.Results.Add(obj);
                });
                OnPropertyChanged(nameof(Movies)); 
            }
        }
    }
}
