using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitity
{
    public class Student
    {
        public Student()
            {
            }

        public Student(int studentId, string studentName, int studentAge, string studentAddress, int studentMarks)
            {
            StudentId = studentId;
            StudentName = studentName;
            StudentAge = studentAge;
            StudentAddress = studentAddress;
            StudentMarks = studentMarks;
            }

        public int StudentId
            {
            get;set;
            }
        public string StudentName
            {
            get; set;
            }
        public int StudentAge
            {
            get; set;
            }
        public string StudentAddress
            {
            get; set;
            }
        public int StudentMarks
            {
            get; set;
            }
      //  public static string ConnectString()
        //    {

          //  return "Data Source = DESKTOP - TEJJIDI; Initial Catalog = crudoperations; Integrated Security = True";
            //}
        }
}
