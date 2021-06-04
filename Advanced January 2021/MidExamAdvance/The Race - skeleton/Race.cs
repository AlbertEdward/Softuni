using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {

        public List<Racer> Data { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return Data.Count; } }

        public Race(string name, int capacity)
        {
            Data = new List<Racer>();
            Name = name;
            Capacity = capacity;
        }

        public void Add(Racer Racer)
        {
            if (Data.Count < Capacity)
            {
                Data.Add(Racer);
            }
        }
        public bool Remove(string name)
        {
            Racer findRacer = Data.FirstOrDefault(x => x.Name == name);
            return Data.Remove(findRacer);
        }

        public Racer GetOldestRacer()
        {
            return Data.OrderByDescending(x => x.Age).FirstOrDefault();
        }
        public Racer GetRacer(string name)
        {
            Racer getRacer = Data.FirstOrDefault(x => x.Name == name);
            return getRacer;
        }
        public Racer GetFastestRacer()
        {
            return Data.OrderByDescending(x => x.Car.Speed).FirstOrDefault();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {this.Name}:");
            foreach (var racer in Data)
            {
                sb.AppendLine($"{racer}");
            }
            return sb.ToString().TrimEnd();
        }

    }
}