namespace Figures.figures;

public class Circle : Figure
{
    public int Radius { get; set; }

    public Circle(int radius, string title) : base(title)
    {
        Radius = radius;
    }
    
    public Circle(double radius, string title) : this((int)radius, title)
    {
    }

    public override double Perimeter => 2 * Math.PI * Radius;
    public override double Area => Math.PI * Radius * Radius;
}