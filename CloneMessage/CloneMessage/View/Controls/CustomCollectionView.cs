using CloneMessage.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CloneMessage.View.Controls
{
    public class CustomCollectionView : CollectionView
    {
        public static BindableProperty ScrollToItemConfigProperty =
            BindableProperty.Create
            (
                nameof(ScrollToItemConfig),
                typeof(IConfigurableScrollItem),
                typeof(CustomCollectionView),
                default(IConfigurableScrollItem),
                BindingMode.Default,
                propertyChanged: OnScrollTo
             );

        public IConfigurableScrollItem ScrollToItemConfig 
        {
            get => (IConfigurableScrollItem)GetValue(ScrollToItemConfigProperty); 
            set => SetValue(ScrollToItemConfigProperty, value); 
        }

        private static void OnScrollTo(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue == null) return;
            if(bindable is CustomCollectionView current)
            {
                if(newValue is IGroupScrollItem scrollToViewWithGroup)
                {
                    if(scrollToViewWithGroup.config == null)
                        scrollToViewWithGroup.config = new ScrollToConfiguration();

                    current.ScrollTo(scrollToViewWithGroup,
                        scrollToViewWithGroup.GroupValue,
                        scrollToViewWithGroup.config.ScrollToPosition,
                        scrollToViewWithGroup.config.Animated);
                }
                else if(newValue is IScrollItem scrollItem)
                {
                    if(scrollItem.config == null)
                        scrollItem.config = new ScrollToConfiguration();

                    current.ScrollTo(scrollItem, null,
                        scrollItem.config.ScrollToPosition,
                        scrollItem.config.Animated);
                }
            }
        }
    }

    public interface IConfigurableScrollItem
    {
        ScrollToConfiguration config { get; set; }
    }

    public interface IScrollItem : IConfigurableScrollItem
    {
    }
    public interface IGroupScrollItem : IConfigurableScrollItem
    {
        object GroupValue { get; set; }
    }
}
