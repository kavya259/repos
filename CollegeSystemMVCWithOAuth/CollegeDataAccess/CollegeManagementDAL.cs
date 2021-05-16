using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeEntities;
using CollegeExceptions;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CollegeDataAccess
{
    public class CollegeManagementDAL:ICollegeManagementDAL
    {
        static string connect = ConfigurationManager.ConnectionStrings["Collegeconn"].ConnectionString;
        SqlConnection conn = new SqlConnection(connect);



        //*****************Add student details**********************
        Student student = new Student();

        public Student AddStudentDetailsDAL(Student student)
            {
            conn.Open();

            SqlCommand command = new SqlCommand("AddStudentDetails", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Id", student.Id);
            command.Parameters.AddWithValue("@FirstName", student.FirstName);
            command.Parameters.AddWithValue("@LastName", student.LastName);
            command.Parameters.AddWithValue("@Email ", student.Email);
            command.Parameters.AddWithValue("@Gender", student.Gender);
            command.Parameters.AddWithValue("@BranchId", student.Branchid);
            command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
            command.Parameters.AddWithValue("@Age", student.Age);

            int i = command.ExecuteNonQuery();
            conn.Close();
            //if(i >= 1)
            //    return true;
            //else
            //    return false;
            return student;

            }


        public List<Student> GetAllStudentDetailsDAL()
            {
            List<Student> students = new List<Student>();
            conn.Open();

            SqlCommand command = new SqlCommand("GetAllStudentDetails", conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            sd.Fill(datatable);
            SqlDataReader reader = command.ExecuteReader();
            try
                {

                if(reader.HasRows)
                    {

                    foreach(DataRow row in datatable.Rows)
                        {
                        students.Add(
                            new Student
                                {
                                Id = Convert.ToInt32(row["Id"]),
                                FirstName = Convert.ToString(row["FirstName"]),
                                LastName = Convert.ToString(row["LastName"]),
                                Email = Convert.ToString(row["Email"]),
                                Gender = Convert.ToString(row["Gender"]),
                                Branchid = Convert.ToInt32(row["BranchId"]),
                                DateOfBirth = Convert.ToString(row["DateOfBirth"]),
                                Age = Convert.ToInt32(row["Age"]),
                                });
                        }
                    }
                else
                    {
                    throw new NoDataFoundException("No data rows present");
                    }
                }
            catch(NoDataFoundException)
                {
                throw new NoDataFoundException();
                }
            finally
                {
                conn.Close();
                }

            return students;
            }


        public Student UpdateStudentDetailsDAL(Student student)
            {
            conn.Open();

            SqlCommand command = new SqlCommand("UpdateStudentDetails", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Id", student.Id);
            command.Parameters.AddWithValue("@FirstName", student.FirstName);
            command.Parameters.AddWithValue("@LastName", student.LastName);
            command.Parameters.AddWithValue("@Email ", student.Email);
            command.Parameters.AddWithValue("@Gender", student.Gender);
            command.Parameters.AddWithValue("@BranchId", student.Branchid);
            command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
            command.Parameters.AddWithValue("@Age", student.Age);

            command.ExecuteNonQuery();
            conn.Close();

            return student;

            }

        //*************************************************************************************************************
        //BRANCH


        public Branch AddBranchDetailsDAL(Branch branch)
            {
            SqlCommand command = new SqlCommand("AddBranchDetails", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@BranchId", branch.BranchId);
            command.Parameters.AddWithValue("@BranchName", branch.BranchName);

            conn.Open();
            command.ExecuteNonQuery();
            //  int i = command.ExecuteNonQuery();
            conn.Close();
            //if(i >= 1)
            //    return true;
            //else
            //    return false;
            return branch;

            }


        public List<Branch> GetAllBranchDetailsDAL()
            {
            List<Branch> branches = new List<Branch>();
            conn.Open();

            SqlCommand command = new SqlCommand("GetAllBranchDetails", conn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            sd.Fill(datatable);
            SqlDataReader reader = command.ExecuteReader();

            if(reader.HasRows)
                {

                foreach(DataRow row in datatable.Rows)
                    {
                    branches.Add(
                        new Branch
                            {
                            BranchId = Convert.ToInt32(row["BranchId"]),
                            BranchName = Convert.ToString(row["BranchName"]),

                            });
                    }
                }
            else
                {
                throw new NoDataFoundException("No data rows present");
                }
            conn.Close();


            return branches;


            }


        }

    }

