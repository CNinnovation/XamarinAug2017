using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;

namespace AsyncSample
{
    [Activity(Label = "AsyncSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            FindViewById<Button>(Resource.Id.button1).Click += async (sender, e) =>
            {


                await Task.Delay(3000).ConfigureAwait(false);

                RunOnUiThread(() =>
                {
                    FindViewById<TextView>(Resource.Id.textView1).Text = "after the delay";
                });


            };


        }

    }
}

