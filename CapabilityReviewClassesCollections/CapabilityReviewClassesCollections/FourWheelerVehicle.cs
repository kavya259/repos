using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapabilityReviewClassesCollections
    {
   public class FourWheelerVehicle:Vehicle,IComparable<FourWheelerVehicle>
        {
        public const string vehicleName = "Four wheeler";

        public double baseCost = 50000;
        public static double gst = 400;


        public double calculateCost()
            {

            double totalAmount = (baseCost) * (gst);
            return totalAmount;
            }
        public override string getVehicleDetails()
            {
            getBrand();
            return "VehicleId:" + (this.Id++) + "VehicleName :" + VehicleName ;
            }

        public int CompareTo(FourWheelerVehicle other)
            {
            try
                {
                if(this.Id > other.Id)
                    {
                    return 1;
                    }
                else if(this.Id < other.Id)
                    {
                    return -1;
                    }
                else
                    {
                    return 0;
                    }
                }
            catch(NullReferenceException ex)
                {
                throw ex;
                }
            catch(Exception ex)
                {
                throw ex;
                }

            }
        }
    }
