using BenchmarkDotNet.Attributes;
using static System.Math;

[MemoryDiagnoser]
public class CircleFunctions
{
    [Benchmark]
    public static void PrintArea()
    {
        Console.WriteLine("Area : " + new Circle(7).Area);
    }

    [Benchmark]
    public static void PrintCircumference()
    {
        Console.WriteLine("Circumference: " + new Circle(7).Circumference);
    }

    [Benchmark]
    public void PrintAreaUsingNormalMethod()
    {
        const double radius = 7;
        Console.WriteLine("Area : " + 2 * PI * radius);
    }

    [Benchmark]
    public void PrintCircumferenceNormalMethod()
    {
        const double radius = 7;
        Console.WriteLine("Area : " + 2*radius*radius);
    }
}