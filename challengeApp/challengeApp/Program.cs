using challengeApp;

Employee employee1 = new Employee("Rafał", "Stefański", 32 ); 
Employee employee2 = new Employee("Mateusz", "Zieliński", 27 );
Employee employee3 = new Employee("Natalia", "Mucha", 26);

employee1.AddScore(1);
employee1.AddScore(1);
employee1.AddScore(1);
employee1.AddScore(1);
employee1.AddScore(1);


employee2.AddScore(7);
employee2.AddScore(6);
employee2.AddScore(4);
employee2.AddScore(3);
employee2.AddScore(6);

employee3.AddScore(4);
employee3.AddScore(2);
employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(6);

List<Employee> employees = new List<Employee>() 
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if (employee.Result > maxResult)
    {

        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
    
           
    

}
Console.WriteLine("Pracownik otrzymał najwiecej punktów:" + employeeWithMaxResult.Result);
Console.WriteLine(" Imie: " + employeeWithMaxResult.Name + " Nazwisko: " + employeeWithMaxResult.Surname + " Wiek: " + employeeWithMaxResult.Age + " lat");
Console.ReadLine();
