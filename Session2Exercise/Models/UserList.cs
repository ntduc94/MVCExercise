using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExerciseMVC01.Models
{
    public class UserList
    {
        private List<User> Users { get; set; }

        public UserList()
        {
            Users = new List<User> {
                new User { Username = "user 1", Email = "email 1", Phone = "phone 1", Age = 1 },
                new User { Username = "user 2", Email = "email 2", Phone = "phone 2", Age = 2 },
                new User { Username = "user 3", Email = "email 3", Phone = "phone 3", Age = 3 }
            };
        }

        public List<User> Retrieve()
        {
            return Users;
        }

        public void Save(User user)
        {
            Users.Add(user);
        }
    }
}