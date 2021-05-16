using System;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user= user.createUser(user);
            user.showUserDetails(user);
        }
    }
}
