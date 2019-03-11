using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new CPUFactory();
            factory.ConcrateProduct().Print();

            Console.ReadKey();
        }
    }
}
