using System;
using XFormsDemo.DataAccess.Netflix.Common;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace XFormsDemo.DataAccess.Netflix.Models
{
    public class PageDetails<T> : BaseClass
    {
        private int _page;
        private int _totalResults;
        private int _totalPages;
        private ObservableCollection<T> _results;

        [JsonProperty("page")]
        public int CurrentPage
        {
            get { return _page; }
            set { SetValue(ref _page, value); }
        }

        [JsonProperty("total_results")]
        public int TotalResults
        {
            get { return _totalResults; }
            set { SetValue(ref _totalResults, value); }
        }

        [JsonProperty("total_pages")]
        public int TotalPages
        {
            get { return _totalPages; }
            set { SetValue(ref _totalPages, value); }
        }

        public ObservableCollection<T> Results
        {
            get { return _results; }
            set { SetValue(ref _results, value); }
        }
    }
}
