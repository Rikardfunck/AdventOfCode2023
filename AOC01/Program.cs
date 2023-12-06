// AOC01 #1 + #2
using System.Text.RegularExpressions;
using Shared;

var dataAsRows = Helpers.ReadContentAndSplitFromInputFile();
var sumOfAll = 0;
var numbersAsWords = new (string, string)[] { ("one", "1"), ("two", "2"), ("three", "3"), ("four", "4"), ("five", "5"), ("six", "6"), ("seven", "7"), ("eight", "8"), ("nine", "9") };

foreach (var row in dataAsRows)
{
    var matched = new Dictionary<int, string>();

    foreach (var wordTuple in numbersAsWords)
    {
        var numericMatches = Regex.Matches(row, wordTuple.Item2);

        if (numericMatches.Count > 0)
        {
            foreach (Match numericMatch in numericMatches)
            {
                matched.Add(numericMatch.Index, wordTuple.Item2);
            }
        }

        var alphabeticalMatches = Regex.Matches(row, wordTuple.Item1);

        if (alphabeticalMatches.Count > 0)
        {
            foreach (Match alphabeticalMatch in alphabeticalMatches)
            {
                matched.Add(alphabeticalMatch.Index, wordTuple.Item2);
            }
        }
    }

    var firstString = matched.MinBy(item => item.Key).Value;
    var lastString = matched.MaxBy(item => item.Key).Value;

    if (int.TryParse($"{firstString}{lastString}", out int result))
    {
        sumOfAll += result;
    }
}

Console.WriteLine($"Sum: {sumOfAll}");