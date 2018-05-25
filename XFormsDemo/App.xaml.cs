using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFormsDemo.Forms;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFormsDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

			MainPage = new ControllsPage();
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
