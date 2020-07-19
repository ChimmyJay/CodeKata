using System.Collections.Generic;
using System.Linq;

namespace CodeKata
{
    public class StringAverager
    {
        private const string InvalidString = "n/a";

        private readonly Dictionary<string, int> _lowerCaseSingleDigitLetterLookup = new Dictionary<string, int>
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9},
        };

        private string[] _letters;

        public string AverageString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return InvalidString;
            }

            GetLetters(str);
            if (!IsValid())
            {
                return InvalidString;
            }

            return GetLetter(CalculateAverage());
        }

        private double CalculateAverage()
        {
            var average = _letters.Average(x => _lowerCaseSingleDigitLetterLookup[x]);
            return average;
        }

        private string GetLetter(double average)
        {
            return _lowerCaseSingleDigitLetterLookup.First(x => x.Value == (int) average).Key;
        }

        private void GetLetters(string str)
        {
            _letters = str.Split(' ');
        }

        private bool IsValid()
        {
            return _letters.All(x => _lowerCaseSingleDigitLetterLookup.ContainsKey(x));
        }
    }
}