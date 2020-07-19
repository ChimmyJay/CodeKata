using NUnit.Framework;

namespace CodeKata.UnitTest
{
    public class StringAverageTests
    {
        private string _actual;
        private StringAverager _stringAverager;
        private const string InvalidOutput = "n/a";

        [SetUp]
        public void Setup()
        {
            _stringAverager = new StringAverager();
        }

        [Test]
        public void return_na_when_invalid_input()
        {
            Assert.AreEqual("n/a", InvalidOutput);
            GivenInput("invalid input");
            OutputShouldBe(InvalidOutput);
        }

        [Test]
        public void invalid_input_when_input_is_empty()
        {
            GivenInput("");
            OutputShouldBe(InvalidOutput);
        }

        [Test]
        public void invalid_input_when_input_is_null()
        {
            GivenInput(null);
            OutputShouldBe(InvalidOutput);
        }

        [Test]
        public void invalid_input_when_input_contain_not_number_letter()
        {
            GivenInput("abc");
            OutputShouldBe(InvalidOutput);
        }

        [Test]
        public void invalid_input_when_letter_not_single_digit_number()
        {
            GivenInput("ten");
            OutputShouldBe(InvalidOutput);
        }

        [Test]
        [TestCase("Zero")]
        [TestCase("ZERO")]
        public void invalid_input_when_letter_not_lower_case(string input)
        {
            GivenInput(input);
            OutputShouldBe(InvalidOutput);
        }

        [Test]
        public void return_average_floored_letter_when_valid_input()
        {
            GivenInput("zero nine");
            OutputShouldBe("four");
        }

        private void OutputShouldBe(string expected)
        {
            Assert.AreEqual(expected, _actual);
        }

        private void OutputShouldNotBe(string expected)
        {
            Assert.AreNotEqual(expected, _actual);
        }

        private void GivenInput(string input)
        {
            _actual = _stringAverager.AverageString(input);
        }
    }
}