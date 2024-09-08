using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementParkMogul
{
    public class Attraction 
    {
        public int AttractionID { get; }
        public string Name { get; set; }

        public void getRideInfo()
        {
            Console.WriteLine("ID: " + AttractionID);
            Console.WriteLine("Name: " + Name);
        }

    }

    public class Rollercoaster : Attraction , ICalculateAttractionCost
    {
        public int Length { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }

        public void getRollercoasterInfo()
        {
            Console.WriteLine("ID: " + AttractionID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Lenth: " + Length + " feet");
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Material: " + Material);


        }

        public void printProperties(string a)
        {
            Type thisType = a.Length.GetType();
            Console.WriteLine(thisType);
        }

        public void calculateCost()
        {
            int pricePerFoot = 2000;
            int cost = Length * pricePerFoot;


            string costToString = cost.ToString("C");


            Console.WriteLine("The " + Name + " roller coaster is " + costToString);
        }
    }


    public class GentleRide : Attraction, ICalculateAttractionCost
    {
        public int squareFoot { get; set; }

        public void getGentleRideInfo()
        {
            Console.WriteLine("ID: " + AttractionID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Square Feet: " + squareFoot + " square feet");
        }

        public void calculateCost()
        {
            int pricePerSquareFoot = 350;
            int cost = squareFoot * pricePerSquareFoot;


            string costToString = cost.ToString("C");


            Console.WriteLine("The " + Name + " gentle ride is " + costToString);
        }

    }

    //seperated Shop from Gentle Ride in case changes, to either, are needed in the future

    public class Shop : Attraction, ICalculateAttractionCost
    {
        public int squareFoot { get; set; }

        public void getShopInfo()
        {
            Console.WriteLine("ID: " + AttractionID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Square Feet: " + squareFoot + " square feet");
        }

        public void calculateCost()
        {
            int pricePerSquareFoot = 200;
            int cost = squareFoot * pricePerSquareFoot;


            string costToString = cost.ToString("C");


            Console.WriteLine("The " + Name + " shop is " + costToString);
        }

    }



}
