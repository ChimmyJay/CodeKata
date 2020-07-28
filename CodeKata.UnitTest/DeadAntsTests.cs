using NUnit.Framework;

namespace CodeKata.UnitTest
{
    public class DeadAntsTests
    {
        private DeadAnts _deadAnts;
        private int _deadAntCount;

        [SetUp]
        public void SetUp()
        {
            _deadAnts = new DeadAnts();
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void return_0_when_input_is_invalid(string input)
        {
            GivenAnts(input);
            DeadAntsCountShouldBe(0);
        }

        [Test]
        [TestCase("ant ant ant ant", 0)]
        [TestCase("ant anantt aantnt", 2)]
        [TestCase("ant ant .... a nt", 1)]
        public void return_dead_ants_counts_when_input_valid(string input, int expected)
        {
            GivenAnts(input);
            DeadAntsCountShouldBe(expected);
        }

        private void DeadAntsCountShouldBe(int expected)
        {
            Assert.AreEqual(expected, _deadAntCount);
        }

        private void GivenAnts(string ants)
        {
            _deadAntCount = _deadAnts.DeadAntCount(ants);
        }
    }
}