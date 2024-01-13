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

let housesVisited (startingPoint: Point) (directions: string) : Set<Point> =
    let mutable pointSet: Set<Point> = Set([startingPoint])
    let mutable point = startingPoint
    for c in directions do
        let nextPoint = pointApplyDirection(point, c)
        pointSet <- pointSet.Add(nextPoint)
        point <- nextPoint
    pointSet

let housesVisitedDuo (startingPoint: Point) (directions: string) : Set<Point> =
    let mutable pointSet: Set<Point> = Set([startingPoint])
    let mutable santaPoint = startingPoint
    let mutable roboSantaPoint = startingPoint
    for i in 0..directions.Length - 1 do
        if i % 2 = 0 then
            let nextSantaPoint = pointApplyDirection(santaPoint, directions[i])
            pointSet <- pointSet.Add(nextSantaPoint)
            santaPoint <- nextSantaPoint
        else
            let nextRoboSantaPoint = pointApplyDirection(roboSantaPoint, directions[i])
            pointSet <- pointSet.Add(nextRoboSantaPoint)
            roboSantaPoint <- nextRoboSantaPoint
    pointSet

let part1Solution = 
    let line = DataLoaders.readFile(2015, "day03.txt")
    let visited = housesVisited (0, 0) line
    visited.Count

let part2Solution = 
    let line = DataLoaders.readFile(2015, "day03.txt")
    let visited = housesVisitedDuo (0, 0) line
    visited.Count