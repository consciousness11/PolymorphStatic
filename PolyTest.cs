using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphStatic
{
    public class PolyTest
    {
        public int sum(int a, int b, int c)
        {
            return a + b + c;
        }
        public int sum(int a, int b)
        {
            return a + b;
        }

    }
}
