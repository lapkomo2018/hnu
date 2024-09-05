using System.IO.Compression;
using System.Net;

namespace Task4;

class Program {


    static double Z(double a, double b) => b * Math.Tan(a);
    static double A(int i) {
        double result = 0;
        for (int x = 1; x <= i+3; x++) {
            result += F(x);
        }
        return result;
    }
    static double B(int i) {
        double result = 1;
        for (int x = 1; x <= i+7; x++) {
            result *= F(x);
        }
        return result;
    }

    static double F(double x) => Math.Abs(Math.Sin(2*x - 1.5) + 3*Math.Sin(Math.Pow(x, 2))) + 2.38;

    const int I = 7;

    static void Main() {
        double a = A(I), b = B(I);
        double z = Z(a,b);
        Console.WriteLine($"A: {a}\nB: {b}\nZ: {z}");
    }
}