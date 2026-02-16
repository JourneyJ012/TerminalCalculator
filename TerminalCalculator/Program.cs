class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: TerminalCalculator <operation> <numbers separated by commas>");
            return;
        }

        string operation = args[0].ToLower();
        string[] numberStrings = args[1].Split(',');

        double[] numbers;
        try
        {
            numbers = numberStrings.Select(n => Convert.ToDouble(n)).ToArray();
        }
        catch 
        {
            Console.WriteLine("Contains an invalid number");
            return;
        }

        double result = 0.0; //Has to have a value
        
        switch (operation)
        {
            case "add":
                result = numbers.Sum();
                break;
            
            case "subtract":
                result = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    result-= numbers[i];
                }
                break;
            case "multiply":
                result = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    result*= numbers[i];
                }
                break;
            case "divide":
                result = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] == 0)
                    {
                        Console.WriteLine("Divide by zero not allowed!");
                        return;
                    }
                    result/= numbers[i];
                }
                break;
            default:
                Console.WriteLine("Not supported operation!");
                return;
        }
        
        Console.WriteLine($"Result: {result}");
    }
}