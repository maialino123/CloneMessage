using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CloneMessage.View.Controls
{
    public class MyFrame : Frame
    {
       
        public MyFrame()
        {
            base.BorderColor = Color.Orange;
        }

        public static new readonly BindableProperty BorderColorProperty = BindableProperty.Create(
            nameof(BorderColor),
            typeof(Color),
            typeof(MyFrame));

        public new Color BorderColor 
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

        public static new readonly BindableProperty CornerRadiusProperty = BindableProperty.CreateAttached(
            nameof(CornerRadius),
            typeof(float),
            typeof(MyFrame),0f);

        public new float CornerRadius 
        {
            get => (float)GetValue(CornerRadiusProperty); 
            set => SetValue(CornerRadiusProperty, value); 
        }

        public static readonly BindableProperty StrokeProperty = BindableProperty.Create(
            nameof(Stroke),
            typeof(int),
            typeof(MyFrame),0);
        public int Stroke 
        {
            get => (int)GetValue(StrokeProperty);
            set => SetValue(StrokeProperty,value);
        }

    }

}
