﻿// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using static System.Console;
using static System.Math;

WriteLine("Record struct in C#...");

BenchmarkRunner.Run<CircleFunctions>();

/*
Circle c1 = new(7);

var area = c1.Area;
var circumference = c1.Circumference;

Console.WriteLine("Area : " + area);
Console.WriteLine("Circumference: " + circumference);
*/

[MemoryDiagnoser]
public class CircleFunctions
{
    [Benchmark]
    public static void PrintArea()
    {
        WriteLine("Area : " + new Circle(7).Area);
    }

    [Benchmark]
    public static void PrintCircumference()
    {
        WriteLine("Circumference: " + new Circle(7).Circumference);
    }

    [Benchmark]
    public void PrintAreaUsingNormalMethod()
    {
        const double radius = 7;
        WriteLine("Area : " + 2*PI*radius);
    }

    [Benchmark]
    public void PrintCircumferenceNormalMethod()
    {
        const double radius = 7;
        WriteLine("Area : " + 2*radius*radius);
    }
}

//using record struct to find the area of circle from radius 

public readonly record struct Circle(double radius)
{
    public double Area => PI * radius * radius;
    
    public double Circumference =>  2 * PI * radius;
}