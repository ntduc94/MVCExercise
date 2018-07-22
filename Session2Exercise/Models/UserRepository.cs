using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExerciseMVC01.Models
{
    public class UserRepository
    {
        public List<User> Users { get; set; }

        //public List<User> Retrieve(int username)
        //{

        //}

        public void Save(User user)
        {
            Users.Add(user);
        }
    }
}