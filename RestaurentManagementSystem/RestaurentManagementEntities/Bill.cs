using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurentManagementEntities
    {
    public class Bill
        {
        public int BillNumber
            {
            get;set;
            }
        public int StaffId
            {
            get;set;
            }
        public string StaffName
            {
            get;set;
            }
        public string DeliveryMode
            {
            get;set;
            }
        public int Amount
            {
            get;set;
            }
        }
    }
