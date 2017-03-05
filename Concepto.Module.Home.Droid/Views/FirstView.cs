using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Concepto.Module.Home.Droid.Views
{
    [Activity(Label = "Modulo home")]
    public class HomeView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}
