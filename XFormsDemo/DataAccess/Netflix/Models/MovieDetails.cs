using System;
using XFormsDemo.DataAccess.Netflix.Common;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace XFormsDemo.DataAccess.Netflix.Models
{
    public class MovieDetails : BaseClass
    {
        #region Private Properties
        private int _id;
        private int _voteCount = 0;
        private float _voteAvg = 0;
        private string _title;
        private float _popularity = 0;
        private string _language;
        private string _imageUrl;
        private string _backdropPath;
        private bool _adult;
        private string _overview;
        private string _releaseDate;
        #endregion

        #region Public Properties
        [JsonProperty("id")]
        public int Id
        {
            get { return _id; }
            set { SetValue(ref _id, value); }
        }

        [JsonProperty("vote_count")]
        public int VoteCount
        {
            get { return _voteCount; }
            set { SetValue(ref _voteCount, value); }
        }

        [JsonProperty("vote_average")]
        public float VoteAvg
        {
            get { return _voteAvg; }
            set { SetValue(ref _voteAvg, value); }
        }

        [JsonProperty("title")]
        public string Title
        {
            get { return _title; }
            set { SetValue(ref _title, value); }
        }

        [JsonProperty("popularity")]
        public float Popularity
        {
            get { return _popularity; }
            set { SetValue(ref _popularity, value); }
        }

        [JsonProperty("original_language")]
        public string Language
        {
            get { return _language; }
            set { SetValue(ref _language, value); }
        }

        [JsonProperty("poster_path")]
        public string ImageUrl
        {
            get { return _imageUrl; }
            set
            {
                SetValue(ref _imageUrl, value);
                OnPropertyChanged(nameof(SmallImageUrl));
            }
        }

        [JsonProperty("backdrop_path")]
        public string BackdropPath
        {
            get { return _backdropPath; }
            set
            {
                SetValue(ref _backdropPath, value);
                OnPropertyChanged(nameof(LargeImageUrl));
            }
        }

        public string SmallImageUrl
        {
            get
            {
                return String.Format("{0}/w92/{1}?api_key={2}", NetflixConfig.ImageBaseUrl, _imageUrl, NetflixConfig.APIKey); ;
            }
        }

        public string LargeImageUrl
        {
            get
            {
                return String.Format("{0}/w780/{1}?api_key={2}", NetflixConfig.ImageBaseUrl, _backdropPath, NetflixConfig.APIKey); ;
            }
        }

        [JsonProperty("adult")]
        public bool Adult
        {
            get { return _adult; }
            set { SetValue(ref _adult, value); }
        }

        public string AgeRating
        {
            get { return Adult ? "NC-17" : "G"; }
        }

        [JsonProperty("overview")]
        public string Overview
        {
            get { return _overview; }
            set { SetValue(ref _overview, value); }
        }

        [JsonProperty("release_date")]
        public string ReleaseDate
        {
            get { return _releaseDate; }
            set { SetValue(ref _releaseDate, value); }
        }
        #endregion

        #region Urls
        public static string SearchUrl(string query)
        {
            return String.Format("{0}search/movie?query={1}&api_key={2}", NetflixConfig.BaseUrl, query, NetflixConfig.APIKey);
        }

        public static string UpCommingUrl
        {
            get
            {
                return String.Format("{0}movie/upcoming?api_key={1}", NetflixConfig.BaseUrl, NetflixConfig.APIKey);
            }
        }

        public static string LatestUrl
        {
            get
            {
                return String.Format("{0}movie/latest?api_key={1}", NetflixConfig.BaseUrl, NetflixConfig.APIKey);
            }
        }

        public static string NowPlayingUrl
        {
            get
            {
                return String.Format("{0}movie/now_playing?api_key={1}", NetflixConfig.BaseUrl, NetflixConfig.APIKey);
            }
        }

        public static string PopularUrl
        {
            get
            {
                return String.Format("{0}movie/popular?api_key={1}", NetflixConfig.BaseUrl, NetflixConfig.APIKey);
            }
        }
        #endregion

    }
}
