using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel
{
    public class DiskFactory : IFactory
    {
        public IProduct ConcrateProduct()
        {
            return new Disk();
        }
    }
}
