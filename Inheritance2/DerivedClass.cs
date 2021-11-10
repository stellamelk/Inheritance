using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class DerivedClass
    {
        public int derivedField;
        public DerivedClass()
        {

        }
        public DerivedClass(int num1, int num2)
            : base(num1)
        {
            derivedField = num2;
        }
    }
}
