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
using ListDemo.Models;

namespace ListDemo
{
    [Activity(Label = "MyListActivity")]
    public class MyListActivity : ListActivity
    {
        private IList<SomeData> _list;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            _list = Enumerable.Range(0, 100).Select(i => new SomeData { Number = i, Text = $"sample {i}" }).ToList();
            ListAdapter = new MySomeDataListAdapter(this, _list);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            SomeData selected = _list[position];
            Android.Widget.Toast.MakeText(this, selected.ToString(), Android.Widget.ToastLength.Short).Show();
        }
    }
}