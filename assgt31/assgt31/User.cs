using System;
using System.Collections.Generic;
using System.Text;

namespace assgt31
{
    class User:UserManager
    {
         long userId;
         string dateOfBirth;
         string userName;
         char gender;
         string password;

        internal void showUserDetails(User user)
        {
            throw new NotImplementedException();
        }

        public User()
        { }

        public User(long userId, string dateOfBirth, string userName, char gender, string password)
        {
            this.UserId = userId;
            this.DateOfBirth = dateOfBirth;
            this.UserName = userName;
            this.Gender = gender;
            this.Password = password;
        }

        public long UserId { get => userId; set => userId = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string UserName { get => userName; set => userName = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Password { get => password; set => password = value; }
    }


}
