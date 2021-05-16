using GemBox.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using StudentEntities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentDataAccessLayer
    {
    public class StudentDAL:IStudentDAL
        {
        private readonly StudentDBContext _studentDBContext;
        public StudentDAL(StudentDBContext studentDB)
            {
            _studentDBContext = studentDB;
            }
        List<Student> students = new List<Student>();
        public async Task<bool> AddStudent(Student student)
            {
            int rows = 0;
            try
                {
                _studentDBContext.Students.Add(student);
                rows = await _studentDBContext.SaveChangesAsync();
                if(rows == 0)
                    {
                    return false;
                    }
                else
                    {
                    return true;
                    }
                }
            catch(Exception ex)
                {
                throw ex;
                }
            }
        public async Task<List<Student>> GetStudents()
            {
            students = await _studentDBContext.Students.ToListAsync();
               SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add("studentdata.xlsx");
            worksheet.Cells[0, 0].Value = "Id";
            worksheet.Cells[0, 1].Value = "Name";
            worksheet.Cells[0, 1].Value = "Address";
            int i = 1;
            foreach(Student details in students)
                {
                int j = 0;
                worksheet.Cells[i, j].Value = details.Id;
                j++;
                worksheet.Cells[i, j].Value = details.Name;
                j++;
                worksheet.Cells[i, j].Value = details.Address;
                j++;
                i++;


                }


            workbook.Save("studentdata.xlsx");


            return students;
            }
        //public async Task StudentsDataToExcel()
        //    {
        //    SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");


        //    }
        }
    }
