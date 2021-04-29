using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphStatic
{
    class PolyRunChild : PolyRun
    {
        double radius;
        public PolyRunChild()
        {
            this.radius = 5;
        }
        
       

        public override double area()
        {

            Console.WriteLine("Base value" + base.area());
            return (3.14) * this.radius * this.radius;

        }
    }
}
