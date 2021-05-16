using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment32
    {
    class UserManager
        {
        public static void createUser(User user)
            {
            Console.WriteLine("Enter user id");
            string id = Console.ReadLine();
            int userid = 0;
            try
                {
                userid = Int32.Parse(id);
                }
            catch(Exception ex)
                {
                Console.WriteLine(ex);

                }

            }
        public static void showUserDetails(User user)
            {

            }

        }
    }
