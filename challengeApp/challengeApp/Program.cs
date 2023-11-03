using challengeApp;

var employee = new Employee("Rafał", "Stefański", 32);

employee.AddGrade("Sebastian");
employee.AddGrade("4000");
employee.AddGrade(2);
employee.AddGrade(7);
employee.AddGrade(5);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine( $"Max: {statistics.Max}");

