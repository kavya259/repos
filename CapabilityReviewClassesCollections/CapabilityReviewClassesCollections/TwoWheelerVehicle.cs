using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapabilityReviewClassesCollections
    {
    public class TwoWheelerVehicle:Vehicle,IVehicle
        {
        public const string vehicleName = "Two wheeler";
        public  double baseCost = 20000;
        public static double gst = 200;


        public double calculateCost()
            {
            double totalAmount = (baseCost) * (gst);
            return totalAmount;
            }

        public override string getVehicleDetails()
            {
            getBrand();
            return "VehicleId:"+(this.Id++)+"VehicleName :" + this.VehicleName ;
            }
        }
    }
