using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS6
{
    class Proxy: AbstractFunction
    {
        RealFunction realFunction;
        public override void RequestIgnition(string inputCode)
        {
            if(realFunction==null)
            {
                realFunction = new RealFunction();
                realFunction.RequestIgnition(inputCode);
            }
        }
        public override void RequestJamming(string inputCode)
        {
            if (realFunction == null)
            {
                realFunction = new RealFunction();
                realFunction.RequestJamming(inputCode);
            }
        }
    }
}
