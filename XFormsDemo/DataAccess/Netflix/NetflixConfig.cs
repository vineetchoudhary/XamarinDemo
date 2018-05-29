using System;
namespace XFormsDemo.DataAccess.Netflix
{
    public class NetflixConfig
    {
        private static NetflixConfig _default = null;
        public static string BaseUrl { get { return "http://api.themoviedb.org/3/"; }}
        public static string APIKey { get { return "bf1c5e3e5142fd27208a655dd3313d65"; }}
        public static string ImageBaseUrl { get { return "https://image.tmdb.org/t/p/"; }}

        public static NetflixConfig Default
        {
            get
            {
                if (_default == null)
                {
                    _default = new NetflixConfig();
                }
                return _default;
            }
        }

        private NetflixConfig()
        {
			
        }
    }
}
