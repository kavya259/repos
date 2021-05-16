using System;
using System.Collections.Generic;
using System.Text;

namespace assgt31
{
    class UserManager
    {
        public User createUser(User user)
        {
            Console.WriteLine("Enter user details \n ");
            Console.WriteLine("Enter user Id of atleast 5 characters");

            long userid = Convert.ToInt64(Console.ReadLine());
            string userId = Convert.ToString(userid);
            if (userId.Length < 5)
            {
                throw new InvalidUserIdException("The user id must have atleast 5 characters length ");
            }
            else
            {

                userid = Convert.ToInt64(userId);

            }



            Console.WriteLine("Enter user date of birth  as dd-mm-yyyy format");

            string dob = Console.ReadLine();
            Console.WriteLine("Enter user Name  ");

            string name = Console.ReadLine();
            Console.WriteLine("Enter user gender 'F' for female and 'M' for male  ");
            char gen = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter user password  ");
            string pwd = Console.ReadLine();
            char[] password = pwd.ToCharArray();
            int countNum=0,countLower=0,countUpper=0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] > 64 && password[i] < 91)
                {
                    countUpper++;
                }
                if (password[i] > 96 && password[i] < 123)
                {
                    countLower++;
                }
                if (password[i] >= 0 && password[i] <= 9)
                {
                    countNum++;
                }


            }


            if (pwd.Length < 5 || countUpper < 1 || countLower < 1 || countNum < 1)
            {
                throw new InvalidPasswordException("Password must be atleast 5 characters length and must be a combination of uppercase ,lowercase and numbers ");

            }
            

            User user1 = new User(userid, dob, name, gen, pwd);

            return user1;

        }

        public class InvalidUserIdException : Exception
        {

            public InvalidUserIdException() : base()
            {
            }
            public InvalidUserIdException(string message) : base(message)
            { }

        }
        public class InvalidPasswordException : Exception
        {

            public InvalidPasswordException() : base()
            {
            }
            public InvalidPasswordException(string message) : base(message)
            { }




        }
        public void showUserDetails(User user)
        {

            Console.WriteLine("User id             : " + user.UserId);
            Console.WriteLine("User date of birth  : " + user.DateOfBirth);
            Console.WriteLine("User Name           : " + user.UserName);
            Console.WriteLine("User gender         : " + user.Gender);
            Console.WriteLine("User Password       : " + user.Password);
        

            }

        
    }
}

