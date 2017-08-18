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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using CustomRendererSample.Droid;
using ARatingBar = Android.Widget.RatingBar;
using Android.Media;
using System.ComponentModel;



namespace CustomRendererSample.Droid
{

    public class RatingRenderer : ViewRenderer<RatingBar, ARatingBar>
    {
        private ARatingBar _ratingBar;

        public RatingRenderer()
        {
            AutoPackage = false;
        }

        protected override ARatingBar CreateNativeControl() => new ARatingBar(Context, null, global::Android.Resource.Attribute.RatingBarStyle) { Max = 10 };

  

        protected override void OnElementChanged(ElementChangedEventArgs<RatingBar> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                // instantiate control
                // SetNativeControl
                _ratingBar = CreateNativeControl();
                SetNativeControl(_ratingBar);
            }

            if (e.OldElement != null)
            {
                // unsubscribe event handlers, cleanup
                _ratingBar.RatingBarChange -= OnRatingBarChange;
            }

            if (e.NewElement != null)
            {
                // configure the control, subscribe to event handlers

                _ratingBar.RatingBarChange += OnRatingBarChange;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == RatingBar.NumStarsProperty.PropertyName) UpdateNumStars();

            if (e.PropertyName == RatingBar.RatingProperty.PropertyName) UpdateRating();

            if (e.PropertyName == RatingBar.StepSizeProperty.PropertyName) UpdateStepSize();

        }

        private void OnRatingBarChange(object sender, ARatingBar.RatingBarChangeEventArgs e)
        {

        }

        private void UpdateNumStars() => Control.NumStars = Element.NumStars;

        private void UpdateRating() => Control.Rating = (float)Element.Rating;

        private void UpdateStepSize() => Control.StepSize = (float)Element.StepSize;


    }
}