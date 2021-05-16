using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using StudentEntities;
using System.Data;

namespace StudentDataAccessLayer
{
    public class StudentDAL:IStudentDAL
    {
        static string connect = ConfigurationManager.ConnectionStrings["review"].ConnectionString;
        SqlConnection connection = new SqlConnection(connect);
        List<Student> students = new List<Student>();

        public Student AddStudentDAL(Student student)
            {
            try
                {

                connection.Open();
                SqlCommand command = new SqlCommand("AddStudent", connection);
                command.CommandType = CommandType.StoredProcedure;
                //   command.Parameters.AddWithValue("@Id", student.Id);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Mobile", student.Mobile);
                command.Parameters.AddWithValue("@Email", student.Email);
                command.Parameters.AddWithValue("@Grade", student.Grade);
                command.Parameters.AddWithValue("@Fee", student.Fee);

                command.ExecuteNonQuery();
                return student;

                }
            catch(NullReferenceException ex)
                {
                throw new NullReferenceException("null values", ex);
                }
            catch(FormatException ex)
                {
                throw new FormatException("chexk the datatypes", ex);
                }
            catch(Exception ex)
                {
                throw new Exception("server error occures", ex);
                }
            finally
                {
                connection.Close();
                }
            }


            public List<Student> GetAllStudentsDAL()
                {
                try
                    {

                    connection.Open();
                    SqlCommand command = new SqlCommand("GetAllStudents", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sd = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    sd.Fill(dataTable);
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.HasRows)
                        {
                        foreach(DataRow row in dataTable.Rows)
                            {
                            students.Add(new Student
                                {
                                Id = Convert.ToInt32(row["Id"]),
                                Name = Convert.ToString(row["Name"]),
                                Mobile = Convert.ToString(row["Mobile"]),
                                Email = Convert.ToString(row["Email"]),
                                Grade = Convert.ToChar(row["Grade"]),
                                Fee = Convert.ToInt32(row["Fee"])

                                });
                            }

                        }

                    return students;

                    }
                catch(NullReferenceException ex)
                    {
                    throw new NullReferenceException("null values", ex);
                    }
                catch(FormatException ex)
                    {
                    throw new FormatException("chexk the datatypes", ex);
                    }
                catch(Exception ex)
                    {
                    throw new Exception("server error occures", ex);
                    }
                finally
                    {
                    connection.Close();
                    }



                }

            }
}
