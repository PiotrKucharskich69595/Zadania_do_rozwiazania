using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double poleKola;
        
        poleKola = inputValue();
        double promien;
        
        promien = Math.Sqrt(poleKola / Math.PI);
        Console.WriteLine(promien);
        int obwodKola;
        
        obwodKola = (int) (2 * Math.PI * promien);
        Console.WriteLine(obwodKola);
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
