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
                e.PropertyName == nameof(MyFrame) ||
                e.PropertyName == nameof(MyFrame.CornerRadius)||
                e.PropertyName == nameof(MyFrame.Stroke))
            {
                UpdateCornerRadius();
            }
        }

        private void UpdateCornerRadius()
        {
            var borderColor = (Element as MyFrame).BorderColor;
            float cornerRadius = (Element as MyFrame).CornerRadius;
            int stroke = (Element as MyFrame).Stroke;

            var gradentDrawable = new GradientDrawable();
            gradentDrawable.SetCornerRadius(cornerRadius);
            gradentDrawable.SetStroke(stroke, Android.Graphics.Color.ParseColor(borderColor.ToHex()));

            this.SetBackgroundDrawable(gradentDrawable);
        }
    }
}