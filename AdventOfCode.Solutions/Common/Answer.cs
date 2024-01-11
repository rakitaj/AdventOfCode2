namespace AdventOfCode.Solutions.Common;

public abstract class Answer
{
    public abstract string Part1();

    public abstract string Part2();

    public int Year { get; init; }
    public int Day { get; init; }

    public Answer(int year, int day)
    {
        this.Year = year;
        this.Day = day;
    }

    public List<string> ReadData()
    {
        var dayFilename = $"day{this.Day:00}.txt";
        return Answer.ReadData(this.Year, dayFilename);
    }

    public static List<string> ReadData(int year, string filename)
    {
        var filepath = Path.Join(year.ToString(), filename);
        return File.ReadLines(filepath).ToList();
    }
}

