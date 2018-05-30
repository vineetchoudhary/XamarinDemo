using System;
using XFormsDemo.DataAccess.Netflix.Common;
using System.Net.Http;
using XFormsDemo.DataAccess.Netflix.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace XFormsDemo.DataAccess.Netflix.ViewModels
{
    public class MovieListViewModel : BaseViewModel
    {
        private HttpClient httpClient = new HttpClient();
        private PageDetails<MovieDetails> _moviewPageDetails;
        private bool _isBusy = false;

        public PageDetails<MovieDetails> MoviewPageDetails
        {
            get { return _moviewPageDetails; }
            set 
            {
                SetValue( ref _moviewPageDetails, value);
                OnPropertyChanged(nameof(Movies));
                OnPropertyChanged(nameof(IsEmpty));
                OnPropertyChanged(nameof(IsNotEmpty));
            }
        }

        public List<MovieDetails> Movies 
        {
            get { return MoviewPageDetails?.Results; }
        }

        public bool IsEmpty 
        { 
            get 
            { 
                return (MoviewPageDetails?.Results?.Count ?? 0) == 0 && !IsBusy; 
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

        public Command SearchCommand { get; private set; }

        public MovieListViewModel()
        {
            LoadLatestMovies();
            SearchCommand = new Command<string>(SearchMovies);
        }

        private async void LoadLatestMovies()
        {
            IsBusy = true;
            await Task.Delay(2000);
            var response = await httpClient.GetStringAsync(MovieDetails.PopularUrl);
            MoviewPageDetails = JsonConvert.DeserializeObject<PageDetails<MovieDetails>>(response);
            IsBusy = false;
        }

        private async void SearchMovies(string query)
        {
            string searchQuery = MovieDetails.SearchUrl(query);
            Console.WriteLine(searchQuery);
            IsBusy = true;
            await Task.Delay(2000);
            var response = await httpClient.GetStringAsync(searchQuery);
            MoviewPageDetails = JsonConvert.DeserializeObject<PageDetails<MovieDetails>>(response);
            IsBusy = false;
        }
    }
}
