namespace DateGreeter;

class Program
{
    static void Main(string[] args)
    {
        string YourName = NameMaker();
        
        if (YourName != "") {
        int dateCheck = DateTime.Now.Hour;
        string greetify = Checker(dateCheck, YourName);
        Console.WriteLine(greetify);
        } 

    }
    private static string NameMaker()
    {
        Console.Write("Please insert your name: ");
        string? nameInput = Convert.ToString(Console.ReadLine());
        return nameInput;
    }

    private static string Checker(int numberToBeChecked, string YourName)
    {
        if (numberToBeChecked >= 0 && numberToBeChecked < 5)
        {
            return $"Good night {YourName}. zzzz";
        }
        if (numberToBeChecked >= 5 && numberToBeChecked < 12)
        {
            return $"{YourName}! Good morning!";
        }
        if (numberToBeChecked >= 12 && numberToBeChecked < 18)
        {
            return $"Good afternoon! {YourName}";
        }
        if (numberToBeChecked >= 18 && numberToBeChecked <= 23)
        {
            return $"Good evening~ {YourName}";
        }
        
        return $"{YourName}! You are in a time that doesnt exist! Quick leave limbo!"; 
    }
}
