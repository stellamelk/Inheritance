using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass(1, 2);

            Console.WriteLine(instance._baseNumber);
            Console.WriteLine(instance.derivedField);
        }
    }
}
