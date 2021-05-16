using StudentInfo.Entities;
using System;
using StudentInfo.CustomExceptionLayer;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StudentInfo.DataAccessLayer
{
    public class StudentDAL
        {
        static SqlConnection conn = new SqlConnection();
        public static void AddBranchDAL(Branch branch)
            {
            conn.ConnectionString = "Data Source=DESKTOP-TEJJIDI;Initial Catalog=SchoolInfo;Integrated Security=True";
            try
                {

                string query = "insert into Branch values('" + branch.BranchId + "','" + branch.BranchName + " ')";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.ExecuteNonQuery();
                throw new SqlServerException("Server error occured");
                }
          
            finally {
                conn.Close();

                }
            }

        public static void DisplayBranchesOfMaximumStudentsDAL()
            {
            DataTable table = new DataTable();
            try
                {

                string query = "select Student.BranchName,max(count(StudentId)) from Student inner join Branch on Student.BranchId = Branch.BranchId; ";
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                //  SqlDataAdapter cmd = new SqlDataAdapter(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                    {
                    while(reader.Read())
                        {
                        Console.WriteLine(reader[0] + "\t" + reader[1]);
                        }
                    }
                else
                    {
                    throw new NoRowsPresentException("rows dont have data");
                    }


                throw new SqlServerException("Server error occured");
                }

            finally
                {
                conn.Close();

                }




            }

        public static void AddStudentDAL(Student student)
            {
            conn.ConnectionString = "Data Source=DESKTOP-TEJJIDI;Initial Catalog=SchoolInfo;Integrated Security=True";
            try
                {

                string query = "insert into Student values('" + student.StudentId + "','" + student.StudentName + "','" + student.BranchId + " ')";
                SqlCommand command = new SqlCommand(query, conn);
                conn.Open();
                command.ExecuteNonQuery();
                throw new SqlServerException("Server error occured");
                }
            
            catch(Exception)
                {
                }
            finally
                {
                conn.Close();

                }
            }

        public static void DisplayBranchesDAL()
            {
            DataTable table = new DataTable();
            try
                {

                string query = "select* from Branch";
                conn.Open();

                SqlDataAdapter cmd = new SqlDataAdapter(query,conn);
                cmd.Fill(table);


                throw new SqlServerException("Server error occured");
                }

            finally {
                conn.Close();

                }




            }
        }
    }
