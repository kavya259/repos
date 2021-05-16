using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyDataAccessLayer
    {
    public interface IPharmacyDAL
        {
        Medicine AddMedicineDAL(Medicine medicine);
        ManufacturingCompany AddManufacturerDAL(ManufacturingCompany company);
        List<Medicine> GetAllMedicinesDAL();
        List<ManufacturingCompany> GetAllCompaniesDAL();
        }
    }
