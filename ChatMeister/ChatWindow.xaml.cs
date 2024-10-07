using Microsoft.UI.Xaml;
using ChatMeister.Data.Classes;
using System;
using System.Linq;
using ChatMeister.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ChatMeister
{
    public sealed partial class ChatWindow : Window
    {
        internal Chat Chat { get; set; }
        private MainWindow MainWindow { get; set; }
        internal ChatWindow(Chat chat, MainWindow mainWindow)
        {
            this.InitializeComponent();

            Chat = chat;
            MainWindow = mainWindow;

            ShowMessages();
        }

        private void ShowMessages()
        {
            using (var db = new AppDbContext())
            {
                messageListView.ItemsSource = Chat.messages;
            }
        }

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            if (chatBox.Text.Count() > 0)
            {
                DateTime clickedTime = DateTime.Now;
                int chatId = Chat.Id;
                string message = chatBox.Text;
                Message newMessage = new Message(chatId, 1, message, clickedTime);

                Chat.messages.Add(newMessage);
                SaveMessage(newMessage);

                chatBox.Text = "";

                messageListView.ScrollIntoView(newMessage);

            }
        }

        private void SaveMessage(Message message)
        {
            using (var db = new AppDbContext())
            {
                // Set the user for the new message
                message.User = db.users.Find(message.UserId);

                // Add the message to the database and save changes
                db.messages.Add(message);
                db.SaveChanges();
            }
                MainWindow.RefreshChatrooms();
            
        }
    }
}
