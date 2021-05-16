using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TiffinBusinessLayer;
using TiffinEntities;

namespace TiffinPoint.Models
    {
    public class TiffinPointManagerModel
        {
        TiffinBL tiffinBL = new TiffinBL();
        public void AddItemsModel(ItemModel itemModel) //add items 
            {
            Item item = new Item();
            item.ItemId = itemModel.ItemId;
            item.ItemName = itemModel.ItemName;
            tiffinBL.AddNewItemBL(item);
            }
        public List<ItemModel> GetAllItemsModel()  //get all items model
            {
            List<Item> entityitems = tiffinBL.GetAllItemsBL();
            List<ItemModel> modelItems = new List<ItemModel>();
            foreach(Item item in entityitems)
                {
                modelItems.Add(ItemToItemModel(item));

                }
            return modelItems;
            }

        public ItemModel ItemToItemModel(Item item)
            {
            ItemModel itemModel = new ItemModel();
            itemModel.ItemId = item.ItemId;
            itemModel.ItemName = item.ItemName;
            return itemModel;
            }


        //////////////////////////////////////////////////////////////
        public void AddCustomersModel(CustomerModel customerModel)//To add customers from model to entity
            {
            Customer customer = new Customer();
           // CustomerModel customerModel = new CustomerModel();
            customer.CustomerId = customerModel.CustomerId;
            customer.CustomerName = customerModel.CustomerName;
            customer.Mobile = customerModel.Mobile;
            customer.ItemId = customerModel.ItemId;
            tiffinBL.AddNewCustomerBL(customer);
            }

        public List<CustomerModel> GetAllCustomersModel()  //get all items model
            {
            List<Customer> entitycustomers = tiffinBL.GetCustomersBL();
            List<CustomerModel> modelCustomers = new List<CustomerModel>();
            foreach(Customer customer in entitycustomers)
                {
                modelCustomers.Add(CustomerToCustomerModel(customer));

                }
            return modelCustomers;
            }
        

        public CustomerModel CustomerToCustomerModel(Customer customer)
            {
            CustomerModel customerModel = new CustomerModel();
            customerModel.CustomerId = customer.CustomerId;
            customerModel.CustomerName = customer.CustomerName;
            customerModel.Mobile = customer.Mobile;
            customerModel.ItemId = customer.ItemId;
            
            return customerModel;
            }

        //delete customer
        public void DeleteCustomerModel(int id)
            {
          //  CustomerModel customerModel = new CustomerModel();
            tiffinBL.DeleteCustomerBL(id);


            //List<Customer> entitycustomers = tiffinBL.GetCustomersBL();
            //List<CustomerModel> modelCustomers = GetAllCustomersModel();

            //foreach(Customer customer in entitycustomers)
            //    {
            //    foreach(CustomerModel Model in modelCustomers)
            //        {

            //        if(customer.CustomerId == id && Model.CustomerId == id)
            //            {
            //            tiffinBL.DeleteCustomerBL(id);
            //            Model.CustomerId = customer.CustomerId;
            //            Model.CustomerName = customer.CustomerName;
            //            Model.Mobile = customer.Mobile;
            ////            Model.ItemId = customer.ItemId;
            //            }
            //        }

            //    }
            //return customerModel;

            }

        }
    }