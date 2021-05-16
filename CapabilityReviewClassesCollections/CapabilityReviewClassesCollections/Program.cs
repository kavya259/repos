using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapabilityReviewClassesCollections
    {
   public class Program
        {
        static void Main(string[] args)
            {
            List<TwoWheelerVehicle> twoWheelers = new List<TwoWheelerVehicle>();
            List<ThreeWheelerVehicle> threeWheelers = new List<ThreeWheelerVehicle>();
            List<FourWheelerVehicle> fourWheelers = new List<FourWheelerVehicle>();

            ///Adding two wheelers 
            twoWheelers.Add(new TwoWheelerVehicle() { Id = 1,VehicleName = "maruti" }) ;
            twoWheelers.Add(new TwoWheelerVehicle() {VehicleName = "toyota" }) ;

            //adding three wheelers
            threeWheelers.Add(new ThreeWheelerVehicle() { Id = 1,VehicleName = "xyz" }) ;
            threeWheelers.Add(new ThreeWheelerVehicle() { VehicleName = "abc" });
            //adding four wheerler
            fourWheelers.Add(new FourWheelerVehicle() { Id=1,VehicleName = "tata" });
            fourWheelers.Add(new FourWheelerVehicle() { VehicleName = "mercedes" });
            fourWheelers.Add(new FourWheelerVehicle() { VehicleName = "abcd" });
            //iterating throug two wheelers
            foreach(TwoWheelerVehicle two in twoWheelers)
                {
                Console.WriteLine(two.getVehicleDetails());
                Console.WriteLine(two.calculateCost());
                }
            //iterating throug three wheelers

            foreach(ThreeWheelerVehicle three in threeWheelers)
                {
                Console.WriteLine(three.getVehicleDetails());
                Console.WriteLine(three.calculateCost());
                }
            //iterating throug four wheelers

            foreach(FourWheelerVehicle four in fourWheelers)
                {
                Console.WriteLine(four.getVehicleDetails());
                Console.WriteLine(four.calculateCost());
                }
            //removing abcd four wheeler
            fourWheelers.RemoveAt(2);
            foreach(FourWheelerVehicle four in fourWheelers)
                {
                Console.WriteLine(four.getVehicleDetails());
                Console.WriteLine(four.calculateCost());
                }
            fourWheelers.Sort();
            foreach(FourWheelerVehicle four in fourWheelers)
                {
                Console.WriteLine(four.getVehicleDetails());
                Console.WriteLine(four.calculateCost());
                }





            Console.ReadLine();




            }
        }
    }
