using System;
using System.Collections.Generic;
using CRUDoperationDataAccessLayer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitity;

namespace CRUDoperationBusinesslayer
{
    public class StudentManagerBL
        {    


        public static void AddStudent(Student student)
            {
            DatabaseConnectDAL.AddRows(student);
            
         }

        public static void UpdateRecord(int id,string name,int age)
            {
            
            DatabaseConnectDAL.UpdateRows(id, name, age);
                     
            }
        public static void DisplayAllStudents()
            {
           
            DatabaseConnectDAL.DisplayRows();
            }
        public static void DisplayBasedOnId(int id)
            {
            DatabaseConnectDAL.DisplayBasedOnId(id);
           
            }
        public static void DeleteRecord(int id)
            {
            DatabaseConnectDAL.DeleteRow(id);
            }


        }
    }
