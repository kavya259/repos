using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RoomBookingEntities
    {
    public class Hotel
        {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HotelId
            {
            get; set;
            }
        public string Name
            {
            get; set;
            }
        public double Price
            {
            get; set;
            }
        public string CheckInTime
            {
            get; set;
            }
        public string CheckOutTime
            {
            get; set;
            }
        public string City
            {
            get; set;
            }

        }
    }
