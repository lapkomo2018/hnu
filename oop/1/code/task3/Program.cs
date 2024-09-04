namespace Task3;
class Program {
    static void Main() {
    string? country = "";
    while (string.IsNullOrEmpty(country)){
        Console.WriteLine("Enter country name:");
        country = Console.ReadLine()?.ToUpper();
    }
    char firstLetter = country[0];

    Console.WriteLine($"Using if statement: {UseIf(firstLetter)}");
    Console.WriteLine($"Using switch statement: {UseSwitch(firstLetter)}");
    }

    static string UseIf(char letter){
        if (letter == 'G' || letter == 'H' || letter == 'F'){
            return "Europe";
        } else if (letter == 'V' || letter == 'Q' || letter == 'J'){
            return "Asia";
        } else if (letter == 'B' || letter == 'P' || letter == 'C'){
            return "South America";
        } else {
            return "Unknown";
        }
    }

    static string UseSwitch(char letter){
        switch (letter){
            case 'G' or 'H' or 'F':
                return "Europe";
            case 'V' or 'Q' or 'J':
                return "Asia";
            case 'B' or 'P' or 'C':
                return "South America";
            default:
                return "Unknown";
        }
    }
}
