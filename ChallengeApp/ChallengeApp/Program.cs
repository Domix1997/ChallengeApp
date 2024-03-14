using ChallengeApp;

Employee employee1 = new Employee("Dominik", "Warchol", 27);
Employee employee2 = new Employee("Jan", "Kowalski", 31);
Employee employee3 = new Employee("Magdalena", "Jaśkowiak", 29);

employee1.AddScore(2);
employee1.AddScore(5);
employee1.AddScore(8);
employee1.AddScore(5);
employee1.AddScore(8);

employee2.AddScore(4);
employee2.AddScore(6);
employee2.AddScore(9);
employee2.AddScore(6);
employee2.AddScore(9);

employee3.AddScore(2);
employee3.AddScore(7);
employee3.AddScore(5);
employee3.AddScore(7);
employee3.AddScore(5);


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;

Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("======================");
Console.WriteLine("   NAJLEPSZY GRACZ: ");
Console.WriteLine(employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " | WIEK " + employeeWithMaxResult.Age);
Console.WriteLine("======================");
Console.WriteLine("   SUMA PUNKTÓW: ");
Console.WriteLine("    " + maxResult + " PUNKTÓW");
Console.WriteLine("======================");