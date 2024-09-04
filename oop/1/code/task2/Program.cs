namespace Task2;

using static System.Math;

class Task2
{
    const double V(double x, double b, double a, int i) => Math.Tan(x/i + a) - Math.Log10(Math.Abs(b*i+7));
    
        
    static void Main()
    {
        Console.WriteLine("Input x: ");
        double x = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Input a: ");
        double a = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Input b: ");
        double b = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Input i: ");
        int i = int.Parse(Console.ReadLine());
        
    }
}
