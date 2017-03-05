using Android.App;
using Android.Content.PM;
using Concepto.Module.Home.Droid;
using MvvmCross.Droid.Views;

namespace Concepto.Module.Droid
{
    [Activity(
        Label = "Concepto.Droid"
        , MainLauncher = true
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
