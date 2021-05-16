using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobileoperations
    {
    class menu
        {
        static void Main(string[] args)
            {
            Console.WriteLine("1.Add mobile operator ");
            Console.WriteLine("2.Display all mobile operators ");
            Console.WriteLine("3.Add Person ");
            Console.WriteLine("4.Display top two operators by rating ");
            Console.WriteLine("5.Search person details withmobile operator using person Id");
            Console.WriteLine("6.Display all persons with id,name,operator name  ");
            Console.WriteLine("Please enter your choice ");
            string choice = Console.ReadLine();
            int takenChoice = 0;
            try
                {
                takenChoice = Int32.Parse(choice);

                }
            catch(Exception e)
                {
                Console.WriteLine(e.Message);
                }
            Process pr = new Process();
            do
                {

                switch(takenChoice)
                    {
                    case 1:pr.AddMobileOperator();
                        break;
                    case 2:pr.displayMobileOperators();
                        break;
                    case 3:pr.AddPerson();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                    }
                } while(takenChoice != 7);




            }
        }
       
        }
