using EverybodyCodes.Common;

namespace AdventOfCode.CSharp.Aoc2024;

public class Day01 : Answer
{
    private List<string> _raw;

    public Day01() : base(2024, 1)
    {
        this._raw = this.ReadData();
    }

    public override string Part1()
    {
        var left = new List<int>();
        var right = new List<int>();
        foreach(var line in this._raw)
        {
            var parts = line.Split();
            left.Add(int.Parse(parts[0]));
            right.Add(int.Parse(parts[1]));
        }
        var sortedLeft = left.Order();
        var sortedRight = right.Order();
        var combined = sortedLeft.Zip(sortedRight);
        var totalDifference = combined.Select(x => Math.Abs(x.First - x.Second)).Sum();
        return totalDifference.ToString();
    }

    public override string Part2()
    {
        throw new NotImplementedException();
    }
}