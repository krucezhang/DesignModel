using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel
{
    public class CPUFactory : IFactory
    {
        public IProduct ConcrateProduct()
        {
            return new CPU();
        }
    }
}
