namespace DateGreeter;

class Program
{
    static void Main(string[] args)
    {
        string YourName;


        while (true)
        {
            YourName = NameMaker();

            if (!string.IsNullOrWhiteSpace(YourName))  
            {
                break; 
            }

            Console.WriteLine("Error! You did not insert a valid name! Try again :3 (your string is empty :( please fill out)");
        }

        int dateCheck = DateTime.Now.Hour;
        string greetify = Checker(dateCheck, YourName);
        Console.WriteLine(greetify);
    }

    private static string NameMaker()
    {
        Console.Write("Please insert your name: ");
        string? nameInput = Console.ReadLine();
        return nameInput ?? "";  
    }

    private static string Checker(int numberToBeChecked, string YourName)
    {
        var greetings = new Dictionary<Func<int, bool>, string>
        {
            { time => time >= 0 && time < 5, $"Good night {YourName}. zzzz" },
            { time => time >= 5 && time < 12, $"{YourName}! Good morning!" },
            { time => time >= 12 && time < 18, $"Good afternoon! {YourName}" },
            { time => time >= 18 && time <= 23, $"Good evening~ {YourName}" }
        };

        foreach (var entry in greetings)
        {
            if (entry.Key(numberToBeChecked))
            {
                return entry.Value;
            }
        }

        return $"{YourName}! You are in a time that doesn't exist! Quick leave limbo!";
    }
}
