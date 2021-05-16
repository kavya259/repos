using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RoomBookingEntities;
using RoomBookingExceptions;
namespace RoomBookingDataLayer
    {
    public class RoomBookingDAL : IRoomBookingDAL
        {
        private readonly RoomBookingDBContext _DbContext;
        public RoomBookingDAL(RoomBookingDBContext roomBookingDB)
            {
            _DbContext = roomBookingDB;
            }

        public async Task<bool> AddCustomer(Customer customer)
            {
            int rowsaffected = 0;
            if(await _DbContext.Customers.FirstOrDefaultAsync(cus => cus.PhoneNo == customer.PhoneNo) != null)
                {
                throw new DuplicatePhoneNumberException("This mobile number already exits");
                }
            else if(await _DbContext.Customers.FirstOrDefaultAsync(cus => cus.Email == customer.Email) != null)
                {
                throw new DuplicateEmailException("this email id already exits ,try unique mailid");
                }
            else
                {
                try
                    {
                    _DbContext.Customers.Add(customer);
                    rowsaffected = await _DbContext.SaveChangesAsync();
                    if(rowsaffected == 0)
                        {
                        return false;
                        }
                    else
                        {
                        return true;
                        }
                    }
                catch(NullReferenceException ex)
                    {
                    throw ex;
                    }
                catch(SqlException ex)
                    {
                    throw ex;
                    }
                catch(Exception ex)
                    {
                    throw ex;
                    }

                }

            }


        public async Task<bool> UpdateCustomer(int id, Customer customer)
            {
            int rowsaffected = 0;
            if(await _DbContext.Customers.FirstOrDefaultAsync(cus => cus.CustomerId == id) == null)
                {
                throw new NameNotFoundException("customer not present ");
                }
            else
                {
                try
                    {
                    //_DbContext.Customers.Update(customer);
                    Customer updatedCustomer = await _DbContext.Customers.FirstOrDefaultAsync(c => c.CustomerId == id);
                    //  updatedCustomer.CustomerId = customer.CustomerId;
                    updatedCustomer.Name = customer.Name;
                    updatedCustomer.Email = customer.Email;
                    updatedCustomer.PhoneNo = customer.PhoneNo;

                    rowsaffected = await _DbContext.SaveChangesAsync();
                    if(rowsaffected == 0)
                        {
                        return false;
                        }
                    else
                        {
                        return true;
                        }
                    }
                catch(NullReferenceException ex)
                    {
                    throw ex;
                    }
                catch(SqlException ex)
                    {
                    throw ex;
                    }
                catch(Exception ex)
                    {
                    throw ex;
                    }

                }

            }






        public async Task<bool> AddHotel(Hotel hotel)
            {
            int rowsaffected = 0;
            if(await _DbContext.Hotels.FirstOrDefaultAsync(h => h.Name == hotel.Name && h.City == h.City) != null)
                {
                throw new DuplicateNameException("The hotel with same name in same city already available ");
                }
            else
                {
                try
                    {
                    _DbContext.Hotels.Add(hotel);
                    rowsaffected = await _DbContext.SaveChangesAsync();
                    if(rowsaffected == 0)
                        {
                        return false;
                        }
                    else
                        {
                        return true;
                        }
                    }
                catch(NullReferenceException ex)
                    {
                    throw ex;
                    }
                catch(SqlException ex)
                    {
                    throw ex;
                    }
                catch(Exception ex)
                    {
                    throw ex;
                    }

                }
            }

        public async Task<Hotel> GetHotelDAL(string hotelName)
            {
            try
                {

                if(await _DbContext.Hotels.FirstOrDefaultAsync(h => h.Name == hotelName) != null)
                    {
                    Hotel hotel = await _DbContext.Hotels.FirstOrDefaultAsync(h => h.Name == hotelName);
                    return hotel;

                    }
                else
                    {
                    throw new NameNotFoundException("hotel with this name is not present");
                    }
                }
            catch(NameNotFoundException ex)
                {
                throw ex;
                }
            catch(Exception ex)
                {
                throw ex;

                }

            }




        public async Task<bool> AddRoom(Room room)
            {
            int rowsaffected = 0;
            if(room.CustomerId != 0)
                {

                if(room.FromDate <= DateTime.Now && room.FromDate >= DateTime.Now)
                    {
                    throw new DateNotValidException("please check the from date ,it must be either present day or after ");
                    }
                if(room.ToDate <= DateTime.Now)
                    {
                    throw new DateNotValidException("please check the to date ,it must be either present day or after ");
                    }
                if(!room.RoomStatus.Equals("available"))
                    {
                    return false;
                    }
                else
                    {
                    try
                        {

                        room.RoomStatus = "booked";
                        room.IsDeleted = false;
                        _DbContext.Rooms.Add(room);


                        rowsaffected = await _DbContext.SaveChangesAsync();
                        if(rowsaffected == 0)
                            {
                            return false;
                            }
                        else
                            {
                            return true;
                            }
                        }
                    catch(NullReferenceException ex)
                        {
                        throw ex;
                        }
                    catch(SqlException ex)
                        {
                        throw ex;
                        }
                    catch(Exception ex)
                        {
                        throw ex;
                        }

                    }
                }
            else
                {
                room.RoomStatus = "available";
                room.IsDeleted = true;
                _DbContext.Rooms.Add(room);
                if(rowsaffected == 0)
                    {
                    return false;
                    }
                else
                    {
                    return true;
                    }
                }


            }


        }
    }

