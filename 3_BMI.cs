using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj wagę");
        double waga;
        
        waga = inputValue();
        Console.WriteLine("Podaj wzrost");
        double wzrost;
        
        wzrost = inputValue();
        double bMI;
        
        bMI = waga / (wzrost * wzrost);
        Console.WriteLine(waga / (wzrost * wzrost));
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
