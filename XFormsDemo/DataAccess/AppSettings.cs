using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace XFormsDemo.DataAccess
{
    public class AppSettings
    {      
        private AppSettings()
        {
			
        }

		private static AppSettings current = null;
		public static AppSettings Current
		{
			get
			{
				if (current == null)
					current = new AppSettings();
				return current;
			}
		}

		public string CompanyName 
		{
			get
			{
				if (Application.Current.Properties.ContainsKey(nameof(CompanyName)))
					return Application.Current.Properties[nameof(CompanyName)].ToString();
				return String.Empty;
			}
			set
			{
				Application.Current.Properties[nameof(CompanyName)] = value;
			}
		}

		public bool CompanyStatus
		{
			get
			{
				if (Application.Current.Properties.ContainsKey(nameof(CompanyStatus)))
					return (bool)Application.Current.Properties[nameof(CompanyStatus)];
				return false;
			}
            set
			{
				Application.Current.Properties[nameof(CompanyStatus)] = value; 
			}
		}      
    }
}
