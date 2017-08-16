using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Util;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab1
{
    [Activity(Label = "Memory Eater")]
    public class SmallMemoryEaterActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Log.Debug("MemoryEater", "MemoryEater Activity launched, now consuming memory");
        }

        List<object> o = new List<object>();

        protected override async void OnStart()
        {
            base.OnStart();
            try
            {
                // consume memory
                o.Clear();
                for (int i = 0; i < 300; i++)
                {
                    o.Add(new int[100000]);
                    await Task.Delay(50);
                }
            }
            catch (System.Exception)
            {
            }
        }
    }
}
