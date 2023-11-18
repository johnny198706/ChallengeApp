using challengeApp;
using ChallengeApp;

Console.WriteLine("Witam w Programie MtW do oceny Pracownika");
Console.WriteLine("=========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Rafał", "Stefański",'M', 32);
employee.AddGrade(40);
employee.AddGrade(60);
employee.AddGrade(80);
employee.AddGrade(50);

//var manager = new Manager("Sebastian", "Bąk", 'M', 36);
while (true)
{
  Console.WriteLine("Wpisz kolejną ocene Pracownika:  ");
   var input = Console.ReadLine();
   if (input == "Q" || input == "q")
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
//var statistics = manager.GetStatistics();

//Console.WriteLine();
//Console.WriteLine($"Average: {statistics.Average}");
//Console.WriteLine($"Max: {statistics.Max}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"AverageNumber: {statistics.AverageNumber}");
