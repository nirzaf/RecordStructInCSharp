// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using static System.Console;

WriteLine("Record struct in C#...");

//BenchmarkRunner.Run<CircleFunctions>();

Circle c1 = new(7);

var area = c1.Area;
var circumference = c1.Circumference;

WriteLine("Area : " + area);
WriteLine("Circumference: " + circumference);

//using record struct to find the area of circle from radius 