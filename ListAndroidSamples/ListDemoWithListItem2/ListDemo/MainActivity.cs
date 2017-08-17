using Android.App;
using Android.Widget;
using Android.OS;

namespace ListDemo
{
    [Activity(Label = "ListDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.buttonGotoList);
            button.Click += (sender, e) =>
                StartActivity(typeof(MyListActivity));
        }
    }
}

