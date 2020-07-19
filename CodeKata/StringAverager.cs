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

        public string AverageString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return InvalidString;
            }

            str = str.Trim();
            var letters = GetLetters(str);
            return letters.All(IsValid)
                ? GetLetter(GetFlooredAverage(letters))
                : InvalidString;
        }

        private int GetFlooredAverage(IEnumerable<string> letters)
        {
            var flooredAverage = (int) letters.Average(x => _lowerCaseSingleDigitLetterLookup[x]);
            return flooredAverage;
        }

        private string GetLetter(int flooredAverage)
        {
            var averageString = _lowerCaseSingleDigitLetterLookup.First(x => x.Value == flooredAverage).Key;
            return averageString;
        }

        private static string[] GetLetters(string str)
        {
            var letters = str.Split(' ');
            return letters;
        }

        private bool IsValid(string letter)
        {
            return _lowerCaseSingleDigitLetterLookup.ContainsKey(letter);
        }
    }
}