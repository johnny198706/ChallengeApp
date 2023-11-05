using challengeApp;

Console.WriteLine("Witam w Programie MtW do oceny Pracownika");
Console.WriteLine("=========================================");
Console.WriteLine();

var employee = new Employee("Rafał", "Stefański", 32);

while (true)
{
    Console.WriteLine("Podaj kolejną ocene pracownika: ");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
