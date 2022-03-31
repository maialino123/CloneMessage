using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CloneMessage.Model
{
    public class MessageModel
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public string ColorMessage { get; set; }
    }
}
