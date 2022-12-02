namespace AOC;

public static class FileInterraction
{
    public static IEnumerable<string> ReadWholeContent(string path)
    {
        return File.ReadAllLines(path);
    }
}