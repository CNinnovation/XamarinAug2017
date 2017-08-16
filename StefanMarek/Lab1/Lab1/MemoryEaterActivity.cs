using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Util;

namespace Lab1
{
    [Activity(Label = "Memory Eater")]
    public class MemoryEaterActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Log.Debug("MemoryEater", "MemoryEater Activity launched, now consuming memory");
        }

        int[] b;

        protected override void OnStart()
        {
            base.OnStart();
            try
            {
                // consume memory

                b = new int[100000000];
                System.Diagnostics.Debug.WriteLine(b.Length);
            }
            catch (System.Exception)
            {
            }
        }
    }
}
