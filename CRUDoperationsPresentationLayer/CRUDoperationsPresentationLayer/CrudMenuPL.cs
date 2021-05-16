using CRUDoperationBusinesslayer;
using Entitity;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDoperationsPresentationLayer
    {
    class CrudMenuPL
        {
        static void Main(string[] args)
            {
          //  bool flag = true;
            int choiceTaken = 0;

            //  CrudMenu menu = new CrudMenu();
            do
                {
                Console.WriteLine("1.Add Students in the Students table");
                Console.WriteLine("2.Update student name and student age based on Student Id");
                Console.WriteLine("3.Retrieve/Display All students");
                Console.WriteLine("4.Retrieve/Display student details based on studentID");
                Console.WriteLine("5.Delete students based on student Id");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter your choice from above categories");
                string choice = Console.ReadLine();
             //   int choiceTaken = 0;
                try
                    {
                     choiceTaken = Convert.ToInt32(choice);
                    }
                catch(Exception e)
                    {
                    Console.WriteLine(e);
                    }
                switch(choiceTaken)
                    {
                    case 1:
                        Console.WriteLine("How many students do you want to add");
                        int count = 0;
                        try
                            {
                            count = Convert.ToInt32(Console.ReadLine());
                            }
                        catch(Exception e)
                            {
                            Console.WriteLine(e);
                            }
                    //    StudentManager studManager = new StudentManager();

                        for(int i = 0; i < count; i++)
                            {
                            TakeInput();
                            }

                        break;
                    case 2:UpdateRecord();
                        break;
                    case 3:StudentManagerBL.DisplayAllStudents();
                        break;

                    case 4:Console.WriteLine("Enter student id");

                        int id = Convert.ToInt32(Console.ReadLine());
                        StudentManagerBL.DisplayBasedOnId(id);
                        break;

                    case 5:Console.WriteLine("Enter student id to delete record");

                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        StudentManagerBL.DeleteRecord(deleteId);
                        break;

                    case 6:Console.WriteLine("Thankyou");
                        break;

                    default:Console.WriteLine("Invalid choice");
                        break;



                    }

                } while(choiceTaken<6);
            Console.ReadKey();
            }
        //  ArrayList students = new ArrayList();
        public static void TakeInput()
            {
            Student student = new Student();

            Console.WriteLine("Enter student Id");
            
            try
                {
                student.StudentId = Convert.ToInt32(Console.ReadLine());
                }
            catch(Exception e)
                {
                Console.WriteLine(e.Message);
                }

            Console.WriteLine("Enter student Name");
           // string name = "";
            try
                {
                student.StudentName = Console.ReadLine();
                }
            catch(Exception e)
                {
                Console.WriteLine(e.Message);
                }
            Console.WriteLine("Enter student Age");
           student.StudentAge = Convert.ToInt32(Console.ReadLine());
            //give custom exception
            Console.WriteLine("Enter student Address");
            student.StudentAddress = Console.ReadLine();


            Console.WriteLine("Enter student Marks");
            student.StudentMarks= Convert.ToInt32(Console.ReadLine());

            //give custom exception
            
            student=new  Student(student.StudentId,student.StudentName,student.StudentAge,student.StudentAddress,student.StudentMarks);
            StudentManagerBL.AddStudent(student);
            Console.WriteLine("RECORD ADDED SUCCESSFULLY");




            }
        public static void UpdateRecord()
            {
            Console.WriteLine("Enter student Id");
            int studentId = Convert.ToInt32(Console.ReadLine());     

            Console.WriteLine("Enter student Name");
            string name = Console.ReadLine();
           
            Console.WriteLine("Enter student Age");
            int age= Convert.ToInt32(Console.ReadLine());

            StudentManagerBL.UpdateRecord(studentId, name, age);


            }


        }
    }
