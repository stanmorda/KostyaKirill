namespace Figures.figures;

public class Figure
{
    public virtual double Area { get;  }
    public virtual double Perimeter { get; }

    private static int _count;
    
    
    public Figure(string title)
    {
        Title = title;
        CreateDate = DateTime.UtcNow;
        _count++;
    }

    public string Title { get; set; }
    
    public DateTime CreateDate { get; set; }

    public string GetTitle()
    {
        return $"{Title}[#{_count}]-{CreateDate}";
    }
}