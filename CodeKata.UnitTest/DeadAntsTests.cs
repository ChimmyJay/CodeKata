using NUnit.Framework;

namespace CodeKata.UnitTest
{
    public class DeadAntsTests
    {
        private DeadAnts _deadAnts;

        [Test]
        public void return_0_when_input_is_invalid()
        {
            Assert.AreEqual(0, _deadAnts.DeadAntCount(null));
            Assert.AreEqual(0, _deadAnts.DeadAntCount(""));
        }

        [Test]
        public void return_dead_ants_counts_when_input_valid()
        {
            var deadAnts = new DeadAnts();
            Assert.AreEqual(0, deadAnts.DeadAntCount("ant ant ant ant"));
            Assert.AreEqual(2, deadAnts.DeadAntCount("ant anantt aantnt"));
            Assert.AreEqual(1, deadAnts.DeadAntCount("ant ant .... a nt"));
        }

        [SetUp]
        public void SetUp()
        {
            _deadAnts = new DeadAnts();
        }
    }
}