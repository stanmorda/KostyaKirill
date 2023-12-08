// See https://aka.ms/new-console-template for more information

var a1 = new Taburetka("tab1",10);
var copy = a1.Copy();

string title = (copy?.Title) ?? ("empty");

var a2 = new Taburetka("tab2",10, 99);

var data = a2.GetData(out var flag);

(int width, int height) = a2;


var a3 = new Taburetka("tab3",10);
var a4 = new Taburetka("tab4",10);
var a5 = new Taburetka();

// var a2 = new Taburetka(11);
// var a3 = new Taburetka(12);
// var a4 = new Taburetka(13);
// var a5 = new Taburetka(14, 99);


Console.Read();

class Taburetka : Item
{
    public int Width { get; set; }
    public int Height { get; set; }


    public void Deconstruct(out int width, out int height)
    {
        width = Width;
        height = Height;
    }
    
    public Taburetka(string title, int width, int height=50) : base(title)
    {
        Width = width;
        Height = height;
    }
    
    // public Taburetka(string title, int width) : this(title, width, width)
    // {
    // }


    public Taburetka() : base("Табуретка")
    {
      
    }


    public Taburetka? Copy()
    {
        if (Width < 10)
            return null;
        
        return new Taburetka(Title, Width, Height);
    }

    public int GetData(out bool flag)
    {
        flag = Width > Height;
        return Width;
    }

    public override string ToString()
    {
        return $"{base.ToString()} - Width:{Width}. Height: {Height}";
    }
}


class Item
{
    private static int _countOfMadeItems;
    public string Title { get; set; }

    public Item(string title)
    {
        _countOfMadeItems++;
        Title = title;
    }

    public override string ToString()
    {
        return $"{Title}";
    }

    public int CountOfMadeItems => _countOfMadeItems;
}

static class StaticClass
{
    public static int Value { get; set; }

    public static int Test()
    {
        return -100;
    }
}





