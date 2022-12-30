public readonly record struct Circle(double radius)
{
    public double Area => Math.PI * radius * radius;
    
    public double Circumference =>  2 * Math.PI * radius;
}