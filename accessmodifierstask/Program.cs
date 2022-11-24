using ClassLibrary;

namespace accessmodifierstask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee Fateh = new Employee("Fateh", "Aliverdiev", 500);
            Employee Ramal = new Employee("Ramal", "Fatullayevh", 3000);
            Employee Ehtiram = new Employee("Ehtiram", "Shukurov", 700);
            Employee Elxan = new Employee("Elxan", "Mammadli");
            Department AzTU = new Department("AzTU",3,2500);
            AzTU.AddEmployee(Fateh);
            AzTU.AddEmployee(Ramal);
            AzTU.AddEmployee(Ehtiram);
            AzTU.AddEmployee(Elxan);
            AzTU.GetDepartmentEmployeeInfo();
        }
    }
}