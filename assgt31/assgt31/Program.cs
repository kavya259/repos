using System;

namespace assgt31
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            try
            {
               user= user.createUser(user);

            }
            catch(User.InvalidUserIdException e){
                Console.WriteLine(e.Message);

            
            }
           
            catch (User.InvalidPasswordException e)
            {
                Console.WriteLine(e.Message);


            }

            user.showUserDetails(user);
        }
    }
}
