using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CollegeManagementEntities;
using CollegeManagementBusinesslayer;
using CollegeManagementExceptions;


namespace CollegeManagemetSystem.WebApplication.Models
    {
    public class ManagerModel
        {

        CollegeManagementBL collegeManagementBL = new CollegeManagementBL();

        //****************************************************************************************************************************
        public void AddStudentDetailsManagerModel(StudentModel studentModel)
            {
            Student student = new Student();

            student.Id = studentModel.ID;
            student.FirstName = studentModel.FirstName;
            student.LastName = studentModel.LastName;
            student.Email = studentModel.Email;
            student.Age = studentModel.Age;
            student.Branchid = studentModel.Branchid;
            student.DateOfBirth = studentModel.DateOfBirth;
            student.Gender = studentModel.Gender;

            collegeManagementBL.AddStudentDetailsBL(student);
                            
            }
//***********************************************************************************************************************
        public List<StudentModel> GetAllStudentDetailsManagerModel()
            {
            List<Student> studentdetails = collegeManagementBL.GetAllStudentDetailsBL();
            List<StudentModel> studentModels = new List<StudentModel>();
            foreach(Student student in studentdetails)
                {
                studentModels.Add(StudentToStudentModel(student));
                }

            return studentModels;

            }

        private StudentModel StudentToStudentModel(Student student)
            {
            StudentModel studentModel = new StudentModel();
            studentModel.ID = student.Id;
            studentModel.Email = student.Email;
            studentModel.Age = student.Age;
            studentModel.Branchid = student.Branchid;
            studentModel.DateOfBirth = student.DateOfBirth;
            studentModel.Gender = student.Gender;
            studentModel.FirstName = student.FirstName;
            studentModel.LastName = student.LastName;

            return studentModel;
            }

        //**************************************************************************************************************************

        public void UpdateStudentDetailsManagerModel(StudentModel studentModel)//Change if any execution is not proper 
            {
           // List<Student> studentdetails = collegeManagementBL.GetAllStudentDetailsBL();

            Student student = new Student();


                    student.Id = studentModel.ID;
                    student.FirstName = studentModel.FirstName;
                    student.LastName = studentModel.LastName;
                    student.Email = studentModel.Email;                                     //interchange model and entity
                    student.Age = studentModel.Age;
                    student.Branchid = studentModel.Branchid;
                    student.DateOfBirth = studentModel.DateOfBirth;
                    student.Gender = studentModel.Gender;
            collegeManagementBL.UpdateStudentDetailsBL(student);



            
            }

        //public StudentModel GetStudentAge(int studentid)
        //    {

        //    }

        //************************************************************************************************************************

        Branch branch = new Branch();
        public Branch AddBranchDetailsManagerModel(BranchModel branchModel)
            {
            branch.BranchId = branchModel.BranchId;
            branch.BranchName = branchModel.BranchName;


            return collegeManagementBL.AddBranchDetailsBL(branch);

            }

        public List<BranchModel> GetAllBranchDetailsManagerModel()
            {
            List<Branch> branchdetails = collegeManagementBL.GetAllBranchDetailsBL();
            List<BranchModel> branchModels = new List<BranchModel>();
            foreach(Branch branch in branchdetails)
                {
                branchModels.Add(BranchToBranchModel(branch));
                
                }

            return branchModels;

            }


        public BranchModel BranchToBranchModel(Branch branch)
            {
            BranchModel branchModel = new BranchModel();
            branchModel.BranchId = branch.BranchId;
            branchModel.BranchName = branch.BranchName;

            return branchModel;
            }



        }
    }