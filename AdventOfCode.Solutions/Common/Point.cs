﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Solutions.Common
{
    public record class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString() => $"({this.X}, {this.Y})";
    }
}
