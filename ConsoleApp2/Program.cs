
void Calc()
{
    int result = 0;
    var x = 5;
    int y = 0;
    try
    {
        result = x / y;
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine("Catch DivideByZeroException");
        throw;
    }
    catch (Exception e)
    {
        Console.WriteLine("Catch Exception");
    }
    finally
    {
        throw new MyCustomException();
    }
}


try
{
    Calc();
}
catch (MyCustomException e)
{
    Console.WriteLine("Catch MyCustomException");
    throw;
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Catch Exception");
}
Console.ReadLine();



class MyCustomException : DivideByZeroException
{

}
 