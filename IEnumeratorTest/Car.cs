﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorTest
{
    class Car
    {
        public Car(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
