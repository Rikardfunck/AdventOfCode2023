namespace Shared;

public class Helpers
{
    public static string[] ReadContentAndSplitFromInputFile(string filePath = "Data/input.txt", string separator = "\r\n")
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), filePath);
        var fileContent = File.ReadAllText(path).Split(separator);

        return fileContent;
    }
}
