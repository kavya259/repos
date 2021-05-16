using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel= Microsoft.Office.Interop.Excel;

namespace CollegeManagementSystem
    {
   public class ManagementProcess
        {
        static int collegeId = 1000;
        static int studentId = 1000;
        static int index = 2;
        static string path = @"C:\Users\home\Desktop\exceloperations.xlsx";


        public static void AddCollege()
            {
            try
                {
                Application excel = new _Excel.Application();
                Worksheet ws;
                Workbook wb;
                wb = excel.Workbooks.Open(path);
                ws = excel.Worksheets["sheet1"];

                collegeId++;
                College college = new College();
                college.CollegeId = (string)"C" + collegeId;

                Console.WriteLine("Enter college name");
                college.CollegeName = Console.ReadLine();

                Console.WriteLine("Enter Location");
                college.Location = Console.ReadLine();

                Console.WriteLine("Enter cutoff percentage");
                college.CutOffPercentage = Convert.ToDouble(Console.ReadLine());
                ValidatePercentage(college.CutOffPercentage);

                Console.WriteLine("Enter the number of seats available");
                college.NumberOfSeats = Convert.ToInt32(Console.ReadLine());
                CheckAvailability(college.NumberOfSeats);

                ws.Cells[index, 1].Value2 = college.CollegeId;
                ws.Cells[index, 1].Value2 = college.CollegeName;
                ws.Cells[index, 1].Value2 = college.CutOffPercentage;
                ws.Cells[index, 1].Value2 = college.Location;
                ws.Cells[index, 1].Value2 = college.NumberOfSeats;

                wb.Save();
                wb.Close();
                index++;

                Console.WriteLine("RECORD ADDED SUCCESSFULLY ");


                }
            catch(Exception e)
                {
                Console.WriteLine(e);
                }
            
            }
        private static void CheckAvailability(int numberOfSeats)
            {
            if(numberOfSeats < 0)
                {
                throw new Exception("Initially availability cannot be zero ");
                }

            }
        public static void ValidatePercentage(double percentage)
            {
            if(percentage > 100 || percentage < 0)
                {
                throw new Exception("Percentage should be between 0 and 100");
                }
            }
        public static Dictionary<string, Student> AddStudents(Dictionary<string, Student> students)
            {
            studentId++;
            Student student = new Student();
            student.StudentId = "S"+studentId;

            Application excel = new _Excel.Application();
            Worksheet ws;
            Workbook wb;
            wb = excel.Workbooks.Open(path);
            ws = excel.Worksheets["sheet1"];

            _Excel.Range range = ws.UsedRange;
            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;

            for(int i = 1; i < rowCount; i++)
                {
                for(int j = 1; j < 6; j++)
                    {

                    Console.WriteLine(range.Cells[i, j].Value2 + "\t");

                    }
                }
            wb.Close();

            Console.WriteLine("Enter your name ");
            student.StudentName = Console.ReadLine();

            Console.WriteLine("Enter College Id you want to apply for  ");
            student.StudentId =  Console.ReadLine();

            Console.WriteLine("Enter your Percentage ");
            student.PercentageObtained = Convert.ToDouble(Console.ReadLine());
            ValidatePercentage(student.PercentageObtained);

            College obj = BookCollege(student.PercentageObtained, student.StudentId);
            if(obj == null)
                {
                Console.WriteLine("Unable to proceed request");
                }
            else
                {
                student.College = obj;
                students.Add(student.StudentId, student);
                Console.WriteLine("Successfully Applied for college " + collegeId);
                }

            return students;
            }




        public static void DisplayDetails(IDictionary<string, Student> students)
            {
            Console.WriteLine("Enter college Id");
            string id = Console.ReadLine();
            foreach(KeyValuePair<string, Student> stud in students)
                {
                if(stud.Value.College.CollegeId.Equals(id))
                    {
                    Console.WriteLine(stud.Value.StudentId + "\t" + stud.Value.StudentName + "\t" + stud.Value.PercentageObtained);
                    }

                }


            }
        public static College BookCollege(double percentageObtained, string id)
            {
            Application excel = new _Excel.Application();
            Worksheet ws;
            Workbook wb;
            wb = excel.Workbooks.Open(path);
            ws = excel.Worksheets["sheet1"];

            _Excel.Range range = ws.UsedRange;
            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;

            for(int i = 1; i <= rowCount; i++)
                {
                if(range.Cells[i, 1].Value2.Equals(id) && range.Cells[i, 5].Value2 > 0 && percentageObtained >= range.Cells[i, 3].Value2)
                    {
                    College obj = new College();

                    obj.CollegeId = range.Cells[i, 1].Value2;
                    obj.CollegeName = range.Cells[i, 2].Value2;
                    obj.CutOffPercentage = range.Cells[i, 3].Value2;
                    obj.Location = range.Cells[i, 4].Value2;
                    obj.NumberOfSeats = range.Cells[i, 5].Value2;

                    ws.Cells[i, 5] = obj.NumberOfSeats - 1;
                    wb.Close();
                    return obj;

                    }
                }
            wb.Close();
            return null;

            }


        }
    }
