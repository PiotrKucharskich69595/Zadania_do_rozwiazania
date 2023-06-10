using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int liczba1, liczba2;
        
        Console.WriteLine("Podaj pierwszą liczbę");
        liczba1 = (int) inputValue();
        Console.WriteLine("Podaj drugą liczbę");
        liczba2 = (int) inputValue();
        if (liczba1 > liczba2)
        {
            Console.WriteLine(liczba1);
        }
        else
        {
            Console.WriteLine(liczba2);
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
