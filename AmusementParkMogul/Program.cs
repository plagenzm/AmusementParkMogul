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

            //creating a rollercoaster object
            Rollercoaster rollercoaster = new Rollercoaster();
            rollercoaster.Name = "Viper";
            rollercoaster.Color = "black";
            rollercoaster.Material = "wood";
            rollercoaster.Length = 200;
            rollercoaster.CalculateRollercoasterCost();
            rollercoaster.getRollercoasterInfo();




            //had to put this in or the console would automatically close
            Console.ReadLine();
        }
    }
}
