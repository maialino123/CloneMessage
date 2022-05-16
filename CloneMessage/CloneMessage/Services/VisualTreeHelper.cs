using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace CloneMessage.Services
{
    public static class VisualTreeHelper
    {
        public static T GetParent<T>(this Element element) where T : Element
        {
            if(element is T)
            {
                return element as T;
            }
            else
            {
                if(element.Parent != null)
                    return element.Parent.GetParent<T>();
                return default(T);
            }
        }

        public static IEnumerable<T> GetChildren<T>(this Element element) where T : Element
        {
            var properties = element.GetType().GetRuntimeProperties();

            var contentProperty = properties.FirstOrDefault(x => x.Name.Equals("Content"));
            if(contentProperty != null)
            {
                var content = contentProperty.GetValue(element) as Element;
                if(content != null)
                {
                    if (content is T)
                        yield return content as T;
                    else
                    {
                        foreach (var child in content.GetChildren<T>())
                        {
                            yield return child; 
                        }
                    }
                }
                else
                {
                    var childrenProperty = properties.FirstOrDefault(x => x.Name.Equals("Children"));
                    if(childrenProperty != null)
                    {
                        IEnumerable children = childrenProperty.GetValue(element) as IEnumerable;
                        foreach (var item in children)
                        {
                            var childrenVisualElement = item as Element;
                            if(childrenVisualElement != null)
                            {
                                yield return childrenVisualElement as T;
                            }

                            foreach (var childVisual in childrenVisualElement.GetChildren<T>())
                            {
                                yield return childVisual;
                            }
                        }
                    }
                }
            }
        }
    }
}
