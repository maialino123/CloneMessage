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

        //Using Bindable Create Intance
        public static new readonly BindableProperty BorderColorProperty = BindableProperty.Create(
            nameof(BorderColor),
            typeof(Color),
            typeof(MyFrame));

        public new Color BorderColor 
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

        //Using Bindable Create Attached
        public static readonly BindableProperty HasCornerRadiusProperty = BindableProperty.CreateAttached(
            "HasCornerRadius",
            typeof(float),
            typeof(MyFrame),
            0f);

        public static void SetHasCornerRadiusProperty(BindableObject view, float hasCornerRadius)
        {
            view.SetValue(HasCornerRadiusProperty, hasCornerRadius);
        }

        public static float GetHasCornerRadiusProperty(BindableObject view)
        {
            return (float)view.GetValue(HasCornerRadiusProperty);
        }
    }
}
