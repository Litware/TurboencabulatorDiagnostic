using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboencabulatorDiagnostic
{
    class Hat
    {
        public static void GetHatSize()
        {
            Console.Write("Width of vehicle in inches: ");
            string widthString = Console.ReadLine();

            Console.Write("length of vehicle roof in inches: ");
            string lengthString = Console.ReadLine();

            float width;
            float.TryParse(widthString, out width);

            float length;
            float.TryParse(lengthString, out length);

            float circumference = width * 2 + length * 2;

            // used hat size table and estimated a linear trend
            Console.WriteLine("The vehicle's hat size is: " + (circumference * .35 + .54));
        }
    }
}
