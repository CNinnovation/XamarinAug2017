using Android.App;
using Android.Widget;
using Android.OS;
using System.Runtime.CompilerServices;
using Android.Content;
using System.Diagnostics;
using System;

namespace Lab1
{
    [Activity(Label = "Lab1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var btnAllocate = FindViewById<Button>(Resource.Id.btnAllocate);
            var btnAllocateSmall = FindViewById<Button>(Resource.Id.btnAllocateSmall);
            var btnCollect = FindViewById<Button>(Resource.Id.btnGCCollect);

            btnAllocate.Click += (s, e) => StartActivity(typeof(MemoryEaterActivity));
            btnAllocateSmall.Click += (s, e) => StartActivity(typeof(SmallMemoryEaterActivity));

            btnCollect.Click += (s, e) =>
            {
                System.GC.Collect(0, GCCollectionMode.Forced, true, true);
                System.GC.Collect(1, GCCollectionMode.Forced, true, true);
            };
        }

        protected void LogIt([CallerMemberName] string name = "")
        {
            try
            {
                System.Diagnostics.Debug.Write($"{name} called");
                Android.Util.Log.Debug("Lab1", $"{name} called");
            }
            catch (Exception ex)
            {
                Debugger.Break();
            }
        }

        protected override void OnStart()
        {
            LogIt();
            base.OnStart();
        }

        protected override void OnPause()
        {
            LogIt();
            base.OnPause();
        }

        protected override void OnStop()
        {
            LogIt();
            base.OnStop();
        }

        public override void OnActivityReenter(int resultCode, Intent data)
        {
            LogIt();
            base.OnActivityReenter(resultCode, data);
        }

        public override void OnBackPressed()
        {
            LogIt();
            base.OnBackPressed();
        }

        protected override void OnDestroy()
        {
            LogIt();
            base.OnDestroy();
        }

        protected override void OnRestart()
        {
            LogIt();
            base.OnRestart();
        }

        protected override void OnResume()
        {
            LogIt();
            base.OnResume();
        }


    }
}

