using System;
using System.Collections.Generic;
using System.Linq;
using FFImageLoading.Forms.Platform;
using Foundation;
using ImageCircle.Forms.Plugin.iOS;
using Lottie.Forms.iOS.Renderers;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using UIKit;

namespace XFormsDemo.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Xamarin.Calabash.Start();
            global::Xamarin.Forms.Forms.Init();
			ImageCircleRenderer.Init();
            CachedImageRenderer.Init();

            LoadApplication(new App());
			AppCenter.Start("fd753d57-8fae-4977-91f3-df889f2db996", typeof(Analytics), typeof(Crashes));
			AnimationViewRenderer.Init();

            return base.FinishedLaunching(app, options);
        }
    }
}
