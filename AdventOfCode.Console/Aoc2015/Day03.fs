module Aoc2015.Day03

type Point = (int * int)

let pointApplyDirection (point: Point, c: char): Point = 
    let x', y' = 
        match c with
        | '^' -> (0, 1)
        | 'v' -> (0, -1)
        | '<' -> (-1, 0)
        | '>' -> (1, 0)
        | _ -> (0, 0)
    let x, y = point
    (x + x', y + y')

let visited (initialSet: Set<Point>) (directions: string) : Set<Point> =
    for c in directions do
        
