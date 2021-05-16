using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using PharmacyDataAccessLayer;

namespace PharmacyBusinessLayer
    {
    public interface IPharmacyBL
        {
        Medicine AddMedicineBL(Medicine medicine);
        ManufacturingCompany AddManufacturerBL(ManufacturingCompany company);
        List<Medicine> GetAllMedicinesBL();
        List<ManufacturingCompany> GetAllCompaniesBL();
        }
    }
