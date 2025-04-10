using AkvelonApp;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your text:");

        string line;
        var inputLines = new List<string>();

        while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
        {
            inputLines.Add(line);
        }

        string input = string.Join("\n", inputLines);

        if (!string.IsNullOrEmpty(input))
        {
            var result = Result.GetOutput(input);
            Console.WriteLine("Word Count: " + result.Count);
            Console.WriteLine("Final Output:\n" + result.FinalOutput);
        }
        else
        {
            Console.WriteLine("input should not be null");
        }

        Console.ReadKey();
    }
}
