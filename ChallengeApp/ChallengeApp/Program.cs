using ChallengeApp;

//------------------------Creating Employees-----------------------------------------

Employee employee1 = new Employee("Jan", "Kowalski", 51);
Employee employee2 = new Employee("Monika", "Kowalczyk", 42);
Employee employee3 = new Employee("Zuzanna", "Nowakowska", 30);

//---------------------Adding Points to Employees------------------------------------

employee1.AdScore(1);
employee1.AdScore(2);
employee1.AdScore(3);
employee1.AdScore(4);
employee1.AdScore(5);

employee2.AdScore(2);
employee2.AdScore(3);
employee2.AdScore(4);
employee2.AdScore(5);
employee2.AdScore(6);

employee3.AdScore(3);
employee3.AdScore(4);
employee3.AdScore(5);
employee3.AdScore(6);
employee3.AdScore(7);

//-----------------------Adding Employees to The List------------------------------------------

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

//-------------------Creating Variables To Store Maximum Values-------------------------------

int MaxResult = -1;
Employee eeWithMaxResult = null;

//---------Creating Loop For Finding Employee With Max Total Points-------------------------

foreach (Employee employee in employees)
{
    if (employee.Result > MaxResult)
    {
        MaxResult = employee.Result;
        eeWithMaxResult = employee;
    }
}

//-----------Printing Employee With Max Total Points------------------------------------

Console.WriteLine("Najlepszym pracownikiem jest: "
    + eeWithMaxResult.Name + " " + eeWithMaxResult.Surname
    + ", wiek: " + eeWithMaxResult.Age + ", suma punktow: "
    + eeWithMaxResult.Result);