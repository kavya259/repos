using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomBookingEntities
    {
    public class Customer
        {[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId
            {
            get; set;
            }
        public string Name
            {
            get; set;
            }
        public string Address
            {
            get; set;
            }
        public string GovtIdProof
            {
            get; set;
            }
        public string Email
            {
            get; set;
            }
        public string PhoneNo
            {
            get; set;
            }
        }
    }
