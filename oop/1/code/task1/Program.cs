namespace task1;
class Task1 {
    const double g = 9.807;
    static double E(double m, double v) => m*Math.Pow(v, 2)/2;
    static double P(double m, double h) => m*g*h; 
    
    static void Main() {
        Console.WriteLine("Input m: ");
        double m = double.Parse(Console.ReadLine());
    
        Console.WriteLine("Input h: ");
        double h = double.Parse(Console.ReadLine());
    
        Console.WriteLine("Input v: ");
        double v = double.Parse(Console.ReadLine());
    
        Console.WriteLine($"m: {m}; h: {h}; v: {v}");
        Console.WriteLine($"E: {E(m,v)}\nP: {P(m,h)}");
    }
}