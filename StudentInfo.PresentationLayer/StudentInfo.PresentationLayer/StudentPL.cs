using System;
using StudentInfo.BusinessLayer;
using StudentInfo.Entities;
using StudentInfo.CustomExceptionLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.PresentationLayer
    {
    public class StudentPL
        {
        List<Student> students = new List<Student>();
        List<Branch> branches = new List<Branch>();
                    Branch branch = new Branch();

        static void Main(string[] args)
            {
            Branch branch = new Branch();

            int choiceTaken =0;

            do
                {
                Console.WriteLine("1.Add Branches ");
                Console.WriteLine("2.Display branches ");
                Console.WriteLine("3.Add student ");
                Console.WriteLine("4.Display list of branches having maximum number of sudents");
                Console.WriteLine("5.Display all students ");
                string choice = Console.ReadLine();
                try
                    {
                    choiceTaken = Convert.ToInt32(choice);
                    }
                catch(FormatException e)
                    {
                    Console.WriteLine(e.Message);
                    }
                catch(ArgumentNullException e)
                    {
                    Console.WriteLine(e.Message);

                    }
                catch(Exception e)
                    {
                    Console.WriteLine(e.Message);

                    }

                switch(choiceTaken)
                    {
                    case 1:AddBranchPL();
                        break;
                    case 2:StudentBL.DisplayBranchesBL();
                        break;
                    case 3:AddStudentPL();
                        break;
                    case 4:StudentBL.DisplayBranchesOfMaximumStudentsBL();
                        break;
                    case 5:
                        break;

                    }


                } while(choiceTaken < 6);

            

            }

        private static void AddStudentPL()
            {
            Student student = new Student();
            Console.WriteLine("Enter student id");

            student.StudentId = int.Parse(Console.ReadLine());            
            Console.WriteLine("Enter student Name");
            student.StudentName = Console.ReadLine();
            Console.WriteLine("Enter Branch id");

            StudentBL.AddStudentBL(student);

            }

        public  static void AddBranchPL()
            {
            Branch branch = new Branch();
            Console.WriteLine("Enter branch id");
            branch.BranchId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter branch Name");
            branch.BranchName = Console.ReadLine();
            StudentBL.AddBranchBL(branch);

            }

       
        }
    }
