using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurentManagementEntities;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace RestaurentManagementDataAccessLayer
{
    public class BigBazarDAL:IBIgBazarDAL
    {
        IBIgBazarDAL bigBazarDal = new BigBazarDAL();
        static string connect = ConfigurationManager.["BigBazar"].connectionString;
        SqlConnection conn = new SqlConnection(connect);
        
        public Staff AddStaffDAL()
            {
            Staff staff = new Staff();

            conn.Open();
            SqlCommand command = new SqlCommand("AddStaff", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@StaffId", staff.StaffId);
            command.Parameters.AddWithValue("@StaffName", staff.StaffName);
            command.Parameters.AddWithValue("@StaffShift", staff.StaffShift);
            command.Parameters.AddWithValue("@StaffGender", staff.StaffGender);
            command.ExecuteNonQuery();
            conn.Close();

            return staff;


            }

        public Bill AddBranchDAL()
            {
                    Bill bill = new Bill();

            conn.Open();
            SqlCommand command = new SqlCommand("AddBill", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@BillName", bill.BillNumber);
            command.Parameters.AddWithValue("@Amount",bill.Amount );
            command.Parameters.AddWithValue("@StaffId",bill.StaffId );
            command.Parameters.AddWithValue("@StaffName",bill.StaffName );
            command.ExecuteNonQuery();
            conn.Close();

            return bill;


            }



        }
}
