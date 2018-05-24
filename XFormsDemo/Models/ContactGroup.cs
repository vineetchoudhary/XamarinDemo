using System;
using System.Collections.Generic;

namespace XFormsDemo
{
	public class ContactGroup : List<Contact>
    {
		public String Title { get; set; }
		public String ShortTitle { get; set; }

		public ContactGroup(String title, String shortTitle)
        {
			Title = title;
			ShortTitle = shortTitle;
        }
    }
}
