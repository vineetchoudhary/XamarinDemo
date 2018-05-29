using System;
using System.Security.Policy;
namespace XFormsDemo.DataAccess.Rest
{
	public class Post
	{
		public const string Url = "http://192.168.22.12:9999/articles";

        public string id { get; set; }
        public string author_id { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string url => String.Format("{0}/{1}", Post.Url, this.id ?? "0");
	}
}
