using CloneMessage.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CloneMessage.View.Controls
{
    public class ScollView
    {
        private static ScrollView _scrollView;
        private static bool _isScroll = false;
        #region IsScoll
        public static BindableProperty IsScollProperty =
            BindableProperty.CreateAttached
            (
                "IsScoll",
                typeof(bool),
                typeof(ScollView),
                false,
                propertyChanged: OnpropertyChanged
            );

        private static void OnpropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            _scrollView = bindable as ScrollView;
            _isScroll = (bool)newValue;
            SetIsScoll(bindable, (bool)newValue);
        }

        public static bool GetIsScoll(BindableObject bindable)
        {
            return (bool)bindable.GetValue(IsScollProperty);
        }

        public static void SetIsScoll(BindableObject bindable, bool isScoll)
        {
            bindable.SetValue(IsScollProperty, isScoll);
        }
        #endregion

        #region Target Scoll To
        public static BindableProperty TargetScollToProperty =
            BindableProperty.CreateAttached
            (
                "TargetScollTo",
                typeof(string),
                typeof(ScollView),
                string.Empty,
                propertyChanged: OnScollTo
            );

        public static string GetTargetScollTo(BindableObject bindable)
        {
            return (string)bindable.GetValue(TargetScollToProperty);
        }

        public static void SetTargetScollTo(BindableObject bindable, string value)
        {
            bindable.SetValue(TargetScollToProperty, value);
        }
        #endregion

        private static async void OnScollTo(BindableObject bindable, object oldValue, object newValue)
        {
            if(_isScroll)
            {
                double positionY = 0;
                string target = (string)newValue;
                if (_scrollView != null && !string.IsNullOrEmpty(target))
                {
                    var children = VisualTreeHelper.GetChildren<Label>((Element)bindable);
                    if(children != null)
                    {
                        Label currentElement = new Label();
                        foreach (var child in children)
                        {
                            currentElement.Text = child.Text;
                        }
                        

                        await _scrollView.ScrollToAsync(0, positionY, true);
                    }
                }
            }
        }
    }
}
