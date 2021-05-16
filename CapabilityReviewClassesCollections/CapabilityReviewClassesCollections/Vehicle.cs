using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapabilityReviewClassesCollections
    {
    public abstract class Vehicle:IVehicle
        {
        public int Id
            {
            get; set;
            }
        public string VehicleName
            {
            get; set;
            }
        public string Brand
            {
            get; set;
            }
        
        public abstract string getVehicleDetails();
        public string getBrand()
            {
            return "Brand :" + this.Brand;
            }
        
           
           
        }
    }
