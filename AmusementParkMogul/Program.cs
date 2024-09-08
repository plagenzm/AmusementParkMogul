using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementParkMogul
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to your theme park!");

            Console.WriteLine();
            Console.WriteLine("---");
            Console.WriteLine();

            //creating a rollercoaster object
            Rollercoaster viper = new Rollercoaster();
            viper.Name = "Viper";
            viper.Color = "black";
            viper.Material = "wood";
            viper.Length = 200;
            viper.calculateCost();
            viper.getRollercoasterInfo();
            PropertyPrinter.PrintProperties(viper);


            Console.WriteLine();
            Console.WriteLine("---");
            Console.WriteLine();

            //creating a gentle ride object
            GentleRide hauntedMansion = new GentleRide();
            hauntedMansion.Name = "The Haunted Mansion";
            hauntedMansion.squareFoot = 2500;
            hauntedMansion.calculateCost();
            hauntedMansion.getGentleRideInfo();
            PropertyPrinter.PrintProperties(hauntedMansion);

            Console.WriteLine();
            Console.WriteLine("---");
            Console.WriteLine();

            //creating a shop object
            Shop northBalloonShop = new Shop();
            northBalloonShop.Name = "Balloon Shop - North Entrance";
            northBalloonShop.squareFoot = 800;
            northBalloonShop.calculateCost();
            northBalloonShop.getShopInfo();
            PropertyPrinter.PrintProperties(northBalloonShop);



            //had to put this in or the console would automatically close
            Console.ReadLine();
        }
    }
}
