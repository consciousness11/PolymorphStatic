using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphStatic
{
    class PolyRunChild2:PolyRun
    {
        double length;

        public PolyRunChild2()
        {
            this.length = 3.3;
        }

        public override double area()
        {
            return length * length;
        }
    }
}
