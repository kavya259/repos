using StudentEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentBusinessLayer;

namespace StudentAppCapabilityReviewmvc.Models
    {
    public class ManagerModel
        {
        private readonly IStudentBL studentBL = new StudentBL();
        public Student ModelToEntity(StudentModel studentModel)
            {
            Student student = new Student();
            student.Id = studentModel.Id;
            student.Name = studentModel.Name;
            student.Email = studentModel.Email;
            student.Mobile = studentModel.Mobile;
            student.Grade = studentModel.Grade;
            student.Fee = studentModel.Fee;
            return student;
            }

        public List<StudentModel> GetAllStudents_Model()
            {
            List<Student> students = studentBL.GetAllStudentsBL();
            List<StudentModel> studentsModel = new List<StudentModel>();
            foreach(Student student in students)
                {
               studentsModel.Add(EntityToModel(student));
               }
            return studentsModel;
            }

        public StudentModel EntityToModel(Student student)
            {
            StudentModel studentModel = new StudentModel();
            studentModel.Id = student.Id;
            studentModel.Name = student.Name;
            studentModel.Email = student.Email;
            studentModel.Mobile = student.Mobile;
            studentModel.Grade = student.Grade;
            studentModel.Fee = student.Fee;
            return studentModel;
            }

        }
    }