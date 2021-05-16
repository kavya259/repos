using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiffinDataAccess;
using TiffinEntities;

namespace TiffinBusinessLayer
{
    public class TiffinBL:ITiffinBL
    {
        public ITiffinDAL tiffinDAL = new TiffinDAL();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Item AddNewItemBL(Item item)
            {
            return tiffinDAL.AddNewItemDAL(item);
            }
        public List<Item> GetAllItemsBL()
            {
            return tiffinDAL.GetItemsDAL();
            }
        public Customer AddNewCustomerBL(Customer customer)
            {
            return tiffinDAL.AddNewCustomerDAL(customer);

            }
        public List<Customer> GetCustomersBL()
            {
            return tiffinDAL.GetCustomerDAL();
            }
        public void DeleteCustomerBL(int id)
            {
             tiffinDAL.DeleteCustomerDAL(id);
            }
    }
}
