using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AmusementParkMogul
{
    internal class PropertyPrinter
    {
        public static void PrintProperties(object obj)
        {
            // here we are getting the datatype
            Type type = obj.GetType();

            // here we are getting all of the object's properties
            PropertyInfo[] properties = type.GetProperties();
            
            Console.WriteLine();
            Console.WriteLine("Here is the system reflection:");
            // Iterate through each property
            foreach (var property in properties)
            {
                // Print the property name
                Console.WriteLine("Property: " + property.Name);

                // Print the datatype
                Console.WriteLine("Property Data Type: " + property.PropertyType);

                Console.WriteLine(); 
            }
        }
    }
}
