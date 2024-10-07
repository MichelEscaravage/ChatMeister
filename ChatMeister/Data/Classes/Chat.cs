using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMeister.Data.Classes
{
    internal class Chat
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ObservableCollection<Message> messages { get; set; }
        public Message Message { get { return messages.Last(); } }

        public Chat(int id, string name) 
        {
            Id = id;
            Name = name;

            messages = new ObservableCollection<Message>();
        }
    }
}
    