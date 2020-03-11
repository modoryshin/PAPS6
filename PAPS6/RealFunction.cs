using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS6
{
    class RealFunction:AbstractFunction
    {
        public override void RequestIgnition(string inputCode)
        {
            if(inputCode=="1234")
            Console.WriteLine("Ignition request accepted");
            else
                Console.WriteLine("Request denied");
        }
        public override void RequestJamming(string inputCode)
        {
            if (inputCode == "4321")
                Console.WriteLine("Jamming request accepted");
            else
                Console.WriteLine("Request denied");
        }
    }
}
