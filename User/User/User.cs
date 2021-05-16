using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    class User: UserManager
    {
        private int userId;
        private string dateOfBirth;
        private string userName;
        private char gender;
        private string guardianName;

        public User()
        { }

        public User(int userId, string dateOfBirth, string userName, char gender, string guardianName)
        {
            this.UserId = userId;
            this.DateOfBirth = dateOfBirth;
            this.UserName = userName;
            this.Gender = gender;
            this.GuardianName = guardianName;
        }

        public int UserId { get => userId; set => userId = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string UserName { get => userName; set => userName = value; }
        public char Gender { get => gender; set => gender = value; }
        public string GuardianName { get => guardianName; set => guardianName = value; }
    }
}
