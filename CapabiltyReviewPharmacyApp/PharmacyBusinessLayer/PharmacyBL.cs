using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using PharmacyDataAccessLayer;

namespace PharmacyBusinessLayer
{
    public class PharmacyBL:IPharmacyBL
    {
        static readonly IPharmacyDAL _pharmacyDAL=new PharmacyDAL();
        public Medicine AddMedicineBL(Medicine medicine)
            {
            return _pharmacyDAL.AddMedicineDAL(medicine);
            }
        public ManufacturingCompany AddManufacturerBL(ManufacturingCompany company)
            {
            return _pharmacyDAL.AddManufacturerDAL(company);
            }
        public List<Medicine> GetAllMedicinesBL()
            {
            return _pharmacyDAL.GetAllMedicinesDAL();
            }
        public List<ManufacturingCompany> GetAllCompaniesBL()
            {
            return _pharmacyDAL.GetAllCompaniesDAL();
            }
        }
}
