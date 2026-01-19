// See https://aka.ms/new-console-template for more information

using CoordinateStruct;

Console.WriteLine("Hello, World!");
Coordinate coordinate1  = new Coordinate(1, 2);
Coordinate coordinate2  = new Coordinate(2, 5);
Coordinate coordinate3  = new Coordinate(5, 10);
Coordinate coordinate4  = new Coordinate(10, 15);
Coordinate coordinate5  = new Coordinate(1, 6);

coordinate2.IsCoordinateAdjacent(coordinate1);
coordinate2.IsCoordinateAdjacent(coordinate5);
coordinate2.IsCoordinateAdjacent(coordinate3);
coordinate2.IsCoordinateAdjacent(coordinate4);