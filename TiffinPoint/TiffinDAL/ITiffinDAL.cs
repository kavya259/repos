using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiffinEntities;

namespace TiffinDataAccess
    {
    public interface ITiffinDAL
        {
        Item AddNewItemDAL(Item item);
        List<Item> GetItemsDAL();
        Customer AddNewCustomerDAL(Customer customer);
        List<Customer> GetCustomerDAL();
        void DeleteCustomerDAL(int id);
        }
    }
