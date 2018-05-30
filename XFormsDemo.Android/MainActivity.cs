using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Lottie.Forms.Droid;
using System.Threading.Tasks;
using FFImageLoading.Forms.Platform;

namespace XFormsDemo.Droid
{
	[Activity(Label = "XFormsDemo", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);
            ImageCircleRenderer.Init();
            CachedImageRenderer.Init(true);
            AppCenter.Start("c5e1f818-85ec-4f7e-8ec6-4c66ab822789", typeof(Analytics), typeof(Crashes));
            AnimationViewRenderer.Init();
            LoadApplication(new App());

        }

    }
}

