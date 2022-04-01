using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using CloneMessage.View.Controls;
using CloneMessage.Droid.Renderer;
using Android.Content;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(MyFrame), typeof(MyFrameRenderer))]
namespace CloneMessage.Droid.Renderer
{
    class MyFrameRenderer : FrameRenderer
    {
        public MyFrameRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);
            if(e.NewElement != null)
            {
                UpdateCornerRadius();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if(e.PropertyName == nameof(MyFrame.BorderColor) ||
                e.PropertyName == nameof(MyFrame))
            {
                UpdateCornerRadius();
            }
        }

        private void UpdateCornerRadius()
        {
            var borderColor = (Element as MyFrame).BorderColor;
            var cornerRadius = (Element as MyFrame).CornerRadius;

            var gradentDrawable = new GradientDrawable();
            gradentDrawable.SetCornerRadius(20);
            gradentDrawable.SetStroke((int)cornerRadius, Android.Graphics.Color.ParseColor(borderColor.ToHex()));

            this.SetBackgroundDrawable(gradentDrawable);
        }
    }
}