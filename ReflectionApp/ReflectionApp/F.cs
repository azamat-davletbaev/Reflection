using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionApp
{
    public class F
    {
        public int i1;
        public int i2;
        public int i3;
        public int i4;
        public int i5;
        public F() { }
        public F Get() => new F()
        {
            i1 = 1,
            i2 = 2,
            i3 = 3,
            i4 = 4,
            i5 = 5
        };
    }
}
