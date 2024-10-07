﻿// <auto-generated />
using System;
using ChatMeister.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChatMeister.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240918124807_add tes")]
    partial class addtes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ChatMeister.Data.Classes.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("chats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Chatroom 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Chatroom 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Chatroom 3"
                        });
                });

            modelBuilder.Entity("ChatMeister.Data.Classes.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ChatId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("UserId");

                    b.ToTable("messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChatId = 1,
                            Content = "Hello, everyone!",
                            SentAt = new DateTime(2024, 9, 15, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ChatId = 1,
                            Content = "Hey, Alice!",
                            SentAt = new DateTime(2024, 9, 15, 8, 5, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            ChatId = 2,
                            Content = "We're doing great!",
                            SentAt = new DateTime(2024, 9, 15, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            ChatId = 1,
                            Content = "What's up?",
                            SentAt = new DateTime(2024, 9, 15, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 5,
                            ChatId = 1,
                            Content = "Can we meet later?",
                            SentAt = new DateTime(2024, 9, 15, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 4
                        },
                        new
                        {
                            Id = 6,
                            ChatId = 2,
                            Content = "I love this project!",
                            SentAt = new DateTime(2024, 9, 15, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 7,
                            ChatId = 2,
                            Content = "Let’s catch up tomorrow.",
                            SentAt = new DateTime(2024, 9, 15, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 8,
                            ChatId = 3,
                            Content = "Did anyone see the news?",
                            SentAt = new DateTime(2024, 9, 16, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 9,
                            ChatId = 3,
                            Content = "Yes, crazy stuff happening!",
                            SentAt = new DateTime(2024, 9, 16, 8, 45, 0, 0, DateTimeKind.Unspecified),
                            UserId = 5
                        },
                        new
                        {
                            Id = 10,
                            ChatId = 1,
                            Content = "I’ll send the report tonight.",
                            SentAt = new DateTime(2024, 9, 16, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 11,
                            ChatId = 1,
                            Content = "That sounds perfect.",
                            SentAt = new DateTime(2024, 9, 16, 18, 15, 0, 0, DateTimeKind.Unspecified),
                            UserId = 4
                        },
                        new
                        {
                            Id = 12,
                            ChatId = 3,
                            Content = "How’s the new game going?",
                            SentAt = new DateTime(2024, 9, 17, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            UserId = 2
                        },
                        new
                        {
                            Id = 13,
                            ChatId = 2,
                            Content = "I need some help with this task.",
                            SentAt = new DateTime(2024, 9, 17, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 5
                        },
                        new
                        {
                            Id = 14,
                            ChatId = 2,
                            Content = "Count me in!",
                            SentAt = new DateTime(2024, 9, 17, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 15,
                            ChatId = 1,
                            Content = "Let’s discuss this tomorrow.",
                            SentAt = new DateTime(2024, 9, 17, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 16,
                            ChatId = 3,
                            Content = "I’ll be late to the meeting.",
                            SentAt = new DateTime(2024, 9, 17, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 4
                        },
                        new
                        {
                            Id = 17,
                            ChatId = 2,
                            Content = "Can someone review this?",
                            SentAt = new DateTime(2024, 9, 17, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 1
                        },
                        new
                        {
                            Id = 18,
                            ChatId = 1,
                            Content = "I’ll share the details in the doc.",
                            SentAt = new DateTime(2024, 9, 17, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 5
                        },
                        new
                        {
                            Id = 19,
                            ChatId = 3,
                            Content = "Can’t wait for the weekend!",
                            SentAt = new DateTime(2024, 9, 20, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 3
                        },
                        new
                        {
                            Id = 20,
                            ChatId = 2,
                            Content = "This is so exciting!",
                            SentAt = new DateTime(2024, 9, 20, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = 4
                        });
                });

            modelBuilder.Entity("ChatMeister.Data.Classes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "alice@example.com",
                            UserName = "Alice"
                        },
                        new
                        {
                            Id = 2,
                            Email = "bob@example.com",
                            UserName = "Bob"
                        },
                        new
                        {
                            Id = 3,
                            Email = "carol@example.com",
                            UserName = "Carol"
                        },
                        new
                        {
                            Id = 4,
                            Email = "dave@example.com",
                            UserName = "Dave"
                        },
                        new
                        {
                            Id = 5,
                            Email = "eve@example.com",
                            UserName = "Eve"
                        },
                        new
                        {
                            Id = 6,
                            Email = "frank@example.com",
                            UserName = "Frank"
                        },
                        new
                        {
                            Id = 7,
                            Email = "grace@example.com",
                            UserName = "Grace"
                        },
                        new
                        {
                            Id = 8,
                            Email = "hank@example.com",
                            UserName = "Hank"
                        },
                        new
                        {
                            Id = 9,
                            Email = "irene@example.com",
                            UserName = "Irene"
                        },
                        new
                        {
                            Id = 10,
                            Email = "jack@example.com",
                            UserName = "Jack"
                        },
                        new
                        {
                            Id = 11,
                            Email = "kate@example.com",
                            UserName = "Kate"
                        },
                        new
                        {
                            Id = 12,
                            Email = "leo@example.com",
                            UserName = "Leo"
                        },
                        new
                        {
                            Id = 13,
                            Email = "mona@example.com",
                            UserName = "Mona"
                        },
                        new
                        {
                            Id = 14,
                            Email = "nina@example.com",
                            UserName = "Nina"
                        },
                        new
                        {
                            Id = 15,
                            Email = "oliver@example.com",
                            UserName = "Oliver"
                        },
                        new
                        {
                            Id = 16,
                            Email = "paul@example.com",
                            UserName = "Paul"
                        },
                        new
                        {
                            Id = 17,
                            Email = "quinn@example.com",
                            UserName = "Quinn"
                        },
                        new
                        {
                            Id = 18,
                            Email = "rachel@example.com",
                            UserName = "Rachel"
                        },
                        new
                        {
                            Id = 19,
                            Email = "sam@example.com",
                            UserName = "Sam"
                        },
                        new
                        {
                            Id = 20,
                            Email = "tina@example.com",
                            UserName = "Tina"
                        });
                });

            modelBuilder.Entity("ChatMeister.Data.Classes.Message", b =>
                {
                    b.HasOne("ChatMeister.Data.Classes.Chat", "Chat")
                        .WithMany("messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChatMeister.Data.Classes.User", "User")
                        .WithMany("messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ChatMeister.Data.Classes.Chat", b =>
                {
                    b.Navigation("messages");
                });

            modelBuilder.Entity("ChatMeister.Data.Classes.User", b =>
                {
                    b.Navigation("messages");
                });
#pragma warning restore 612, 618
        }
    }
}
