using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagementSystem
    {
    class CollegeManagement
        {
        static Dictionary<string, Student> students = new Dictionary<string, Student>();
        public static void LoginPage()
            {

            try
                {

                Console.WriteLine("Enter your choice from below ");
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                if(option == 1)
                    {
                    Console.Write("Enter User Id :");
                    string userId = Console.ReadLine();
                    Console.WriteLine("Enter Password :");
                    string password = Console.ReadLine();
                    if(userId.Equals("admin") && password.Equals("admin"))
                        {
                        AdminPage();

                        }
                    else if(userId.Equals("student") && password.Equals("student"))
                        {
                        StudentPage();

                        }
                    else
                        {
                        Console.WriteLine("Invalid userId or password");
                        }
                    }
                else if(option == 2)
                    {
                    Console.WriteLine("Thank you ");
                    System.Environment.Exit(1);

                    }
                else
                    {
                    Console.WriteLine("Option not available , invalid choice");
                    }

                }
            catch(Exception e)
                {
                Console.WriteLine(e);
                }

            }
        public static void AdminPage()
            {
            try
                {
                Console.WriteLine("1.Add College ");
                Console.WriteLine("2.Display students details with  CollegeId ");
                Console.WriteLine("Go to Login page");
                Console.WriteLine("Enter your choice ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                    {
                    case 1:
                        bool count = true;
                        do
                            {
                            ManagementProcess.AddCollege();
                            Console.WriteLine("Want to add one more college?(y/n) :");
                            char c = Convert.ToChar(Console.ReadLine());
                            if(c == 'y')
                                {
                                count = true;
                                }
                            else
                                {
                                count = false;
                                }

                            } while(count);
                        AdminPage();
                        break;
                    case 2:
                        ManagementProcess.DisplayDetails(students);
                        AdminPage();
                        break;
                    case 3:
                        LoginPage();
                        break;
                    default:
                        Console.WriteLine("Invalid choice ");
                        AdminPage();
                        break;
                    }
                }
            catch(Exception e)
                {
                Console.WriteLine(e);
                }
                


            }
        public static void StudentPage()
            {
            try
                {
                students = AddStudents(students);
                LoginPage();
                }
            catch(Exception e)
                {
                Console.WriteLine(e);
                }
            }

        private static Dictionary<string, Student> AddStudents(Dictionary<string, Student> students)
            {
            throw new NotImplementedException();
            }
        }

            }
        
    
