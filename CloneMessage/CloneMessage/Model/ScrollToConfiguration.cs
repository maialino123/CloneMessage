using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CloneMessage.Model
{
    public class ScrollToConfiguration
    {
        public bool Animated { get; set; }
        public ScrollToPosition ScrollToPosition { get; set; } = ScrollToPosition.Center;
    }
}
