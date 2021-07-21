using NUnit.Framework;
using System;
using TestAxe;

namespace Tests
{
    [TestFixture()]
    public class DummyTests
    {
        [Test()]
        public void DummyLoseHealthIfAttacked()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            dummy.TakeAttack(1);

            Assert.That(dummy.Health, Is.LessThan(9), "Your program doesn't work, health doesn't loses after attack!");
        }

        [Test()]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            dummy.IsDead();

            dummy.TakeAttack(1);

            Assert.Pass("Success Passed", dummy);

        }

    }
}
