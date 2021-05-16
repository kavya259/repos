using RoomBookingEntities;
using System;
using System.Threading.Tasks;

namespace RoomBookingDataLayer
    {
    public interface IRoomBookingDAL
        {
        Task<bool> AddCustomer(Customer customer);
        Task<bool> UpdateCustomer(int id, Customer customer);
        Task<bool> AddHotel(Hotel hotel);
        Task<Hotel> GetHotelDAL(string hotelName);
        Task<bool> AddRoom(Room room);



        }
    }
