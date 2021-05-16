using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RoomBookingDataLayer;
using RoomBookingEntities;

namespace RoomBookingBusinessLayer
    {
     public class RoomBookingBL:IRoomBookingBL
        {
        private readonly IRoomBookingDAL _bookingDAL;
        public RoomBookingBL(IRoomBookingDAL roomBookingDAL)
            {
            _bookingDAL = roomBookingDAL;
            }
        public async Task<bool> AddCustomerBl(Customer customer)
            {
            return await _bookingDAL.AddCustomer(customer);
            }
        public async Task<bool> UpdateCustomerBL(int id, Customer customer)
            {
            return await _bookingDAL.UpdateCustomer(id,customer);
            }
        public async Task<bool> AddHotelBl(Hotel hotel)
            {
            return await _bookingDAL.AddHotel(hotel);
            }
        public async Task<bool> AddRoomBl(Room room)
            {
            return await _bookingDAL.AddRoom(room);
            }

        public async Task<Hotel> GetHotelBL(string hotelName)
            {
            return await _bookingDAL.GetHotelDAL(hotelName);
            }
       
        }
    }
