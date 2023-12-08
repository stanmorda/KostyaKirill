namespace Figures.figures;

public class Square : Figure
{
    public delegate double CalcPerimeter(int a);

    private CalcPerimeter _calc;

    public int A { get; set; }

    public Square(int a, string title) : base(title)
    {
        A = a;
    }

    public void RegisterCalc(CalcPerimeter func)
    {
        _calc = func;
    }

    public override double Perimeter => _calc?.Invoke(A) ?? throw new ArgumentException("Perimeter logic not defined");

    public override double Area => A*A;
}



public class SquareA : Square
{
    public SquareA(int a, string title) : base(a, title)
    {
        RegisterCalc(
            delegate(int i)
            {
                return i * 4;
            }
            
            );
    }

}

public class SquareB : Square
{

    public SquareB(int a, string title) : base(a, title)
    {
    }

}