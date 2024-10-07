using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatMeister.Data.Classes;

namespace ChatMeister.Data.Lists
{
    internal class ChatList
    {
        List<Chat> chatList = new List<Chat>()
        {
            new Chat (1,"Chatroom 1"),
            new Chat (2, "Chatroom 2"),
            new Chat (3, "Chatroom 3")
        };

        public List<Chat> getChatList()
        {
            return chatList;
        }
    }
}
