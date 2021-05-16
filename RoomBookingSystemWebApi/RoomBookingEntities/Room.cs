using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RoomBookingEntities
    {
    public class Room
        {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomId
            {
            get; set;
            }
        public int RoomNo
            {
            get; set;
            }
        public string RoomStatus
            {
            get; set;
            }
        public DateTime FromDate
            {
            get; set;
            }
        public DateTime ToDate
            {
            get; set;
            }
        public bool IsDeleted
            {
            get; set;
            }
        [ForeignKey("Customer")]
        public int CustomerId
            {
            get; set;
            }
        //public Customer Customer
        //    {
        //    get; set;
        //    }
        [ForeignKey("Hotel")]
        public int HotelId
            {
            get; set;
            }
        //public Hotel Hotel
        //    {
        //    get; set;
        //    }
        }
    }
