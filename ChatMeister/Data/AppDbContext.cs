using ChatMeister.Data.Classes;
using ChatMeister.Data.Lists;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMeister.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Chat> chats { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Message> messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;" +
                "port=3306;" +
                "user=root;" +
                "password=;" +
                "database=csd_ChatMeister",
                ServerVersion.Parse("10.4.17-mariadb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Chat)
                .WithMany(c => c.messages)
                .HasForeignKey(m => m.ChatId);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.User)
                .WithMany(u => u.messages)
                .HasForeignKey(m => m.UserId);

            ChatList chatList = new ChatList();
            MessageList messageList = new MessageList();
            UserList userList = new UserList();

            List<Chat> chats = chatList.getChatList();
            List<Message> messages = messageList.GetMessageList();
            List<User> users = userList.GetUserList();

            modelBuilder.Entity<Chat>().HasData(chats.ToArray());
            modelBuilder.Entity<Message>().HasData(messages.ToArray());
            modelBuilder.Entity<User>().HasData(users.ToArray());
        }
    }

}
