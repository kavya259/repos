using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurentManagementSystem.MVCWebApplication.Models
    {
    public class BillModel
        {
        public int BillNumber
            {
            get; set;
            }
        public int StaffId
            {
            get; set;
            }
        public string StaffName
            {
            get; set;
            }
        public string DeliveryMode
            {
            get; set;
            }
        public int Amount
            {
            get; set;
            }

        }
    }