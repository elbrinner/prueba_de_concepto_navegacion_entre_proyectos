using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Concepto.Module.Product.Droid.Views
{
    [Activity(Label = "data")]
    public class DataView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.DataView);
        }
    }
}
