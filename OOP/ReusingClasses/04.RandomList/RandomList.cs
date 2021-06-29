using System;
using System.Collections.Generic;

namespace _04.RandomList
{
    public class RandomList
    {
        private data = new List<string>();

        public List<string> data { get; set; }

        public string RandomString()
        {
            var random = new Random();C

            string index = random.Next(Data.Count);

            return index;
        }
    }
}
