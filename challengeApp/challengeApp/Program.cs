using challengeApp;

var employee = new Employee("Rafał", "Stefański", 32);

employee.AddGrade(6f);
employee.AddGrade(5);
employee.AddGrade(-2);
employee.AddGrade(7);
employee.AddGrade(5);

var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine("Wyniki dla Metody GetStatistics: ");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine( $"Max: {statistics.Max}");

Console.WriteLine("Wyniki dla Metody GetStatisticsWithForEach: ");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine("Wyniki dla Metody GetStatisticsWithFor: ");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine("Wyniki dla Metody GetStatisticsWithDoWhile: ");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

Console.WriteLine("Wyniki dla Metody GetStatisticsWithWhile:");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");


