using CloneMessage.Model;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace CloneMessage
{
    public class MessagePageModel : FreshBasePageModel
    {
        public MessagePageModel()
        {

        }
        public ObservableCollection<MessageModel> Messages { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);
            var messageList = new ObservableCollection<MessageModel>(InitDataMessage());
            foreach (var item in messageList)
            {
                switch (item.Title)
                {
                    case "ThankYou":
                        item.ColorMessage = "#00FF00";
                        break;
                    case "Notification":
                        item.ColorMessage = "#000080";
                        break;
                    case "Welcome":
                        item.ColorMessage = "#800000";
                        break;
                    default:
                        item.ColorMessage = "#2F4F4F";
                        break;
                }
            }
            Messages = messageList;
        }


        private ObservableCollection<MessageModel> InitDataMessage()
        {
            return new ObservableCollection<MessageModel>
            {
                new MessageModel { Title = "ThankYou", Name = "ThankYou", DateTime = DateTime.UtcNow },
                new MessageModel { Title = "Notification", Name = "Notification", DateTime = DateTime.UtcNow },
                new MessageModel { Title = "ThankYou", Name = "ThankYou", DateTime = DateTime.UtcNow },
                new MessageModel { Title = "Notification", Name = "Notification", DateTime = DateTime.UtcNow },
                new MessageModel { Title = "Welcome", Name = "Welcome", DateTime = DateTime.UtcNow },
                new MessageModel { Title = "Notification", Name = "Notification", DateTime = DateTime.UtcNow },
                new MessageModel { Title = "Welcome", Name = "Welcome", DateTime = DateTime.UtcNow },
                new MessageModel { Title = "Notification", Name = "Notification", DateTime = DateTime.UtcNow },
                new MessageModel { Title = "Welcome", Name = "Welcome", DateTime = DateTime.UtcNow },
                new MessageModel { Title = "Notification", Name = "Notification", DateTime = DateTime.UtcNow },
                new MessageModel { Title = "ThankYou", Name = "ThankYou", DateTime = DateTime.UtcNow },
                new MessageModel { Title = "Welcome", Name = "Welcome", DateTime = DateTime.UtcNow }
            };
        }
    }
}
