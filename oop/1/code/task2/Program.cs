namespace Task2;

class Task2 {
    static double V(double x, int i) {
        double a = InputDouble("Input a: "), b = InputDouble("Input b: ");
        return Math.Tan(x / i + a) - Math.Log10(Math.Abs(b * i + 7));
    }


    static double W(double x, int i){
        double c = InputDouble("Input c: "), d = InputDouble("Input d: ");
        return c * Math.Sqrt(Math.Pow(x, 2) + d * Math.Pow(i, 12));
    }

    const int I = 7;

    static void Main() {
        double x = InputDouble("Input x: ");
        
        double result;
        if (Math.Abs(x) < 10) {
            result = V(x, I);
        } else {
            result = W(x, I);
        }
        Console.WriteLine($"Result: {result}");
    }

    static double InputDouble(string message) {
        Console.WriteLine(message);
        double value;
        while (!double.TryParse(Console.ReadLine(), out value)) {
            Console.WriteLine("Invalid input. Try again.");
        }
        return value;
    }
}
