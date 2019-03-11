using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel
{
    public class CPU : IProduct
    {
        public void Print()
        {
            Console.WriteLine("CPU");
        }
    }
}
