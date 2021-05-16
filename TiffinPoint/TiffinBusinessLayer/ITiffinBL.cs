using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiffinDataAccess;
using TiffinEntities;

namespace TiffinBusinessLayer
    {
   public  interface ITiffinBL
        {
        Item AddNewItemBL(Item item);


        List<Item> GetAllItemsBL();

        Customer AddNewCustomerBL(Customer customer);

        List<Customer> GetCustomersBL();


        void DeleteCustomerBL(int id);
        }
    }
