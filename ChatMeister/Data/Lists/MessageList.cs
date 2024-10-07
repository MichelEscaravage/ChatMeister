using ChatMeister.Data.Classes;
using System;
using System.Collections.Generic;

namespace ChatMeister.Data.Lists
{
    internal class MessageList
    {
        List<Message> messageList = new List<Message>()
        {
            new Message(1, 1, 1, "Hello, everyone!", DateTime.Parse("2024-09-15T08:00:00")),
            new Message(2, 1, 2, "Hey, Alice!", DateTime.Parse("2024-09-15T08:05:00")),
            new Message(3, 2, 1, "We're doing great!", DateTime.Parse("2024-09-15T09:00:00")),
            new Message(4, 1, 3, "What's up?", DateTime.Parse("2024-09-15T09:15:00")),
            new Message(5, 1, 4, "Can we meet later?", DateTime.Parse("2024-09-15T10:00:00")),
            new Message(6, 2, 2, "I love this project!", DateTime.Parse("2024-09-15T11:00:00")),
            new Message(7, 2, 3, "Let’s catch up tomorrow.", DateTime.Parse("2024-09-15T11:30:00")),
            new Message(8, 3, 1, "Did anyone see the news?", DateTime.Parse("2024-09-16T08:00:00")),
            new Message(9, 3, 5, "Yes, crazy stuff happening!", DateTime.Parse("2024-09-16T08:45:00")),
            new Message(10, 1, 2, "I’ll send the report tonight.", DateTime.Parse("2024-09-16T18:00:00")),
            new Message(11, 1, 4, "That sounds perfect.", DateTime.Parse("2024-09-16T18:15:00")),
            new Message(12, 3, 2, "How’s the new game going?", DateTime.Parse("2024-09-17T08:30:00")),
            new Message(13, 2, 5, "I need some help with this task.", DateTime.Parse("2024-09-17T09:00:00")),
            new Message(14, 2, 3, "Count me in!", DateTime.Parse("2024-09-17T10:00:00")),
            new Message(15, 1, 1, "Let’s discuss this tomorrow.", DateTime.Parse("2024-09-17T10:30:00")),
            new Message(16, 3, 4, "I’ll be late to the meeting.", DateTime.Parse("2024-09-17T12:00:00")),
            new Message(17, 2, 1, "Can someone review this?", DateTime.Parse("2024-09-17T13:00:00")),
            new Message(18, 1, 5, "I’ll share the details in the doc.", DateTime.Parse("2024-09-17T14:00:00")),
            new Message(19, 3, 3, "Can’t wait for the weekend!", DateTime.Parse("2024-09-20T08:00:00")),
            new Message(20, 2, 4, "This is so exciting!", DateTime.Parse("2024-09-20T09:00:00")),
        };

        public List<Message> GetMessageList()
        {
            return messageList;
        }
    }
}
