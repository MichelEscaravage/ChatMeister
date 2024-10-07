using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMeister.Data.Classes
{
    internal class Message
    {
        public int Id { get; set; }
        public int ChatId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime SentAt { get; set; }

        public Chat Chat { get; set; }
        public User User { get; set; }

        public Message(int id, int chatId, int userId, string content, DateTime sentAt)
        {
            Id = id;
            ChatId = chatId;
            UserId = userId;
            Content = content;
            SentAt = sentAt;
        }
        public Message(int chatId, int userId, string content, DateTime sentAt)
        {
            ChatId = chatId;
            UserId = userId;
            Content = content;
            SentAt = sentAt;
        }
    }


}
