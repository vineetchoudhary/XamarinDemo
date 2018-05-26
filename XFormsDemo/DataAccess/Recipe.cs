using System;
using SQLite;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XFormsDemo.DataAccess
{
	public class Recipe : INotifyPropertyChanged
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        //Name
		private string name;
        [MaxLength(255)]
        public string Name 
		{ 
			get
			{
				return name;
			}
			set
			{
				if (name == value)
					return;
				name = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		void OnPropertyChanged([CallerMemberName] string name = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}
}
