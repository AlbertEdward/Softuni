using System;
using System.Collections.Generic;
using System.Text;

namespace ManufacturingPhones
{
    public class Smartphone : ICalling, IBrowsing
    {
        public List<string> Site { get; set; }
        public List<string> Number { get; set; }

        public void Calling()
        {
            if (Number.Count == 7)
            {
                for (int i = 0; i < Number.Count; i++)
                {
                    if()
                    {


                    }
                }
                Console.WriteLine($"Dialing... {Number}");
            }
            else if (Number.Count == 10)
            {
                Console.WriteLine($"Calling... {Number}");
            }
        }
    }
}
