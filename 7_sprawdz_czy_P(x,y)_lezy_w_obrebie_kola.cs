using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int x, y, r, odlegloscOdSrodka;
        
        Console.WriteLine("Podaj x");
        x = (int) inputValue();
        Console.WriteLine("Podaj y");
        y = (int) inputValue();
        Console.WriteLine("Podaj r");
        r = (int) inputValue();
        if (x * x + y * y <= r * r)
        {
            Console.WriteLine("Wybrane współrzędne znajdują się w obrębie koła");
        }
        else
        {
            Console.WriteLine("Wpisane współrzędne nie znajdują się w obrębie koła");
        }
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
