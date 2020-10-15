using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {

// 6 6 5 3 3 2
            
 //
            // --------------------------
            //           3                         
            //         1
            //         2
            // 3 1 5 6 1 2
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int broq4 = 0;

            for (int a = 0; a < num.Length-1; a++)
            {
                for (int b = a + 1; b < num.Length ; b++)
                {
                    for (int i = 0; i < num.Length; i++)
                    { 
                        if(num[a] + num[b] == num[i])
                        {
                            Console.WriteLine($"{num[a]} + {num[b]} == {num[i]}");

                            broq4++;
                        }
                    
                    }
                }
            }

            if(broq4 == 0) {
                Console.WriteLine("No");
            }
        }
    }
}
