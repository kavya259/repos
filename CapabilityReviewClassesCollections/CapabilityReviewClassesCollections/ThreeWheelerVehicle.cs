using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapabilityReviewClassesCollections
    {
    public class ThreeWheelerVehicle:Vehicle
        {
        public const string vehicleName = "Three wheeler";

        public double baseCost = 30000;
        public static double gst = 250;


        public double calculateCost()
            {
            double totalAmount = (baseCost) * (gst);
            return totalAmount;
            }
        public override string getVehicleDetails()
            {
            getBrand();

            return "VehicleId:" + (this.Id++) + "VehicleName :" + this.VehicleName ;
            }
        }
    }
