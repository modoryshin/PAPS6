using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS6
{
    public abstract class AbstractFunction
    {
        public abstract void RequestIgnition(string c);
        public abstract void RequestJamming(string c);
    }
}
