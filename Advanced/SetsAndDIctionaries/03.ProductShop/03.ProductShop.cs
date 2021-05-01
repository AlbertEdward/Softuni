using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> storeProductPrice = new SortedDictionary<string, Dictionary<string, double>>();

            var input = Console.ReadLine().Split(", ");

            while (input[0] != "Revision")
            {
                var store = input[0];
                var product = input[1];
                var price = double.Parse(input[2]);

                if (!storeProductPrice.ContainsKey(store))
                {
                    storeProductPrice.Add(store, new Dictionary<string, double>());
                }

                storeProductPrice[store].Add(product, price);


                input = Console.ReadLine().Split(", ");
            }

            foreach (var store in storeProductPrice)
            {
                Console.WriteLine($"{store.Key}->");

                foreach (var product in store.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }

            
        }
    }
}
