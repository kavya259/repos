using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Entities;
namespace PharmacyDataAccessLayer
    {
    public class PharmacyDAL:IPharmacyDAL
        {
        static string connect = ConfigurationManager.ConnectionStrings["Pharmacy"].ConnectionString;
        SqlConnection conn = new SqlConnection(connect);
        static List<Medicine> medicines = new List<Medicine>();
        static List<ManufacturingCompany> companies = new List<ManufacturingCompany>();


        public Medicine AddMedicineDAL(Medicine medicine)
            {
            try
                {

                conn.Open();
                SqlCommand command = new SqlCommand("AddMedicine", conn);
                command.CommandType = CommandType.StoredProcedure;
                // command.Parameters.AddWithValue("@Id", medicine.Id);
                command.Parameters.AddWithValue("@Name", medicine.Name);
                command.Parameters.AddWithValue("@Price", medicine.Price);
                command.Parameters.AddWithValue("@Category", medicine.Category);
                command.Parameters.AddWithValue("@ManufacturingCompanyName", medicine.ManufacturingCompany);
                command.Parameters.AddWithValue("@ExpiryDate", medicine.ExpiryDate);
                command.ExecuteNonQuery();
                return medicine;
                }
            catch(NullReferenceException ex)
                {
                throw ex;
                }
            catch(FormatException ex)
                {
                throw ex;
                }
            catch(Exception ex)
                {
                throw ex;
                }
            finally
                {
                conn.Close();
                }


            }


        public ManufacturingCompany AddManufacturerDAL(ManufacturingCompany company)
            {
            try
                {

                conn.Open();
                SqlCommand command = new SqlCommand("AddCompany", conn);
                command.CommandType = CommandType.StoredProcedure;
                // command.Parameters.AddWithValue("@Id", medicine.Id);
                command.Parameters.AddWithValue("@Name", company.Name);
                command.ExecuteNonQuery();
                return company;
                }
            catch(NullReferenceException ex)
                {
                throw ex;
                }
            catch(FormatException ex)
                {
                throw ex;
                }
            catch(Exception ex)
                {
                throw ex;
                }
            finally
                {
                conn.Close();
                }


            }




        public List<Medicine> GetAllMedicinesDAL()
            {
            try
                {

                conn.Open();
                SqlCommand command = new SqlCommand("GetAllMedicines", conn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                sd.Fill(data);
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                    {
                    foreach(DataRow row in data.Rows)
                        {
                        medicines.Add(new Medicine
                            {
                            Id = Convert.ToInt32(row["Id"]),
                            Name = Convert.ToString(row["Name"]),
                            Price = Convert.ToInt32(row["Price"]),
                            Category = Convert.ToString(row["Category"]),
                            ManufacturingCompany = Convert.ToString(row["ManufacturingCompanyName"]),
                            ExpiryDate = Convert.ToDateTime(row["ExpiryDate"])

                            });
                        }
                    }
                return medicines;
                }
            catch(NullReferenceException ex)
                {
                throw ex;
                }
            catch(Exception ex)
                {
                throw ex;
                }
            finally
                {
                conn.Close();
                }



            }
        
    
        public List<ManufacturingCompany> GetAllCompaniesDAL()
        {
        try
            {

            conn.Open();
            SqlCommand command = new SqlCommand("GetAllCompanies", conn);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            sd.Fill(data);
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
                {
                foreach(DataRow row in data.Rows)
                    {
                    companies.Add(new ManufacturingCompany
                        {
                        Name = Convert.ToString(row["Name"])
                        
                        });
                    }
                }
            return companies;
            }
        catch(NullReferenceException ex)
            {
            throw ex;
            }
        catch(Exception ex)
            {
            throw ex;
            }
        finally
            {
            conn.Close();
            }



        }
    }

    }
