using NUnit.Framework;
using System;
using System.Linq;

namespace DatabaseTests
{
    public class Test
    {
        private Database.Database database;

        [SetUp]
        public void SetUp()
        {
            this.database = new Database.Database();
        }

        [Test]
        public void CheckArrayThatIsItEqualTo16()
        {
            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }
            Assert.That(database.Count, Is.EqualTo(16));
        }


        [Test]
        public void Add_ThrowException_WhenCapacityExceeded()
        {
            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(17));
        }

        [Test]
        public void Remove_()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void Add_AddElementToDatabase()
        {
            int element = 12;

            database.Add(element);

            int[] elements = database.Fetch();

            Assert.IsTrue(elements.Contains(element));

        }



        //i am stupid, very much

    }
} 
