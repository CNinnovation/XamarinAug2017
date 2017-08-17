using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.Design.Widget;

namespace ListDemo
{
    [Activity(Label = "MyListActivity")]
    public class MyListActivity : ListActivity
    {
        private IList<string> _list;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            _list = Enumerable.Range(0, 20).Select(i => $"{i}. item").ToList();

            ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, _list);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            String selected = _list[position];
            Android.Widget.Toast.MakeText(this, selected, Android.Widget.ToastLength.Short).Show();
        }

    }
}