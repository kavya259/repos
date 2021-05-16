using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
    {
    class Program
        {
        static void Main(string[] args)
            {
            Student student = new Student();
            student.GetDetails();
            List<Student> students=new List<Student>();
            students.Add(new Student() {SchoolCode=1,SchoolName="",StudentName=1});
            students.Add(new Student() { SchoolCode =2, SchoolName = "" });
           // students.Sort();
            foreach(Student student1 in students)
                {
                Console.WriteLine(student1.GetDetails());
                }
            Console.ReadKey();

            student.getMarks();

            }
        }
    }
