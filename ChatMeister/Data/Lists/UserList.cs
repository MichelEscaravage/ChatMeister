using ChatMeister.Data.Classes;
using System.Collections.Generic;

namespace ChatMeister.Data.Lists
{
    internal class UserList
    {
        List<User> userList = new List<User>()
        {
            new User { Id = 1, Email = "alice@example.com", UserName = "Alice" },
            new User { Id = 2, Email = "bob@example.com", UserName = "Bob" },
            new User { Id = 3, Email = "carol@example.com", UserName = "Carol" },
            new User { Id = 4, Email = "dave@example.com", UserName = "Dave" },
            new User { Id = 5, Email = "eve@example.com", UserName = "Eve" },
            new User { Id = 6, Email = "frank@example.com", UserName = "Frank" },
            new User { Id = 7, Email = "grace@example.com", UserName = "Grace" },
            new User { Id = 8, Email = "hank@example.com", UserName = "Hank" },
            new User { Id = 9, Email = "irene@example.com", UserName = "Irene" },
            new User { Id = 10, Email = "jack@example.com", UserName = "Jack" },
            new User { Id = 11, Email = "kate@example.com", UserName = "Kate" },
            new User { Id = 12, Email = "leo@example.com", UserName = "Leo" },
            new User { Id = 13, Email = "mona@example.com", UserName = "Mona" },
            new User { Id = 14, Email = "nina@example.com", UserName = "Nina" },
            new User { Id = 15, Email = "oliver@example.com", UserName = "Oliver" },
            new User { Id = 16, Email = "paul@example.com", UserName = "Paul" },
            new User { Id = 17, Email = "quinn@example.com", UserName = "Quinn" },
            new User { Id = 18, Email = "rachel@example.com", UserName = "Rachel" },
            new User { Id = 19, Email = "sam@example.com", UserName = "Sam" },
            new User { Id = 20, Email = "tina@example.com", UserName = "Tina" }
        };

        public List<User> GetUserList()
        {
            return userList;
        }
    }
}
