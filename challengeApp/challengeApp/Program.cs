using challengeApp;

Employee employee1 = new Employee("Rafał", "Stefański", 32 ); 
Employee employee2 = new Employee("Mateusz", "Zieliński", 27 );
Employee employee3 = new Employee("Natalia", "Mucha", 37);

employee1.AddScore(8);
employee1.AddScore(9);
employee1.AddScore(7);
employee1.AddScore(9);
employee1.AddScore(10);


employee2.AddScore(7);
employee2.AddScore(6);
employee2.AddScore(4);
employee2.AddScore(3);
employee2.AddScore(6);

employee3.AddScore(3);
employee3.AddScore(5);
employee3.AddScore(7);
employee3.AddScore(8);
employee3.AddScore(7);

 var result = employee1.Result;
var result1 = employee2.Result;
var result2 = employee3.Result;


List<Employee> employees = new List<Employee>() 
{
employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;

        Console.WriteLine("Pracownik otrzymał najwiecej punktów:" + result + " Imie: " + employeeWithMaxResult.Name + " Nazwisko: " + employeeWithMaxResult.Surname + " Wiek: " + employeeWithMaxResult.Age);
        Console.ReadLine();

    }
    

}
