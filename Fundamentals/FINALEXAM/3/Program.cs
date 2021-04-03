using System;
using System.Linq;
using System.Collections.Generic;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int[]> dict = new Dictionary<string, int[]>();

            string input = Console.ReadLine();

            while (input != "Results")
            {
                string[] splitted = input.Split(':');

                if (splitted[0] == "Add")
                {
                    if (dict.ContainsKey(splitted[1]))
                    {
                        dict[splitted[1]][0] += int.Parse(splitted[2]);
                    }
                    else
                    {
                        int[] n = new int[] { int.Parse(splitted[2]), int.Parse(splitted[3]) };
                        dict.Add(splitted[1], n);
                    }
                }
                else if (splitted[0] == "Attack")
                {
                    string attacker = splitted[1];
                    string deffender = splitted[2];
                    int damage = int.Parse(splitted[3]);

                    if (dict.ContainsKey(attacker) && dict.ContainsKey(deffender))
                    {
                        dict[deffender][0] -= damage;
                        dict[attacker][1] -= 1;

                        if (dict[deffender][0] <= 0)
                        {
                            dict.Remove(deffender);
                            Console.WriteLine($"{deffender} was disqualified!");
                        }
                        if (dict[attacker][1] <= 0)
                        {
                            dict.Remove(attacker);
                            Console.WriteLine($"{attacker} was disqualified!");
                        }
                    }
                }
                else if (splitted[0] == "Delete")
                {
                    if (splitted[1] == "All")
                    {
                        dict = new Dictionary<string, int[]>();
                    } else
                    {
                        dict.Remove(splitted[1]);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"People count: {dict.Count}");

            var keys = dict.Keys.ToArray();
            keys = keys.OrderByDescending(key => dict[key][0]).ThenByDescending(key => dict[key][1]).ThenBy(key => key).ToArray();
                
            foreach (var username in keys)
            {
                Console.WriteLine($"{username} - {dict[username][0]} - {dict[username][1]}");
            }
        }
    }
}
