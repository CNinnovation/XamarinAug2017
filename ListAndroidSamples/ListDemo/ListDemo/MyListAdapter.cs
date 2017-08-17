using Android.App;
using Android.Views;
using Android.Widget;
using ListDemo.Models;
using System;
using System.Collections.Generic;

namespace ListDemo
{
    public class MyListAdapter<T> : BaseAdapter
    {

        protected readonly Activity _activity;
        protected readonly IList<T> _items;

        public MyListAdapter(Activity activity, IList<T> items)
        {
            _activity = activity;
            _items = items;
        }

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
            {
                view = _activity.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
            }
            return view;
          
            //var view = convertView;
            //SomeDataAdapterViewHolder holder = null;

            //if (view != null)
            //    holder = view.Tag as SomeDataAdapterViewHolder;

            //if (holder == null)
            //{
            //    holder = new SomeDataAdapterViewHolder();
            //    var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
            //    //replace with your item and your holder items
            //    //comment back in
            //    //view = inflater.Inflate(Resource.Layout.item, parent, false);
            //    //holder.Title = view.FindViewById<TextView>(Resource.Id.text);
            //    view.Tag = holder;
            //}

            ////fill in your items
            ////holder.Title.Text = "new text here";

            //return view;
        }

        public override int Count => _items.Count;
    }

    public class MySomeDataListAdapter : MyListAdapter<SomeData>
    {
        public MySomeDataListAdapter(Activity activity, IList<SomeData> items)
            : base(activity, items)
        {
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = base.GetView(position, convertView, parent);
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = $"{_items[position].Number}: {_items[position].Text}";
            return view;
        }
    }
}