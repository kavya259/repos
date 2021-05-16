using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestaurentManagementBusinessLayer;
using RestaurentManagementEntities;

namespace RestaurentManagementSystem.MVCWebApplication.Models
    {
    public class ManagerModel
        {
        IBigBazarBL bigbazarbl = new BigBazarBL();
        public void AddStaffManagerModel(StaffModel staffModel)
            {
            Staff staff = new Staff();
            staff.StaffId = staffModel.StaffId;
            staff.StaffName = staffModel.StaffName;
            staff.StaffGender = staffModel.StaffGender;
            staff.StaffShift = staffModel.StaffShift;
            bigbazarbl.AddStaffBL(staff);

            }

        public void AddBillManagerModel(BillModel billModel)
            {
            Bill bill = new Bill();
            bill.BillNumber = billModel.BillNumber;
            bill.Amount = billModel.Amount;
            bill.StaffId = billModel.StaffId;
            bill.StaffName = billModel.StaffName;
            bigbazarbl.AddBillBl(bill);
            

            }

        public BillModel EntityToBillModel(Bill bill)
            {
            BillModel billModel = new BillModel();
            billModel.BillNumber = bill.BillNumber;
            billModel.Amount = bill.Amount;
            billModel.StaffId = billModel.StaffId;
            billModel.StaffName = billModel.StaffName;
            return billModel;
            }
        public List<BillModel> GetBillList()
            {
            List<Bill> bills = bigbazarbl.GetBillList();
            List<BillModel> billModels = new List<BillModel>();
            foreach(Bill bill in bills)
                {
                billModels.Add(EntityToBillModel(bill));
                }

            return billModels;
                
            }
        public StaffModel EntityToStaffModel(Staff staff)
            {
            StaffModel staffModel = new StaffModel();
            staffModel.StaffId = staff.StaffId;
            staffModel.StaffName = staff.StaffName;
            staffModel.StaffShift = staff.StaffShift;
            staffModel.StaffGender = staff.StaffGender;
            return staffModel;
           
            }
        public List<StaffModel> GetStaffList()
            {
            List<Staff> staffList = bigbazarbl.GetStaffList();
            List<StaffModel> staffModels = new List<StaffModel>();
            foreach(Staff staff in staffList)
                {
                staffModels.Add(EntityToStaffModel(staff));
                }

            return staffModels;

            }

        }
    }