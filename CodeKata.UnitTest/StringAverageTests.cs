using NUnit.Framework;

namespace CodeKata.UnitTest
{
    public class StringAverageTests
    {
        private string _actual;
        private StringAverager _stringAverager;

        private void GivenInput(string input)
        {
            _actual = _stringAverager.AverageString(input);
        }

        [Test]
        public void input_invalid_when_input_is_empty()
        {
            GivenInput("");
            Assert.IsFalse(IsValidInput());
        }

        [Test]
        [TestCase("Zero")]
        [TestCase("ZERO")]
        public void input_invalid_when_letter_not_lower_case(string input)
        {
            GivenInput(input);
            Assert.IsFalse(IsValidInput());
        }

        [Test]
        public void input_invalid_when_letter_not_single_digit_number()
        {
            GivenInput("ten");
            Assert.IsFalse(IsValidInput());
        }

        private bool IsValidInput()
        {
            return _actual != "n/a";
        }

        [Test]
        public void output_is_floored_whole_number()
        {
            GivenInput("zero one");
            OutputShouldBe("zero");
        }

        private void OutputShouldBe(string expected)
        {
            Assert.AreEqual(expected, _actual);
        }

        private void OutputShouldNotBe(string expected)
        {
            Assert.AreNotEqual(expected, _actual);
        }

        [Test]
        public void return_average_letter_when_input_valid()
        {
            GivenInput("one two three");
            OutputShouldBe("two");
        }

        [SetUp]
        public void Setup()
        {
            _stringAverager = new StringAverager();
        }

        [Test]
        public void when_input_invalid_return_na()
        {
            GivenInput("invalid input");
            OutputShouldBe("n/a");
        }

        [Test]
        public void when_input_valid_return_not_na()
        {
            GivenInput("zero one two three four five six seven eight nine");
            OutputShouldNotBe("n/a");
        }
    }
}