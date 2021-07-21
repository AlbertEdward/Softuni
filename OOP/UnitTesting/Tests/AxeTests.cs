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
            Axe axe = new Axe(10,10);

            axe.Attack();

            Assert.That(axe.Durability, Is.EqualTo(1), "Axe Durability doesn't change after attack.");
        }
    }
}
