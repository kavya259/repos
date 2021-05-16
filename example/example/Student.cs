using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
    {
    public class Student:School,ISchool,IComparable<Student>
        {
        public static int Roll = 31;
        public const string stclass="5";
        public int StudentName
            {
            get; set;
            }
        public override string GetDetails()
            {
            return "StudentRoll:" + Roll + "StudentName:" + this.StudentName + "Class:" + stclass;
            }
        public void getMarks()
            {
            Console.WriteLine("enter the math marks");
            int marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("marks " + marks);
            }

        public int CompareTo(Student other)
            {
            if(this.SchoolCode > other.StudentName)
                {
                return 1;
                }
            else if(this.SchoolCode > other.StudentName)
                {
                return -1;
                }
            else
                {
                return 0;
                }


            }
        }
    }
