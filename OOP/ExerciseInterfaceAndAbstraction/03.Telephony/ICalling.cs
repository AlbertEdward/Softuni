using System;
using System.Collections.Generic;

namespace ManufacturingPhones
{
    public interface ICalling
    {
        public List<string> Number { get; set; }

        abstract void Calling();
    }
}
