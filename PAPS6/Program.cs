using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPS6
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFunction func = new Proxy();
            func.RequestIgnition("123");
            func = new Proxy();
            func.RequestIgnition("1234");
            func = new Proxy();
            func.RequestJamming("4321");
            func = new Proxy();
            func.RequestJamming("1337");
            Console.ReadKey();
        }
    }
}
