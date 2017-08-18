using System;
using Xamarin.Forms;

namespace CustomRendererSample
{
    public class RatingBar : View
    {
        public RatingBar()
        {

        }

        public int NumStars
        {
            get { return (int)GetValue(NumStarsProperty); }
            set { SetValue(NumStarsProperty, value); }
        }

        public static readonly BindableProperty NumStarsProperty =
            BindableProperty.Create("NumStars", typeof(int), typeof(RatingBar), 5);

        public double StepSize
        {
            get { return (double)GetValue(StepSizeProperty); }
            set { SetValue(StepSizeProperty, value); }
        }

        public static readonly BindableProperty StepSizeProperty =
            BindableProperty.Create("StepSize", typeof(double), typeof(RatingBar), 1.0);

        public double Rating
        {
            get { return (double)GetValue(RatingProperty); }
            set { SetValue(RatingProperty, value); }
        }

        public static readonly BindableProperty RatingProperty =
            BindableProperty.Create("Rating", typeof(double), typeof(RatingBar), 3.5);

    }
}
