using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            PolyTest pt = new PolyTest();
            int sum1 = pt.sum(4, 5);
            int sum2 = pt.sum(2, 5, 7);

           // Console.WriteLine("two para sum" + sum1);
           // Console.WriteLine("three para sum" + sum2);
      


            PolyRunChild prc = new PolyRunChild();
            Console.WriteLine("Area " + prc.area());
            PolyRunChild2 prc2 = new PolyRunChild2();
            Console.WriteLine("Area " + prc2.area());
            Console.ReadLine();
        }
    }
}
