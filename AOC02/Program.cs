using AOC02.Utilities;
using Shared;
using System.Text.RegularExpressions;

// AOC02 #2
var blueMax = 14;
var greenMax = 13;
var redMax = 12;
var sum = 0;
var powerOfSum = 0;

var dataAsRows = Helpers.ReadContentAndSplitFromInputFile();

foreach (var row in dataAsRows)
{
    var cleaned = Regex.Replace(row, "[^0-9a-zA-z\\s]", string.Empty);
    var splitted = cleaned.Split(' ').ToList();

    var blue = splitted.GetValuesWithOffsettFromList("blue", -1).Max();
    var red = splitted.GetValuesWithOffsettFromList("red", -1).Max();
    var green = splitted.GetValuesWithOffsettFromList("green", -1).Max();

    var id = splitted.GetValuesWithOffsettFromList("Game", 1).First();

    if ((green != -1 && green <= greenMax) && (red != -1 && red <= redMax) && (blue != -1 && blue <= blueMax))
    {
        sum += id;
    }

    powerOfSum += blue * red * green;
}

Console.WriteLine($"Sum: {sum}");

// AOC02 #2
Console.WriteLine($"PowerOfSum: {powerOfSum}");