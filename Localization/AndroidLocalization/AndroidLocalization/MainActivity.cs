using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;

namespace AndroidLocalization
{
    [Activity(Label = "AndroidLocalization", 
        MainLauncher = true, 
        ConfigurationChanges = ConfigChanges.Locale,
        Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            string locale = Resources.Configuration.Locale.Language;
            FindViewById<TextView>(Resource.Id.textUserLocale).Text = locale;

            string hello = GetText(Resource.String.Hello);
            FindViewById<TextView>(Resource.Id.textViewHello2).Text = hello;

            string text1 = Resources.GetQuantityString(Resource.Plurals.numberOfChildren, 1, 1);
            FindViewById<TextView>(Resource.Id.textView1).Text = text1;
            string text2 = Resources.GetQuantityString(Resource.Plurals.numberOfChildren, 3, 3);
            FindViewById<TextView>(Resource.Id.textView2).Text = text2;
            string text3 = Resources.GetQuantityString(Resource.Plurals.numberOfChildren, 0, 0);
            FindViewById<TextView>(Resource.Id.textView3).Text = text3;
        }
    }
}

