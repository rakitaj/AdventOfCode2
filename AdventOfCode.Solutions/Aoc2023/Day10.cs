namespace AdventOfCode.Solutions.Aoc2023;

using AdventOfCode.Solutions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Day10 : Answer
{
    public Grid<char> PipesGrid { get; }

    public Dictionary<char, List<Tuple<int, int>>> Directions = new Dictionary<char, List<Tuple<int, int>>>
    {
        ['|'] = [ Tuple.Create(0, 1), Tuple.Create(0, -1)],
        ['-'] = [ Tuple.Create(1, 0), Tuple.Create(-1, 0)],
        ['L'] = [ Tuple.Create(0, -1), Tuple.Create(1,0)],
        ['J'] = [ Tuple.Create(0, -1), Tuple.Create(-1, 0)],
        ['7'] = [ Tuple.Create(0, 1), Tuple.Create(-1, 0)],
        ['F'] = [ Tuple.Create(0, 1), Tuple.Create(1, 0)]
    };

    public List<Point> FindPath(Point start)
    {

    }

    public Day10(Grid<char> grid) : base(2023, 10)
    {
        this.PipesGrid = grid;
    }

    public override string Part1()
    {
        throw new NotImplementedException();
    }

    public override string Part2()
    {
        throw new NotImplementedException();
    }
}

