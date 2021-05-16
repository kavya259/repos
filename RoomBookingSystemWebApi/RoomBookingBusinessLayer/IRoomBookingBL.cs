using RoomBookingEntities;
using System;
using System.Threading.Tasks;

namespace RoomBookingBusinessLayer
    {
    public interface IRoomBookingBL
        {
        Task<bool> AddCustomerBl(Customer customer);
        Task<bool> UpdateCustomerBL(int id, Customer customer);
        Task<bool> AddHotelBl(Hotel hotel);
        Task<Hotel> GetHotelBL(string hotelName);
        Task<bool> AddRoomBl(Room room);


        }
    }
