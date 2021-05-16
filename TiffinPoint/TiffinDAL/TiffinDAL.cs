using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TiffinEntities;
using System.Data.SqlClient;
using System.Data;
using CustomExceptionLayer;
namespace TiffinDataAccess
    {
    public class TiffinDAL:ITiffinDAL
        {
        static string connect = ConfigurationManager.ConnectionStrings["Tiffin"].ConnectionString;
        SqlConnection connection = new SqlConnection(connect);

        public Item AddNewItemDAL(Item item)//adding items to the database
            {
            connection.Open();
            try
                {

                SqlCommand command = new SqlCommand("AddNewItem", connection);
                command.CommandType = CommandType.StoredProcedure;
                // command.Parameters.AddWithValue("@ItemId",item.ItemId);
                command.Parameters.AddWithValue("@ItemName", item.ItemName);
                int rowsaffected = command.ExecuteNonQuery();
                if(rowsaffected == 0)
                    {
                    throw new CustomExceptionLayer.SqlServerException("there is a problem in connecting to server ,please check");
                    }
                }
            catch(System.Data.SqlClient.SqlException ex)
                {
                throw new CustomExceptionLayer.SqlServerException(ex.Message);

                }
            catch(Exception)
                {
                throw new Exception("Some error occured in server or connection");

                }
            finally
                {
                connection.Close();
                }
            return item;


            }
        public List<Item> GetItemsDAL()//Getting list of all items
            {
            List<Item> items = new List<Item>();
            connection.Open();
            SqlCommand command = new SqlCommand("GetAllItems", connection);
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
                        items.Add(
                            new Item
                                {
                                ItemId = Convert.ToInt32(row["ItemId"]),
                                ItemName = Convert.ToString(row["ItemName"])
                                });

                        }

                    }
                else
                    {
                    throw new NoDataFoundException("Items data is not found");
                    }
                }
            catch(FormatException)
                {
                throw new FormatException("Check the data types");
                }
            catch(Exception)
                {
                throw new Exception("Some error occured in server or connection");
                }
            finally
                {
                connection.Close();
                }
            return items;
            }


        public Customer AddNewCustomerDAL(Customer customer)
            {
            try
                {
                SqlCommand command = new SqlCommand("AddNewCustomer", connection);
                command.CommandType = CommandType.StoredProcedure;
             //  command.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
                command.Parameters.AddWithValue("@CustomerName", customer.CustomerName);
                command.Parameters.AddWithValue("@Mobile",customer.Mobile );
                command.Parameters.AddWithValue("@ItemId",customer.ItemId );
            connection.Open();
                int rowsaffected = command.ExecuteNonQuery();
                if(rowsaffected == 0)
                    {
                    throw new SqlServerException("there is a problem in connecting to server ,please check");
                    }
                }
            catch(SqlServerException ex)
                {
                throw new SqlServerException(ex.Message);

                }
            catch(FormatException)
                {
                throw new FormatException("Check the data types");
                }
            catch(Exception)
                {
                throw new Exception("Some error occured in server or connection");
                }
            finally
                {
                connection.Close();
                }
            return customer;

            }

        public List<Customer> GetCustomerDAL()//Getting list of all items
            {
            List<Customer> customers = new List<Customer>();
            connection.Open();
            SqlCommand command = new SqlCommand("GetCustomer", connection);
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
                        customers.Add(
                            new Customer
                                {
                                CustomerId = Convert.ToInt32(row["CustomerId"]),
                                CustomerName = Convert.ToString(row["CustomerName"]),
                                Mobile=Convert.ToString(row["Mobile"]),
                                ItemId=Convert.ToInt32(row["ItemId"])
                                });

                        }

                    }
                else
                    {
                    throw new NoDataFoundException("Customer data is not found");
                    }
                }
            catch(FormatException)
                {
                throw new FormatException();
                }
            catch(Exception )
                {
                throw new Exception("Some error occured in server or connection");

                }
            finally
                {
                connection.Close();
                }
            return customers;
            }

        public void DeleteCustomerDAL(int id)
            {
            connection.Open();

            try
                {
                SqlCommand command = new SqlCommand("DeleteCustomer", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerId", id);
                //command.Parameters.AddWithValue("@CustomerName", null);
                //command.Parameters.AddWithValue("@Mobile", null);
                //command.Parameters.AddWithValue("@ItemId", null);
                int rowsaffected = command.ExecuteNonQuery();
                if(rowsaffected == 0)
                    {
                    throw new CustomExceptionLayer.SqlServerException("Id is not available to delete");
                    }
                }
            catch(System.Data.SqlClient.SqlException ex)
                {
                throw new CustomExceptionLayer.SqlServerException(ex.Message);
                }
            catch(Exception)
                {
                throw new Exception("Some error occured in server or connection");
                }
           
            finally
                {
                connection.Close();
                }
            
            
            }


        }
    }
