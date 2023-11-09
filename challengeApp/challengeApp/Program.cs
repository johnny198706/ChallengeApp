using challengeApp;
using ChallengeApp;

Console.WriteLine("Witam w Programie MtW do oceny Kierownika");
Console.WriteLine("=========================================");
Console.WriteLine();

//var employee = new Employee("Rafał", "Stefański",'M', 32);
var manager = new Manager("Sebastian", "Bąk", 'M', 36);
while (true)
{
    Console.WriteLine("Wpisz kolejną ocene kierownika:  ");
    var input = Console.ReadLine();
    if (input == "Q" || input == "q")
    {
        break;
    }
    
    try
    {
        manager.AddGrade(input);
    }
    catch (Exception m)
    {
        Console.WriteLine($"Exception catched: {m.Message}");
    }
}

//var statistics = employee.GetStatistics();

//Console.WriteLine();
//Console.WriteLine($"Average: {statistics.Average}");
//Console.WriteLine($"Max: {statistics.Max}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");

var statistics = manager.GetStatistics();

Console.WriteLine();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"AverageNumber: {statistics.AverageNumber}");
