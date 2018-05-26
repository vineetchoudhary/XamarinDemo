using System;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Xamarin.Forms;

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
				IsRefreshing = value;
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

        //Load Posts
		async public void LoadPost()
		{
			IsRefreshing = IsBusy = true;
			await Task.Delay(5000);                  
			var response = await httpClient.GetStringAsync(Post.Url);
			IsRefreshing = IsBusy = false;
			Posts = JsonConvert.DeserializeObject<List<Post>>(response);
		}

        //Commands
		public Command AddPostCommand { get; set; }
		public Command RefreshListCommand { get; set; }
        
		private void ManageCommands()
		{
			AddPostCommand = new Command( async () =>
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
				await httpClient.PostAsync(Post.Url, new StringContent(postContent));
				IsBusy = false;
				LoadPost();
			}, () => !IsBusy);

			RefreshListCommand = new Command(LoadPost, () => !IsBusy);
		}
    }
}
