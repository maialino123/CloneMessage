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
        private static StackLayout _stackLayout;
        private static bool _isScroll = false;
        private static string _TargetScrollTo;
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
                propertyChanged: OnTargetScorllToChanged
            );

        private static void OnTargetScorllToChanged(BindableObject bindable, object oldValue, object newValue)
        {
            _stackLayout = bindable as StackLayout;
            _TargetScrollTo = (string)newValue;
        }

        public static string GetTargetScollTo(BindableObject bindable)
        {
            return (string)bindable.GetValue(TargetScollToProperty);
        }

        public static void SetTargetScollTo(BindableObject bindable, string value)
        {
            bindable.SetValue(TargetScollToProperty, value);
        }
        #endregion

        #region Target To
        public static BindableProperty TargetToProperty =
            BindableProperty.CreateAttached
            (
                "TargetTo",
                typeof(string),
                typeof(ScollView),
                string.Empty,
                propertyChanged: OnScollTo
            );

        public static string GetTargetTo(BindableObject bindable)
        {
            return (string)bindable.GetValue(TargetToProperty);
        }

        public static void SetTargetTo(BindableObject bindable, string value)
        {
            bindable.SetValue(TargetToProperty, value);
        }
        #endregion

        private static async void OnScollTo(BindableObject bindable, object oldValue, object newValue)
        {
            if(_isScroll)
            {
                double positionY = 0;
                string target = (string)newValue;
                if(_TargetScrollTo.Equals(target))
                {
                    if (_scrollView != null && !string.IsNullOrEmpty(target))
                    {
                        _stackLayout = bindable as StackLayout;
                        positionY = _stackLayout.Y;
                        await _scrollView.ScrollToAsync(0, positionY, true);
                    }
                }
            }
        }
    }
}
