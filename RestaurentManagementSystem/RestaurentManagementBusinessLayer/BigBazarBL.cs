using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurentManagementEntities;
using RestaurentManagementDataAccessLayer;

namespace RestaurentManagementBusinessLayer
{
    public class BigBazarBL
    {
        BigBazarDAL bigBazarDAL = new BigBazarDAL();

        public Staff AddStaffBL()
            {
            return bigBazarDAL.AddStaffDAL();
            }
    }
}
