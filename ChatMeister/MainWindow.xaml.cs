using ChatMeister.Data;
using ChatMeister.Data.Classes;
using ChatMeister.Data.Lists;
using Microsoft.EntityFrameworkCore;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Linq;

namespace ChatMeister
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            ShowChats();
        }

        public void ShowChats()
        {
            using (var db = new AppDbContext())
            {
                var chats = db.chats.Include(chat => chat.messages).ThenInclude(messages => messages.User).ToList();
                chatListView.ItemsSource = chats;
            }
        }

        public void RefreshChatrooms()
        {
            using (var db = new AppDbContext())
            {
                // Reload the chats including the latest messages
                var chats = db.chats.Include(chat => chat.messages).ThenInclude(messages => messages.User).ToList();

                // Update the ItemsSource of chatListView with the refreshed chat data
                chatListView.ItemsSource = null; // Clear existing data binding
                chatListView.ItemsSource = chats; // Set the updated data
            }
        }


        private void chatListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Chat selectedChat = (Chat)e.ClickedItem;

            ChatWindow chatWindow = new ChatWindow(selectedChat, this);
            chatWindow.Activate();
        }
    }
}
