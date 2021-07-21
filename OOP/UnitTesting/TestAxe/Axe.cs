using System;
namespace TestAxe
{
    public class Axe
    {
        public Axe(int damage, int durability)
        {
            Damage = damage;
            Durability = durability;
        }

        public int Damage { get; set; }
        public int Durability { get; set; }

        public void Attack()
        {
            Durability -= 1;
        }
        
    }
}
