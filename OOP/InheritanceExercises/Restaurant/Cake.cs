﻿using System;
namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double defaultGrams = 250;

        private const double defaultCalories = 1000;

        public const decimal CakePrice = 5m;

        public Cake(string name)
            : base(name, CakePrice, defaultGrams, defaultCalories)
        {
            
        }
    }
}
