using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XFormsDemo
{
	public class Contact : INotifyPropertyChanged
    {
		public Contact()
        {
			FollowCommand = new Command(async () => await HandleFollowAction(), () => !IsBusy);
			MessageCommand = new Command(async () => await HandleMessageAction(), () => !IsBusy);
        }

		int id;
		public int Id 
		{
			get { return id; }
			set { id = value; }
		}

		string name;
		public string Name 
		{ 
			get { return name; } 
			set { name = value; } 
		}

		string status;
		public string Status 
		{ 
			get { return status; } 
			set { status = value; } 
		}

		string imageURL;
		public string ImageURL 
		{ 
			get { return imageURL; } 
			set { imageURL = value; } 
		}

		bool follow;      
		public bool Follow 
		{ 
			get { return follow; } 
			set 
			{ 
				follow = value;
				OnPropertyChanged(nameof(FollowStatus));
			} 
		}      
		public string FollowStatus
		{
			get
			{
				return Follow ? "UnFollow" : "Follow";
			}
		}
        
		bool isBusy;
		public bool IsBusy
		{
			get { return isBusy; }
			set 
			{
				isBusy = value;
				OnPropertyChanged();
				FollowCommand.ChangeCanExecute();
			}
   		}

        //Property changed Event Handler
		public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{   
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		//Commands      
		public Command FollowCommand { get; }

		async Task HandleFollowAction()
		{
			IsBusy = true;
			await Task.Delay(4000);
			IsBusy = false;
			Follow = !Follow;
		}

		public Command MessageCommand { get; }
              
		async Task HandleMessageAction()
		{
			Console.WriteLine("Sending Message...");
			IsBusy = true;
			await Task.Delay(5000);
			IsBusy = false;
			Console.WriteLine("Message Sent!!!");
			Console.ResetColor();

		}
	}
}
