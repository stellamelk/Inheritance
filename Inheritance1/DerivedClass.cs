﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class DerivedClass : BaseClass
    {
        public int derivedField;
        public DerivedClass(int number1, int number2)
        {
            _baseNumber = number1;
            derivedField = number2;

        }
    }
}
