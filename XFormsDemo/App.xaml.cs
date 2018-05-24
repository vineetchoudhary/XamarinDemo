using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFormsDemo.Navigations;
using XFormsDemo.MasterDetails;
using XFormsDemo.TabBarView;
using XFormsDemo.Carousel;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFormsDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

			MainPage = new MainCarouselPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
