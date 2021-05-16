using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    class UserManager
    {

      /*  private int userId;
        private string dateOfBirth;
        private string userName;
        private char gender;
        private string guardianNmae;
      */

        public User createUser(User user)
        {
            Console.WriteLine("Enter user details \n ");
            Console.WriteLine("Enter user Id ");

            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter user date of birth  as dd-mm-yyyy format");

            string dob = Console.ReadLine();
            Console.WriteLine("Enter user Name  ");

            string name = Console.ReadLine();
            Console.WriteLine("Enter user gender 'F' for female and 'M' for male  ");
            char gen = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter user guardian name  ");
            string gname = Console.ReadLine();  
            User user1=new User(id, dob, name, gen, gname);

            return user1;

        }

        public void showUserDetails(User user)
        {

            Console.WriteLine("User id             : "+user.UserId);
            Console.WriteLine("User date of birth  : " + user.DateOfBirth);
            Console.WriteLine("User Name           : " + user.UserName);
            Console.WriteLine("User gender         : " + user.Gender);
            Console.WriteLine("User guardian name  : " + user.GuardianName);

        }



    }
}
