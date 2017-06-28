using Android.App;
using Android.Widget;
using Android.OS;

namespace CirclerProgressQs
{
    [Activity(Label = "CirclerProgressQs", MainLauncher = true, Icon = "@drawable/nx_logo_green")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
        }
    }
}

