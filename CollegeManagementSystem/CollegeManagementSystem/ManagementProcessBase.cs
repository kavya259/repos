namespace CollegeManagementSystem
    {
    public class ManagementProcessBase
        {
        public static Dictionary<string, Student> AddStudents(Dictionary<string, Student> students)
            {
            studentId++;
            Student student = new Student();
            student.StudentId = "S" + studentId;

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
            student.StudentId = Console.ReadLine();

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
        }
    }