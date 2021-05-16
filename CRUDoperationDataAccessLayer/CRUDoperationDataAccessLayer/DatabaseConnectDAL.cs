using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entitity;
using System.Configuration;


namespace CRUDoperationDataAccessLayer
{
   
    public class DatabaseConnectDAL
    {
         static SqlConnection con = new SqlConnection();

        //ADD ROWS
        public static void AddRows(Student student)
            {
           con.ConnectionString= "Data Source =DESKTOP-TEJJIDI; Initial Catalog = crudoperations; Integrated Security = True";
            SqlCommand command = new SqlCommand("insert into Student values(' " + student.StudentId + " ',' " + student.StudentName + " ',' " + student.StudentAge + " ',' " + student.StudentAddress + " ',' " + student.StudentMarks+"')",con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            }
      

        //updating record /rows in database
        public static void UpdateRows(int id, string name, int age)
            {
                
                con.ConnectionString = "Data Source =DESKTOP-TEJJIDI; Initial Catalog = crudoperations; Integrated Security = True";
            SqlCommand command = new SqlCommand("update  Student set studentName='" + name + "',studentAge=" + age + "where studentId='" + id + "'", con);
                con.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("RECORD UPDATED SUCCESSFULLY");
                con.Close();


                }

        //displaying all rows 
        public static void DisplayRows()
            {
            con.ConnectionString = "Data Source = DESKTOP-TEJJIDI; Initial Catalog = crudoperations; Integrated Security = True";
            SqlCommand command = new SqlCommand("select * from Student", con);
            con.Open();

            //command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("StudentId\tStudentName\tage\tAddress\tLocation");
            if(reader.HasRows)
                {
                while(reader.Read())
                    {
                    Console.WriteLine(reader[0] + "\t" + reader[1] + " " + reader[2] + "\t" + reader[3] + "\t" + reader[4]);
                    Console.WriteLine();
                    }
                }
            else
                {
                Console.WriteLine("No data found");
                }

            con.Close();


            }

        public static void DisplayBasedOnId(int id)
            {
            con.ConnectionString = "Data Source = DESKTOP-TEJJIDI; Initial Catalog = crudoperations; Integrated Security = True";
            SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE studentId='"+id+"'", con);
            con.Open();

            //command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("StudentId\tStudentName\tage\tAddress\tLocation");
            if(reader.HasRows)
                {
                while(reader.Read())
                    {
                    Console.WriteLine(reader[0] + "\t" + reader[1] + " " + reader[2] + "\t" + reader[3] + "\t" + reader[4]);
                    Console.WriteLine();
                    }
                }
            else
                {
                Console.WriteLine("No data found");
                }
            con.Close();
            }
        public static void DeleteRow(int id)
            {
            con.ConnectionString = "Data Source = DESKTOP-TEJJIDI; Initial Catalog = crudoperations; Integrated Security = True";
            SqlCommand command = new SqlCommand("DELETE FROM Student WHERE studentId='" + id + "'", con);
            con.Open();

            command.ExecuteNonQuery();
            Console.WriteLine("Record deleted successfully");
           SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("StudentId\tStudentName\tage\tAddress\tLocation");
            if(reader.HasRows)
                {
                while(reader.Read())
                    {
                    Console.WriteLine(reader[0] + "\t" + reader[1] + " " + reader[2] + "\t" + reader[3] + "\t" + reader[4]);
                    Console.WriteLine();
                    }
                }
            else
                {
                Console.WriteLine("No data found");
                }
            con.Close();

            }


        }
}
