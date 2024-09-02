using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementParkMogul
{
    public class Rollercoaster
    {
        public int RollercoasterID { get; }
        public string Name { get; set; }
        public int Length { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }

        public void getRollercoasterInfo()
        {
            Console.WriteLine("ID: " + RollercoasterID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Lenth: " + Length + " feet");
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Material: " + Material);
        }

        public void CalculateRollercoasterCost()
        {
            int pricePerFoot = 2000;
            int cost = Length * pricePerFoot;


            string costToString = cost.ToString("C");


            Console.WriteLine("The " + Name + " roller coaster is " + costToString);
        }

    }
}
