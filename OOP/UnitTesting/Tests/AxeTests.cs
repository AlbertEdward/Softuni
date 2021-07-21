using NUnit.Framework;
using System;
using TestAxe;

namespace Tests
{
    [TestFixture()]
    public class AxeTests
    {
        [Test()]
        public void AxeLoosesDurabilityAfterAttack()
        {
            int attack = 5;
            int durability = 6;
            Axe axe = new Axe(attack, durability);

            Assert.AreEqual(axe.AttackPoints, attack);
            Assert.AreEqual(axe.DurabilityPoints, durability);



        }
    }
}
