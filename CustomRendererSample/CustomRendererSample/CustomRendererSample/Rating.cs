using Xamarin.Forms;

namespace CustomRendererSample
{
    public class Rating : View
    {
        public Rating()
        {

        }

        public double NumStars
        {
            get { return (double)GetValue(NumStarsProperty); }
            set { SetValue(NumStarsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NumStars.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty NumStarsProperty =
            BindableProperty.Create("NumStars", typeof(double), typeof(Rating), 5.0);

        public double StepSize
        {
            get { return (double)GetValue(StepSizeProperty); }
            set { SetValue(StepSizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NumStars.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty StepSizeProperty =
            BindableProperty.Create("StepSize", typeof(double), typeof(Rating), 1.0);
    }
}
