using System;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http.Headers;

namespace XFormsDemo.DataAccess.Rest
{
	public class PostManager : INotifyPropertyChanged
    {
        //HTTP Client
        private HttpClient httpClient = new HttpClient();

        //Post List
		private List<Post> posts;      
		public List<Post> Posts 
		{
			get
			{
				return posts;
			}
			set
			{
				posts = value;
				OnPropertyChanged();
			}
		}

		//Working
		private bool isBusy = false;
        public bool IsBusy
		{
			get
			{
				return isBusy;
			}
			set
            {
				isBusy = value;
				OnPropertyChanged();
				AddPostCommand?.ChangeCanExecute();
				RefreshListCommand?.ChangeCanExecute();
                DeleteCommand?.ChangeCanExecute();
            }
		}

		private bool isRefreshing = false;
		public bool IsRefreshing
		{
			get
			{
				return isRefreshing;
			}
			set
			{
				isRefreshing = value;
				OnPropertyChanged();
			}
		}

        //Property changed notifier
		public event PropertyChangedEventHandler PropertyChanged;
		void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        //Default Post Manager
		private static PostManager defaultPostManager = null;

		private PostManager()
        {
            //httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			LoadPost();
            ManageCommands();
        }

		public static PostManager Default
		{
			get
			{
				if (defaultPostManager == null)
					defaultPostManager = new PostManager();
				return defaultPostManager;
			}
		}

        //Posts
		async public void LoadPost()
		{
            IsBusy = IsRefreshing = true;
			await Task.Delay(3000);                  
			var response = await httpClient.GetStringAsync(Post.Url);
            IsBusy = IsRefreshing = false;
			Posts = JsonConvert.DeserializeObject<List<Post>>(response);
		}

        async public Task CreatePost()
        {
            Post post = new Post
            {
                title = "Hello form the other side.",
                content = "Hello, it's me I was wondering if after all these years you'd like to meet To go over everything They say that time's supposed to heal ya But I ain't done much healing",
                author = "Vineet",
                author_id = "1"
            };
            var postContent = JsonConvert.SerializeObject(post);
            IsBusy = true;
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, Post.Url);
            requestMessage.Content = new StringContent(postContent);
            requestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            await httpClient.SendAsync(requestMessage);
            IsBusy = false;
        }

        async public void DeletePost(Post post)
        {
            IsBusy = true;
            var response = await httpClient.DeleteAsync(post.url);
            IsBusy = false;
            LoadPost();
        }

        //Commands
		public Command AddPostCommand { get; set; }
		public Command RefreshListCommand { get; set; }
        public Command DeleteCommand { get; set; }
        
		private void ManageCommands()
		{
			AddPostCommand = new Command( async () =>
			{
                await CreatePost();
				LoadPost();
			}, () => !IsBusy);

			RefreshListCommand = new Command(LoadPost, () => !IsBusy);

            DeleteCommand = new Command<Post>(DeletePost, (post) => !IsBusy);
		}
    }
}
